namespace SFG
{
    partial class FrmMantenimientoIngresos
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
            this.btnGrabar.ClaseATrabajar = Controles.listado.Ingresos;
            this.btnGrabar.MyTextBoxID = this.txtd1cod_ing;
            this.btnGrabar.Procedimiento = "SentenciaIngresos";
            this.btnEliminar.ClaseATrabajar = Controles.listado.Ingresos;
            this.btnEliminar.MyTextBoxID = this.txtd1cod_ing;
            this.btnEliminar.Procedimiento = "SentenciaIngresos";
this.lbldc7bal_pen_ing = new Controles.LabelNormalCustom();
            
            //
            // lbldc7bal_pen_ing
            //
            this.lbldc7bal_pen_ing.AutoSize = true;
            this.lbldc7bal_pen_ing.Location = new System.Drawing.Point(36, 213);
            this.lbldc7bal_pen_ing.Name = "lbldc7bal_pen_ing";
            this.lbldc7bal_pen_ing.Text = "Bal_pen_ing";

this.txtd7bal_pen_ing = new Controles.TextBoxCustom();
                        //
            // txtd7bal_pen_ing
            //
            this.txtd7bal_pen_ing.DefaultValue = "0.00";
            this.txtd7bal_pen_ing.Text = "0.00";
            this.txtd7bal_pen_ing.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd7bal_pen_ing.Enabled = false;
            this.txtd7bal_pen_ing.id = "bal_pen_ing";
            this.txtd7bal_pen_ing.Limpiar = true;
            this.txtd7bal_pen_ing.Location = new System.Drawing.Point(140, 210);
            this.txtd7bal_pen_ing.Name = "txtd7bal_pen_ing";
            this.txtd7bal_pen_ing.NeedAlert = false;
            this.txtd7bal_pen_ing.obligatorio = true;
            this.txtd7bal_pen_ing.ObligatorioDinamico = 1;
            this.txtd7bal_pen_ing.MaxLength = 17;
            this.txtd7bal_pen_ing.TipoValidacion = Controles.Validacion.Dinero;
            this.txtd7bal_pen_ing.Size = new System.Drawing.Size(100, 20);
            this.txtd7bal_pen_ing.TabIndex = 6;
this.lbldc6tot_ing = new Controles.LabelNormalCustom();
            
            //
            // lbldc6tot_ing
            //
            this.lbldc6tot_ing.AutoSize = true;
            this.lbldc6tot_ing.Location = new System.Drawing.Point(36, 187);
            this.lbldc6tot_ing.Name = "lbldc6tot_ing";
            this.lbldc6tot_ing.Text = "Tot_ing";

this.txtd6tot_ing = new Controles.TextBoxCustom();
                        //
            // txtd6tot_ing
            //
            this.txtd6tot_ing.DefaultValue = "0.00";
            this.txtd6tot_ing.Text = "0.00";
            this.txtd6tot_ing.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd6tot_ing.Enabled = false;
            this.txtd6tot_ing.id = "tot_ing";
            this.txtd6tot_ing.Limpiar = true;
            this.txtd6tot_ing.Location = new System.Drawing.Point(140, 184);
            this.txtd6tot_ing.Name = "txtd6tot_ing";
            this.txtd6tot_ing.NeedAlert = false;
            this.txtd6tot_ing.obligatorio = true;
            this.txtd6tot_ing.ObligatorioDinamico = 1;
            this.txtd6tot_ing.MaxLength = 17;
            this.txtd6tot_ing.TipoValidacion = Controles.Validacion.Dinero;
            this.txtd6tot_ing.Size = new System.Drawing.Size(100, 20);
            this.txtd6tot_ing.TabIndex = 5;
this.lbldc5hor_ing = new Controles.LabelNormalCustom();
            
            //
            // lbldc5hor_ing
            //
            this.lbldc5hor_ing.AutoSize = true;
            this.lbldc5hor_ing.Location = new System.Drawing.Point(36, 161);
            this.lbldc5hor_ing.Name = "lbldc5hor_ing";
            this.lbldc5hor_ing.Text = "Hor_ing";

this.txtd5hor_ing = new Controles.TextBoxCustom();
                        //
            // txtd5hor_ing
            //
            this.txtd5hor_ing.DefaultValue = "";
            this.txtd5hor_ing.Text = "";
            this.txtd5hor_ing.Enabled = false;
            this.txtd5hor_ing.id = "hor_ing";
            this.txtd5hor_ing.Limpiar = true;
            this.txtd5hor_ing.Location = new System.Drawing.Point(140, 158);
            this.txtd5hor_ing.Name = "txtd5hor_ing";
            this.txtd5hor_ing.NeedAlert = false;
            this.txtd5hor_ing.obligatorio = true;
            this.txtd5hor_ing.ObligatorioDinamico = 1;
            this.txtd5hor_ing.Size = new System.Drawing.Size(100, 20);
            this.txtd5hor_ing.TabIndex = 4;
this.lbldc4fec_ing = new Controles.LabelNormalCustom();
            
            //
            // lbldc4fec_ing
            //
            this.lbldc4fec_ing.AutoSize = true;
            this.lbldc4fec_ing.Location = new System.Drawing.Point(36, 135);
            this.lbldc4fec_ing.Name = "lbldc4fec_ing";
            this.lbldc4fec_ing.Text = "Fec_ing";

this.dateCustom4fec_ing = new Controles.dateCustom();
                        //
            // dateCustom4fec_ing
            //
            this.dateCustom4fec_ing.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCustom4fec_ing.id = "fec_ing";
            this.dateCustom4fec_ing.Limpiar = true;
            this.dateCustom4fec_ing.Location = new System.Drawing.Point(140, 132);
            this.dateCustom4fec_ing.Name = "dateCustom4fec_ing";
            this.dateCustom4fec_ing.NeedAlert = false;
            this.dateCustom4fec_ing.obligatorio = true;
            this.dateCustom4fec_ing.ObligatorioDinamico = 1;
            this.dateCustom4fec_ing.Size = new System.Drawing.Size(105, 20);
            this.dateCustom4fec_ing.TabIndex = 3;
            this.dateCustom4fec_ing.Value = new System.DateTime(2019, 1, 1, 12, 00, 00, 001);
            this.dateCustom4fec_ing.Enabled = false;
this.lbldc3mon_ing = new Controles.LabelNormalCustom();
            
            //
            // lbldc3mon_ing
            //
            this.lbldc3mon_ing.AutoSize = true;
            this.lbldc3mon_ing.Location = new System.Drawing.Point(36, 109);
            this.lbldc3mon_ing.Name = "lbldc3mon_ing";
            this.lbldc3mon_ing.Text = "Mon_ing";

this.txtd3mon_ing = new Controles.TextBoxCustom();
                        //
            // txtd3mon_ing
            //
            this.txtd3mon_ing.DefaultValue = "0.00";
            this.txtd3mon_ing.Text = "0.00";
            this.txtd3mon_ing.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd3mon_ing.Enabled = false;
            this.txtd3mon_ing.id = "mon_ing";
            this.txtd3mon_ing.Limpiar = true;
            this.txtd3mon_ing.Location = new System.Drawing.Point(140, 106);
            this.txtd3mon_ing.Name = "txtd3mon_ing";
            this.txtd3mon_ing.NeedAlert = false;
            this.txtd3mon_ing.obligatorio = true;
            this.txtd3mon_ing.ObligatorioDinamico = 1;
            this.txtd3mon_ing.MaxLength = 17;
            this.txtd3mon_ing.TipoValidacion = Controles.Validacion.Dinero;
            this.txtd3mon_ing.Size = new System.Drawing.Size(100, 20);
            this.txtd3mon_ing.TabIndex = 2;
this.lbldc2fk_cod_fac = new Controles.LabelNormalCustom();
            
            //
            // lbldc2fk_cod_fac
            //
            this.lbldc2fk_cod_fac.AutoSize = true;
            this.lbldc2fk_cod_fac.Location = new System.Drawing.Point(36, 83);
            this.lbldc2fk_cod_fac.Name = "lbldc2fk_cod_fac";
            this.lbldc2fk_cod_fac.Text = "Fk_cod_fac";

this.txtd2fk_cod_fac = new Controles.TextBoxCustom();
                        //
            // txtd2fk_cod_fac
            //
            this.txtd2fk_cod_fac.DefaultValue = "0";
            this.txtd2fk_cod_fac.Text = "0";
            this.txtd2fk_cod_fac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd2fk_cod_fac.Enabled = false;
            this.txtd2fk_cod_fac.id = "fk_cod_fac";
            this.txtd2fk_cod_fac.Limpiar = true;
            this.txtd2fk_cod_fac.Location = new System.Drawing.Point(140, 80);
            this.txtd2fk_cod_fac.Name = "txtd2fk_cod_fac";
            this.txtd2fk_cod_fac.NeedAlert = false;
            this.txtd2fk_cod_fac.obligatorio = true;
            this.txtd2fk_cod_fac.ObligatorioDinamico = 1;
            this.txtd2fk_cod_fac.MaxLength = 17;
            this.txtd2fk_cod_fac.TipoValidacion = Controles.Validacion.Enteros;
            this.txtd2fk_cod_fac.Size = new System.Drawing.Size(100, 20);
            this.txtd2fk_cod_fac.TabIndex = 1;
this.LabelN1cod_ing = new Controles.LabelNormalCustom();
            
            //
            // LabelN1cod_ing
            //
            this.LabelN1cod_ing.AutoSize = true;
            this.LabelN1cod_ing.Location = new System.Drawing.Point(36, 57);
            this.LabelN1cod_ing.Name = "LabelN1cod_ing";
            this.LabelN1cod_ing.Size = new System.Drawing.Size(15, 13);
            this.LabelN1cod_ing.Text = "Cod_ing";

this.txtd1cod_ing = new Controles.TextBoxCustom();
                        //
            // txtd1cod_ing
            //
            this.txtd1cod_ing.DefaultValue = "Nuevo";
            this.txtd1cod_ing.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd1cod_ing.Text = "NUEVO";
            this.txtd1cod_ing.Enabled = false;
            this.txtd1cod_ing.id = "cod_ing";
            this.txtd1cod_ing.Limpiar = true;
            this.txtd1cod_ing.Location = new System.Drawing.Point(140, 54);
            this.txtd1cod_ing.Name = "txtd1cod_ing";
            this.txtd1cod_ing.NeedAlert = false;
            this.txtd1cod_ing.obligatorio = false;
            this.txtd1cod_ing.ObligatorioDinamico = 1;
            this.txtd1cod_ing.DefaultEnabledFalse = true;
            this.txtd1cod_ing.Size = new System.Drawing.Size(100, 20);
            this.txtd1cod_ing.TabIndex = 0;
            this.SuspendLayout();
            // 
            // FrmMantenimientoIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 519);
            this.tabPageRegistro.Controls.Add(this.txtd1cod_ing);
            
            this.tabPageRegistro.Controls.Add(this.LabelN1cod_ing);
            
            this.tabPageRegistro.Controls.Add(this.txtd2fk_cod_fac);
            
            this.tabPageRegistro.Controls.Add(this.lbldc2fk_cod_fac);
            
            this.tabPageRegistro.Controls.Add(this.txtd3mon_ing);
            
            this.tabPageRegistro.Controls.Add(this.lbldc3mon_ing);
            
            this.tabPageRegistro.Controls.Add(this.dateCustom4fec_ing);
            
            this.tabPageRegistro.Controls.Add(this.lbldc4fec_ing);
            
            this.tabPageRegistro.Controls.Add(this.txtd5hor_ing);
            
            this.tabPageRegistro.Controls.Add(this.lbldc5hor_ing);
            
            this.tabPageRegistro.Controls.Add(this.txtd6tot_ing);
            
            this.tabPageRegistro.Controls.Add(this.lbldc6tot_ing);
            
            this.tabPageRegistro.Controls.Add(this.txtd7bal_pen_ing);
            
            this.tabPageRegistro.Controls.Add(this.lbldc7bal_pen_ing);
            
            this.txtd7bal_pen_ing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtd7bal_pen_ing_KeyPress);
            this.txtd7bal_pen_ing.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtd7bal_pen_ing_PreviewKeyDown);
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
            this.Column1.DataPropertyName = "cod_ing";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "fk_cod_fac";
            this.Column2.HeaderText = "fk_cod_fac";
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
this.Name = "FrmMantenimientoIngresos";
            this.ShowInTaskbar = false;
            this.Text = "Formulario Heredable";
            this.Load += new System.EventHandler(this.FrmMantenimientoIngresos_Load);
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
        public Controles.LabelNormalCustom lbldc7bal_pen_ing;
        public Controles.TextBoxCustom txtd7bal_pen_ing;
        public Controles.LabelNormalCustom lbldc6tot_ing;
        public Controles.TextBoxCustom txtd6tot_ing;
        public Controles.LabelNormalCustom lbldc5hor_ing;
        public Controles.TextBoxCustom txtd5hor_ing;
        public Controles.LabelNormalCustom lbldc4fec_ing;
        public Controles.dateCustom dateCustom4fec_ing;
        public Controles.LabelNormalCustom lbldc3mon_ing;
        public Controles.TextBoxCustom txtd3mon_ing;
        public Controles.LabelNormalCustom lbldc2fk_cod_fac;
        public Controles.TextBoxCustom txtd2fk_cod_fac;
        public Controles.LabelNormalCustom LabelN1cod_ing;
        public Controles.TextBoxCustom txtd1cod_ing;
    }
}