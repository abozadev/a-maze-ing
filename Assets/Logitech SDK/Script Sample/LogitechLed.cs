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
		red = 100;
		green = 0;
		LogitechGSDK.LogiLedInit();
		LogitechGSDK.LogiLedSaveCurrentLighting();


        int finishRed = 0;
        int finishBlue = 0;
        int finishGreen = 0;

        LogitechGSDK.LogiLedPulseSingleKey(LogitechGSDK.keyboardNames.N, finishRed, finishGreen, finishBlue, red, green, blue, 1000, true);
        LogitechGSDK.LogiLedPulseSingleKey(LogitechGSDK.keyboardNames.B, finishRed, finishGreen, finishBlue, red, green, blue, 1000, true);
        LogitechGSDK.LogiLedPulseSingleKey(LogitechGSDK.keyboardNames.H, finishRed, finishGreen, finishBlue, red, green, blue, 1000, true);
        LogitechGSDK.LogiLedPulseSingleKey(LogitechGSDK.keyboardNames.J, finishRed, finishGreen, finishBlue, red, green, blue, 1000, true);
        LogitechGSDK.LogiLedPulseSingleKey(LogitechGSDK.keyboardNames.G, finishRed, finishGreen, finishBlue, red, green, blue, 1000, true);
        LogitechGSDK.LogiLedPulseSingleKey(LogitechGSDK.keyboardNames.T, finishRed, finishGreen, finishBlue, red, green, blue, 1000, true);
        LogitechGSDK.LogiLedPulseSingleKey(LogitechGSDK.keyboardNames.Y, finishRed, finishGreen, finishBlue, red, green, blue, 1000, true);
        LogitechGSDK.LogiLedPulseSingleKey(LogitechGSDK.keyboardNames.U, finishRed, finishGreen, finishBlue, red, green, blue, 1000, true);
        LogitechGSDK.LogiLedPulseSingleKey(LogitechGSDK.keyboardNames.I, finishRed, finishGreen, finishBlue, red, green, blue, 1000, true);
        LogitechGSDK.LogiLedPulseSingleKey(LogitechGSDK.keyboardNames.SIX, finishRed, finishGreen, finishBlue, red, green, blue, 1000, true);
        LogitechGSDK.LogiLedPulseSingleKey(LogitechGSDK.keyboardNames.EIGHT, finishRed, finishGreen, finishBlue, red, green, blue, 1000, true);

        LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(LogitechGSDK.keyboardNames.A, 0, 100, 0);
    }


    // Update is called once per frame
    void Update () {

        
	}
	
	void OnDestroy () {
		//Before quitting, we need to restore the user's backlighting settings
		LogitechGSDK.LogiLedRestoreLighting();
     	LogitechGSDK.LogiLedShutdown();
	}
}
