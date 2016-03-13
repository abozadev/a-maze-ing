using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class GirlSound : MonoBehaviour {

    public AudioSource _audio;
    // Use this for initialization
    void Start () {
        _audio = GetComponent<AudioSource>();
    }
	
    public void play_sound()
    {
        _audio.Play();
    }
	// Update is called once per frame
	void Update () {
	
	}
}
