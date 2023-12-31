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
    
    
    /// The schedule has time points where the time between them is constant.
    public class RegularIntervalSchedule : BasicIntervalSchedule {
        
        /// The regular interval time point data values that define this schedule.
        private List<RegularTimePoint> cim_TimePoints = new List<RegularTimePoint>();
        
        private const bool isTimePointsMandatory = true;
        
        private const string _TimePointsPrefix = "cim";
        
        public virtual List<RegularTimePoint> TimePoints {
            get {
                return this.cim_TimePoints;
            }
            set {
                this.cim_TimePoints = value;
            }
        }
        
        public virtual bool TimePointsHasValue {
            get {
                return this.cim_TimePoints != null;
            }
        }
        
        public static bool IsTimePointsMandatory {
            get {
                return isTimePointsMandatory;
            }
        }
        
        public static string TimePointsPrefix {
            get {
                return _TimePointsPrefix;
            }
        }
    }
}
