using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Mascotas
{
    class CD_AgregarCastracion:CD_EjecutarSQL
    {
        private string query;
        public object IdCastracion { get; private set; }
        public object Descripcion { get; private set; }

        public void Castracion()
        {
            query = $"INSERT INTO CASTRACION (IDCastracion,Descripcion) VALUES ({IdCastracion},{Descripcion});";
            ModoDesconectado(query);
        }
    }
}
