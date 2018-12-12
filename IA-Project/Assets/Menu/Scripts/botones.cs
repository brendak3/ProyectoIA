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
        if (Input.GetButton("Fire4"))
        {
            BtnPlay();
        }
        else if(Input.GetButton("Fire5"))
        {
            Btnplay2();
        }
	}

    public void BtnPlay()
    {
        DataBase db = new DataBase();
        //db.InsertarRegistro();
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
