
namespace CapaVista
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.flpMenus = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMascotas = new System.Windows.Forms.Button();
            this.panelSMMascotas = new System.Windows.Forms.Panel();
            this.btnAgregarM = new System.Windows.Forms.Button();
            this.btnBuscarM = new System.Windows.Forms.Button();
            this.btnResponsables = new System.Windows.Forms.Button();
            this.panelSMResponsables = new System.Windows.Forms.Panel();
            this.btnAgregarR = new System.Windows.Forms.Button();
            this.btnBuscarR = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.flpMenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSMMascotas.SuspendLayout();
            this.panelSMResponsables.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpMenus
            // 
            this.flpMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(19)))), ((int)(((byte)(131)))));
            this.flpMenus.Controls.Add(this.pictureBox1);
            this.flpMenus.Controls.Add(this.label2);
            this.flpMenus.Controls.Add(this.btnMascotas);
            this.flpMenus.Controls.Add(this.panelSMMascotas);
            this.flpMenus.Controls.Add(this.btnResponsables);
            this.flpMenus.Controls.Add(this.panelSMResponsables);
            this.flpMenus.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpMenus.Location = new System.Drawing.Point(0, 0);
            this.flpMenus.Name = "flpMenus";
            this.flpMenus.Size = new System.Drawing.Size(169, 801);
            this.flpMenus.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(250)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(0, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "VETERINARIA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMascotas
            // 
            this.btnMascotas.AutoSize = true;
            this.btnMascotas.BackColor = System.Drawing.Color.Aqua;
            this.btnMascotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMascotas.FlatAppearance.BorderSize = 0;
            this.btnMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMascotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMascotas.Location = new System.Drawing.Point(3, 158);
            this.btnMascotas.Name = "btnMascotas";
            this.btnMascotas.Size = new System.Drawing.Size(160, 73);
            this.btnMascotas.TabIndex = 1;
            this.btnMascotas.Text = "Mascotas";
            this.btnMascotas.UseVisualStyleBackColor = false;
            this.btnMascotas.MouseHover += new System.EventHandler(this.BtnMascotas_MouseHover);
            // 
            // panelSMMascotas
            // 
            this.panelSMMascotas.Controls.Add(this.btnAgregarM);
            this.panelSMMascotas.Controls.Add(this.btnBuscarM);
            this.panelSMMascotas.Location = new System.Drawing.Point(3, 237);
            this.panelSMMascotas.Name = "panelSMMascotas";
            this.panelSMMascotas.Size = new System.Drawing.Size(160, 95);
            this.panelSMMascotas.TabIndex = 7;
            // 
            // btnAgregarM
            // 
            this.btnAgregarM.BackColor = System.Drawing.Color.Aqua;
            this.btnAgregarM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarM.FlatAppearance.BorderSize = 0;
            this.btnAgregarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgregarM.Location = new System.Drawing.Point(1, 49);
            this.btnAgregarM.Name = "btnAgregarM";
            this.btnAgregarM.Size = new System.Drawing.Size(159, 40);
            this.btnAgregarM.TabIndex = 4;
            this.btnAgregarM.Text = "Agregar";
            this.btnAgregarM.UseVisualStyleBackColor = false;
            this.btnAgregarM.Click += new System.EventHandler(this.BtnAgregarM_Click);
            // 
            // btnBuscarM
            // 
            this.btnBuscarM.BackColor = System.Drawing.Color.Aqua;
            this.btnBuscarM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarM.FlatAppearance.BorderSize = 0;
            this.btnBuscarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBuscarM.Location = new System.Drawing.Point(3, 3);
            this.btnBuscarM.Name = "btnBuscarM";
            this.btnBuscarM.Size = new System.Drawing.Size(157, 40);
            this.btnBuscarM.TabIndex = 3;
            this.btnBuscarM.Text = "Buscar";
            this.btnBuscarM.UseVisualStyleBackColor = false;
            this.btnBuscarM.Click += new System.EventHandler(this.BtnBuscarM_Click);
            // 
            // btnResponsables
            // 
            this.btnResponsables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(250)))), ((int)(((byte)(85)))));
            this.btnResponsables.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResponsables.FlatAppearance.BorderSize = 0;
            this.btnResponsables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResponsables.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponsables.Location = new System.Drawing.Point(3, 338);
            this.btnResponsables.Name = "btnResponsables";
            this.btnResponsables.Size = new System.Drawing.Size(160, 73);
            this.btnResponsables.TabIndex = 2;
            this.btnResponsables.Text = "Responsables";
            this.btnResponsables.UseVisualStyleBackColor = false;
            this.btnResponsables.MouseHover += new System.EventHandler(this.BtnResponsables_MouseHover);
            // 
            // panelSMResponsables
            // 
            this.panelSMResponsables.Controls.Add(this.btnAgregarR);
            this.panelSMResponsables.Controls.Add(this.btnBuscarR);
            this.panelSMResponsables.Location = new System.Drawing.Point(3, 417);
            this.panelSMResponsables.Name = "panelSMResponsables";
            this.panelSMResponsables.Size = new System.Drawing.Size(160, 95);
            this.panelSMResponsables.TabIndex = 8;
            // 
            // btnAgregarR
            // 
            this.btnAgregarR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(250)))), ((int)(((byte)(85)))));
            this.btnAgregarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarR.FlatAppearance.BorderSize = 0;
            this.btnAgregarR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnAgregarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgregarR.Location = new System.Drawing.Point(1, 49);
            this.btnAgregarR.Name = "btnAgregarR";
            this.btnAgregarR.Size = new System.Drawing.Size(160, 40);
            this.btnAgregarR.TabIndex = 4;
            this.btnAgregarR.Text = "Agregar";
            this.btnAgregarR.UseVisualStyleBackColor = false;
            this.btnAgregarR.Click += new System.EventHandler(this.BtnAgregarR_Click);
            // 
            // btnBuscarR
            // 
            this.btnBuscarR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(250)))), ((int)(((byte)(85)))));
            this.btnBuscarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarR.FlatAppearance.BorderSize = 0;
            this.btnBuscarR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnBuscarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBuscarR.Location = new System.Drawing.Point(3, 3);
            this.btnBuscarR.Name = "btnBuscarR";
            this.btnBuscarR.Size = new System.Drawing.Size(160, 40);
            this.btnBuscarR.TabIndex = 3;
            this.btnBuscarR.Text = "Buscar";
            this.btnBuscarR.UseVisualStyleBackColor = false;
            this.btnBuscarR.Click += new System.EventHandler(this.BtnBuscarR_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(19)))), ((int)(((byte)(131)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(169, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 30);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(19)))), ((int)(((byte)(131)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(169, 771);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1131, 30);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(19)))), ((int)(((byte)(131)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1270, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 741);
            this.panel3.TabIndex = 3;
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(72)))), ((int)(((byte)(203)))));
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(169, 30);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1101, 741);
            this.panelCentral.TabIndex = 4;
            this.panelCentral.MouseHover += new System.EventHandler(this.PanelCentral_MouseHover);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 801);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpMenus);
            this.Name = "FrmInicio";
            this.Text = "Veterinaria";
            this.flpMenus.ResumeLayout(false);
            this.flpMenus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSMMascotas.ResumeLayout(false);
            this.panelSMResponsables.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMenus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMascotas;
        private System.Windows.Forms.Button btnResponsables;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Panel panelSMMascotas;
        private System.Windows.Forms.Button btnAgregarM;
        private System.Windows.Forms.Button btnBuscarM;
        private System.Windows.Forms.Panel panelSMResponsables;
        private System.Windows.Forms.Button btnAgregarR;
        private System.Windows.Forms.Button btnBuscarR;
    }
}

