using System.Data;
using CapaDatos;

namespace CapaLogica
{
    public class CL_Responsables
    {
        private CD_Buscar buscarEnCD = new CD_Buscar();
        private DataTable DT = new DataTable();
        public DataTable Buscar(string parametro)
        {
            DT.Clear();
            buscarEnCD.ParametroDeBusqueda = parametro;
            DT = buscarEnCD.Responsales();
            return DT;
        }
    }
}
