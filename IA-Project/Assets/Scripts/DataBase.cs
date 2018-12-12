using System.Collections;
using System.Collections.Generic;
using System;
using Mono;
using UnityEngine;


public class DataBase : MonoBehaviour {
    private string conn, sqlQuery;

    System.Data.IDbConnection dbconn;
    System.Data.IDbCommand dbcmd;
    // Use this for initialization
    void Start () {
		
	}

    public int InsertarRegistro()
    {
        conn = "URI=file:" + Application.dataPath + "/Plugins/historial.db";
        using (dbconn = new Mono.Data.Sqlite.SqliteConnection(conn))
        {
            dbconn.Open(); //Open connection to the database.
            dbcmd = dbconn.CreateCommand();
            DateTime dtN = DateTime.Now;
            sqlQuery = string.Format("INSERT INTO Usuario (usu_nombre, usu_fecha) VALUES(\"{0}\",\"{1}\")", "Sesión del dia " + dtN.ToLongDateString(), dtN.ToShortDateString());
            dbcmd.CommandText = sqlQuery;
            var rsp = dbcmd.ExecuteScalar();
            if (rsp != null)
            {
                Variables.Instance.IDSESION = rsp.ToString();
            }
            dbconn.Close();
        }
        return 1;
    }
    public void InsertResultado(int ejercicio, int resultado)
    {
        using (dbconn = new Mono.Data.Sqlite.SqliteConnection(conn))
        {
            int id = Convert.ToInt32(Variables.Instance.IDSESION);
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
        using (dbconn = new Mono.Data.Sqlite.SqliteConnection(conn))
        {
            dbconn.Open(); //Open connection to the database.
            dbcmd = dbconn.CreateCommand();
            sqlQuery = "SELECT usu_nombre, rst_ejercicio, rst_respuesta FROM Usuario INNER JOIN Resultados ON usu_id = rst_usu_id";// table name
            dbcmd.CommandText = sqlQuery;
            System.Data.IDataReader reader = dbcmd.ExecuteReader();
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