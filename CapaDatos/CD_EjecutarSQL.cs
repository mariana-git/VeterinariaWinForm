using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace CapaDatos
{
 
    public class CD_EjecutarSQL : CD_Conexion
    {

        #region CONEXION ACCESS (desactivado)

        //private DataTable DT = new DataTable();
        //private OleDbCommand Comando = new OleDbCommand();
        //private OleDbDataReader leer;
        //public void ModoDesconectado(string query)
        //{
        //    //Método para realizar todas las consultas en modo conectado
        //    Comando.Connection = Conectar();
        //    Comando.CommandText = query;
        //    Comando.ExecuteNonQuery();
        //    Desconectar();
        //}

        //public DataTable ModoConectado(string query)
        //{
        //    Comando.Connection = Conectar();
        //    Comando.CommandText = query;
        //    Comando.CommandTimeout = 15;
        //    leer = Comando.ExecuteReader();
        //    DT.Load(leer);
        //    if (DT.Rows.Count == 0) throw new Exception("LA BÚSQUEDA NO ARROJÓ RESULTADOS\n\n\n\n");
        //    Desconectar();
        //    return DT;
        //}
        #endregion

        #region CONEXION SQL (activado)

        private DataTable DT = new DataTable();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader leer;
        public void ModoDesconectado(string query)
        {
            //Método para realizar todas las consultas en modo conectado
            Comando.Connection = ConectarBD();
            Comando.CommandText = query;
            Comando.ExecuteNonQuery();
            DesconectarBD();
        }

        public DataTable ModoConectado(string query)
        {
            Comando.Connection = ConectarBD();
            Comando.CommandText = query;
            Comando.CommandTimeout = 15;
            leer = Comando.ExecuteReader();
            DT.Load(leer);
            if (DT.Rows.Count == 0) throw new Exception("LA BÚSQUEDA NO ARROJÓ RESULTADOS\n\n\n\n");
            DesconectarBD();
            return DT;
        }
        #endregion
    }
}
