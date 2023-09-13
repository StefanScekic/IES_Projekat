using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTN.Services.NetworkModelService.DataModel.IES_Projects
{
    public class SeasonDayTypeSchedule : RegularIntervalSchedule
    {
        private long dayType = 0;
        private long season = 0;
        public SeasonDayTypeSchedule(long globalId) : base(globalId)
        {
        }

        public long DayType { get => dayType; set => dayType = value; }
        public long Season { get => season; set => season = value; }

        public override bool Equals(object obj)
        {
            return obj is SeasonDayTypeSchedule schedule &&
                   base.Equals(obj) &&
                   dayType == schedule.dayType &&
                   season == schedule.season;
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
                case ModelCode.SEASONDTS_DT:
                case ModelCode.SEASONDTS_SEASON:
                    return true;

                default:
                    return base.HasProperty(t);

            }
        }

        public override void GetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.SEASONDTS_DT:
                    property.SetValue(dayType);
                    break;
                case ModelCode.SEASONDTS_SEASON:
                    property.SetValue(season);
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
                case ModelCode.SEASONDTS_DT:
                    dayType = property.AsReference();
                    break;
                case ModelCode.SEASONDTS_SEASON:
                    season = property.AsReference();
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

            if (dayType != 0 && (refType == TypeOfReference.Reference || refType == TypeOfReference.Both))
            {
                references[ModelCode.SEASONDTS_DT] = new List<long>();
                references[ModelCode.SEASONDTS_DT].Add(dayType);
            }
            if (season != 0 && (refType == TypeOfReference.Reference || refType == TypeOfReference.Both))
            {
                references[ModelCode.SEASONDTS_SEASON] = new List<long>();
                references[ModelCode.SEASONDTS_SEASON].Add(season);
            }

            base.GetReferences(references, refType);
        }

        #endregion IReference implementation
    }
}
