using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{

    public class CD_Buscar : CD_EjecutarSQL
    {
        #region ATRIBUTOS
        private int idMascota, ficha, idResponsable, numeroCalle, piso, idLocalidad, idPartido, idProvincia, idTelefono, idMail, idCastracion, idEspecimen, idVacuna;
        private DateTime fechaNacimientoMascota;
        private string nombreMascota, nombreResponsable, apellidoResponsable, calle, departamento, email, parametroDeBusqueda, consulta;
        #endregion
        #region PROPIEDADES
        public int IdMascota { get => idMascota; set => idMascota = value; }
        public int Ficha { get => ficha; set => ficha = value; }
        public int IdResponsable { get => idResponsable; set => idResponsable = value; }
        public int NumeroCalle { get => numeroCalle; set => numeroCalle = value; }
        public int Piso { get => piso; set => piso = value; }
        public int IdLocalidad { get => idLocalidad; set => idLocalidad = value; }
        public int IdPartido { get => idPartido; set => idPartido = value; }
        public int IdProvincia { get => idProvincia; set => idProvincia = value; }
        public int IdTelefono { get => idTelefono; set => idTelefono = value; }
        public int IdMail { get => idMail; set => idMail = value; }
        public int IdCastracion { get => idCastracion; set => idCastracion = value; }
        public int IdEspecimen { get => idEspecimen; set => idEspecimen = value; }
        public int IdVacuna { get => idVacuna; set => idVacuna = value; }
        public DateTime FechaNacimientoMascota { get => fechaNacimientoMascota; set => fechaNacimientoMascota = value; }
        public string NombreMascota { get => nombreMascota; set => nombreMascota = value; }
        public string NombreResponsable { get => nombreResponsable; set => nombreResponsable = value; }
        public string ApellidoResponsable { get => apellidoResponsable; set => apellidoResponsable = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Email { get => email; set => email = value; }
        public string ParametroDeBusqueda { get => parametroDeBusqueda; set => parametroDeBusqueda = value; }
        #endregion

        private DataTable DT = new DataTable();

        #region METODOS 
        public DataTable Mascotas()
        {
            DT.Clear();
            if (ParametroDeBusqueda != "") consulta = $"SELECT * FROM MASCOTAS WHERE (Nombre LIKE '%{ParametroDeBusqueda}%'" +
                    $" OR Ficha LIKE '%{ParametroDeBusqueda}%' ORDER BY Nombre;";
            else consulta = "SELECT * FROM MASCOTAS;";

            DT = ModoConectado(consulta);
            return DT;
        }
        public DataTable Responsales()
        {
            DT.Clear();
            if (ParametroDeBusqueda != "") consulta = $"SELECT * FROM RESPONSABLES WHERE (Nombre LIKE '%{ParametroDeBusqueda}%'" +
                    $" OR Apellido LIKE '%{ParametroDeBusqueda}%' OR Documento LIKE '%{ParametroDeBusqueda}%' OR Legajo LIKE '%{ParametroDeBusqueda}%');";
            else consulta = "SELECT * FROM MASCOTAS;";
            DT = ModoConectado(consulta);
            return DT;
        }
        #endregion
    }
}
