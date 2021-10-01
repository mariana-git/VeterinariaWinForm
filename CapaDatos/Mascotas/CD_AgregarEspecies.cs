using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Mascotas
{
    class CD_AgregarEspecies:CD_EjecutarSQL
    {
        public string query;
        public object EspecieDescripcion { get; private set; }
        public object IdEspecie { get; private set; }
        public object IdRaza { get; private set; }
        public object RazaDescripcion { get; private set; }

        public void Especies()
        {
            query = $"INSERT INTO ESPECIES (IDEspecie,Descripcion,IDRaza) VALUES ({IdEspecie},{EspecieDescripcion},{IdRaza});";
            ModoDesconectado(query);
        }
        public void TipoRaza()
        {
            query = $"INSERT INTO TIPORAZA (IDRaza,Descripcion) VALUES ({IdRaza},{RazaDescripcion});";
            ModoDesconectado(query);
        }
    }
}
