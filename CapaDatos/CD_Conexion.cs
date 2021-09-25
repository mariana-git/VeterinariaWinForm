using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Conexion
    {
        private readonly OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Veterinaria.accdb");

        public OleDbConnection Conectar()
        {
            if (Conexion.State == ConnectionState.Open) Conexion.Close();        //    
            Conexion.Open();
            return Conexion;
        }

        public OleDbConnection Desconectar()
        {
            Conexion.Close();
            return Conexion;
        }
    }
}
