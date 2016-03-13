using UnityEngine;
using System.Collections;

public class Job 
{

    float wait_time;
    Timer time;
    float myTime;
    void Start()
    {

    }

    public  IEnumerator ThreadFunction()
    {
        // Do your threaded task. DON'T use the Unity API here
            byte[] bitmap = new byte[644];
            wait_time = 0.025F;
            LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
            

            int aux = 253;
            for (int i = 0; i < 644; i += 4)
            {
                bitmap[i] = 0;      // blue
                bitmap[i + 1] = 0;      // green
                bitmap[i + 2] = 0;      // red
                bitmap[i + 3] = 255;  // brightness
            }
            // loop through the bitmap, every four bits is a key so act on i/+1/+2/+3
            for (int i = 0; i < 23; i += 4)
            {
                bitmap[aux + i] = 255;
                LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
                yield return new WaitForSeconds(wait_time);
                bitmap[aux + i] = 0;
                LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
            }
            bitmap[193] = 255;
            LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
        yield return new WaitForSeconds(wait_time);
        bitmap[193] = 0;
            LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);

            bitmap[113] = 255;
            LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
        yield return new WaitForSeconds(wait_time);
        bitmap[113] = 0;
            LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);

            bitmap[197] = 255;
            LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
        yield return new WaitForSeconds(wait_time);
        bitmap[197] = 0;
            LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);

            bitmap[281] = 255;
            LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
        yield return new WaitForSeconds(wait_time);
        bitmap[281] = 0;
            LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);

            bitmap[369] = 255;
            LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
        yield return new WaitForSeconds(wait_time);
        bitmap[369] = 0;
            LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);

            aux = 285;

            for (int i = 0; i < 24; i += 4)
            {
                bitmap[aux + i] = 255;
                LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
            yield return new WaitForSeconds(wait_time);
            bitmap[aux + i] = 0;
                LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);

            }
        
    }

    void one_pulse()
    {

    }
    
}