namespace Discipline_Tracker
{
    partial class FormTrackerMaster
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
            this.cmbCurso = new Discipline_Tracker.ComboBoxRegular();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbEstudiante = new Discipline_Tracker.ComboBoxRegular();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.Text = "Tracker";
            // 
            // cmbCurso
            // 
            this.cmbCurso.BackColor = System.Drawing.Color.White;
            this.cmbCurso.DefaultLimpiarValue = 0;
            this.cmbCurso.Deshabilitar = true;
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCurso.Font = new System.Drawing.Font("Calibri", 10F);
            this.cmbCurso.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Habilitar = true;
            this.cmbCurso.Limpiar = true;
            this.cmbCurso.Location = new System.Drawing.Point(21, 115);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Obligatorio = true;
            this.cmbCurso.Size = new System.Drawing.Size(229, 23);
            this.cmbCurso.TabEnter = true;
            this.cmbCurso.TabIndex = 109;
            this.cmbCurso.SelectedIndexChanged += new System.EventHandler(this.cmbCurso_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(21, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 110;
            this.label5.Text = "Por Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(166, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 110;
            this.label2.Text = "Tracker";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Honeydew;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(433, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(219, 342);
            this.panel5.TabIndex = 111;
            // 
            // cmbEstudiante
            // 
            this.cmbEstudiante.BackColor = System.Drawing.Color.White;
            this.cmbEstudiante.DefaultLimpiarValue = 0;
            this.cmbEstudiante.Deshabilitar = true;
            this.cmbEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstudiante.Font = new System.Drawing.Font("Calibri", 10F);
            this.cmbEstudiante.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbEstudiante.FormattingEnabled = true;
            this.cmbEstudiante.Habilitar = true;
            this.cmbEstudiante.Limpiar = true;
            this.cmbEstudiante.Location = new System.Drawing.Point(21, 181);
            this.cmbEstudiante.Name = "cmbEstudiante";
            this.cmbEstudiante.Obligatorio = true;
            this.cmbEstudiante.Size = new System.Drawing.Size(364, 23);
            this.cmbEstudiante.TabEnter = true;
            this.cmbEstudiante.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(21, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 115;
            this.label3.Text = "Por Estudiante";
            // 
            // FormTrackerMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 382);
            this.Controls.Add(this.cmbEstudiante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Name = "FormTrackerMaster";
            this.Opacity = 1D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormTrackerMaster";
            this.Load += new System.EventHandler(this.FormTrackerMaster_Load);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmbCurso, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cmbEstudiante, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBoxRegular cmbCurso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private ComboBoxRegular cmbEstudiante;
        private System.Windows.Forms.Label label3;
    }
}