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
    Job myJob;
    two_pulse pulse2;
    int count;
    bool myPulse = true;
    Timer timeer;

    // Use this for initialization
    void Start () {

        timeer = new Timer();
		blue = 0;
		red = 100;
		green = 0;
		LogitechGSDK.LogiLedInit();
		LogitechGSDK.LogiLedSaveCurrentLighting();

        count = 0;    

        myJob = new Job();
        pulse2 = new two_pulse();

        StartCoroutine( myJob.ThreadFunction());
        //StartCoroutine(pulse2.ThreadFunction());
        
    }


    // Update is called once per frame
    void Update () {

        if (count == 100)
        {
            StartCoroutine(myJob.ThreadFunction());
            //else StartCoroutine(pulse2.ThreadFunction());
            count = 0;
        }
        else count += 1;
	}
	
	void OnDestroy () {
		//Before quitting, we need to restore the user's backlighting settings
		LogitechGSDK.LogiLedRestoreLighting();
     	LogitechGSDK.LogiLedShutdown();
	}


    public void changePulse()
    {
        myPulse = false;
    }
            
}
