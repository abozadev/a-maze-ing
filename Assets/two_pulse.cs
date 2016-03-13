using UnityEngine;
using System.Collections;

public class two_pulse
{

    float wait_time;
    void Start()
    {

    }

    public IEnumerator ThreadFunction()
    {
        // Do your threaded task. DON'T use the Unity API here
            byte[] bitmap = new byte[644];
        wait_time = 0.025F;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);


        int aux = 253;
        for (int i = 0; i < 644; i += 4)
        {
            bitmap[i] = 0;          // blue
            bitmap[i + 1] = 0;      // green
            bitmap[i + 2] = 0;      // red
            bitmap[i + 3] = 255;    // brightness
        }
        // loop through the bitmap, every four bits is a key so act on i/+1/+2/+3
        for (int i = 0; i < 16; i += 4)
        {
            bitmap[aux + i] = 255;
            LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
            yield return new WaitForSeconds(wait_time);
            bitmap[aux + i] = 0;
            LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
        }
        bitmap[185] = 255;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
        yield return new WaitForSeconds(wait_time);
        bitmap[185] = 0;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);

        bitmap[105] = 255;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
        yield return new WaitForSeconds(wait_time);
        bitmap[105] = 0;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);

        bitmap[189] = 255;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
        yield return new WaitForSeconds(wait_time);
        bitmap[189] = 0;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);

        bitmap[273] = 255;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
        yield return new WaitForSeconds(wait_time);
        bitmap[273] = 0;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);

        bitmap[361] = 255;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
        yield return new WaitForSeconds(wait_time);
        bitmap[361] = 0;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);

        bitmap[277] = 255;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
        yield return new WaitForSeconds(wait_time);
        bitmap[277] = 0;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);

        bitmap[281] = 255;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
        yield return new WaitForSeconds(wait_time);
        bitmap[281] = 0;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);

        bitmap[201] = 255;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
        yield return new WaitForSeconds(wait_time);
        bitmap[201] = 0;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);

        bitmap[121] = 255;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
        yield return new WaitForSeconds(wait_time);
        bitmap[121] = 0;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);

        bitmap[205] = 255;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
        yield return new WaitForSeconds(wait_time);
        bitmap[205] = 0;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);

        bitmap[289] = 255;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
        yield return new WaitForSeconds(wait_time);
        bitmap[289] = 0;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);

        bitmap[377] = 255;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
        yield return new WaitForSeconds(wait_time);
        bitmap[377] = 0;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);

        bitmap[293] = 255;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);
        yield return new WaitForSeconds(wait_time);
        bitmap[293] = 0;
        LogitechGSDK.LogiLedSetLightingFromBitmap(bitmap);


        aux = 293;

        for (int i = 0; i < 16; i += 4)
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