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
            gbMascota.Enabled = false;
            //flPanelMascota.Enabled = false;
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //flPanelMascota.Enabled = true;
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("posta?", "ELIMINAR PERMANENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);   
        }
    }
}
