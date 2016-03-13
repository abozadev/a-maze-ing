// Logitech Gaming SDK
//
// Copyright (C) 2011-2014 Logitech. All rights reserved.
// Author: Tiziano Pigliucci
// Email: devtechsupport@logitech.com

using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System;
using System.IO;

public class LogitechArxControl : MonoBehaviour {

	private String descriptionLabel;
    public AudioSource[] _audio;
    private Light myLight;
    

    volatile IntPtr girl_playable = Marshal.AllocHGlobal(sizeof(int));
    int comm = new int();
    volatile bool scream_playable = false;
    LogitechGSDK.logiArxCbContext cbContext;
    
    //public AudioSource clickAudio;
    //GirlSound girl;
    //bool girl_playable;

    //screamsound scream;
    //bool scream_playable;

    // Use this for initialization
    /*void Start () {var showText=false;




		LogitechGSDK.logiArxCbContext cbContext;
		LogitechGSDK.logiArxCB cbInstance = new LogitechGSDK.logiArxCB(this.ArxSDKCallback);
		cbContext.arxCallBack = cbInstance;
		cbContext.arxContext = IntPtr.Zero;

        girl_playable = false;
        girl = GetComponent<GirlSound>();

        scream = GetComponent<screamsound>();
        scream_playable = false;

        LogitechGSDK.LogiArxInit("com.screamit.com", "Scream it", ref cbContext);
		//descriptionLabel = "Click the left mouse button to update the progress bar, Press G to switch to a different index file, press I to go back to the original one.";
	}*/
    void Start()
    {

        
        LogitechGSDK.logiArxCB cbInstance = new LogitechGSDK.logiArxCB(this.ArxSDKCallback);
        cbContext.arxCallBack = cbInstance;
        cbContext.arxContext = girl_playable;
        LogitechGSDK.LogiArxInit("com.screamit.com", "Scream it", ref cbContext);


        //audio = GetComponents<AudioSource>();
        // audio[1].Play();
        // audio[0].Play();
        // Debug.Log(audio[0]);
        //Debug.Log(audio[1]);
        //audio[1] = GetComponent<AudioSource>();
    }
	// Update is called once per frame
	void Update(){

        //print((int)cbContext.arxContext);
        //if ((int)girl_playable == 1)
        //if (cbContext.arxContext != IntPtr.Zero)
        if (Marshal.ReadInt32(girl_playable) == 1)
        {
            //girl_playable = IntPtr.Zero;
            Debug.Log("girl sound" + cbContext.arxContext.ToString());
            cbContext.arxContext = IntPtr.Zero;

            _audio[0].Play();
            Marshal.WriteInt32(girl_playable, 0);
        }
        if (Marshal.ReadInt32(girl_playable) == 2)
        {
            //girl_playable = IntPtr.Zero;
            Debug.Log("Scream sound" + cbContext.arxContext.ToString());
            cbContext.arxContext = IntPtr.Zero;

            _audio[1].Play();
            Marshal.WriteInt32(girl_playable, 0);
        }
        if (Marshal.ReadInt32(girl_playable) == 3)
        {
            _audio[2].Play();
            Marshal.WriteInt32(girl_playable, 0);
        }
        //if (scream_playable)
        //{

        //    scream_playable = false;
        //    Debug.Log("Scream sound");
        //    //scream.play_sound();
        //    _audio[1].Play();
        //}
    }

	public static string getHtmlString()
	{
		string retStr = "";
		retStr += "<html><center><body bgcolor='black'><a href='applet.html'><img src='gameover.png'/></a></body></center></html>";
		return retStr;
	}

	void ArxSDKCallback(int eventType, int eventValue, String eventArg, IntPtr context)
	{ 
		// Debug.Log("CALLBACK: type:"+eventType+", value:"+eventValue+", arg:"+eventArg);
		if(eventType ==LogitechGSDK.LOGI_ARX_EVENT_MOBILEDEVICE_ARRIVAL)
		{
            
            if (!LogitechGSDK.LogiArxAddFileAs("Assets//Logitech SDK//AppletData//applet.html","applet.html", ""))
			{
				Debug.Log("Could not send applet.html : "+LogitechGSDK.LogiArxGetLastError());
			}

            if (!LogitechGSDK.LogiArxAddFileAs("Assets//Logitech SDK//AppletData//style.css", "style.css", ""))
            {
                Debug.Log("Could not send style.css : " + LogitechGSDK.LogiArxGetLastError());
            }

            if (!LogitechGSDK.LogiArxAddFileAs("Assets//Logitech SDK//AppletData//background.png","background.png",""))
			{
				Debug.Log("Could not send background.png : "+LogitechGSDK.LogiArxGetLastError());
			}          
		
			if(!LogitechGSDK.LogiArxSetIndex("applet.html"))
			{
				Debug.Log("Could not set index : "+LogitechGSDK.LogiArxGetLastError());
			}
					
		}
		/* else if(eventType ==LogitechGSDK.LOGI_ARX_EVENT_MOBILEDEVICE_REMOVAL)
		{
			Debug.Log("NO DEVICES");
		} */
		else if (eventType == LogitechGSDK.LOGI_ARX_EVENT_TAP_ON_TAG)
		{
            Debug.Log("Main loop " + eventArg + " " + eventValue);
            if (eventArg == "girl")
            {
                Marshal.WriteInt32(context, 1);
                Debug.Log(context.ToString());
            }
            if (eventArg == "scream")
            {
                Marshal.WriteInt32(context, 2);
                Debug.Log("Scream loop");
                scream_playable = true;
                //scream_playable = true;
                //    Debug.Log("Scream exit loop");              
            }
            if (eventArg == "man")
            {
                Marshal.WriteInt32(context, 3);
                Debug.Log("Scream loop");
            }
            //Debug.Log("Tap on tag with id :"+eventArg);
        }
        Debug.Log("CALLBACK: type:" + eventType + ", value:" + eventValue + ", arg:" + eventArg + "EXITED");
    }
	
	void OnDestroy () {
		//Free G-Keys SDKs before quitting the game
		LogitechGSDK.LogiArxShutdown();
	}

    
}
