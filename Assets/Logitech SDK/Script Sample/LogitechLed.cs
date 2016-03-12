// Logitech Gaming SDK
//
// Copyright (C) 2011-2014 Logitech. All rights reserved.
// Author: Tiziano Pigliucci
// Email: devtechsupport@logitech.com

using UnityEngine;
using System.Collections;

public class LogitechLed : MonoBehaviour {
	
	int red,blue,green;
	public string effectLabel;
	
	// Use this for initialization
	void Start () {

		blue = 0;
		red = 0;
		green = 0;
		LogitechGSDK.LogiLedInit();
		LogitechGSDK.LogiLedSaveCurrentLighting();
		effectLabel = "Press F to test flashing effect, P to test pulsing effect \n " +
			"Press mouse1 to set all lighting to random color, mouse 2 to set G910 to random bitmap \n" +
            "Press E to start per-key effects (F1-F12) show on supported devices \n" +
			"Press S to stop the effects \n";
	}
	void OnGUI(){
		GUI.Label(new Rect(10, 250, 500, 200), effectLabel);
	}
	
	// Update is called once per frame
	void Update () {

        int duration = GetDlgItemInt(IDC_EDIT_DURATION, 0, 0);

        int redVal = 0;
        int greenVal = 0;
        int blueVal = 0;
        GetEffectColorValues(&redVal, &greenVal, &blueVal, true);

        int redFinishVal = 0;
        int greenFinishVal = 0;
        int blueFinishVal = 0;
        int duration1 = 1000;

        GetEffectColorValues(&redFinishVal, &greenFinishVal, &blueFinishVal, false);
        int loopChecked = m_perKeyPulseLoop.GetCheck();


        LogiLedPulseSingleKey(LogiLed::KeyName::N, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration1, loopChecked);
        LogiLedPulseSingleKey(LogiLed::KeyName::B, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration1, loopChecked);
        LogiLedPulseSingleKey(LogiLed::KeyName::H, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration1, loopChecked);
        LogiLedPulseSingleKey(LogiLed::KeyName::J, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration1, loopChecked);
        LogiLedPulseSingleKey(LogiLed::KeyName::G, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration1, loopChecked);
        LogiLedPulseSingleKey(LogiLed::KeyName::Y, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration1, loopChecked);
        LogiLedPulseSingleKey(LogiLed::KeyName::U, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration1, loopChecked);
        LogiLedPulseSingleKey(LogiLed::KeyName::I, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration1, loopChecked);
        LogiLedPulseSingleKey(LogiLed::KeyName::T, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration1, loopChecked);
        LogiLedPulseSingleKey(LogiLed::KeyName::SIX, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration1, loopChecked);
        LogiLedPulseSingleKey(LogiLed::KeyName::EIGHT, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration1, loopChecked);

        /*/
        LogiLedPulseSingleKey(LogiLed::KeyName::N, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration, loopChecked);
        LogiLedPulseSingleKey(LogiLed::KeyName::B, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration, loopChecked);
        LogiLedPulseSingleKey(LogiLed::KeyName::H, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration, loopChecked);
        LogiLedPulseSingleKey(LogiLed::KeyName::J, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration, loopChecked);
        LogiLedPulseSingleKey(LogiLed::KeyName::G, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration, loopChecked);
        LogiLedPulseSingleKey(LogiLed::KeyName::Y, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration, loopChecked);
        LogiLedPulseSingleKey(LogiLed::KeyName::U, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration, loopChecked);
        LogiLedPulseSingleKey(LogiLed::KeyName::I, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration, loopChecked);
        LogiLedPulseSingleKey(LogiLed::KeyName::T, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration, loopChecked);
        LogiLedPulseSingleKey(LogiLed::KeyName::SIX, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration, loopChecked);
        LogiLedPulseSingleKey(LogiLed::KeyName::EIGHT, redFinishVal, greenFinishVal, blueFinishVal, redVal, greenVal, blueVal, duration, loopChecked);
        */
    }

    void OnDestroy () {
		//Before quitting, we need to restore the user's backlighting settings
		LogitechGSDK.LogiLedRestoreLighting();
     	LogitechGSDK.LogiLedShutdown();
	}
}
