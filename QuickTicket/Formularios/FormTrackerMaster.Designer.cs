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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbEstudiante = new Discipline_Tracker.ComboBoxRegular();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtTotalComp = new System.Windows.Forms.Button();
            this.txtTotalOrg = new System.Windows.Forms.Button();
            this.txtTotalCelebraciones = new System.Windows.Forms.Button();
            this.lblCurso = new System.Windows.Forms.Button();
            this.lblNombreEstudiante = new System.Windows.Forms.Button();
            this.btnAgregarDemComp = new System.Windows.Forms.Button();
            this.btnAgregarDemOrg = new System.Windows.Forms.Button();
            this.btnAgregarCelebracion = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.panel5.Controls.Add(this.txtTotalCelebraciones);
            this.panel5.Controls.Add(this.txtTotalOrg);
            this.panel5.Controls.Add(this.lblNombreEstudiante);
            this.panel5.Controls.Add(this.dateTimePicker4);
            this.panel5.Controls.Add(this.lblCurso);
            this.panel5.Controls.Add(this.txtTotalComp);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.btnAgregarCelebracion);
            this.panel5.Controls.Add(this.btnAgregarDemOrg);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.btnAgregarDemComp);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel11);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(433, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(219, 408);
            this.panel5.TabIndex = 111;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuickBill_SP.Properties.Resources.rule;
            this.pictureBox2.Location = new System.Drawing.Point(12, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
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
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(83)))), ((int)(((byte)(152)))));
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnIniciarSesion.Location = new System.Drawing.Point(134, 378);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(170, 30);
            this.btnIniciarSesion.TabIndex = 117;
            this.btnIniciarSesion.Text = "P R O C E S A R";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 10F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 318);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 24);
            this.dateTimePicker1.TabIndex = 118;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(160, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 115;
            this.label4.Text = "Rango de Fecha";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("Calibri", 10F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(232, 318);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(98, 24);
            this.dateTimePicker2.TabIndex = 118;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(212, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 19);
            this.label6.TabIndex = 115;
            this.label6.Text = "-";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(83)))), ((int)(((byte)(152)))));
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Honeydew;
            this.checkBox1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.checkBox1.Location = new System.Drawing.Point(144, 300);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 119;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("Calibri", 10F);
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(164, 255);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(98, 24);
            this.dateTimePicker3.TabIndex = 118;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(83)))), ((int)(((byte)(152)))));
            this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Honeydew;
            this.checkBox2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.checkBox2.Location = new System.Drawing.Point(144, 235);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 119;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QuickBill_SP.Properties.Resources.setting;
            this.pictureBox3.Location = new System.Drawing.Point(79, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QuickBill_SP.Properties.Resources.medal;
            this.pictureBox4.Location = new System.Drawing.Point(146, 47);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(61, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.Location = new System.Drawing.Point(10, 105);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 1);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkGray;
            this.panel7.Location = new System.Drawing.Point(25, 40);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(35, 1);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkGray;
            this.panel8.Location = new System.Drawing.Point(92, 40);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(35, 1);
            this.panel8.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkGray;
            this.panel9.Location = new System.Drawing.Point(159, 40);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(35, 1);
            this.panel9.TabIndex = 2;
            // 
            // txtTotalComp
            // 
            this.txtTotalComp.FlatAppearance.BorderSize = 0;
            this.txtTotalComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTotalComp.Font = new System.Drawing.Font("Calibri", 8F);
            this.txtTotalComp.Location = new System.Drawing.Point(12, 18);
            this.txtTotalComp.Name = "txtTotalComp";
            this.txtTotalComp.Size = new System.Drawing.Size(61, 21);
            this.txtTotalComp.TabIndex = 3;
            this.txtTotalComp.Text = "-";
            this.txtTotalComp.UseVisualStyleBackColor = true;
            // 
            // txtTotalOrg
            // 
            this.txtTotalOrg.FlatAppearance.BorderSize = 0;
            this.txtTotalOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTotalOrg.Font = new System.Drawing.Font("Calibri", 8F);
            this.txtTotalOrg.Location = new System.Drawing.Point(79, 18);
            this.txtTotalOrg.Name = "txtTotalOrg";
            this.txtTotalOrg.Size = new System.Drawing.Size(61, 21);
            this.txtTotalOrg.TabIndex = 3;
            this.txtTotalOrg.Text = "-";
            this.txtTotalOrg.UseVisualStyleBackColor = true;
            // 
            // txtTotalCelebraciones
            // 
            this.txtTotalCelebraciones.FlatAppearance.BorderSize = 0;
            this.txtTotalCelebraciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTotalCelebraciones.Font = new System.Drawing.Font("Calibri", 8F);
            this.txtTotalCelebraciones.Location = new System.Drawing.Point(146, 18);
            this.txtTotalCelebraciones.Name = "txtTotalCelebraciones";
            this.txtTotalCelebraciones.Size = new System.Drawing.Size(61, 21);
            this.txtTotalCelebraciones.TabIndex = 3;
            this.txtTotalCelebraciones.Text = "-";
            this.txtTotalCelebraciones.UseVisualStyleBackColor = true;
            // 
            // lblCurso
            // 
            this.lblCurso.FlatAppearance.BorderSize = 0;
            this.lblCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCurso.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblCurso.ForeColor = System.Drawing.Color.DimGray;
            this.lblCurso.Location = new System.Drawing.Point(12, 112);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(201, 26);
            this.lblCurso.TabIndex = 3;
            this.lblCurso.Text = "4to B (Secundaria)";
            this.lblCurso.UseVisualStyleBackColor = true;
            // 
            // lblNombreEstudiante
            // 
            this.lblNombreEstudiante.FlatAppearance.BorderSize = 0;
            this.lblNombreEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreEstudiante.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblNombreEstudiante.ForeColor = System.Drawing.Color.Black;
            this.lblNombreEstudiante.Location = new System.Drawing.Point(12, 141);
            this.lblNombreEstudiante.Name = "lblNombreEstudiante";
            this.lblNombreEstudiante.Size = new System.Drawing.Size(201, 26);
            this.lblNombreEstudiante.TabIndex = 3;
            this.lblNombreEstudiante.Text = "JOSE ANIBAL RAMOS MARTINEZ";
            this.lblNombreEstudiante.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDemComp
            // 
            this.btnAgregarDemComp.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAgregarDemComp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAgregarDemComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDemComp.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnAgregarDemComp.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarDemComp.Location = new System.Drawing.Point(12, 232);
            this.btnAgregarDemComp.Name = "btnAgregarDemComp";
            this.btnAgregarDemComp.Size = new System.Drawing.Size(198, 30);
            this.btnAgregarDemComp.TabIndex = 117;
            this.btnAgregarDemComp.Text = "Demérito de Comportamiento";
            this.btnAgregarDemComp.UseVisualStyleBackColor = false;
            // 
            // btnAgregarDemOrg
            // 
            this.btnAgregarDemOrg.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnAgregarDemOrg.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarDemOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDemOrg.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnAgregarDemOrg.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarDemOrg.Location = new System.Drawing.Point(12, 268);
            this.btnAgregarDemOrg.Name = "btnAgregarDemOrg";
            this.btnAgregarDemOrg.Size = new System.Drawing.Size(198, 30);
            this.btnAgregarDemOrg.TabIndex = 117;
            this.btnAgregarDemOrg.Text = "Demérito de Organización";
            this.btnAgregarDemOrg.UseVisualStyleBackColor = false;
            // 
            // btnAgregarCelebracion
            // 
            this.btnAgregarCelebracion.BackColor = System.Drawing.Color.White;
            this.btnAgregarCelebracion.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarCelebracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCelebracion.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnAgregarCelebracion.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCelebracion.Location = new System.Drawing.Point(12, 304);
            this.btnAgregarCelebracion.Name = "btnAgregarCelebracion";
            this.btnAgregarCelebracion.Size = new System.Drawing.Size(198, 30);
            this.btnAgregarCelebracion.TabIndex = 117;
            this.btnAgregarCelebracion.Text = "Celebración";
            this.btnAgregarCelebracion.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkGray;
            this.panel10.Location = new System.Drawing.Point(9, 170);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 1);
            this.panel10.TabIndex = 1;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Font = new System.Drawing.Font("Calibri", 10F);
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(60, 200);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(98, 24);
            this.dateTimePicker4.TabIndex = 118;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(160, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 19);
            this.label7.TabIndex = 115;
            this.label7.Text = "Rango de Fecha";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(68, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 19);
            this.label9.TabIndex = 115;
            this.label9.Text = "Agregar (+)";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DarkGray;
            this.panel11.Location = new System.Drawing.Point(9, 347);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 1);
            this.panel11.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(105)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(24, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 30);
            this.button1.TabIndex = 117;
            this.button1.Text = "-   V E R   D E T A L L E   -";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormTrackerMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 448);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.cmbEstudiante);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
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
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmbCurso, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cmbEstudiante, 0);
            this.Controls.SetChildIndex(this.btnIniciarSesion, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.dateTimePicker3, 0);
            this.Controls.SetChildIndex(this.dateTimePicker2, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.checkBox2, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button txtTotalComp;
        private System.Windows.Forms.Button txtTotalCelebraciones;
        private System.Windows.Forms.Button txtTotalOrg;
        private System.Windows.Forms.Button lblCurso;
        private System.Windows.Forms.Button lblNombreEstudiante;
        private System.Windows.Forms.Button btnAgregarCelebracion;
        private System.Windows.Forms.Button btnAgregarDemOrg;
        private System.Windows.Forms.Button btnAgregarDemComp;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button1;
    }
}