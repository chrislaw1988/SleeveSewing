
;////////////////////////////////////////////////////////////////////////////////////////////
;//
;// ErrorCodes.h
;// Created on: 01/09/2012  Author: Josh Kelley
;// 
;// Provides Error Codes Reported By PMAC
;//
;////////////////////////////////////////////////////////////////////////////////////////////


;//Error Codes, These come back from the PMAC
#define ESTOP_ERROR  1;
#define INIT_FAILED_ERROR  2;
#define HOME_FAILED_ERROR  3;


;// MOTOR 1 --> Left Needle
#define AXIS1_AMP_FAULT		100;
#define AXIS1_FF_FAULT		101;
#define AXIS1_NEG_LIMIT		102;
#define AXIS1_POS_LIMIT		103;
#define AXIS1_I2T_FAULT		104;
#define AXIS1_PHASING_FAULT 105;
#define AXIS1_HOME_FAILED	106;

;// MOTOR 2 --> Right Needle
#define AXIS2_AMP_FAULT		200;
#define AXIS2_FF_FAULT		201;
#define AXIS2_NEG_LIMIT		202;
#define AXIS2_POS_LIMIT		203;
#define AXIS2_I2T_FAULT		204;
#define AXIS2_PHASING_FAULT 205;
#define AXIS2_HOME_FAILED	206;


;// MOTOR 3 --> Loopers
#define AXIS3_AMP_FAULT		300;
#define AXIS3_FF_FAULT		301;
#define AXIS3_NEG_LIMIT		302;
#define AXIS3_POS_LIMIT		303;
#define AXIS3_I2T_FAULT		304;
#define AXIS3_PHASING_FAULT	305;
#define AXIS3_HOME_FAILED	306;

;// MOTOR 4 --> Linear Traverse
#define AXIS4_AMP_FAULT		400;
#define AXIS4_FF_FAULT		401;
#define AXIS4_NEG_LIMIT		402;
#define AXIS4_POS_LIMIT		403;
#define AXIS4_I2T_FAULT		404;
#define AXIS4_PHASING_FAULT	405;
#define AXIS4_HOME_FAILED	406;

