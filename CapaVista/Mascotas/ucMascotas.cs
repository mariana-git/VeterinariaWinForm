using System;
using System.Collections.Generic;
using CapaLogica.Mascotas;
using System.Windows.Forms;

namespace CapaVista.Mascotas
{
    public partial class UcMascotas : UserControl
    {
        CL_AgregarConsulta agregarEnCL = new CL_AgregarConsulta();
        public UcMascotas()
        {
            InitializeComponent();
            MascotaNoEditable();
        }
        private void MascotaNoEditable()
        {
            txtNombreMascota.ReadOnly = true;
            txtFicha.ReadOnly = true;
            dateTimeFechaNac.Enabled = false;
            cmbEspecie.Enabled = false;
            cmbRaza.Enabled = false;
            dgvMascotaVacunas.ReadOnly = true;
            cmbCastracion.Enabled = false;
            dateTimeCastracion.Enabled = false;
            dgvMascotasResponsables.ReadOnly = true;
        }
        private void MascotaEditable()
        {
            txtNombreMascota.ReadOnly = false;
            txtFicha.ReadOnly = false;
            dateTimeFechaNac.Enabled = true;
            cmbEspecie.Enabled = true;
            cmbRaza.Enabled = true;
            dgvMascotaVacunas.ReadOnly = false;
            cmbCastracion.Enabled = true;
            dateTimeCastracion.Enabled = true;
            dgvMascotasResponsables.ReadOnly = false;
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "EDITAR")
            {
                btnEditar.Text = "GUARDAR";
                MascotaEditable();
            }

            else
            {
                MessageBox.Show("Guardado con éxito!");
                btnEditar.Text = "EDITAR";
                MascotaNoEditable();
            } 
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea archivar de manera permanente la ficha de esta mascota?", "ELIMINAR PERMANENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);   
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //guardar consulta
                agregarEnCL.ArrayCategoriaConsulta = ItemsSeleccionados();
                agregarEnCL.CargarCategoriasConsultas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }

                rtbDetalleConsulta.Clear();
        }
        private int[] ItemsSeleccionados()
        {
            //con este método armo una lista donde acumulo los índices de los items seleccionados del checklistbox y luego la transformo en un array

            List<int> listaItems = new List<int>();
            //obtiene cada indice seleccionado
            foreach (int indexChecked in chckListaTipoConsulta.CheckedIndices)
            {                
                listaItems.Add(indexChecked);   //la variable indexChecked contiene el indice del item             
            }
            int[] arrayLista = listaItems.ToArray();

            //deselecciono los items
            for (int i = 0; i < chckListaTipoConsulta.Items.Count; i++)
            {
                chckListaTipoConsulta.SetItemChecked(i, false);
            }
            return arrayLista;
        }
    }
}
