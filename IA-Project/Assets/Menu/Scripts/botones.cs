using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class botones : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire2"))
        {
            BtnPlay();
        }
        else if(Input.GetButton("Fire1"))
        {
            Btnplay2();
        }
	}

    public void BtnPlay()
    {
     SceneManager.LoadScene("carro");
    }
    public void Btnplay2()
    {
        SceneManager.LoadScene("analogia2");
    }
    public void BtnEstadisticas()
    {

    }
    public void BtnOpc()
    {

    }

}
