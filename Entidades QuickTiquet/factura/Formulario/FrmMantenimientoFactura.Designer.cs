namespace SFG
{
    partial class FrmMantenimientoFactura
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
            this.btnGrabar.ClaseATrabajar = Controles.listado.Factura;
            this.btnGrabar.MyTextBoxID = this.txtd1cod_fac;
            this.btnGrabar.Procedimiento = "SentenciaFactura";
            this.btnEliminar.ClaseATrabajar = Controles.listado.Factura;
            this.btnEliminar.MyTextBoxID = this.txtd1cod_fac;
            this.btnEliminar.Procedimiento = "SentenciaFactura";
this.lbldc9tot_fac = new Controles.LabelNormalCustom();
            
            //
            // lbldc9tot_fac
            //
            this.lbldc9tot_fac.AutoSize = true;
            this.lbldc9tot_fac.Location = new System.Drawing.Point(36, 265);
            this.lbldc9tot_fac.Name = "lbldc9tot_fac";
            this.lbldc9tot_fac.Text = "Tot_fac";

this.txtd9tot_fac = new Controles.TextBoxCustom();
                        //
            // txtd9tot_fac
            //
            this.txtd9tot_fac.DefaultValue = "0.00";
            this.txtd9tot_fac.Text = "0.00";
            this.txtd9tot_fac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd9tot_fac.Enabled = false;
            this.txtd9tot_fac.id = "tot_fac";
            this.txtd9tot_fac.Limpiar = true;
            this.txtd9tot_fac.Location = new System.Drawing.Point(140, 262);
            this.txtd9tot_fac.Name = "txtd9tot_fac";
            this.txtd9tot_fac.NeedAlert = false;
            this.txtd9tot_fac.obligatorio = true;
            this.txtd9tot_fac.ObligatorioDinamico = 1;
            this.txtd9tot_fac.MaxLength = 17;
            this.txtd9tot_fac.TipoValidacion = Controles.Validacion.Dinero;
            this.txtd9tot_fac.Size = new System.Drawing.Size(100, 20);
            this.txtd9tot_fac.TabIndex = 8;
this.lbldc8des_fac = new Controles.LabelNormalCustom();
            
            //
            // lbldc8des_fac
            //
            this.lbldc8des_fac.AutoSize = true;
            this.lbldc8des_fac.Location = new System.Drawing.Point(36, 239);
            this.lbldc8des_fac.Name = "lbldc8des_fac";
            this.lbldc8des_fac.Text = "Des_fac";

this.txtd8des_fac = new Controles.TextBoxCustom();
                        //
            // txtd8des_fac
            //
            this.txtd8des_fac.DefaultValue = "0.00";
            this.txtd8des_fac.Text = "0.00";
            this.txtd8des_fac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd8des_fac.Enabled = false;
            this.txtd8des_fac.id = "des_fac";
            this.txtd8des_fac.Limpiar = true;
            this.txtd8des_fac.Location = new System.Drawing.Point(140, 236);
            this.txtd8des_fac.Name = "txtd8des_fac";
            this.txtd8des_fac.NeedAlert = false;
            this.txtd8des_fac.obligatorio = true;
            this.txtd8des_fac.ObligatorioDinamico = 1;
            this.txtd8des_fac.MaxLength = 17;
            this.txtd8des_fac.TipoValidacion = Controles.Validacion.Dinero;
            this.txtd8des_fac.Size = new System.Drawing.Size(100, 20);
            this.txtd8des_fac.TabIndex = 7;
this.lbldc7itb_fac = new Controles.LabelNormalCustom();
            
            //
            // lbldc7itb_fac
            //
            this.lbldc7itb_fac.AutoSize = true;
            this.lbldc7itb_fac.Location = new System.Drawing.Point(36, 213);
            this.lbldc7itb_fac.Name = "lbldc7itb_fac";
            this.lbldc7itb_fac.Text = "Itb_fac";

this.txtd7itb_fac = new Controles.TextBoxCustom();
                        //
            // txtd7itb_fac
            //
            this.txtd7itb_fac.DefaultValue = "0.00";
            this.txtd7itb_fac.Text = "0.00";
            this.txtd7itb_fac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd7itb_fac.Enabled = false;
            this.txtd7itb_fac.id = "itb_fac";
            this.txtd7itb_fac.Limpiar = true;
            this.txtd7itb_fac.Location = new System.Drawing.Point(140, 210);
            this.txtd7itb_fac.Name = "txtd7itb_fac";
            this.txtd7itb_fac.NeedAlert = false;
            this.txtd7itb_fac.obligatorio = true;
            this.txtd7itb_fac.ObligatorioDinamico = 1;
            this.txtd7itb_fac.MaxLength = 17;
            this.txtd7itb_fac.TipoValidacion = Controles.Validacion.Dinero;
            this.txtd7itb_fac.Size = new System.Drawing.Size(100, 20);
            this.txtd7itb_fac.TabIndex = 6;
this.lbldc6sub_tot_fac = new Controles.LabelNormalCustom();
            
            //
            // lbldc6sub_tot_fac
            //
            this.lbldc6sub_tot_fac.AutoSize = true;
            this.lbldc6sub_tot_fac.Location = new System.Drawing.Point(36, 187);
            this.lbldc6sub_tot_fac.Name = "lbldc6sub_tot_fac";
            this.lbldc6sub_tot_fac.Text = "Sub_tot_fac";

this.txtd6sub_tot_fac = new Controles.TextBoxCustom();
                        //
            // txtd6sub_tot_fac
            //
            this.txtd6sub_tot_fac.DefaultValue = "0.00";
            this.txtd6sub_tot_fac.Text = "0.00";
            this.txtd6sub_tot_fac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd6sub_tot_fac.Enabled = false;
            this.txtd6sub_tot_fac.id = "sub_tot_fac";
            this.txtd6sub_tot_fac.Limpiar = true;
            this.txtd6sub_tot_fac.Location = new System.Drawing.Point(140, 184);
            this.txtd6sub_tot_fac.Name = "txtd6sub_tot_fac";
            this.txtd6sub_tot_fac.NeedAlert = false;
            this.txtd6sub_tot_fac.obligatorio = true;
            this.txtd6sub_tot_fac.ObligatorioDinamico = 1;
            this.txtd6sub_tot_fac.MaxLength = 17;
            this.txtd6sub_tot_fac.TipoValidacion = Controles.Validacion.Dinero;
            this.txtd6sub_tot_fac.Size = new System.Drawing.Size(100, 20);
            this.txtd6sub_tot_fac.TabIndex = 5;
this.lbldc5fk_cod_cli_fac = new Controles.LabelNormalCustom();
            
            //
            // lbldc5fk_cod_cli_fac
            //
            this.lbldc5fk_cod_cli_fac.AutoSize = true;
            this.lbldc5fk_cod_cli_fac.Location = new System.Drawing.Point(36, 161);
            this.lbldc5fk_cod_cli_fac.Name = "lbldc5fk_cod_cli_fac";
            this.lbldc5fk_cod_cli_fac.Text = "Fk_cod_cli_fac";

this.txtd5fk_cod_cli_fac = new Controles.TextBoxCustom();
                        //
            // txtd5fk_cod_cli_fac
            //
            this.txtd5fk_cod_cli_fac.DefaultValue = "0";
            this.txtd5fk_cod_cli_fac.Text = "0";
            this.txtd5fk_cod_cli_fac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd5fk_cod_cli_fac.Enabled = false;
            this.txtd5fk_cod_cli_fac.id = "fk_cod_cli_fac";
            this.txtd5fk_cod_cli_fac.Limpiar = true;
            this.txtd5fk_cod_cli_fac.Location = new System.Drawing.Point(140, 158);
            this.txtd5fk_cod_cli_fac.Name = "txtd5fk_cod_cli_fac";
            this.txtd5fk_cod_cli_fac.NeedAlert = false;
            this.txtd5fk_cod_cli_fac.obligatorio = true;
            this.txtd5fk_cod_cli_fac.ObligatorioDinamico = 1;
            this.txtd5fk_cod_cli_fac.MaxLength = 17;
            this.txtd5fk_cod_cli_fac.TipoValidacion = Controles.Validacion.Enteros;
            this.txtd5fk_cod_cli_fac.Size = new System.Drawing.Size(100, 20);
            this.txtd5fk_cod_cli_fac.TabIndex = 4;
this.lbldc4tip_fac = new Controles.LabelNormalCustom();
            
            //
            // lbldc4tip_fac
            //
            this.lbldc4tip_fac.AutoSize = true;
            this.lbldc4tip_fac.Location = new System.Drawing.Point(36, 135);
            this.lbldc4tip_fac.Name = "lbldc4tip_fac";
            this.lbldc4tip_fac.Text = "Tip_fac";

this.txtd4tip_fac = new Controles.TextBoxCustom();
                        //
            // txtd4tip_fac
            //
            this.txtd4tip_fac.DefaultValue = "";
            this.txtd4tip_fac.Text = "";
            this.txtd4tip_fac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd4tip_fac.Enabled = false;
            this.txtd4tip_fac.id = "tip_fac";
            this.txtd4tip_fac.Limpiar = true;
            this.txtd4tip_fac.Location = new System.Drawing.Point(140, 132);
            this.txtd4tip_fac.Name = "txtd4tip_fac";
            this.txtd4tip_fac.NeedAlert = false;
            this.txtd4tip_fac.obligatorio = true;
            this.txtd4tip_fac.ObligatorioDinamico = 1;
            this.txtd4tip_fac.Size = new System.Drawing.Size(100, 20);
            this.txtd4tip_fac.MaxLength = 45;
            this.txtd4tip_fac.TabIndex = 3;
this.lbldc3hor_fac = new Controles.LabelNormalCustom();
            
            //
            // lbldc3hor_fac
            //
            this.lbldc3hor_fac.AutoSize = true;
            this.lbldc3hor_fac.Location = new System.Drawing.Point(36, 109);
            this.lbldc3hor_fac.Name = "lbldc3hor_fac";
            this.lbldc3hor_fac.Text = "Hor_fac";

this.txtd3hor_fac = new Controles.TextBoxCustom();
                        //
            // txtd3hor_fac
            //
            this.txtd3hor_fac.DefaultValue = "";
            this.txtd3hor_fac.Text = "";
            this.txtd3hor_fac.Enabled = false;
            this.txtd3hor_fac.id = "hor_fac";
            this.txtd3hor_fac.Limpiar = true;
            this.txtd3hor_fac.Location = new System.Drawing.Point(140, 106);
            this.txtd3hor_fac.Name = "txtd3hor_fac";
            this.txtd3hor_fac.NeedAlert = false;
            this.txtd3hor_fac.obligatorio = true;
            this.txtd3hor_fac.ObligatorioDinamico = 1;
            this.txtd3hor_fac.Size = new System.Drawing.Size(100, 20);
            this.txtd3hor_fac.TabIndex = 2;
this.lbldc2fec_fac = new Controles.LabelNormalCustom();
            
            //
            // lbldc2fec_fac
            //
            this.lbldc2fec_fac.AutoSize = true;
            this.lbldc2fec_fac.Location = new System.Drawing.Point(36, 83);
            this.lbldc2fec_fac.Name = "lbldc2fec_fac";
            this.lbldc2fec_fac.Text = "Fec_fac";

this.dateCustom2fec_fac = new Controles.dateCustom();
                        //
            // dateCustom2fec_fac
            //
            this.dateCustom2fec_fac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCustom2fec_fac.id = "fec_fac";
            this.dateCustom2fec_fac.Limpiar = true;
            this.dateCustom2fec_fac.Location = new System.Drawing.Point(140, 80);
            this.dateCustom2fec_fac.Name = "dateCustom2fec_fac";
            this.dateCustom2fec_fac.NeedAlert = false;
            this.dateCustom2fec_fac.obligatorio = true;
            this.dateCustom2fec_fac.ObligatorioDinamico = 1;
            this.dateCustom2fec_fac.Size = new System.Drawing.Size(105, 20);
            this.dateCustom2fec_fac.TabIndex = 1;
            this.dateCustom2fec_fac.Value = new System.DateTime(2019, 1, 1, 12, 00, 00, 001);
            this.dateCustom2fec_fac.Enabled = false;
this.LabelN1cod_fac = new Controles.LabelNormalCustom();
            
            //
            // LabelN1cod_fac
            //
            this.LabelN1cod_fac.AutoSize = true;
            this.LabelN1cod_fac.Location = new System.Drawing.Point(36, 57);
            this.LabelN1cod_fac.Name = "LabelN1cod_fac";
            this.LabelN1cod_fac.Size = new System.Drawing.Size(15, 13);
            this.LabelN1cod_fac.Text = "Cod_fac";

this.txtd1cod_fac = new Controles.TextBoxCustom();
                        //
            // txtd1cod_fac
            //
            this.txtd1cod_fac.DefaultValue = "Nuevo";
            this.txtd1cod_fac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtd1cod_fac.Text = "NUEVO";
            this.txtd1cod_fac.Enabled = false;
            this.txtd1cod_fac.id = "cod_fac";
            this.txtd1cod_fac.Limpiar = true;
            this.txtd1cod_fac.Location = new System.Drawing.Point(140, 54);
            this.txtd1cod_fac.Name = "txtd1cod_fac";
            this.txtd1cod_fac.NeedAlert = false;
            this.txtd1cod_fac.obligatorio = false;
            this.txtd1cod_fac.ObligatorioDinamico = 1;
            this.txtd1cod_fac.DefaultEnabledFalse = true;
            this.txtd1cod_fac.Size = new System.Drawing.Size(100, 20);
            this.txtd1cod_fac.TabIndex = 0;
            this.SuspendLayout();
            // 
            // FrmMantenimientoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 519);
            this.tabPageRegistro.Controls.Add(this.txtd1cod_fac);
            
            this.tabPageRegistro.Controls.Add(this.LabelN1cod_fac);
            
            this.tabPageRegistro.Controls.Add(this.dateCustom2fec_fac);
            
            this.tabPageRegistro.Controls.Add(this.lbldc2fec_fac);
            
            this.tabPageRegistro.Controls.Add(this.txtd3hor_fac);
            
            this.tabPageRegistro.Controls.Add(this.lbldc3hor_fac);
            
            this.tabPageRegistro.Controls.Add(this.txtd4tip_fac);
            
            this.tabPageRegistro.Controls.Add(this.lbldc4tip_fac);
            
            this.tabPageRegistro.Controls.Add(this.txtd5fk_cod_cli_fac);
            
            this.tabPageRegistro.Controls.Add(this.lbldc5fk_cod_cli_fac);
            
            this.tabPageRegistro.Controls.Add(this.txtd6sub_tot_fac);
            
            this.tabPageRegistro.Controls.Add(this.lbldc6sub_tot_fac);
            
            this.tabPageRegistro.Controls.Add(this.txtd7itb_fac);
            
            this.tabPageRegistro.Controls.Add(this.lbldc7itb_fac);
            
            this.tabPageRegistro.Controls.Add(this.txtd8des_fac);
            
            this.tabPageRegistro.Controls.Add(this.lbldc8des_fac);
            
            this.tabPageRegistro.Controls.Add(this.txtd9tot_fac);
            
            this.tabPageRegistro.Controls.Add(this.lbldc9tot_fac);
            
            this.txtd9tot_fac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtd9tot_fac_KeyPress);
            this.txtd9tot_fac.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtd9tot_fac_PreviewKeyDown);
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
            this.Column1.DataPropertyName = "cod_fac";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "fec_fac";
            this.Column2.HeaderText = "fec_fac";
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
this.Name = "FrmMantenimientoFactura";
            this.ShowInTaskbar = false;
            this.Text = "Formulario Heredable";
            this.Load += new System.EventHandler(this.FrmMantenimientoFactura_Load);
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
        public Controles.LabelNormalCustom lbldc9tot_fac;
        public Controles.TextBoxCustom txtd9tot_fac;
        public Controles.LabelNormalCustom lbldc8des_fac;
        public Controles.TextBoxCustom txtd8des_fac;
        public Controles.LabelNormalCustom lbldc7itb_fac;
        public Controles.TextBoxCustom txtd7itb_fac;
        public Controles.LabelNormalCustom lbldc6sub_tot_fac;
        public Controles.TextBoxCustom txtd6sub_tot_fac;
        public Controles.LabelNormalCustom lbldc5fk_cod_cli_fac;
        public Controles.TextBoxCustom txtd5fk_cod_cli_fac;
        public Controles.LabelNormalCustom lbldc4tip_fac;
        public Controles.TextBoxCustom txtd4tip_fac;
        public Controles.LabelNormalCustom lbldc3hor_fac;
        public Controles.TextBoxCustom txtd3hor_fac;
        public Controles.LabelNormalCustom lbldc2fec_fac;
        public Controles.dateCustom dateCustom2fec_fac;
        public Controles.LabelNormalCustom LabelN1cod_fac;
        public Controles.TextBoxCustom txtd1cod_fac;
    }
}