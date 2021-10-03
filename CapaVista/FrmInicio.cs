using System;
using System.Windows.Forms;
using CapaLogica;
using CapaVista.Mascotas;

namespace CapaVista
{
    public partial class FrmInicio : Form
    {
        private UserControl userControlActivo = null; //variable para manipular en el metodo del ControlUser Activo en el panel
        public FrmInicio()
        {
            InitializeComponent();
            SubMenusOcultos();
        }
        private void AbrirUC(UserControl UControlActivo)
        {
            //Controla que solo haya un UserControl abierto dentro del Panel
            if (userControlActivo != null) userControlActivo.Dispose();
            userControlActivo = UControlActivo;
            panelCentral.Controls.Add(UControlActivo);
            panelCentral.Tag = UControlActivo;
            UControlActivo.BringToFront();
            UControlActivo.Show();
        }
        private void SubMenusOcultos()
        {
            panelSMMascotas.Visible = false;
            panelSMResponsables.Visible = false;
        }
        private void OcultarSubMenu()
        {
            if (panelSMMascotas.Visible == true) panelSMMascotas.Visible = false;
            if (panelSMResponsables.Visible == true) panelSMResponsables.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }
        private void BtnBuscarM_Click(object sender, EventArgs e)
        {
            AbrirUC(new ucBusqueda("MASCOTAS"));
            OcultarSubMenu();
        }

        private void BtnBuscarR_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            AbrirUC(new ucBusqueda("RESPONSABLES"));
        }

        private void BtnAgregarM_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            AbrirUC(new UcMascotas());
        }

        private void BtnAgregarR_Click(object sender, EventArgs e)
        {

        }

        private void BtnMascotas_MouseHover(object sender, EventArgs e)
        {
            OcultarSubMenu();
            MostrarSubMenu(panelSMMascotas);
        }

        private void BtnResponsables_MouseHover(object sender, EventArgs e)
        {
            OcultarSubMenu();
            MostrarSubMenu(panelSMResponsables);
        }

        private void PanelCentral_MouseHover(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }
    }
}
