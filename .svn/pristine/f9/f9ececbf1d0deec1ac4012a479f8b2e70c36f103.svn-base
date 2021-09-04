;// This file contains suggested definitions for M-variables on the Turbo PMAC2. Note that these
;// are only suggestions;// the user is free to make whatever definitions are desired.
;// Clear existing definitions
CLOSE ;// Make sure no buffer is open

M0..6700->* ;// All M-variables are now self-referenced
;//M8000..8100->* ;// All M-variables are now self-referenced

;//The following DPR addresses are reserved for replacing DPR for Interrupts
M1->DP:$0608B1		;//DPR Int1 Set
;//DP:$0608B2		;//DPR Int2 Set
;//DP:$0608B3		;//DPR Int3 Set
;//DP:$0608B4		;//DPR Int4 Set

;//M1->X:$078005,11		;//int set
;//M2->X:$078005,12		;//int config

;//M11->L:$6000			;//address of P0
;//M12->Y:$47DB,0,12		;//M2011 definition word

M11->F:$60000			;//Starting Buffer address in DPRAM	Buffer is 500 Points
M12->Y:$400B,0,12			;//Pointer to the definition work of m11(ie. M11 address)
M13->DP:$60000		;//Starting Buffer address in DPRAM DPRAM	Buffer is 500 Points
M14->Y:$400D,0,12			;//Pointer to the definition work of m13(ie. M13 address)
M15->F:$60000		;//Starting Buffer address in DPRAM DPRAM	Buffer is 500 Points
M16->Y:$400F,0,12			;//Pointer to the definition work of m13(ie. M13 address)
M17->F:$60000		;//Starting Buffer address in DPRAM DPRAM	Buffer is 500 Points
M18->Y:$4011,0,12			;//Pointer to the definition work of m13(ie. M13 address)

M20->Y:$078414,24		;//Pulse output 1 commanded value
M21->X:$078414,0,8		;//Pulse Widths for 1 and 2
M22->Y:$07841C,24		;//Pulse output 2 commanded value
M23->X:$078415,23		;//Pulse 1 PFM bit
M24->X:$078415,19		;//Pulse 1 Direction bit
M25->X:$07841D,23		;//Pulse 2 PFM bit
M26->X:$07841D,19		;//Pulse 2 Direction bit
M27->X:$078415,21		;//Pulse 1 Invert Bit
M28->X:$07841D,21		;//Pulse 2 Invert Bit

;// JTHW Thumbwheel Multiplexer Port M-variables
M40->Y:$078402,8 ;// SEL0 Line;// J2 Pin 4
M41->Y:$078402,9 ;// SEL1 Line;// J2 Pin 6
M42->Y:$078402,10 ;// SEL2 Line;// J2 Pin 8
M43->Y:$078402,11 ;// SEL3 Line;// J2 Pin 10
M44->Y:$078402,12 ;// SEL4 Line;// J2 Pin 12
M45->Y:$078402,13 ;// SEL5 Line;// J2 Pin 14
M46->Y:$078402,14 ;// SEL6 Line;// J2 Pin 16
M47->Y:$078402,15 ;// SEL7 Line;// J2 Pin 18
M48->Y:$078402,8,8,U ;// SEL0-7 Lines treated as a byte
M50->Y:$078402,0 ;// DAT0 Line;// J2 Pin 3
M51->Y:$078402,1 ;// DAT1 Line;// J2 Pin 5
M52->Y:$078402,2 ;// DAT2 Line;// J2 Pin 7
M53->Y:$078402,3 ;// DAT3 Line;// J2 Pin 9
M54->Y:$078402,4 ;// DAT4 Line;// J2 Pin 11
M55->Y:$078402,5 ;// DAT5 Line;// J2 Pin 13
M56->Y:$078402,6 ;// DAT6 Line;// J2 Pin 15
M57->Y:$078402,7 ;// DAT7 Line;// J2 Pin 17

M58->Y:$078402,0,8,U ;// DAT0-7 Lines treated as a byte

M60->X:$078402,0,8 ;// Direction control for DAT0 to DAT7
M61->Y:$070800,4 ;// Buffer direction control for DAT0 to DAT7, PCbus
;//M61->Y:$070802,0 ;// Buffer direction control for DAT0 to DAT7, VMEbus
M62->X:$078400,8,8 ;// Direction control for SEL0 to SEL7
M63->Y:$070800,5 ;// Buffer direction control for SEL0 to SEL7, PCbus
;//M63->Y:$070802,1 ;// Buffer direction control for SEL0 to SEL7, VMEbus

;// Miscellaneous global registers
M80->X:$000025,0,24 ;// Minimum watchdog timer count
M81->X:$000024,0,24 ;// Pointer to display buffer
M82->Y:$001080,0,8 ;// First character of display buffer
M83->X:$000006,12,1 ;// Firmware checksum error bit
M84->X:$000006,13,1 ;// Any memory checksum error bit
M85->X:$000006,5,1 ;// MACRO auxiliary communications error bit
M86->X:$000006,6,1 ;// ACC-34 serial parity error bit

;// Servo cycle counter (read only) -- counts up once per servo cycle
M100->X:$000000,0,24,U ;// 24-bit servo cycle counter (changed to Unsigned 2/26/2013 by MRB because it is Unsigned).

;//The following DPR addresses are reserved for replacing DPR for Interrupts
;//DP:$0608B1		;//DPR Int1 Set
;//DP:$0608B2		;//DPR Int2 Set
;//DP:$0608B3		;//DPR Int3 Set
;//DP:$0608B4		;//DPR Int4 Set

;//for using DPR instead of the int set the Appropriate Mvariable to the correct address in DPR for above

;// Servo IC 2 Channel 1 Registers (usually for Motor #1)
M101->X:$078201,0,24,S ;// ENC1 24-bit counter position
M102->Y:$078202,8,16,S ;// OUT1A command value;// DAC or PWM
M103->X:$078203,0,24,S ;// ENC1 captured position
M104->Y:$078203,8,16,S ;// OUT1B command value;// DAC or PWM
M105->Y:$078205,8,16,S ;// ADC1A input value
M106->Y:$078206,8,16,S ;// ADC1B input value
M107->Y:$078204,8,16,S ;// OUT1C command value;// PFM or PWM
M108->Y:$078207,0,24,S ;// ENC1 compare A position
M109->X:$078207,0,24,S ;// ENC1 compare B position
M110->X:$078206,0,24,S ;// ENC1 compare autoincrement value
M111->X:$078205,11 ;// ENC1 compare initial state write enable
M112->X:$078205,12 ;// ENC1 compare initial state
M114->X:$078205,14 ;// AENA1 output status
M115->X:$078200,19 ;// USER1 flag input status
M116->X:$078200,9 ;// ENC1 compare output value
M117->X:$078200,11 ;// ENC1 capture flag
M118->X:$078200,8 ;// ENC1 count error flag
M119->X:$078200,14 ;// CHC1 input status
M120->X:$078200,16 ;// HMFL1 flag input status
M121->X:$078200,17 ;// PLIM1 flag input status
M122->X:$078200,18 ;// MLIM1 flag input status
M123->X:$078200,15 ;// FAULT1 flag input status
M124->X:$078200,20 ;// Channel 1 W flag input status
M125->X:$078200,21 ;// Channel 1 V flag input status
M126->X:$078200,22 ;// Channel 1 U flag input status
M127->X:$078200,23 ;// Channel 1 T flag input status
M128->X:$078200,20,4 ;// Channel 1 TUVW inputs as 4-bit value

;// Motor #1 Status Bits
M130->Y:$0000C0,11,1 ;// #1 Stopped-on-position-limit bit
M131->X:$0000B0,21,1 ;// #1 Positive-end-limit-set bit
M132->X:$0000B0,22,1 ;// #1 Negative-end-limit-set bit
M133->X:$0000B0,13,1 ;// #1 Desired-velocity-zero bit
M135->X:$0000B0,15,1 ;// #1 Dwell-in-progress bit
M137->X:$0000B0,17,1 ;// #1 Running-program bit
M138->X:$0000B0,18,1 ;// #1 Open-loop-mode bit
M139->X:$0000B0,19,1 ;// #1 Amplifier-enabled status bit
M140->Y:$0000C0,0,1 ;// #1 Background in-position bit
M141->Y:$0000C0,1,1 ;// #1 Warning-following error bit
M142->Y:$0000C0,2,1 ;// #1 Fatal-following-error bit
M143->Y:$0000C0,3,1 ;// #1 Amplifier-fault-error bit
M144->Y:$0000C0,13,1 ;// #1 Foreground in-position bit
M145->Y:$0000C0,10,1 ;// #1 Home-complete bit
M146->Y:$0000C0,6,1 ;// #1 Integrated following error fault bit
M147->Y:$0000C0,5,1 ;// #1 I2T fault bit
M148->Y:$0000C0,8,1 ;// #1 Phasing error fault bit
M149->Y:$0000C0,9,1 ;// #1 Phasing search-in-progress bit

;// MACRO IC 0 Node 0 Flag Registers (usually used for Motor #1)
M150->X:$003440,0,24 ;// MACRO IC 0 Node 0 flag status register
M151->Y:$003440,0,24 ;// MACRO IC 0 Node 0 flag command register
M153->X:$003440,20,4 ;// MACRO IC 0 Node 0 TUVW flags
M154->Y:$003440,14,1 ;// MACRO IC 0 Node 0 amplifier enable flag
M155->X:$003440,15,1 ;// MACRO IC 0 Node 0 node/amplifier fault flag
M156->X:$003440,16,1 ;// MACRO IC 0 Node 0 home flag
M157->X:$003440,17,1 ;// MACRO IC 0 Node 0 positive limit flag
M158->X:$003440,18,1 ;// MACRO IC 0 Node 0 negative limit flag
M159->X:$003440,19,1 ;// MACRO IC 0 Node 0 user flag

;// Motor #1 Move Registers
M161->D:$000088 ;// #1 Commanded position (1/[Ixx08*32] cts)
M162->D:$00008B ;// #1 Actual position (1/[Ixx08*32] cts)
M163->D:$0000C7 ;// #1 Target (end) position (1/[Ixx08*32] cts)
M164->D:$0000CC ;// #1 Position bias (1/[Ixx08*32] cts)
M166->X:$00009D,0,24,S ;// #1 Actual velocity (1/[Ixx09*32] cts/cyc)
M167->D:$00008D ;// #1 Present master pos (1/[Ixx07*32] cts)
M168->X:$0000BF,8,16,S ;// #1 Filter Output (16-bit DAC bits)
M169->D:$000090 ;// #1 Compensation correction (1/[Ixx08*32] cts)
M170->D:$0000B4 ;// #1 Present phase position (including fraction)
M171->X:$0000B4,24,S ;// #1 Present phase position (counts *Ixx70)
M172->L:$0000D7 ;// #1 Variable jog position/distance (cts)
M173->Y:$0000CE,0,24,S ;// #1 Encoder home capture position (cts)
M174->D:$0000EF ;// #1 Averaged actual velocity (1/[Ixx09*32] cts/cyc)
M175->X:$0000B9,8,16,S ;// #1 Actual quadrature current
M176->Y:$0000B9,8,16,S ;// #1 Actual direct current
M177->X:$0000BC,8,16,S ;// #1 Quadrature current-loop integrator output
M178->Y:$0000BC,8,16,S ;// #1 Direct current-loop integrator output
M179->X:$0000AE,8,16,S ;// #1 PID internal filter result (16-bit DAC bits)
M188->Y:$078201,0,12,U ;// IC 2 Ch 1 Compare A fractional count
M189->Y:$078200,0,12,U ;// IC 2 Ch 1 Compare B fractional count

;// Motor #1 Axis Definition Registers
M191->L:$0000CF ;// #1 X/U/A/B/C-Axis scale factor (cts/unit)
M192->L:$0000D0 ;// #1 Y/V-Axis scale factor (cts/unit)
M193->L:$0000D1 ;// #1 Z/W-Axis scale factor (cts/unit)
M194->L:$0000D2 ;// #1 Axis offset (cts)

;// Servo IC 2 Registers for PMAC2 Channel 2 (usually for Motor #2)
M201->X:$078209,0,24,S ;// ENC2 24-bit counter position
M202->Y:$07820A,8,16,S ;// OUT2A command value;// DAC or PWM
M203->X:$07820B,0,24,S ;// ENC2 captured position
M204->Y:$07820B,8,16,S ;// OUT2B command value;// DAC or PWM
M205->Y:$07820D,8,16,S ;// ADC2A input value
M206->Y:$07820E,8,16,S ;// ADC2B input value
M207->Y:$07820C,8,16,S ;// OUT2C command value;// PFM or PWM
M208->Y:$07820F,0,24,S ;// ENC2 compare A position
M209->X:$07820F,0,24,S ;// ENC2 compare B position
M210->X:$07820E,0,24,S ;// ENC2 compare autoincrement value
M211->X:$07820D,11 ;// ENC2 compare initial state write enable
M212->X:$07820D,12 ;// ENC2 compare initial state
M214->X:$07820D,14 ;// AENA2 output status
M215->X:$078208,19 ;// USER2 flag input status
M216->X:$078208,9 ;// ENC2 compare output value
M217->X:$078208,11 ;// ENC2 capture flag
M218->X:$078208,8 ;// ENC2 count error flag
M219->X:$078208,14 ;// CHC2 input status
M220->X:$078208,16 ;// HMFL2 flag input status
M221->X:$078208,17 ;// PLIM2 flag input status
M222->X:$078208,18 ;// MLIM2 flag input status
M223->X:$078208,15 ;// FAULT2 flag input status
M224->X:$078208,20 ;// Channel 2 W flag input status
M225->X:$078208,21 ;// Channel 2 V flag input status
M226->X:$078208,22 ;// Channel 2 U flag input status
M227->X:$078208,23 ;// Channel 2 T flag input status
M228->X:$078208,20,4 ;// Channel 2 TUVW inputs as 4-bit value

;// Motor #2 Status Bits
M230->Y:$000140,11,1 ;// #2 Stopped-on-position-limit bit
M231->X:$000130,21,1 ;// #2 Positive-end-limit-set bit
M232->X:$000130,22,1 ;// #2 Negative-end-limit-set bit
M233->X:$000130,13,1 ;// #2 Desired-velocity-zero bit
M235->X:$000130,15,1 ;// #2 Dwell-in-progress bit
M237->X:$000130,17,1 ;// #2 Running-program bit
M238->X:$000130,18,1 ;// #2 Open-loop-mode bit
M239->X:$000130,19,1 ;// #2 Amplifier-enabled status bit
M240->Y:$000140,0,1 ;// #2 Background in-position bit
M241->Y:$000140,1,1 ;// #2 Warning-following error bit
M242->Y:$000140,2,1 ;// #2 Fatal-following-error bit
M243->Y:$000140,3,1 ;// #2 Amplifier-fault-error bit
M244->Y:$000140,13,1 ;// #2 Foreground in-position bit
M245->Y:$000140,10,1 ;// #2 Home-complete bit
M246->Y:$000140,6,1 ;// #2 Integrated following error fault bit
M247->Y:$000140,5,1 ;// #2 I2T fault bit
M248->Y:$000140,8,1 ;// #2 Phasing error fault bit
M249->Y:$000140,9,1 ;// #2 Phasing search-in-progress bit

;// MACRO IC 0 Node 1 Flag Registers (usually used for Motor #2)
M250->X:$003441,0,24 ;// MACRO IC 0 Node 1 flag status register
M251->Y:$003441,0,24 ;// MACRO IC 0 Node 1 flag command register
M253->X:$003441,20,4 ;// MACRO IC 0 Node 1 TUVW flags
M254->Y:$003441,14,1 ;// MACRO IC 0 Node 1 amplifier enable flag
M255->X:$003441,15,1 ;// MACRO IC 0 Node 1 node/amplifier fault flag
M256->X:$003441,16,1 ;// MACRO IC 0 Node 1 home flag
M257->X:$003441,17,1 ;// MACRO IC 0 Node 1 positive limit flag
M258->X:$003441,18,1 ;// MACRO IC 0 Node 1 negative limit flag
M259->X:$003441,19,1 ;// MACRO IC 0 Node 1 user flag

;// Motor #2 Move Registers
M261->D:$000108 ;// #2 Commanded position (1/[Ixx08*32] cts)
M262->D:$00010B ;// #2 Actual position (1/[Ixx08*32] cts)
M263->D:$000147 ;// #2 Target (end) position (1/[Ixx08*32] cts)
M264->D:$00014C ;// #2 Position bias (1/[Ixx08*32] cts)
M266->X:$00011D,0,24,S ;// #2 Actual velocity (1/[Ixx09*32] cts/cyc)
M267->D:$00010D ;// #2 Present master pos (1/[Ixx07*32] cts)
M268->X:$00013F,8,16,S ;// #2 Filter Output (16-bit DAC bits)
M269->D:$000110 ;// #2 Compensation correction (1/[Ixx08*32] cts)
M270->D:$000134 ;// #2 Present phase position (including fraction)
M271->X:$000134,24,S ;// #2 Present phase position (counts *Ixx70)
M272->L:$000157 ;// #2 Variable jog position/distance (cts)
M273->Y:$00014E,0,24,S ;// #2 Encoder home capture position (cts)
M274->D:$00016F ;// #2 Averaged actual velocity (1/[Ixx09*32] cts/cyc)
M275->X:$000139,8,16,S ;// #2 Actual quadrature current
M276->Y:$000139,8,16,S ;// #2 Actual direct current
M277->X:$00013C,8,16,S ;// #2 Quadrature current-loop integrator output
M278->Y:$00013C,8,16,S ;// #2 Direct current-loop integrator output
M279->X:$00012E,8,16,S ;// #2 PID internal filter result (16-bit DAC bits)
M288->Y:$078209,0,12,U ;// IC 2 Ch 2 Compare A fractional count
M289->Y:$078208,0,12,U ;// IC 2 Ch 2 Compare B fractional count

;// Motor #2 Axis Definition Registers
M291->L:$00014F ;// #2 X/U/A/B/C-Axis scale factor (cts/unit)
M292->L:$000150 ;// #2 Y/V-Axis scale factor (cts/unit)
M293->L:$000151 ;// #2 Z/W-Axis scale factor (cts/unit)
M294->L:$000152 ;// #2 Axis offset (cts)

;// Servo IC 2 Channel 3 Registers (usually for Motor #3)
M301->X:$078211,0,24,S ;// ENC3 24-bit counter position
M302->Y:$078212,8,16,S ;// OUT3A command value;// DAC or PWM
M303->X:$078213,0,24,S ;// ENC3 captured position
M304->Y:$078213,8,16,S ;// OUT3B command value;// DAC or PWM
M305->Y:$078215,8,16,S ;// ADC3A input value
M306->Y:$078216,8,16,S ;// ADC3B input value
M307->Y:$078214,8,16,S ;// OUT3C command value;// PFM or PWM
M308->Y:$078217,0,24,S ;// ENC3 compare A position
M309->X:$078217,0,24,S ;// ENC3 compare B position
M310->X:$078216,0,24,S ;// ENC3 compare autoincrement value
M311->X:$078215,11 ;// ENC3 compare initial state write enable
M312->X:$078215,12 ;// ENC3 compare initial state
M314->X:$078215,14 ;// AENA3 output status
M315->X:$078210,19 ;// USER3 flag input status
M316->X:$078210,9 ;// ENC3 compare output value
M317->X:$078210,11 ;// ENC3 capture flag
M318->X:$078210,8 ;// ENC3 count error flag
M319->X:$078210,14 ;// CHC3 input status
M320->X:$078210,16 ;// HMFL3 flag input status
M321->X:$078210,17 ;// PLIM3 flag input status
M322->X:$078210,18 ;// MLIM3 flag input status
M323->X:$078210,15 ;// FAULT3 flag input status
M324->X:$078210,20 ;// Channel 3 W flag input status
M325->X:$078210,21 ;// Channel 3 V flag input status
M326->X:$078210,22 ;// Channel 3 U flag input status
M327->X:$078210,23 ;// Channel 3 T flag input status
M328->X:$078210,20,4 ;// Channel 3 TUVW inputs as 4-bit value

;// Motor #3 Status Bits
M330->Y:$0001C0,11,1 ;// #3 Stopped-on-position-limit bit
M331->X:$0001B0,21,1 ;// #3 Positive-end-limit-set bit
M332->X:$0001B0,22,1 ;// #3 Negative-end-limit-set bit
M333->X:$0001B0,13,1 ;// #3 Desired-velocity-zero bit
M335->X:$0001B0,15,1 ;// #3 Dwell-in-progress bit
M337->X:$0001B0,17,1 ;// #3 Running-program bit
M338->X:$0001B0,18,1 ;// #3 Open-loop-mode bit
M339->X:$0001B0,19,1 ;// #3 Amplifier-enabled status bit
M340->Y:$0001C0,0,1 ;// #3 Background in-position bit
M341->Y:$0001C0,1,1 ;// #3 Warning-following error bit
M342->Y:$0001C0,2,1 ;// #3 Fatal-following-error bit
M343->Y:$0001C0,3,1 ;// #3 Amplifier-fault-error bit
M344->Y:$0001C0,13,1 ;// #3 Foreground in-position bit
M345->Y:$0001C0,10,1 ;// #3 Home-complete bit
M346->Y:$0001C0,6,1 ;// #3 Integrated following error fault bit
M347->Y:$0001C0,5,1 ;// #3 I2T fault bit
M348->Y:$0001C0,8,1 ;// #3 Phasing error fault bit
M349->Y:$0001C0,9,1 ;// #3 Phasing search-in-progress bit

;// MACRO IC 0 Node 4 Flag Registers (usually used for Motor #3)
M350->X:$003444,0,24 ;// MACRO IC 0 Node 4 flag status register
M351->Y:$003444,0,24 ;// MACRO IC 0 Node 4 flag command register
M353->X:$003444,20,4 ;// MACRO IC 0 Node 4 TUVW flags
M354->Y:$003444,14,1 ;// MACRO IC 0 Node 4 amplifier enable flag
M355->X:$003444,15,1 ;// MACRO IC 0 Node 4 node/amplifier fault flag
M356->X:$003444,16,1 ;// MACRO IC 0 Node 4 home flag
M357->X:$003444,17,1 ;// MACRO IC 0 Node 4 positive limit flag
M358->X:$003444,18,1 ;// MACRO IC 0 Node 4 negative limit flag
M359->X:$003444,19,1 ;// MACRO IC 0 Node 4 user flag

;// Motor #3 Move Registers
M361->D:$000188 ;// #3 Commanded position (1/[Ixx08*32] cts)
M362->D:$00018B ;// #3 Actual position (1/[Ixx08*32] cts)
M363->D:$0001C7 ;// #3 Target (end) position (1/[Ixx08*32] cts)
M364->D:$0001CC ;// #3 Position bias (1/[Ixx08*32] cts)
M366->X:$00019D,0,24,S ;// #3 Actual velocity (1/[Ixx09*32] cts/cyc)
M367->D:$00018D ;// #3 Present master pos (1/[Ixx07*32] cts)
M368->X:$0001BF,8,16,S ;// #3 Filter Output (16-bit DAC bits)
M369->D:$000190 ;// #3 Compensation correction (1/[Ixx08*32] cts)
M370->D:$0001B4 ;// #3 Present phase position (including fraction)
M371->X:$0001B4,24,S ;// #3 Present phase position (counts *Ixx70)
M372->L:$0001D7 ;// #3 Variable jog position/distance (cts)
M373->Y:$0001CE,0,24,S ;// #3 Encoder home capture position (cts)
M374->D:$0001EF ;// #3 Averaged actual velocity (1/[Ixx09*32] cts/cyc)
M375->X:$0001B9,8,16,S ;// #3 Actual quadrature current
M376->Y:$0001B9,8,16,S ;// #3 Actual direct current
M377->X:$0001BC,8,16,S ;// #3 Quadrature current-loop integrator output
M378->Y:$0001BC,8,16,S ;// #3 Direct current-loop integrator output
M379->X:$0001AE,8,16,S ;// #3 PID internal filter result (16-bit DAC bits)
M388->Y:$078211,0,12,U ;// IC 2 Ch 3 Compare A fractional count
M389->Y:$078210,0,12,U ;// IC 2 Ch 3 Compare B fractional count

;// Motor #3 Axis Definition Registers
M391->L:$0001CF ;// #3 X/U/A/B/C-Axis scale factor (cts/unit)
M392->L:$0001D0 ;// #3 Y/V-Axis scale factor (cts/unit)
M393->L:$0001D1 ;// #3 Z/W-Axis scale factor (cts/unit)
M394->L:$0001D2 ;// #3 Axis offset (cts)

;// Servo IC 2 Channel 4 Registers (usually for Motor #4)
M401->X:$078219,0,24,S ;// ENC4 24-bit counter position
M402->Y:$07821A,8,16,S ;// OUT4A command value;// DAC or PWM
M403->X:$07821B,0,24,S ;// ENC4 captured position
M404->Y:$07821B,8,16,S ;// OUT4B command value;// DAC or PWM
M405->Y:$07821D,8,16,S ;// ADC4A input value
M406->Y:$07821E,8,16,S ;// ADC4B input value
M407->Y:$07821C,8,16,S ;// OUT4C command value;// PFM or PWM
M408->Y:$07821F,0,24,S ;// ENC4 compare A position
M409->X:$07821F,0,24,S ;// ENC4 compare B position
M410->X:$07821E,0,24,S ;// ENC4 compare autoincrement value
M411->X:$07821D,11 ;// ENC4 compare initial state write enable
M412->X:$07821D,12 ;// ENC4 compare initial state
M414->X:$07821D,14 ;// AENA4 output status
M415->X:$078218,19 ;// USER4 flag input status
M416->X:$078218,9 ;// ENC4 compare output value
M417->X:$078218,11 ;// ENC4 capture flag
M418->X:$078218,8 ;// ENC4 count error flag
M419->X:$078218,14 ;// HMFL4 flag input status
M420->X:$078218,16 ;// CHC4 input status
M421->X:$078218,17 ;// PLIM4 flag input status
M422->X:$078218,18 ;// MLIM4 flag input status
M423->X:$078218,15 ;// FAULT4 flag input status
M424->X:$078218,20 ;// Channel 4 W flag input status
M425->X:$078218,21 ;// Channel 4 V flag input status
M426->X:$078218,22 ;// Channel 4 U flag input status
M427->X:$078218,23 ;// Channel 4 T flag input status
M428->X:$078218,20,4 ;// Channel 4 TUVW inputs as 4-bit value

;// Motor #4 Status Bits
M430->Y:$000240,11,1 ;// #4 Stopped-on-position-limit bit
M431->X:$000230,21,1 ;// #4 Positive-end-limit-set bit
M432->X:$000230,22,1 ;// #4 Negative-end-limit-set bit
M433->X:$000230,13,1 ;// #4 Desired-velocity-zero bit
M435->X:$000230,15,1 ;// #4 Dwell-in-progress bit
M437->X:$000230,17,1 ;// #4 Running-program bit
M438->X:$000230,18,1 ;// #4 Open-loop-mode bit
M439->X:$000230,19,1 ;// #4 Amplifier-enabled status bit
M440->Y:$000240,0,1 ;// #4 Background in-position bit
M441->Y:$000240,1,1 ;// #4 Warning-following error bit
M442->Y:$000240,2,1 ;// #4 Fatal-following-error bit
M443->Y:$000240,3,1 ;// #4 Amplifier-fault-error bit
M444->Y:$000240,13,1 ;// #4 Foreground in-position bit
M445->Y:$000240,10,1 ;// #4 Home-complete bit
M446->Y:$000240,6,1 ;// #4 Integrated following error fault bit
M447->Y:$000240,5,1 ;// #4 I2T fault bit
M448->Y:$000240,8,1 ;// #4 Phasing error fault bit
M449->Y:$000240,9,1 ;// #4 Phasing search-in-progress bit

;// MACRO IC 0 Node 5 Flag Registers (usually used for Motor #4)
M450->X:$003445,0,24 ;// MACRO IC 0 Node 5 flag status register
M451->Y:$003445,0,24 ;// MACRO IC 0 Node 5 flag command register
M453->X:$003445,20,4 ;// MACRO IC 0 Node 5 TUVW flags
M454->Y:$003445,14,1 ;// MACRO IC 0 Node 5 amplifier enable flag
M455->X:$003445,15,1 ;// MACRO IC 0 Node 5 node/amplifier fault flag
M456->X:$003445,16,1 ;// MACRO IC 0 Node 5 home flag
M457->X:$003445,17,1 ;// MACRO IC 0 Node 5 positive limit flag
M458->X:$003445,18,1 ;// MACRO IC 0 Node 5 negative limit flag
M459->X:$003445,19,1 ;// MACRO IC 0 Node 5 user flag

;// Motor #4 Move Registers
M461->D:$000208 ;// #4 Commanded position (1/[Ixx08*32] cts)
M462->D:$00020B ;// #4 Actual position (1/[Ixx08*32] cts)
M463->D:$000247 ;// #4 Target (end) position (1/[Ixx08*32] cts)
M464->D:$00024C ;// #4 Position bias (1/[Ixx08*32] cts)
M466->X:$00021D,0,24,S ;// #4 Actual velocity (1/[Ixx09*32] cts/cyc)
M467->D:$00020D ;// #4 Present master pos (1/[Ixx07*32] cts)
M468->X:$00023F,8,16,S ;// #4 Filter Output (16-bit DAC bits)
M469->D:$000210 ;// #4 Compensation correction (1/[Ixx08*32] cts)
M470->D:$000234 ;// #4 Present phase position (including fraction)
M471->X:$000234,24,S ;// #4 Present phase position (counts *Ixx70)
M472->L:$000257 ;// #4 Variable jog position/distance (cts)
M473->Y:$00024E,0,24,S ;// #4 Encoder home capture position (cts)
M474->D:$00026F ;// #4 Averaged actual velocity (1/[Ixx09*32] cts/cyc)
M475->X:$000239,8,16,S ;// #4 Actual quadrature current
M476->Y:$000239,8,16,S ;// #4 Actual direct current
M477->X:$00023C,8,16,S ;// #4 Quadrature current-loop integrator output
M478->Y:$00023C,8,16,S ;// #4 Direct current-loop integrator output
M479->X:$00022E,8,16,S ;// #4 PID internal filter result (16-bit DAC bits)
M488->Y:$078219,0,12,U ;// IC 2 Ch 4 Compare A fractional count
M489->Y:$078218,0,12,U ;// IC 2 Ch 4 Compare B fractional count

;// Motor #4 Axis Definition Registers
M491->L:$00024F ;// #4 X/U/A/B/C-Axis scale factor (cts/unit)
M492->L:$000250 ;// #4 Y/V-Axis scale factor (cts/unit)
M493->L:$000251 ;// #4 Z/W-Axis scale factor (cts/unit)
M494->L:$000252 ;// #4 Axis offset (cts)

;// Servo IC 3 Channel 1 Registers (usually for Motor #5)
M501->X:$078301,0,24,S ;// ENC5 24-bit counter position
M502->Y:$078302,8,16,S ;// OUT5A command value;// DAC or PWM
M503->X:$078303,0,24,S ;// ENC5 captured position
M504->Y:$078303,8,16,S ;// OUT5B command value;// DAC or PWM
M505->Y:$078305,8,16,S ;// ADC5A input value
M506->Y:$078306,8,16,S ;// ADC5B input value
M507->Y:$078304,8,16,S ;// OUT5C command value;// PFM or PWM
M508->Y:$078307,0,24,S ;// ENC5 compare A position
M509->X:$078307,0,24,S ;// ENC5 compare B position
M510->X:$078306,0,24,S ;// ENC5 compare autoincrement value
M511->X:$078305,11 ;// ENC5 compare initial state write enable
M512->X:$078305,12 ;// ENC5 compare initial state
M514->X:$078305,14 ;// AENA5 output status
M515->X:$078300,19 ;// USER5 flag input status
M516->X:$078300,9 ;// ENC5 compare output value
M517->X:$078300,11 ;// ENC5 capture flag
M518->X:$078300,8 ;// ENC5 count error flag
M519->X:$078300,14 ;// CHC5 input status
M520->X:$078300,16 ;// HMFL5 flag input status
M521->X:$078300,17 ;// PLIM5 flag input status
M522->X:$078300,18 ;// MLIM5 flag input status
M523->X:$078300,15 ;// FAULT5 flag input status
M524->X:$078300,20 ;// Channel 5 W flag input status
M525->X:$078300,21 ;// Channel 5 V flag input status
M526->X:$078300,22 ;// Channel 5 U flag input status
M527->X:$078300,23 ;// Channel 5 T flag input status
M528->X:$078300,20,4 ;// Channel 5 TUVW inputs as 4-bit value

;// Motor #5 Status Bits
M530->Y:$0002C0,11,1 ;// #5 Stopped-on-position-limit bit
M531->X:$0002B0,21,1 ;// #5 Positive-end-limit-set bit
M532->X:$0002B0,22,1 ;// #5 Negative-end-limit-set bit
M533->X:$0002B0,13,1 ;// #5 Desired-velocity-zero bit
M535->X:$0002B0,15,1 ;// #5 Dwell-in-progress bit
M537->X:$0002B0,17,1 ;// #5 Running-program bit
M538->X:$0002B0,18,1 ;// #5 Open-loop-mode bit
M539->X:$0002B0,19,1 ;// #5 Amplifier-enabled status bit
M540->Y:$0002C0,0,1 ;// #5 Background in-position bit
M541->Y:$0002C0,1,1 ;// #5 Warning-following error bit
M542->Y:$0002C0,2,1 ;// #5 Fatal-following-error bit
M543->Y:$0002C0,3,1 ;// #5 Amplifier-fault-error bit
M544->Y:$0002C0,13,1 ;// #5 Foreground in-position bit
M545->Y:$0002C0,10,1 ;// #5 Home-complete bit
M546->Y:$0002C0,6,1 ;// #5 Integrated following error fault bit
M547->Y:$0002C0,5,1 ;// #5 I2T fault bit
M548->Y:$0002C0,8,1 ;// #5 Phasing error fault bit
M549->Y:$0002C0,9,1 ;// #5 Phasing search-in-progress bit

;// MACRO IC 0 Node 8 Flag Registers (usually used for Motor #5)
M550->X:$003448,0,24 ;// MACRO IC 0 Node 8 flag status register
M551->Y:$003448,0,24 ;// MACRO IC 0 Node 8 flag command register
M553->X:$003448,20,4 ;// MACRO IC 0 Node 8 TUVW flags
M554->Y:$003448,14,1 ;// MACRO IC 0 Node 8 amplifier enable flag
M555->X:$003448,15,1 ;// MACRO IC 0 Node 8 node/amplifier fault flag
M556->X:$003448,16,1 ;// MACRO IC 0 Node 8 home flag
M557->X:$003448,17,1 ;// MACRO IC 0 Node 8 positive limit flag
M558->X:$003448,18,1 ;// MACRO IC 0 Node 8 negative limit flag
M559->X:$003448,19,1 ;// MACRO IC 0 Node 8 user flag

;// Motor #5 Move Registers
M561->D:$000288 ;// #5 Commanded position (1/[Ixx08*32] cts)
M562->D:$00028B ;// #5 Actual position (1/[Ixx08*32] cts)
M563->D:$0002C7 ;// #5 Target (end) position (1/[Ixx08*32] cts)
M564->D:$0002CC ;// #5 Position bias (1/[Ixx08*32] cts)
M565->X:$000284,0,24,S ;// #5 Desired Accel 6/[Ixx08*32] cts/msec2 at %100
M566->X:$00029D,0,24,S ;// #5 Actual velocity (1/[Ixx09*32] cts/cyc)
M567->D:$00028D ;// #5 Present master pos (1/[Ixx07*32] cts)
M568->X:$0002BF,8,16,S ;// #5 Filter Output (16-bit DAC bits)
M569->D:$000290 ;// #5 Compensation correction (1/[Ixx08*32] cts)
M570->D:$0002B4 ;// #5 Present phase position (including fraction)
M571->X:$0002B4,24,S ;// #5 Present phase position (counts *Ixx70)
M572->L:$0002D7 ;// #5 Variable jog position/distance (cts)
M573->Y:$0002CE,0,24,S ;// #5 Encoder home capture position (cts)
M574->D:$0002EF ;// #5 Averaged actual velocity (1/[Ixx09*32] cts/cyc)
M575->X:$0002B9,8,16,S ;// #5 Actual quadrature current
M576->Y:$0002B9,8,16,S ;// #5 Actual direct current
M577->X:$0002BC,8,16,S ;// #5 Quadrature current-loop integrator output
M578->Y:$0002BC,8,16,S ;// #5 Direct current-loop integrator output
M579->X:$0002AE,8,16,S ;// #5 PID internal filter result (16-bit DAC bits)
M588->Y:$078301,0,12,U ;// IC 3 Ch 1 Compare A fractional count
M589->Y:$078300,0,12,U ;// IC 3 Ch 1 Compare B fractional count

;// Motor #5 Axis Definition Registers
M591->L:$0002CF ;// #5 X/U/A/B/C-Axis scale factor (cts/unit)
M592->L:$0002D0 ;// #5 Y/V-Axis scale factor (cts/unit)
M593->L:$0002D1 ;// #5 Z/W-Axis scale factor (cts/unit)
M594->L:$0002D2 ;// #5 Axis offset (cts)

;// Servo IC 3 Channel 2 Registers (usually for Motor #6)
M601->X:$078309,0,24,S ;// ENC6 24-bit counter position
M602->Y:$07830A,8,16,S ;// OUT6A command value;// DAC or PWM
M603->X:$07830B,0,24,S ;// ENC6 captured position
M604->Y:$07830B,8,16,S ;// OUT6B command value;// DAC or PWM
M605->Y:$07830D,8,16,S ;// ADC6A input value
M606->Y:$07830E,8,16,S ;// ADC6B input value
M607->Y:$07830C,8,16,S ;// OUT6C command value;// PFM or PWM
M608->Y:$07830F,0,24,S ;// ENC6 compare A position
M609->X:$07830F,0,24,S ;// ENC6 compare B position
M610->X:$07830E,0,24,S ;// ENC6 compare autoincrement value
M611->X:$07830D,11 ;// ENC6 compare initial state write enable
M612->X:$07830D,12 ;// ENC6 compare initial state
M614->X:$07830D,14 ;// AENA6 output status
M615->X:$078308,19 ;// USER6 flag input status
M616->X:$078308,9 ;// ENC6 compare output value
M617->X:$078308,11 ;// ENC6 capture flag
M618->X:$078308,8 ;// ENC6 count error flag
M619->X:$078308,14 ;// CHC6 input status
M620->X:$078308,16 ;// HMFL6 flag input status
M621->X:$078308,17 ;// PLIM6 flag input status
M622->X:$078308,18 ;// MLIM6 flag input status
M623->X:$078308,15 ;// FAULT6 flag input status
M624->X:$078308,20 ;// Channel 6 W flag input status
M625->X:$078308,21 ;// Channel 6 V flag input status
M626->X:$078308,22 ;// Channel 6 U flag input status
M627->X:$078308,23 ;// Channel 6 T flag input status
M628->X:$078308,20,4 ;// Channel 6 TUVW inputs as 4-bit value

;// Motor #6 Status Bits
M630->Y:$000340,11,1 ;// #6 Stopped-on-position-limit bit
M631->X:$000330,21,1 ;// #6 Positive-end-limit-set bit
M632->X:$000330,22,1 ;// #6 Negative-end-limit-set bit
M633->X:$000330,13,1 ;// #6 Desired-velocity-zero bit
M635->X:$000330,15,1 ;// #6 Dwell-in-progress bit
M637->X:$000330,17,1 ;// #6 Running-program bit
M638->X:$000330,18,1 ;// #6 Open-loop-mode bit
M639->X:$000330,19,1 ;// #6 Amplifier-enabled status bit
M640->Y:$000340,0,1 ;// #6 Background in-position bit
M641->Y:$000340,1,1 ;// #6 Warning-following error bit
M642->Y:$000340,2,1 ;// #6 Fatal-following-error bit
M643->Y:$000340,3,1 ;// #6 Amplifier-fault-error bit
M644->Y:$000340,13,1 ;// #6 Foreground in-position bit
M645->Y:$000340,10,1 ;// #6 Home-complete bit
M646->Y:$000340,6,1 ;// #6 Integrated following error fault bit
M647->Y:$000340,5,1 ;// #6 I2T fault bit
M648->Y:$000340,8,1 ;// #6 Phasing error fault bit
M649->Y:$000340,9,1 ;// #6 Phasing search-in-progress bit

;// MACRO IC 0 Node 9 Flag Registers (usually used for Motor #6)
M650->X:$003449,0,24 ;// MACRO IC 0 Node 9 flag status register
M651->Y:$003449,0,24 ;// MACRO IC 0 Node 9 flag command register
M653->X:$003449,20,4 ;// MACRO IC 0 Node 9 TUVW flags
M654->Y:$003449,14,1 ;// MACRO IC 0 Node 9 amplifier enable flag
M655->X:$003449,15,1 ;// MACRO IC 0 Node 9 node/amplifier fault flag
M656->X:$003449,16,1 ;// MACRO IC 0 Node 9 home flag
M657->X:$003449,17,1 ;// MACRO IC 0 Node 9 positive limit flag
M658->X:$003449,18,1 ;// MACRO IC 0 Node 9 negative limit flag
M659->X:$003449,19,1 ;// MACRO IC 0 Node 9 user flag

;// Motor #6 Move Registers
M661->D:$000308 ;// #6 Commanded position (1/[Ixx08*32] cts)
M662->D:$00030B ;// #6 Actual position (1/[Ixx08*32] cts)
M663->D:$000347 ;// #6 Target (end) position (1/[Ixx08*32] cts)
M664->D:$00034C ;// #6 Position bias (1/[Ixx08*32] cts)
M666->X:$00031D,0,24,S ;// #6 Actual velocity (1/[Ixx09*32] cts/cyc)
M667->D:$00030D ;// #6 Present master pos (1/[Ixx07*32] cts)
M668->X:$00033F,8,16,S ;// #6 Filter Output (16-bit DAC bits)
M669->D:$000310 ;// #6 Compensation correction (1/[Ixx08*32] cts)
M670->D:$000334 ;// #6 Present phase position (including fraction)
M671->X:$000334,24,S ;// #6 Present phase position (counts *Ixx70)
M672->L:$000357 ;// #6 Variable jog position/distance (cts)
M673->Y:$00034E,0,24,S ;// #6 Encoder home capture position (cts)
M674->D:$00036F ;// #6 Averaged actual velocity (1/[Ixx09*32] cts/cyc)
M675->X:$000339,8,16,S ;// #6 Actual quadrature current
M676->Y:$000339,8,16,S ;// #6 Actual direct current
M677->X:$00033C,8,16,S ;// #6 Quadrature current-loop integrator output
M678->Y:$00033C,8,16,S ;// #6 Direct current-loop integrator output
M679->X:$00032E,8,16,S ;// #6 PID internal filter result (16-bit DAC bits)
M688->Y:$078309,0,12,U ;// IC 3 Ch 2 Compare A fractional count
M689->Y:$078308,0,12,U ;// IC 3 Ch 2 Compare B fractional count

;// Motor #6 Axis Definition Registers
M691->L:$00034F ;// #6 X/U/A/B/C-Axis scale factor (cts/unit)
M692->L:$000350 ;// #6 Y/V-Axis scale factor (cts/unit)
M693->L:$000351 ;// #6 Z/W-Axis scale factor (cts/unit)
M694->L:$000352 ;// #6 Axis offset (cts)

;// Servo IC 3 Channel 3 Registers (usually for Motor #7)
M701->X:$078311,0,24,S ;// ENC7 24-bit counter position
M702->Y:$078312,8,16,S ;// OUT7A command value;// DAC or PWM
M703->X:$078313,0,24,S ;// ENC7 captured position
M704->Y:$078313,8,16,S ;// OUT7B command value;// DAC or PWM
M705->Y:$078315,8,16,S ;// ADC7A input value
M706->Y:$078316,8,16,S ;// ADC7B input value
M707->Y:$078314,8,16,S ;// OUT7C command value;// PFM or PWM
M708->Y:$078317,0,24,S ;// ENC7 compare A position
M709->X:$078317,0,24,S ;// ENC7 compare B position
M710->X:$078316,0,24,S ;// ENC7 compare autoincrement value
M711->X:$078315,11 ;// ENC7 compare initial state write enable
M712->X:$078315,12 ;// ENC7 compare initial state
M714->X:$078315,14 ;// AENA7 output status
M715->X:$078310,19 ;// CHC7 input status
M716->X:$078310,9 ;// ENC7 compare output value
M717->X:$078310,11 ;// ENC7 capture flag
M718->X:$078310,8 ;// ENC7 count error flag
M719->X:$078310,14 ;// CHC7 input status
M720->X:$078310,16 ;// HMFL7 flag input status
M721->X:$078310,17 ;// PLIM7 flag input status
M722->X:$078310,18 ;// MLIM7 flag input status
M723->X:$078310,15 ;// FAULT7 flag input status
M724->X:$078310,20 ;// Channel 7 W flag input status
M725->X:$078310,21 ;// Channel 7 V flag input status
M726->X:$078310,22 ;// Channel 7 U flag input status
M727->X:$078310,23 ;// Channel 7 T flag input status
M728->X:$078310,20,4 ;// Channel 7 TUVW inputs as 4-bit value

;// Motor #7 Status Bits
M730->Y:$0003C0,11,1 ;// #7 Stopped-on-position-limit bit
M731->X:$0003B0,21,1 ;// #7 Positive-end-limit-set bit
M732->X:$0003B0,22,1 ;// #7 Negative-end-limit-set bit
M733->X:$0003B0,13,1 ;// #7 Desired-velocity-zero bit
M735->X:$0003B0,15,1 ;// #7 Dwell-in-progress bit
M737->X:$0003B0,17,1 ;// #7 Running-program bit
M738->X:$0003B0,18,1 ;// #7 Open-loop-mode bit
M739->X:$0003B0,19,1 ;// #7 Amplifier-enabled status bit
M740->Y:$0003C0,0,1 ;// #7 Background in-position bit
M741->Y:$0003C0,1,1 ;// #7 Warning-following error bit
M742->Y:$0003C0,2,1 ;// #7 Fatal-following-error bit
M743->Y:$0003C0,3,1 ;// #7 Amplifier-fault-error bit
M744->Y:$0003C0,13,1 ;// #7 Foreground in-position bit
M745->Y:$0003C0,10,1 ;// #7 Home-complete bit
M746->Y:$0003C0,6,1 ;// #7 Integrated following error fault bit
M747->Y:$0003C0,5,1 ;// #7 I2T fault bit
M748->Y:$0003C0,8,1 ;// #7 Phasing error fault bit
M749->Y:$0003C0,9,1 ;// #7 Phasing search-in-progress bit

;// MACRO IC 0 Node 12 Flag Registers (usually used for Motor #7)
M750->X:$00344C,0,24 ;// MACRO IC 0 Node 12 flag status register
M751->Y:$00344C,0,24 ;// MACRO IC 0 Node 12 flag command register
M753->X:$00344C,20,4 ;// MACRO IC 0 Node 12 TUVW flags
M754->Y:$00344C,14,1 ;// MACRO IC 0 Node 12 amplifier enable flag
M755->X:$00344C,15,1 ;// MACRO IC 0 Node 12 node/amplifier fault flag
M756->X:$00344C,16,1 ;// MACRO IC 0 Node 12 home flag
M757->X:$00344C,17,1 ;// MACRO IC 0 Node 12 positive limit flag
M758->X:$00344C,18,1 ;// MACRO IC 0 Node 12 negative limit flag
M759->X:$00344C,19,1 ;// MACRO IC 0 Node 12 user flag

;// Motor #7 Move Registers
M761->D:$000388 ;// #7 Commanded position (1/[Ixx08*32] cts)
M762->D:$00038B ;// #7 Actual position (1/[Ixx08*32] cts)
M763->D:$0003C7 ;// #7 Target (end) position (1/[Ixx08*32] cts)
M764->D:$0003CC ;// #7 Position bias (1/[Ixx08*32] cts)
M766->X:$00039D,0,24,S ;// #7 Actual velocity (1/[Ixx09*32] cts/cyc)
M767->D:$00038D ;// #7 Present master pos (1/[Ixx07*32] cts)
M768->X:$0003BF,8,16,S ;// #7 Filter Output (16-bit DAC bits)
M769->D:$000390 ;// #7 Compensation correction (1/[Ixx08*32] cts)
M770->D:$0003B4 ;// #7 Present phase position (including fraction)
M771->X:$0003B4,24,S ;// #7 Present phase position (counts *Ixx70)
M772->L:$0003D7 ;// #7 Variable jog position/distance (cts)
M773->Y:$0003CE,0,24,S ;// #7 Encoder home capture position (cts)
M774->D:$0003EF ;// #7 Averaged actual velocity (1/[Ixx09*32] cts/cyc)
M775->X:$0003B9,8,16,S ;// #7 Actual quadrature current
M776->Y:$0003B9,8,16,S ;// #7 Actual direct current
M777->X:$0003BC,8,16,S ;// #7 Quadrature current-loop integrator output
M778->Y:$0003BC,8,16,S ;// #7 Direct current-loop integrator output
M779->X:$0003AE,8,16,S ;// #7 PID internal filter result (16-bit DAC bits)
M788->Y:$078311,0,12,U ;// IC 3 Ch 3 Compare A fractional count
M789->Y:$078310,0,12,U ;// IC 3 Ch 3 Compare B fractional count

;// Motor #7 Axis Definition Registers
M791->L:$0003CF ;// #7 X/U/A/B/C-Axis scale factor (cts/unit)
M792->L:$0003D0 ;// #7 Y/V-Axis scale factor (cts/unit)
M793->L:$0003D1 ;// #7 Z/W-Axis scale factor (cts/unit)
M794->L:$0003D2 ;// #7 Axis offset (cts)

;// Servo IC 3 Channel 4 Registers (usually for Motor #8)
M801->X:$078319,0,24,S ;// ENC8 24-bit counter position
M802->Y:$07831A,8,16,S ;// OUT8A command value;// DAC or PWM
M803->X:$07831B,0,24,S ;// ENC8 captured position
M804->Y:$07831B,8,16,S ;// OUT8B command value;// DAC or PWM
M805->Y:$07831D,8,16,S ;// ADC8A input value
M806->Y:$07831E,8,16,S ;// ADC8B input value
M807->Y:$07831C,8,16,S ;// OUT8C command value;// PFM or PWM
M808->Y:$07831F,0,24,S ;// ENC8 compare A position
M809->X:$07831F,0,24,S ;// ENC8 compare B position
M810->X:$07831E,0,24,S ;// ENC8 compare autoincrement value
M811->X:$07831D,11 ;// ENC8 compare initial state write enable
M812->X:$07831D,12 ;// ENC8 compare initial state
M814->X:$07831D,14 ;// AENA8 output status
M815->X:$078318,19 ;// USER8 flag input status
M816->X:$078318,9 ;// ENC8 compare output value
M817->X:$078318,11 ;// ENC8 capture flag
M818->X:$078318,8 ;// ENC8 count error flag
M819->X:$078318,14 ;// CHC8 input status
M820->X:$078318,16 ;// HMFL8 flag input status
M821->X:$078318,17 ;// PLIM8 flag input status
M822->X:$078318,18 ;// MLIM8 flag input status
M823->X:$078318,15 ;// FAULT8 flag input status
M824->X:$078318,20 ;// Channel 8 W flag input status
M825->X:$078318,21 ;// Channel 8 V flag input status
M826->X:$078318,22 ;// Channel 8 U flag input status
M827->X:$078318,23 ;// Channel 8 T flag input status
M828->X:$078318,20,4 ;// Channel 8 TUVW inputs as 4-bit value

;// Motor #8 Status Bits
M830->Y:$000440,11,1 ;// #8 Stopped-on-position-limit bit
M831->X:$000430,21,1 ;// #8 Positive-end-limit-set bit
M832->X:$000430,22,1 ;// #8 Negative-end-limit-set bit
M833->X:$000430,13,1 ;// #8 Desired-velocity-zero bit
M835->X:$000430,15,1 ;// #8 Dwell-in-progress bit
M837->X:$000430,17,1 ;// #8 Running-program bit
M838->X:$000430,18,1 ;// #8 Open-loop-mode bit
M839->X:$000430,19,1 ;// #8 Amplifier-enabled status bit
M840->Y:$000440,0,1 ;// #8 Background in-position bit
M841->Y:$000440,1,1 ;// #8 Warning-following error bit
M842->Y:$000440,2,1 ;// #8 Fatal-following-error bit
M843->Y:$000440,3,1 ;// #8 Amplifier-fault-error bit
M844->Y:$000440,13,1 ;// #8 Foreground in-position bit
M845->Y:$000440,10,1 ;// #8 Home-complete bit
M846->Y:$000440,6,1 ;// #8 Integrated following error fault bit
M847->Y:$000440,5,1 ;// #8 I2T fault bit
M848->Y:$000440,8,1 ;// #8 Phasing error fault bit
M849->Y:$000440,9,1 ;// #8 Phasing search-in-progress bit

;// MACRO IC 0 Node 13 Flag Registers (usually used for Motor #8)
M850->X:$00344D,0,24 ;// MACRO IC 0 Node 13 flag status register
M851->Y:$00344D,0,24 ;// MACRO IC 0 Node 13 flag command register
M853->X:$00344D,20,4 ;// MACRO IC 0 Node 13 TUVW flags
M854->Y:$00344D,14,1 ;// MACRO IC 0 Node 13 amplifier enable flag
M855->X:$00344D,15,1 ;// MACRO IC 0 Node 13 node/amplifier fault flag
M856->X:$00344D,16,1 ;// MACRO IC 0 Node 13 home flag
M857->X:$00344D,17,1 ;// MACRO IC 0 Node 13 positive limit flag
M858->X:$00344D,18,1 ;// MACRO IC 0 Node 13 negative limit flag
M859->X:$00344D,19,1 ;// MACRO IC 0 Node 13 user flag

;// Motor #8 Move Registers
M861->D:$000408 ;// #8 Commanded position (1/[Ixx08*32] cts)
M862->D:$00040B ;// #8 Actual position (1/[Ixx08*32] cts)
M863->D:$000447 ;// #8 Target (end) position (1/[Ixx08*32] cts)
M864->D:$00044C ;// #8 Position bias (1/[Ixx08*32] cts)
M866->X:$00041D,0,24,S ;// #8 Actual velocity (1/[Ixx09*32] cts/cyc)
M867->D:$00040D ;// #8 Present master pos (1/[Ixx07*32] cts)
M868->X:$00043F,8,16,S ;// #8 Filter Output (16-bit DAC bits)
M869->D:$000410 ;// #8 Compensation correction 1/[Ixx08*32] cts)
M870->D:$000434 ;// #8 Present phase position (including fraction)
M871->X:$000434,24,S ;// #8 Present phase position (counts *Ixx70)
M872->L:$000457 ;// #8 Variable jog position/distance (cts)
M873->Y:$00044E,0,24,S ;// #8 Encoder home capture position (cts)
M874->D:$00046F ;// #8 Averaged actual velocity (1/[Ixx09*32] cts/cyc)
M875->X:$000439,8,16,S ;// #8 Actual quadrature current
M876->Y:$000439,8,16,S ;// #8 Actual direct current
M877->X:$00043C,8,16,S ;// #8 Quadrature current-loop integrator output
M878->Y:$00043C,8,16,S ;// #8 Direct current-loop integrator output
M879->X:$00042E,8,16,S ;// #8 PID internal filter result (16-bit DAC bits)
M888->Y:$078319,0,12,U ;// IC 3 Ch 4 Compare A fractional count
M889->Y:$078318,0,12,U ;// IC 3 Ch 4 Compare B fractional count

;// Motor #8 Axis Definition Registers
M891->L:$00044F ;// #8 X/U/A/B/C-Axis scale factor (cts/unit)
M892->L:$000450 ;// #8 Y/V-Axis scale factor (cts/unit)
M893->L:$000451 ;// #8 Z/W-Axis scale factor (cts/unit)
M894->L:$000452 ;// #8 Axis offset (cts)

;// Servo IC 4 Channel 1 Registers (usually for Motor #9)
M901->X:$079201,0,24,S ;// ENC1 24-bit counter position
M902->Y:$079202,8,16,S ;// OUT1A command value;// DAC or PWM
M903->X:$079203,0,24,S ;// ENC1 captured position
M904->Y:$079203,8,16,S ;// OUT1B command value;// DAC or PWM
M905->Y:$079205,8,16,S ;// ADC1A input value
M906->Y:$079206,8,16,S ;// ADC1B input value
M907->Y:$079204,8,16,S ;// OUT1C command value;// PFM or PWM
M908->Y:$079207,0,24,S ;// ENC1 compare A position
M909->X:$079207,0,24,S ;// ENC1 compare B position
M910->X:$079206,0,24,S ;// ENC1 compare autoincrement value
M911->X:$079205,11 ;// ENC1 compare initial state write enable
M912->X:$079205,12 ;// ENC1 compare initial state
M914->X:$079205,14 ;// AENA1 output status
M915->X:$079200,19 ;// USER1 flag input status
M916->X:$079200,9 ;// ENC1 compare output value
M917->X:$079200,11 ;// ENC1 capture flag
M918->X:$079200,8 ;// ENC1 count error flag
M919->X:$079200,14 ;// CHC1 input status
M920->X:$079200,16 ;// HMFL1 flag input status
M921->X:$079200,17 ;// PLIM1 flag input status
M922->X:$079200,18 ;// MLIM1 flag input status
M923->X:$079200,15 ;// FAULT1 flag input status
M924->X:$079200,20 ;// Channel 1 W flag input status
M925->X:$079200,21 ;// Channel 1 V flag input status
M926->X:$079200,22 ;// Channel 1 U flag input status
M927->X:$079200,23 ;// Channel 1 T flag input status
M928->X:$079200,20,4 ;// Channel 1 TUVW inputs as 4-bit value

;// Motor #9 Status Bits
M930->Y:$0004C0,11,1 ;// #9 Stopped-on-position-limit bit
M931->X:$0004B0,21,1 ;// #9 Positive-end-limit-set bit
M932->X:$0004B0,22,1 ;// #9 Negative-end-limit-set bit
M933->X:$0004B0,13,1 ;// #9 Desired-velocity-zero bit
M935->X:$0004B0,15,1 ;// #9 Dwell-in-progress bit
M937->X:$0004B0,17,1 ;// #9 Running-program bit
M938->X:$0004B0,18,1 ;// #9 Open-loop-mode bit
M939->X:$0004B0,19,1 ;// #9 Amplifier-enabled status bit
M940->Y:$0004C0,0,1 ;// #9 Background in-position bit
M941->Y:$0004C0,1,1 ;// #9 Warning-following error bit
M942->Y:$0004C0,2,1 ;// #9 Fatal-following-error bit
M943->Y:$0004C0,3,1 ;// #9 Amplifier-fault-error bit
M944->Y:$0004C0,13,1 ;// #9 Foreground in-position bit
M945->Y:$0004C0,10,1 ;// #9 Home-complete bit
M946->Y:$0004C0,6,1 ;// #9 Integrated following error fault bit
M947->Y:$0004C0,5,1 ;// #9 I2T fault bit
M948->Y:$0004C0,8,1 ;// #9 Phasing error fault bit
M949->Y:$0004C0,9,1 ;// #9 Phasing search-in-progress bit

;// MACRO IC 1 Node 0 Flag Registers (usually used for Motor #9)
M950->X:$003450,0,24 ;// MACRO IC 1 Node 0 flag status register
M951->Y:$003450,0,24 ;// MACRO IC 1 Node 0 flag command register
M953->X:$003450,20,4 ;// MACRO IC 1 Node 0 TUVW flags
M954->Y:$003450,14,1 ;// MACRO IC 1 Node 0 amplifier enable flag
M955->X:$003450,15,1 ;// MACRO IC 1 Node 0 node/amplifier fault flag
M956->X:$003450,16,1 ;// MACRO IC 1 Node 0 home flag
M957->X:$003450,17,1 ;// MACRO IC 1 Node 0 positive limit flag
M958->X:$003450,18,1 ;// MACRO IC 1 Node 0 negative limit flag
M959->X:$003450,19,1 ;// MACRO IC 1 Node 0 user flag

;// Motor #9 Move Registers
M961->D:$000488 ;// #9 Commanded position (1/[Ixx08*32] cts)
M962->D:$00048B ;// #9 Actual position (1/[Ixx08*32] cts)
M963->D:$0004C7 ;// #9 Target (end) position (1/[Ixx08*32] cts)
M964->D:$0004CC ;// #9 Position bias (1/[Ixx08*32] cts)
M966->X:$00049D,0,24,S ;// #9 Actual velocity (1/[Ixx09*32] cts/cyc)
M967->D:$00048D ;// #9 Present master pos (1/[Ixx07*32] cts)
M968->X:$0004BF,8,16,S ;// #9 Filter Output (16-bit DAC bits)
M969->D:$000490 ;// #9 Compensation correction (1/[Ixx08*32] cts)
M970->D:$0004B4 ;// #9 Present phase position (including fraction)
M971->X:$0004B4,24,S ;// #9 Present phase position (counts *Ixx70)
M972->L:$0004D7 ;// #9 Variable jog position/distance (cts)
M973->Y:$0004CE,0,24,S ;// #9 Encoder home capture position (cts)
M974->D:$0004EF ;// #9 Averaged actual velocity (1/[Ixx09*32] cts/cyc)
M975->X:$0004B9,8,16,S ;// #9 Actual quadrature current
M976->Y:$0004B9,8,16,S ;// #9 Actual direct current
M977->X:$0004BC,8,16,S ;// #9 Quadrature current-loop integrator output
M978->Y:$0004BC,8,16,S ;// #9 Direct current-loop integrator output
M979->X:$0004AE,8,16,S ;// #9 PID internal filter result (16-bit DAC bits)
M988->Y:$079201,0,12,U ;// IC 4 Ch 1 Compare A fractional count
M989->Y:$079200,0,12,U ;// IC 4 Ch 1 Compare B fractional count

;// Motor #9 Axis Definition Registers
M991->L:$0004CF ;// #9 X/U/A/B/C-Axis scale factor (cts/unit)
M992->L:$0004D0 ;// #9 Y/V-Axis scale factor (cts/unit)
M993->L:$0004D1 ;// #9 Z/W-Axis scale factor (cts/unit)
M994->L:$0004D2 ;// #9 Axis offset (cts)

;// Servo IC 4 Channel 2 Registers (usually for Motor #10)
M1001->X:$079209,0,24,S ;// ENC2 24-bit counter position
M1002->Y:$07920A,8,16,S ;// OUT2A command value;// DAC or PWM
M1003->X:$07920B,0,24,S ;// ENC2 captured position
M1004->Y:$07920B,8,16,S ;// OUT2B command value;// DAC or PWM
M1005->Y:$07920D,8,16,S ;// ADC2A input value
M1006->Y:$07920E,8,16,S ;// ADC2B input value
M1007->Y:$07920C,8,16,S ;// OUT2C command value;// PFM or PWM
M1008->Y:$07920F,0,24,S ;// ENC2 compare A position
M1009->X:$07920F,0,24,S ;// ENC2 compare B position
M1010->X:$07920E,0,24,S ;// ENC2 compare autoincrement value
M1011->X:$07920D,11 ;// ENC2 compare initial state write enable
M1012->X:$07920D,12 ;// ENC2 compare initial state
M1014->X:$07920D,14 ;// AENA2 output status
M1015->X:$079208,19 ;// USER2 flag input status
M1016->X:$079208,9 ;// ENC2 compare output value
M1017->X:$079208,11 ;// ENC2 capture flag
M1018->X:$079208,8 ;// ENC2 count error flag
M1019->X:$079208,14 ;// CHC2 input status
M1020->X:$079208,16 ;// HMFL2 flag input status
M1021->X:$079208,17 ;// PLIM2 flag input status
M1022->X:$079208,18 ;// MLIM2 flag input status
M1023->X:$079208,15 ;// FAULT2 flag input status
M1024->X:$079208,20 ;// Channel 2 W flag input status
M1025->X:$079208,21 ;// Channel 2 V flag input status
M1026->X:$079208,22 ;// Channel 2 U flag input status
M1027->X:$079208,23 ;// Channel 2 T flag input status
M1028->X:$079208,20,4 ;// Channel 2 TUVW inputs as 4-bit value

;// Motor #10 Status Bits
M1030->Y:$000540,11,1 ;// #10 Stopped-on-position-limit bit
M1031->X:$000530,21,1 ;// #10 Positive-end-limit-set bit
M1032->X:$000530,22,1 ;// #10 Negative-end-limit-set bit
M1033->X:$000530,13,1 ;// #10 Desired-velocity-zero bit
M1035->X:$000530,15,1 ;// #10 Dwell-in-progress bit
M1037->X:$000530,17,1 ;// #10 Running-program bit
M1038->X:$000530,18,1 ;// #10 Open-loop-mode bit
M1039->X:$000530,19,1 ;// #10 Amplifier-enabled status bit
M1040->Y:$000540,0,1 ;// #10 Background in-position bit
M1041->Y:$000540,1,1 ;// #10 Warning-following error bit
M1042->Y:$000540,2,1 ;// #10 Fatal-following-error bit
M1043->Y:$000540,3,1 ;// #10 Amplifier-fault-error bit
M1044->Y:$000540,13,1 ;// #10 Foreground in-position bit
M1045->Y:$000540,10,1 ;// #10 Home-complete bit
M1046->Y:$000540,6,1 ;// #10 Integrated following error fault bit
M1047->Y:$000540,5,1 ;// #10 I2T fault bit
M1048->Y:$000540,8,1 ;// #10 Phasing error fault bit
M1049->Y:$000540,9,1 ;// #10 Phasing search-in-progress bit

;// MACRO IC 1 Node 1 Flag Registers (usually used for Motor #10)
M1050->X:$003451,0,24 ;// MACRO IC 1 Node 1 flag status register
M1051->Y:$003451,0,24 ;// MACRO IC 1 Node 1 flag command register
M1053->X:$003451,20,4 ;// MACRO IC 1 Node 1 TUVW flags
M1054->Y:$003451,14,1 ;// MACRO IC 1 Node 1 amplifier enable flag
M1055->X:$003451,15,1 ;// MACRO IC 1 Node 1 node/amplifier fault flag
M1056->X:$003451,16,1 ;// MACRO IC 1 Node 1 home flag
M1057->X:$003451,17,1 ;// MACRO IC 1 Node 1 positive limit flag
M1058->X:$003451,18,1 ;// MACRO IC 1 Node 1 negative limit flag
M1059->X:$003451,19,1 ;// MACRO IC 1 Node 1 user flag

;// Motor #10 Move Registers
M1061->D:$000508 ;// #10 Commanded position (1/[Ixx08*32] cts)
M1062->D:$00050B ;// #10 Actual position (1/[Ixx08*32] cts)
M1063->D:$000547 ;// #10 Target (end) position (1/[Ixx08*32] cts)
M1064->D:$00054C ;// #10 Position bias (1/[Ixx08*32] cts)
M1066->X:$00051D,0,24,S ;// #10 Actual velocity (1/[Ixx09*32] cts/cyc)
M1067->D:$00050D ;// #10 Present master pos (1/[Ixx07*32] cts)
M1068->X:$00053F,8,16,S ;// #10 Filter Output (16-bit DAC bits)
M1069->D:$000510 ;// #10 Compensation correction (1/[Ixx08*32] cts)
M1070->D:$000534 ;// #10 Present phase position (including fraction)
M1071->X:$000534,24,S ;// #10 Present phase position (counts *Ixx70)
M1072->L:$000557 ;// #10 Variable jog position/distance (cts)
M1073->Y:$00054E,0,24,S ;// #10 Encoder home capture position (cts)
M1074->D:$00056F ;// #10 Averaged actual velocity (1/[Ixx09*32] cts/cyc)
M1075->X:$000539,8,16,S ;// #10 Actual quadrature current
M1076->Y:$000539,8,16,S ;// #10 Actual direct current
M1077->X:$00053C,8,16,S ;// #10 Quadrature current-loop integrator output
M1078->Y:$00053C,8,16,S ;// #10 Direct current-loop integrator output
M1079->X:$00052E,8,16,S ;// #10 PID internal filter result (16-bit DAC bits)
M1088->Y:$079209,0,12,U ;// IC 4 Ch 2 Compare A fractional count
M1089->Y:$079208,0,12,U ;// IC 4 Ch 2 Compare B fractional count

;// Motor #10 Axis Definition Registers
M1091->L:$00054F ;// #10 X/U/A/B/C-Axis scale factor (cts/unit)
M1092->L:$000550 ;// #10 Y/V-Axis scale factor (cts/unit)
M1093->L:$000551 ;// #10 Z/W-Axis scale factor (cts/unit)
M1094->L:$000552 ;// #10 Axis offset (cts)

;// Servo IC 4 Channel 3 Registers (usually for Motor #11)
M1101->X:$079211,0,24,S ;// ENC3 24-bit counter position
M1102->Y:$079212,8,16,S ;// OUT3A command value;// DAC or PWM
M1103->X:$079213,0,24,S ;// ENC3 captured position
M1104->Y:$079213,8,16,S ;// OUT3B command value;// DAC or PWM
M1105->Y:$079215,8,16,S ;// ADC3A input value
M1106->Y:$079216,8,16,S ;// ADC3B input value
M1107->Y:$079214,8,16,S ;// OUT3C command value;// PFM or PWM
M1108->Y:$079217,0,24,S ;// ENC3 compare A position
M1109->X:$079217,0,24,S ;// ENC3 compare B position
M1110->X:$079216,0,24,S ;// ENC3 compare autoincrement value
M1111->X:$079215,11 ;// ENC3 compare initial state write enable
M1112->X:$079215,12 ;// ENC3 compare initial state
M1114->X:$079215,14 ;// AENA3 output status
M1115->X:$079210,19 ;// USER3 flag input status
M1116->X:$079210,9 ;// ENC3 compare output value
M1117->X:$079210,11 ;// ENC3 capture flag
M1118->X:$079210,8 ;// ENC3 count error flag
M1119->X:$079210,14 ;// CHC3 input status
M1120->X:$079210,16 ;// HMFL3 flag input status
M1121->X:$079210,17 ;// PLIM3 flag input status
M1122->X:$079210,18 ;// MLIM3 flag input status
M1123->X:$079210,15 ;// FAULT3 flag input status
M1124->X:$079210,20 ;// Channel 3 W flag input status
M1125->X:$079210,21 ;// Channel 3 V flag input status
M1126->X:$079210,22 ;// Channel 3 U flag input status
M1127->X:$079210,23 ;// Channel 3 T flag input status
M1128->X:$079210,20,4 ;// Channel 3 TUVW inputs as 4-bit value

;// Motor #11 Status Bits
M1130->Y:$0005C0,11,1 ;// #11 Stopped-on-position-limit bit
M1131->X:$0005B0,21,1 ;// #11 Positive-end-limit-set bit
M1132->X:$0005B0,22,1 ;// #11 Negative-end-limit-set bit
M1133->X:$0005B0,13,1 ;// #11 Desired-velocity-zero bit
M1135->X:$0005B0,15,1 ;// #11 Dwell-in-progress bit
M1137->X:$0005B0,17,1 ;// #11 Running-program bit
M1138->X:$0005B0,18,1 ;// #11 Open-loop-mode bit
M1139->X:$0005B0,19,1 ;// #11 Amplifier-enabled status bit
M1140->Y:$0005C0,0,1 ;// #11 Background in-position bit
M1141->Y:$0005C0,1,1 ;// #11 Warning-following error bit
M1142->Y:$0005C0,2,1 ;// #11 Fatal-following-error bit
M1143->Y:$0005C0,3,1 ;// #11 Amplifier-fault-error bit
M1144->Y:$0005C0,13,1 ;// #11 Foreground in-position bit
M1145->Y:$0005C0,10,1 ;// #11 Home-complete bit
M1146->Y:$0005C0,6,1 ;// #11 Integrated following error fault bit
M1147->Y:$0005C0,5,1 ;// #11 I2T fault bit
M1148->Y:$0005C0,8,1 ;// #11 Phasing error fault bit
M1149->Y:$0005C0,9,1 ;// #11 Phasing search-in-progress bit

;// MACRO IC 1 Node 4 Flag Registers (usually used for Motor #11)
M1150->X:$003454,0,24 ;// MACRO IC 1 Node 4 flag status register
M1151->Y:$003454,0,24 ;// MACRO IC 1 Node 4 flag command register
M1153->X:$003454,20,4 ;// MACRO IC 1 Node 4 TUVW flags
M1154->Y:$003454,14,1 ;// MACRO IC 1 Node 4 amplifier enable flag
M1155->X:$003454,15,1 ;// MACRO IC 1 Node 4 node/amplifier fault flag
M1156->X:$003454,16,1 ;// MACRO IC 1 Node 4 home flag
M1157->X:$003454,17,1 ;// MACRO IC 1 Node 4 positive limit flag
M1158->X:$003454,18,1 ;// MACRO IC 1 Node 4 negative limit flag
M1159->X:$003454,19,1 ;// MACRO IC 1 Node 4 user flag

;// Motor #11 Move Registers
M1161->D:$000588 ;// #11 Commanded position (1/[Ixx08*32] cts)
M1162->D:$00058B ;// #11 Actual position (1/[Ixx08*32] cts)
M1163->D:$0005C7 ;// #11 Target (end) position (1/[Ixx08*32] cts)
M1164->D:$0005CC ;// #11 Position bias (1/[Ixx08*32] cts)
M1166->X:$00059D,0,24,S ;// #11 Actual velocity (1/[Ixx09*32] cts/cyc)
M1167->D:$00058D ;// #11 Present master pos (1/[Ixx07*32] cts)
M1168->X:$0005BF,8,16,S ;// #11 Filter Output (16-bit DAC bits)
M1169->D:$000590 ;// #11 Compensation correction (1/[Ixx08*32] cts)
M1170->D:$0005B4 ;// #11 Present phase position (including fraction)
M1171->X:$0005B4,24,S ;// #11 Present phase position (counts *Ixx70)
M1172->L:$0005D7 ;// #11 Variable jog position/distance (cts)
M1173->Y:$0005CE,0,24,S ;// #11 Encoder home capture position (cts)
M1174->D:$0005EF ;// #11 Averaged actual velocity (1/[Ixx09*32] cts/cyc)
M1175->X:$0005B9,8,16,S ;// #11 Actual quadrature current
M1176->Y:$0005B9,8,16,S ;// #11 Actual direct current
M1177->X:$0005BC,8,16,S ;// #11 Quadrature current-loop integrator output
M1178->Y:$0005BC,8,16,S ;// #11 Direct current-loop integrator output
M1179->X:$0005AE,8,16,S ;// #11 PID internal filter result (16-bit DAC bits)
M1188->Y:$079211,0,12,U ;// IC 4 Ch 3 Compare A fractional count
M1189->Y:$079210,0,12,U ;// IC 4 Ch 3 Compare B fractional count

;// Motor #11 Axis Definition Registers
M1191->L:$0005CF ;// #11 X/U/A/B/C-Axis scale factor (cts/unit)
M1192->L:$0005D0 ;// #11 Y/V-Axis scale factor (cts/unit)
M1193->L:$0005D1 ;// #11 Z/W-Axis scale factor (cts/unit)
M1194->L:$0005D2 ;// #11 Axis offset (cts)

;// Servo IC 4 Channel 4 Registers (usually for Motor #12)
M1201->X:$079219,0,24,S ;// ENC4 24-bit counter position
M1202->Y:$07921A,8,16,S ;// OUT4A command value;// DAC or PWM
M1203->X:$07921B,0,24,S ;// ENC4 captured position
M1204->Y:$07921B,8,16,S ;// OUT4B command value;// DAC or PWM
M1205->Y:$07921D,8,16,S ;// ADC4A input value
M1206->Y:$07921E,8,16,S ;// ADC4B input value
M1207->Y:$07921C,8,16,S ;// OUT4C command value;// PFM or PWM
M1208->Y:$07921F,0,24,S ;// ENC4 compare A position
M1209->X:$07921F,0,24,S ;// ENC4 compare B position
M1210->X:$07921E,0,24,S ;// ENC4 compare autoincrement value
M1211->X:$07921D,11 ;// ENC4 compare initial state write enable
M1212->X:$07921D,12 ;// ENC4 compare initial state
M1214->X:$07921D,14 ;// AENA4 output status
M1215->X:$079218,19 ;// USER4 flag input status
M1216->X:$079218,9 ;// ENC4 compare output value
M1217->X:$079218,11 ;// ENC4 capture flag
M1218->X:$079218,8 ;// ENC4 count error flag
M1219->X:$079218,14 ;// HMFL4 flag input status
M1220->X:$079218,16 ;// CHC4 input status
M1221->X:$079218,17 ;// PLIM4 flag input status
M1222->X:$079218,18 ;// MLIM4 flag input status
M1223->X:$079218,15 ;// FAULT4 flag input status
M1224->X:$079218,20 ;// Channel 4 W flag input status
M1225->X:$079218,21 ;// Channel 4 V flag input status
M1226->X:$079218,22 ;// Channel 4 U flag input status
M1227->X:$079218,23 ;// Channel 4 T flag input status
M1228->X:$079218,20,4 ;// Channel 4 TUVW inputs as 4-bit value

;// Motor #12 Status Bits
M1230->Y:$000640,11,1 ;// #12 Stopped-on-position-limit bit
M1231->X:$000630,21,1 ;// #12 Positive-end-limit-set bit
M1232->X:$000630,22,1 ;// #12 Negative-end-limit-set bit
M1233->X:$000630,13,1 ;// #12 Desired-velocity-zero bit
M1235->X:$000630,15,1 ;// #12 Dwell-in-progress bit
M1237->X:$000630,17,1 ;// #12 Running-program bit
M1238->X:$000630,18,1 ;// #12 Open-loop-mode bit
M1239->X:$000630,19,1 ;// #12 Amplifier-enabled status bit
M1240->Y:$000640,0,1 ;// #12 Background in-position bit
M1241->Y:$000640,1,1 ;// #12 Warning-following error bit
M1242->Y:$000640,2,1 ;// #12 Fatal-following-error bit
M1243->Y:$000640,3,1 ;// #12 Amplifier-fault-error bit
M1244->Y:$000640,13,1 ;// #12 Foreground in-position bit
M1245->Y:$000640,10,1 ;// #12 Home-complete bit
M1246->Y:$000640,6,1 ;// #12 Integrated following error fault bit
M1247->Y:$000640,5,1 ;// #12 I2T fault bit
M1248->Y:$000640,8,1 ;// #12 Phasing error fault bit
M1249->Y:$000640,9,1 ;// #12 Phasing search-in-progress bit

;// MACRO IC 1 Node 5 Flag Registers (usually used for Motor #12)
M1250->X:$003455,0,24 ;// MACRO IC 1 Node 5 flag status register
M1251->Y:$003455,0,24 ;// MACRO IC 1 Node 5 flag command register
M1253->X:$003455,20,4 ;// MACRO IC 1 Node 5 TUVW flags
M1254->Y:$003455,14,1 ;// MACRO IC 1 Node 5 amplifier enable flag
M1255->X:$003455,15,1 ;// MACRO IC 1 Node 5 node/amplifier fault flag
M1256->X:$003455,16,1 ;// MACRO IC 1 Node 5 home flag
M1257->X:$003455,17,1 ;// MACRO IC 1 Node 5 positive limit flag
M1258->X:$003455,18,1 ;// MACRO IC 1 Node 5 negative limit flag
M1259->X:$003455,19,1 ;// MACRO IC 1 Node 5 user flag

;// Motor #12 Move Registers
M1261->D:$000608 ;// #12 Commanded position (1/[Ixx08*32] cts)
M1262->D:$00060B ;// #12 Actual position (1/[Ixx08*32] cts)
M1263->D:$000647 ;// #12 Target (end) position (1/[Ixx08*32] cts)
M1264->D:$00064C ;// #12 Position bias (1/[Ixx08*32] cts)
M1266->X:$00061D,0,24,S ;// #12 Actual velocity (1/[Ixx09*32] cts/cyc)
M1267->D:$00060D ;// #12 Present master pos (1/[Ixx07*32] cts)
M1268->X:$00063F,8,16,S ;// #12 Filter Output (16-bit DAC bits)
M1269->D:$000610 ;// #12 Compensation correction (1/[Ixx08*32] cts)
M1270->D:$000634 ;// #12 Present phase position (including fraction)
M1271->X:$000634,24,S ;// #12 Present phase position (counts *Ixx70)
M1272->L:$000657 ;// #12 Variable jog position/distance (cts)
M1273->Y:$00064E,0,24,S ;// #12 Encoder home capture position (cts)
M1274->D:$00066F ;// #12 Averaged actual velocity (1/[Ixx09*32] cts/cyc)
M1275->X:$000639,8,16,S ;// #12 Actual quadrature current
M1276->Y:$000639,8,16,S ;// #12 Actual direct current
M1277->X:$00063C,8,16,S ;// #12 Quadrature current-loop integrator output
M1278->Y:$00063C,8,16,S ;// #12 Direct current-loop integrator output
M1279->X:$00062E,8,16,S ;// #12 PID internal filter result (16-bit DAC bits)
M1288->Y:$079219,0,12,U ;// IC 4 Ch 4 Compare A fractional count
M1289->Y:$079218,0,12,U ;// IC 4 Ch 4 Compare B fractional count

;// Motor #12 Axis Definition Registers
M1291->L:$00064F ;// #12 X/U/A/B/C-Axis scale factor (cts/unit)
M1292->L:$000650 ;// #12 Y/V-Axis scale factor (cts/unit)
M1293->L:$000651 ;// #12 Z/W-Axis scale factor (cts/unit)
M1294->L:$000652 ;// #12 Axis offset (cts)

;// De-multiplexed ADC values from Opt. 12, ACC-36
M5061->Y:$003400,12,12,U ;// Demuxed low ADC register from I5061
M5062->Y:$003402,12,12,U ;// Demuxed low ADC register from I5062
M5063->Y:$003404,12,12,U ;// Demuxed low ADC register from I5063
M5064->Y:$003406,12,12,U ;// Demuxed low ADC register from I5064
M5065->Y:$003408,12,12,U ;// Demuxed low ADC register from I5065
M5066->Y:$00340A,12,12,U ;// Demuxed low ADC register from I5066
M5067->Y:$00340C,12,12,U ;// Demuxed low ADC register from I5067
M5068->Y:$00340E,12,12,U ;// Demuxed low ADC register from I5068
M5069->Y:$003410,12,12,U ;// Demuxed low ADC register from I5069
M5070->Y:$003412,12,12,U ;// Demuxed low ADC register from I5070
M5071->Y:$003414,12,12,U ;// Demuxed low ADC register from I5071
M5072->Y:$003416,12,12,U ;// Demuxed low ADC register from I5072
M5073->Y:$003418,12,12,U ;// Demuxed low ADC register from I5073
M5074->Y:$00341A,12,12,U ;// Demuxed low ADC register from I5074
M5075->Y:$00341C,12,12,U ;// Demuxed low ADC register from I5075
M5076->Y:$00341E,12,12,U ;// Demuxed low ADC register from I5076
M5081->Y:$003401,12,12,U ;// Demuxed high ADC register from I5061
M5082->Y:$003403,12,12,U ;// Demuxed high ADC register from I5062
M5083->Y:$003405,12,12,U ;// Demuxed high ADC register from I5063
M5084->Y:$003407,12,12,U ;// Demuxed high ADC register from I5064
M5085->Y:$003409,12,12,U ;// Demuxed high ADC register from I5065
M5086->Y:$00340B,12,12,U ;// Demuxed high ADC register from I5066
M5087->Y:$00340D,12,12,U ;// Demuxed high ADC register from I5067
M5088->Y:$00340F,12,12,U ;// Demuxed high ADC register from I5068
M5089->Y:$003411,12,12,U ;// Demuxed high ADC register from I5069
M5090->Y:$003413,12,12,U ;// Demuxed high ADC register from I5070
M5091->Y:$003415,12,12,U ;// Demuxed high ADC register from I5071
M5092->Y:$003417,12,12,U ;// Demuxed high ADC register from I5072
M5093->Y:$003419,12,12,U ;// Demuxed high ADC register from I5073
M5094->Y:$00341B,12,12,U ;// Demuxed high ADC register from I5074
M5095->Y:$00341D,12,12,U ;// Demuxed high ADC register from I5075
M5096->Y:$00341F,12,12,U ;// Demuxed high ADC register from I5076


;// Coordinate System 1 (&1) timers
M5111->X:$002015,0,24,S ;// &1 Isx11 timer (for synchronous assignment)
M5112->Y:$002015,0,24,S ;// &1 Isx12 timer (for synchronous assignment)

;// Coordinate System 1 (&1) end-of-calculated-move positions
M5141->L:$002041 ;// &1 A-axis target position (engineering units)
M5142->L:$002042 ;// &1 B-axis target position (engineering units)
M5143->L:$002043 ;// &1 C-axis target position (engineering units)
M5144->L:$002044 ;// &1 U-axis target position (engineering units)
M5145->L:$002045 ;// &1 V-axis target position (engineering units)
M5146->L:$002046 ;// &1 W-axis target position (engineering units)
M5147->L:$002047 ;// &1 X-axis target position (engineering units)
M5148->L:$002048 ;// &1 Y-axis target position (engineering units)
M5149->L:$002049 ;// &1 Z-axis target position (engineering units)

;// Coordinate System 1 (&1) Status Bits
M5180->X:$002040,0,1 ;// &1 Program-running bit
M5181->Y:$00203F,21,1 ;// &1 Circle-radius-error bit
M5182->Y:$00203F,22,1 ;// &1 Run-time-error bit
M5184->X:$002040,0,4 ;// &1 Continuous motion request
M5187->Y:$00203F,17,1 ;// &1 In-position bit (AND of motors)
M5188->Y:$00203F,18,1 ;// &1 Warning-following-error bit (OR)
M5189->Y:$00203F,19,1 ;// &1 Fatal-following-error bit (OR)
M5190->Y:$00203F,20,1 ;// &1 Amp-fault-error bit (OR of motors)

;// Coordinate System 1 (&1) Variables
M5197->X:$002000,0,24,S ;// &1 Host commanded time base (I10 units)
M5198->X:$002002,0,24,S ;// &1 Present time base (I10 units)

;// Coordinate System 2 (&2) timers
M5211->X:$002115,0,24,S ;// &2 Isx11 timer (for synchronous assignment)
M5212->Y:$002115,0,24,S ;// &2 Isx12 timer (for synchronous assignment)

;// Coordinate System 2 (&2) end-of-calculated-move positions
M5241->L:$002141 ;// &2 A-axis target position (engineering units)
M5242->L:$002142 ;// &2 B-axis target position (engineering units)
M5243->L:$002143 ;// &2 C-axis target position (engineering units)
M5244->L:$002144 ;// &2 U-axis target position (engineering units)
M5245->L:$002145 ;// &2 V-axis target position (engineering units)
M5246->L:$002146 ;// &2 W-axis target position (engineering units)
M5247->L:$002147 ;// &2 X-axis target position (engineering units)
M5248->L:$002148 ;// &2 Y-axis target position (engineering units)
M5249->L:$002149 ;// &2 Z-axis target position (engineering units)

;// Coordinate System 2 (&2) Status Bits
M5280->X:$002140,0,1 ;// &2 Program-running bit
M5281->Y:$00213F,21,1 ;// &2 Circle-radius-error bit
M5282->Y:$00213F,22,1 ;// &2 Run-time-error bit
M5284->X:$002140,0,4 ;// &2 Continuous motion request
M5287->Y:$00213F,17,1 ;// &2 In-position bit (AND of motors)
M5288->Y:$00213F,18,1 ;// &2 Warning-following-error bit (OR)
M5289->Y:$00213F,19,1 ;// &2 Fatal-following-error bit (OR)
M5290->Y:$00213F,20,1 ;// &2 Amp-fault-error bit (OR of motors)

;// Coordinate System 2 (&2) Variables
M5297->X:$002100,0,24,S ;// &2 Host commanded time base (I10 units)
M5298->X:$002102,0,24,S ;// &2 Present time base (I10 units)

;// Coordinate System 3 (&3) timers
M5311->X:$002215,0,24,S ;// &3 Isx11 timer (for synchronous assignment)
M5312->Y:$002215,0,24,S ;// &3 Isx12 timer (for synchronous assignment)

;// Coordinate System 3 (&3) end-of-calculated-move positions
M5341->L:$002241 ;// &3 A-axis target position (engineering units)
M5342->L:$002242 ;// &3 B-axis target position (engineering units)
M5343->L:$002243 ;// &3 C-axis target position (engineering units)
M5344->L:$002244 ;// &3 U-axis target position (engineering units)
M5345->L:$002245 ;// &3 V-axis target position (engineering units)
M5346->L:$002246 ;// &3 W-axis target position (engineering units)
M5347->L:$002247 ;// &3 X-axis target position (engineering units)
M5348->L:$002248 ;// &3 Y-axis target position (engineering units)
M5349->L:$002249 ;// &3 Z-axis target position (engineering units)

;// Coordinate System 3 (&3) Status Bits
M5380->X:$002240,0,1 ;// &3 Program-running bit
M5381->Y:$00223F,21,1 ;// &3 Circle-radius-error bit
M5382->Y:$00223F,22,1 ;// &3 Run-time-error bit
M5384->X:$002240,0,4 ;// &3 Continuous motion request
M5387->Y:$00223F,17,1 ;// &3 In-position bit (AND of motors)
M5388->Y:$00223F,18,1 ;// &3 Warning-following-error bit (OR)
M5389->Y:$00223F,19,1 ;// &3 Fatal-following-error bit (OR)
M5390->Y:$00223F,20,1 ;// &3 Amp-fault-error bit (OR of motors)

;// Coordinate System 3 (&3) Variables
M5397->X:$002200,0,24,S ;// &3 Host commanded time base (I10 units)
M5398->X:$002202,0,24,S ;// &3 Present time base (I10 units)

;// Coordinate System 4 (&4) timers
M5411->X:$002315,0,24,S ;// &4 Isx11 timer (for synchronous assignment)
M5412->Y:$002315,0,24,S ;// &4 Isx12 timer (for synchronous assignment)

;// Coordinate System 4 (&4) end-of-calculated-move positions
M5441->L:$002341 ;// &4 A-axis target position (engineering units)
M5442->L:$002342 ;// &4 B-axis target position (engineering units)
M5443->L:$002343 ;// &4 C-axis target position (engineering units)
M5444->L:$002344 ;// &4 U-axis target position (engineering units)
M5445->L:$002345 ;// &4 V-axis target position (engineering units)
M5446->L:$002346 ;// &4 W-axis target position (engineering units)
M5447->L:$002347 ;// &4 X-axis target position (engineering units)
M5448->L:$002348 ;// &4 Y-axis target position (engineering units)
M5449->L:$002349 ;// &4 Z-axis target position (engineering units)

;// Coordinate System 4 (&4) Status Bits
M5480->X:$002340,0,1 ;// &4 Program-running bit
M5481->Y:$00233F,21,1 ;// &4 Circle-radius-error bit
M5482->Y:$00233F,22,1 ;// &4 Run-time-error bit
M5484->X:$002340,0,4 ;// &4 Continuous motion request
M5487->Y:$00233F,17,1 ;// &4 In-position bit (AND of motors)
M5488->Y:$00233F,18,1 ;// &4 Warning-following-error bit (OR)
M5489->Y:$00233F,19,1 ;// &4 Fatal-following-error bit (OR)
M5490->Y:$00233F,20,1 ;// &4 Amp-fault-error bit (OR of motors)

;// Coordinate System 4 (&4) Variables
M5497->X:$002300,0,24,S ;// &4 Host commanded time base (I10 units)
M5498->X:$002302,0,24,S ;// &4 Present time base (I10 units)

;// Coordinate System 5 (&5) timers
M5511->X:$002415,0,24,S ;// &5 Isx11 timer (for synchronous assignment)
M5512->Y:$002415,0,24,S ;// &5 Isx12 timer (for synchronous assignment)

;// Coordinate System 5 (&5) end-of-calculated-move positions
M5541->L:$002441 ;// &5 A-axis target position (engineering units)
M5542->L:$002442 ;// &5 B-axis target position (engineering units)
M5543->L:$002443 ;// &5 C-axis target position (engineering units)
M5544->L:$002444 ;// &5 U-axis target position (engineering units)
M5545->L:$002445 ;// &5 V-axis target position (engineering units)
M5546->L:$002446 ;// &5 W-axis target position (engineering units)
M5547->L:$002447 ;// &5 X-axis target position (engineering units)
M5548->L:$002448 ;// &5 Y-axis target position (engineering units)
M5549->L:$002449 ;// &5 Z-axis target position (engineering units)

;// Coordinate System 5 (&5) Status Bits
M5580->X:$002440,0,1 ;// &5 Program-running bit
M5581->Y:$00243F,21,1 ;// &5 Circle-radius-error bit
M5582->Y:$00243F,22,1 ;// &5 Run-time-error bit
M5584->X:$002440,0,4 ;// &5 Continuous motion request
M5587->Y:$00243F,17,1 ;// &5 In-position bit (AND of motors)
M5588->Y:$00243F,18,1 ;// &5 Warning-following-error bit (OR)
M5589->Y:$00243F,19,1 ;// &5 Fatal-following-error bit (OR)
M5590->Y:$00243F,20,1 ;// &5 Amp-fault-error bit (OR of motors)

;// Coordinate System 5 (&5) Variables
M5597->X:$002400,0,24,S ;// &5 Host commanded time base (I10 units)
M5598->X:$002402,0,24,S ;// &5 Present time base (I10 units)

;// Coordinate System 6 (&6) timers
M5611->X:$002515,0,24,S ;// &6 Isx11 timer (for synchronous assignment)
M5612->Y:$002515,0,24,S ;// &6 Isx12 timer (for synchronous assignment)

;// Coordinate System 6 (&6) end-of-calculated-move positions
M5641->L:$002541 ;// &6 A-axis target position (engineering units)
M5642->L:$002542 ;// &6 B-axis target position (engineering units)
M5643->L:$002543 ;// &6 C-axis target position (engineering units)
M5644->L:$002544 ;// &6 U-axis target position (engineering units)
M5645->L:$002545 ;// &6 V-axis target position (engineering units)
M5646->L:$002546 ;// &6 W-axis target position (engineering units)
M5647->L:$002547 ;// &6 X-axis target position (engineering units)
M5648->L:$002548 ;// &6 Y-axis target position (engineering units)
M5649->L:$002549 ;// &6 Z-axis target position (engineering units)

;// Coordinate System 6 (&6) Status Bits
M5680->X:$002540,0,1 ;// &6 Program-running bit
M5681->Y:$00253F,21,1 ;// &6 Circle-radius-error bit
M5682->Y:$00253F,22,1 ;// &6 Run-time-error bit
M5684->X:$002540,0,4 ;// &6 Continuous motion request
M5687->Y:$00253F,17,1 ;// &6 In-position bit (AND of motors)
M5688->Y:$00253F,18,1 ;// &6 Warning-following-error bit (OR)
M5689->Y:$00253F,19,1 ;// &6 Fatal-following-error bit (OR)
M5690->Y:$00253F,20,1 ;// &6 Amp-fault-error bit (OR of motors)

;// Coordinate System 6 (&6) Variables
M5697->X:$002500,0,24,S ;// &6 Host commanded time base (I10 units)
M5698->X:$002502,0,24,S ;// &6 Present time base (I10 units)

;// Coordinate System 7 (&7) timers
M5711->X:$002615,0,24,S ;// &7 Isx11 timer (for synchronous assignment)
M5712->Y:$002615,0,24,S ;// &7 Isx12 timer (for synchronous assignment)

;// Coordinate System 7 (&7) end-of-calculated-move positions
M5741->L:$002641 ;// &7 A-axis target position (engineering units)
M5742->L:$002642 ;// &7 B-axis target position (engineering units)
M5743->L:$002643 ;// &7 C-axis target position (engineering units)
M5744->L:$002644 ;// &7 U-axis target position (engineering units)
M5745->L:$002645 ;// &7 V-axis target position (engineering units)
M5746->L:$002646 ;// &7 W-axis target position (engineering units)
M5747->L:$002647 ;// &7 X-axis target position (engineering units)
M5748->L:$002648 ;// &7 Y-axis target position (engineering units)
M5749->L:$002649 ;// &7 Z-axis target position (engineering units)

;// Coordinate System 7 (&7) Status Bits
M5780->X:$002640,0,1 ;// &7 Program-running bit
M5781->Y:$00263F,21,1 ;// &7 Circle-radius-error bit
M5782->Y:$00263F,22,1 ;// &7 Run-time-error bit
M5784->X:$002640,0,4 ;// &7 Continuous motion request
M5787->Y:$00263F,17,1 ;// &7 In-position bit (AND of motors)
M5788->Y:$00263F,18,1 ;// &7 Warning-following-error bit (OR)
M5789->Y:$00263F,19,1 ;// &7 Fatal-following-error bit (OR)
M5790->Y:$00263F,20,1 ;// &7 Amp-fault-error bit (OR of motors)

;// Coordinate System 7 (&7) Variables
M5797->X:$002600,0,24,S ;// &7 Host commanded time base (I10 units)
M5798->X:$002602,0,24,S ;// &7 Present time base (I10 units)

;// Coordinate System 8 (&8) timers
M5811->X:$002715,0,24,S ;// &8 Isx11 timer (for synchronous assignment)
M5812->Y:$002715,0,24,S ;// &8 Isx12 timer (for synchronous assignment)

;// Coordinate System 8 (&8) end-of-calculated-move positions
M5841->L:$002741 ;// &8 A-axis target position (engineering units)
M5842->L:$002742 ;// &8 B-axis target position (engineering units)
M5843->L:$002743 ;// &8 C-axis target position (engineering units)
M5844->L:$002744 ;// &8 U-axis target position (engineering units)
M5845->L:$002745 ;// &8 V-axis target position (engineering units)
M5846->L:$002746 ;// &8 W-axis target position (engineering units)
M5847->L:$002747 ;// &8 X-axis target position (engineering units)
M5848->L:$002748 ;// &8 Y-axis target position (engineering units)
M5849->L:$002749 ;// &8 Z-axis target position (engineering units)

;// Coordinate System 8 (&8) Status Bits
M5880->X:$002740,0,1 ;// &8 Program-running bit
M5881->Y:$00273F,21,1 ;// &8 Circle-radius-error bit
M5882->Y:$00273F,22,1 ;// &8 Run-time-error bit
M5884->X:$002740,0,4 ;// &8 Continuous motion request
M5887->Y:$00273F,17,1 ;// &8 In-position bit (AND of motors)
M5888->Y:$00273F,18,1 ;// &8 Warning-following-error bit (OR)
M5889->Y:$00273F,19,1 ;// &8 Fatal-following-error bit (OR)
M5890->Y:$00273F,20,1 ;// &8 Amp-fault-error bit (OR of motors)

;// Coordinate System 8 (&8) Variables
M5897->X:$002700,0,24,S ;// &8 Host commanded time base (I10 units)
M5898->X:$002702,0,24,S ;// &8 Present time base (I10 units)

;// Coordinate System 9 (&9) timers
M5911->X:$002815,0,24,S ;// &9 Isx11 timer (for synchronous assignment)
M5912->Y:$002815,0,24,S ;// &9 Isx12 timer (for synchronous assignment)

;// Coordinate System 9 (&9) end-of-calculated-move positions
M5941->L:$002841 ;// &9 A-axis target position (engineering units)
M5942->L:$002842 ;// &9 B-axis target position (engineering units)
M5943->L:$002843 ;// &9 C-axis target position (engineering units)
M5944->L:$002844 ;// &9 U-axis target position (engineering units)
M5945->L:$002845 ;// &9 V-axis target position (engineering units)
M5946->L:$002846 ;// &9 W-axis target position (engineering units)
M5947->L:$002847 ;// &9 X-axis target position (engineering units)
M5948->L:$002848 ;// &9 Y-axis target position (engineering units)
M5949->L:$002849 ;// &9 Z-axis target position (engineering units)

;// Coordinate System 1 (&1) Status Bits
M5980->X:$002840,0,1 ;// &9 Program-running bit
M5981->Y:$00283F,21,1 ;// &9 Circle-radius-error bit
M5982->Y:$00283F,22,1 ;// &9 Run-time-error bit
M5984->X:$002840,0,4 ;// &9 Continuous motion request
M5987->Y:$00283F,17,1 ;// &9 In-position bit (AND of motors)
M5988->Y:$00283F,18,1 ;// &9 Warning-following-error bit (OR)
M5989->Y:$00283F,19,1 ;// &9 Fatal-following-error bit (OR)
M5990->Y:$00283F,20,1 ;// &9 Amp-fault-error bit (OR of motors)

;// Coordinate System 1 (&1) Variables
M5997->X:$002800,0,24,S ;// &9 Host commanded time base (I10 units)
M5998->X:$002802,0,24,S ;// &9 Present time base (I10 units)

;// Coordinate System 10 (&10) timers
M6011->X:$002915,0,24,S ;// &10 Isx11 timer (for synchronous assignment)
M6012->Y:$002915,0,24,S ;// &10 Isx12 timer (for synchronous assignment)

;// Coordinate System 10 (&10) end-of-calculated-move positions
M6041->L:$002941 ;// &10 A-axis target position (engineering units)
M6042->L:$002942 ;// &10 B-axis target position (engineering units)
M6043->L:$002943 ;// &10 C-axis target position (engineering units)
M6044->L:$002944 ;// &10 U-axis target position (engineering units)
M6045->L:$002945 ;// &10 V-axis target position (engineering units)
M6046->L:$002946 ;// &10 W-axis target position (engineering units)
M6047->L:$002947 ;// &10 X-axis target position (engineering units)
M6048->L:$002948 ;// &10 Y-axis target position (engineering units)
M6049->L:$002949 ;// &10 Z-axis target position (engineering units)

;// Coordinate System 10 (&10) Status Bits
M6080->X:$002940,0,1 ;// &10 Program-running bit
M6081->Y:$00293F,21,1 ;// &10 Circle-radius-error bit
M6082->Y:$00293F,22,1 ;// &10 Run-time-error bit
M6084->X:$002940,0,4 ;// &10 Continuous motion request
M6087->Y:$00293F,17,1 ;// &10 In-position bit (AND of motors)
M6088->Y:$00293F,18,1 ;// &10 Warning-following-error bit (OR)
M6089->Y:$00293F,19,1 ;// &10 Fatal-following-error bit (OR)
M6090->Y:$00293F,20,1 ;// &10 Amp-fault-error bit (OR of motors)

;// Coordinate System 10 (&10) Variables
M6097->X:$002900,0,24,S ;// &10 Host commanded time base (I10 units)
M6098->X:$002902,0,24,S ;// &10 Present time base (I10 units)

;// Coordinate System 11 (&11) timers
M6111->X:$002A15,0,24,S ;// &11 Isx11 timer (for synchronous assignment)
M6112->Y:$002A15,0,24,S ;// &11 Isx12 timer (for synchronous assignment)

;// Coordinate System 11 (&11) end-of-calculated-move positions
M6141->L:$002A41 ;// &11 A-axis target position (engineering units)
M6142->L:$002A42 ;// &11 B-axis target position (engineering units)
M6143->L:$002A43 ;// &11 C-axis target position (engineering units)
M6144->L:$002A44 ;// &11 U-axis target position (engineering units)
M6145->L:$002A45 ;// &11 V-axis target position (engineering units)
M6146->L:$002A46 ;// &11 W-axis target position (engineering units)
M6147->L:$002A47 ;// &11 X-axis target position (engineering units)
M6148->L:$002A48 ;// &11 Y-axis target position (engineering units)
M6149->L:$002A49 ;// &11 Z-axis target position (engineering units)

;// Coordinate System 11 (&11) Status Bits
M6180->X:$002A40,0,1 ;// &11 Program-running bit
M6181->Y:$002A3F,21,1 ;// &11 Circle-radius-error bit
M6182->Y:$002A3F,22,1 ;// &11 Run-time-error bit
M6184->X:$002A40,0,4 ;// &11 Continuous motion request
M6187->Y:$002A3F,17,1 ;// &11 In-position bit (AND of motors)
M6188->Y:$002A3F,18,1 ;// &11 Warning-following-error bit (OR)
M6189->Y:$002A3F,19,1 ;// &11 Fatal-following-error bit (OR)
M6190->Y:$002A3F,20,1 ;// &11 Amp-fault-error bit (OR of motors)

;// Coordinate System 11 (&11) Variables
M6197->X:$002A00,0,24,S ;// &11 Host commanded time base (I10 units)
M6198->X:$002A02,0,24,S ;// &11 Present time base (I10 units)

;// Coordinate System 12 (&12) timers
M6211->X:$002B15,0,24,S ;// &12 Isx11 timer (for synchronous assignment)
M6212->Y:$002B15,0,24,S ;// &12 Isx12 timer (for synchronous assignment)

;// Coordinate System 12 (&12) end-of-calculated-move positions
M6241->L:$002B41 ;// &12 A-axis target position (engineering units)
M6242->L:$002B42 ;// &12 B-axis target position (engineering units)
M6243->L:$002B43 ;// &12 C-axis target position (engineering units)
M6244->L:$002B44 ;// &12 U-axis target position (engineering units)
M6245->L:$002B45 ;// &12 V-axis target position (engineering units)
M6246->L:$002B46 ;// &12 W-axis target position (engineering units)
M6247->L:$002B47 ;// &12 X-axis target position (engineering units)
M6248->L:$002B48 ;// &12 Y-axis target position (engineering units)
M6249->L:$002B49 ;// &12 Z-axis target position (engineering units)

;// Coordinate System 12 (&12) Status Bits
M6280->X:$002B40,0,1 ;// &12 Program-running bit
M6281->Y:$002B3F,21,1 ;// &12 Circle-radius-error bit

M6282->Y:$002B3F,22,1 ;// &12 Run-time-error bit
M6284->X:$002B40,0,4 ;// &12 Continuous motion request
M6287->Y:$002B3F,17,1 ;// &12 In-position bit (AND of motors)
M6288->Y:$002B3F,18,1 ;// &12 Warning-following-error bit (OR)
M6289->Y:$002B3F,19,1 ;// &12 Fatal-following-error bit (OR)
M6290->Y:$002B3F,20,1 ;// &12 Amp-fault-error bit (OR of motors)

;// Coordinate System 12 (&12) Variables
M6297->X:$002B00,0,24,S ;// &12 Host commanded time base (I10 units)
M6298->X:$002B02,0,24,S ;// &12 Present time base (I10 units)

;// Coordinate System 13 (&13) timers
M6311->X:$002C15,0,24,S ;// &13 Isx11 timer (for synchronous assignment)
M6312->Y:$002C15,0,24,S;// &13 Isx12 timer (for synchronous assignment)

;// Coordinate System 13 (&13) end-of-calculated-move positions
M6341->L:$002C41 ;// &13 A-axis target position (engineering units)
M6342->L:$002C42 ;// &13 B-axis target position (engineering units)
M6343->L:$002C43 ;// &13 C-axis target position (engineering units)
M6344->L:$002C44 ;// &13 U-axis target position (engineering units)
M6345->L:$002C45 ;// &13 V-axis target position (engineering units)
M6346->L:$002C46 ;// &13 W-axis target position (engineering units)
M6347->L:$002C47 ;// &13 X-axis target position (engineering units)
M6348->L:$002C48 ;// &13 Y-axis target position (engineering units)
M6349->L:$002C49 ;// &13 Z-axis target position (engineering units)

;// Coordinate System 13 (&13) Status Bits
M6380->X:$002C40,0,1 ;// &13 Program-running bit
M6381->Y:$002C3F,21,1 ;// &13 Circle-radius-error bit
M6382->Y:$002C3F,22,1 ;// &13 Run-time-error bit
M6384->X:$002C40,0,4 ;// &13 Continuous motion request
M6387->Y:$002C3F,17,1 ;// &13 In-position bit (AND of motors)
M6388->Y:$002C3F,18,1 ;// &13 Warning-following-error bit (OR)
M6389->Y:$002C3F,19,1 ;// &13 Fatal-following-error bit (OR)
M6390->Y:$002C3F,20,1 ;// &13 Amp-fault-error bit (OR of motors)

;// Coordinate System 13 (&13) Variables
M6397->X:$002C00,0,24,S ;// &13 Host commanded time base (I10 units)
M6398->X:$002C02,0,24,S ;// &13 Present time base (I10 units)

;// Coordinate System 14 (&14) timers
M6411->X:$002D15,0,24,S ;// &14 Isx11 timer (for synchronous assignment)
M6412->Y:$002D15,0,24,S ;// &14 Isx12 timer (for synchronous assignment)

;// Coordinate System 14 (&14) end-of-calculated-move positions
M6441->L:$002D41 ;// &14 A-axis target position (engineering units)
M6442->L:$002D42 ;// &14 B-axis target position (engineering units)
M6443->L:$002D43 ;// &14 C-axis target position (engineering units)
M6444->L:$002D44 ;// &14 U-axis target position (engineering units)
M6445->L:$002D45 ;// &14 V-axis target position (engineering units)
M6446->L:$002D46 ;// &14 W-axis target position (engineering units)
M6447->L:$002D47 ;// &14 X-axis target position (engineering units)
M6448->L:$002D48 ;// &14 Y-axis target position (engineering units)
M6449->L:$002D49 ;// &14 Z-axis target position (engineering units)

;// Coordinate System 14 (&14) Status Bits
M6480->X:$002D40,0,1 ;// &14 Program-running bit
M6481->Y:$002D3F,21,1 ;// &14 Circle-radius-error bit
M6482->Y:$002D3F,22,1 ;// &14 Run-time-error bit
M6484->X:$002D40,0,4 ;// &14 Continuous motion request
M6487->Y:$002D3F,17,1 ;// &14 In-position bit (AND of motors)
M6488->Y:$002D3F,18,1 ;// &14 Warning-following-error bit (OR)
M6489->Y:$002D3F,19,1 ;// &14 Fatal-following-error bit (OR)
M6490->Y:$002D3F,20,1 ;// &14 Amp-fault-error bit (OR of motors)

;// Coordinate System 14 (&14) Variables
M6497->X:$002D00,0,24,S ;// &14 Host commanded time base (I10 units)
M6498->X:$002D02,0,24,S ;// &14 Present time base (I10 units)

;// Coordinate System 15 (&15) timers
M6511->X:$002E15,0,24,S ;// &15 Isx11 timer (for synchronous assignment)
M6512->Y:$002E15,0,24,S ;// &15 Isx12 timer (for synchronous assignment)

;// Coordinate System 15 (&15) end-of-calculated-move positions
M6541->L:$002E41 ;// &15 A-axis target position (engineering units)
M6542->L:$002E42 ;// &15 B-axis target position (engineering units)
M6543->L:$002E43 ;// &15 C-axis target position (engineering units)
M6544->L:$002E44 ;// &15 U-axis target position (engineering units)
M6545->L:$002E45 ;// &15 V-axis target position (engineering units)
M6546->L:$002E46 ;// &15 W-axis target position (engineering units)
M6547->L:$002E47 ;// &15 X-axis target position (engineering units)
M6548->L:$002E48 ;// &15 Y-axis target position (engineering units)
M6549->L:$002E49 ;// &15 Z-axis target position (engineering units)

;// Coordinate System 15 (&15) Status Bits
M6580->X:$002E40,0,1 ;// &15 Program-running bit
M6581->Y:$002E3F,21,1 ;// &15 Circle-radius-error bit
M6582->Y:$002E3F,22,1 ;// &15 Run-time-error bit
M6584->X:$002E40,0,4 ;// &15 Continuous motion request
M6587->Y:$002E3F,17,1 ;// &15 In-position bit (AND of motors)
M6588->Y:$002E3F,18,1 ;// &15 Warning-following-error bit (OR)
M6589->Y:$002E3F,19,1 ;// &15 Fatal-following-error bit (OR)
M6590->Y:$002E3F,20,1 ;// &15 Amp-fault-error bit (OR of motors)

;// Coordinate System 15 (&15) Variables
M6597->X:$002E00,0,24,S ;// &15 Host commanded time base (I10 units)
M6598->X:$002E02,0,24,S ;// &15 Present time base (I10 units)

;// Coordinate System 16 (&16) timers
M6611->X:$002F15,0,24,S ;// &16 Isx11 timer (for synchronous assignment)
M6612->Y:$002F15,0,24,S ;// &16 Isx12 timer (for synchronous assignment)

;// Coordinate System 16 (&16) end-of-calculated-move positions
M6641->L:$002F41 ;// &16 A-axis target position (engineering units)
M6642->L:$002F42 ;// &16 B-axis target position (engineering units)
M6643->L:$002F43 ;// &16 C-axis target position (engineering units)
M6644->L:$002F44 ;// &16 U-axis target position (engineering units)
M6645->L:$002F45 ;// &16 V-axis target position (engineering units)
M6646->L:$002F46 ;// &16 W-axis target position (engineering units)
M6647->L:$002F47 ;// &16 X-axis target position (engineering units)
M6648->L:$002F48 ;// &16 Y-axis target position (engineering units)
M6649->L:$002F49 ;// &16 Z-axis target position (engineering units)

;// Coordinate System 16 (&16) Status Bits
M6680->X:$002F40,0,1 ;// &16 Program-running bit
M6681->Y:$002F3F,21,1 ;// &16 Circle-radius-error bit
M6682->Y:$002F3F,22,1 ;// &16 Run-time-error bit
M6684->X:$002F40,0,4 ;// &16 Continuous motion request
M6687->Y:$002F3F,17,1 ;// &16 In-position bit (AND of motors)
M6688->Y:$002F3F,18,1 ;// &16 Warning-following-error bit (OR)
M6689->Y:$002F3F,19,1 ;// &16 Fatal-following-error bit (OR)
M6690->Y:$002F3F,20,1 ;// &16 Amp-fault-error bit (OR of motors)

;// Coordinate System 16 (&16) Variables
M6697->X:$002F00,0,24,S ;// &16 Host commanded time base (I10 units)
M6698->X:$002F02,0,24,S ;// &16 Present time base (I10 units)

;// IO Bank and Control Register Mapping for Acc65E at Base Address $7AC00
M6900->Y:$07AC00, 0, 8;//I/O bits 0-7 (port A IC0) 
M6901->Y:$07AC01, 0, 8;//I/O bits 8-15 (port A IC0)
M6902->Y:$07AC02, 0, 8;//I/O bits 16-23 (port A IC0)
M6903->Y:$07AC03, 0, 8;//I/O bits 0-7 (port B IC0)
M6904->Y:$07AC04, 0, 8;//I/O bits 8-15 (port B IC0)
M6905->Y:$07AC05, 0, 8;//I/O bits 16-23 (port B IC0)
M6906->Y:$07AC06, 0, 8;//register selected
M6907->Y:$07AC07, 0, 8;//control register for Acc65E at base address $7AC00

;// Bit Level Mapping For Acc65E
M7000->Y:$07AC00, 0, 1;//Input 1 
M7001->Y:$07AC00, 1, 1;//Input 2 
M7002->Y:$07AC00, 2, 1;//Input 3 
M7003->Y:$07AC00, 3, 1;//Input 4 
M7004->Y:$07AC00, 4, 1;//Input 5 
M7005->Y:$07AC00, 5, 1;//Input 6 
M7006->Y:$07AC00, 6, 1;//Input 7 
M7007->Y:$07AC00, 7, 1;//Input 8 
M7008->Y:$07AC01, 0, 1;//Input 9
M7009->Y:$07AC01, 1, 1;//Input 10
M7010->Y:$07AC01, 2, 1;//Input 11 
M7011->Y:$07AC01, 3, 1;//Input 12 
M7012->Y:$07AC01, 4, 1;//Input 13 
M7013->Y:$07AC01, 5, 1;//Input 14 
M7014->Y:$07AC01, 6, 1;//Input 15 
M7015->Y:$07AC01, 7, 1;//Input 16 
M7016->Y:$07AC02, 0, 1;//Input 17 
M7017->Y:$07AC02, 1, 1;//Input 18 
M7018->Y:$07AC02, 2, 1;//Input 19 
M7019->Y:$07AC02, 3, 1;//Input 20 
M7020->Y:$07AC02, 4, 1;//Input 21 
M7021->Y:$07AC02, 5, 1;//Input 22 
M7022->Y:$07AC02, 6, 1;//Input 23 
M7023->Y:$07AC02, 7, 1;//Input 24

M7024->Y:$07AC03, 0, 1;//Output 1
M7025->Y:$07AC03, 1, 1;//Output 2
M7026->Y:$07AC03, 2, 1;//Output 3
M7027->Y:$07AC03, 3, 1;//Output 4
M7028->Y:$07AC03, 4, 1;//Output 5
M7029->Y:$07AC03, 5, 1;//Output 6
M7030->Y:$07AC03, 6, 1;//Output 7
M7031->Y:$07AC03, 7, 1;//Output 8
M7032->Y:$07AC04, 0, 1;//Output 9
M7033->Y:$07AC04, 1, 1;//Output 10
M7034->Y:$07AC04, 2, 1;//Output 11
M7035->Y:$07AC04, 3, 1;//Output 12
M7036->Y:$07AC04, 4, 1;//Output 13
M7037->Y:$07AC04, 5, 1;//Output 14
M7038->Y:$07AC04, 6, 1;//Output 15
M7039->Y:$07AC04, 7, 1;//Output 16
M7040->Y:$07AC05, 0, 1;//Output 17
M7041->Y:$07AC05, 1, 1;//Output 18
M7042->Y:$07AC05, 2, 1;//Output 19
M7043->Y:$07AC05, 3, 1;//Output 20
M7044->Y:$07AC05, 4, 1;//Output 21
M7045->Y:$07AC05, 5, 1;//Output 22
M7046->Y:$07AC05, 6, 1;//Output 23
M7047->Y:$07AC05, 7, 1;//Output 24

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


I5060 = 8;//A/D processing Ring Size set to Demux 8ADC pairs we only get the low bytes 

I5061, 8 = $1400;// ADC pairs 1 through 8 offset width: $1400 = $079C00-$78800
I5081 = 0;// ADC#1 Unipolar
I5082 = 1;// ADC#2 Unipolar
I5083 = 2;// ADC#3 Unipolar
I5084 = 3;// ADC#4 Unipolar
I5085 = 4;// ADC#5 Unipolar
I5086 = 5;// ADC#6 Unipolar
I5087 = 6;// ADC#7 Unipolar
I5088 = 7;// ADC#8 Unipolar

;///////////////////////////////////////////////////////////////////
;//Map the Suggested M-Variable Definitions for the ADC channels
;//////////////////////////////////////////////////////////////////
M5061->Y:$003400, 12, 12, U;// ADC#1 Unipolar
M5062->Y:$003402, 12, 12, U;// ADC#2 Unipolar
M5063->Y:$003404, 12, 12, U;// ADC#3 Unipolar
M5064->Y:$003406, 12, 12, U;// ADC#4 Unipolar
M5065->Y:$003408, 12, 12, U;// ADC#5 Unipolar
M5066->Y:$00340A, 12, 12, U;// ADC#6 Unipolar
M5067->Y:$00340C, 12, 12, U;// ADC#7 Unipolar
M5068->Y:$00340E, 12, 12, U;// ADC#8 Unipolar


;///////////////////////////////////////////////////////////////////
;//Map the Suggested M-Variable Definitions for the DAC channels
;//////////////////////////////////////////////////////////////////
M6001->Y:$79C08, 0, 12;// DAC Channel #1
M6002->Y:$79C09, 0, 12;// DAC Channel #2
M6003->Y:$79C0A, 0, 12;// DAC Channel #3
M6004->Y:$79C0B, 0, 12;// DAC Channel #4
M6005->Y:$79C08, 12, 12;// DAC Channel #5
M6006->Y:$79C09, 12, 12;// DAC Channel #6
M6007->Y:$79C0A, 12, 12;// DAC Channel #7
M6008->Y:$79C0B, 12, 12;// DAC Channel #8



#define dac2LftThreadBrakeTension_cnts  M6001;
#define dac3RhtThreadBrakeTension_cnts	M6002;
#define dac1SleveTension_cnts			M6003;
