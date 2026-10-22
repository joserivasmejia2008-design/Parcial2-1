namespace Parcial2_1
{
    partial class Form1
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
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.grbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.lblIdAlumno = new System.Windows.Forms.Label();
            this.idAlumno = new System.Windows.Forms.Label();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.txtCodigoAlumno = new System.Windows.Forms.TextBox();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.lblDireccionAlumno = new System.Windows.Forms.Label();
            this.txtDireccionAlumno = new System.Windows.Forms.TextBox();
            this.lblTelefonoAlumno = new System.Windows.Forms.Label();
            this.txtTelefonoAlumno = new System.Windows.Forms.TextBox();
            this.grbNavegacionAlumno = new System.Windows.Forms.GroupBox();
            this.btnPrimeroAlumno = new System.Windows.Forms.Button();
            this.btnAnteriorAlumno = new System.Windows.Forms.Button();
            this.lblnRegistrosAlumno = new System.Windows.Forms.Label();
            this.btnSiguienteAlumno = new System.Windows.Forms.Button();
            this.btnUltimoAlumno = new System.Windows.Forms.Button();
            this.grbEdicionAlumno = new System.Windows.Forms.GroupBox();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.lblBuscarAlumnos = new System.Windows.Forms.Label();
            this.txtBuscarAlumnos = new System.Windows.Forms.TextBox();
            this.grdAlumnos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlumnos)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.grbDatosAlumno.SuspendLayout();
            this.grbNavegacionAlumno.SuspendLayout();
            this.grbEdicionAlumno.SuspendLayout();
            this.SuspendLayout();

            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(94)))), ((int)(((byte)(89)))));
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Size = new System.Drawing.Size(820, 56);
            this.pnlEncabezado.TabIndex = 0;
            this.pnlEncabezado.Name = "pnlEncabezado";

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(16, 4);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Alumnos";
            this.lblTitulo.Name = "lblTitulo";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(238)))), ((int)(((byte)(232)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 33);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Registro de estudiantes  ·  USTR081726";
            this.lblSubtitulo.Name = "lblSubtitulo";

            this.grbDatosAlumno.Controls.Add(this.txtTelefonoAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblTelefonoAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtDireccionAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblDireccionAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtNombreAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblNombreAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtCodigoAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblCodigoAlumno);
            this.grbDatosAlumno.Controls.Add(this.idAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblIdAlumno);
            this.grbDatosAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(94)))), ((int)(((byte)(89)))));
            this.grbDatosAlumno.Location = new System.Drawing.Point(16, 68);
            this.grbDatosAlumno.Size = new System.Drawing.Size(360, 202);
            this.grbDatosAlumno.TabIndex = 1;
            this.grbDatosAlumno.TabStop = false;
            this.grbDatosAlumno.Text = "Datos del alumno";
            this.grbDatosAlumno.Name = "grbDatosAlumno";

            this.lblIdAlumno.AutoSize = true;
            this.lblIdAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblIdAlumno.Location = new System.Drawing.Point(16, 32);
            this.lblIdAlumno.Text = "ID:";
            this.lblIdAlumno.Name = "lblIdAlumno";

            this.idAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            this.idAlumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.idAlumno.Location = new System.Drawing.Point(110, 29);
            this.idAlumno.Size = new System.Drawing.Size(90, 25);
            this.idAlumno.Text = "";
            this.idAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.idAlumno.Name = "idAlumno";

            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblCodigoAlumno.Location = new System.Drawing.Point(16, 65);
            this.lblCodigoAlumno.Text = "Código:";
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";

            this.txtCodigoAlumno.Location = new System.Drawing.Point(110, 62);
            this.txtCodigoAlumno.MaxLength = 10;
            this.txtCodigoAlumno.Size = new System.Drawing.Size(120, 25);
            this.txtCodigoAlumno.TabIndex = 0;
            this.txtCodigoAlumno.Name = "txtCodigoAlumno";

            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblNombreAlumno.Location = new System.Drawing.Point(16, 98);
            this.lblNombreAlumno.Text = "Nombre:";
            this.lblNombreAlumno.Name = "lblNombreAlumno";

            this.txtNombreAlumno.Location = new System.Drawing.Point(110, 95);
            this.txtNombreAlumno.MaxLength = 65;
            this.txtNombreAlumno.Size = new System.Drawing.Size(230, 25);
            this.txtNombreAlumno.TabIndex = 1;
            this.txtNombreAlumno.Name = "txtNombreAlumno";

            this.lblDireccionAlumno.AutoSize = true;
            this.lblDireccionAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblDireccionAlumno.Location = new System.Drawing.Point(16, 131);
            this.lblDireccionAlumno.Text = "Dirección:";
            this.lblDireccionAlumno.Name = "lblDireccionAlumno";

            this.txtDireccionAlumno.Location = new System.Drawing.Point(110, 128);
            this.txtDireccionAlumno.MaxLength = 85;
            this.txtDireccionAlumno.Size = new System.Drawing.Size(230, 25);
            this.txtDireccionAlumno.TabIndex = 2;
            this.txtDireccionAlumno.Name = "txtDireccionAlumno";

            this.lblTelefonoAlumno.AutoSize = true;
            this.lblTelefonoAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTelefonoAlumno.Location = new System.Drawing.Point(16, 164);
            this.lblTelefonoAlumno.Text = "Teléfono:";
            this.lblTelefonoAlumno.Name = "lblTelefonoAlumno";

            this.txtTelefonoAlumno.Location = new System.Drawing.Point(110, 161);
            this.txtTelefonoAlumno.MaxLength = 9;
            this.txtTelefonoAlumno.Size = new System.Drawing.Size(120, 25);
            this.txtTelefonoAlumno.TabIndex = 3;
            this.txtTelefonoAlumno.Name = "txtTelefonoAlumno";

            this.grbNavegacionAlumno.Controls.Add(this.btnUltimoAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnSiguienteAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.lblnRegistrosAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnAnteriorAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnPrimeroAlumno);
            this.grbNavegacionAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(94)))), ((int)(((byte)(89)))));
            this.grbNavegacionAlumno.Location = new System.Drawing.Point(16, 278);
            this.grbNavegacionAlumno.Size = new System.Drawing.Size(360, 66);
            this.grbNavegacionAlumno.TabIndex = 2;
            this.grbNavegacionAlumno.TabStop = false;
            this.grbNavegacionAlumno.Text = "Navegación";
            this.grbNavegacionAlumno.Name = "grbNavegacionAlumno";

            this.btnPrimeroAlumno.Location = new System.Drawing.Point(12, 24);
            this.btnPrimeroAlumno.Size = new System.Drawing.Size(50, 30);
            this.btnPrimeroAlumno.TabIndex = 0;
            this.btnPrimeroAlumno.Text = "|<";
            this.btnPrimeroAlumno.UseVisualStyleBackColor = true;
            this.btnPrimeroAlumno.Name = "btnPrimeroAlumno";
            this.btnPrimeroAlumno.Click += new System.EventHandler(this.btnPrimeroAlumno_Click);

            this.btnAnteriorAlumno.Location = new System.Drawing.Point(66, 24);
            this.btnAnteriorAlumno.Size = new System.Drawing.Size(50, 30);
            this.btnAnteriorAlumno.TabIndex = 1;
            this.btnAnteriorAlumno.Text = "<";
            this.btnAnteriorAlumno.UseVisualStyleBackColor = true;
            this.btnAnteriorAlumno.Name = "btnAnteriorAlumno";
            this.btnAnteriorAlumno.Click += new System.EventHandler(this.btnAnteriorAlumno_Click);

            this.lblnRegistrosAlumno.BackColor = System.Drawing.Color.White;
            this.lblnRegistrosAlumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnRegistrosAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblnRegistrosAlumno.Location = new System.Drawing.Point(122, 24);
            this.lblnRegistrosAlumno.Size = new System.Drawing.Size(116, 30);
            this.lblnRegistrosAlumno.TabIndex = 2;
            this.lblnRegistrosAlumno.Text = "0 de 0";
            this.lblnRegistrosAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblnRegistrosAlumno.Name = "lblnRegistrosAlumno";

            this.btnSiguienteAlumno.Location = new System.Drawing.Point(244, 24);
            this.btnSiguienteAlumno.Size = new System.Drawing.Size(50, 30);
            this.btnSiguienteAlumno.TabIndex = 3;
            this.btnSiguienteAlumno.Text = ">";
            this.btnSiguienteAlumno.UseVisualStyleBackColor = true;
            this.btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            this.btnSiguienteAlumno.Click += new System.EventHandler(this.btnSiguienteAlumno_Click);

            this.btnUltimoAlumno.Location = new System.Drawing.Point(298, 24);
            this.btnUltimoAlumno.Size = new System.Drawing.Size(50, 30);
            this.btnUltimoAlumno.TabIndex = 4;
            this.btnUltimoAlumno.Text = ">|";
            this.btnUltimoAlumno.UseVisualStyleBackColor = true;
            this.btnUltimoAlumno.Name = "btnUltimoAlumno";
            this.btnUltimoAlumno.Click += new System.EventHandler(this.btnUltimoAlumno_Click);

            this.grbEdicionAlumno.Controls.Add(this.btnEliminarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnModificarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnAgregarAlumno);
            this.grbEdicionAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(94)))), ((int)(((byte)(89)))));
            this.grbEdicionAlumno.Location = new System.Drawing.Point(16, 350);
            this.grbEdicionAlumno.Size = new System.Drawing.Size(360, 72);
            this.grbEdicionAlumno.TabIndex = 3;
            this.grbEdicionAlumno.TabStop = false;
            this.grbEdicionAlumno.Text = "Edición";
            this.grbEdicionAlumno.Name = "grbEdicionAlumno";

            this.btnAgregarAlumno.Location = new System.Drawing.Point(12, 24);
            this.btnAgregarAlumno.Size = new System.Drawing.Size(105, 36);
            this.btnAgregarAlumno.TabIndex = 0;
            this.btnAgregarAlumno.Text = "Nuevo";
            this.btnAgregarAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(94)))), ((int)(((byte)(89)))));
            this.btnAgregarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAlumno.UseVisualStyleBackColor = false;
            this.btnAgregarAlumno.FlatAppearance.BorderSize = 0;
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);

            this.btnModificarAlumno.Location = new System.Drawing.Point(127, 24);
            this.btnModificarAlumno.Size = new System.Drawing.Size(105, 36);
            this.btnModificarAlumno.TabIndex = 1;
            this.btnModificarAlumno.Text = "Modificar";
            this.btnModificarAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            this.btnModificarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarAlumno.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnModificarAlumno.UseVisualStyleBackColor = false;
            this.btnModificarAlumno.FlatAppearance.BorderSize = 0;
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Click += new System.EventHandler(this.btnModificarAlumno_Click);

            this.btnEliminarAlumno.Location = new System.Drawing.Point(242, 24);
            this.btnEliminarAlumno.Size = new System.Drawing.Size(105, 36);
            this.btnEliminarAlumno.TabIndex = 2;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnEliminarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnEliminarAlumno.UseVisualStyleBackColor = false;
            this.btnEliminarAlumno.FlatAppearance.BorderSize = 0;
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);

            this.lblBuscarAlumnos.AutoSize = true;
            this.lblBuscarAlumnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblBuscarAlumnos.Location = new System.Drawing.Point(392, 68);
            this.lblBuscarAlumnos.Text = "Buscar por código o nombre:";
            this.lblBuscarAlumnos.Name = "lblBuscarAlumnos";

            this.txtBuscarAlumnos.Location = new System.Drawing.Point(392, 90);
            this.txtBuscarAlumnos.MaxLength = 65;
            this.txtBuscarAlumnos.Size = new System.Drawing.Size(412, 25);
            this.txtBuscarAlumnos.TabIndex = 4;
            this.txtBuscarAlumnos.Name = "txtBuscarAlumnos";
            this.txtBuscarAlumnos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarAlumnos_KeyUp);

            this.grdAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.colCodigo,
            this.colNombre,
            this.colDireccion,
            this.colTelefono});
            this.grdAlumnos.AllowUserToAddRows = false;
            this.grdAlumnos.AllowUserToDeleteRows = false;
            this.grdAlumnos.AllowUserToResizeRows = false;
            this.grdAlumnos.BackgroundColor = System.Drawing.Color.White;
            this.grdAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAlumnos.Location = new System.Drawing.Point(392, 124);
            this.grdAlumnos.MultiSelect = false;
            this.grdAlumnos.RowHeadersVisible = false;
            this.grdAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAlumnos.Size = new System.Drawing.Size(412, 298);
            this.grdAlumnos.TabIndex = 20;
            this.grdAlumnos.ReadOnly = true;
            this.grdAlumnos.Name = "grdAlumnos";
            this.grdAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAlumnos_CellClick);

            this.id.DataPropertyName = "idAlumno";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 45;

            this.colCodigo.DataPropertyName = "codigo";
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Width = 75;

            this.colNombre.DataPropertyName = "nombre";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            this.colDireccion.DataPropertyName = "direccion";
            this.colDireccion.HeaderText = "Dirección";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            this.colTelefono.DataPropertyName = "telefono";
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Width = 80;

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(820, 438);
            this.Controls.Add(this.grdAlumnos);
            this.Controls.Add(this.txtBuscarAlumnos);
            this.Controls.Add(this.lblBuscarAlumnos);
            this.Controls.Add(this.grbEdicionAlumno);
            this.Controls.Add(this.grbNavegacionAlumno);
            this.Controls.Add(this.grbDatosAlumno);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos - USTR081726";
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAlumnos)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.grbDatosAlumno.ResumeLayout(false);
            this.grbDatosAlumno.PerformLayout();
            this.grbNavegacionAlumno.ResumeLayout(false);
            this.grbNavegacionAlumno.PerformLayout();
            this.grbEdicionAlumno.ResumeLayout(false);
            this.grbEdicionAlumno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.GroupBox grbDatosAlumno;
        private System.Windows.Forms.Label lblIdAlumno;
        private System.Windows.Forms.Label idAlumno;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Label lblDireccionAlumno;
        private System.Windows.Forms.TextBox txtDireccionAlumno;
        private System.Windows.Forms.Label lblTelefonoAlumno;
        private System.Windows.Forms.TextBox txtTelefonoAlumno;
        private System.Windows.Forms.GroupBox grbNavegacionAlumno;
        private System.Windows.Forms.Button btnPrimeroAlumno;
        private System.Windows.Forms.Button btnAnteriorAlumno;
        private System.Windows.Forms.Label lblnRegistrosAlumno;
        private System.Windows.Forms.Button btnSiguienteAlumno;
        private System.Windows.Forms.Button btnUltimoAlumno;
        private System.Windows.Forms.GroupBox grbEdicionAlumno;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Label lblBuscarAlumnos;
        private System.Windows.Forms.TextBox txtBuscarAlumnos;
        private System.Windows.Forms.DataGridView grdAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
    }
}
