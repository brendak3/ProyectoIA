using System.Collections;
using System.Collections.Generic;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine;

public class InsertResultado : MonoBehaviour {
    private string conn, sqlQuery;
    IDbConnection dbconn;
    IDbCommand dbcmd;
    // Use this for initialization
    void Start () {
        conn = "URI=file:" + Application.dataPath + "/Plugins/historial.db";
    }

    public void insertResultado(int id, int ejercicio, int resultado)
    {
        using (dbconn = new SqliteConnection(conn))
        {
            dbconn.Open(); //Open connection to the database.
            dbcmd = dbconn.CreateCommand();
            sqlQuery = string.Format("INSER INTO Resultados (rst_usu_id,rst_ejercicio, rst_respuesta) VALUES(\"{0}\",\"{1}\",\"{2}\")", id, ejercicio, resultado);// table name
            dbcmd.CommandText = sqlQuery;
            dbcmd.ExecuteScalar();
            dbconn.Close();
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
