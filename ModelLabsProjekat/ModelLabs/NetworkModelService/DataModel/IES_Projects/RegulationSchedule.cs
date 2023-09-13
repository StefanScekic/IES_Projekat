using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTN.Services.NetworkModelService.DataModel.IES_Projects
{
    public class RegulationSchedule : SeasonDayTypeSchedule
    {
        private long regulatingControl = 0;
        public RegulationSchedule(long globalId) : base(globalId)
        {
        }

        public long RegulatingControl { get => regulatingControl; set => regulatingControl = value; }

        public override bool Equals(object obj)
        {
            return obj is RegulationSchedule schedule &&
                   base.Equals(obj) &&
                   regulatingControl == schedule.regulatingControl;
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
                case ModelCode.REGSCH_REGCTRL:
                    return true;

                default:
                    return base.HasProperty(t);

            }
        }

        public override void GetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.REGSCH_REGCTRL:
                    property.SetValue(regulatingControl);
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
                case ModelCode.REGSCH_REGCTRL:
                    regulatingControl = property.AsReference();
                    break;

                default:
                    base.SetProperty(property);
                    break;
            }
        }

        #endregion IAccess implementation

        #region IReference implementation               

        public override void GetReferences(Dictionary<ModelCode, List<long>> references, TypeOfReference refType)
        {
            if (regulatingControl != 0 && (refType == TypeOfReference.Reference || refType == TypeOfReference.Both))
            {
                references[ModelCode.REGSCH_REGCTRL] = new List<long>();
                references[ModelCode.REGSCH_REGCTRL].Add(regulatingControl);
            }

            base.GetReferences(references, refType);
        }

        #endregion IReference implementation
    }
}
