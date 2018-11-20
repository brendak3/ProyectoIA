using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRespuestas : MonoBehaviour {
    public GameObject clip;
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
    }

    public void Reproducir() {
        clip = GameObject.FindGameObjectWithTag("audio_1");
        clip.GetComponent<AudioSource>().Play();
    }

    
}
