using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTN.Services.NetworkModelService.DataModel.IES_Projects
{
    public class RegulatingControl : PowerSystemResource
    {
        private bool discrete;
        private RegulatingControlModeKind mode;
        private PhaseCode monitoredPhase;
        private float targetRange;
        private float targetValue;
        private List<long> regulationSchedule = new List<long>();

        public RegulatingControl(long globalId) : base(globalId)
        {
        }

        public bool Discrete { get => discrete; set => discrete = value; }
        public RegulatingControlModeKind Mode { get => mode; set => mode = value; }
        public PhaseCode MonitoredPhase { get => monitoredPhase; set => monitoredPhase = value; }
        public float TargetRange { get => targetRange; set => targetRange = value; }
        public float TargetValue { get => targetValue; set => targetValue = value; }
        public List<long> RegulationSchedule { get => regulationSchedule; set => regulationSchedule = value; }

        public override bool Equals(object obj)
        {
            return obj is RegulatingControl control &&
                   base.Equals(obj) &&
                   discrete == control.discrete &&
                   mode == control.mode &&
                   monitoredPhase == control.monitoredPhase &&
                   targetRange == control.targetRange &&
                   targetValue == control.targetValue &&
                   CompareHelper.CompareLists(control.regulationSchedule, regulationSchedule);
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
                case ModelCode.REGCTRL_DISCRETE:
                case ModelCode.REGCTRL_MODE:
                case ModelCode.REGCTRL_MONITOREDPH:
                case ModelCode.REGCTRL_TARGETRANGE:
                case ModelCode.REGCTRL_TARGETVAL:
                case ModelCode.REGCTRL_REGSCH:
                    return true;

                default:
                    return base.HasProperty(t);

            }
        }

        public override void GetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.REGCTRL_DISCRETE:
                    property.SetValue(discrete);
                    break;

                case ModelCode.REGCTRL_MODE:
                    property.SetValue((short)mode);
                    break;

                case ModelCode.REGCTRL_MONITOREDPH:
                    property.SetValue((short)monitoredPhase);
                    break;

                case ModelCode.REGCTRL_TARGETRANGE:
                    property.SetValue(targetRange);
                    break;

                case ModelCode.REGCTRL_TARGETVAL:
                    property.SetValue(targetValue);
                    break;

                case ModelCode.REGCTRL_REGSCH:
                    property.SetValue(regulationSchedule);
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
                case ModelCode.REGCTRL_DISCRETE:
                    discrete = property.AsBool();
                    break;

                case ModelCode.REGCTRL_MODE:
                    mode = (RegulatingControlModeKind)property.AsEnum();
                    break;

                case ModelCode.REGCTRL_MONITOREDPH:
                    monitoredPhase = (PhaseCode)property.AsEnum();
                    break;

                case ModelCode.REGCTRL_TARGETRANGE:
                    targetRange = property.AsFloat();
                    break;

                case ModelCode.REGCTRL_TARGETVAL:
                    targetValue = property.AsFloat();
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
                return regulationSchedule.Count != 0 || base.IsReferenced;
            }
        }

        public override void GetReferences(Dictionary<ModelCode, List<long>> references, TypeOfReference refType)
        {            

            if (regulationSchedule != null && regulationSchedule.Count != 0 && (refType == TypeOfReference.Target || refType == TypeOfReference.Both))
            {
                references[ModelCode.REGCTRL_REGSCH] = regulationSchedule.GetRange(0, regulationSchedule.Count);
            }

            base.GetReferences(references, refType);
        }

        public override void AddReference(ModelCode referenceId, long globalId)
        {
            switch (referenceId)
            {
                case ModelCode.REGSCH_REGCTRL:
                    regulationSchedule.Add(globalId);
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
                case ModelCode.REGSCH_REGCTRL:

                    if (regulationSchedule.Contains(globalId))
                    {
                        regulationSchedule.Remove(globalId);
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
