using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Mascotas
{
    class CD_AgregarVacunas:CD_EjecutarSQL
    {
        private string query;
        public object IdVacuna { get; private set; }
        public object DescripcionVacuna { get; private set; }
        public object DescripcionDosis { get; private set; }
        public object IdDosis { get; private set; }

        public void Vacunas()
        {
            query = $"INSERT INTO VACUNAS (IDVacuna,Descripcion,IDDosis) VALUES ({IdVacuna},{DescripcionVacuna},{IdDosis});";
            ModoDesconectado(query);
        }
        public void TipoDosis()
        {
            query = $"INSERT INTO TIPODOSIS (IDDosis,Descripcion) VALUES ({IdDosis},{DescripcionDosis});";
            ModoDesconectado(query);
        }
    }
}
