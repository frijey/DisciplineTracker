namespace SFG
{
    partial class FrmMantenimientoUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGrabar.ClaseATrabajar = Controles.listado.Usuario;
            this.btnGrabar.MyTextBoxID = this.txtd1cod_usu;
            this.btnGrabar.Procedimiento = "SentenciaUsuario";
            this.btnEliminar.ClaseATrabajar = Controles.listado.Usuario;
            this.btnEliminar.MyTextBoxID = this.txtd1cod_usu;
            this.btnEliminar.Procedimiento = "SentenciaUsuario";
this.lbldc6fk_rol = new Controles.LabelNormalCustom();
            
            //
            // lbldc6fk_rol
            //
            this.lbldc6fk_rol.AutoSize = true;
            this.lbldc6fk_rol.Location = new System.Drawing.Point(36, 187);
            this.lbldc6fk_rol.Name = "lbldc6fk_rol";
            this.lbldc6fk_rol.Text = "Fk_rol";

this.txtd6fk_rol = new Controles.TextBoxCustom();
                        //
            // txtd6fk_rol
            //
            this.txtd6fk_rol.DefaultValue = "0";
            this.txtd6fk_rol.Text = "0";
            this.txtd6fk_rol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd6fk_rol.Enabled = false;
            this.txtd6fk_rol.id = "fk_rol";
            this.txtd6fk_rol.Limpiar = true;
            this.txtd6fk_rol.Location = new System.Drawing.Point(140, 184);
            this.txtd6fk_rol.Name = "txtd6fk_rol";
            this.txtd6fk_rol.NeedAlert = false;
            this.txtd6fk_rol.obligatorio = true;
            this.txtd6fk_rol.ObligatorioDinamico = 1;
            this.txtd6fk_rol.MaxLength = 17;
            this.txtd6fk_rol.TipoValidacion = Controles.Validacion.Enteros;
            this.txtd6fk_rol.Size = new System.Drawing.Size(100, 20);
            this.txtd6fk_rol.TabIndex = 5;
this.lbldc5ema_usu = new Controles.LabelNormalCustom();
            
            //
            // lbldc5ema_usu
            //
            this.lbldc5ema_usu.AutoSize = true;
            this.lbldc5ema_usu.Location = new System.Drawing.Point(36, 161);
            this.lbldc5ema_usu.Name = "lbldc5ema_usu";
            this.lbldc5ema_usu.Text = "Ema_usu";

this.txtd5ema_usu = new Controles.TextBoxCustom();
                        //
            // txtd5ema_usu
            //
            this.txtd5ema_usu.DefaultValue = "";
            this.txtd5ema_usu.Text = "";
            this.txtd5ema_usu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd5ema_usu.Enabled = false;
            this.txtd5ema_usu.id = "ema_usu";
            this.txtd5ema_usu.Limpiar = true;
            this.txtd5ema_usu.Location = new System.Drawing.Point(140, 158);
            this.txtd5ema_usu.Name = "txtd5ema_usu";
            this.txtd5ema_usu.NeedAlert = false;
            this.txtd5ema_usu.obligatorio = true;
            this.txtd5ema_usu.ObligatorioDinamico = 1;
            this.txtd5ema_usu.Size = new System.Drawing.Size(100, 20);
            this.txtd5ema_usu.MaxLength = 45;
            this.txtd5ema_usu.TabIndex = 4;
this.lbldc4tip_usu = new Controles.LabelNormalCustom();
            
            //
            // lbldc4tip_usu
            //
            this.lbldc4tip_usu.AutoSize = true;
            this.lbldc4tip_usu.Location = new System.Drawing.Point(36, 135);
            this.lbldc4tip_usu.Name = "lbldc4tip_usu";
            this.lbldc4tip_usu.Text = "Tip_usu";

this.txtd4tip_usu = new Controles.TextBoxCustom();
                        //
            // txtd4tip_usu
            //
            this.txtd4tip_usu.DefaultValue = "";
            this.txtd4tip_usu.Text = "";
            this.txtd4tip_usu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd4tip_usu.Enabled = false;
            this.txtd4tip_usu.id = "tip_usu";
            this.txtd4tip_usu.Limpiar = true;
            this.txtd4tip_usu.Location = new System.Drawing.Point(140, 132);
            this.txtd4tip_usu.Name = "txtd4tip_usu";
            this.txtd4tip_usu.NeedAlert = false;
            this.txtd4tip_usu.obligatorio = true;
            this.txtd4tip_usu.ObligatorioDinamico = 1;
            this.txtd4tip_usu.Size = new System.Drawing.Size(100, 20);
            this.txtd4tip_usu.MaxLength = 45;
            this.txtd4tip_usu.TabIndex = 3;
this.lbldc3cla_usu = new Controles.LabelNormalCustom();
            
            //
            // lbldc3cla_usu
            //
            this.lbldc3cla_usu.AutoSize = true;
            this.lbldc3cla_usu.Location = new System.Drawing.Point(36, 109);
            this.lbldc3cla_usu.Name = "lbldc3cla_usu";
            this.lbldc3cla_usu.Text = "Cla_usu";

this.txtd3cla_usu = new Controles.TextBoxCustom();
                        //
            // txtd3cla_usu
            //
            this.txtd3cla_usu.DefaultValue = "";
            this.txtd3cla_usu.Text = "";
            this.txtd3cla_usu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd3cla_usu.Enabled = false;
            this.txtd3cla_usu.id = "cla_usu";
            this.txtd3cla_usu.Limpiar = true;
            this.txtd3cla_usu.Location = new System.Drawing.Point(140, 106);
            this.txtd3cla_usu.Name = "txtd3cla_usu";
            this.txtd3cla_usu.NeedAlert = false;
            this.txtd3cla_usu.obligatorio = true;
            this.txtd3cla_usu.ObligatorioDinamico = 1;
            this.txtd3cla_usu.Size = new System.Drawing.Size(100, 20);
            this.txtd3cla_usu.MaxLength = 45;
            this.txtd3cla_usu.TabIndex = 2;
this.lbldc2nom_usu = new Controles.LabelNormalCustom();
            
            //
            // lbldc2nom_usu
            //
            this.lbldc2nom_usu.AutoSize = true;
            this.lbldc2nom_usu.Location = new System.Drawing.Point(36, 83);
            this.lbldc2nom_usu.Name = "lbldc2nom_usu";
            this.lbldc2nom_usu.Text = "Nom_usu";

this.txtd2nom_usu = new Controles.TextBoxCustom();
                        //
            // txtd2nom_usu
            //
            this.txtd2nom_usu.DefaultValue = "";
            this.txtd2nom_usu.Text = "";
            this.txtd2nom_usu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd2nom_usu.Enabled = false;
            this.txtd2nom_usu.id = "nom_usu";
            this.txtd2nom_usu.Limpiar = true;
            this.txtd2nom_usu.Location = new System.Drawing.Point(140, 80);
            this.txtd2nom_usu.Name = "txtd2nom_usu";
            this.txtd2nom_usu.NeedAlert = false;
            this.txtd2nom_usu.obligatorio = true;
            this.txtd2nom_usu.ObligatorioDinamico = 1;
            this.txtd2nom_usu.Size = new System.Drawing.Size(100, 20);
            this.txtd2nom_usu.MaxLength = 45;
            this.txtd2nom_usu.TabIndex = 1;
this.LabelN1cod_usu = new Controles.LabelNormalCustom();
            
            //
            // LabelN1cod_usu
            //
            this.LabelN1cod_usu.AutoSize = true;
            this.LabelN1cod_usu.Location = new System.Drawing.Point(36, 57);
            this.LabelN1cod_usu.Name = "LabelN1cod_usu";
            this.LabelN1cod_usu.Size = new System.Drawing.Size(15, 13);
            this.LabelN1cod_usu.Text = "Cod_usu";

this.txtd1cod_usu = new Controles.TextBoxCustom();
                        //
            // txtd1cod_usu
            //
            this.txtd1cod_usu.DefaultValue = "Nuevo";
            this.txtd1cod_usu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd1cod_usu.Text = "NUEVO";
            this.txtd1cod_usu.Enabled = false;
            this.txtd1cod_usu.id = "cod_usu";
            this.txtd1cod_usu.Limpiar = true;
            this.txtd1cod_usu.Location = new System.Drawing.Point(140, 54);
            this.txtd1cod_usu.Name = "txtd1cod_usu";
            this.txtd1cod_usu.NeedAlert = false;
            this.txtd1cod_usu.obligatorio = false;
            this.txtd1cod_usu.ObligatorioDinamico = 1;
            this.txtd1cod_usu.DefaultEnabledFalse = true;
            this.txtd1cod_usu.Size = new System.Drawing.Size(100, 20);
            this.txtd1cod_usu.TabIndex = 0;
            this.SuspendLayout();
            // 
            // FrmMantenimientoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 519);
            this.tabPageRegistro.Controls.Add(this.txtd1cod_usu);
            
            this.tabPageRegistro.Controls.Add(this.LabelN1cod_usu);
            
            this.tabPageRegistro.Controls.Add(this.txtd2nom_usu);
            
            this.tabPageRegistro.Controls.Add(this.lbldc2nom_usu);
            
            this.tabPageRegistro.Controls.Add(this.txtd3cla_usu);
            
            this.tabPageRegistro.Controls.Add(this.lbldc3cla_usu);
            
            this.tabPageRegistro.Controls.Add(this.txtd4tip_usu);
            
            this.tabPageRegistro.Controls.Add(this.lbldc4tip_usu);
            
            this.tabPageRegistro.Controls.Add(this.txtd5ema_usu);
            
            this.tabPageRegistro.Controls.Add(this.lbldc5ema_usu);
            
            this.tabPageRegistro.Controls.Add(this.txtd6fk_rol);
            
            this.tabPageRegistro.Controls.Add(this.lbldc6fk_rol);
            
            this.txtd6fk_rol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtd6fk_rol_KeyPress);
            this.txtd6fk_rol.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtd6fk_rol_PreviewKeyDown);
                        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewNormal2 = new Controles.DataGridViewNormal();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtParametro = new Controles.TextBoxSecundarioCustom();
            this.btnmostrartodo = new Controles.btnCustom();
            this.labelNormalCustom6 = new Controles.LabelNormalCustom();
            this.lblCantidad = new Controles.LabelNormalCustom();
            this.tabPageListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNormal2)).BeginInit();
            this.tabPageListado.Controls.Add(this.lblCantidad);
            this.tabPageListado.Controls.Add(this.labelNormalCustom6);
            this.tabPageListado.Controls.Add(this.dataGridViewNormal2);
            this.tabPageListado.Controls.Add(this.txtParametro);
            this.tabPageListado.Controls.Add(this.btnmostrartodo);
            // dataGridViewNormal2
            // 
            this.dataGridViewNormal2.AllowUserToAddRows = false;
            this.dataGridViewNormal2.AllowUserToDeleteRows = false;
            this.dataGridViewNormal2.AllowUserToResizeColumns = false;
            this.dataGridViewNormal2.AllowUserToResizeRows = false;
            this.dataGridViewNormal2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewNormal2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewNormal2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNormal2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(133)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNormal2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNormal2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNormal2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNormal2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewNormal2.EnableHeadersVisualStyles = false;
            this.dataGridViewNormal2.Location = new System.Drawing.Point(3, 65);
            this.dataGridViewNormal2.MultiSelect = false;
            this.dataGridViewNormal2.Name = "dataGridViewNormal2";
            this.dataGridViewNormal2.ReadOnly = true;
            this.dataGridViewNormal2.RowHeadersVisible = false;
            this.dataGridViewNormal2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNormal2.Size = new System.Drawing.Size(638, 369);
            this.dataGridViewNormal2.TabIndex = 10;
            this.dataGridViewNormal2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNormal2_CellDoubleClick);
            this.dataGridViewNormal2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewNormal2_KeyDown);            
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.DataPropertyName = "cod_usu";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "nom_usu";
            this.Column2.HeaderText = "nom_usu";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;            
            // 
            // txtParametro
            // 
            this.txtParametro.BackColor = System.Drawing.Color.White;
            this.txtParametro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParametro.DefaultDeshabilitar = true;
            this.txtParametro.DefaultEnabledFalse = false;
            this.txtParametro.DefaultValue = "";
            this.txtParametro.ExtraInfo = "";
            this.txtParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametro.id = "TextBoxDeBusqueda123";
            this.txtParametro.Limpiar = false;
            this.txtParametro.Location = new System.Drawing.Point(13, 37);
            this.txtParametro.MaxLength = 45;
            this.txtParametro.MinimumValue = 0D;
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.NeedAlert = false;
            this.txtParametro.obligatorio = false;
            this.txtParametro.ObligatorioDinamico = 0;
            this.txtParametro.Size = new System.Drawing.Size(368, 20);
            this.txtParametro.TabIndex = 6;
            this.txtParametro.TextChanged += new System.EventHandler(this.textBoxSecundarioCustom1_TextChanged);
            this.txtParametro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParametro_KeyDown);
            // 
            // btnmostrartodo
            // 
            this.btnmostrartodo.Accion = "I";
            this.btnmostrartodo.BackColor = System.Drawing.Color.White;
            this.btnmostrartodo.ClaseATrabajar = Controles.listado.ninguno;
            this.btnmostrartodo.GrupoObligatorio = 0;
            this.btnmostrartodo.Location = new System.Drawing.Point(387, 6);
            this.btnmostrartodo.MostrarMsjError = false;
            this.btnmostrartodo.MostrarMsjSatisfactorio = false;
            this.btnmostrartodo.MsjError = "Error";
            this.btnmostrartodo.MsjSatisfactorio = "Satisfactorio";
            this.btnmostrartodo.Name = "btnmostrartodo";
            this.btnmostrartodo.Procedimiento = "";
            this.btnmostrartodo.Size = new System.Drawing.Size(252, 53);
            this.btnmostrartodo.TabIndex = 7;
            this.btnmostrartodo.Text = "Mostrar Todo";
            this.btnmostrartodo.UseVisualStyleBackColor = false;
            this.btnmostrartodo.Click += new System.EventHandler(this.MostrarTodo);
            // 
            // labelNormalCustom6
            // 
            this.labelNormalCustom6.AutoSize = true;
            this.labelNormalCustom6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNormalCustom6.ForeColor = System.Drawing.Color.Black;
            this.labelNormalCustom6.Location = new System.Drawing.Point(32, 15);
            this.labelNormalCustom6.Name = "labelNormalCustom6";
            this.labelNormalCustom6.Size = new System.Drawing.Size(231, 15);
            this.labelNormalCustom6.TabIndex = 19;
            this.labelNormalCustom6.Text = "Buscar por ID o Nombre";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.Black;
            this.lblCantidad.Location = new System.Drawing.Point(3, 437);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(40, 15);
            this.lblCantidad.TabIndex = 20;
            this.lblCantidad.Text = "Items:";
            //
            this.tabPageListado.ResumeLayout(false);
            this.tabPageListado.PerformLayout();
            this.tabPageListado.Enter += new System.EventHandler(this.tabPageListado_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNormal2)).EndInit();
this.Name = "FrmMantenimientoUsuario";
            this.ShowInTaskbar = false;
            this.Text = "Formulario Heredable";
            this.Load += new System.EventHandler(this.FrmMantenimientoUsuario_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public Controles.DataGridViewNormal dataGridViewNormal2;
        private Controles.TextBoxSecundarioCustom txtParametro;
        private Controles.btnCustom btnmostrartodo;
        private Controles.LabelNormalCustom labelNormalCustom6;
        private Controles.LabelNormalCustom lblCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public Controles.LabelNormalCustom lbldc6fk_rol;
        public Controles.TextBoxCustom txtd6fk_rol;
        public Controles.LabelNormalCustom lbldc5ema_usu;
        public Controles.TextBoxCustom txtd5ema_usu;
        public Controles.LabelNormalCustom lbldc4tip_usu;
        public Controles.TextBoxCustom txtd4tip_usu;
        public Controles.LabelNormalCustom lbldc3cla_usu;
        public Controles.TextBoxCustom txtd3cla_usu;
        public Controles.LabelNormalCustom lbldc2nom_usu;
        public Controles.TextBoxCustom txtd2nom_usu;
        public Controles.LabelNormalCustom LabelN1cod_usu;
        public Controles.TextBoxCustom txtd1cod_usu;
    }
}