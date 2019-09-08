namespace Discipline_Tracker
{
    partial class FormTag
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
            this.ptbCliente = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new Discipline_Tracker.TextBoxRegular();
            this.txtSiglas = new Discipline_Tracker.TextBoxRegular();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkEstado = new Discipline_Tracker.CheckBoxEstado();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoTag = new Discipline_Tracker.ComboBoxRegular();
            this.txtDescripcion = new Discipline_Tracker.TextBoxRegular();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Location = new System.Drawing.Point(731, 0);
            this.btnSalir.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardarModificar
            // 
            this.btnGuardarModificar.FlatAppearance.BorderSize = 0;
            this.btnGuardarModificar.Click += new System.EventHandler(this.btnGuardarModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 429);
            this.panel5.Size = new System.Drawing.Size(834, 75);
            // 
            // ptbListado
            // 
            this.ptbListado.Location = new System.Drawing.Point(743, 306);
            this.ptbListado.Click += new System.EventHandler(this.ptbListado_Click);
            // 
            // label8
            // 
            this.label8.Size = new System.Drawing.Size(236, 20);
            this.label8.Text = "MANTENIMIENTO DE PROFESORES";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(435, 6);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Visible = false;
            // 
            // ptbCliente
            // 
            this.ptbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbCliente.Image = global::QuickBill_SP.Properties.Resources.house;
            this.ptbCliente.Location = new System.Drawing.Point(574, 99);
            this.ptbCliente.Name = "ptbCliente";
            this.ptbCliente.Size = new System.Drawing.Size(247, 201);
            this.ptbCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCliente.TabIndex = 1;
            this.ptbCliente.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(630, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 136;
            this.label2.Text = "Curso";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.CantidadMinima = false;
            this.txtCodigo.CantMin = 0;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.DefaultLimpiarValue = "NUEVO";
            this.txtCodigo.Deshabilitar = true;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCodigo.FormatoDinero = false;
            this.txtCodigo.Habilitar = false;
            this.txtCodigo.Limpiar = true;
            this.txtCodigo.Location = new System.Drawing.Point(704, 79);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Obligatorio = false;
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(60, 17);
            this.txtCodigo.TabEnter = true;
            this.txtCodigo.TabIndex = 137;
            this.txtCodigo.Text = "NUEVO";
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigo.TipoDeValidacion = Discipline_Tracker.TiposDeValidacion.Normal;
            // 
            // txtSiglas
            // 
            this.txtSiglas.BackColor = System.Drawing.Color.White;
            this.txtSiglas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSiglas.CantidadMinima = true;
            this.txtSiglas.CantMin = 1;
            this.txtSiglas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSiglas.DefaultLimpiarValue = "";
            this.txtSiglas.Deshabilitar = true;
            this.txtSiglas.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtSiglas.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSiglas.FormatoDinero = false;
            this.txtSiglas.Habilitar = true;
            this.txtSiglas.Limpiar = true;
            this.txtSiglas.Location = new System.Drawing.Point(32, 181);
            this.txtSiglas.MaxLength = 3;
            this.txtSiglas.Name = "txtSiglas";
            this.txtSiglas.Obligatorio = true;
            this.txtSiglas.Size = new System.Drawing.Size(75, 17);
            this.txtSiglas.TabEnter = true;
            this.txtSiglas.TabIndex = 1;
            this.txtSiglas.TipoDeValidacion = Discipline_Tracker.TiposDeValidacion.Entero;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(32, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 108;
            this.label4.Text = "Siglas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(254, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 108;
            this.label7.Text = "Estado";
            // 
            // chkEstado
            // 
            this.chkEstado.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEstado.AutoSize = true;
            this.chkEstado.BackColor = System.Drawing.Color.White;
            this.chkEstado.DefaultLimpiarValue = true;
            this.chkEstado.Deshabilitar = true;
            this.chkEstado.FlatAppearance.BorderSize = 0;
            this.chkEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkEstado.ForeColor = System.Drawing.Color.Black;
            this.chkEstado.Habilitar = true;
            this.chkEstado.Limpiar = true;
            this.chkEstado.Location = new System.Drawing.Point(201, 99);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Obligatorio = true;
            this.chkEstado.Size = new System.Drawing.Size(155, 23);
            this.chkEstado.TabEnter = true;
            this.chkEstado.TabIndex = 4;
            this.chkEstado.Text = "                   Activo                 ";
            this.chkEstado.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(32, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 108;
            this.label5.Text = "Descripción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(32, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 108;
            this.label6.Text = "Profesor";
            // 
            // cmbProfesor
            // 
            this.cmbTipoTag.BackColor = System.Drawing.Color.White;
            this.cmbTipoTag.DefaultLimpiarValue = 0;
            this.cmbTipoTag.Deshabilitar = true;
            this.cmbTipoTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoTag.Font = new System.Drawing.Font("Calibri", 10F);
            this.cmbTipoTag.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbTipoTag.FormattingEnabled = true;
            this.cmbTipoTag.Habilitar = true;
            this.cmbTipoTag.Limpiar = true;
            this.cmbTipoTag.Location = new System.Drawing.Point(32, 351);
            this.cmbTipoTag.Name = "cmbProfesor";
            this.cmbTipoTag.Obligatorio = true;
            this.cmbTipoTag.Size = new System.Drawing.Size(500, 23);
            this.cmbTipoTag.TabEnter = true;
            this.cmbTipoTag.TabIndex = 162;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.CantidadMinima = true;
            this.txtDescripcion.CantMin = 1;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.DefaultLimpiarValue = "";
            this.txtDescripcion.Deshabilitar = true;
            this.txtDescripcion.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDescripcion.FormatoDinero = false;
            this.txtDescripcion.Habilitar = true;
            this.txtDescripcion.Limpiar = true;
            this.txtDescripcion.Location = new System.Drawing.Point(32, 272);
            this.txtDescripcion.MaxLength = 3;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Obligatorio = true;
            this.txtDescripcion.Size = new System.Drawing.Size(350, 17);
            this.txtDescripcion.TabEnter = true;
            this.txtDescripcion.TabIndex = 174;
            this.txtDescripcion.TipoDeValidacion = Discipline_Tracker.TiposDeValidacion.Entero;
            // 
            // FormTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.canMaximize = false;
            this.ClientSize = new System.Drawing.Size(834, 512);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cmbTipoTag);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSiglas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ptbCliente);
            this.MaximizeBox = false;
            this.Name = "FormTag";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Cliente";
            this.Load += new System.EventHandler(this.FormCurso_Load);
            this.Controls.SetChildIndex(this.ptbCliente, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtSiglas, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.ptbListado, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.chkEstado, 0);
            this.Controls.SetChildIndex(this.cmbTipoTag, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbCliente;
        public System.Windows.Forms.Label label2;
        public Discipline_Tracker.TextBoxRegular txtCodigo;
        private Discipline_Tracker.TextBoxRegular txtSiglas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private Discipline_Tracker.CheckBoxEstado chkEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private ComboBoxRegular cmbTipoTag;
        private TextBoxRegular txtDescripcion;
    }
}

