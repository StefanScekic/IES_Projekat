//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FTN {
    using System;
    using FTN;
    using System.Collections.Generic;
    
    
    /// Group of similar days.   For example it could be used to represent weekdays, weekend, or holidays.
    public class DayType : IdentifiedObject {
        
        /// Schedules that use this DayType.
        private List<SeasonDayTypeSchedule> cim_SeasonDayTypeSchedules = new List<SeasonDayTypeSchedule>();
        
        private const bool isSeasonDayTypeSchedulesMandatory = false;
        
        private const string _SeasonDayTypeSchedulesPrefix = "cim";
        
        public virtual List<SeasonDayTypeSchedule> SeasonDayTypeSchedules {
            get {
                return this.cim_SeasonDayTypeSchedules;
            }
            set {
                this.cim_SeasonDayTypeSchedules = value;
            }
        }
        
        public virtual bool SeasonDayTypeSchedulesHasValue {
            get {
                return this.cim_SeasonDayTypeSchedules != null;
            }
        }
        
        public static bool IsSeasonDayTypeSchedulesMandatory {
            get {
                return isSeasonDayTypeSchedulesMandatory;
            }
        }
        
        public static string SeasonDayTypeSchedulesPrefix {
            get {
                return _SeasonDayTypeSchedulesPrefix;
            }
        }
    }
}