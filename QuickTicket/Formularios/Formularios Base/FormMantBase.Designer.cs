namespace Discipline_Tracker
{
    partial class FormMantBase
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarModificar = new System.Windows.Forms.Button();
            this.ptbListado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbListado)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.Text = "MANTENIMIENTO";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(522, 6);
            this.label1.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CadetBlue;
            this.panel5.Controls.Add(this.btnSalir);
            this.panel5.Controls.Add(this.btnEliminar);
            this.panel5.Controls.Add(this.btnNuevo);
            this.panel5.Controls.Add(this.btnCancelar);
            this.panel5.Controls.Add(this.btnGuardarModificar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 528);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(842, 75);
            this.panel5.TabIndex = 105;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(739, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 75);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            this.btnSalir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickDown_Effect);
            this.btnSalir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClickUp_DesEffect);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Khaki;
            this.btnEliminar.Image = global::QuickBill_SP.Properties.Resources.eliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(558, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 75);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickDown_Effect);
            this.btnEliminar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClickUp_DesEffect);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Enabled = false;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.LightCyan;
            this.btnNuevo.Image = global::QuickBill_SP.Properties.Resources.nuevodos;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.Location = new System.Drawing.Point(398, 0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(140, 75);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickDown_Effect);
            this.btnNuevo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClickUp_DesEffect);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnCancelar.Image = global::QuickBill_SP.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(201, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(177, 75);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickDown_Effect);
            this.btnCancelar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClickUp_DesEffect);
            // 
            // btnGuardarModificar
            // 
            this.btnGuardarModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarModificar.FlatAppearance.BorderSize = 0;
            this.btnGuardarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarModificar.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarModificar.Image = global::QuickBill_SP.Properties.Resources.guardar;
            this.btnGuardarModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarModificar.Location = new System.Drawing.Point(11, 0);
            this.btnGuardarModificar.Name = "btnGuardarModificar";
            this.btnGuardarModificar.Size = new System.Drawing.Size(170, 75);
            this.btnGuardarModificar.TabIndex = 0;
            this.btnGuardarModificar.Text = "GUARDAR";
            this.btnGuardarModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarModificar.UseVisualStyleBackColor = false;
            this.btnGuardarModificar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickDown_Effect);
            this.btnGuardarModificar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClickUp_DesEffect);
            // 
            // ptbListado
            // 
            this.ptbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbListado.Image = global::QuickBill_SP.Properties.Resources.test;
            this.ptbListado.Location = new System.Drawing.Point(751, 405);
            this.ptbListado.Name = "ptbListado";
            this.ptbListado.Size = new System.Drawing.Size(85, 117);
            this.ptbListado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbListado.TabIndex = 107;
            this.ptbListado.TabStop = false;
            // 
            // FormMantBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 611);
            this.Controls.Add(this.ptbListado);
            this.Controls.Add(this.panel5);
            this.Name = "FormMantBase";
            this.Opacity = 1D;
            this.Text = "FormMantBase";
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.ptbListado, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Button btnGuardarModificar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.PictureBox ptbListado;
    }
}