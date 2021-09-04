
;////////////////////////////////////////////////////////////////////////////////////////////
;//
;// PVars.h
;// Created on: 01/09/2012  Author: Josh Kelley
;// 
;// P Variable Definitions
;//
;////////////////////////////////////////////////////////////////////////////////////////////



;////////////////////////////////////////////////////////////////////////
;//			Error Looging p-Vars P1-10
;////////////////////////////////////////////////////////////////////////
#define pUmacError	P1

;//Error Logging Vars for the SetErrorWord PLC
#define pSlotAvailable			P2 ;//Boolean
#define pErrorSet				P3;//Boolean
#define pErrorChckIndex			P4 ;//check Index
#define pErrorLogged			P5 ;//Boolean
#define pErrorIndex				P6 ;//Indexer used to cycle between 7510 -> 7514
#define pErrorStartLoc			P7 ;//This Gets set to 7510 mSystemError0 m7510

;//Error Logging Vars For the AxisErros plc
#define pAxisErrored			P8 
#define pAxisEnableCount		P9


;////////////////////////////////////////////////////////////////////////
;//			SEWING PVARS  p20-p50
;////////////////////////////////////////////////////////////////////////

;////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
;// Rev 2 Definitions
 
#define pSewingEnabled		P20
#define pStitchIdx			P21;	//Indexer for Stitch Counting
#define pStitchRampRate		P22;	// Calculated ramping rate  = ((pSlowStichTimeSlice - pStitchTimeSlice) / pSlowStitchRampCount) Used by Left And Right Head
#define pRampStitchIdx		P23;	//Indexer for ramping the stitch rate Used By Left And Right Head

;//Sleeve Variables
#define pStartPosition_mm	p24;	//The Start Position to Begin the Stitch
#define pMiddleGap_mm		P25;	//The Gap between Twin Stitch Sleeves in mm

;//Left Head Deployment Line Variables
#define pLHeadFiberTension_cnts	P26;	//Fiber Tension left Head
#define pLHeadStitchCnt			P27;	//The Total Stitch Count For the Left Head (calculated within HMI)
#define pLHeadStitchTimeSlice	P28;	//Calculated Time Slice for PVT Moves with Left head (Calculated within HMI)
#define pLHeadStitchLength_mm	P29;	//The Stitch Length in mm for the Left Head (Calculated within HMI)

#define pLHeadSlowStitchTimeSlice	P30;	//Time Slice used during slow stitches
#define pLHeadSlowStitchCount		P31;	//The Number of stitches to hold the thread clamp for
#define pLHeadSlowStitchRampCount	P32;	//The Number of Stitches to Ramp from slow speed to Production Speed 	
#define pLHeadSlowStitchTension		P33;	//Fiber tension used during slow and ramp stitches

#define pLHeadUseAltStartTension	P34;	//Boolean to use Alt Tension at for slow and ramp stitches see LSD Sewing PMC's	
#define pLHeadSewLowStitchDensity	P35;	//Boolean value used by messageHandler PMC to Pick correct Sewing Program either HSD or LSD

;// Right Head Deployment Line Variables See Left Head Section for Definitions as these are the same but for the Right Head
#define pRHeadFiberTension_cnts	P36;
#define pRHeadStitchCnt			P37;
#define pRHeadStitchTimeSlice	P38; 
#define pRHeadStitchLength_mm	P39; 

#define pRHeadSlowStitchTimeSlice	P40;
#define pRHeadSlowStitchCount		P41;
#define pRHeadSlowStitchRampCount	P42;
#define pRHeadSlowStitchTension		P43;

#define pRHeadUseAltStartTension	P44;
#define pRHeadSewLowStitchDensity	P45;



;////////////////////////////////////////////////////////////////////////
;//			Home Offset PVars P50-P60
;////////////////////////////////////////////////////////////////////////

#define pLNeedleHomeOffset	P50;
#define pRNeedleHomeOffset	P51;
#define pLooperHomeOffset	P52;
#define pTraverseHomeOffset	P53;
#define pReverseLooperInstalled P54;

;////////////////////////////////////////////////////////////////////////
;//			Following Error Varaibles P60-P70
;////////////////////////////////////////////////////////////////////////
#define pLNeedleHomeFFE	P60;
#define pRNeedleHomeFFE	P61;
#define pLooperHomeFFE	P62;
#define pXAxisHomeFFE	P63;

#define pLNeedleFFE		P64;
#define pRNeedleFFE		P65;
#define pLooperFFE		P66;
#define pXAxisFFE		P67;

;//Define the Values
pLNeedleHomeFFE = 533;
pRNeedleHomeFFE = 533;
pLooperHomeFFE = 888;
pXAxisHomeFFE = 640;

pLNeedleFFE = 2666;
pRNeedleFFE = 2666;
pLooperFFE = 2666;
pXAxisFFE = 2560;

;////////////////////////////////////////////////////////////////////////
;//		X- Axis move to position Var used to calculate the middle gap distance for twin stitch sleeves
;////////////////////////////////////////////////////////////////////////

#define pXAxisMoveToPosition	P70;
#define pLooperDegTo0			P71;
#define pXAxisFeedRate_mm_Sec	P72;