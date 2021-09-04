
;////////////////////////////////////////////////////////////////////////////////////////////
;//
;// MVars.h
;// Created on: 01/09/2012  Author: Josh Kelley
;// 
;// M Variable Mapping Using Suggested M Variable Deffinitions Followed by Macro Definitions
;//
;////////////////////////////////////////////////////////////////////////////////////////////


;// Servo IC 0 Registers for PMAC2 Channel 1 (usually for Motor #1)
;///////////////////////////////////////////////////////////////////////////////////////////////
M101->X:$078201,0,24,S ;// ENC1 24-bit counter position
M102->Y:$078202,8,16,S ;// OUT1A command value;// DAC or PWM
M103->X:$078203,0,24,S ;// ENC1 captured position
M104->Y:$078203,8,16,S ;// OUT1B command value;// DAC or PWM
M105->X:$078205,8,16,S ;// ADC1A input value
M106->Y:$078206,8,16,S ;// ADC1B input value
M107->Y:$078204,8,16,S ;// OUT1C command value;// PFM or PWM
M108->Y:$078207,0,24,S ;// ENC1 compare A position
M109->X:$078207,0,24,S ;// ENC1 compare B position
M110->X:$078206,0,24,S ;// ENC1 compare autoincrement value
M111->X:$078205,11 ;// ENC1 compare initial state write enable
M112->X:$078205,12 ;// ENC1 compare initial state
M114->X:$078205,14 ;// AENA1 output status
M115->X:$078205,19 ;// USER1 flag input status
M116->X:$078200,9 ;// ENC1 compare output value
M117->X:$078200,11 ;// ENC1 capture flag
M118->X:$078200,8 ;// ENC1 count error flag
M119->X:$078200,14 ;// CHC1 input status
M120->X:$078200,16 ;// HMFL1 flag input status
M121->X:$078200,17 ;// PLIM21 flag input status
M122->X:$078200,18 ;// MLIM21 flag input status
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
M140->Y:$0000C0,0,1 ;// #1 In-position bit
M141->Y:$0000C0,1,1 ;// #1 Warning-following error bit
M142->Y:$0000C0,2,1 ;// #1 Fatal-following-error bit
M143->Y:$0000C0,3,1 ;// #1 Amplifier-fault-error bit
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
M173->Y:$0000D8,0,24,S ;// #1 Encoder home capture position (cts)
M174->D:$0000EF ;// #1 Averaged actual velocity (1/[Ixx09*32] cts/cyc)
M175->X:$0000B9,8,16,S ;// #1 Actual quadrature current
M176->Y:$0000B9,8,16,S ;// #1 Actual direct current
M177->X:$0000BC,8,16,S ;// #1 Quadrature current-loop integrator output
M178->Y:$0000BC,8,16,S ;// #1 Direct current-loop integrator output
M179->X:$00009A,24,S		;//#1 Previous Desired Velocity

;// Motor #1 Axis Definition Registers
M191->L:$0000CF ;// #1 X/U/A/B/C-Axis scale factor (cts/unit)
M192->L:$0000D0 ;// #1 Y/V-Axis scale factor (cts/unit)
M193->L:$0000D1 ;// #1 Z/W-Axis scale factor (cts/unit)
M194->L:$0000D2 ;// #1 Axis offset (cts)

;// Servo IC 0 Registers for PMAC2 Channel 2 (usually for Motor #2)
M201->X:$078209,0,24,S ;// ENC2 24-bit counter position
M202->Y:$07820A,8,16,S ;// OUT2A command value;// DAC or PWM
M203->X:$07820B,0,24,S ;// ENC2 captured position
M204->Y:$07820B,8,16,S ;// OUT2B command value;// DAC or PWM
M205->X:$07820D,8,16,S ;// ADC2A input value
M206->Y:$07820E,8,16,S ;// ADC2B input value
M207->Y:$07820C,8,16,S ;// OUT2C command value;// PFM or PWM
M208->Y:$07820F,0,24,S ;// ENC2 compare A position
M209->X:$07820F,0,24,S ;// ENC2 compare B position
M210->X:$07820E,0,24,S ;// ENC2 compare autoincrement value
M211->X:$07820D,11 ;// ENC2 compare initial state write enable
M212->X:$07820D,12 ;// ENC2 compare initial state
M214->X:$07820D,14 ;// AENA2 output status
M215->X:$07820D,19 ;// USER2 flag input status
M216->X:$078208,9 ;// ENC2 compare output value
M217->X:$078208,11 ;// ENC2 capture flag
M218->X:$078208,8 ;// ENC2 count error flag
M219->X:$078208,14 ;// CHC2 input status
M220->X:$078208,16 ;// HMFL2 flag input status
M221->X:$078208,17 ;// PLIM22 flag input status
M222->X:$078208,18 ;// MLIM22 flag input status
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
M240->Y:$000140,0,1 ;// #2 In-position bit
M241->Y:$000140,1,1 ;// #2 Warning-following error bit
M242->Y:$000140,2,1 ;// #2 Fatal-following-error bit
M243->Y:$000140,3,1 ;// #2 Amplifier-fault-error bit
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
M273->Y:$000158,0,24,S ;// #2 Encoder home capture position (cts)
M274->D:$00016F ;// #2 Averaged actual velocity (1/[Ixx09*32] cts/cyc)
M275->X:$000139,8,16,S ;// #2 Actual quadrature current
M276->Y:$000139,8,16,S ;// #2 Actual direct current
M277->X:$00013C,8,16,S ;// #2 Quadrature current-loop integrator output
M278->Y:$00013C,8,16,S ;// #2 Direct current-loop integrator output
M279->X:$00010A,24,S		;//#2 Previous Desired Velocity

;// Motor #2 Axis Definition Registers
M291->L:$00014F ;// #2 X/U/A/B/C-Axis scale factor (cts/unit)
M292->L:$000150 ;// #2 Y/V-Axis scale factor (cts/unit)
M293->L:$000151 ;// #2 Z/W-Axis scale factor (cts/unit)
M294->L:$000152 ;// #2 Axis offset (cts)

;// Servo IC 0 Registers for PMAC2 Channel 3 (usually for Motor #3)
M301->X:$078211,0,24,S ;// ENC3 24-bit counter position
M302->Y:$078212,8,16,S ;// OUT3A command value;// DAC or PWM
M303->X:$078213,0,24,S ;// ENC3 captured position
M304->Y:$078213,8,16,S ;// OUT3B command value;// DAC or PWM
M305->X:$078215,8,16,S ;// ADC3A input value
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
M321->X:$078210,17 ;// PLIM23 flag input status
M322->X:$078210,18 ;// MLIM23 flag input status
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
M340->Y:$0001C0,0,1 ;// #3 In-position bit
M341->Y:$0001C0,1,1 ;// #3 Warning-following error bit
M342->Y:$0001C0,2,1 ;// #3 Fatal-following-error bit
M343->Y:$0001C0,3,1 ;// #3 Amplifier-fault-error bit
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
M373->Y:$0001D8,0,24,S ;// #3 Encoder home capture position (cts)
M374->D:$0001EF ;// #3 Averaged actual velocity (1/[Ixx09*32] cts/cyc)
M375->X:$0001B9,8,16,S ;// #3 Actual quadrature current
M376->Y:$0001B9,8,16,S ;// #3 Actual direct current
M377->X:$0001BC,8,16,S ;// #3 Quadrature current-loop integrator output
M378->Y:$0001BC,8,16,S ;// #3 Direct current-loop integrator output
M379->X:$00019A,24,S		;//#3 Previous Desired Velocity

;// Motor #3 Axis Definition Registers
M391->L:$0001CF ;// #3 X/U/A/B/C-Axis scale factor (cts/unit)
M392->L:$0001D0 ;// #3 Y/V-Axis scale factor (cts/unit)
M393->L:$0001D1 ;// #3 Z/W-Axis scale factor (cts/unit)
M394->L:$0001D2 ;// #3 Axis offset (cts)

;// Servo IC 0 Registers for PMAC2 Channel 4 (usually for Motor #4)
M401->X:$078219,0,24,S ;// ENC4 24-bit counter position
M402->Y:$07821A,8,16,S ;// OUT4A command value;// DAC or PWM
M403->X:$07821B,0,24,S ;// ENC4 captured position
M404->Y:$07821B,8,16,S ;// OUT4B command value;// DAC or PWM
M405->X:$07821D,8,16,S ;// ADC4A input value
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
M418->X:$078218,8 ;//  ENC4 count error flag
M419->X:$078218,14 ;// CH4 flag input status
M420->X:$078218,16 ;// HMFL4 input status
M421->X:$078218,17 ;// PLIM24 flag input status
M422->X:$078218,18 ;// MLIM24 flag input status
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
M440->Y:$000240,0,1 ;// #4 In-position bit
M441->Y:$000240,1,1 ;// #4 Warning-following error bit
M442->Y:$000240,2,1 ;// #4 Fatal-following-error bit
M443->Y:$000240,3,1 ;// #4 Amplifier-fault-error bit
M445->Y:$000240,10,1 ;// #4 Home-complete bit
M446->Y:$000240,6,1 ;// #4 Integrated following error fault bit
M447->Y:$000240,5,1 ;// #4 I2T fault bit
M448->Y:$000140,8,1 ;// #4 Phasing error fault bit
M449->Y:$000140,9,1 ;// #4 Phasing search-in-progress bit

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
M473->Y:$000258,0,24,S ;// #4 Encoder home capture position (cts)
M474->D:$00026F ;// #4 Averaged actual velocity (1/[Ixx09*32] cts/cyc)
M475->X:$000239,8,16,S ;// #4 Actual quadrature current
M476->Y:$000239,8,16,S ;// #4 Actual direct current
M477->X:$00023C,8,16,S ;// #4 Quadrature current-loop integrator output
M478->Y:$00023C,8,16,S ;// #4 Direct current-loop integrator output
M479->X:$00021A,24,S		;//#4 Previous Desired Velocity

;// Motor #4 Axis Definition Registers
M491->L:$00024F ;// #4 X/U/A/B/C-Axis scale factor (cts/unit)
M492->L:$000250 ;// #4 Y/V-Axis scale factor (cts/unit)
M493->L:$000251 ;// #4 Z/W-Axis scale factor (cts/unit)
M494->L:$000252 ;// #4 Axis offset (cts)


;//////////////////////////////////////////////////////////
;/////   Coordinate System Def
;/////////////////////////////////////////////////////////

;//Coordinate System 1 (&1) Timers
M5111->X:$002015,0,24,S ;// &1 Isx11 timer (for synchronous assignment)
M5112->Y:$002015,0,24,S ;// &1 Isx12 timer (for synchronous assignment)

;//Coordinate System 1 (&1) End-of-Calculated Move Positions
M5141->L:$002041 ;// &1 A-axis target position (engineering units)
M5142->L:$002042 ;// &1 B-axis target position (engineering units)
M5143->L:$002043 ;// &1 C-axis target position (engineering units)
M5144->L:$002044 ;// &1 U-axis target position (engineering units)
M5145->L:$002045 ;// &1 V-axis target position (engineering units)
M5146->L:$002046 ;// &1 W-axis target position (engineering units)
M5147->L:$002047 ;// &1 X-axis target position (engineering units)
M5148->L:$002048 ;// &1 Y-axis target position (engineering units)
M5149->L:$002049 ;// &1 Z-axis target position (engineering units)

;//Coordinate System 1 (&1) Status Bits
M5180->X:$002040,0,1 ;// &1 Program-running bit
M5181->Y:$00203F,21,1 ;// &1 Circle-radius-error bit
M5182->Y:$00203F,22,1 ;// &1 Run-time-error bit
M5184->X:$002040,4,1 ;// &1 Continuous motion request
M5187->Y:$00203F,17,1 ;// &1 In-position bit (AND of motors)
M5188->Y:$00203F,18,1 ;// &1 Warning-following-error bit (OR)
M5189->Y:$00203F,19,1 ;// &1 Fatal-following-error bit (OR)
M5190->Y:$00203F,20,1 ;// &1 Amp-fault-error bit (OR of motors)

;//Coordinate System 1 (&1) Variables
M5197->X:$002000,0,24,S ; &1 Host commanded time base (I10 units)
M5198->X:$002002,0,24,S ; &1 Present time base (I10 units)



//#define	mInt1Set				M1		;//Interrupt1 Set bit		
//#define	mInt1Config				M2		;//Interrupt1 Config 
//#define	mInt2Set				M3		;//Interrupt2 Set bit		
//#define	mInt2Config				M4		;//Interrupt2 Config 
//#define	mInt3Set				M5		;//Interrupt3 Set bit		
//#define	mInt3Config				M6		;//Interrupt3 Config 
//#define	mInt4Set				M7		;//Interrupt4 Set bit		
//#define	mInt4Config				M8		;//Interrupt4 Config 
//#define	mInt5Set				M9		;//Interrupt4 Set bit		
//#define	mInt5Config				M10		;//Interrupt4 Config 
//
//;//array control variables
//#define mArrayPtr1				M11		;//point to P0
//#define mArrayDefPtr1			M12		;//point the definition word of mArrayPtr1
//
//;//M240 thru M249 spare array control variables (application specific)
//#define	mArrayPtr2				M13
//#define	mArrayDefPtr2           M14
//#define	mArrayPtr3				M15
//#define	mArrayDefPtr3			M16
//#define	mArrayPtr4				M17
//#define	mArrayDefPtr4			M18
//
//;//M240 thru M249 spare Handwheel pulse control variable(application specific)
//#define mPulse1Freq				M20		;//Pulse 1 Frequency
//#define mPulseWidth				M21		;//Pulse  Width
//#define mPulse2Freq				M22		;//Pulse 2 Frequency
//#define mPulse1PFM				M23		;//Pulse 1 PFM bit
//#define mPulse1Direction		M24		;//Pulse 1 Direction bit
//#define mPulse2PFM				M25		;//Pulse 1 PFM bit
//#define mPulse2Direction		M26		;//Pulse 2 Direction bit
//#define mPulse1Invert			M27		;//Pulse 1 Invert bit
//#define mPulse2Invert			M28		;//Pulse 2 Invert bit		
//
//;//M2040 thru M2099 reserved for pre-defined Mvars

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
#define mAxis2Running			M237		;// #2 Running-program bit
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

#define mAxis2ActualVel			M266		;// #2 Actual velocity (1/[Ix09*32] cts/cyc)
#define mAxis2MasterPos			M267		;// #2 Present master pos (1/[Ix08*32] cts)
#define mAxis2Filter			M268		;// #2 Filter Output (DAC bits)
#define mAxis2Compensation		M269		;// #2 Compensation correction
#define mAxis2PhasePos			M271		;// #2 Present phase position
#define mAxis2JogPosition		M272		;// #2 Variable Jog Position
#define mAxis2HomeCapturePos	M273		;// #2 Home Capture Position
#define mAxis2AvgVel			M274		;// #2 Avg Velocity (1/[Ixx09*32] cts/cyc)
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
