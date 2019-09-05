namespace Discipline_Tracker
{
    partial class FormProfesor
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new Discipline_Tracker.TextBoxRegular();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new Discipline_Tracker.TextBoxRegular();
            this.txtApellido = new Discipline_Tracker.TextBoxRegular();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkEstado = new QuickBill_SP.CheckBoxEstado();
            this.txtEmail = new Discipline_Tracker.TextBoxRegular();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContacto = new Discipline_Tracker.MaskedTextBoxRegular();
            this.label6 = new System.Windows.Forms.Label();
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
            this.ptbCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbCliente.Image = global::QuickBill_SP.Properties.Resources.teacherB;
            this.ptbCliente.Location = new System.Drawing.Point(647, 99);
            this.ptbCliente.Name = "ptbCliente";
            this.ptbCliente.Size = new System.Drawing.Size(174, 170);
            this.ptbCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCliente.TabIndex = 1;
            this.ptbCliente.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(32, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 108;
            this.label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.CantidadMinima = true;
            this.txtNombre.CantMin = 5;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.DefaultLimpiarValue = "";
            this.txtNombre.Deshabilitar = true;
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombre.FormatoDinero = false;
            this.txtNombre.Habilitar = true;
            this.txtNombre.Limpiar = true;
            this.txtNombre.Location = new System.Drawing.Point(32, 133);
            this.txtNombre.MaxLength = 45;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Obligatorio = true;
            this.txtNombre.Size = new System.Drawing.Size(259, 17);
            this.txtNombre.TabEnter = true;
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TipoDeValidacion = Discipline_Tracker.TiposDeValidacion.Normal;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(656, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 136;
            this.label2.Text = "Profesor";
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
            this.txtCodigo.Location = new System.Drawing.Point(746, 74);
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
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.CantidadMinima = true;
            this.txtApellido.CantMin = 5;
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.DefaultLimpiarValue = "";
            this.txtApellido.Deshabilitar = true;
            this.txtApellido.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtApellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtApellido.FormatoDinero = false;
            this.txtApellido.Habilitar = true;
            this.txtApellido.Limpiar = true;
            this.txtApellido.Location = new System.Drawing.Point(32, 196);
            this.txtApellido.MaxLength = 45;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Obligatorio = true;
            this.txtApellido.Size = new System.Drawing.Size(350, 17);
            this.txtApellido.TabEnter = true;
            this.txtApellido.TabIndex = 1;
            this.txtApellido.TipoDeValidacion = Discipline_Tracker.TiposDeValidacion.Normal;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(32, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 108;
            this.label4.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(254, 52);
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
            this.chkEstado.Location = new System.Drawing.Point(201, 74);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Obligatorio = true;
            this.chkEstado.Size = new System.Drawing.Size(155, 23);
            this.chkEstado.TabEnter = true;
            this.chkEstado.TabIndex = 154;
            this.chkEstado.Text = "                   Activo                 ";
            this.chkEstado.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.CantidadMinima = true;
            this.txtEmail.CantMin = 5;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.DefaultLimpiarValue = "";
            this.txtEmail.Deshabilitar = true;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEmail.FormatoDinero = false;
            this.txtEmail.Habilitar = true;
            this.txtEmail.Limpiar = true;
            this.txtEmail.Location = new System.Drawing.Point(32, 263);
            this.txtEmail.MaxLength = 45;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Obligatorio = true;
            this.txtEmail.Size = new System.Drawing.Size(350, 17);
            this.txtEmail.TabEnter = true;
            this.txtEmail.TabIndex = 0;
            this.txtEmail.TipoDeValidacion = Discipline_Tracker.TiposDeValidacion.Email;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(32, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 108;
            this.label5.Text = "Email";
            // 
            // txtContacto
            // 
            this.txtContacto.BackColor = System.Drawing.Color.White;
            this.txtContacto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContacto.CantidadMinima = true;
            this.txtContacto.CantMin = 5;
            this.txtContacto.DefaultLimpiarValue = "";
            this.txtContacto.Deshabilitar = true;
            this.txtContacto.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtContacto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtContacto.FormatoDinero = false;
            this.txtContacto.Habilitar = true;
            this.txtContacto.Limpiar = true;
            this.txtContacto.Location = new System.Drawing.Point(32, 326);
            this.txtContacto.Mask = "(999) 999-9999";
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Obligatorio = true;
            this.txtContacto.Size = new System.Drawing.Size(350, 17);
            this.txtContacto.TabEnter = true;
            this.txtContacto.TabIndex = 1;
            this.txtContacto.TipoDeValidacion = Discipline_Tracker.TiposDeValidacion.Entero;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(32, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 108;
            this.label6.Text = "Contacto";
            // 
            // FormProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.canMaximize = false;
            this.ClientSize = new System.Drawing.Size(834, 512);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.ptbCliente);
            this.MaximizeBox = false;
            this.Name = "FormProfesor";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Cliente";
            this.Controls.SetChildIndex(this.ptbCliente, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.txtContacto, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.ptbListado, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.chkEstado, 0);
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
        private System.Windows.Forms.Label label3;
        private Discipline_Tracker.TextBoxRegular txtNombre;
        public System.Windows.Forms.Label label2;
        public Discipline_Tracker.TextBoxRegular txtCodigo;
        private Discipline_Tracker.TextBoxRegular txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private QuickBill_SP.CheckBoxEstado chkEstado;
        private TextBoxRegular txtEmail;
        private System.Windows.Forms.Label label5;
        private MaskedTextBoxRegular txtContacto;
        private System.Windows.Forms.Label label6;
    }
}

