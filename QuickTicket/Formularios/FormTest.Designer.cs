namespace Discipline_Tracker
{
    partial class FormTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxRegular5 = new Discipline_Tracker.TextBoxRegular();
            this.textBoxRegular4 = new Discipline_Tracker.TextBoxRegular();
            this.textBoxRegular1 = new Discipline_Tracker.TextBoxRegular();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxRegular5
            // 
            this.textBoxRegular5.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxRegular5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegular5.CantidadMinima = false;
            this.textBoxRegular5.CantMin = 0;
            this.textBoxRegular5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxRegular5.Deshabilitar = true;
            this.textBoxRegular5.Font = new System.Drawing.Font("Calibri", 10F);
            this.textBoxRegular5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxRegular5.FormatoDinero = false;
            this.textBoxRegular5.Habilitar = true;
            this.textBoxRegular5.Location = new System.Drawing.Point(316, 293);
            this.textBoxRegular5.Name = "textBoxRegular5";
            this.textBoxRegular5.Obligatorio = true;
            this.textBoxRegular5.Size = new System.Drawing.Size(100, 17);
            this.textBoxRegular5.TabEnter = true;
            this.textBoxRegular5.TabIndex = 1;
            this.textBoxRegular5.TipoDeValidacion = Discipline_Tracker.TiposDeValidacion.Normal;
            // 
            // textBoxRegular4
            // 
            this.textBoxRegular4.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxRegular4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegular4.CantidadMinima = true;
            this.textBoxRegular4.CantMin = 5;
            this.textBoxRegular4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxRegular4.Deshabilitar = true;
            this.textBoxRegular4.Font = new System.Drawing.Font("Calibri", 10F);
            this.textBoxRegular4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxRegular4.FormatoDinero = false;
            this.textBoxRegular4.Habilitar = true;
            this.textBoxRegular4.Location = new System.Drawing.Point(240, 232);
            this.textBoxRegular4.Name = "textBoxRegular4";
            this.textBoxRegular4.Obligatorio = true;
            this.textBoxRegular4.Size = new System.Drawing.Size(100, 17);
            this.textBoxRegular4.TabEnter = true;
            this.textBoxRegular4.TabIndex = 1;
            this.textBoxRegular4.TipoDeValidacion = Discipline_Tracker.TiposDeValidacion.Normal;
            // 
            // textBoxRegular1
            // 
            this.textBoxRegular1.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxRegular1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegular1.CantidadMinima = false;
            this.textBoxRegular1.CantMin = 0;
            this.textBoxRegular1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxRegular1.Deshabilitar = true;
            this.textBoxRegular1.Font = new System.Drawing.Font("Calibri", 10F);
            this.textBoxRegular1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxRegular1.FormatoDinero = false;
            this.textBoxRegular1.Habilitar = true;
            this.textBoxRegular1.Location = new System.Drawing.Point(136, 278);
            this.textBoxRegular1.Name = "textBoxRegular1";
            this.textBoxRegular1.Obligatorio = false;
            this.textBoxRegular1.Size = new System.Drawing.Size(100, 17);
            this.textBoxRegular1.TabEnter = true;
            this.textBoxRegular1.TabIndex = 1;
            this.textBoxRegular1.TipoDeValidacion = Discipline_Tracker.TiposDeValidacion.Normal;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(77, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 112);
            this.panel1.TabIndex = 30;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 373);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxRegular5);
            this.Controls.Add(this.textBoxRegular4);
            this.Controls.Add(this.textBoxRegular1);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBoxRegular textBoxRegular1;
        private TextBoxRegular textBoxRegular4;
        private TextBoxRegular textBoxRegular5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}