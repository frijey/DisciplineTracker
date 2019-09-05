namespace Discipline_Tracker
{
    partial class FormListadoCursos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Text = "";
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.FlatAppearance.BorderSize = 0;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // label8
            // 
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.Text = "LISTADO DE CURSOS";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToResizeColumns = false;
            this.dgvListado.AllowUserToResizeRows = false;
            this.dgvListado.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListado.ColumnHeadersHeight = 25;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre_curso,
            this.numeracion,
            this.nivel,
            this.profe});
            this.dgvListado.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListado.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListado.GridColor = System.Drawing.SystemColors.Control;
            this.dgvListado.Location = new System.Drawing.Point(0, 89);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowHeadersVisible = false;
            this.dgvListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(834, 393);
            this.dgvListado.TabIndex = 116;
            this.dgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellDoubleClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "id_curso";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 65;
            // 
            // nombre_curso
            // 
            this.nombre_curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre_curso.DataPropertyName = "nombre_curso";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.nombre_curso.DefaultCellStyle = dataGridViewCellStyle3;
            this.nombre_curso.HeaderText = "Nombre del Curso";
            this.nombre_curso.Name = "nombre_curso";
            this.nombre_curso.ReadOnly = true;
            this.nombre_curso.Width = 129;
            // 
            // numeracion
            // 
            this.numeracion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeracion.DataPropertyName = "numeracion";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.numeracion.DefaultCellStyle = dataGridViewCellStyle4;
            this.numeracion.HeaderText = "Numeración";
            this.numeracion.Name = "numeracion";
            this.numeracion.ReadOnly = true;
            // 
            // nivel
            // 
            this.nivel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nivel.DataPropertyName = "nivel";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.nivel.DefaultCellStyle = dataGridViewCellStyle5;
            this.nivel.HeaderText = "Nivel";
            this.nivel.Name = "nivel";
            this.nivel.ReadOnly = true;
            this.nivel.Width = 60;
            // 
            // profe
            // 
            this.profe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.profe.DataPropertyName = "profesor";
            this.profe.HeaderText = "Profesor";
            this.profe.Name = "profe";
            this.profe.ReadOnly = true;
            this.profe.Width = 74;
            // 
            // FormListadoCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 512);
            this.Controls.Add(this.dgvListado);
            this.Name = "FormListadoCursos";
            this.Text = "FormListClientes";
            this.Load += new System.EventHandler(this.FormListadoClientes_Load);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.dgvListado, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn profe;
    }
}