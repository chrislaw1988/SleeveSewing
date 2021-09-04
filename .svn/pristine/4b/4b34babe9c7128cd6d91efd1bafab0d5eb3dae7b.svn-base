;////////////////////////////////////////////////////////////////////////////////////////////
;//
;// IO.h
;// Created on: 01/08/2012  Author: Josh Kelley
;// 
;// Machine contains (1) Acc-65E DIO Card with 24 I/0 Points at Base Address $7AC00
;// Machine contains (1) ACC-59E Analog IO Card with 8 ADC Channels and 8 Dac Channels At Base Address $079C00
;//
;// Maps M-Vars to Address space used by the IO Cards within the System Along with the IO variables
;//
;////////////////////////////////////////////////////////////////////////////////////////////



;// IO Bank and Control Register Mapping for Acc65E at Base Address $7AC00
M6900->Y:$07AC00,0,8 ;//I/O bits 0-7 (port A IC0) 
M6901->Y:$07AC01,0,8 ;//I/O bits 8-15 (port A IC0)
M6902->Y:$07AC02,0,8 ;//I/O bits 16-23 (port A IC0)
M6903->Y:$07AC03,0,8 ;//I/O bits 0-7 (port B IC0)
M6904->Y:$07AC04,0,8 ;//I/O bits 8-15 (port B IC0)
M6905->Y:$07AC05,0,8 ;//I/O bits 16-23 (port B IC0)
M6906->Y:$07AC06,0,8 ;//register selected
M6907->Y:$07AC07,0,8 ;//control register for Acc65E at base address $7AC00

;// Bit Level Mapping For Acc65E
M7000->Y:$07AC00,0,1 ;//Input 1 
M7001->Y:$07AC00,1,1 ;//Input 2 
M7002->Y:$07AC00,2,1 ;//Input 3 
M7003->Y:$07AC00,3,1 ;//Input 4 
M7004->Y:$07AC00,4,1 ;//Input 5 
M7005->Y:$07AC00,5,1 ;//Input 6 
M7006->Y:$07AC00,6,1 ;//Input 7 
M7007->Y:$07AC00,7,1 ;//Input 8 
M7008->Y:$07AC01,0,1 ;//Input 9
M7009->Y:$07AC01,1,1 ;//Input 10
M7010->Y:$07AC01,2,1 ;//Input 11 
M7011->Y:$07AC01,3,1 ;//Input 12 
M7012->Y:$07AC01,4,1 ;//Input 13 
M7013->Y:$07AC01,5,1 ;//Input 14 
M7014->Y:$07AC01,6,1 ;//Input 15 
M7015->Y:$07AC01,7,1 ;//Input 16 
M7016->Y:$07AC02,0,1 ;//Input 17 
M7017->Y:$07AC02,1,1 ;//Input 18 
M7018->Y:$07AC02,2,1 ;//Input 19 
M7019->Y:$07AC02,3,1 ;//Input 20 
M7020->Y:$07AC02,4,1 ;//Input 21 
M7021->Y:$07AC02,5,1 ;//Input 22 
M7022->Y:$07AC02,6,1 ;//Input 23 
M7023->Y:$07AC02,7,1 ;//Input 24

M7024->Y:$07AC03,0,1 ;//Output 1
M7025->Y:$07AC03,1,1 ;//Output 2
M7026->Y:$07AC03,2,1 ;//Output 3
M7027->Y:$07AC03,3,1 ;//Output 4
M7028->Y:$07AC03,4,1 ;//Output 5
M7029->Y:$07AC03,5,1 ;//Output 6
M7030->Y:$07AC03,6,1 ;//Output 7
M7031->Y:$07AC03,7,1 ;//Output 8
M7032->Y:$07AC04,0,1 ;//Output 9
M7033->Y:$07AC04,1,1 ;//Output 10
M7034->Y:$07AC04,2,1 ;//Output 11
M7035->Y:$07AC04,3,1 ;//Output 12
M7036->Y:$07AC04,4,1 ;//Output 13
M7037->Y:$07AC04,5,1 ;//Output 14
M7038->Y:$07AC04,6,1 ;//Output 15
M7039->Y:$07AC04,7,1 ;//Output 16
M7040->Y:$07AC05,0,1 ;//Output 17
M7041->Y:$07AC05,1,1 ;//Output 18
M7042->Y:$07AC05,2,1 ;//Output 19
M7043->Y:$07AC05,3,1 ;//Output 20
M7044->Y:$07AC05,4,1 ;//Output 21
M7045->Y:$07AC05,5,1 ;//Output 22
M7046->Y:$07AC05,6,1 ;//Output 23
M7047->Y:$07AC05,7,1 ;//Output 24

;////////////////////////////////////////////////////////////////////////
;// IO Bank Definitions
;////////////////////////////////////////////////////////////////////////
#define acc65E_Input_Bits_0_7		M6900;
#define acc65E_Input_Bits_8_15		M6901;
#define acc65E_Input_Bits_16_23		M6902;

#define acc65E_Output_Bits_0_7		M6903;
#define acc65E_Output_Bits_8_15		M6904;
#define acc65E_Output_Bits_16_23	M6905;

#define acc65E_Register_Select	M6906;
#define acc65E_Control_Register	M6907;

;////////////////////////////////////////////////////////////////////////
;// Bit level Input Definitions
;////////////////////////////////////////////////////////////////////////
#define iSystemEstopped	M7000



;////////////////////////////////////////////////////////////////////////
;// Bit level Output Definitions
;////////////////////////////////////////////////////////////////////////
#define oRegulatorOn		M7024
#define oLeftThreadClamp	M7025
#define oRightThreadClamp	M7026
#define oLeftSleeveClamp	M7027
#define oRightSleeveClamp	M7028
#define oNeedleBlock		M7029
#define oTailStockAdj		M7030
#define oSleeveTension		M7031

#define





;/////////////////////////////////////////////////////////////////////////////////////////////////////////////
;//
;//		ACC59E Analog IO Setup BASE ADDRESS OF $079C00
;//		Setup the Acc59E for Automatic Reading of the Demuxed ADC pairs
;//		We may use some ADC for servo feedback which requires the Auto Read
;//		Reference the Acc-59E manual 
;//		The system is not using the ADC channels
;//		The system is using DAC channels 1 and 2
;// 
;///////////////////////////////////////////////////////////////////////////////////////////////////////////


I5060 = 8 ;//A/D processing Ring Size set to Demux 8ADC pairs we only get the low bytes 

I5061,8=$1400 ;// ADC pairs 1 through 8 offset width: $1400 = $079C00-$78800
I5081=0 ;// ADC#1 Unipolar
I5082=1 ;// ADC#2 Unipolar
I5083=2 ;// ADC#3 Unipolar
I5084=3 ;// ADC#4 Unipolar
I5085=4 ;// ADC#5 Unipolar
I5086=5 ;// ADC#6 Unipolar
I5087=6 ;// ADC#7 Unipolar
I5088=7 ;// ADC#8 Unipolar

;///////////////////////////////////////////////////////////////////
;//Map the Suggested M-Variable Definitions for the ADC channels
;//////////////////////////////////////////////////////////////////
M5061->Y:$003400,12,12,U ;// ADC#1 Unipolar
M5062->Y:$003402,12,12,U ;// ADC#2 Unipolar
M5063->Y:$003404,12,12,U ;// ADC#3 Unipolar
M5064->Y:$003406,12,12,U ;// ADC#4 Unipolar
M5065->Y:$003408,12,12,U ;// ADC#5 Unipolar
M5066->Y:$00340A,12,12,U ;// ADC#6 Unipolar
M5067->Y:$00340C,12,12,U ;// ADC#7 Unipolar
M5068->Y:$00340E,12,12,U ;// ADC#8 Unipolar


;///////////////////////////////////////////////////////////////////
;//Map the Suggested M-Variable Definitions for the DAC channels
;//////////////////////////////////////////////////////////////////
M6001->Y:$79C08,0,12 ;// DAC Channel #1
M6002->Y:$79C09,0,12 ;// DAC Channel #2
M6003->Y:$79C0A,0,12 ;// DAC Channel #3
M6004->Y:$79C0B,0,12 ;// DAC Channel #4
M6005->Y:$79C08,12,12 ;// DAC Channel #5
M6006->Y:$79C09,12,12 ;// DAC Channel #6
M6007->Y:$79C0A,12,12 ;// DAC Channel #7
M6008->Y:$79C0B,12,12 ;// DAC Channel #8



#define dac2LftThreadBrakeTension_cnts  M6001;
#define dac3RhtThreadBrakeTension_cnts	M6002;
#define dac1SleveTension_cnts			M6003;

