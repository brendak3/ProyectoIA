using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;

public class conexion : MonoBehaviour {
    private string conn, sqlQuery;
    IDbConnection dbconn;
    IDbCommand dbcmd;
    // Use this for initialization
    void Start () {
		conn = "URI=file:" + Application.dataPath + "/Plugins/historial.db"; 
       //readers();
	}

    public int insertName(string name)
    {
        using (dbconn = new SqliteConnection(conn))
        {
            dbconn.Open(); //Open connection to the database.
            dbcmd = dbconn.CreateCommand();
            sqlQuery = string.Format("INSERT INTO Usuario (usu_nombre, usu_fecha) VALUES(\"{0}\",\"{1}\")", name, DateTime.Now.ToShortDateString());// table name
            dbcmd.CommandText = sqlQuery;
            dbcmd.ExecuteScalar();
            dbconn.Close();
        }
        return 1;
    }
    public void insertResultado(int id, int ejercicio,int resultado)
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

    public void readers()
    {
        using (dbconn = new SqliteConnection(conn))
        {
            dbconn.Open(); //Open connection to the database.
            dbcmd = dbconn.CreateCommand();
            sqlQuery = "SELECT usu_nombre, rst_ejercicio, rst_respuesta FROM Usuario INNER JOIN Resultados ON usu_id = rst_usu_id";// table name
            dbcmd.CommandText = sqlQuery;
            IDataReader reader = dbcmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString(0);
                string ejercicio = reader.GetString(1);
                string resultado = reader.GetString(2);

                Debug.Log("Nombre =" + name + "  Ejercicio =" + ejercicio + "   Resultado" + resultado);
            }
            reader.Close();
            reader = null;
            dbcmd.Dispose();
            dbcmd = null;
            dbconn.Close();
            dbconn = null;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}