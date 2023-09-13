using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTN.Services.NetworkModelService.DataModel.IES_Projects
{
    public class BasicIntervalSchedule : IdentifiedObject
    {
        private DateTime startTime;
        private UnitSymbol value1Unit;
        public BasicIntervalSchedule(long globalId) : base(globalId)
        {
        }

        public DateTime StartTime { get => startTime; set => startTime = value; }
        public UnitSymbol Value1Unit { get => value1Unit; set => value1Unit = value; }

        public override bool Equals(object obj)
        {
            return obj is BasicIntervalSchedule schedule &&
                   base.Equals(obj) &&
                   startTime == schedule.startTime &&
                   value1Unit == schedule.value1Unit;
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
                case ModelCode.BIS_STARTTIME:
                case ModelCode.BIS_V1U:
                    return true;

                default:
                    return base.HasProperty(t);

            }
        }

        public override void GetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.BIS_STARTTIME:
                    property.SetValue(startTime);
                    break;

                case ModelCode.BIS_V1U:
                    property.SetValue((short)value1Unit);
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
                case ModelCode.BIS_STARTTIME:
                    startTime = property.AsDateTime();
                    break;

                case ModelCode.BIS_V1U:
                    value1Unit = (UnitSymbol)property.AsEnum();
                    break;

                default:
                    base.SetProperty(property);
                    break;
            }
        }

        #endregion IAccess implementation
    }
}
