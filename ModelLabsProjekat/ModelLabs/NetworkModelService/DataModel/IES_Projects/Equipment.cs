using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTN.Services.NetworkModelService.DataModel.IES_Projects
{
    public class Equipment : PowerSystemResource
    {
        private bool aggregate;
        private bool normallyInService;
        public Equipment(long globalId) : base(globalId)
        {
        }

        public bool Aggregate { get => aggregate; set => aggregate = value; }
        public bool NormallyInService { get => normallyInService; set => normallyInService = value; }

        public override bool Equals(object obj)
        {
            return obj is Equipment equipment &&
                   base.Equals(obj) &&
                   aggregate == equipment.aggregate &&
                   normallyInService == equipment.normallyInService;
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
                case ModelCode.EQ_AGGR:
                case ModelCode.EQ_NIS:
                    return true;

                default:
                    return base.HasProperty(t);

            }
        }

        public override void GetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.EQ_AGGR:
                    property.SetValue(aggregate);
                    break;

                case ModelCode.EQ_NIS:
                    property.SetValue(normallyInService);
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
                case ModelCode.EQ_AGGR:
                    aggregate = property.AsBool();
                    break;

                case ModelCode.EQ_NIS:
                    normallyInService = property.AsBool();
                    break;

                default:
                    base.SetProperty(property);
                    break;
            }
        }

        #endregion IAccess implementation
    }
}
