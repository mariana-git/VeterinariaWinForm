using System;
using CapaDatos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Mascotas;

namespace CapaLogica.Mascotas
{
    public class CL_AgregarConsulta
    {
        CD_AgregarConsultas agregarEnCD = new CD_AgregarConsultas();
        
        private int[] arrayCategoriaConsulta;

        public int[] ArrayCategoriaConsulta { get => arrayCategoriaConsulta; set => arrayCategoriaConsulta = value; }

        public void CargarCategoriasConsultas()
        {
            foreach (var item in ArrayCategoriaConsulta)
            {
                agregarEnCD.IdTipoConsulta = item;
                agregarEnCD.AgregarCategoríasConsulta();
            }            
        }
    }
}
