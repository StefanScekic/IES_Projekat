using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTN.Services.NetworkModelService.DataModel.IES_Projects
{
    public class SwitchSchedule : SeasonDayTypeSchedule
    {
        private long _switch = 0;
        public SwitchSchedule(long globalId) : base(globalId)
        {
        }

        public long Switch { get => _switch; set => _switch = value; }

        public override bool Equals(object obj)
        {
            return obj is SwitchSchedule schedule &&
                   base.Equals(obj) &&
                   _switch == schedule._switch;
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
                case ModelCode.SWITCHSCH_SWITCH:
                    return true;

                default:
                    return base.HasProperty(t);

            }
        }

        public override void GetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.SWITCHSCH_SWITCH:
                    property.SetValue(_switch);
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
                case ModelCode.SWITCHSCH_SWITCH:
                    _switch = property.AsReference();
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
            if (_switch != 0 && (refType == TypeOfReference.Reference || refType == TypeOfReference.Both))
            {
                references[ModelCode.SWITCHSCH_SWITCH] = new List<long>();
                references[ModelCode.SWITCHSCH_SWITCH].Add(_switch);
            }

            base.GetReferences(references, refType);
        
        }

        #endregion IReference implementation
    }
}
