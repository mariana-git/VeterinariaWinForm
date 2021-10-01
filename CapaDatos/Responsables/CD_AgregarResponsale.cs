using System;
using System.Data;

namespace CapaDatos
{
    public class CD_AgregarResponsale: CD_EjecutarSQL
    {
        #region ATRIBUTOS
        private int idMascota, ficha, idResponsable, numeroCalle, piso, idLocalidad, idPartido, idProvincia, idTelefono, idMail, idCastracion, idEspecie, idVacuna,telefono;
        private DateTime fechaNacimientoMascota, fechaInoculacion, fechaCastracion;
        private string nombreMascota, nombreResponsable, apellidoResponsable, calle, departamento, email, consulta;
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
        public int IdEspecie { get => idEspecie; set => idEspecie = value; }
        public int IdVacuna { get => idVacuna; set => idVacuna = value; }
        public DateTime FechaNacimientoMascota { get => fechaNacimientoMascota; set => fechaNacimientoMascota = value; }
        public string NombreMascota { get => nombreMascota; set => nombreMascota = value; }
        public string NombreResponsable { get => nombreResponsable; set => nombreResponsable = value; }
        public string ApellidoResponsable { get => apellidoResponsable; set => apellidoResponsable = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Email { get => email; set => email = value; }
        public DateTime FechaInoculacion { get => fechaInoculacion; set => fechaInoculacion = value; }
        public DateTime FechaCastracion { get => fechaCastracion; set => fechaCastracion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        #endregion

        #region METODOS 
       
        public void Responsable()
        {
            consulta = "INSERT INTO RESPONSABLES (Nombre, Apelllido, Calle, Numero, Piso, Departamento, IDLocalidad) " +
                $"VALUES ({NombreResponsable},{ApellidoResponsable},{Calle},{NumeroCalle},{Piso},{Departamento},{IdLocalidad});";
            ModoDesconectado(consulta);
        }
        public void ResponsableMail()
        {
            consulta = $"INSERT INTO RESPONSABLES_MAILS (IDResponsable, IDMail, Numero) VALUES ({IdResponsable},{IdMail},{Email});";
            ModoDesconectado(consulta);
        }
        public void ResponsableTelefono()
        {
            consulta = $"INSERT INTO RESPONSABLES_TELEFONOS (IDResponsable, IDTelefono, Numero) VALUES ({IdResponsable},{IdTelefono},{Telefono});";
            ModoDesconectado(consulta);
        }
        #endregion
    }
}
