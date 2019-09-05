namespace SFG
{
    partial class FrmMantenimientoProveedor
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
            this.btnGrabar.ClaseATrabajar = Controles.listado.Proveedor;
            this.btnGrabar.MyTextBoxID = this.txtd1cod_pro;
            this.btnGrabar.Procedimiento = "SentenciaProveedor";
            this.btnEliminar.ClaseATrabajar = Controles.listado.Proveedor;
            this.btnEliminar.MyTextBoxID = this.txtd1cod_pro;
            this.btnEliminar.Procedimiento = "SentenciaProveedor";
this.lbldc9rnc_pro = new Controles.LabelNormalCustom();
            
            //
            // lbldc9rnc_pro
            //
            this.lbldc9rnc_pro.AutoSize = true;
            this.lbldc9rnc_pro.Location = new System.Drawing.Point(36, 265);
            this.lbldc9rnc_pro.Name = "lbldc9rnc_pro";
            this.lbldc9rnc_pro.Text = "Rnc_pro";

this.txtd9rnc_pro = new Controles.TextBoxCustom();
                        //
            // txtd9rnc_pro
            //
            this.txtd9rnc_pro.DefaultValue = "";
            this.txtd9rnc_pro.Text = "";
            this.txtd9rnc_pro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd9rnc_pro.Enabled = false;
            this.txtd9rnc_pro.id = "rnc_pro";
            this.txtd9rnc_pro.Limpiar = true;
            this.txtd9rnc_pro.Location = new System.Drawing.Point(140, 262);
            this.txtd9rnc_pro.Name = "txtd9rnc_pro";
            this.txtd9rnc_pro.NeedAlert = false;
            this.txtd9rnc_pro.obligatorio = true;
            this.txtd9rnc_pro.ObligatorioDinamico = 1;
            this.txtd9rnc_pro.Size = new System.Drawing.Size(100, 20);
            this.txtd9rnc_pro.MaxLength = 15;
            this.txtd9rnc_pro.TabIndex = 8;
this.lbldc8ema_pro = new Controles.LabelNormalCustom();
            
            //
            // lbldc8ema_pro
            //
            this.lbldc8ema_pro.AutoSize = true;
            this.lbldc8ema_pro.Location = new System.Drawing.Point(36, 239);
            this.lbldc8ema_pro.Name = "lbldc8ema_pro";
            this.lbldc8ema_pro.Text = "Ema_pro";

this.txtd8ema_pro = new Controles.TextBoxCustom();
                        //
            // txtd8ema_pro
            //
            this.txtd8ema_pro.DefaultValue = "";
            this.txtd8ema_pro.Text = "";
            this.txtd8ema_pro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd8ema_pro.Enabled = false;
            this.txtd8ema_pro.id = "ema_pro";
            this.txtd8ema_pro.Limpiar = true;
            this.txtd8ema_pro.Location = new System.Drawing.Point(140, 236);
            this.txtd8ema_pro.Name = "txtd8ema_pro";
            this.txtd8ema_pro.NeedAlert = false;
            this.txtd8ema_pro.obligatorio = true;
            this.txtd8ema_pro.ObligatorioDinamico = 1;
            this.txtd8ema_pro.Size = new System.Drawing.Size(100, 20);
            this.txtd8ema_pro.MaxLength = 45;
            this.txtd8ema_pro.TabIndex = 7;
this.lbldc7con_pro = new Controles.LabelNormalCustom();
            
            //
            // lbldc7con_pro
            //
            this.lbldc7con_pro.AutoSize = true;
            this.lbldc7con_pro.Location = new System.Drawing.Point(36, 213);
            this.lbldc7con_pro.Name = "lbldc7con_pro";
            this.lbldc7con_pro.Text = "Con_pro";

this.txtd7con_pro = new Controles.TextBoxCustom();
                        //
            // txtd7con_pro
            //
            this.txtd7con_pro.DefaultValue = "";
            this.txtd7con_pro.Text = "";
            this.txtd7con_pro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd7con_pro.Enabled = false;
            this.txtd7con_pro.id = "con_pro";
            this.txtd7con_pro.Limpiar = true;
            this.txtd7con_pro.Location = new System.Drawing.Point(140, 210);
            this.txtd7con_pro.Name = "txtd7con_pro";
            this.txtd7con_pro.NeedAlert = false;
            this.txtd7con_pro.obligatorio = true;
            this.txtd7con_pro.ObligatorioDinamico = 1;
            this.txtd7con_pro.Size = new System.Drawing.Size(100, 20);
            this.txtd7con_pro.MaxLength = 45;
            this.txtd7con_pro.TabIndex = 6;
this.lbldc6zon_pro = new Controles.LabelNormalCustom();
            
            //
            // lbldc6zon_pro
            //
            this.lbldc6zon_pro.AutoSize = true;
            this.lbldc6zon_pro.Location = new System.Drawing.Point(36, 187);
            this.lbldc6zon_pro.Name = "lbldc6zon_pro";
            this.lbldc6zon_pro.Text = "Zon_pro";

this.txtd6zon_pro = new Controles.TextBoxCustom();
                        //
            // txtd6zon_pro
            //
            this.txtd6zon_pro.DefaultValue = "";
            this.txtd6zon_pro.Text = "";
            this.txtd6zon_pro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd6zon_pro.Enabled = false;
            this.txtd6zon_pro.id = "zon_pro";
            this.txtd6zon_pro.Limpiar = true;
            this.txtd6zon_pro.Location = new System.Drawing.Point(140, 184);
            this.txtd6zon_pro.Name = "txtd6zon_pro";
            this.txtd6zon_pro.NeedAlert = false;
            this.txtd6zon_pro.obligatorio = true;
            this.txtd6zon_pro.ObligatorioDinamico = 1;
            this.txtd6zon_pro.Size = new System.Drawing.Size(100, 20);
            this.txtd6zon_pro.MaxLength = 45;
            this.txtd6zon_pro.TabIndex = 5;
this.lbldc5sec_pro = new Controles.LabelNormalCustom();
            
            //
            // lbldc5sec_pro
            //
            this.lbldc5sec_pro.AutoSize = true;
            this.lbldc5sec_pro.Location = new System.Drawing.Point(36, 161);
            this.lbldc5sec_pro.Name = "lbldc5sec_pro";
            this.lbldc5sec_pro.Text = "Sec_pro";

this.txtd5sec_pro = new Controles.TextBoxCustom();
                        //
            // txtd5sec_pro
            //
            this.txtd5sec_pro.DefaultValue = "";
            this.txtd5sec_pro.Text = "";
            this.txtd5sec_pro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd5sec_pro.Enabled = false;
            this.txtd5sec_pro.id = "sec_pro";
            this.txtd5sec_pro.Limpiar = true;
            this.txtd5sec_pro.Location = new System.Drawing.Point(140, 158);
            this.txtd5sec_pro.Name = "txtd5sec_pro";
            this.txtd5sec_pro.NeedAlert = false;
            this.txtd5sec_pro.obligatorio = true;
            this.txtd5sec_pro.ObligatorioDinamico = 1;
            this.txtd5sec_pro.Size = new System.Drawing.Size(100, 20);
            this.txtd5sec_pro.MaxLength = 45;
            this.txtd5sec_pro.TabIndex = 4;
this.lbldc4dir_pro = new Controles.LabelNormalCustom();
            
            //
            // lbldc4dir_pro
            //
            this.lbldc4dir_pro.AutoSize = true;
            this.lbldc4dir_pro.Location = new System.Drawing.Point(36, 135);
            this.lbldc4dir_pro.Name = "lbldc4dir_pro";
            this.lbldc4dir_pro.Text = "Dir_pro";

this.txtd4dir_pro = new Controles.TextBoxCustom();
                        //
            // txtd4dir_pro
            //
            this.txtd4dir_pro.DefaultValue = "";
            this.txtd4dir_pro.Text = "";
            this.txtd4dir_pro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd4dir_pro.Enabled = false;
            this.txtd4dir_pro.id = "dir_pro";
            this.txtd4dir_pro.Limpiar = true;
            this.txtd4dir_pro.Location = new System.Drawing.Point(140, 132);
            this.txtd4dir_pro.Name = "txtd4dir_pro";
            this.txtd4dir_pro.NeedAlert = false;
            this.txtd4dir_pro.obligatorio = true;
            this.txtd4dir_pro.ObligatorioDinamico = 1;
            this.txtd4dir_pro.Size = new System.Drawing.Size(100, 20);
            this.txtd4dir_pro.MaxLength = 245;
            this.txtd4dir_pro.TabIndex = 3;
this.lbldc3tip_pro = new Controles.LabelNormalCustom();
            
            //
            // lbldc3tip_pro
            //
            this.lbldc3tip_pro.AutoSize = true;
            this.lbldc3tip_pro.Location = new System.Drawing.Point(36, 109);
            this.lbldc3tip_pro.Name = "lbldc3tip_pro";
            this.lbldc3tip_pro.Text = "Tip_pro";

this.txtd3tip_pro = new Controles.TextBoxCustom();
                        //
            // txtd3tip_pro
            //
            this.txtd3tip_pro.DefaultValue = "";
            this.txtd3tip_pro.Text = "";
            this.txtd3tip_pro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd3tip_pro.Enabled = false;
            this.txtd3tip_pro.id = "tip_pro";
            this.txtd3tip_pro.Limpiar = true;
            this.txtd3tip_pro.Location = new System.Drawing.Point(140, 106);
            this.txtd3tip_pro.Name = "txtd3tip_pro";
            this.txtd3tip_pro.NeedAlert = false;
            this.txtd3tip_pro.obligatorio = true;
            this.txtd3tip_pro.ObligatorioDinamico = 1;
            this.txtd3tip_pro.Size = new System.Drawing.Size(100, 20);
            this.txtd3tip_pro.MaxLength = 45;
            this.txtd3tip_pro.TabIndex = 2;
this.lbldc2nom_pro = new Controles.LabelNormalCustom();
            
            //
            // lbldc2nom_pro
            //
            this.lbldc2nom_pro.AutoSize = true;
            this.lbldc2nom_pro.Location = new System.Drawing.Point(36, 83);
            this.lbldc2nom_pro.Name = "lbldc2nom_pro";
            this.lbldc2nom_pro.Text = "Nom_pro";

this.txtd2nom_pro = new Controles.TextBoxCustom();
                        //
            // txtd2nom_pro
            //
            this.txtd2nom_pro.DefaultValue = "";
            this.txtd2nom_pro.Text = "";
            this.txtd2nom_pro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd2nom_pro.Enabled = false;
            this.txtd2nom_pro.id = "nom_pro";
            this.txtd2nom_pro.Limpiar = true;
            this.txtd2nom_pro.Location = new System.Drawing.Point(140, 80);
            this.txtd2nom_pro.Name = "txtd2nom_pro";
            this.txtd2nom_pro.NeedAlert = false;
            this.txtd2nom_pro.obligatorio = true;
            this.txtd2nom_pro.ObligatorioDinamico = 1;
            this.txtd2nom_pro.Size = new System.Drawing.Size(100, 20);
            this.txtd2nom_pro.MaxLength = 45;
            this.txtd2nom_pro.TabIndex = 1;
this.LabelN1cod_pro = new Controles.LabelNormalCustom();
            
            //
            // LabelN1cod_pro
            //
            this.LabelN1cod_pro.AutoSize = true;
            this.LabelN1cod_pro.Location = new System.Drawing.Point(36, 57);
            this.LabelN1cod_pro.Name = "LabelN1cod_pro";
            this.LabelN1cod_pro.Size = new System.Drawing.Size(15, 13);
            this.LabelN1cod_pro.Text = "Cod_pro";

this.txtd1cod_pro = new Controles.TextBoxCustom();
                        //
            // txtd1cod_pro
            //
            this.txtd1cod_pro.DefaultValue = "Nuevo";
            this.txtd1cod_pro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd1cod_pro.Text = "NUEVO";
            this.txtd1cod_pro.Enabled = false;
            this.txtd1cod_pro.id = "cod_pro";
            this.txtd1cod_pro.Limpiar = true;
            this.txtd1cod_pro.Location = new System.Drawing.Point(140, 54);
            this.txtd1cod_pro.Name = "txtd1cod_pro";
            this.txtd1cod_pro.NeedAlert = false;
            this.txtd1cod_pro.obligatorio = false;
            this.txtd1cod_pro.ObligatorioDinamico = 1;
            this.txtd1cod_pro.DefaultEnabledFalse = true;
            this.txtd1cod_pro.Size = new System.Drawing.Size(100, 20);
            this.txtd1cod_pro.TabIndex = 0;
            this.SuspendLayout();
            // 
            // FrmMantenimientoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 519);
            this.tabPageRegistro.Controls.Add(this.txtd1cod_pro);
            
            this.tabPageRegistro.Controls.Add(this.LabelN1cod_pro);
            
            this.tabPageRegistro.Controls.Add(this.txtd2nom_pro);
            
            this.tabPageRegistro.Controls.Add(this.lbldc2nom_pro);
            
            this.tabPageRegistro.Controls.Add(this.txtd3tip_pro);
            
            this.tabPageRegistro.Controls.Add(this.lbldc3tip_pro);
            
            this.tabPageRegistro.Controls.Add(this.txtd4dir_pro);
            
            this.tabPageRegistro.Controls.Add(this.lbldc4dir_pro);
            
            this.tabPageRegistro.Controls.Add(this.txtd5sec_pro);
            
            this.tabPageRegistro.Controls.Add(this.lbldc5sec_pro);
            
            this.tabPageRegistro.Controls.Add(this.txtd6zon_pro);
            
            this.tabPageRegistro.Controls.Add(this.lbldc6zon_pro);
            
            this.tabPageRegistro.Controls.Add(this.txtd7con_pro);
            
            this.tabPageRegistro.Controls.Add(this.lbldc7con_pro);
            
            this.tabPageRegistro.Controls.Add(this.txtd8ema_pro);
            
            this.tabPageRegistro.Controls.Add(this.lbldc8ema_pro);
            
            this.tabPageRegistro.Controls.Add(this.txtd9rnc_pro);
            
            this.tabPageRegistro.Controls.Add(this.lbldc9rnc_pro);
            
            this.txtd9rnc_pro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtd9rnc_pro_KeyPress);
            this.txtd9rnc_pro.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtd9rnc_pro_PreviewKeyDown);
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
            this.Column1.DataPropertyName = "cod_pro";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "nom_pro";
            this.Column2.HeaderText = "nom_pro";
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
this.Name = "FrmMantenimientoProveedor";
            this.ShowInTaskbar = false;
            this.Text = "Formulario Heredable";
            this.Load += new System.EventHandler(this.FrmMantenimientoProveedor_Load);
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
        public Controles.LabelNormalCustom lbldc9rnc_pro;
        public Controles.TextBoxCustom txtd9rnc_pro;
        public Controles.LabelNormalCustom lbldc8ema_pro;
        public Controles.TextBoxCustom txtd8ema_pro;
        public Controles.LabelNormalCustom lbldc7con_pro;
        public Controles.TextBoxCustom txtd7con_pro;
        public Controles.LabelNormalCustom lbldc6zon_pro;
        public Controles.TextBoxCustom txtd6zon_pro;
        public Controles.LabelNormalCustom lbldc5sec_pro;
        public Controles.TextBoxCustom txtd5sec_pro;
        public Controles.LabelNormalCustom lbldc4dir_pro;
        public Controles.TextBoxCustom txtd4dir_pro;
        public Controles.LabelNormalCustom lbldc3tip_pro;
        public Controles.TextBoxCustom txtd3tip_pro;
        public Controles.LabelNormalCustom lbldc2nom_pro;
        public Controles.TextBoxCustom txtd2nom_pro;
        public Controles.LabelNormalCustom LabelN1cod_pro;
        public Controles.TextBoxCustom txtd1cod_pro;
    }
}