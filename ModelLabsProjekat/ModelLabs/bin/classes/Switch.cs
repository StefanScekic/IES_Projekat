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
    
    
    /// A generic device designed to close, or open, or both, one or more electric circuits.
    public class Switch : ConductingEquipment {
        
        /// The attribute is used in cases when no Measurement for the status value is present. If the Switch has a status measurment the Discrete.normalValue is expected to match with the Switch.normalOpen.
        private System.Boolean? cim_normalOpen;
        
        private const bool isNormalOpenMandatory = false;
        
        private const string _normalOpenPrefix = "cim";
        
        /// The maximum continuous current carrying capacity in amps governed by the device material and construction.
        private System.Single? cim_ratedCurrent;
        
        private const bool isRatedCurrentMandatory = false;
        
        private const string _ratedCurrentPrefix = "cim";
        
        /// Branch is retained in a bus branch model.
        private System.Boolean? cim_retained;
        
        private const bool isRetainedMandatory = false;
        
        private const string _retainedPrefix = "cim";
        
        /// The switch on count since the switch was last reset or initialized.
        private System.Int32? cim_switchOnCount;
        
        private const bool isSwitchOnCountMandatory = false;
        
        private const string _switchOnCountPrefix = "cim";
        
        /// The date and time when the switch was last switched on.
        private System.DateTime? cim_switchOnDate;
        
        private const bool isSwitchOnDateMandatory = false;
        
        private const string _switchOnDatePrefix = "cim";
        
        /// A Switch can be associated with SwitchSchedules.
        private List<SwitchSchedule> cim_SwitchSchedules = new List<SwitchSchedule>();
        
        private const bool isSwitchSchedulesMandatory = false;
        
        private const string _SwitchSchedulesPrefix = "cim";
        
        public virtual bool NormalOpen {
            get {
                return this.cim_normalOpen.GetValueOrDefault();
            }
            set {
                this.cim_normalOpen = value;
            }
        }
        
        public virtual bool NormalOpenHasValue {
            get {
                return this.cim_normalOpen != null;
            }
        }
        
        public static bool IsNormalOpenMandatory {
            get {
                return isNormalOpenMandatory;
            }
        }
        
        public static string NormalOpenPrefix {
            get {
                return _normalOpenPrefix;
            }
        }
        
        public virtual float RatedCurrent {
            get {
                return this.cim_ratedCurrent.GetValueOrDefault();
            }
            set {
                this.cim_ratedCurrent = value;
            }
        }
        
        public virtual bool RatedCurrentHasValue {
            get {
                return this.cim_ratedCurrent != null;
            }
        }
        
        public static bool IsRatedCurrentMandatory {
            get {
                return isRatedCurrentMandatory;
            }
        }
        
        public static string RatedCurrentPrefix {
            get {
                return _ratedCurrentPrefix;
            }
        }
        
        public virtual bool Retained {
            get {
                return this.cim_retained.GetValueOrDefault();
            }
            set {
                this.cim_retained = value;
            }
        }
        
        public virtual bool RetainedHasValue {
            get {
                return this.cim_retained != null;
            }
        }
        
        public static bool IsRetainedMandatory {
            get {
                return isRetainedMandatory;
            }
        }
        
        public static string RetainedPrefix {
            get {
                return _retainedPrefix;
            }
        }
        
        public virtual int SwitchOnCount {
            get {
                return this.cim_switchOnCount.GetValueOrDefault();
            }
            set {
                this.cim_switchOnCount = value;
            }
        }
        
        public virtual bool SwitchOnCountHasValue {
            get {
                return this.cim_switchOnCount != null;
            }
        }
        
        public static bool IsSwitchOnCountMandatory {
            get {
                return isSwitchOnCountMandatory;
            }
        }
        
        public static string SwitchOnCountPrefix {
            get {
                return _switchOnCountPrefix;
            }
        }
        
        public virtual System.DateTime SwitchOnDate {
            get {
                return this.cim_switchOnDate.GetValueOrDefault();
            }
            set {
                this.cim_switchOnDate = value;
            }
        }
        
        public virtual bool SwitchOnDateHasValue {
            get {
                return this.cim_switchOnDate != null;
            }
        }
        
        public static bool IsSwitchOnDateMandatory {
            get {
                return isSwitchOnDateMandatory;
            }
        }
        
        public static string SwitchOnDatePrefix {
            get {
                return _switchOnDatePrefix;
            }
        }
        
        public virtual List<SwitchSchedule> SwitchSchedules {
            get {
                return this.cim_SwitchSchedules;
            }
            set {
                this.cim_SwitchSchedules = value;
            }
        }
        
        public virtual bool SwitchSchedulesHasValue {
            get {
                return this.cim_SwitchSchedules != null;
            }
        }
        
        public static bool IsSwitchSchedulesMandatory {
            get {
                return isSwitchSchedulesMandatory;
            }
        }
        
        public static string SwitchSchedulesPrefix {
            get {
                return _SwitchSchedulesPrefix;
            }
        }
    }
}
