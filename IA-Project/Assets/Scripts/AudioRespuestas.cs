using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRespuestas : MonoBehaviour {
    public GameObject clip;
    public GameObject[] clips;
    
	// Use this for initialization
	void Start () {
        clips = GameObject.FindGameObjectsWithTag("audio_1");
        clip = GameObject.FindGameObjectWithTag("analogia_audio");
    }
	
	// Update is called once per frame
	void Update () {
        //Reproducir();
    }

    public void Reproducir() {
        System.Random random = new System.Random();

        int random_audio = random.Next(0, clips.Length - 1);
        clips[random_audio].GetComponent<AudioSource>().Play();

        clip.GetComponent<AudioSource>().PlayDelayed(3);

    }


    
}
