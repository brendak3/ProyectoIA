using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesAnalogia1 : MonoBehaviour {
    public GameObject clip;
    public GameObject[] clips;
    public GameObject clipcompleto;

    // Use this for initialization
    void Start () {
        clips = GameObject.FindGameObjectsWithTag("audio_1");
        clip = GameObject.FindGameObjectWithTag("analogia_audio");
        clipcompleto = GameObject.FindGameObjectWithTag("analogia_pregunta");
    }
	
	// Update is called once per frame
	void Update () {
        DataBase db = new DataBase();
        if (Input.GetButton("Fire4")) //respuesta correcta
        {
            //db.InsertResultado(1, 1);
            Reproducir();
        }
        else if(Input.GetButton("Fire5")) //Respuesta incorrecta
        {
            //db.InsertResultado(1, 0);
            clipcompleto.GetComponent<AudioSource>().Play();
        }
    }

    public void Reproducir()
    {
        System.Random random = new System.Random();

        int random_audio = random.Next(0, clips.Length - 1);
        clips[random_audio].GetComponent<AudioSource>().Play();

        clip.GetComponent<AudioSource>().PlayDelayed(3);

    }
}
