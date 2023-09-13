using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTN.Services.NetworkModelService.DataModel.Wires
{
    public class ProtectedSwitch : Switch
    {
        private float breakingCapacity;
        public ProtectedSwitch(long globalId) : base(globalId)
        {
        }

        public float BreakingCapacity { get => breakingCapacity; set => breakingCapacity = value; }

        public override bool Equals(object obj)
        {
            return obj is ProtectedSwitch @switch &&
                   base.Equals(obj) &&
                   breakingCapacity == @switch.breakingCapacity;
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
                case ModelCode.PROSW_BRCAP:
                    return true;

                default:
                    return base.HasProperty(t);

            }
        }

        public override void GetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.PROSW_BRCAP:
                    property.SetValue(breakingCapacity);
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
                case ModelCode.PROSW_BRCAP:
                    breakingCapacity = property.AsFloat();
                    break;

                default:
                    base.SetProperty(property);
                    break;
            }
        }

        #endregion IAccess implementation

    }
}
