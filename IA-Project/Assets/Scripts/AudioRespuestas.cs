using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRespuestas : MonoBehaviour {
    public GameObject clip;
    //List<GameObject> clips = new List<GameObject>();
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
    }

    public void Reproducir() {
        var clips = GameObject.FindGameObjectsWithTag("audio_1");
        clip.GetComponent<AudioSource>().Play();
        //for (int i = 0; i < clip.Count; i++)
        //{

        //}
        //clip.GetComponent<AudioSource>(Random.Range(0, 3).Play();
    }

    
}
