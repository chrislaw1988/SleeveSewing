

;////////////////////////////////////////////////////////////////////////////////////////////
;//
;// BrickIO.h
;// Created on: 05/06/2014  Author: Josh Kelley
;//
;// Machine Configuration: 4 Axis Geo Brick Controller, With All digital IO coming from the J6 Connector
;//						   Analog IO is coming from Connectors X9-X11
;//
;// Maps the Suggested M-Variables to Address Space, Defines Macro Definitions for access to the M-Variables
;// The Suggested M-Variables are documented within: (GEO Brick Drive User Manual Released: February 2014)
;//
;////////////////////////////////////////////////////////////////////////////////////////////

// Digital Inputs: J6 Connector
M1->Y:$78800,0,1 ;// Input 01 J6 Pin#1
M2->Y:$78800,1,1 ;// Input 02 J6 Pin#20
M3->Y:$78800,2,1 ;// Input 03 J6 Pin#2
M4->Y:$78800,3,1 ;// Input 04 J6 Pin#21
M5->Y:$78800,4,1 ;// Input 05 J6 Pin#3
M6->Y:$78800,5,1 ;// Input 06 J6 Pin#22
M7->Y:$78800,6,1 ;// Input 07 J6 Pin#4
M8->Y:$78800,7,1 ;// Input 08 J6 Pin#23
M9->Y:$78801,0,1 ;// Input 09 J6 Pin#5
M10->Y:$78801,1,1 ;// Input 10 J6 Pin#24
M11->Y:$78801,2,1 ;// Input 11 J6 Pin#6
M12->Y:$78801,3,1 ;// Input 12 J6 Pin#25
M13->Y:$78801,4,1 ;// Input 13 J6 Pin#7
M14->Y:$78801,5,1 ;// Input 14 J6 Pin#26
M15->Y:$78801,6,1 ;// Input 15 J6 Pin#8
M16->Y:$78801,7,1 ;// Input 16 J6 Pin#27

//Digital Outputs: J6 Connector Output# Sourcing Sinking
M33->Y:$078802,0,1 ;// Output 1 J6 Pin#12 Pin#30
M34->Y:$078802,1,1 ;// Output 2 J6 Pin#13 Pin#31
M35->Y:$078802,2,1 ;// Output 3 J6 Pin#14 Pin#32
M36->Y:$078802,3,1 ;// Output 4 J6 Pin#15 Pin#33
M37->Y:$078802,4,1 ;// Output 5 J6 Pin#16 Pin#34
M38->Y:$078802,5,1 ;// Output 6 J6 Pin#17 Pin#35
M39->Y:$078802,6,1 ;// Output 7 J6 Pin#18 Pin#36
M40->Y:$078802,7,1 ;// Output 8 J6 Pin#19 Pin#37

;////////////////////////////////////////////////////////////////////////
;// Bit level Input  MACRO Definitions
;////////////////////////////////////////////////////////////////////////
#define iSystemEstopped	M1

;////////////////////////////////////////////////////////////////////////
;// Bit level Output  MACRO Definitions
;////////////////////////////////////////////////////////////////////////

;//#define oRegulatorOn		M7024
#define oRightThreadClamp	M33
#define oLeftThreadClamp	M34
#define oLeftSleeveClamp	M35
#define oRightSleeveClamp	M36
#define oNeedleBlock		M37
#define oTailStockAdj		M38
#define oSleeveTension		M39


;/////////////////////////////////////////////////////////////////////////////////////////////////////////////
;//		Analog IO  
;//	Analog Output Range is set from 0-816 --> 0-10v
;//	The Analog IO is Filtered PWM "12 Bit", 
;// Reference Pg 147 of GEO Brick Drive User Manual Released: February 2014 for Info on the configuration
;// of the Servo IC1 clock settings
;//   
;////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Set Servo IC 1 Clock Settings 
I7100 = 816 ;// Giving a PWM Frequency of 36Khz
I7101 = 3	;// Giving a Phase Clock of 18Khz
I7102 = 3   ;// Giving a Servo clock of 4.5Khz
I7104 = 0   ;// Giving a Pwm Deadtime of 0

// De-activate Motors 5-8 to write directly to the analog outputs
I500,4,100=0 ;// De-activate channels 5-8
I569,4,100=816 ;// Set Output Limit --(816 or 10v)

// Analog Outputs:
M502->Y:$078102,8,16,S ;// Analog DAC Output (DAC5), Connector X9
M602->Y:$07810A,8,16,S ;// Analog DAC Output (DAC6), Connector X10
M702->Y:$078112,8,16,S ;// Analog DAC Output (DAC7), Connector X11
M802->Y:$07811A,8,16,S ;// Analog DAC Output (DAC8), Connector X12

;////////////////////////////////////////////////////////////////////////
;// Analog Output  MACRO Definitions
;////////////////////////////////////////////////////////////////////////
#define dac1SleveTension_cnts			M502;
#define dac2LftThreadBrakeTension_cnts  M602;
#define dac3RhtThreadBrakeTension_cnts	M702;
