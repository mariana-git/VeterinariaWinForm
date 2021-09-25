using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Eliminar : CD_EjecutarSQL
    {
        #region ATRIBUTOS
        private int idMascota, idResponsable;
        #endregion

        #region PROPIEDADES
        public int IdMascota { get => idMascota; set => idMascota = value; }
        public int IdResponsable { get => idResponsable; set => idResponsable = value; }
        #endregion

        #region METODOS 
        public void Mascota()
        {
            string sentencia = $"DELETE FROM MASCOTAS WHERE IDMascota = {IdMascota};";
            ModoDesconectado(sentencia);
        }
        public void Responsable()
        {
            string sentencia = $"DELETE FROM RESPONSABLES WHERE IDResponsable = {IdResponsable};";
            ModoDesconectado(sentencia);
        }
        #endregion
    }

}
