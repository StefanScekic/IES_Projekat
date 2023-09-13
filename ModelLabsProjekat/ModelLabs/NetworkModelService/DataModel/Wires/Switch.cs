﻿using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;
using FTN.Services.NetworkModelService.DataModel.IES_Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTN.Services.NetworkModelService.DataModel.Wires
{
    public class Switch : ConductingEquipment
    {
        private bool normalOpen;
        private float ratedCurrent;
        private bool retained;
        private int switchOnCount;
        private DateTime switchOnDate;
        private List<long> switchSchedules = new List<long>();

        public Switch(long globalId) : base(globalId)
        {
        }

        public bool NormalOpen { get => normalOpen; set => normalOpen = value; }
        public float RatedCurrent { get => ratedCurrent; set => ratedCurrent = value; }
        public bool Retained { get => retained; set => retained = value; }
        public int SwitchOnCount { get => switchOnCount; set => switchOnCount = value; }
        public DateTime SwitchOnDate { get => switchOnDate; set => switchOnDate = value; }
        public List<long> SwitchSchedules { get => switchSchedules; set => switchSchedules = value; }

        public override bool Equals(object obj)
        {
            return obj is Switch @switch &&
                   base.Equals(obj) &&
                   normalOpen == @switch.normalOpen &&
                   ratedCurrent == @switch.ratedCurrent &&
                   retained == @switch.retained &&
                   switchOnCount == @switch.switchOnCount &&
                   switchOnDate == @switch.switchOnDate &&
                   CompareHelper.CompareLists(@switch.switchSchedules, switchSchedules);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #region IAccess implementation

        public override bool HasProperty(ModelCode t)
        {
            switch (t)
            {
                case ModelCode.SWITCH_NORMOP:
                case ModelCode.SWITCH_RETAINED:
                case ModelCode.SWITCH_SWONC:
                case ModelCode.SWITCH_SWOND:
                case ModelCode.SWITCH_RC:
                case ModelCode.SWITCH_SWSCH:
                    return true;

                default:
                    return base.HasProperty(t);

            }
        }

        public override void GetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.SWITCH_NORMOP:
                    property.SetValue(normalOpen);
                    break;

                case ModelCode.SWITCH_RETAINED:
                    property.SetValue(retained);
                    break;

                case ModelCode.SWITCH_SWONC:
                    property.SetValue(switchOnCount);
                    break;

                case ModelCode.SWITCH_SWOND:
                    property.SetValue(switchOnDate);
                    break;

                case ModelCode.SWITCH_RC:
                    property.SetValue(ratedCurrent);
                    break;

                case ModelCode.SWITCH_SWSCH:
                    property.SetValue(switchSchedules);
                    break;

                default:
                    base.GetProperty(property);
                    break;
            }
        }

        public override void SetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.SWITCH_NORMOP:
                    normalOpen = property.AsBool();
                    break;

                case ModelCode.SWITCH_RETAINED:
                    retained = property.AsBool();
                    break;

                case ModelCode.SWITCH_SWONC:
                    switchOnCount = property.AsInt();
                    break;

                case ModelCode.SWITCH_SWOND:
                    switchOnDate = property.AsDateTime();
                    break;

                case ModelCode.SWITCH_RC:
                    ratedCurrent = property.AsFloat();
                    break;

                default:
                    base.SetProperty(property);
                    break;
            }
        }

        #endregion IAccess implementation

        #region IReference implementation

        public override bool IsReferenced
        {
            get
            {
                return switchSchedules.Count != 0 || base.IsReferenced;
            }
        }

        public override void GetReferences(Dictionary<ModelCode, List<long>> references, TypeOfReference refType)
        {          

            if (switchSchedules != null && switchSchedules.Count != 0 && (refType == TypeOfReference.Target || refType == TypeOfReference.Both))
            {
                references[ModelCode.SWITCH_SWSCH] = switchSchedules.GetRange(0, switchSchedules.Count);
            }

            base.GetReferences(references, refType);
        }

        public override void AddReference(ModelCode referenceId, long globalId)
        {
            switch (referenceId)
            {
                case ModelCode.SWITCHSCH_SWITCH:
                    switchSchedules.Add(globalId);
                    break;

                default:
                    base.AddReference(referenceId, globalId);
                    break;
            }
        }

        public override void RemoveReference(ModelCode referenceId, long globalId)
        {
            switch (referenceId)
            {
                case ModelCode.SWITCHSCH_SWITCH:

                    if (switchSchedules.Contains(globalId))
                    {
                        switchSchedules.Remove(globalId);
                    }
                    else
                    {
                        CommonTrace.WriteTrace(CommonTrace.TraceWarning, "Entity (GID = 0x{0:x16}) doesn't contain reference 0x{1:x16}.", this.GlobalId, globalId);
                    }

                    break;

                default:
                    base.RemoveReference(referenceId, globalId);
                    break;
            }
        }

        #endregion IReference implementation
    }
}
