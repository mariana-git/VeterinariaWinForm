using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Conexion
    {
        #region CONEXION ACCESS (desactivado)

        //private readonly OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = |DataDirectory|Veterinaria.accdb; Persist Security Info=False;");

        //public OleDbConnection Conectar()
        //{
        //    if (Conexion.State == ConnectionState.Open) Conexion.Close();
        //    Conexion.Open();
        //    return Conexion;
        //}

        //public OleDbConnection Desconectar()
        //{
        //    Conexion.Close();
        //    return Conexion;
        //}

        #endregion

        #region CONEXION SQL (activado)
        private readonly SqlConnection Conexion = new SqlConnection("server = DESKTOP-JRGCSS9 ; database= Veterinaria ; integrated security = true;");

        public SqlConnection ConectarBD()
        {
            if (Conexion.State == ConnectionState.Open) Conexion.Close();
            Conexion.Open();
            return Conexion;
        }

        public SqlConnection DesconectarBD()
        {
            Conexion.Close();
            return Conexion;
        }
        #endregion
    }
}
