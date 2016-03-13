using UnityEngine;
using System.Collections;

public class screamsound : MonoBehaviour {

    public AudioSource audio_scream;
    // Use this for initialization
    void Start()
    {
        audio_scream = GetComponent<AudioSource>();
    }

    public void play_sound()
    {
        audio_scream.Play();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
