using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Mascotas
{
    public class CD_AgregarConsultas:CD_EjecutarSQL
    {
        private string query;
        private int idConsulta, idTipoConsulta, tipoConsultaDescripcion;

        public int IdConsulta { get => idConsulta; set => idConsulta = value; }
        public int IdTipoConsulta { get => idTipoConsulta; set => idTipoConsulta = value; }
        public int TipoConsultaDescripcion { get => tipoConsultaDescripcion; set => tipoConsultaDescripcion = value; }

        public void AgregarCategoríasConsulta()
        {
            query = $"INSERT INTO CONSULTAS (IDTipoConsulta) VALUES ({IdTipoConsulta});";
            ModoDesconectado(query);
        }
        public void TipoConsulta()
        {
            query = $"INSERT INTO TIPOCONSULTA (IDTipoConsulta,Descripcion) VALUES ({IdTipoConsulta},{TipoConsultaDescripcion});";
            ModoDesconectado(query);
        }
    }
}
