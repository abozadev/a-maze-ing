using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{


    float timeRemaining = 240;

    void Update()
    {
        timeRemaining -= Time.deltaTime;
    }

    void OnGUI()
    {
        if (timeRemaining > 0)
        {
            GUI.Label(new Rect(100, 100, 200, 100),
                         "Time Remaining : " + System.Math.Round(timeRemaining / 60, 0) + ":" + System.Math.Round(timeRemaining%60, 2));
                if (System.Math.Round(timeRemaining / 60, 0) < 2)
            {
                Debug.Log("Change Pulse");
                //LogitechLed.changePulse();
            }
        }
        else {
            GUI.Label(new Rect(100, 100, 200, 100), "Time's Up");
        }
    }

    public float getTime()
    {
        return timeRemaining;
    }
}