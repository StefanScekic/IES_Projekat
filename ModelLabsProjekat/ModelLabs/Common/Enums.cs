using System;

namespace FTN.Common
{	
	public enum PhaseCode : short
	{
		Unknown = 0x0,
		N = 0x1,
		C = 0x2,
		CN = 0x3,
		B = 0x4,
		BN = 0x5,
		BC = 0x6,
		BCN = 0x7,
		A = 0x8,
		AN = 0x9,
		AC = 0xA,
		ACN = 0xB,
		AB = 0xC,
		ABN = 0xD,
		ABC = 0xE,
		ABCN = 0xF
	}
	
	public enum RegulatingControlModeKind : short
	{
        Unknown = 0,
        ActivePower = 1, //Active power is specified.
		Admittance = 2, //Admittance is specified.
		CurrentFlow = 3, //Current flow is specified.
		Fixed = 4, //The regulation mode is fixed, and thus not regulating.
		PowerFactor = 5, //Power factor is specified.
		ReactivePower = 6, //Reactive power is specified.
		Temperature = 7, //Control switches on/off based on the local temperature (i.e., a thermostat).
		TimeScheduled = 8, //Control switches on/off by time of day. The times may change on the weekend, or in different seasons.
		Voltage = 9, //Voltage is specified.
	}

    public enum UnitSymbol
    {
        Unknown = 0,
        A = 1,       // Current in ampere.
        F = 2,       // Capacitance in farad.
        H = 3,       // Inductance in henry.
        Hz = 4,      // Frequency in hertz.
        J = 5,       // Energy in joule.
        N = 6,       // Force in newton.
        Pa = 7,      // Pressure in pascal (n/m2).
        S = 8,       // Conductance in siemens.
        V = 9,       // Voltage in volt.
        VA = 10,     // Apparent power in volt ampere.
        VAh = 11,    // Apparent energy in volt ampere hours.
        VAr = 12,    // Reactive power in volt ampere reactive.
        VArh = 13,   // Reactive energy in volt ampere reactive hours.
        W = 14,      // Active power in watt.
        Wh = 15,     // Real energy in watt hours.
        deg = 16,    // Plane angle in degrees.
        degC = 17,   // Relative temperature in degrees Celsius.
        g = 18,      // Mass in gram.
        h = 19,      // Time in hours.
        m = 20,      // Length in meter.
        m2 = 21,     // Area in square meters.
        m3 = 22,     // Volume in cubic meters.
        min = 23,    // Time in minutes.
        none = 24,   // Dimensionless quantity, e.g., count, per unit, etc.
        ohm = 25,    // Resistance in ohm.
        rad = 26,    // Plane angle in radians.
        s = 27      // Time in seconds.
    }
}
