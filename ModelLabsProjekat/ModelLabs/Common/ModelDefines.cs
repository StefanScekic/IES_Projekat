using System;
using System.Collections.Generic;
using System.Text;

namespace FTN.Common
{
	
	public enum DMSType : short
	{		
		MASK_TYPE							= unchecked((short)0xFFFF),        	

		BREAKER									= 0x0001,
		DT										= 0x0002,
		RTP										= 0x0003,
		REGCTRL									= 0x0004,
		REGSCH									= 0x0005,
		SEASON									= 0x0006,
		SWITCHSCH								= 0x0007,
	}

    [Flags]
	public enum ModelCode : long
	{
        //CORE
        IDOBJ                                       = 0x1000000000000000,
        IDOBJ_GID                                   = 0x1000000000000104,
        IDOBJ_MRID                                  = 0x1000000000000207,
        IDOBJ_ALNAME                                = 0x1000000000000307,
        IDOBJ_NAME                                  = 0x1000000000000407,

        RTP                                         = 0x1200000000030000,
        RTP_SEQNUM                                  = 0x1200000000030103,
        RTP_V1                                      = 0x1200000000030205,
        RTP_V2                                      = 0x1200000000030305,
        RTP_INTERVALSCH                             = 0x1200000000030409,

        PSR                                         = 0x1500000000000000,

        //Wires
        SWITCH                                      = 0x1521100000000000,
        SWITCH_NORMOP                               = 0x1521100000000101,
        SWITCH_RETAINED                             = 0x1521100000000201,
        SWITCH_SWONC                                = 0x1521100000000303,
        SWITCH_SWOND                                = 0x1521100000000408,
        SWITCH_RC                                   = 0x1521100000000505,   
        SWITCH_SWSCH                                = 0x1521100000000619,

        PROSW                                       = 0x1521110000000000,
        PROSW_BRCAP                                 = 0x1521110000000105,

        //IES_PROJECTS
        BIS                                         = 0x1100000000000000,
        BIS_STARTTIME                               = 0x1100000000000108,
        BIS_V1U                                     = 0x110000000000020a,

        RIS                                         = 0x1110000000000000,
        RIS_TP                                      = 0x1110000000000119,

        SEASONDTS                                   = 0x1111000000000000,
        SEASONDTS_DT                                = 0x1111000000000109,
        SEASONDTS_SEASON                            = 0x1111000000000209,

        SWITCHSCH                                   = 0x1111100000070000,
        SWITCHSCH_SWITCH                            = 0x1111100000070109,

        REGSCH                                      = 0x1111200000050000,
        REGSCH_REGCTRL                              = 0x1111200000050109,

        REGCTRL                                     = 0x1510000000040000,
        REGCTRL_DISCRETE                            = 0x1510000000040101,
        REGCTRL_MODE                                = 0x151000000004020a,
        REGCTRL_MONITOREDPH                         = 0x151000000004030a,
        REGCTRL_TARGETRANGE                         = 0x1510000000040405,
        REGCTRL_TARGETVAL                           = 0x1510000000040505,
        REGCTRL_REGSCH                              = 0x1510000000040619,

        EQ                                          = 0x1520000000000000,
        EQ_AGGR                                     = 0x1520000000000101,
        EQ_NIS                                      = 0x1520000000000201,

        CONDEQ                                      = 0x1521000000000000,

        BREAKER                                     = 0x1521111000010000,
        BREAKER_ITT                                 = 0x1521111000010105,

        //LOADMODEL
        DT                                          = 0x1300000000020000,
        DT_SEASONDTSCH                              = 0x1300000000020119,
        
        SEASON                                      = 0x1400000000060000,
        SEASON_ENDDATE                              = 0x1400000000060108,
        SEASON_STARTDATE                            = 0x1400000000060208,
        SEASON_SEASONDTSCH                          = 0x1400000000060319,

    }

    [Flags]
	public enum ModelCodeMask : long
	{
		MASK_TYPE			 = 0x00000000ffff0000,
		MASK_ATTRIBUTE_INDEX = 0x000000000000ff00,
		MASK_ATTRIBUTE_TYPE	 = 0x00000000000000ff,

		MASK_INHERITANCE_ONLY = unchecked((long)0xffffffff00000000),
		MASK_FIRSTNBL		  = unchecked((long)0xf000000000000000),
		MASK_DELFROMNBL8	  = unchecked((long)0xfffffff000000000),		
	}																		
}


