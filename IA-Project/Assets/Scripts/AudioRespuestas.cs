using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRespuestas : MonoBehaviour {
    public GameObject clip;
    public GameObject[] clips;
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //Reproducir();
    }

    public void Reproducir() {
        System.Random random = new System.Random();

        //clip = GameObject.FindGameObjectWithTag("audio_1");
        clips = GameObject.FindGameObjectsWithTag("audio_1");

        int random_audio = random.Next(0, clips.Length-1);
        clips[random_audio].GetComponent<AudioSource>().Play();
        //clip.GetComponent<AudioSource>().Play();
    }

    public void Score() {

    }

    
}
