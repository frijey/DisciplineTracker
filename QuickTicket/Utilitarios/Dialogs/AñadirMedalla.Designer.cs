namespace Discipline_Tracker
{
    partial class AñadirMedalla
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbTag = new Discipline_Tracker.ComboBoxRegular();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblTitulo.Location = new System.Drawing.Point(194, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(202, 29);
            this.lblTitulo.TabIndex = 111;
            this.lblTitulo.Text = "Añadir Celebracion";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(39, 108);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentario.Size = new System.Drawing.Size(512, 53);
            this.txtComentario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F);
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(53, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 111;
            this.label1.Text = "Comentario";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(83)))), ((int)(((byte)(152)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnGuardar.Location = new System.Drawing.Point(77, 172);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(215, 30);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "G U A R D A R";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnCancelar.Location = new System.Drawing.Point(298, 172);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(215, 30);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "C A N C E L A R";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(589, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 218);
            this.panel1.TabIndex = 120;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 218);
            this.panel2.TabIndex = 121;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(2, 216);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(587, 2);
            this.panel3.TabIndex = 121;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(2, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(587, 2);
            this.panel4.TabIndex = 121;
            // 
            // cmbTag
            // 
            this.cmbTag.BackColor = System.Drawing.Color.White;
            this.cmbTag.DefaultLimpiarValue = 0;
            this.cmbTag.Deshabilitar = true;
            this.cmbTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTag.Font = new System.Drawing.Font("Calibri", 10F);
            this.cmbTag.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbTag.FormattingEnabled = true;
            this.cmbTag.Habilitar = true;
            this.cmbTag.Limpiar = true;
            this.cmbTag.Location = new System.Drawing.Point(99, 51);
            this.cmbTag.Name = "cmbTag";
            this.cmbTag.Obligatorio = true;
            this.cmbTag.Size = new System.Drawing.Size(393, 23);
            this.cmbTag.TabEnter = true;
            this.cmbTag.TabIndex = 0;
            // 
            // AñadirMedalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 218);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cmbTag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(591, 218);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(591, 218);
            this.Name = "AñadirMedalla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AñadirMedalla";
            this.Load += new System.EventHandler(this.AñadirMedalla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Discipline_Tracker.ComboBoxRegular cmbTag;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}