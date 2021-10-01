
namespace CapaVista.Mascotas
{
    partial class UcMascotas
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.flPanelMascota = new System.Windows.Forms.FlowLayoutPanel();
            this.gbMascota = new System.Windows.Forms.GroupBox();
            this.dateTimeFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtFicha = new System.Windows.Forms.TextBox();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbRaza = new System.Windows.Forms.ComboBox();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvMascotaVacunas = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimeCastracion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMascotasResponsables = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.gbxConsultas = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.chklistboxTipoConsulta = new System.Windows.Forms.CheckedListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.rtbDetalleConsulta = new System.Windows.Forms.RichTextBox();
            this.flPanelMascota.SuspendLayout();
            this.gbMascota.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotaVacunas)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotasResponsables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.gbxConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // flPanelMascota
            // 
            this.flPanelMascota.Controls.Add(this.gbMascota);
            this.flPanelMascota.Controls.Add(this.groupBox3);
            this.flPanelMascota.Controls.Add(this.groupBox4);
            this.flPanelMascota.Controls.Add(this.groupBox5);
            this.flPanelMascota.Controls.Add(this.groupBox2);
            this.flPanelMascota.Location = new System.Drawing.Point(33, 3);
            this.flPanelMascota.Name = "flPanelMascota";
            this.flPanelMascota.Size = new System.Drawing.Size(292, 687);
            this.flPanelMascota.TabIndex = 0;
            // 
            // gbMascota
            // 
            this.gbMascota.Controls.Add(this.dateTimeFechaNac);
            this.gbMascota.Controls.Add(this.txtFicha);
            this.gbMascota.Controls.Add(this.txtNombreMascota);
            this.gbMascota.Controls.Add(this.label3);
            this.gbMascota.Controls.Add(this.label2);
            this.gbMascota.Controls.Add(this.label1);
            this.gbMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.gbMascota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.gbMascota.Location = new System.Drawing.Point(3, 3);
            this.gbMascota.Name = "gbMascota";
            this.gbMascota.Size = new System.Drawing.Size(286, 141);
            this.gbMascota.TabIndex = 0;
            this.gbMascota.TabStop = false;
            this.gbMascota.Text = "MASCOTA";
            // 
            // dateTimeFechaNac
            // 
            this.dateTimeFechaNac.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFechaNac.Location = new System.Drawing.Point(141, 103);
            this.dateTimeFechaNac.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimeFechaNac.Name = "dateTimeFechaNac";
            this.dateTimeFechaNac.Size = new System.Drawing.Size(132, 24);
            this.dateTimeFechaNac.TabIndex = 15;
            // 
            // txtFicha
            // 
            this.txtFicha.Location = new System.Drawing.Point(141, 73);
            this.txtFicha.Name = "txtFicha";
            this.txtFicha.Size = new System.Drawing.Size(132, 24);
            this.txtFicha.TabIndex = 14;
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Location = new System.Drawing.Point(142, 43);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(132, 24);
            this.txtNombreMascota.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "F de Nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ficha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbRaza);
            this.groupBox3.Controls.Add(this.cmbEspecie);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.groupBox3.Location = new System.Drawing.Point(3, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 115);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ESPECÍMEN";
            // 
            // cmbRaza
            // 
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.Location = new System.Drawing.Point(85, 71);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(188, 26);
            this.cmbRaza.TabIndex = 21;
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(85, 42);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(188, 26);
            this.cmbEspecie.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Especie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Raza:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvMascotaVacunas);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.groupBox4.Location = new System.Drawing.Point(3, 271);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 144);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "VACUNAS";
            // 
            // dgvMascotaVacunas
            // 
            this.dgvMascotaVacunas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            this.dgvMascotaVacunas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMascotaVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotaVacunas.Location = new System.Drawing.Point(3, 39);
            this.dgvMascotaVacunas.Name = "dgvMascotaVacunas";
            this.dgvMascotaVacunas.Size = new System.Drawing.Size(283, 90);
            this.dgvMascotaVacunas.TabIndex = 24;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.dateTimeCastracion);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.groupBox5.Location = new System.Drawing.Point(3, 421);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(286, 113);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CASTRACIÓN";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(141, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 26);
            this.comboBox1.TabIndex = 21;
            // 
            // dateTimeCastracion
            // 
            this.dateTimeCastracion.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeCastracion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeCastracion.Location = new System.Drawing.Point(143, 72);
            this.dateTimeCastracion.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimeCastracion.Name = "dateTimeCastracion";
            this.dateTimeCastracion.Size = new System.Drawing.Size(131, 24);
            this.dateTimeCastracion.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "F de Castración:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Efectuada:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMascotasResponsables);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.groupBox2.Location = new System.Drawing.Point(3, 540);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 144);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RESPONSABLES";
            // 
            // dgvMascotasResponsables
            // 
            this.dgvMascotasResponsables.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            this.dgvMascotasResponsables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMascotasResponsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotasResponsables.Location = new System.Drawing.Point(3, 46);
            this.dgvMascotasResponsables.Name = "dgvMascotasResponsables";
            this.dgvMascotasResponsables.Size = new System.Drawing.Size(280, 84);
            this.dgvMascotasResponsables.TabIndex = 25;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(250)))), ((int)(((byte)(85)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEditar.Location = new System.Drawing.Point(33, 696);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(143, 28);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(250)))), ((int)(((byte)(85)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEliminar.Location = new System.Drawing.Point(179, 696);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(143, 28);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(250)))), ((int)(((byte)(85)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(72)))), ((int)(((byte)(203)))));
            this.btnCerrar.Location = new System.Drawing.Point(1076, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 26);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            this.dgvConsultas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(368, 32);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.Size = new System.Drawing.Size(689, 253);
            this.dgvConsultas.TabIndex = 23;
            // 
            // gbxConsultas
            // 
            this.gbxConsultas.Controls.Add(this.button2);
            this.gbxConsultas.Controls.Add(this.chklistboxTipoConsulta);
            this.gbxConsultas.Controls.Add(this.btnGuardar);
            this.gbxConsultas.Controls.Add(this.rtbDetalleConsulta);
            this.gbxConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.gbxConsultas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.gbxConsultas.Location = new System.Drawing.Point(368, 310);
            this.gbxConsultas.Name = "gbxConsultas";
            this.gbxConsultas.Size = new System.Drawing.Size(689, 414);
            this.gbxConsultas.TabIndex = 21;
            this.gbxConsultas.TabStop = false;
            this.gbxConsultas.Text = "CONSULTAS";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(250)))), ((int)(((byte)(85)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button2.Location = new System.Drawing.Point(365, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 28);
            this.button2.TabIndex = 32;
            this.button2.Text = "EDITAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // chklistboxTipoConsulta
            // 
            this.chklistboxTipoConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            this.chklistboxTipoConsulta.CheckOnClick = true;
            this.chklistboxTipoConsulta.ColumnWidth = 200;
            this.chklistboxTipoConsulta.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklistboxTipoConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.chklistboxTipoConsulta.FormattingEnabled = true;
            this.chklistboxTipoConsulta.Items.AddRange(new object[] {
            "Consulta",
            "Vacunación",
            "Tratamiento",
            "Urgencia",
            "Cirugia",
            "Estudios Clínicos"});
            this.chklistboxTipoConsulta.Location = new System.Drawing.Point(20, 289);
            this.chklistboxTipoConsulta.MultiColumn = true;
            this.chklistboxTipoConsulta.Name = "chklistboxTipoConsulta";
            this.chklistboxTipoConsulta.Size = new System.Drawing.Size(646, 50);
            this.chklistboxTipoConsulta.TabIndex = 25;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(250)))), ((int)(((byte)(85)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnGuardar.Location = new System.Drawing.Point(178, 380);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(162, 28);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // rtbDetalleConsulta
            // 
            this.rtbDetalleConsulta.BackColor = System.Drawing.SystemColors.Window;
            this.rtbDetalleConsulta.Location = new System.Drawing.Point(20, 51);
            this.rtbDetalleConsulta.Name = "rtbDetalleConsulta";
            this.rtbDetalleConsulta.Size = new System.Drawing.Size(646, 221);
            this.rtbDetalleConsulta.TabIndex = 0;
            this.rtbDetalleConsulta.Text = "";
            // 
            // ucMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            this.Controls.Add(this.gbxConsultas);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.flPanelMascota);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Name = "ucMascotas";
            this.Size = new System.Drawing.Size(1101, 741);
            this.flPanelMascota.ResumeLayout(false);
            this.gbMascota.ResumeLayout(false);
            this.gbMascota.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotaVacunas)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotasResponsables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.gbxConsultas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPanelMascota;
        private System.Windows.Forms.GroupBox gbMascota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeFechaNac;
        private System.Windows.Forms.TextBox txtFicha;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dateTimeCastracion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.GroupBox gbxConsultas;
        private System.Windows.Forms.CheckedListBox chklistboxTipoConsulta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RichTextBox rtbDetalleConsulta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbRaza;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.DataGridView dgvMascotaVacunas;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvMascotasResponsables;
    }
}
