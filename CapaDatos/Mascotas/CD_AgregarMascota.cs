using System;
using System.Data;

namespace CapaDatos
{
    public class CD_AgregarMascota: CD_EjecutarSQL
    {
        #region ATRIBUTOS
        private int idMascota, ficha, idResponsable, idCastracion, idEspecie, idVacuna;
        private DateTime fechaNacimientoMascota, fechaInoculacion, fechaCastracion,fechaConsulta;
        private string nombreMascota, nombreResponsable, apellidoResponsable, detalle, query;
        #endregion
        #region PROPIEDADES
        public int IdMascota { get => idMascota; set => idMascota = value; }
        public int Ficha { get => ficha; set => ficha = value; }
        public int IdResponsable { get => idResponsable; set => idResponsable = value; }
        public int IdCastracion { get => idCastracion; set => idCastracion = value; }
        public int IdEspecie { get => idEspecie; set => idEspecie = value; }
        public int IdVacuna { get => idVacuna; set => idVacuna = value; }
        public DateTime FechaNacimientoMascota { get => fechaNacimientoMascota; set => fechaNacimientoMascota = value; }
        public string NombreMascota { get => nombreMascota; set => nombreMascota = value; }
        public string NombreResponsable { get => nombreResponsable; set => nombreResponsable = value; }
        public string ApellidoResponsable { get => apellidoResponsable; set => apellidoResponsable = value; }
        public DateTime FechaInoculacion { get => fechaInoculacion; set => fechaInoculacion = value; }
        public DateTime FechaCastracion { get => fechaCastracion; set => fechaCastracion = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public DateTime FechaConsulta { get => fechaConsulta; set => fechaConsulta = value; }
        public object IdConsulta { get; private set; }
        #endregion
        #region METODOS 
        public void Mascota()
        {
            query = $"INSERT INTO MASCOTAS (Ficha, Nombre, FechaNac) VALUES ({Ficha},{NombreMascota},{FechaNacimientoMascota:dd/mm/yyyy});"; //String fnew = String.Format( f.ToShortDateString(), "dd/mm/aaaa");
            ModoDesconectado(query);
        }
        public void MascotaVacuna()
        {
            query = "INSERT INTO MASCOTAS_VACUNAS (IDVacuna, IDMascota, FechaInoculacion) " +
                $"VALUES ({IdVacuna},{IdMascota},{FechaInoculacion:dd/mm/yyyy});";
            ModoDesconectado(query);
        }

        public void MascotaEspecie()
        {
            query = $"INSERT INTO MASCOTAS_ESPECIE (IDMascota, IDEspecie) VALUES ({IdMascota},{IdEspecie});";
            ModoDesconectado(query);
        }

        public void MascotaCastracion()
        {
            query = $"INSERT INTO MASCOTAS_CASTRACION (IDMascota, IDCastracion, Fecha) VALUES ({IdMascota},{IdCastracion},{FechaCastracion:dd/mm/yyyy});";
            ModoDesconectado(query);
        }
        public void MascotaResponsable()
        {
            query = $"INSERT INTO MASCOTAS_RESPONSABLES (IDMascota,IDResponsable) VALUES ({IdMascota},{IdResponsable});";
            ModoDesconectado(query);
        }
        public void MascotaConsultas()
        {
            query = $"INSERT INTO MASCOTAS_CONSULTAS (IDConsulta,IDMascota,Detalle) VALUES ({IdConsulta},{IdMascota},{FechaConsulta:dd/mm/yyyy},{Detalle});";
            ModoDesconectado(query);
        }
        #endregion
    }
}
