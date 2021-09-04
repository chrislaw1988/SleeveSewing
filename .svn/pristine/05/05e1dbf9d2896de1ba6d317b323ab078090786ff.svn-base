
;////////////////////////////////////////////////////////////////////////////////////////////
;//
;// Const.h
;// Created on: 01/08/2012  Author: Josh Kelley
;// 
;// Constant Definitions
;//
;////////////////////////////////////////////////////////////////////////////////////////////


#define SERVO_CYCLES_PER_MSEC (8388608/(I10))

;//Countdown PLC Timer Macro 1 liner --> mCoor1Timer1 = XXX CRD1_TMR_COUNTDOWN where XXX is Time in ms
#define CRD1_TMR_COUNTDOWN *8388608/I10While(M5111>0)EndW

#define 60_SEC							60.0
#define 360_DEG							360
#define NEEDLE_OFFSET_MM				29.00	;//Offset in MM between Left And Right Needle

#define NEEDLE_LOOPER_CNTS_PER_DEG		11.11111;//User units Scalling (4000cnts / 360 deg)
#define PITCH_CNTS_PER_MM				55.33333;//User Units Scalling 



#define MAX_ERROR_WORDS	5



;//generic boolean bits
#define	ON               		1
#define	OFF						0
#define TRUE					1
#define FALSE					0
#define PASS              		1
#define FAIL              		0
#define EXTEND					1
#define RETRACT					0



;////////////////////////////////////////////////////////////////////////////////////////////
;//								PLC Definitions
;////////////////////////////////////////////////////////////////////////////////////////////

#define PLC_1_STARTUP	PLC1
#define PLC_2_ESTOP		PLC2
#define PLC_3_INIT		PLC3
#define PLC_4_MSGHANDLER	PLC4
#define PLC_5_AXIS_MONITOR	PLC5
#define PLC_6_SET_ERROR		PLC6
#define PLC_7_CLEAR_ERRORS	PLC7
#define PLC_8_INIT_IO		PLC8

;////////////////////////////////////////////////////////////////////////////////////////////
;//								PMC Definitions
;////////////////////////////////////////////////////////////////////////////////////////////

#define PROG_1_HOME				PROG 1
#define PROG_10_SEW_LEFT		PROG 10
#define	PROG_11_SEW_RIGHT		PROG 11
#define PROG_12_MOVE_TO_START	PROG 12
#define PROG_13_LOOP_OUT_360	PROG 13
#define PROG_14_SEW_RIGHT_REV_LOOPER	PROG 14




;////////////////////////////////////////////////////////////////////////////////////////////
;//						Bit Definitions for mMachineControl0 (M7500)
;////////////////////////////////////////////////////////////////////////////////////////////

#define	DO_HOME				$1
#define	DO_SEW_LEFT_HEAD	$2
#define	DO_SEW_RIGHT_HEAD	$4
#define	DO_MOVE_TO_START	$8
#define	DO_ERROR_RESET		$10
#define	D0_ABORT			$20
#define	DO_INIT				$40
#define DO_LOOP_OUT			$80


;////////////////////////////////////////////////////////////////////////////////////////////
;//						Bit Definitions for mMachineStatus0 (M7505)
;////////////////////////////////////////////////////////////////////////////////////////////

#define	HOME_DONE				$1
#define	SEW_LEFT_HEAD_DONE		$2
#define	SEW_RIGHT_HEAD_DONE		$4
#define	MOVE_TO_START_DONE		$8
#define	ERROR_RESET_DONE		$10
#define	ABORT_DONE				$20
#define	INIT_DONE				$40
#define LOOP_OUT_DONE			$80