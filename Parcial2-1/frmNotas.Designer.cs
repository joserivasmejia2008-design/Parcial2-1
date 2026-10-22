namespace Parcial2_1
{
    partial class frmNotas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle estiloNF = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloNota = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dnotasDataGridView = new System.Windows.Forms.DataGridView();
            this.alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFormula = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasDataGridView)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.SuspendLayout();

            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(94)))), ((int)(((byte)(89)))));
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Size = new System.Drawing.Size(720, 56);
            this.pnlEncabezado.TabIndex = 0;
            this.pnlEncabezado.Name = "pnlEncabezado";

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(16, 4);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Notas";
            this.lblTitulo.Name = "lblTitulo";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(238)))), ((int)(((byte)(232)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 33);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Calificaciones por materia y período  ·  USTR081726";
            this.lblSubtitulo.Name = "lblSubtitulo";

            this.lblMateria.AutoSize = true;
            this.lblMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblMateria.Location = new System.Drawing.Point(16, 72);
            this.lblMateria.Text = "Materia:";
            this.lblMateria.Name = "lblMateria";

            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.Location = new System.Drawing.Point(84, 68);
            this.cboMateria.Size = new System.Drawing.Size(250, 25);
            this.cboMateria.TabIndex = 1;
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.SelectedValueChanged += new System.EventHandler(this.cboMateria_SelectedValueChanged);

            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblPeriodo.Location = new System.Drawing.Point(352, 72);
            this.lblPeriodo.Text = "Período:";
            this.lblPeriodo.Name = "lblPeriodo";

            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.Location = new System.Drawing.Point(416, 68);
            this.cboPeriodo.Size = new System.Drawing.Size(160, 25);
            this.cboPeriodo.TabIndex = 2;
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.SelectedValueChanged += new System.EventHandler(this.cboPeriodo_SelectedValueChanged);

            this.fechaDateTimePicker.Enabled = false;
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(590, 68);
            this.fechaDateTimePicker.Size = new System.Drawing.Size(114, 25);
            this.fechaDateTimePicker.TabStop = false;
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";

            this.dnotasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alumno,
            this.idDetalle,
            this.idNota,
            this.idMateria,
            this.lab1,
            this.lab2,
            this.parcial,
            this.nota_final});
            this.dnotasDataGridView.AllowUserToAddRows = false;
            this.dnotasDataGridView.AllowUserToDeleteRows = false;
            this.dnotasDataGridView.AllowUserToResizeRows = false;
            this.dnotasDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dnotasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dnotasDataGridView.Location = new System.Drawing.Point(16, 104);
            this.dnotasDataGridView.MultiSelect = false;
            this.dnotasDataGridView.RowHeadersVisible = false;
            this.dnotasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dnotasDataGridView.Size = new System.Drawing.Size(688, 270);
            this.dnotasDataGridView.TabIndex = 20;
            this.dnotasDataGridView.Name = "dnotasDataGridView";
            this.dnotasDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dnotasDataGridView_CellValidating);
            this.dnotasDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dnotasDataGridView_DataError);

            this.alumno.DataPropertyName = "nombre";
            this.alumno.HeaderText = "Alumno";
            this.alumno.Name = "alumno";
            this.alumno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.alumno.ReadOnly = true;

            this.idDetalle.DataPropertyName = "idDetalle";
            this.idDetalle.HeaderText = "idDetalle";
            this.idDetalle.Name = "idDetalle";
            this.idDetalle.Width = 50;
            this.idDetalle.Visible = false;

            this.idNota.DataPropertyName = "idNota";
            this.idNota.HeaderText = "idNota";
            this.idNota.Name = "idNota";
            this.idNota.Width = 50;
            this.idNota.Visible = false;

            this.idMateria.DataPropertyName = "idMateria";
            this.idMateria.HeaderText = "idMateria";
            this.idMateria.Name = "idMateria";
            this.idMateria.Width = 50;
            this.idMateria.Visible = false;

            estiloNota.Format = "N2";
            this.lab1.DataPropertyName = "lab1";
            this.lab1.HeaderText = "LAB 1 (30 %)";
            this.lab1.Name = "lab1";
            this.lab1.Width = 100;
            this.lab1.DefaultCellStyle = estiloNota;

            estiloNota.Format = "N2";
            this.lab2.DataPropertyName = "lab2";
            this.lab2.HeaderText = "LAB 2 (30 %)";
            this.lab2.Name = "lab2";
            this.lab2.Width = 100;
            this.lab2.DefaultCellStyle = estiloNota;

            estiloNota.Format = "N2";
            this.parcial.DataPropertyName = "parcial";
            this.parcial.HeaderText = "Parcial (40 %)";
            this.parcial.Name = "parcial";
            this.parcial.Width = 105;
            this.parcial.DefaultCellStyle = estiloNota;

            estiloNF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            estiloNF.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estiloNF.Format = "N2";
            this.nota_final.DataPropertyName = "nf";
            this.nota_final.HeaderText = "NF";
            this.nota_final.Name = "nota_final";
            this.nota_final.Width = 70;
            this.nota_final.DefaultCellStyle = estiloNF;
            this.nota_final.ReadOnly = true;

            this.lblFormula.AutoSize = true;
            this.lblFormula.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormula.ForeColor = System.Drawing.Color.DimGray;
            this.lblFormula.Location = new System.Drawing.Point(16, 392);
            this.lblFormula.Text = "NF = LAB 1 × 30 %  +  LAB 2 × 30 %  +  PARCIAL × 40 %";
            this.lblFormula.Name = "lblFormula";

            this.btnGuardar.Location = new System.Drawing.Point(584, 384);
            this.btnGuardar.Size = new System.Drawing.Size(120, 40);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(94)))), ((int)(((byte)(89)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(720, 440);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.dnotasDataGridView);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(this.cboPeriodo);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas - USTR081726";
            this.Name = "frmNotas";
            this.Load += new System.EventHandler(this.frmNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dnotasDataGridView)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.DataGridView dnotasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab2;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota_final;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Button btnGuardar;
    }
}
