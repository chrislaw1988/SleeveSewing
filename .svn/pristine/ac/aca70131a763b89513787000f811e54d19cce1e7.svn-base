;////GenericTurboMVars(PMAC2).h 
;////Created 4/19/99

;//M210 thru M219 Reserved for interrupt config words

;//The following DPR addresses are reserved for replacing DPR for Interrupts
;//DP:$0608B1		;//DPR Int1 Set
;//DP:$0608B2		;//DPR Int2 Set
;//DP:$0608B3		;//DPR Int3 Set
;//DP:$0608B4		;//DPR Int4 Set

;//for using DPR instead of the int set the Appropriate Mvariable to the correct address in DPR for above

#define	mInt1Set				M1		;//Interrupt1 Set bit		
#define	mInt1Config				M2		;//Interrupt1 Config 
#define	mInt2Set				M3		;//Interrupt2 Set bit		
#define	mInt2Config				M4		;//Interrupt2 Config 
#define	mInt3Set				M5		;//Interrupt3 Set bit		
#define	mInt3Config				M6		;//Interrupt3 Config 
#define	mInt4Set				M7		;//Interrupt4 Set bit		
#define	mInt4Config				M8		;//Interrupt4 Config 
#define	mInt5Set				M9		;//Interrupt4 Set bit		
#define	mInt5Config				M10		;//Interrupt4 Config 

;//array control variables
#define mArrayPtr1				M11		;//point to P0
#define mArrayDefPtr1			M12		;//point the definition word of mArrayPtr1

;//M240 thru M249 spare array control variables (application specific)
#define	mArrayPtr2				M13
#define	mArrayDefPtr2           M14
#define	mArrayPtr3				M15
#define	mArrayDefPtr3			M16
#define	mArrayPtr4				M17
#define	mArrayDefPtr4			M18

;//M240 thru M249 spare Handwheel pulse control variable(application specific)
#define mPulse1Freq				M20		;//Pulse 1 Frequency
#define mPulseWidth				M21		;//Pulse  Width
#define mPulse2Freq				M22		;//Pulse 2 Frequency
#define mPulse1PFM				M23		;//Pulse 1 PFM bit
#define mPulse1Direction		M24		;//Pulse 1 Direction bit
#define mPulse2PFM				M25		;//Pulse 1 PFM bit
#define mPulse2Direction		M26		;//Pulse 2 Direction bit
#define mPulse1Invert			M27		;//Pulse 1 Invert bit
#define mPulse2Invert			M28		;//Pulse 2 Invert bit		

;//M2040 thru M2099 reserved for pre-defined Mvars

#define mServoCycleCounter		M100		;//Servo cycle counter

;// Registers associated with Encoder/DAC1 (Usually #define Motor #1) 
#define mAxis1EnableBit			M114		;// #1 ACTUAL ENABLE BIT
#define mAxis1HmFlag			M120		;// #1 HMFL input status
#define mAxis1PosLim			M121		;// #1 +LIM input status
#define mAxis1NegLim			M122		;// #1 -LIM input status
#define mAxis1Fault				M123		;// #1 FAULT input status

;// #define Motor #1 Status Bits
#define mAxis1OnPositionLim		M130		;// #1 Stopped-on-position-limit bit
#define mAxis1PosEndLim			M131		;// #1 Positive-end-limit-set bit
#define mAxis1NegEndLim			M132		;// #1 Negative-end-limit-set bit
#define mAxis1ZeroVelBit		M133		;// #1 Desired-velocity-zero bit
#define mAxis1InDwell			M135		;// #1 Dwell-in-progress bit
#define mAxis1Running			M137		;// #1 Running-program bit
#define mAxis1OpenLoop			M138		;// #1 Open-loop-mode bit
#define mAxis1AmpEnable			M139		;// #1 Amplifier-enabled status bit
#define mAxis1InPosition		M140		;// #1 In-position bit
#define mAxis1Warning			M141		;// #1 Warning-following error bit
#define mAxis1FatFolBit			M142		;// #1 Fatal-following-error bit
#define mAxis1AmpFault			M143		;// #1 Amplifier-fault-error bit
#define mAxis1HomeDone			M145		;// #1 Home-complete bit
#define mAxis1I2TAmpFault		M147		;// #1 I2T Amp fault
#define mAxis1PhasingFault		M148		;// #1 Phase Fault
#define mAxis1Phasing			M149		;// #1 Phasing	

;// #define Motor #1 #define MoveRegisters
#define mAxis1CmdPos			M161		;// #1 Commanded position (1/[Ix08*32] cts)
#define mAxis1ActualPos			M162		;// #1 Actual position (1/[Ix08*32] cts)
#define mAxis1EndPos			M163		;// #1 Target (end) position (1/[Ix08*32] cts)
#define mAxis1PosBias			M164		;// #1 Position bias (1/[Ix08*32] cts)
#define mAxis1ActualVel			M166		;// #1 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis1MasterPos			M167		;// #1 Present master pos (1/[Ix08*32] cts)
#define mAxis1Filter			M168		;// #1 Filter Output (DAC bits)
#define mAxis1Compensation		M169		;// #1 Compensation correction
#define mAxis1PhasePos			M171		;// #1 Present phase position
#define mAxis1JogPosition		M172		;// #1 Variable Jog Position
#define mAxis1HomeCapturePos	M173		;// #1 Home Capture Position
#define mAxis1AvgVel			M174		;// #1 Avg Velocity
#define mAxis1QuadI				M175		;// #1 Actual Quadrature Current
#define mAxis1DirI				M176		;// #1 Actual Direct Current
#define mAxis1DesiredVel		M179		;// #4 Previous Desired Velocity

#define mAxis1JogVelMax			M180		;// #1 Maximum Jog Speed(cts/msec)
#define mAxis1PosCmpA			M108		;// #1 Position Compare A 
#define mAxis1PosCmpB			M109		;// #1 Position Compare B
 

;// Motor #1 Axis Definition Regiters
#define mAxis1XFactor			M191		;// #1 X Factor
#define mAxis1YFactor			M192		;// #1 Y Factor
#define mAxis1ZFactor			M193		;// #1 Z Factor
#define mAxis1XOffset			M194		;// #1 Offset

;// Registers associated with Encder/DAC2 (Usually #define Motor #2) 
#define mAxis2EnableBit			M214		;// #2 ACTUAL ENABLE BIT
#define mAxis2HmFlag			M220		;// #2 HMFL input status
#define mAxis2PosLim			M221		;// #2 +LIM input status
#define mAxis2NegLim			M222		;// #2 -LIM input status
#define mAxis2Fault				M223		;// #2 FAULT input status

;// #define Motor #2 Status Bits
#define mAxis2OnPositionLim		M230		;// #2 Stopped-on-position-limit bit
#define mAxis2PosEndLim			M231		;// #2 Positive-end-limit-set bit
#define mAxis2NegEndLim			M232		;// #2 Negative-end-limit-set bit
#define mAxis2ZeroVelBit		M233		;// #2 Desired-velocity-zero bit
#define mAxis2InDwell			M235		;// #2 Dwell-in-progress bit
#define mAxis2MoveTimerActive	M237		;// #2 Move Timer Active bit
#define mAxis2OpenLoop			M238		;// #2 Open-loop-mode bit
#define mAxis2AmpEnable			M239		;// #2 Amplifier-enabled status bit
#define mAxis2InPosition		M240		;// #2 In-position bit
#define mAxis2Warning			M241		;// #2 Warning-following error bit
#define mAxis2FatFolBit			M242		;// #2 Fatal-following-error bit
#define mAxis2AmpFault			M243		;// #2 Amplifier-fault-error bit
#define mAxis2HomeDone			M245		;// #2 Home-complete bit
#define mAxis2I2TAmpFault		M247		;// #1 I2T Amp fault
#define mAxis2PhasingFault		M248		;// #2 Phase Fault
#define mAxis2Phasing			M249		;// #2 Phasing	

;// #define Motor #2 #define MoveRegisters
#define mAxis2CmdPos			M261		;// #2 Commanded position (1/[Ix08*32] cts)
#define mAxis2ActualPos			M262		;// #2 Actual position (1/[Ix08*32] cts)
#define mAxis2EndPos			M263		;// #2 Target (end) position (1/[Ix08*32] cts)
#define mAxis2PosBias			M264		;// #2 Position bias (1/[Ix08*32] cts)
;//#define mAxis2TrgtPos			M22		;// &1 X-axis target position (engineering units)
#define mAxis2ActualVel			M266		;// #2 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis2MasterPos			M267		;// #2 Present master pos (1/[Ix08*32] cts)
#define mAxis2Filter			M268		;// #2 Filter Output (DAC bits)
#define mAxis2Compensation		M269		;// #2 Compensation correction
#define mAxis2PhasePos			M271		;// #2 Present phase position
#define mAxis2JogPosition		M272		;// #2 Variable Jog Position
#define mAxis2HomeCapturePos	M273		;// #2 Home Capture Position
#define mAxis2AvgVel			M274		;// #2 Avg Velocity
#define mAxis2QuadI				M275		;// #2 Actual Quadrature Current
#define mAxis2DirI				M276		;// #2 Actual Direct Current
#define mAxis2DesiredVel		M279		;// #4 Previous Desired Velocity

#define mAxis2JogVelMax			M280		;// #2 Maximum Jog Speed(cts/msec)
#define mAxis2PosCmpA			M208		;// #2 Position Compare A 
#define mAxis2PosCmpB			M209		;// #2 Position Compare B 

;// Motor #2 Axis Definition Regiters
#define mAxis2XFactor			M291		;// #2 X Factor
#define mAxis2YFactor			M292		;// #2 Y Factor
#define mAxis2ZFactor			M293		;// #2 Z Factor
#define mAxis2XOffset			M294		;// #2 Offset

;// Registers associated with Encder/DAC1 (Usually #define Motor #3) 

#define mAxis3EnableBit			M314		;// #3 ACTUAL ENABLE BIT
#define mAxis3HmFlag			M320		;// #3 HMFL input status
#define mAxis3PosLim			M321		;// #3 +LIM input status
#define mAxis3NegLim			M322		;// #3 -LIM input status
#define mAxis3Fault				M323		;// #3 FAULT input status

;// #define Motor #3 Status Bits
#define mAxis3OnPositionLim		M330		;// #3 Stopped-on-position-limit bit
#define mAxis3PosEndLim			M331		;// #3 Positive-end-limit-set bit
#define mAxis3NegEndLim			M332		;// #3 Negative-end-limit-set bit
#define mAxis3ZeroVelBit		M333		;// #3 Desired-velocity-zero bit
#define mAxis3InDwell			M335		;// #3 Dwell-in-progress bit
#define mAxis3Running			M337		;// #3 Running-program bit
#define mAxis3OpenLoop			M338		;// #3 Open-loop-mode bit
#define mAxis3AmpEnable			M339		;// #3 Amplifier-enabled status bit
#define mAxis3InPosition		M340		;// #3 In-position bit
#define mAxis3Warning			M341		;// #3 Warning-following error bit
#define mAxis3FatFolBit			M342		;// #3 Fatal-following-error bit
#define mAxis3AmpFault			M343		;// #3 Amplifier-fault-error bit
#define mAxis3I2TAmpFault		M347		;// #1 I2T Amp fault
#define mAxis3HomeDone			M345		;// #3 Home-complete bit
#define mAxis3PhasingFault		M348		;// #3 Phase Fault
#define mAxis3Phasing			M349		;// #3 Phasing	

;// #define Motor #3 #define MoveRegisters
#define mAxis3CmdPos			M361		;// #3 Commanded position (1/[Ix08*32] cts)
#define mAxis3ActualPos			M362		;// #3 Actual position (1/[Ix08*32] cts)
#define mAxis3EndPos			M363		;// #3 Target (end) position (1/[Ix08*32] cts)
#define mAxis3PosBias			M364		;// #3 Position bias (1/[Ix08*32] cts)
#define mAxis3ActualVel			M366		;// #3 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis3MasterPos			M367		;// #3 Present master pos (1/[Ix08*32] cts)
#define mAxis3Filter			M368		;// #3 Filter Output (DAC bits)
#define mAxis3Compensation		M369		;// #3 Compensation correction
#define mAxis3PhasePos			M371		;// #3 Present phase position
#define mAxis3JogPosition		M372		;// #3 Variable Jog Position
#define mAxis3HomeCapturePos	M373		;// #3 Home Capture Position
#define mAxis3AvgVel			M374		;// #3 Avg Velocity
#define mAxis3QuadI				M375		;// #3 Actual Quadrature Current
#define mAxis3DirI				M376		;// #3 Actual Direct Current
#define mAxis3DesiredVel		M379		;// #3 Previous Desired Velocity

#define mAxis3JogVelMax			M380		;// #3 Maximum Jog Speed(cts/msec)
#define mAxis3PosCmpA			M308		;// #3 Position Compare A 
#define mAxis3PosCmpB			M309		;// #3 Position Compare B 

;// Motor #3 Axis Definition Regiters
#define mAxis3XFactor			M391		;// #3 X Factor
#define mAxis3YFactor			M392		;// #3 Y Factor
#define mAxis3ZFactor			M393		;// #3 Z Factor
#define mAxis3XOffset			M394		;// #3 Offset

;// Registers associated with Encder/DAC1 (Usually #define Motor #4) 

#define mAxis4EnableBit			M414		;// #4 ACTUAL ENABLE BIT
#define mAxis4HmFlag			M420		;// #4 HMFL input status
#define mAxis4PosLim			M421		;// #4 +LIM input status
#define mAxis4NegLim			M422		;// #4 -LIM input status
#define mAxis4Fault				M423		;// #4 FAULT input status

;// #define Motor #4 Status Bits
#define mAxis4OnPositionLim		M430		;// #4 Stopped-on-position-limit bit
#define mAxis4PosEndLim			M431		;// #4 Positive-end-limit-set bit
#define mAxis4NegEndLim			M432		;// #4 Negative-end-limit-set bit
#define mAxis4ZeroVelBit		M433		;// #4 Desired-velocity-zero bit
#define mAxis4InDwell			M435		;// #4 Dwell-in-progress bit
#define mAxis4Running			M437		;// #4 Running-program bit
#define mAxis4OpenLoop			M438		;// #4 Open-loop-mode bit
#define mAxis4AmpEnable			M439		;// #4 Amplifier-enabled status bit
#define mAxis4InPosition		M440		;// #4 In-position bit
#define mAxis4Warning			M441		;// #4 Warning-following error bit
#define mAxis4FatFolBit			M442		;// #4 Fatal-following-error bit
#define mAxis4AmpFault			M443		;// #4 Amplifier-fault-error bit
#define mAxis4I2TAmpFault		M447		;// #1 I2T Amp fault
#define mAxis4HomeDone			M445		;// #4 Home-complete bit
#define mAxis4PhasingFault		M448		;// #4 Phase Fault
#define mAxis4Phasing			M449		;// #4 Phasing	

;// #define Motor #4 #define MoveRegisters
#define mAxis4CmdPos			M461		;// #4 Commanded position (1/[Ix08*32] cts)
#define mAxis4ActualPos			M462		;// #4 Actual position (1/[Ix08*32] cts)
#define mAxis4EndPos			M463		;// #4 Target (end) position (1/[Ix08*32] cts)
#define mAxis4PosBias			M464		;// #4 Position bias (1/[Ix08*32] cts)
#define mAxis4ActualVel			M466		;// #4 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis4MasterPos			M467		;// #4 Present master pos (1/[Ix08*32] cts)
#define mAxis4Filter			M468		;// #4 Filter Output (DAC bits)
#define mAxis4Compensation		M469		;// #4 Compensation correction
#define mAxis4PhasePos			M471		;// #4 Present phase position
#define mAxis4JogPosition		M472		;// #4 Variable Jog Position
#define mAxis4HomeCapturePos	M473		;// #4 Home Capture Position
#define mAxis4AvgVel			M474		;// #4 Avg Velocity
#define mAxis4QuadI				M475		;// #4 Actual Quadrature Current
#define mAxis4DirI				M476		;// #4 Actual Direct Current
#define mAxis4DesiredVel		M479		;// #4 Previous Desired Velocity

#define mAxis4JogVelMax			M480		;// #4 Maximum Jog Speed(cts/msec)
#define mAxis4PosCmpA			M408		;// #4 Position Compare A 
#define mAxis4PosCmpB			M409		;// #4 Position Compare B 

;// Motor #4 Axis Definition Regiters
#define mAxis4XFactor			M491		;// #4 X Factor
#define mAxis4YFactor			M492		;// #4 Y Factor
#define mAxis4ZFactor			M493		;// #4 Z Factor
#define mAxis4XOffset			M494		;// #4 Offset

;// Registers associated with Encder/DAC1 (Usually #define Motor #5) 

#define mAxis5EnableBit			M514		;// #5 ACTUAL ENABLE BIT
#define mAxis5HmFlag			M520		;// #5 HMFL input status
#define mAxis5PosLim			M521		;// #5 +LIM input status
#define mAxis5NegLim			M522		;// #5 -LIM input status
#define mAxis5Fault				M523		;// #5 FAULT input status

;// #define Motor #5 Status Bits
#define mAxis5OnPositionLim		M530		;// #5 Stopped-on-position-limit bit
#define mAxis5PosEndLim			M531		;// #5 Positive-end-limit-set bit
#define mAxis5NegEndLim			M532		;// #5 Negative-end-limit-set bit
#define mAxis5ZeroVelBit		M533		;// #5 Desired-velocity-zero bit
#define mAxis5InDwell			M535		;// #5 Dwell-in-progress bit
#define mAxis5Running			M537		;// #5 Running-program bit
#define mAxis5OpenLoop			M538		;// #5 Open-loop-mode bit
#define mAxis5AmpEnable			M539		;// #5 Amplifier-enabled status bit
#define mAxis5InPosition		M540		;// #5 In-position bit
#define mAxis5Warning			M541		;// #5 Warning-following error bit
#define mAxis5FatFolBit			M542		;// #5 Fatal-following-error bit
#define mAxis5AmpFault			M543		;// #5 Amplifier-fault-error bit
#define mAxis5HomeDone			M545		;// #5 Home-complete bit
#define mAxis5I2TAmpFault		M547		;// #5 I2T Amp Fault
#define mAxis5PhasingFault		M548		;// #5 Phase Fault
#define mAxis5Phasing			M549		;// #5 Phasing	

;// #define Motor #5 #define MoveRegisters
#define mAxis5CmdPos			M561		;// #5 Commanded position (1/[Ix08*32] cts)
#define mAxis5ActualPos			M562		;// #5 Actual position (1/[Ix08*32] cts)
#define mAxis5EndPos			M563		;// #5 Target (end) position (1/[Ix08*32] cts)
#define mAxis5PosBias			M564		;// #5 Position bias (1/[Ix08*32] cts)
#define mAxis5DesiredAccel		M565		;// #5 Desired Accel 6/[Ixx08*32] cts/msec2 at %100
#define mAxis5ActualVel			M566		;// #5 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis5MasterPos			M567		;// #5 Present master pos (1/[Ix08*32] cts)
#define mAxis5Filter			M568		;// #5 Filter Output (DAC bits)
#define mAxis5Compensation		M569		;// #5 Compensation correction
#define mAxis5PhasePos			M571		;// #5 Present phase position
#define mAxis5JogPosition		M572		;// #5 Variable Jog Position
#define mAxis5HomeCapturePos	M573		;// #5 Home Capture Position
#define mAxis5AvgVel			M574		;// #5 Avg Velocity
#define mAxis5QuadI				M575		;// #5 Actual Quadrature Current
#define mAxis5DirI				M576		;// #5 Actual Direct Current

#define mAxis5JogVelMax			M580		;// #5 Maximum Jog Speed(cts/msec)
#define mAxis5PosCmpA			M508		;// #5 Position Compare A 
#define mAxis5PosCmpB			M509		;// #5 Position Compare B 

;// Motor #5 Axis Definition Regiters
#define mAxis5XFactor			M591		;// #5 X Factor
#define mAxis5YFactor			M592		;// #5 Y Factor
#define mAxis5ZFactor			M593		;// #5 Z Factor
#define mAxis5XOffset			M594		;// #5 Offset

;// Registers associated with Encder/DAC1 (Usually #define Motor #6) 

#define mAxis6EnableBit			M614		;// #6 ACTUAL ENABLE BIT
#define mAxis6HmFlag			M620		;// #6 HMFL input status
#define mAxis6PosLim			M621		;// #6 +LIM input status
#define mAxis6NegLim			M622		;// #6 -LIM input status
#define mAxis6Fault				M623		;// #6 FAULT input status

;// #define Motor #6 Status Bits
#define mAxis6OnPositionLim		M630		;// #6 Stopped-on-position-limit bit
#define mAxis6PosEndLim			M631		;// #6 Positive-end-limit-set bit
#define mAxis6NegEndLim			M632		;// #6 Negative-end-limit-set bit
#define mAxis6ZeroVelBit		M633		;// #6 Desired-velocity-zero bit
#define mAxis6InDwell			M635		;// #6 Dwell-in-progress bit
#define mAxis6Running			M637		;// #6 Running-program bit
#define mAxis6OpenLoop			M638		;// #6 Open-loop-mode bit
#define mAxis6AmpEnable			M639		;// #6 Amplifier-enabled status bit
#define mAxis6InPosition		M640		;// #6 In-position bit
#define mAxis6Warning			M641		;// #6 Warning-following error bit
#define mAxis6FatFolBit			M642		;// #6 Fatal-following-error bit
#define mAxis6AmpFault			M643		;// #6 Amplifier-fault-error bit
#define mAxis6HomeDone			M645		;// #6 Home-complete bit
#define mAxis6I2TAmpFault		M647		;// #6 I2T Amp Fault
#define mAxis6PhasingFault		M648		;// #6 Phase Fault
#define mAxis6Phasing			M649		;// #6 Phasing	

;// #define Motor #6 #define MoveRegisters
#define mAxis6CmdPos			M661		;// #6 Commanded position (1/[Ix08*32] cts)
#define mAxis6ActualPos			M662		;// #6 Actual position (1/[Ix08*32] cts)
#define mAxis6EndPos			M663		;// #6 Target (end) position (1/[Ix08*32] cts)
#define mAxis6PosBias			M664		;// #6 Position bias (1/[Ix08*32] cts)
#define mAxis6ActualVel			M666		;// #6 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis6MasterPos			M667		;// #6 Present master pos (1/[Ix08*32] cts)
#define mAxis6Filter			M668		;// #6 Filter Output (DAC bits)
#define mAxis6Compensation		M669		;// #6 Compensation correction
#define mAxis6PhasePos			M671		;// #6 Present phase position
#define mAxis6JogPosition		M672		;// #6 Variable Jog Position
#define mAxis6HomeCapturePos	M673		;// #6 Home Capture Position
#define mAxis6AvgVel			M674		;// #6 Avg Velocity
#define mAxis6QuadI				M675		;// #6 Actual Quadrature Current
#define mAxis6DirI				M676		;// #6 Actual Direct Current
#define mAxis6DesiredVel		M679		;// #4 Previous Desired Velocity

#define mAxis6JogVelMax			M680		;// #6 Maximum Jog Speed(cts/msec)
#define mAxis6PosCmpA			M608		;// #6 Position Compare A 
#define mAxis6PosCmpB			M609		;// #6 Position Compare B 

;// Motor #6 Axis Definition Regiters
#define mAxis6XFactor			M691		;// #6 X Factor
#define mAxis6YFactor			M692		;// #6 Y Factor
#define mAxis6ZFactor			M693		;// #6 Z Factor
#define mAxis6XOffset			M694		;// #6 Offset

;// Registers associated with Encder/DAC1 (Usually #define Motor #7) 

#define mAxis7EnableBit			M714		;// #7 ACTUAL ENABLE BIT
#define mAxis7HmFlag			M720		;// #7 HMFL input status
#define mAxis7PosLim			M721		;// #7 +LIM input status
#define mAxis7NegLim			M722		;// #7 -LIM input status
#define mAxis7Fault				M723		;// #7 FAULT input status

;// #define Motor #7 Status Bits
#define mAxis7OnPositionLim		M730		;// #7 Stopped-on-position-limit bit
#define mAxis7PosEndLim			M731		;// #7 Positive-end-limit-set bit
#define mAxis7NegEndLim			M732		;// #7 Negative-end-limit-set bit
#define mAxis7ZeroVelBit		M733		;// #7 Desired-velocity-zero bit
#define mAxis7InDwell			M735		;// #7 Dwell-in-progress bit
#define mAxis7Running			M737		;// #7 Running-program bit
#define mAxis7OpenLoop			M738		;// #7 Open-loop-mode bit
#define mAxis7AmpEnable			M739		;// #7 Amplifier-enabled status bit
#define mAxis7InPosition		M740		;// #7 In-position bit
#define mAxis7Warning			M741		;// #7 Warning-following error bit
#define mAxis7FatFolBit			M742		;// #7 Fatal-following-error bit
#define mAxis7AmpFault			M743		;// #7 Amplifier-fault-error bit
#define mAxis7HomeDone			M745		;// #7 Home-complete bit
#define mAxis7I2TAmpFault		M747		;// #7 I2T Amp Fault
#define mAxis7PhasingFault		M748		;// #7 Phase Fault
#define mAxis7Phasing			M749		;// #7 Phasing	

;// #define Motor #7 #define MoveRegisters
#define mAxis7CmdPos			M761		;// #7 Commanded position (1/[Ix08*32] cts)
#define mAxis7ActualPos			M762		;// #7 Actual position (1/[Ix08*32] cts)
#define mAxis7EndPos			M763		;// #7 Target (end) position (1/[Ix08*32] cts)
#define mAxis7PosBias			M764		;// #7 Position bias (1/[Ix08*32] cts)
#define mAxis7ActualVel			M766		;// #7 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis7MasterPos			M767		;// #7 Present master pos (1/[Ix08*32] cts)
#define mAxis7Filter			M768		;// #7 Filter Output (DAC bits)
#define mAxis7Compensation		M769		;// #7 Compensation correction
#define mAxis7PhasePos			M771		;// #7 Present phase position
#define mAxis7JogPosition		M772		;// #7 Variable Jog Position
#define mAxis7HomeCapturePos	M773		;// #7 Home Capture Position
#define mAxis7AvgVel			M774		;// #7 Avg Velocity
#define mAxis7QuadI				M775		;// #7 Actual Quadrature Current
#define mAxis7DirI				M776		;// #7 Actual Direct Current
#define mAxis7DesiredVel		M779		;// #7 Previous Desired Velocity

#define mAxis7JogVelMax			M780		;// #7 Maximum Jog Speed(cts/msec)
#define mAxis7PosCmpA			M708		;// #7 Position Compare A 
#define mAxis7PosCmpB			M709		;// #7 Position Compare B 

;// Motor #7 Axis Definition Regiters
#define mAxis7XFactor			M791		;// #7 X Factor
#define mAxis7YFactor			M792		;// #7 Y Factor
#define mAxis7ZFactor			M793		;// #7 Z Factor
#define mAxis7XOffset			M794		;// #7 Offset

;// Registers associated with Encder/DAC1 (Usually #define Motor #8) 

#define mAxis8EnableBit			M814		;// #8 ACTUAL ENABLE BIT
#define mAxis8HmFlag			M820		;// #8 HMFL input status
#define mAxis8PosLim			M821		;// #8 +LIM input status
#define mAxis8NegLim			M822		;// #8 -LIM input status
#define mAxis8Fault				M823		;// #8 FAULT input status

;// #define Motor #8 Status Bits
#define mAxis8OnPositionLim		M830		;// #8 Stopped-on-position-limit bit
#define mAxis8PosEndLim			M831		;// #8 Positive-end-limit-set bit
#define mAxis8NegEndLim			M832		;// #8 Negative-end-limit-set bit
#define mAxis8ZeroVelBit		M833		;// #8 Desired-velocity-zero bit
#define mAxis8InDwell			M835		;// #8 Dwell-in-progress bit
#define mAxis8Running			M837		;// #8 Running-program bit
#define mAxis8OpenLoop			M838		;// #8 Open-loop-mode bit
#define mAxis8AmpEnable			M839		;// #8 Amplifier-enabled status bit
#define mAxis8InPosition		M840		;// #8 In-position bit
#define mAxis8Warning			M841		;// #8 Warning-following error bit
#define mAxis8FatFolBit			M842		;// #8 Fatal-following-error bit
#define mAxis8AmpFault			M843		;// #8 Amplifier-fault-error bit
#define mAxis8HomeDone			M845		;// #8 Home-complete bit
#define mAxis8I2TAmpFault		M847		;// #8 I2T Amp Fault
#define mAxis8PhasingFault		M848		;// #8 Phase Fault
#define mAxis8Phasing			M849		;// #8 Phasing	

;// #define Motor #8 #define MoveRegisters
#define mAxis8CmdPos			M861		;// #8 Commanded position (1/[Ix08*32] cts)
#define mAxis8ActualPos			M862		;// #8 Actual position (1/[Ix08*32] cts)
#define mAxis8EndPos			M863		;// #8 Target (end) position (1/[Ix08*32] cts)
#define mAxis8PosBias			M864		;// #8 Position bias (1/[Ix08*32] cts)
#define mAxis8ActualVel			M866		;// #8 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis8MasterPos			M867		;// #8 Present master pos (1/[Ix08*32] cts)
#define mAxis8Filter			M868		;// #8 Filter Output (DAC bits)
#define mAxis8Compensation		M869		;// #8 Compensation correction
#define mAxis8PhasePos			M871		;// #8 Present phase position
#define mAxis8JogPosition		M872		;// #8 Variable Jog Position
#define mAxis8HomeCapturePos	M873		;// #8 Home Capture Position
#define mAxis8AvgVel			M874		;// #8 Avg Velocity
#define mAxis8QuadI				M875		;// #8 Actual Quadrature Current
#define mAxis8DirI				M876		;// #8 Actual Direct Current
#define mAxis8DesiredVel		M879		;// #8 Previous Desired Velocity

#define mAxis8JogVelMax			M880		;// #8 Maximum Jog Speed(cts/msec)
#define mAxis8PosCmpA			M808		;// #8 Position Compare A 
#define mAxis8PosCmpB			M809		;// #8 Position Compare B 

;// Motor #8 Axis Definition Regiters
#define mAxis8XFactor			M891		;// #8 X Factor
#define mAxis8YFactor			M892		;// #8 Y Factor
#define mAxis8ZFactor			M893		;// #8 Z Factor
#define mAxis8XOffset			M894		;// #8 Offset

;// Registers associated with Encder/DAC1 (Usually #define Motor #9) 

#define mAxis9EnableBit			M914		;// #9 ACTUAL ENABLE BIT
#define mAxis9HmFlag			M920		;// #9 HMFL input status
#define mAxis9PosLim			M921		;// #9 +LIM input status
#define mAxis9NegLim			M922		;// #9 -LIM input status
#define mAxis9Fault				M923		;// #9 FAULT input status

;// #define Motor #9 Status Bits
#define mAxis9OnPositionLim		M930		;// #9 Stopped-on-position-limit bit
#define mAxis9PosEndLim			M931		;// #9 Positive-end-limit-set bit
#define mAxis9NegEndLim			M932		;// #9 Negative-end-limit-set bit
#define mAxis9ZeroVelBit		M933		;// #9 Desired-velocity-zero bit
#define mAxis9InDwell			M935		;// #9 Dwell-in-progress bit
#define mAxis9Running			M937		;// #9 Running-program bit
#define mAxis9OpenLoop			M938		;// #9 Open-loop-mode bit
#define mAxis9AmpEnable			M939		;// #9 Amplifier-enabled status bit
#define mAxis9InPosition		M940		;// #9 In-position bit
#define mAxis9Warning			M941		;// #9 Warning-following error bit
#define mAxis9FatFolBit			M942		;// #9 Fatal-following-error bit
#define mAxis9AmpFault			M943		;// #9 Amplifier-fault-error bit
#define mAxis9HomeDone			M945		;// #9 Home-complete bit
#define mAxis9I2TAmpFault		M947		;// #9 I2T Amp Fault
#define mAxis9PhasingFault		M948		;// #9 Phase Fault
#define mAxis9Phasing			M949		;// #9 Phasing	

;// #define Motor #9 #define MoveRegisters
#define mAxis9CmdPos			M961		;// #9 Commanded position (1/[Ix08*32] cts)
#define mAxis9ActualPos			M962		;// #9 Actual position (1/[Ix08*32] cts)
#define mAxis9EndPos			M963		;// #9 Target (end) position (1/[Ix08*32] cts)
#define mAxis9PosBias			M964		;// #9 Position bias (1/[Ix08*32] cts)
#define mAxis9ActualVel			M966		;// #9 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis9MasterPos			M967		;// #9 Present master pos (1/[Ix08*32] cts)
#define mAxis9Filter			M968		;// #9 Filter Output (DAC bits)
#define mAxis9Compensation		M969		;// #9 Compensation correction
#define mAxis9PhasePos			M971		;// #9 Present phase position
#define mAxis9JogPosition		M972		;// #9 Variable Jog Position
#define mAxis9HomeCapturePos	M973		;// #9 Home Capture Position
#define mAxis9AvgVel			M974		;// #9 Avg Velocity
#define mAxis9QuadI				M975		;// #9 Actual Quadrature Current
#define mAxis9DirI				M976		;// #9 Actual Direct Current
#define mAxis9DesiredVel		M979		;// #9 Previous Desired Velocity

#define mAxis9JogVelMax			M980		;// #9 Maximum Jog Speed(cts/msec)
#define mAxis9PosCmpA			M981		;// #9 Position Compare A 
#define mAxis9PosCmpB			M982		;// #9 Position Compare B 

;// Motor #9 Axis Definition Regiters
#define mAxis9XFactor			M991		;// #9 X Factor
#define mAxis9YFactor			M992		;// #9 Y Factor
#define mAxis9ZFactor			M993		;// #9 Z Factor
#define mAxis9XOffset			M994		;// #9 Offset

;// Registers associated with Encoder/DAC #10 (Usually #define Motor #10) 

#define mAxis10EnableBit		M1014		;// #10 ACTUAL ENABLE BIT
#define mAxis10HmFlag			M1020		;// #10 HMFL input status
#define mAxis10PosLim			M1021		;// #10 +LIM input status
#define mAxis10NegLim			M1022		;// #10 -LIM input status
#define mAxis10Fault			M1023		;// #10 FAULT input status

;// #define Motor #10 Status Bits
#define mAxis10OnPositionLim	M1030		;// #10 Stopped-on-position-limit bit
#define mAxis10PosEndLim		M1031		;// #10 Positive-end-limit-set bit
#define mAxis10NegEndLim		M1032		;// #10 Negative-end-limit-set bit
#define mAxis10ZeroVelBit		M1033		;// #10 Desired-velocity-zero bit
#define mAxis10InDwell			M1035		;// #10 Dwell-in-progress bit
#define mAxis10Running			M1037		;// #10 Running-program bit
#define mAxis10OpenLoop			M1038		;// #10 Open-loop-mode bit
#define mAxis10AmpEnable		M1039		;// #10 Amplifier-enabled status bit
#define mAxis10InPosition		M1040		;// #10 In-position bit
#define mAxis10Warning			M1041		;// #10 Warning-following error bit
#define mAxis10FatFolBit		M1042		;// #10 Fatal-following-error bit
#define mAxis10AmpFault			M1043		;// #10 Amplifier-fault-error bit
#define mAxis10HomeDone			M1045		;// #10 Home-complete bit
#define mAxis10I2TAmpFault		M1047		;// #10 I2T Amp Fault
#define mAxis10PhasingFault		M1048		;// #10 Phase Fault
#define mAxis10Phasing			M1049		;// #10 Phasing	

;// #define Motor #10 #define Move Registers
#define mAxis10CmdPos			M1061		;// #10 Commanded position (1/[Ix08*32] cts)
#define mAxis10ActualPos		M1062		;// #10 Actual position (1/[Ix08*32] cts)
#define mAxis10EndPos			M1063		;// #10 Target (end) position (1/[Ix08*32] cts)
#define mAxis10PosBias			M1064		;// #10 Position bias (1/[Ix08*32] cts)
#define mAxis10ActualVel		M1065		;// #10 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis10MasterPos		M1066		;// #10 Present master pos (1/[Ix08*32] cts)
#define mAxis10Filter			M1068		;// #10 Filter Output (DAC bits)
#define mAxis10Compensation		M1069		;// #10 Compensation correction
#define mAxis10PhasePos			M1071		;// #10 Present phase position
#define mAxis10JogPosition		M1072		;// #10 Variable Jog Position
#define mAxis10HomeCapturePos	M1073		;// #10 Home Capture Position
#define mAxis10AvgVel			M1074		;// #10 Avg Velocity
#define mAxis10QuadI			M1075		;// #10 Actual Quadrature Current
#define mAxis10DirI				M1076		;// #10 Actual Direct Current
#define mAxis10DesiredVel		M1079		;// #10 Previous Desired Velocity

#define mAxis10JogVelMax		M1080		;// #10 Maximum Jog Speed(cts/msec)
#define mAxis10PosCmpA			M1081		;// #10 Position Compare A 
#define mAxis10PosCmpB			M1082		;// #10 Position Compare B 

;// Motor #10 Axis Definition Registers
#define mAxis10XFactor			M1091		;// #10 X Factor
#define mAxis10YFactor			M1092		;// #10 Y Factor
#define mAxis10ZFactor			M1093		;// #10 Z Factor
#define mAxis10XOffset			M1094		;// #10 Offset

;// Registers associated with Encoder/DAC #11 (Usually #define Motor #11) 

#define mAxis11EnableBit		M1114		;// #11 ACTUAL ENABLE BIT
#define mAxis11HmFlag			M1120		;// #11 HMFL input status
#define mAxis11PosLim			M1121		;// #11 +LIM input status
#define mAxis11NegLim			M1122		;// #11 -LIM input status
#define mAxis11Fault			M1123		;// #11 FAULT input status

;// #define Motor #11 Status Bits
#define mAxis11OnPositionLim	M1130		;// #11 Stopped-on-position-limit bit
#define mAxis11PosEndLim		M1131		;// #11 Positive-end-limit-set bit
#define mAxis11NegEndLim		M1132		;// #11 Negative-end-limit-set bit
#define mAxis11ZeroVelBit		M1133		;// #11 Desired-velocity-zero bit
#define mAxis11InDwell			M1135		;// #11 Dwell-in-progress bit
#define mAxis11Running			M1137		;// #11 Running-program bit
#define mAxis11OpenLoop			M1138		;// #11 Open-loop-mode bit
#define mAxis11AmpEnable		M1139		;// #11 Amplifier-enabled status bit
#define mAxis11InPosition		M1140		;// #11 In-position bit
#define mAxis11Warning			M1141		;// #11 Warning-following error bit
#define mAxis11FatFolBit		M1142		;// #11 Fatal-following-error bit
#define mAxis11AmpFault			M1143		;// #11 Amplifier-fault-error bit
#define mAxis11HomeDone			M1145		;// #11 Home-complete bit
#define mAxis11I2TAmpFault		M1147		;// #11 I2T Amp Fault
#define mAxis11PhasingFault		M1148		;// #11 Phase Fault
#define mAxis11Phasing			M1149		;// #11 Phasing	

;// #define Motor #11 #define Move Registers
#define mAxis11CmdPos			M1161		;// #11 Commanded position (1/[Ix08*32] cts)
#define mAxis11ActualPos		M1162		;// #11 Actual position (1/[Ix08*32] cts)
#define mAxis11EndPos			M1163		;// #11 Target (end) position (1/[Ix08*32] cts)
#define mAxis11PosBias			M1164		;// #11 Position bias (1/[Ix08*32] cts)
#define mAxis11ActualVel		M1165		;// #11 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis11MasterPos		M1166		;// #11 Present master pos (1/[Ix08*32] cts)
#define mAxis11Filter			M1168		;// #11 Filter Output (DAC bits)
#define mAxis11Compensation		M1169		;// #11 Compensation correction
#define mAxis11PhasePos			M1171		;// #11 Present phase position
#define mAxis11JogPosition		M1172		;// #11 Variable Jog Position
#define mAxis11HomeCapturePos	M1173		;// #11 Home Capture Position
#define mAxis11AvgVel			M1174		;// #11 Avg Velocity
#define mAxis11QuadI			M1175		;// #11 Actual Quadrature Current
#define mAxis11DirI				M1176		;// #11 Actual Direct Current
#define mAxis11DesiredVel		M1179		;// #11 Previous Desired Velocity

#define mAxis11JogVelMax		M1180		;// #11 Maximum Jog Speed(cts/msec)
#define mAxis11PosCmpA			M1181		;// #11 Position Compare A 
#define mAxis11PosCmpB			M1182		;// #11 Position Compare B 

;// Motor #11 Axis Definition Registers
#define mAxis11XFactor			M1191		;// #11 X Factor
#define mAxis11YFactor			M1192		;// #11 Y Factor
#define mAxis11ZFactor			M1193		;// #11 Z Factor
#define mAxis11XOffset			M1194		;// #11 Offset

;// Registers associated with Encoder/DAC #12 (Usually #define Motor #12) 

#define mAxis12EnableBit		M1214		;// #12 ACTUAL ENABLE BIT
#define mAxis12HmFlag			M1220		;// #12 HMFL input status
#define mAxis12PosLim			M1221		;// #12 +LIM input status
#define mAxis12NegLim			M1222		;// #12 -LIM input status
#define mAxis12Fault			M1223		;// #12 FAULT input status

;// #define Motor #12 Status Bits
#define mAxis12OnPositionLim	M1230		;// #12 Stopped-on-position-limit bit
#define mAxis12PosEndLim		M1231		;// #12 Positive-end-limit-set bit
#define mAxis12NegEndLim		M1232		;// #12 Negative-end-limit-set bit
#define mAxis12ZeroVelBit		M1233		;// #12 Desired-velocity-zero bit
#define mAxis12InDwell			M1235		;// #12 Dwell-in-progress bit
#define mAxis12Running			M1237		;// #12 Running-program bit
#define mAxis12OpenLoop			M1238		;// #12 Open-loop-mode bit
#define mAxis12AmpEnable		M1239		;// #12 Amplifier-enabled status bit
#define mAxis12InPosition		M1240		;// #12 In-position bit
#define mAxis12Warning			M1241		;// #12 Warning-following error bit
#define mAxis12FatFolBit		M1242		;// #12 Fatal-following-error bit
#define mAxis12AmpFault			M1243		;// #12 Amplifier-fault-error bit
#define mAxis12HomeDone			M1245		;// #12 Home-complete bit
#define mAxis12I2TAmpFault		M1247		;// #12 I2T Amp Fault
#define mAxis12PhasingFault		M1248		;// #12 Phase Fault
#define mAxis12Phasing			M1249		;// #12 Phasing	

;// #define Motor #12 #define Move Registers
#define mAxis12CmdPos			M1261		;// #12 Commanded position (1/[Ix08*32] cts)
#define mAxis12ActualPos		M1262		;// #12 Actual position (1/[Ix08*32] cts)
#define mAxis12EndPos			M1263		;// #12 Target (end) position (1/[Ix08*32] cts)
#define mAxis12PosBias			M1264		;// #12 Position bias (1/[Ix08*32] cts)
#define mAxis12ActualVel		M1266		;// #12 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis12MasterPos		M1267		;// #12 Present master pos (1/[Ix08*32] cts)
#define mAxis12Filter			M1268		;// #12 Filter Output (DAC bits)
#define mAxis12Compensation		M1269		;// #12 Compensation correction
#define mAxis12PhasePos			M1271		;// #12 Present phase position
#define mAxis12JogPosition		M1272		;// #12 Variable Jog Position
#define mAxis12HomeCapturePos	M1273		;// #12 Home Capture Position
#define mAxis12AvgVel			M1274		;// #12 Avg Velocity
#define mAxis12QuadI			M1275		;// #12 Actual Quadrature Current
#define mAxis12DirI				M1276		;// #12 Actual Direct Current
#define mAxis12DesiredVel		M1279		;// #12 Previous Desired Velocity

#define mAxis12JogVelMax		M1280		;// #12 Maximum Jog Speed(cts/msec)
#define mAxis12PosCmpA			M1281		;// #12 Position Compare A 
#define mAxis12PosCmpB			M1282		;// #12 Position Compare B 

;// Motor #12 Axis Definition Registers
#define mAxis12XFactor			M1291		;// #12 X Factor
#define mAxis12YFactor			M1292		;// #12 Y Factor
#define mAxis12ZFactor			M1293		;// #12 Z Factor
#define mAxis12XOffset			M1294		;// #12 Offset

;// Registers associated with Encoder/DAC #13 (Usually #define Motor #13) 

#define mAxis13EnableBit		M1314		;// #13 ACTUAL ENABLE BIT
#define mAxis13HmFlag			M1320		;// #13 HMFL input status
#define mAxis13PosLim			M1321		;// #13 +LIM input status
#define mAxis13NegLim			M1322		;// #13 -LIM input status
#define mAxis13Fault			M1323		;// #13 FAULT input status

;// #define Motor #13 Status Bits
#define mAxis13OnPositionLim	M1330		;// #13 Stopped-on-position-limit bit
#define mAxis13PosEndLim		M1331		;// #13 Positive-end-limit-set bit
#define mAxis13NegEndLim		M1332		;// #13 Negative-end-limit-set bit
#define mAxis13ZeroVelBit		M1333		;// #13 Desired-velocity-zero bit
#define mAxis13InDwell			M1335		;// #13 Dwell-in-progress bit
#define mAxis13Running			M1337		;// #13 Running-program bit
#define mAxis13OpenLoop			M1338		;// #13 Open-loop-mode bit
#define mAxis13AmpEnable		M1339		;// #13 Amplifier-enabled status bit
#define mAxis13InPosition		M1340		;// #13 In-position bit
#define mAxis13Warning			M1341		;// #13 Warning-following error bit
#define mAxis13FatFolBit		M1342		;// #13 Fatal-following-error bit
#define mAxis13AmpFault			M1343		;// #13 Amplifier-fault-error bit
#define mAxis13HomeDone			M1345		;// #13 Home-complete bit
#define mAxis13PhasingFault		M1348		;// #13 Phase Fault
#define mAxis13Phasing			M1349		;// #13 Phasing	

;// #define Motor #13 #define Move Registers
#define mAxis13CmdPos			M1361		;// #13 Commanded position (1/[Ix08*32] cts)
#define mAxis13ActualPos		M1362		;// #13 Actual position (1/[Ix08*32] cts)
#define mAxis13EndPos			M1363		;// #13 Target (end) position (1/[Ix08*32] cts)
#define mAxis13PosBias			M1364		;// #13 Position bias (1/[Ix08*32] cts)
#define mAxis13ActualVel		M1366		;// #13 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis13MasterPos		M1367		;// #13 Present master pos (1/[Ix08*32] cts)
#define mAxis13Filter			M1368		;// #13 Filter Output (DAC bits)
#define mAxis13Compensation		M1369		;// #13 Compensation correction
#define mAxis13PhasePos			M1371		;// #13 Present phase position
#define mAxis13JogPosition		M1372		;// #13 Variable Jog Position
#define mAxis13HomeCapturePos	M1373		;// #13 Home Capture Position
#define mAxis13AvgVel			M1374		;// #13 Avg Velocity
#define mAxis13QuadI			M1375		;// #13 Actual Quadrature Current
#define mAxis13DirI				M1376		;// #13 Actual Direct Current
#define mAxis13DesiredVel		M1379		;// #13 Previous Desired Velocity

#define mAxis13JogVelMax		M1380		;// #13 Maximum Jog Speed(cts/msec)
#define mAxis13PosCmpA			M1381		;// #13 Position Compare A 
#define mAxis13PosCmpB			M1382		;// #13 Position Compare B 

;// Motor #13 Axis Definition Registers
#define mAxis13XFactor			M1391		;// #13 X Factor
#define mAxis13YFactor			M1392		;// #13 Y Factor
#define mAxis13ZFactor			M1393		;// #13 Z Factor
#define mAxis13XOffset			M1394		;// #13 Offset

;// Registers associated with Encoder/DAC #14 (Usually #define Motor #14) 

#define mAxis14EnableBit		M1414		;// #14 ACTUAL ENABLE BIT
#define mAxis14HmFlag			M1420		;// #14 HMFL input status
#define mAxis14PosLim			M1421		;// #14 +LIM input status
#define mAxis14NegLim			M1422		;// #14 -LIM input status
#define mAxis14Fault			M1423		;// #14 FAULT input status

;// #define Motor #14 Status Bits
#define mAxis14OnPositionLim	M1430		;// #14 Stopped-on-position-limit bit
#define mAxis14PosEndLim		M1431		;// #14 Positive-end-limit-set bit
#define mAxis14NegEndLim		M1432		;// #14 Negative-end-limit-set bit
#define mAxis14ZeroVelBit		M1433		;// #14 Desired-velocity-zero bit
#define mAxis14InDwell			M1435		;// #14 Dwell-in-progress bit
#define mAxis14Running			M1437		;// #14 Running-program bit
#define mAxis14OpenLoop			M1438		;// #14 Open-loop-mode bit
#define mAxis14AmpEnable		M1439		;// #14 Amplifier-enabled status bit
#define mAxis14InPosition		M1440		;// #14 In-position bit
#define mAxis14Warning			M1441		;// #14 Warning-following error bit
#define mAxis14FatFolBit		M1442		;// #14 Fatal-following-error bit
#define mAxis14AmpFault			M1443		;// #14 Amplifier-fault-error bit
#define mAxis14HomeDone			M1445		;// #14 Home-complete bit
#define mAxis14PhasingFault		M1448		;// #14 Phase Fault
#define mAxis14Phasing			M1449		;// #14 Phasing	

;// #define Motor #14 #define Move Registers
#define mAxis14CmdPos			M1461		;// #14 Commanded position (1/[Ix08*32] cts)
#define mAxis14ActualPos		M1462		;// #14 Actual position (1/[Ix08*32] cts)
#define mAxis14EndPos			M1463		;// #14 Target (end) position (1/[Ix08*32] cts)
#define mAxis14PosBias			M1464		;// #14 Position bias (1/[Ix08*32] cts)
#define mAxis14ActualVel		M1465		;// #14 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis14MasterPos		M1467		;// #14 Present master pos (1/[Ix08*32] cts)
#define mAxis14Filter			M1468		;// #14 Filter Output (DAC bits)
#define mAxis14Compensation		M1469		;// #14 Compensation correction
#define mAxis14PhasePos			M1471		;// #14 Present phase position
#define mAxis14JogPosition		M1472		;// #14 Variable Jog Position
#define mAxis14HomeCapturePos	M1473		;// #14 Home Capture Position
#define mAxis14AvgVel			M1474		;// #14 Avg Velocity
#define mAxis14QuadI			M1475		;// #14 Actual Quadrature Current
#define mAxis14DirI				M1476		;// #14 Actual Direct Current
#define mAxis14DesiredVel		M1479		;// #14 Previous Desired Velocity

#define mAxis14JogVelMax		M1480		;// #14 Maximum Jog Speed(cts/msec)
#define mAxis14PosCmpA			M1481		;// #14 Position Compare A 
#define mAxis14PosCmpB			M1482		;// #14 Position Compare B 

;// Motor #14 Axis Definition Registers
#define mAxis14XFactor			M1491		;// #14 X Factor
#define mAxis14YFactor			M1492		;// #14 Y Factor
#define mAxis14ZFactor			M1493		;// #14 Z Factor
#define mAxis14XOffset			M1494		;// #14 Offset

;// Registers associated with Encoder/DAC #15 (Usually #define Motor #15) 

#define mAxis15EnableBit		M1514		;// #15 ACTUAL ENABLE BIT
#define mAxis15HmFlag			M1520		;// #15 HMFL input status
#define mAxis15PosLim			M1521		;// #15 +LIM input status
#define mAxis15NegLim			M1522		;// #15 -LIM input status
#define mAxis15Fault			M1523		;// #15 FAULT input status

;// #define Motor #15 Status Bits
#define mAxis15OnPositionLim	M1530		;// #15 Stopped-on-position-limit bit
#define mAxis15PosEndLim		M1531		;// #15 Positive-end-limit-set bit
#define mAxis15NegEndLim		M1532		;// #15 Negative-end-limit-set bit
#define mAxis15ZeroVelBit		M1533		;// #15 Desired-velocity-zero bit
#define mAxis15InDwell			M1535		;// #15 Dwell-in-progress bit
#define mAxis15Running			M1537		;// #15 Running-program bit
#define mAxis15OpenLoop			M1538		;// #15 Open-loop-mode bit
#define mAxis15AmpEnable		M1539		;// #15 Amplifier-enabled status bit
#define mAxis15InPosition		M1540		;// #15 In-position bit
#define mAxis15Warning			M1541		;// #15 Warning-following error bit
#define mAxis15FatFolBit		M1542		;// #15 Fatal-following-error bit
#define mAxis15AmpFault			M1543		;// #15 Amplifier-fault-error bit
#define mAxis15HomeDone			M1545		;// #15 Home-complete bit
#define mAxis15PhasingFault		M1548		;// #15 Phase Fault
#define mAxis15Phasing			M1549		;// #15 Phasing	

;// #define Motor #15 #define Move Registers
#define mAxis15CmdPos			M1561		;// #15 Commanded position (1/[Ix08*32] cts)
#define mAxis15ActualPos		M1562		;// #15 Actual position (1/[Ix08*32] cts)
#define mAxis15EndPos			M1563		;// #15 Target (end) position (1/[Ix08*32] cts)
#define mAxis15PosBias			M1564		;// #15 Position bias (1/[Ix08*32] cts)
#define mAxis15ActualVel		M1565		;// #15 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis15MasterPos		M1567		;// #15 Present master pos (1/[Ix08*32] cts)
#define mAxis15Filter			M1568		;// #15 Filter Output (DAC bits)
#define mAxis15Compensation		M1569		;// #15 Compensation correction
#define mAxis15PhasePos			M1571		;// #15 Present phase position
#define mAxis15JogPosition		M1572		;// #15 Variable Jog Position
#define mAxis15HomeCapturePos	M1573		;// #15 Home Capture Position
#define mAxis15AvgVel			M1574		;// #15 Avg Velocity
#define mAxis15QuadI			M1575		;// #15 Actual Quadrature Current
#define mAxis15DirI				M1576		;// #15 Actual Direct Current
#define mAxis15DesiredVel		M1579		;// #15 Previous Desired Velocity

#define mAxis15JogVelMax		M1580		;// #15 Maximum Jog Speed(cts/msec)
#define mAxis15PosCmpA			M1581		;// #15 Position Compare A 
#define mAxis15PosCmpB			M1582		;// #15 Position Compare B 

;// Motor #15 Axis Definition Registers
#define mAxis15XFactor			M1591		;// #15 X Factor
#define mAxis15YFactor			M1592		;// #15 Y Factor
#define mAxis15ZFactor			M1593		;// #15 Z Factor
#define mAxis15XOffset			M1594		;// #15 Offset

;// Registers associated with Encoder/DAC #16 (Usually #define Motor #16) 

#define mAxis16EnableBit		M1614		;// #16 ACTUAL ENABLE BIT
#define mAxis16HmFlag			M1620		;// #16 HMFL input status
#define mAxis16PosLim			M1621		;// #16 +LIM input status
#define mAxis16NegLim			M1622		;// #16 -LIM input status
#define mAxis16Fault			M1623		;// #16 FAULT input status

;// #define Motor #16 Status Bits
#define mAxis16OnPositionLim	M1630		;// #16 Stopped-on-position-limit bit
#define mAxis16PosEndLim		M1631		;// #16 Positive-end-limit-set bit
#define mAxis16NegEndLim		M1632		;// #16 Negative-end-limit-set bit
#define mAxis16ZeroVelBit		M1633		;// #16 Desired-velocity-zero bit
#define mAxis16InDwell			M1635		;// #16 Dwell-in-progress bit
#define mAxis16Running			M1637		;// #16 Running-program bit
#define mAxis16OpenLoop			M1638		;// #16 Open-loop-mode bit
#define mAxis16AmpEnable		M1639		;// #16 Amplifier-enabled status bit
#define mAxis16InPosition		M1640		;// #16 In-position bit
#define mAxis16Warning			M1641		;// #16 Warning-following error bit
#define mAxis16FatFolBit		M1642		;// #16 Fatal-following-error bit
#define mAxis16AmpFault			M1643		;// #16 Amplifier-fault-error bit
#define mAxis16HomeDone			M1645		;// #16 Home-complete bit
#define mAxis16PhasingFault		M1648		;// #16 Phase Fault
#define mAxis16Phasing			M1649		;// #16 Phasing	

;// #define Motor #16 #define Move Registers
#define mAxis16CmdPos			M1661		;// #16 Commanded position (1/[Ix08*32] cts)
#define mAxis16ActualPos		M1662		;// #16 Actual position (1/[Ix08*32] cts)
#define mAxis16EndPos			M1663		;// #16 Target (end) position (1/[Ix08*32] cts)
#define mAxis16PosBias			M1664		;// #16 Position bias (1/[Ix08*32] cts)
#define mAxis16ActualVel		M1665		;// #16 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis16MasterPos		M1667		;// #16 Present master pos (1/[Ix08*32] cts)
#define mAxis16Filter			M1668		;// #16 Filter Output (DAC bits)
#define mAxis16Compensation		M1669		;// #16 Compensation correction
#define mAxis16PhasePos			M1671		;// #16 Present phase position
#define mAxis16JogPosition		M1672		;// #16 Variable Jog Position
#define mAxis16HomeCapturePos	M1673		;// #16 Home Capture Position
#define mAxis16AvgVel			M1674		;// #16 Avg Velocity
#define mAxis16QuadI			M1675		;// #16 Actual Quadrature Current
#define mAxis16DirI				M1676		;// #16 Actual Direct Current
#define mAxis16DesiredVel		M1679		;// #16 Previous Desired Velocity

#define mAxis16JogVelMax		M1680		;// #16 Maximum Jog Speed(cts/msec)
#define mAxis16PosCmpA			M1681		;// #16 Position Compare A 
#define mAxis16PosCmpB			M1682		;// #16 Position Compare B 

;// Motor #16 Axis Definition Registers
#define mAxis16XFactor			M1691		;// #16 X Factor
#define mAxis16YFactor			M1692		;// #16 Y Factor
#define mAxis16ZFactor			M1693		;// #16 Z Factor
#define mAxis16XOffset			M1694		;// #16 Offset

;// Registers associated with Encoder/DAC #17 (Usually #define Motor #17) 

#define mAxis17EnableBit		M1714		;// #17 ACTUAL ENABLE BIT
#define mAxis17HmFlag			M1720		;// #17 HMFL input status
#define mAxis17PosLim			M1721		;// #17 +LIM input status
#define mAxis17NegLim			M1722		;// #17 -LIM input status
#define mAxis17Fault			M1723		;// #17 FAULT input status

;// #define Motor #17 Status Bits
#define mAxis17OnPositionLim	M1730		;// #17 Stopped-on-position-limit bit
#define mAxis17PosEndLim		M1731		;// #17 Positive-end-limit-set bit
#define mAxis17NegEndLim		M1732		;// #17 Negative-end-limit-set bit
#define mAxis17ZeroVelBit		M1733		;// #17 Desired-velocity-zero bit
#define mAxis17InDwell			M1735		;// #17 Dwell-in-progress bit
#define mAxis17Running			M1737		;// #17 Running-program bit
#define mAxis17OpenLoop			M1738		;// #17 Open-loop-mode bit
#define mAxis17AmpEnable		M1739		;// #17 Amplifier-enabled status bit
#define mAxis17InPosition		M1740		;// #17 In-position bit
#define mAxis17Warning			M1741		;// #17 Warning-following error bit
#define mAxis17FatFolBit		M1742		;// #17 Fatal-following-error bit
#define mAxis17AmpFault			M1743		;// #17 Amplifier-fault-error bit
#define mAxis17HomeDone			M1745		;// #17 Home-complete bit
#define mAxis17PhasingFault		M1748		;// #17 Phase Fault
#define mAxis17Phasing			M1749		;// #17 Phasing	

;// #define Motor #17 #define Move Registers
#define mAxis17CmdPos			M1761		;// #17 Commanded position (1/[Ix08*32] cts)
#define mAxis17ActualPos		M1762		;// #17 Actual position (1/[Ix08*32] cts)
#define mAxis17EndPos			M1763		;// #17 Target (end) position (1/[Ix08*32] cts)
#define mAxis17PosBias			M1764		;// #17 Position bias (1/[Ix08*32] cts)
#define mAxis17ActualVel		M1765		;// #17 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis17MasterPos		M1767		;// #17 Present master pos (1/[Ix08*32] cts)
#define mAxis17Filter			M1768		;// #17 Filter Output (DAC bits)
#define mAxis17Compensation		M1769		;// #17 Compensation correction
#define mAxis17PhasePos			M1771		;// #17 Present phase position
#define mAxis17JogPosition		M1772		;// #17 Variable Jog Position
#define mAxis17HomeCapturePos	M1773		;// #17 Home Capture Position
#define mAxis17AvgVel			M1774		;// #17 Avg Velocity
#define mAxis17QuadI			M1775		;// #17 Actual Quadrature Current
#define mAxis17DirI				M1776		;// #17 Actual Direct Current
#define mAxis17DesiredVel		M1779		;// #17 Previous Desired Velocity

#define mAxis17JogVelMax		M1780		;// #17 Maximum Jog Speed(cts/msec)
#define mAxis17PosCmpA			M1781		;// #17 Position Compare A 
#define mAxis17PosCmpB			M1782		;// #17 Position Compare B 

;// Motor #17 Axis Definition Registers
#define mAxis17XFactor			M1791		;// #17 X Factor
#define mAxis17YFactor			M1792		;// #17 Y Factor
#define mAxis17ZFactor			M1793		;// #17 Z Factor
#define mAxis17XOffset			M1794		;// #17 Offset

;// Registers associated with Encoder/DAC #18 (Usually #define Motor #18) 

#define mAxis18EnableBit		M1814		;// #18 ACTUAL ENABLE BIT
#define mAxis18HmFlag			M1820		;// #18 HMFL input status
#define mAxis18PosLim			M1821		;// #18 +LIM input status
#define mAxis18NegLim			M1822		;// #18 -LIM input status
#define mAxis18Fault			M1823		;// #18 FAULT input status

;// #define Motor #18 Status Bits
#define mAxis18OnPositionLim	M1830		;// #18 Stopped-on-position-limit bit
#define mAxis18PosEndLim		M1831		;// #18 Positive-end-limit-set bit
#define mAxis18NegEndLim		M1832		;// #18 Negative-end-limit-set bit
#define mAxis18ZeroVelBit		M1833		;// #18 Desired-velocity-zero bit
#define mAxis18InDwell			M1835		;// #18 Dwell-in-progress bit
#define mAxis18Running			M1837		;// #18 Running-program bit
#define mAxis18OpenLoop			M1838		;// #18 Open-loop-mode bit
#define mAxis18AmpEnable		M1839		;// #18 Amplifier-enabled status bit
#define mAxis18InPosition		M1840		;// #18 In-position bit
#define mAxis18Warning			M1841		;// #18 Warning-following error bit
#define mAxis18FatFolBit		M1842		;// #18 Fatal-following-error bit
#define mAxis18AmpFault			M1843		;// #18 Amplifier-fault-error bit
#define mAxis18HomeDone			M1845		;// #18 Home-complete bit
#define mAxis18PhasingFault		M1848		;// #18 Phase Fault
#define mAxis18Phasing			M1849		;// #18 Phasing	

;// #define Motor #18 #define Move Registers
#define mAxis18CmdPos			M1861		;// #18 Commanded position (1/[Ix08*32] cts)
#define mAxis18ActualPos		M1862		;// #18 Actual position (1/[Ix08*32] cts)
#define mAxis18EndPos			M1863		;// #18 Target (end) position (1/[Ix08*32] cts)
#define mAxis18PosBias			M1864		;// #18 Position bias (1/[Ix08*32] cts)
#define mAxis18ActualVel		M1865		;// #18 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis18MasterPos		M1867		;// #18 Present master pos (1/[Ix08*32] cts)
#define mAxis18Filter			M1868		;// #18 Filter Output (DAC bits)
#define mAxis18Compensation		M1869		;// #18 Compensation correction
#define mAxis18PhasePos			M1871		;// #18 Present phase position
#define mAxis18JogPosition		M1872		;// #18 Variable Jog Position
#define mAxis18HomeCapturePos	M1873		;// #18 Home Capture Position
#define mAxis18AvgVel			M1874		;// #18 Avg Velocity
#define mAxis18QuadI			M1875		;// #18 Actual Quadrature Current
#define mAxis18DirI				M1876		;// #18 Actual Direct Current
#define mAxis18DesiredVel		M1879		;// #18 Previous Desired Velocity

#define mAxis18JogVelMax		M1880		;// #18 Maximum Jog Speed(cts/msec)
#define mAxis18PosCmpA			M1881		;// #18 Position Compare A 
#define mAxis18PosCmpB			M1882		;// #18 Position Compare B 

;// Motor #18 Axis Definition Registers
#define mAxis18XFactor			M1891		;// #18 X Factor
#define mAxis18YFactor			M1892		;// #18 Y Factor
#define mAxis18ZFactor			M1893		;// #18 Z Factor
#define mAxis18XOffset			M1894		;// #18 Offset

;// Registers associated with Encoder/DAC #19 (Usually #define Motor #19) 

#define mAxis19EnableBit		M1914		;// #19 ACTUAL ENABLE BIT
#define mAxis19HmFlag			M1920		;// #19 HMFL input status
#define mAxis19PosLim			M1921		;// #19 +LIM input status
#define mAxis19NegLim			M1922		;// #19 -LIM input status
#define mAxis19Fault			M1923		;// #19 FAULT input status

;// #define Motor #19 Status Bits
#define mAxis19OnPositionLim	M1930		;// #19 Stopped-on-position-limit bit
#define mAxis19PosEndLim		M1931		;// #19 Positive-end-limit-set bit
#define mAxis19NegEndLim		M1932		;// #19 Negative-end-limit-set bit
#define mAxis19ZeroVelBit		M1933		;// #19 Desired-velocity-zero bit
#define mAxis19InDwell			M1935		;// #19 Dwell-in-progress bit
#define mAxis19Running			M1937		;// #19 Running-program bit
#define mAxis19OpenLoop			M1938		;// #19 Open-loop-mode bit
#define mAxis19AmpEnable		M1939		;// #19 Amplifier-enabled status bit
#define mAxis19InPosition		M1940		;// #19 In-position bit
#define mAxis19Warning			M1941		;// #19 Warning-following error bit
#define mAxis19FatFolBit		M1942		;// #19 Fatal-following-error bit
#define mAxis19AmpFault			M1943		;// #19 Amplifier-fault-error bit
#define mAxis19HomeDone			M1945		;// #19 Home-complete bit
#define mAxis19PhasingFault		M1948		;// #19 Phase Fault
#define mAxis19Phasing			M1949		;// #19 Phasing	

;// #define Motor #19 #define Move Registers
#define mAxis19CmdPos			M1961		;// #19 Commanded position (1/[Ix08*32] cts)
#define mAxis19ActualPos		M1962		;// #19 Actual position (1/[Ix08*32] cts)
#define mAxis19EndPos			M1963		;// #19 Target (end) position (1/[Ix08*32] cts)
#define mAxis19PosBias			M1964		;// #19 Position bias (1/[Ix08*32] cts)
#define mAxis19ActualVel		M1965		;// #19 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis19MasterPos		M1967		;// #19 Present master pos (1/[Ix08*32] cts)
#define mAxis19Filter			M1968		;// #19 Filter Output (DAC bits)
#define mAxis19Compensation		M1969		;// #19 Compensation correction
#define mAxis19PhasePos			M1971		;// #19 Present phase position
#define mAxis19JogPosition		M1972		;// #19 Variable Jog Position
#define mAxis19HomeCapturePos	M1973		;// #19 Home Capture Position
#define mAxis19AvgVel			M1974		;// #19 Avg Velocity
#define mAxis19QuadI			M1975		;// #19 Actual Quadrature Current
#define mAxis19DirI				M1976		;// #19 Actual Direct Current
#define mAxis19DesiredVel		M1979		;// #19 Previous Desired Velocity

#define mAxis19JogVelMax		M1980		;// #19 Maximum Jog Speed(cts/msec)
#define mAxis19PosCmpA			M1981		;// #19 Position Compare A 
#define mAxis19PosCmpB			M1982		;// #19 Position Compare B 

;// Motor #19 Axis Definition Registers
#define mAxis19XFactor			M1991		;// #19 X Factor
#define mAxis19YFactor			M1992		;// #19 Y Factor
#define mAxis19ZFactor			M1993		;// #19 Z Factor
#define mAxis19XOffset			M1994		;// #19 Offset

;// Registers associated with Encoder/DAC #20 (Usually #define Motor #20) 

#define mAxis20EnableBit		M2014		;// #20 ACTUAL ENABLE BIT
#define mAxis20HmFlag			M2020		;// #20 HMFL input status
#define mAxis20PosLim			M2021		;// #20 +LIM input status
#define mAxis20NegLim			M2022		;// #20 -LIM input status
#define mAxis20Fault			M2023		;// #20 FAULT input status

;// #define Motor #20 Status Bits
#define mAxis20OnPositionLim	M2030		;// #20 Stopped-on-position-limit bit
#define mAxis20PosEndLim		M2031		;// #20 Positive-end-limit-set bit
#define mAxis20NegEndLim		M2032		;// #20 Negative-end-limit-set bit
#define mAxis20ZeroVelBit		M2033		;// #20 Desired-velocity-zero bit
#define mAxis20InDwell			M2035		;// #20 Dwell-in-progress bit
#define mAxis20Running			M2037		;// #20 Running-program bit
#define mAxis20OpenLoop			M2038		;// #20 Open-loop-mode bit
#define mAxis20AmpEnable		M2039		;// #20 Amplifier-enabled status bit
#define mAxis20InPosition		M2040		;// #20 In-position bit
#define mAxis20Warning			M2041		;// #20 Warning-following error bit
#define mAxis20FatFolBit		M2042		;// #20 Fatal-following-error bit
#define mAxis20AmpFault			M2043		;// #20 Amplifier-fault-error bit
#define mAxis20HomeDone			M2045		;// #20 Home-complete bit
#define mAxis20PhasingFault		M2048		;// #20 Phase Fault
#define mAxis20Phasing			M2049		;// #20 Phasing	

;// #define Motor #20 #define Move Registers
#define mAxis20CmdPos			M2061		;// #20 Commanded position (1/[Ix08*32] cts)
#define mAxis20ActualPos		M2062		;// #20 Actual position (1/[Ix08*32] cts)
#define mAxis20EndPos			M2063		;// #20 Target (end) position (1/[Ix08*32] cts)
#define mAxis20PosBias			M2064		;// #20 Position bias (1/[Ix08*32] cts)
#define mAxis20ActualVel		M2065		;// #20 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis20MasterPos		M2067		;// #20 Present master pos (1/[Ix08*32] cts)
#define mAxis20Filter			M2068		;// #20 Filter Output (DAC bits)
#define mAxis20Compensation		M2069		;// #20 Compensation correction
#define mAxis20PhasePos			M2071		;// #20 Present phase position
#define mAxis20JogPosition		M2072		;// #20 Variable Jog Position
#define mAxis20HomeCapturePos	M2073		;// #20 Home Capture Position
#define mAxis20AvgVel			M2074		;// #20 Avg Velocity
#define mAxis20QuadI			M2075		;// #20 Actual Quadrature Current
#define mAxis20DirI				M2076		;// #20 Actual Direct Current
#define mAxis20DesiredVel		M2079		;// #20 Previous Desired Velocity

#define mAxis20JogVelMax		M2080		;// #20 Maximum Jog Speed(cts/msec)
#define mAxis20PosCmpA			M2081		;// #20 Position Compare A 
#define mAxis20PosCmpB			M2082		;// #20 Position Compare B 

;// Motor #20 Axis Definition Registers
#define mAxis20XFactor			M2091		;// #20 X Factor
#define mAxis20YFactor			M2092		;// #20 Y Factor
#define mAxis20ZFactor			M2093		;// #20 Z Factor
#define mAxis20XOffset			M2094		;// #20 Offset

;// Registers associated with Encoder/DAC #21 (Usually #define Motor #21) 

#define mAxis21EnableBit		M2114		;// #21 ACTUAL ENABLE BIT
#define mAxis21HmFlag			M2120		;// #21 HMFL input status
#define mAxis21PosLim			M2121		;// #21 +LIM input status
#define mAxis21NegLim			M2122		;// #21 -LIM input status
#define mAxis21Fault			M2123		;// #21 FAULT input status

;// #define Motor #21 Status Bits
#define mAxis21OnPositionLim	M2130		;// #21 Stopped-on-position-limit bit
#define mAxis21PosEndLim		M2131		;// #21 Positive-end-limit-set bit
#define mAxis21NegEndLim		M2132		;// #21 Negative-end-limit-set bit
#define mAxis21ZeroVelBit		M2133		;// #21 Desired-velocity-zero bit
#define mAxis21InDwell			M2135		;// #21 Dwell-in-progress bit
#define mAxis21Running			M2137		;// #21 Running-program bit
#define mAxis21OpenLoop			M2138		;// #21 Open-loop-mode bit
#define mAxis21AmpEnable		M2139		;// #21 Amplifier-enabled status bit
#define mAxis21InPosition		M2140		;// #21 In-position bit
#define mAxis21Warning			M2141		;// #21 Warning-following error bit
#define mAxis21FatFolBit		M2142		;// #21 Fatal-following-error bit
#define mAxis21AmpFault			M2143		;// #21 Amplifier-fault-error bit
#define mAxis21HomeDone			M2145		;// #21 Home-complete bit
#define mAxis21PhasingFault		M2148		;// #21 Phase Fault
#define mAxis21Phasing			M2149		;// #21 Phasing	

;// #define Motor #21 #define Move Registers
#define mAxis21CmdPos			M2161		;// #21 Commanded position (1/[Ix08*32] cts)
#define mAxis21ActualPos		M2162		;// #21 Actual position (1/[Ix08*32] cts)
#define mAxis21EndPos			M2163		;// #21 Target (end) position (1/[Ix08*32] cts)
#define mAxis21PosBias			M2164		;// #21 Position bias (1/[Ix08*32] cts)
#define mAxis21ActualVel		M2165		;// #21 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis21MasterPos		M2167		;// #21 Present master pos (1/[Ix08*32] cts)
#define mAxis21Filter			M2168		;// #21 Filter Output (DAC bits)
#define mAxis21Compensation		M2169		;// #21 Compensation correction
#define mAxis21PhasePos			M2171		;// #21 Present phase position
#define mAxis21JogPosition		M2172		;// #21 Variable Jog Position
#define mAxis21HomeCapturePos	M2173		;// #21 Home Capture Position
#define mAxis21AvgVel			M2174		;// #21 Avg Velocity
#define mAxis21QuadI			M2175		;// #21 Actual Quadrature Current
#define mAxis21DirI				M2176		;// #21 Actual Direct Current
#define mAxis21DesiredVel		M2179		;// #21 Previous Desired Velocity

#define mAxis21JogVelMax		M2180		;// #21 Maximum Jog Speed(cts/msec)
#define mAxis21PosCmpA			M2181		;// #21 Position Compare A 
#define mAxis21PosCmpB			M2182		;// #21 Position Compare B 

;// Motor #21 Axis Definition Registers
#define mAxis21XFactor			M2191		;// #21 X Factor
#define mAxis21YFactor			M2192		;// #21 Y Factor
#define mAxis21ZFactor			M2193		;// #21 Z Factor
#define mAxis21XOffset			M2194		;// #21 Offset

;// Registers associated with Encoder/DAC #22 (Usually #define Motor #22) 

#define mAxis22EnableBit		M2214		;// #22 ACTUAL ENABLE BIT
#define mAxis22HmFlag			M2220		;// #22 HMFL input status
#define mAxis22PosLim			M2221		;// #22 +LIM input status
#define mAxis22NegLim			M2222		;// #22 -LIM input status
#define mAxis22Fault			M2223		;// #22 FAULT input status

;// #define Motor #22 Status Bits
#define mAxis22OnPositionLim	M2230		;// #22 Stopped-on-position-limit bit
#define mAxis22PosEndLim		M2231		;// #22 Positive-end-limit-set bit
#define mAxis22NegEndLim		M2232		;// #22 Negative-end-limit-set bit
#define mAxis22ZeroVelBit		M2233		;// #22 Desired-velocity-zero bit
#define mAxis22InDwell			M2235		;// #22 Dwell-in-progress bit
#define mAxis22Running			M2237		;// #22 Running-program bit
#define mAxis22OpenLoop			M2238		;// #22 Open-loop-mode bit
#define mAxis22AmpEnable		M2239		;// #22 Amplifier-enabled status bit
#define mAxis22InPosition		M2240		;// #22 In-position bit
#define mAxis22Warning			M2241		;// #22 Warning-following error bit
#define mAxis22FatFolBit		M2242		;// #22 Fatal-following-error bit
#define mAxis22AmpFault			M2243		;// #22 Amplifier-fault-error bit
#define mAxis22HomeDone			M2245		;// #22 Home-complete bit
#define mAxis22PhasingFault		M2248		;// #22 Phase Fault
#define mAxis22Phasing			M2249		;// #22 Phasing	

;// #define Motor #22 #define Move Registers
#define mAxis22CmdPos			M2261		;// #22 Commanded position (1/[Ix08*32] cts)
#define mAxis22ActualPos		M2262		;// #22 Actual position (1/[Ix08*32] cts)
#define mAxis22EndPos			M2263		;// #22 Target (end) position (1/[Ix08*32] cts)
#define mAxis22PosBias			M2264		;// #22 Position bias (1/[Ix08*32] cts)
#define mAxis22ActualVel		M2265		;// #22 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis22MasterPos		M2267		;// #22 Present master pos (1/[Ix08*32] cts)
#define mAxis22Filter			M2268		;// #22 Filter Output (DAC bits)
#define mAxis22Compensation		M2269		;// #22 Compensation correction
#define mAxis22PhasePos			M2271		;// #22 Present phase position
#define mAxis22JogPosition		M2272		;// #22 Variable Jog Position
#define mAxis22HomeCapturePos	M2273		;// #22 Home Capture Position
#define mAxis22AvgVel			M2274		;// #22 Avg Velocity
#define mAxis22QuadI			M2275		;// #22 Actual Quadrature Current
#define mAxis22DirI				M2276		;// #22 Actual Direct Current
#define mAxis22DesiredVel		M2279		;// #22 Previous Desired Velocity

#define mAxis22JogVelMax		M2280		;// #22 Maximum Jog Speed(cts/msec)
#define mAxis22PosCmpA			M2281		;// #22 Position Compare A 
#define mAxis22PosCmpB			M2282		;// #22 Position Compare B 

;// Motor #22 Axis Definition Registers
#define mAxis22XFactor			M2291		;// #22 X Factor
#define mAxis22YFactor			M2292		;// #22 Y Factor
#define mAxis22ZFactor			M2293		;// #22 Z Factor
#define mAxis22XOffset			M2294		;// #22 Offset

;// Registers associated with Encoder/DAC #23 (Usually #define Motor #23) 

#define mAxis23EnableBit		M2314		;// #23 ACTUAL ENABLE BIT
#define mAxis23HmFlag			M2320		;// #23 HMFL input status
#define mAxis23PosLim			M2321		;// #23 +LIM input status
#define mAxis23NegLim			M2322		;// #23 -LIM input status
#define mAxis23Fault			M2323		;// #23 FAULT input status

;// #define Motor #23 Status Bits
#define mAxis23OnPositionLim	M2330		;// #23 Stopped-on-position-limit bit
#define mAxis23PosEndLim		M2331		;// #23 Positive-end-limit-set bit
#define mAxis23NegEndLim		M2332		;// #23 Negative-end-limit-set bit
#define mAxis23ZeroVelBit		M2333		;// #23 Desired-velocity-zero bit
#define mAxis23InDwell			M2335		;// #23 Dwell-in-progress bit
#define mAxis23Running			M2337		;// #23 Running-program bit
#define mAxis23OpenLoop			M2338		;// #23 Open-loop-mode bit
#define mAxis23AmpEnable		M2339		;// #23 Amplifier-enabled status bit
#define mAxis23InPosition		M2340		;// #23 In-position bit
#define mAxis23Warning			M2341		;// #23 Warning-following error bit
#define mAxis23FatFolBit		M2342		;// #23 Fatal-following-error bit
#define mAxis23AmpFault			M2343		;// #23 Amplifier-fault-error bit
#define mAxis23HomeDone			M2345		;// #23 Home-complete bit
#define mAxis23PhasingFault		M2348		;// #23 Phase Fault
#define mAxis23Phasing			M2349		;// #23 Phasing	

;// #define Motor #23 #define Move Registers
#define mAxis23CmdPos			M2361		;// #23 Commanded position (1/[Ix08*32] cts)
#define mAxis23ActualPos		M2362		;// #23 Actual position (1/[Ix08*32] cts)
#define mAxis23EndPos			M2363		;// #23 Target (end) position (1/[Ix08*32] cts)
#define mAxis23PosBias			M2364		;// #23 Position bias (1/[Ix08*32] cts)
#define mAxis23ActualVel		M2365		;// #23 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis23MasterPos		M2367		;// #23 Present master pos (1/[Ix08*32] cts)
#define mAxis23Filter			M2368		;// #23 Filter Output (DAC bits)
#define mAxis23Compensation		M2369		;// #23 Compensation correction
#define mAxis23PhasePos			M2371		;// #23 Present phase position
#define mAxis23JogPosition		M2372		;// #23 Variable Jog Position
#define mAxis23HomeCapturePos	M2373		;// #23 Home Capture Position
#define mAxis23AvgVel			M2374		;// #23 Avg Velocity
#define mAxis23QuadI			M2375		;// #23 Actual Quadrature Current
#define mAxis23DirI				M2376		;// #23 Actual Direct Current
#define mAxis23DesiredVel		M2379		;// #23 Previous Desired Velocity

#define mAxis23JogVelMax		M2380		;// #23 Maximum Jog Speed(cts/msec)
#define mAxis23PosCmpA			M2381		;// #23 Position Compare A 
#define mAxis23PosCmpB			M2382		;// #23 Position Compare B 

;// Motor #23 Axis Definition Registers
#define mAxis23XFactor			M2391		;// #23 X Factor
#define mAxis23YFactor			M2392		;// #23 Y Factor
#define mAxis23ZFactor			M2393		;// #23 Z Factor
#define mAxis23XOffset			M2394		;// #23 Offset

;// Registers associated with Encoder/DAC #24 (Usually #define Motor #24) 

#define mAxis24EnableBit		M2414		;// #24 ACTUAL ENABLE BIT
#define mAxis24HmFlag			M2420		;// #24 HMFL input status
#define mAxis24PosLim			M2421		;// #24 +LIM input status
#define mAxis24NegLim			M2422		;// #24 -LIM input status
#define mAxis24Fault			M2423		;// #24 FAULT input status

;// #define Motor #24 Status Bits
#define mAxis24OnPositionLim	M2430		;// #24 Stopped-on-position-limit bit
#define mAxis24PosEndLim		M2431		;// #24 Positive-end-limit-set bit
#define mAxis24NegEndLim		M2432		;// #24 Negative-end-limit-set bit
#define mAxis24ZeroVelBit		M2433		;// #24 Desired-velocity-zero bit
#define mAxis24InDwell			M2435		;// #24 Dwell-in-progress bit
#define mAxis24Running			M2437		;// #24 Running-program bit
#define mAxis24OpenLoop			M2438		;// #24 Open-loop-mode bit
#define mAxis24AmpEnable		M2439		;// #24 Amplifier-enabled status bit
#define mAxis24InPosition		M2440		;// #24 In-position bit
#define mAxis24Warning			M2441		;// #24 Warning-following error bit
#define mAxis24FatFolBit		M2442		;// #24 Fatal-following-error bit
#define mAxis24AmpFault			M2443		;// #24 Amplifier-fault-error bit
#define mAxis24HomeDone			M2445		;// #24 Home-complete bit
#define mAxis24PhasingFault		M2448		;// #24 Phase Fault
#define mAxis24Phasing			M2449		;// #24 Phasing	

;// #define Motor #24 #define Move Registers
#define mAxis24CmdPos			M2461		;// #24 Commanded position (1/[Ix08*32] cts)
#define mAxis24ActualPos		M2462		;// #24 Actual position (1/[Ix08*32] cts)
#define mAxis24EndPos			M2463		;// #24 Target (end) position (1/[Ix08*32] cts)
#define mAxis24PosBias			M2464		;// #24 Position bias (1/[Ix08*32] cts)
#define mAxis24ActualVel		M2465		;// #24 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis24MasterPos		M2467		;// #24 Present master pos (1/[Ix08*32] cts)
#define mAxis24Filter			M2468		;// #24 Filter Output (DAC bits)
#define mAxis24Compensation		M2469		;// #24 Compensation correction
#define mAxis24PhasePos			M2471		;// #24 Present phase position
#define mAxis24JogPosition		M2472		;// #24 Variable Jog Position
#define mAxis24HomeCapturePos	M2473		;// #24 Home Capture Position
#define mAxis24AvgVel			M2474		;// #24 Avg Velocity
#define mAxis24QuadI			M2475		;// #24 Actual Quadrature Current
#define mAxis24DirI				M2476		;// #24 Actual Direct Current
#define mAxis24DesiredVel		M2479		;// #24 Previous Desired Velocity

#define mAxis24JogVelMax		M2480		;// #24 Maximum Jog Speed(cts/msec)
#define mAxis24PosCmpA			M2481		;// #24 Position Compare A 
#define mAxis24PosCmpB			M2482		;// #24 Position Compare B 

;// Motor #24 Axis Definition Registers
#define mAxis24XFactor			M2491		;// #24 X Factor
#define mAxis24YFactor			M2492		;// #24 Y Factor
#define mAxis24ZFactor			M2493		;// #24 Z Factor
#define mAxis24XOffset			M2494		;// #24 Offset

;// Registers associated with Encoder/DAC #25 (Usually #define Motor #25) 

#define mAxis25EnableBit		M2514		;// #25 ACTUAL ENABLE BIT
#define mAxis25HmFlag			M2520		;// #25 HMFL input status
#define mAxis25PosLim			M2521		;// #25 +LIM input status
#define mAxis25NegLim			M2522		;// #25 -LIM input status
#define mAxis25Fault			M2523		;// #25 FAULT input status

;// #define Motor #25 Status Bits
#define mAxis25OnPositionLim	M2530		;// #25 Stopped-on-position-limit bit
#define mAxis25PosEndLim		M2531		;// #25 Positive-end-limit-set bit
#define mAxis25NegEndLim		M2532		;// #25 Negative-end-limit-set bit
#define mAxis25ZeroVelBit		M2533		;// #25 Desired-velocity-zero bit
#define mAxis25InDwell			M2535		;// #25 Dwell-in-progress bit
#define mAxis25Running			M2537		;// #25 Running-program bit
#define mAxis25OpenLoop			M2538		;// #25 Open-loop-mode bit
#define mAxis25AmpEnable		M2539		;// #25 Amplifier-enabled status bit
#define mAxis25InPosition		M2540		;// #25 In-position bit
#define mAxis25Warning			M2541		;// #25 Warning-following error bit
#define mAxis25FatFolBit		M2542		;// #25 Fatal-following-error bit
#define mAxis25AmpFault			M2543		;// #25 Amplifier-fault-error bit
#define mAxis25HomeDone			M2545		;// #25 Home-complete bit
#define mAxis25PhasingFault		M2548		;// #25 Phase Fault
#define mAxis25Phasing			M2549		;// #25 Phasing	

;// #define Motor #25 #define Move Registers
#define mAxis25CmdPos			M2561		;// #25 Commanded position (1/[Ix08*32] cts)
#define mAxis25ActualPos		M2562		;// #25 Actual position (1/[Ix08*32] cts)
#define mAxis25EndPos			M2563		;// #25 Target (end) position (1/[Ix08*32] cts)
#define mAxis25PosBias			M2564		;// #25 Position bias (1/[Ix08*32] cts)
#define mAxis25ActualVel		M2565		;// #25 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis25MasterPos		M2567		;// #25 Present master pos (1/[Ix08*32] cts)
#define mAxis25Filter			M2568		;// #25 Filter Output (DAC bits)
#define mAxis25Compensation		M2569		;// #25 Compensation correction
#define mAxis25PhasePos			M2571		;// #25 Present phase position
#define mAxis25JogPosition		M2572		;// #25 Variable Jog Position
#define mAxis25HomeCapturePos	M2573		;// #25 Home Capture Position
#define mAxis25AvgVel			M2574		;// #25 Avg Velocity
#define mAxis25QuadI			M2575		;// #25 Actual Quadrature Current
#define mAxis25DirI				M2576		;// #25 Actual Direct Current
#define mAxis25DesiredVel		M2579		;// #25 Previous Desired Velocity

#define mAxis25JogVelMax		M2580		;// #25 Maximum Jog Speed(cts/msec)
#define mAxis25PosCmpA			M2581		;// #25 Position Compare A 
#define mAxis25PosCmpB			M2582		;// #25 Position Compare B 

;// Motor #25 Axis Definition Registers
#define mAxis25XFactor			M2591		;// #25 X Factor
#define mAxis25YFactor			M2592		;// #25 Y Factor
#define mAxis25ZFactor			M2593		;// #25 Z Factor
#define mAxis25XOffset			M2594		;// #25 Offset

;// Registers associated with Encoder/DAC #26 (Usually #define Motor #26) 

#define mAxis26EnableBit		M2614		;// #26 ACTUAL ENABLE BIT
#define mAxis26HmFlag			M2620		;// #26 HMFL input status
#define mAxis26PosLim			M2621		;// #26 +LIM input status
#define mAxis26NegLim			M2622		;// #26 -LIM input status
#define mAxis26Fault			M2623		;// #26 FAULT input status

;// #define Motor #26 Status Bits
#define mAxis26OnPositionLim	M2630		;// #26 Stopped-on-position-limit bit
#define mAxis26PosEndLim		M2631		;// #26 Positive-end-limit-set bit
#define mAxis26NegEndLim		M2632		;// #26 Negative-end-limit-set bit
#define mAxis26ZeroVelBit		M2633		;// #26 Desired-velocity-zero bit
#define mAxis26InDwell			M2635		;// #26 Dwell-in-progress bit
#define mAxis26Running			M2637		;// #26 Running-program bit
#define mAxis26OpenLoop			M2638		;// #26 Open-loop-mode bit
#define mAxis26AmpEnable		M2639		;// #26 Amplifier-enabled status bit
#define mAxis26InPosition		M2640		;// #26 In-position bit
#define mAxis26Warning			M2641		;// #26 Warning-following error bit
#define mAxis26FatFolBit		M2642		;// #26 Fatal-following-error bit
#define mAxis26AmpFault			M2643		;// #26 Amplifier-fault-error bit
#define mAxis26HomeDone			M2645		;// #26 Home-complete bit
#define mAxis26PhasingFault		M2648		;// #26 Phase Fault
#define mAxis26Phasing			M2649		;// #26 Phasing	

;// #define Motor #26 #define Move Registers
#define mAxis26CmdPos			M2661		;// #26 Commanded position (1/[Ix08*32] cts)
#define mAxis26ActualPos		M2662		;// #26 Actual position (1/[Ix08*32] cts)
#define mAxis26EndPos			M2663		;// #26 Target (end) position (1/[Ix08*32] cts)
#define mAxis26PosBias			M2664		;// #26 Position bias (1/[Ix08*32] cts)
#define mAxis26ActualVel		M2665		;// #26 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis26MasterPos		M2667		;// #26 Present master pos (1/[Ix08*32] cts)
#define mAxis26Filter			M2668		;// #26 Filter Output (DAC bits)
#define mAxis26Compensation		M2669		;// #26 Compensation correction
#define mAxis26PhasePos			M2671		;// #26 Present phase position
#define mAxis26JogPosition		M2672		;// #26 Variable Jog Position
#define mAxis26HomeCapturePos	M2673		;// #26 Home Capture Position
#define mAxis26AvgVel			M2674		;// #26 Avg Velocity
#define mAxis26QuadI			M2675		;// #26 Actual Quadrature Current
#define mAxis26DirI				M2676		;// #26 Actual Direct Current
#define mAxis26DesiredVel		M2679		;// #26 Previous Desired Velocity

#define mAxis26JogVelMax		M2680		;// #26 Maximum Jog Speed(cts/msec)
#define mAxis26PosCmpA			M2681		;// #26 Position Compare A 
#define mAxis26PosCmpB			M2682		;// #26 Position Compare B 

;// Motor #26 Axis Definition Registers
#define mAxis26XFactor			M2691		;// #26 X Factor
#define mAxis26YFactor			M2692		;// #26 Y Factor
#define mAxis26ZFactor			M2693		;// #26 Z Factor
#define mAxis26XOffset			M2694		;// #26 Offset

;// Registers associated with Encoder/DAC #27 (Usually #define Motor #27) 

#define mAxis27EnableBit		M2714		;// #27 ACTUAL ENABLE BIT
#define mAxis27HmFlag			M2720		;// #27 HMFL input status
#define mAxis27PosLim			M2721		;// #27 +LIM input status
#define mAxis27NegLim			M2722		;// #27 -LIM input status
#define mAxis27Fault			M2723		;// #27 FAULT input status

;// #define Motor #27 Status Bits
#define mAxis27OnPositionLim	M2730		;// #27 Stopped-on-position-limit bit
#define mAxis27PosEndLim		M2731		;// #27 Positive-end-limit-set bit
#define mAxis27NegEndLim		M2732		;// #27 Negative-end-limit-set bit
#define mAxis27ZeroVelBit		M2733		;// #27 Desired-velocity-zero bit
#define mAxis27InDwell			M2735		;// #27 Dwell-in-progress bit
#define mAxis27Running			M2737		;// #27 Running-program bit
#define mAxis27OpenLoop			M2738		;// #27 Open-loop-mode bit
#define mAxis27AmpEnable		M2739		;// #27 Amplifier-enabled status bit
#define mAxis27InPosition		M2740		;// #27 In-position bit
#define mAxis27Warning			M2741		;// #27 Warning-following error bit
#define mAxis27FatFolBit		M2742		;// #27 Fatal-following-error bit
#define mAxis27AmpFault			M2743		;// #27 Amplifier-fault-error bit
#define mAxis27HomeDone			M2745		;// #27 Home-complete bit
#define mAxis27PhasingFault		M2748		;// #27 Phase Fault
#define mAxis27Phasing			M2749		;// #27 Phasing	

;// #define Motor #27 #define Move Registers
#define mAxis27CmdPos			M2761		;// #27 Commanded position (1/[Ix08*32] cts)
#define mAxis27ActualPos		M2762		;// #27 Actual position (1/[Ix08*32] cts)
#define mAxis27EndPos			M2763		;// #27 Target (end) position (1/[Ix08*32] cts)
#define mAxis27PosBias			M2764		;// #27 Position bias (1/[Ix08*32] cts)
#define mAxis27ActualVel		M2765		;// #27 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis27MasterPos		M2767		;// #27 Present master pos (1/[Ix08*32] cts)
#define mAxis27Filter			M2768		;// #27 Filter Output (DAC bits)
#define mAxis27Compensation		M2769		;// #27 Compensation correction
#define mAxis27PhasePos			M2791		;// #27 Present phase position
#define mAxis27JogPosition		M2792		;// #27 Variable Jog Position
#define mAxis27HomeCapturePos	M2793		;// #27 Home Capture Position
#define mAxis27AvgVel			M2794		;// #27 Avg Velocity
#define mAxis27QuadI			M2795		;// #27 Actual Quadrature Current
#define mAxis27DirI				M2796		;// #27 Actual Direct Current
#define mAxis27DesiredVel		M2797		;// #27 Previous Desired Velocity

#define mAxis27JogVelMax		M2780		;// #27 Maximum Jog Speed(cts/msec)
#define mAxis27PosCmpA			M2781		;// #27 Position Compare A 
#define mAxis27PosCmpB			M2782		;// #27 Position Compare B 

;// Motor #27 Axis Definition Registers
#define mAxis27XFactor			M2791		;// #27 X Factor
#define mAxis27YFactor			M2792		;// #27 Y Factor
#define mAxis27ZFactor			M2793		;// #27 Z Factor
#define mAxis27XOffset			M2794		;// #27 Offset

;// Registers associated with Encoder/DAC #28 (Usually #define Motor #28) 

#define mAxis28EnableBit		M2814		;// #28 ACTUAL ENABLE BIT
#define mAxis28HmFlag			M2820		;// #28 HMFL input status
#define mAxis28PosLim			M2821		;// #28 +LIM input status
#define mAxis28NegLim			M2822		;// #28 -LIM input status
#define mAxis28Fault			M2823		;// #28 FAULT input status

;// #define Motor #28 Status Bits
#define mAxis28OnPositionLim	M2830		;// #28 Stopped-on-position-limit bit
#define mAxis28PosEndLim		M2831		;// #28 Positive-end-limit-set bit
#define mAxis28NegEndLim		M2832		;// #28 Negative-end-limit-set bit
#define mAxis28ZeroVelBit		M2833		;// #28 Desired-velocity-zero bit
#define mAxis28InDwell			M2835		;// #28 Dwell-in-progress bit
#define mAxis28Running			M2837		;// #28 Running-program bit
#define mAxis28OpenLoop			M2838		;// #28 Open-loop-mode bit
#define mAxis28AmpEnable		M2839		;// #28 Amplifier-enabled status bit
#define mAxis28InPosition		M2840		;// #28 In-position bit
#define mAxis28Warning			M2841		;// #28 Warning-following error bit
#define mAxis28FatFolBit		M2842		;// #28 Fatal-following-error bit
#define mAxis28AmpFault			M2843		;// #28 Amplifier-fault-error bit
#define mAxis28HomeDone			M2845		;// #28 Home-complete bit
#define mAxis28PhasingFault		M2848		;// #28 Phase Fault
#define mAxis28Phasing			M2849		;// #28 Phasing	

;// #define Motor #28 #define Move Registers
#define mAxis28CmdPos			M2861		;// #28 Commanded position (1/[Ix08*32] cts)
#define mAxis28ActualPos		M2862		;// #28 Actual position (1/[Ix08*32] cts)
#define mAxis28EndPos			M2863		;// #28 Target (end) position (1/[Ix08*32] cts)
#define mAxis28PosBias			M2864		;// #28 Position bias (1/[Ix08*32] cts)
#define mAxis28ActualVel		M2865		;// #28 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis28MasterPos		M2867		;// #28 Present master pos (1/[Ix08*32] cts)
#define mAxis28Filter			M2868		;// #28 Filter Output (DAC bits)
#define mAxis28Compensation		M2869		;// #28 Compensation correction
#define mAxis28PhasePos			M2871		;// #28 Present phase position
#define mAxis28JogPosition		M2872		;// #28 Variable Jog Position
#define mAxis28HomeCapturePos	M2873		;// #28 Home Capture Position
#define mAxis28AvgVel			M2874		;// #28 Avg Velocity
#define mAxis28QuadI			M2875		;// #28 Actual Quadrature Current
#define mAxis28DirI				M2876		;// #28 Actual Direct Current
#define mAxis28DesiredVel		M2879		;// #28 Previous Desired Velocity

#define mAxis28JogVelMax		M2880		;// #28 Maximum Jog Speed(cts/msec)
#define mAxis28PosCmpA			M2881		;// #28 Position Compare A 
#define mAxis28PosCmpB			M2882		;// #28 Position Compare B 

;// Motor #28 Axis Definition Registers
#define mAxis28XFactor			M2891		;// #28 X Factor
#define mAxis28YFactor			M2892		;// #28 Y Factor
#define mAxis28ZFactor			M2893		;// #28 Z Factor
#define mAxis28XOffset			M2894		;// #28 Offset

;// Registers associated with Encoder/DAC #29 (Usually #define Motor #29) 

#define mAxis29EnableBit		M2914		;// #29 ACTUAL ENABLE BIT
#define mAxis29HmFlag			M2920		;// #29 HMFL input status
#define mAxis29PosLim			M2921		;// #29 +LIM input status
#define mAxis29NegLim			M2922		;// #29 -LIM input status
#define mAxis29Fault			M2923		;// #29 FAULT input status

;// #define Motor #29 Status Bits
#define mAxis29OnPositionLim	M2930		;// #29 Stopped-on-position-limit bit
#define mAxis29PosEndLim		M2931		;// #29 Positive-end-limit-set bit
#define mAxis29NegEndLim		M2932		;// #29 Negative-end-limit-set bit
#define mAxis29ZeroVelBit		M2933		;// #29 Desired-velocity-zero bit
#define mAxis29InDwell			M2935		;// #29 Dwell-in-progress bit
#define mAxis29Running			M2937		;// #29 Running-program bit
#define mAxis29OpenLoop			M2938		;// #29 Open-loop-mode bit
#define mAxis29AmpEnable		M2939		;// #29 Amplifier-enabled status bit
#define mAxis29InPosition		M2940		;// #29 In-position bit
#define mAxis29Warning			M2941		;// #29 Warning-following error bit
#define mAxis29FatFolBit		M2942		;// #29 Fatal-following-error bit
#define mAxis29AmpFault			M2943		;// #29 Amplifier-fault-error bit
#define mAxis29HomeDone			M2945		;// #29 Home-complete bit
#define mAxis29PhasingFault		M2948		;// #29 Phase Fault
#define mAxis29Phasing			M2949		;// #29 Phasing	

;// #define Motor #29 #define Move Registers
#define mAxis29CmdPos			M2961		;// #29 Commanded position (1/[Ix08*32] cts)
#define mAxis29ActualPos		M2962		;// #29 Actual position (1/[Ix08*32] cts)
#define mAxis29EndPos			M2963		;// #29 Target (end) position (1/[Ix08*32] cts)
#define mAxis29PosBias			M2964		;// #29 Position bias (1/[Ix08*32] cts)
#define mAxis29ActualVel		M2965		;// #29 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis29MasterPos		M2967		;// #29 Present master pos (1/[Ix08*32] cts)
#define mAxis29Filter			M2968		;// #29 Filter Output (DAC bits)
#define mAxis29Compensation		M2969		;// #29 Compensation correction
#define mAxis29PhasePos			M2971		;// #29 Present phase position
#define mAxis29JogPosition		M2972		;// #29 Variable Jog Position
#define mAxis29HomeCapturePos	M2973		;// #29 Home Capture Position
#define mAxis29AvgVel			M2974		;// #29 Avg Velocity
#define mAxis29QuadI			M2975		;// #29 Actual Quadrature Current
#define mAxis29DirI				M2976		;// #29 Actual Direct Current
#define mAxis29DesiredVel		M2979		;// #29 Previous Desired Velocity

#define mAxis29JogVelMax		M2980		;// #29 Maximum Jog Speed(cts/msec)
#define mAxis29PosCmpA			M2981		;// #29 Position Compare A 
#define mAxis29PosCmpB			M2982		;// #29 Position Compare B 

;// Motor #29 Axis Definition Registers
#define mAxis29XFactor			M2991		;// #29 X Factor
#define mAxis29YFactor			M2992		;// #29 Y Factor
#define mAxis29ZFactor			M2993		;// #29 Z Factor
#define mAxis29XOffset			M2994		;// #29 Offset

;// Registers associated with Encoder/DAC #30 (Usually #define Motor #30) 

#define mAxis30EnableBit		M3014		;// #30 ACTUAL ENABLE BIT
#define mAxis30HmFlag			M3020		;// #30 HMFL input status
#define mAxis30PosLim			M3021		;// #30 +LIM input status
#define mAxis30NegLim			M3022		;// #30 -LIM input status
#define mAxis30Fault			M3023		;// #30 FAULT input status

;// #define Motor #30 Status Bits
#define mAxis30OnPositionLim	M3030		;// #30 Stopped-on-position-limit bit
#define mAxis30PosEndLim		M3031		;// #30 Positive-end-limit-set bit
#define mAxis30NegEndLim		M3032		;// #30 Negative-end-limit-set bit
#define mAxis30ZeroVelBit		M3033		;// #30 Desired-velocity-zero bit
#define mAxis30InDwell			M3035		;// #30 Dwell-in-progress bit
#define mAxis30Running			M3037		;// #30 Running-program bit
#define mAxis30OpenLoop			M3038		;// #30 Open-loop-mode bit
#define mAxis30AmpEnable		M3039		;// #30 Amplifier-enabled status bit
#define mAxis30InPosition		M3040		;// #30 In-position bit
#define mAxis30Warning			M3041		;// #30 Warning-following error bit
#define mAxis30FatFolBit		M3042		;// #30 Fatal-following-error bit
#define mAxis30AmpFault			M3043		;// #30 Amplifier-fault-error bit
#define mAxis30HomeDone			M3045		;// #30 Home-complete bit
#define mAxis30PhasingFault		M3048		;// #30 Phase Fault
#define mAxis30Phasing			M3049		;// #30 Phasing	

;// #define Motor #30 #define Move Registers
#define mAxis30CmdPos			M3061		;// #30 Commanded position (1/[Ix08*32] cts)
#define mAxis30ActualPos		M3062		;// #30 Actual position (1/[Ix08*32] cts)
#define mAxis30EndPos			M3063		;// #30 Target (end) position (1/[Ix08*32] cts)
#define mAxis30PosBias			M3064		;// #30 Position bias (1/[Ix08*32] cts)
#define mAxis30ActualVel		M3065		;// #30 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis30MasterPos		M3067		;// #30 Present master pos (1/[Ix08*32] cts)
#define mAxis30Filter			M3068		;// #30 Filter Output (DAC bits)
#define mAxis30Compensation		M3069		;// #30 Compensation correction
#define mAxis30PhasePos			M3071		;// #30 Present phase position
#define mAxis30JogPosition		M3072		;// #30 Variable Jog Position
#define mAxis30HomeCapturePos	M3073		;// #30 Home Capture Position
#define mAxis30AvgVel			M3074		;// #30 Avg Velocity
#define mAxis30QuadI			M3075		;// #30 Actual Quadrature Current
#define mAxis30DirI				M3076		;// #30 Actual Direct Current
#define mAxis30DesiredVel		M3079		;// #30 Previous Desired Velocity

#define mAxis30JogVelMax		M3080		;// #30 Maximum Jog Speed(cts/msec)
#define mAxis30PosCmpA			M3081		;// #30 Position Compare A 
#define mAxis30PosCmpB			M3082		;// #30 Position Compare B 

;// Motor #30 Axis Definition Registers
#define mAxis30XFactor			M3091		;// #30 X Factor
#define mAxis30YFactor			M3092		;// #30 Y Factor
#define mAxis30ZFactor			M3093		;// #30 Z Factor
#define mAxis30XOffset			M3094		;// #30 Offset

;// Registers associated with Encoder/DAC #31 (Usually #define Motor #31) 

#define mAxis31EnableBit		M3114		;// #31 ACTUAL ENABLE BIT
#define mAxis31HmFlag			M3120		;// #31 HMFL input status
#define mAxis31PosLim			M3121		;// #31 +LIM input status
#define mAxis31NegLim			M3122		;// #31 -LIM input status
#define mAxis31Fault			M3123		;// #31 FAULT input status

;// #define Motor #31 Status Bits
#define mAxis31OnPositionLim	M3130		;// #31 Stopped-on-position-limit bit
#define mAxis31PosEndLim		M3131		;// #31 Positive-end-limit-set bit
#define mAxis31NegEndLim		M3132		;// #31 Negative-end-limit-set bit
#define mAxis31ZeroVelBit		M3133		;// #31 Desired-velocity-zero bit
#define mAxis31InDwell			M3135		;// #31 Dwell-in-progress bit
#define mAxis31Running			M3137		;// #31 Running-program bit
#define mAxis31OpenLoop			M3138		;// #31 Open-loop-mode bit
#define mAxis31AmpEnable		M3139		;// #31 Amplifier-enabled status bit
#define mAxis31InPosition		M3140		;// #31 In-position bit
#define mAxis31Warning			M3141		;// #31 Warning-following error bit
#define mAxis31FatFolBit		M3142		;// #31 Fatal-following-error bit
#define mAxis31AmpFault			M3143		;// #31 Amplifier-fault-error bit
#define mAxis31HomeDone			M3145		;// #31 Home-complete bit
#define mAxis31PhasingFault		M3148		;// #31 Phase Fault
#define mAxis31Phasing			M3149		;// #31 Phasing	

;// #define Motor #31 #define Move Registers
#define mAxis31CmdPos			M3161		;// #31 Commanded position (1/[Ix08*32] cts)
#define mAxis31ActualPos		M3162		;// #31 Actual position (1/[Ix08*32] cts)
#define mAxis31EndPos			M3163		;// #31 Target (end) position (1/[Ix08*32] cts)
#define mAxis31PosBias			M3164		;// #31 Position bias (1/[Ix08*32] cts)
#define mAxis31ActualVel		M3165		;// #31 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis31MasterPos		M3167		;// #31 Present master pos (1/[Ix08*32] cts)
#define mAxis31Filter			M3168		;// #31 Filter Output (DAC bits)
#define mAxis31Compensation		M3169		;// #31 Compensation correction
#define mAxis31PhasePos			M3171		;// #31 Present phase position
#define mAxis31JogPosition		M3172		;// #31 Variable Jog Position
#define mAxis31HomeCapturePos	M3173		;// #31 Home Capture Position
#define mAxis31AvgVel			M3174		;// #31 Avg Velocity
#define mAxis31QuadI			M3175		;// #31 Actual Quadrature Current
#define mAxis31DirI				M3176		;// #31 Actual Direct Current
#define mAxis31DesiredVel		M3179		;// #31 Previous Desired Velocity

#define mAxis31JogVelMax		M3180		;// #31 Maximum Jog Speed(cts/msec)
#define mAxis31PosCmpA			M3181		;// #31 Position Compare A 
#define mAxis31PosCmpB			M3182		;// #31 Position Compare B 

;// Motor #31 Axis Definition Registers
#define mAxis31XFactor			M3191		;// #31 X Factor
#define mAxis31YFactor			M3192		;// #31 Y Factor
#define mAxis31ZFactor			M3193		;// #31 Z Factor
#define mAxis31XOffset			M3194		;// #31 Offset

;// Registers associated with Encoder/DAC #32 (Usually #define Motor #32) 

#define mAxis32EnableBit		M3214		;// #32 ACTUAL ENABLE BIT
#define mAxis32HmFlag			M3220		;// #32 HMFL input status
#define mAxis32PosLim			M3221		;// #32 +LIM input status
#define mAxis32NegLim			M3222		;// #32 -LIM input status
#define mAxis32Fault			M3223		;// #32 FAULT input status

;// #define Motor #32 Status Bits
#define mAxis32OnPositionLim	M3230		;// #32 Stopped-on-position-limit bit
#define mAxis32PosEndLim		M3231		;// #32 Positive-end-limit-set bit
#define mAxis32NegEndLim		M3232		;// #32 Negative-end-limit-set bit
#define mAxis32ZeroVelBit		M3233		;// #32 Desired-velocity-zero bit
#define mAxis32InDwell			M3235		;// #32 Dwell-in-progress bit
#define mAxis32Running			M3237		;// #32 Running-program bit
#define mAxis32OpenLoop			M3238		;// #32 Open-loop-mode bit
#define mAxis32AmpEnable		M3239		;// #32 Amplifier-enabled status bit
#define mAxis32InPosition		M3240		;// #32 In-position bit
#define mAxis32Warning			M3241		;// #32 Warning-following error bit
#define mAxis32FatFolBit		M3242		;// #32 Fatal-following-error bit
#define mAxis32AmpFault			M3243		;// #32 Amplifier-fault-error bit
#define mAxis32HomeDone			M3245		;// #32 Home-complete bit
#define mAxis32PhasingFault		M3248		;// #32 Phase Fault
#define mAxis32Phasing			M3249		;// #32 Phasing	

;// #define Motor #32 #define Move Registers
#define mAxis32CmdPos			M3261		;// #32 Commanded position (1/[Ix08*32] cts)
#define mAxis32ActualPos		M3262		;// #32 Actual position (1/[Ix08*32] cts)
#define mAxis32EndPos			M3263		;// #32 Target (end) position (1/[Ix08*32] cts)
#define mAxis32PosBias			M3264		;// #32 Position bias (1/[Ix08*32] cts)
#define mAxis32ActualVel		M3265		;// #32 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis32MasterPos		M3267		;// #32 Present master pos (1/[Ix08*32] cts)
#define mAxis32Filter			M3268		;// #32 Filter Output (DAC bits)
#define mAxis32Compensation		M3269		;// #32 Compensation correction
#define mAxis32PhasePos			M3271		;// #32 Present phase position
#define mAxis32JogPosition		M3272		;// #32 Variable Jog Position
#define mAxis32HomeCapturePos	M3273		;// #32 Home Capture Position
#define mAxis32AvgVel			M3274		;// #32 Avg Velocity
#define mAxis32QuadI			M3275		;// #32 Actual Quadrature Current
#define mAxis32DirI				M3276		;// #32 Actual Direct Current
#define mAxis32DesiredVel		M3279		;// #32 Previous Desired Velocity

#define mAxis32JogVelMax		M3280		;// #32 Maximum Jog Speed(cts/msec)
#define mAxis32PosCmpA			M3281		;// #32 Position Compare A 
#define mAxis32PosCmpB			M3282		;// #32 Position Compare B 

;// Motor #32 Axis Definition Registers
#define mAxis32XFactor			M3291		;// #32 X Factor
#define mAxis32YFactor			M3292		;// #32 Y Factor
#define mAxis32ZFactor			M3293		;// #32 Z Factor
#define mAxis32XOffset			M3294		;// #32 Offset

;// Coordinate System &1 Status Bits 
#define mCoor1Timer1			M5111		;// &1 Isx11 Timer1 (for synchronous assignment)
#define mCoor1Timer2			M5112		;// &1 Isx11 Timer2 (for synchronous assignment)

#define mCoor1AAxisTargetPos	M5141		;// &1 A-Axis Target Position
#define mCoor1BAxisTargetPos	M5142		;// &1 B-Axis Target Position
#define mCoor1CAxisTargetPos	M5143		;// &1 C-Axis Target Position
#define mCoor1UAxisTargetPos	M5144		;// &1 U-Axis Target Position
#define mCoor1VAxisTargetPos	M5145		;// &1 V-Axis Target Position
#define mCoor1WAxisTargetPos	M5146		;// &1 W-Axis Target Position
#define mCoor1XAxisTargetPos	M5147		;// &1 X-Axis Target Position
#define mCoor1YAxisTargetPos	M5148		;// &1 Y-Axis Target Position
#define mCoor1ZAxisTargetPos	M5149		;// &1 Z-Axis Target Position

#define mCoor1Running			M5180		;// &1 Program-running bit
#define mCoor1RadError			M5181		;// &1 Circle-radius-error bit
#define mCoor1RuntimeError		M5182		;// &1 Run-time-error bit
#define mCoor1ContinuousMot		M5184		;// &1 Continuous Motion requested
#define mCoor1InPos				M5187		;// &1 In-position bit (AND of motors)
#define mCoor1FatFolWarning		M5188		;// &1 Warning-following-error bit (OR)
#define mCoor1FatFolError		M5189		;// &1 Fatal-following-error bit (OR)
#define mCoor1AmpFault			M5190		;// &1 Amp-fault-error bit (OR of motors)

#define mCoor1HostTimeBase		M5197		;// &1 Host commanded Time Base (I10 units)
#define mCoor1PresTimeBase		M5198		;// &1 Present Time Base (I10 units)

;// Coordinate System &2 Status Bits 
#define mCoor2Timer1			M5211		;// &2 Isx11 Timer1 (for synchronous assignment)
#define mCoor2Timer2			M5212		;// &2 Isx11 Timer2 (for synchronous assignment)

#define mCoor2AAxisTargetPos	M5241		;// &2 A-Axis Target Position
#define mCoor2BAxisTargetPos	M5242		;// &2 B-Axis Target Position
#define mCoor2CAxisTargetPos	M5243		;// &2 C-Axis Target Position
#define mCoor2UAxisTargetPos	M5244		;// &2 U-Axis Target Position
#define mCoor2VAxisTargetPos	M5245		;// &2 V-Axis Target Position
#define mCoor2WAxisTargetPos	M5246		;// &2 W-Axis Target Position
#define mCoor2XAxisTargetPos	M5247		;// &2 X-Axis Target Position
#define mCoor2YAxisTargetPos	M5248		;// &2 Y-Axis Target Position
#define mCoor2ZAxisTargetPos	M5249		;// &2 Z-Axis Target Position

#define mCoor2Running			M5280		;// &2 Program-running bit
#define mCoor2RadError			M5281		;// &2 Circle-radius-error bit
#define mCoor2RuntimeError		M5282		;// &2 Run-time-error bit
#define mCoor2ContinuousMot		M5284		;// &2 Continuous Motion requested
#define mCoor2InPos				M5287		;// &2 In-position bit (AND of motors)
#define mCoor2FatFolWarning		M5288		;// &2 Warning-following-error bit (OR)
#define mCoor2FatFolError		M5289		;// &2 Fatal-following-error bit (OR)
#define mCoor2AmpFault			M5290		;// &2 Amp-fault-error bit (OR of motors)

#define mCoor2HostTimeBase		M5297		;// &2 Host commanded Time Base (I10 units)
#define mCoor2PresTimeBase		M5298		;// &2 Present Time Base (I10 units)

;// Coordinate System &3 Status Bits 
#define mCoor3Timer1			M5311		;// &3 Isx11 Timer1 (for synchronous assignment)
#define mCoor3Timer2			M5312		;// &3 Isx11 Timer2 (for synchronous assignment)

#define mCoor3AAxisTargetPos	M5341		;// &3 A-Axis Target Position
#define mCoor3BAxisTargetPos	M5342		;// &3 B-Axis Target Position
#define mCoor3CAxisTargetPos	M5343		;// &3 C-Axis Target Position
#define mCoor3UAxisTargetPos	M5344		;// &3 U-Axis Target Position
#define mCoor3VAxisTargetPos	M5345		;// &3 V-Axis Target Position
#define mCoor3WAxisTargetPos	M5346		;// &3 W-Axis Target Position
#define mCoor3XAxisTargetPos	M5347		;// &3 X-Axis Target Position
#define mCoor3YAxisTargetPos	M5348		;// &3 Y-Axis Target Position
#define mCoor3ZAxisTargetPos	M5349		;// &3 Z-Axis Target Position

#define mCoor3Running			M5380		;// &3 Program-running bit
#define mCoor3RadError			M5381		;// &3 Circle-radius-error bit
#define mCoor3RuntimeError		M5382		;// &3 Run-time-error bit
#define mCoor3ContinuousMot		M5384		;// &3 Continuous Motion requested
#define mCoor3InPos				M5387		;// &3 In-position bit (AND of motors)
#define mCoor3FatFolWarning		M5388		;// &3 Warning-following-error bit (OR)
#define mCoor3FatFolError		M5389		;// &3 Fatal-following-error bit (OR)
#define mCoor3AmpFault			M5390		;// &3 Amp-fault-error bit (OR of motors)

#define mCoor3HostTimeBase		M5397		;// &3 Host commanded Time Base (I10 units)
#define mCoor3PresTimeBase		M5398		;// &3 Present Time Base (I10 units)


;// Coordinate System &4 Status Bits 
#define mCoor4Timer1			M5411		;// &4 Isx11 Timer1 (for synchronous assignment)
#define mCoor4Timer2			M5412		;// &4 Isx11 Timer2 (for synchronous assignment)

#define mCoor4AAxisTargetPos	M5441		;// &4 A-Axis Target Position
#define mCoor4BAxisTargetPos	M5442		;// &4 B-Axis Target Position
#define mCoor4CAxisTargetPos	M5443		;// &4 C-Axis Target Position
#define mCoor4UAxisTargetPos	M5444		;// &4 U-Axis Target Position
#define mCoor4VAxisTargetPos	M5445		;// &4 V-Axis Target Position
#define mCoor4WAxisTargetPos	M5446		;// &4 W-Axis Target Position
#define mCoor4XAxisTargetPos	M5447		;// &4 X-Axis Target Position
#define mCoor4YAxisTargetPos	M5448		;// &4 Y-Axis Target Position
#define mCoor4ZAxisTargetPos	M5449		;// &4 Z-Axis Target Position

#define mCoor4Running			M5480		;// &4 Program-running bit
#define mCoor4RadError			M5481		;// &4 Circle-radius-error bit
#define mCoor4RuntimeError		M5482		;// &4 Run-time-error bit
#define mCoor4ContinuousMot		M5484		;// &4 Continuous Motion requested
#define mCoor4InPos				M5487		;// &4 In-position bit (AND of motors)
#define mCoor4FatFolWarning		M5488		;// &4 Warning-following-error bit (OR)
#define mCoor4FatFolError		M5489		;// &4 Fatal-following-error bit (OR)
#define mCoor4AmpFault			M5490		;// &4 Amp-fault-error bit (OR of motors)

#define mCoor4HostTimeBase		M5497		;// &4 Host commanded Time Base (I10 units)
#define mCoor4PresTimeBase		M5498		;// &4 Present Time Base (I10 units)


;// Coordinate System &5 Status Bits 
#define mCoor5Timer1			M5511		;// &5 Isx11 Timer1 (for synchronous assignment)
#define mCoor5Timer2			M5512		;// &5 Isx11 Timer2 (for synchronous assignment)

#define mCoor5AAxisTargetPos	M5541		;// &5 A-Axis Target Position
#define mCoor5BAxisTargetPos	M5542		;// &5 B-Axis Target Position
#define mCoor5CAxisTargetPos	M5543		;// &5 C-Axis Target Position
#define mCoor5UAxisTargetPos	M5544		;// &5 U-Axis Target Position
#define mCoor5VAxisTargetPos	M5545		;// &5 V-Axis Target Position
#define mCoor5WAxisTargetPos	M5546		;// &5 W-Axis Target Position
#define mCoor5XAxisTargetPos	M5547		;// &5 X-Axis Target Position
#define mCoor5YAxisTargetPos	M5548		;// &5 Y-Axis Target Position
#define mCoor5ZAxisTargetPos	M5549		;// &5 Z-Axis Target Position

#define mCoor5Running			M5580		;// &5 Program-running bit
#define mCoor5RadError			M5581		;// &5 Circle-radius-error bit
#define mCoor5RuntimeError		M5582		;// &5 Run-time-error bit
#define mCoor5ContinuousMot		M5584		;// &5 Continuous Motion requested
#define mCoor5InPos				M5587		;// &5 In-position bit (AND of motors)
#define mCoor5FatFolWarning		M5588		;// &5 Warning-following-error bit (OR)
#define mCoor5FatFolError		M5589		;// &5 Fatal-following-error bit (OR)
#define mCoor5AmpFault			M5590		;// &5 Amp-fault-error bit (OR of motors)

#define mCoor5HostTimeBase		M5597		;// &5 Host commanded Time Base (I10 units)
#define mCoor5PresTimeBase		M5598		;// &5 Present Time Base (I10 units)


;// Coordinate System &6 Status Bits 
#define mCoor6Timer1			M5611		;// &6 Isx11 Timer1 (for synchronous assignment)
#define mCoor6Timer2			M5612		;// &6 Isx11 Timer2 (for synchronous assignment)

#define mCoor6AAxisTargetPos	M5641		;// &6 A-Axis Target Position
#define mCoor6BAxisTargetPos	M5642		;// &6 B-Axis Target Position
#define mCoor6CAxisTargetPos	M5643		;// &6 C-Axis Target Position
#define mCoor6UAxisTargetPos	M5644		;// &6 U-Axis Target Position
#define mCoor6VAxisTargetPos	M5645		;// &6 V-Axis Target Position
#define mCoor6WAxisTargetPos	M5646		;// &6 W-Axis Target Position
#define mCoor6XAxisTargetPos	M5647		;// &6 X-Axis Target Position
#define mCoor6YAxisTargetPos	M5648		;// &6 Y-Axis Target Position
#define mCoor6ZAxisTargetPos	M5649		;// &6 Z-Axis Target Position

#define mCoor6Running			M5680		;// &6 Program-running bit
#define mCoor6RadError			M5681		;// &6 Circle-radius-error bit
#define mCoor6RuntimeError		M5682		;// &6 Run-time-error bit
#define mCoor6ContinuousMot		M5684		;// &6 Continuous Motion requested
#define mCoor6InPos				M5687		;// &6 In-position bit (AND of motors)
#define mCoor6FatFolWarning		M5688		;// &6 Warning-following-error bit (OR)
#define mCoor6FatFolError		M5689		;// &6 Fatal-following-error bit (OR)
#define mCoor6AmpFault			M5690		;// &6 Amp-fault-error bit (OR of motors)

#define mCoor6HostTimeBase		M5697		;// &6 Host commanded Time Base (I10 units)
#define mCoor6PresTimeBase		M5698		;// &6 Present Time Base (I10 units)


;// Coordinate System &7 Status Bits 
#define mCoor7Timer1			M5711		;// &7 Isx11 Timer1 (for synchronous assignment)
#define mCoor7Timer2			M5712		;// &7 Isx11 Timer2 (for synchronous assignment)

#define mCoor7AAxisTargetPos	M5741		;// &7 A-Axis Target Position
#define mCoor7BAxisTargetPos	M5742		;// &7 B-Axis Target Position
#define mCoor7CAxisTargetPos	M5743		;// &7 C-Axis Target Position
#define mCoor7UAxisTargetPos	M5744		;// &7 U-Axis Target Position
#define mCoor7VAxisTargetPos	M5745		;// &7 V-Axis Target Position
#define mCoor7WAxisTargetPos	M5746		;// &7 W-Axis Target Position
#define mCoor7XAxisTargetPos	M5747		;// &7 X-Axis Target Position
#define mCoor7YAxisTargetPos	M5748		;// &7 Y-Axis Target Position
#define mCoor7ZAxisTargetPos	M5749		;// &7 Z-Axis Target Position

#define mCoor7Running			M5780		;// &7 Program-running bit
#define mCoor7RadError			M5781		;// &7 Circle-radius-error bit
#define mCoor7RuntimeError		M5782		;// &7 Run-time-error bit
#define mCoor7ContinuousMot		M5784		;// &7 Continuous Motion requested
#define mCoor7InPos				M5787		;// &7 In-position bit (AND of motors)
#define mCoor7FatFolWarning		M5788		;// &7 Warning-following-error bit (OR)
#define mCoor7FatFolError		M5789		;// &7 Fatal-following-error bit (OR)
#define mCoor7AmpFault			M5790		;// &7 Amp-fault-error bit (OR of motors)

#define mCoor7HostTimeBase		M5797		;// &7 Host commanded Time Base (I10 units)
#define mCoor7PresTimeBase		M5798		;// &7 Present Time Base (I10 units)


;// Coordinate System &8 Status Bits 
#define mCoor8Timer1			M5811		;// &8 Isx11 Timer1 (for synchronous assignment)
#define mCoor8Timer2			M5812		;// &8 Isx11 Timer2 (for synchronous assignment)

#define mCoor8AAxisTargetPos	M5841		;// &8 A-Axis Target Position
#define mCoor8BAxisTargetPos	M5842		;// &8 B-Axis Target Position
#define mCoor8CAxisTargetPos	M5843		;// &8 C-Axis Target Position
#define mCoor8UAxisTargetPos	M5844		;// &8 U-Axis Target Position
#define mCoor8VAxisTargetPos	M5845		;// &8 V-Axis Target Position
#define mCoor8WAxisTargetPos	M5846		;// &8 W-Axis Target Position
#define mCoor8XAxisTargetPos	M5847		;// &8 X-Axis Target Position
#define mCoor8YAxisTargetPos	M5848		;// &8 Y-Axis Target Position
#define mCoor8ZAxisTargetPos	M5849		;// &8 Z-Axis Target Position

#define mCoor8Running			M5880		;// &8 Program-running bit
#define mCoor8RadError			M5881		;// &8 Circle-radius-error bit
#define mCoor8RuntimeError		M5882		;// &8 Run-time-error bit
#define mCoor8ContinuousMot		M5884		;// &8 Continuous Motion requested
#define mCoor8InPos				M5887		;// &8 In-position bit (AND of motors)
#define mCoor8FatFolWarning		M5888		;// &8 Warning-following-error bit (OR)
#define mCoor8FatFolError		M5889		;// &8 Fatal-following-error bit (OR)
#define mCoor8AmpFault			M5890		;// &8 Amp-fault-error bit (OR of motors)

#define mCoor8HostTimeBase		M5897		;// &8 Host commanded Time Base (I10 units)
#define mCoor8PresTimeBase		M5898		;// &8 Present Time Base (I10 units)


;// Coordinate System &9 Status Bits 
#define mCoor9Timer1			M5911		;// &9 Isx11 Timer1 (for synchronous assignment)
#define mCoor9Timer2			M5912		;// &9 Isx11 Timer2 (for synchronous assignment)

#define mCoor9AAxisTargetPos	M5941		;// &9 A-Axis Target Position
#define mCoor9BAxisTargetPos	M5942		;// &9 B-Axis Target Position
#define mCoor9CAxisTargetPos	M5943		;// &9 C-Axis Target Position
#define mCoor9UAxisTargetPos	M5944		;// &9 U-Axis Target Position
#define mCoor9VAxisTargetPos	M5945		;// &9 V-Axis Target Position
#define mCoor9WAxisTargetPos	M5946		;// &9 W-Axis Target Position
#define mCoor9XAxisTargetPos	M5947		;// &9 X-Axis Target Position
#define mCoor9YAxisTargetPos	M5948		;// &9 Y-Axis Target Position
#define mCoor9ZAxisTargetPos	M5949		;// &9 Z-Axis Target Position

#define mCoor9Running			M5980		;// &9 Program-running bit
#define mCoor9RadError			M5981		;// &9 Circle-radius-error bit
#define mCoor9RuntimeError		M5982		;// &9 Run-time-error bit
#define mCoor9ContinuousMot		M5984		;// &9 Continuous Motion requested
#define mCoor9InPos				M5987		;// &9 In-position bit (AND of motors)
#define mCoor9FatFolWarning		M5988		;// &9 Warning-following-error bit (OR)
#define mCoor9FatFolError		M5989		;// &9 Fatal-following-error bit (OR)
#define mCoor9AmpFault			M5990		;// &9 Amp-fault-error bit (OR of motors)

#define mCoor9HostTimeBase		M5997		;// &9 Host commanded Time Base (I10 units)
#define mCoor9PresTimeBase		M5998		;// &9 Present Time Base (I10 units)


;// Coordinate System &10 Status Bits 
#define mCoor10Timer1			M6011		;// &10 Isx11 Timer1 (for synchronous assignment)
#define mCoor10Timer2			M6012		;// &10 Isx11 Timer2 (for synchronous assignment)

#define mCoor10AAxisTargetPos	M6041		;// &10 A-Axis Target Position
#define mCoor10BAxisTargetPos	M6042		;// &10 B-Axis Target Position
#define mCoor10CAxisTargetPos	M6043		;// &10 C-Axis Target Position
#define mCoor10UAxisTargetPos	M6044		;// &10 U-Axis Target Position
#define mCoor10VAxisTargetPos	M6045		;// &10 V-Axis Target Position
#define mCoor10WAxisTargetPos	M6046		;// &10 W-Axis Target Position
#define mCoor10XAxisTargetPos	M6047		;// &10 X-Axis Target Position
#define mCoor10YAxisTargetPos	M6048		;// &10 Y-Axis Target Position
#define mCoor10ZAxisTargetPos	M6049		;// &10 Z-Axis Target Position

#define mCoor10Running			M6080		;// &10 Program-running bit
#define mCoor10RadError			M6081		;// &10 Circle-radius-error bit
#define mCoor10RuntimeError		M6082		;// &10 Run-time-error bit
#define mCoor10ContinuousMot	M6084		;// &10 Continuous Motion requested
#define mCoor10InPos			M6087		;// &10 In-position bit (AND of motors)
#define mCoor10FatFolWarning	M6088		;// &10 Warning-following-error bit (OR)
#define mCoor10FatFolError		M6089		;// &10 Fatal-following-error bit (OR)
#define mCoor10AmpFault			M6090		;// &10 Amp-fault-error bit (OR of motors)

#define mCoor10HostTimeBase		M6097		;// &10 Host commanded Time Base (I10 units)
#define mCoor10PresTimeBase		M6098		;// &10 Present Time Base (I10 units)


;// Coordinate System &11 Status Bits 
#define mCoor11Timer1			M6111		;// &11 Isx11 Timer1 (for synchronous assignment)
#define mCoor11Timer2			M6112		;// &11 Isx11 Timer2 (for synchronous assignment)

#define mCoor11AAxisTargetPos	M6141		;// &11 A-Axis Target Position
#define mCoor11BAxisTargetPos	M6142		;// &11 B-Axis Target Position
#define mCoor11CAxisTargetPos	M6143		;// &11 C-Axis Target Position
#define mCoor11UAxisTargetPos	M6144		;// &11 U-Axis Target Position
#define mCoor11VAxisTargetPos	M6145		;// &11 V-Axis Target Position
#define mCoor11WAxisTargetPos	M6146		;// &11 W-Axis Target Position
#define mCoor11XAxisTargetPos	M6147		;// &11 X-Axis Target Position
#define mCoor11YAxisTargetPos	M6148		;// &11 Y-Axis Target Position
#define mCoor11ZAxisTargetPos	M6149		;// &11 Z-Axis Target Position

#define mCoor11Running			M6180		;// &11 Program-running bit
#define mCoor11RadError			M6181		;// &11 Circle-radius-error bit
#define mCoor11RuntimeError		M6182		;// &11 Run-time-error bit
#define mCoor11ContinuousMot	M6184		;// &11 Continuous Motion requested
#define mCoor11InPos			M6187		;// &11 In-position bit (AND of motors)
#define mCoor11FatFolWarning	M6188		;// &11 Warning-following-error bit (OR)
#define mCoor11FatFolError		M6189		;// &11 Fatal-following-error bit (OR)
#define mCoor11AmpFault			M6190		;// &11 Amp-fault-error bit (OR of motors)

#define mCoor11HostTimeBase		M6197		;// &11 Host commanded Time Base (I10 units)
#define mCoor11PresTimeBase		M6198		;// &11 Present Time Base (I10 units)


;// Coordinate System &1 Status Bits 
#define mCoor12Timer1			M6211		;// &12 Isx11 Timer1 (for synchronous assignment)
#define mCoor12Timer2			M6212		;// &12 Isx11 Timer2 (for synchronous assignment)

#define mCoor12AAxisTargetPos	M6241		;// &12 A-Axis Target Position
#define mCoor12BAxisTargetPos	M6242		;// &12 B-Axis Target Position
#define mCoor12CAxisTargetPos	M6243		;// &12 C-Axis Target Position
#define mCoor12UAxisTargetPos	M6244		;// &12 U-Axis Target Position
#define mCoor12VAxisTargetPos	M6245		;// &12 V-Axis Target Position
#define mCoor12WAxisTargetPos	M6246		;// &12 W-Axis Target Position
#define mCoor12XAxisTargetPos	M6247		;// &12 X-Axis Target Position
#define mCoor12YAxisTargetPos	M6248		;// &12 Y-Axis Target Position
#define mCoor12ZAxisTargetPos	M6249		;// &12 Z-Axis Target Position

#define mCoor12Running			M6280		;// &12 Program-running bit
#define mCoor12RadError			M6281		;// &12 Circle-radius-error bit
#define mCoor12RuntimeError		M6282		;// &12 Run-time-error bit
#define mCoor12ContinuousMot	M6284		;// &12 Continuous Motion requested
#define mCoor12InPos			M6287		;// &12 In-position bit (AND of motors)
#define mCoor12FatFolWarning	M6288		;// &12 Warning-following-error bit (OR)
#define mCoor12FatFolError		M6289		;// &12 Fatal-following-error bit (OR)
#define mCoor12AmpFault			M6290		;// &12 Amp-fault-error bit (OR of motors)

#define mCoor12HostTimeBase		M6297		;// &12 Host commanded Time Base (I10 units)
#define mCoor12PresTimeBase		M6298		;// &12 Present Time Base (I10 units)


;// Coordinate System &13 Status Bits 
#define mCoor13Timer1			M6311		;// &13 Isx11 Timer1 (for synchronous assignment)
#define mCoor13Timer2			M6312		;// &13 Isx11 Timer2 (for synchronous assignment)

#define mCoor13AAxisTargetPos	M6341		;// &13 A-Axis Target Position
#define mCoor13BAxisTargetPos	M6342		;// &13 B-Axis Target Position
#define mCoor13CAxisTargetPos	M6343		;// &13 C-Axis Target Position
#define mCoor13UAxisTargetPos	M6344		;// &13 U-Axis Target Position
#define mCoor13VAxisTargetPos	M6345		;// &13 V-Axis Target Position
#define mCoor13WAxisTargetPos	M6346		;// &13 W-Axis Target Position
#define mCoor13XAxisTargetPos	M6347		;// &13 X-Axis Target Position
#define mCoor13YAxisTargetPos	M6348		;// &13 Y-Axis Target Position
#define mCoor13ZAxisTargetPos	M6349		;// &13 Z-Axis Target Position

#define mCoor13Running			M6380		;// &13 Program-running bit
#define mCoor13RadError			M6381		;// &13 Circle-radius-error bit
#define mCoor13RuntimeError		M6382		;// &13 Run-time-error bit
#define mCoor13ContinuousMot	M6384		;// &13 Continuous Motion requested
#define mCoor13InPos			M6387		;// &13 In-position bit (AND of motors)
#define mCoor13FatFolWarning	M6388		;// &13 Warning-following-error bit (OR)
#define mCoor13FatFolError		M6389		;// &13 Fatal-following-error bit (OR)
#define mCoor13AmpFault			M6390		;// &13 Amp-fault-error bit (OR of motors)

#define mCoor13HostTimeBase		M6397		;// &13 Host commanded Time Base (I10 units)
#define mCoor13PresTimeBase		M6398		;// &13 Present Time Base (I10 units)


;// Coordinate System &14 Status Bits 
#define mCoor14Timer1			M6411		;// &14 Isx11 Timer1 (for synchronous assignment)
#define mCoor14Timer2			M6412		;// &14 Isx11 Timer2 (for synchronous assignment)

#define mCoor14AAxisTargetPos	M6441		;// &14 A-Axis Target Position
#define mCoor14BAxisTargetPos	M6442		;// &14 B-Axis Target Position
#define mCoor14CAxisTargetPos	M6443		;// &14 C-Axis Target Position
#define mCoor14UAxisTargetPos	M6444		;// &14 U-Axis Target Position
#define mCoor14VAAxisTargetPos	M6445		;// &14 V-Axis Target Position
#define mCoor14WAxisTargetPos	M6446		;// &14 W-Axis Target Position
#define mCoor14XAxisTargetPos	M6447		;// &14 X-Axis Target Position
#define mCoor14YAxisTargetPos	M6448		;// &14 Y-Axis Target Position
#define mCoor14ZAxisTargetPos	M6449		;// &14 Z-Axis Target Position

#define mCoor14Running			M6480		;// &14 Program-running bit
#define mCoor14RadError			M6481		;// &14 Circle-radius-error bit
#define mCoor14RuntimeError		M6482		;// &14 Run-time-error bit
#define mCoor14ContinuousMot	M6484		;// &14 Continuous Motion requested
#define mCoor14InPos			M6487		;// &14 In-position bit (AND of motors)
#define mCoor14FatFolWarning	M6488		;// &14 Warning-following-error bit (OR)
#define mCoor14FatFolError		M6489		;// &14 Fatal-following-error bit (OR)
#define mCoor14AmpFault			M6490		;// &14 Amp-fault-error bit (OR of motors)

#define mCoor14HostTimeBase		M6497		;// &14 Host commanded Time Base (I10 units)
#define mCoor14PresTimeBase		M6498		;// &14 Present Time Base (I10 units)


;// Coordinate System &15 Status Bits 
#define mCoor15Timer1			M6511		;// &15 Isx11 Timer1 (for synchronous assignment)
#define mCoor15Timer2			M6512		;// &15 Isx11 Timer2 (for synchronous assignment)

#define mCoor15AAxisTargetPos	M6541		;// &15 A-Axis Target Position
#define mCoor15BAxisTargetPos	M6542		;// &15 B-Axis Target Position
#define mCoor15CAxisTargetPos	M6543		;// &15 C-Axis Target Position
#define mCoor15UAxisTargetPos	M6544		;// &15 U-Axis Target Position
#define mCoor15VAxisTargetPos	M6545		;// &15 V-Axis Target Position
#define mCoor15WAxisTargetPos	M6546		;// &15 W-Axis Target Position
#define mCoor15XAxisTargetPos	M6547		;// &15 X-Axis Target Position
#define mCoor15YAxisTargetPos	M6548		;// &15 Y-Axis Target Position
#define mCoor15ZAxisTargetPos	M6549		;// &15 Z-Axis Target Position

#define mCoor15Running			M6580		;// &15 Program-running bit
#define mCoor15RadError			M6581		;// &15 Circle-radius-error bit
#define mCoor15RuntimeError		M6582		;// &15 Run-time-error bit
#define mCoor15ContinuousMot	M6584		;// &15 Continuous Motion requested
#define mCoor15InPos			M6587		;// &15 In-position bit (AND of motors)
#define mCoor15FatFolWarning	M6588		;// &15 Warning-following-error bit (OR)
#define mCoor15FatFolError		M6589		;// &15 Fatal-following-error bit (OR)
#define mCoor15AmpFault			M6590		;// &15 Amp-fault-error bit (OR of motors)

#define mCoor15HostTimeBase		M6597		;// &15 Host commanded Time Base (I10 units)
#define mCoor15PresTimeBase		M6598		;// &15 Present Time Base (I10 units)


;// Coordinate System &16 Status Bits 
#define mCoor16Timer1			M6611		;// &16 Isx11 Timer1 (for synchronous assignment)
#define mCoor16Timer2			M6612		;// &16 Isx11 Timer2 (for synchronous assignment)

#define mCoor16AAxisTargetPos	M6641		;// &16 A-Axis Target Position
#define mCoor16BAxisTargetPos	M6642		;// &16 B-Axis Target Position
#define mCoor16CAxisTargetPos	M6643		;// &16 C-Axis Target Position
#define mCoor16UAxisTargetPos	M6644		;// &16 U-Axis Target Position
#define mCoor16VAxisTargetPos	M6645		;// &16 V-Axis Target Position
#define mCoor16WAxisTargetPos	M6646		;// &16 W-Axis Target Position
#define mCoor16XAxisTargetPos	M6647		;// &16 X-Axis Target Position
#define mCoor16YAxisTargetPos	M6648		;// &16 Y-Axis Target Position
#define mCoor16ZAxisTargetPos	M6649		;// &16 Z-Axis Target Position

#define mCoor16Running			M6680		;// &16 Program-running bit
#define mCoor16RadError			M6681		;// &16 Circle-radius-error bit
#define mCoor16RuntimeError		M6682		;// &16 Run-time-error bit
#define mCoor16ContinuousMot	M6684		;// &16 Continuous Motion requested
#define mCoor16InPos			M6687		;// &16 In-position bit (AND of motors)
#define mCoor16FatFolWarning	M6688		;// &16 Warning-following-error bit (OR)
#define mCoor16FatFolError		M6689		;// &16 Fatal-following-error bit (OR)
#define mCoor16AmpFault			M6690		;// &16 Amp-fault-error bit (OR of motors)

#define mCoor16HostTimeBase		M6697		;// &16 Host commanded Time Base (I10 units)
#define mCoor16PresTimeBase		M6698		;// &16 Present Time Base (I10 units)

#define mMachineStatus			M7500       ;// Machine Status
#define mPreviousMS				M7501       ;// Machine Status



