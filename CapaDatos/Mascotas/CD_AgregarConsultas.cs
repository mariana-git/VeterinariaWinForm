using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Mascotas
{
    class CD_AgregarConsultas:CD_EjecutarSQL
    {
        private string query;
        public object IdConsulta { get; private set; }
        public object IdTipoConsulta { get; private set; }
        public object TipoConsultaDescripcion { get; private set; }

        public void Consultas()
        {
            query = $"INSERT INTO CONSULTAS (IDConsulta,IDTipoConsulta) VALUES ({IdConsulta},{IdTipoConsulta});";
            ModoDesconectado(query);
        }
        public void TipoConsulta()
        {
            query = $"INSERT INTO TIPOCONSULTA (IDTipoConsulta,Descripcion) VALUES ({IdTipoConsulta},{TipoConsultaDescripcion});";
            ModoDesconectado(query);
        }
    }
}
