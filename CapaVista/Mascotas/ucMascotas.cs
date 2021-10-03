using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Mascotas
{
    public partial class UcMascotas : UserControl
    {
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
            MessageBox.Show("posta?", "ELIMINAR PERMANENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);   
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //guardar consulta
            MessageBox.Show("Guardado con éxito!");
            rtbDetalleConsulta.Clear();      
        }
        private void ItemsSeleccionados(object sender, EventArgs e)
        {
 
        }
    }
}
