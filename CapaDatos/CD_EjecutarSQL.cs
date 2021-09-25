﻿using System;
using System.Data;
using System.Data.OleDb;

namespace CapaDatos
{
    public class CD_EjecutarSQL : CD_Conexion
    {
        private DataTable DT = new DataTable();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataReader leer;
        public void ModoDesconectado(string query)
        {
            //Método para realizar todas las consultas en modo conectado
            Comando.Connection = Conectar();
            Comando.CommandText = query;
            Comando.ExecuteNonQuery();
            Desconectar();
        }

        public DataTable ModoConectado(string query)
        {
            Comando.Connection = Conectar();
            Comando.CommandText = query;
            Comando.CommandTimeout = 15;
            leer = Comando.ExecuteReader();
            DT.Load(leer);
            if (DT.Rows.Count == 0) throw new Exception("LA OPERACIÓN NO ARROJÓ RESULTADOS\n\n");
            Desconectar();
            return DT;
        }
    }
}
