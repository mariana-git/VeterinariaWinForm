using System;
using CapaLogica;
using CapaLogica.Mascotas;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class ucBusqueda : UserControl
    {
        public ucBusqueda(string origen)
        {
            InitializeComponent();
            lblOrigen.Text = origen;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();        
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvBuscar.DataSource = null;
                if (lblOrigen.Text == "MASCOTAS") dgvBuscar.DataSource = new CL_BuscarMascotas().Buscar(txtBucar.Text);
                if (lblOrigen.Text == "RESPONSABLES") dgvBuscar.DataSource = new CL_Responsables().Buscar(txtBucar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
            txtBucar.Text = string.Empty;
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string id ="", mostrarID;

            if (lblOrigen.Text == "MASCOTAS") id = "IDMascota";
            if (lblOrigen.Text == "RESPONSABLES") id = "IDResponsable";
            mostrarID = dgvBuscar.CurrentRow.Cells[id].Value.ToString();
            //TODO abrir uc mascota completo
        }
    }
}
