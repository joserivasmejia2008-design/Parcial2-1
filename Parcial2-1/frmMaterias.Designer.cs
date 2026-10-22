namespace Parcial2_1
{
    partial class frmMaterias
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
            this.grbDatosMateria = new System.Windows.Forms.GroupBox();
            this.lblIdMateria = new System.Windows.Forms.Label();
            this.idMateria = new System.Windows.Forms.Label();
            this.lblCodigoMateria = new System.Windows.Forms.Label();
            this.txtCodigoMateria = new System.Windows.Forms.TextBox();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.lblUvMateria = new System.Windows.Forms.Label();
            this.txtUvMateria = new System.Windows.Forms.TextBox();
            this.grbNavegacionMateria = new System.Windows.Forms.GroupBox();
            this.btnPrimeroMateria = new System.Windows.Forms.Button();
            this.btnAnteriorMateria = new System.Windows.Forms.Button();
            this.lblnRegistrosMateria = new System.Windows.Forms.Label();
            this.btnSiguienteMateria = new System.Windows.Forms.Button();
            this.btnUltimoMateria = new System.Windows.Forms.Button();
            this.grbEdicionMateria = new System.Windows.Forms.GroupBox();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.btnModificarMateria = new System.Windows.Forms.Button();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.lblBuscarMaterias = new System.Windows.Forms.Label();
            this.cboBuscarMaterias = new System.Windows.Forms.ComboBox();
            this.txtBuscarMaterias = new System.Windows.Forms.TextBox();
            this.grdMaterias = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterias)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.grbDatosMateria.SuspendLayout();
            this.grbNavegacionMateria.SuspendLayout();
            this.grbEdicionMateria.SuspendLayout();
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
            this.lblTitulo.Text = "Materias";
            this.lblTitulo.Name = "lblTitulo";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(238)))), ((int)(((byte)(232)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 33);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Asignaturas y unidades valorativas  ·  USTR081726";
            this.lblSubtitulo.Name = "lblSubtitulo";

            this.grbDatosMateria.Controls.Add(this.txtUvMateria);
            this.grbDatosMateria.Controls.Add(this.lblUvMateria);
            this.grbDatosMateria.Controls.Add(this.txtNombreMateria);
            this.grbDatosMateria.Controls.Add(this.lblNombreMateria);
            this.grbDatosMateria.Controls.Add(this.txtCodigoMateria);
            this.grbDatosMateria.Controls.Add(this.lblCodigoMateria);
            this.grbDatosMateria.Controls.Add(this.idMateria);
            this.grbDatosMateria.Controls.Add(this.lblIdMateria);
            this.grbDatosMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(94)))), ((int)(((byte)(89)))));
            this.grbDatosMateria.Location = new System.Drawing.Point(16, 68);
            this.grbDatosMateria.Size = new System.Drawing.Size(360, 168);
            this.grbDatosMateria.TabIndex = 1;
            this.grbDatosMateria.TabStop = false;
            this.grbDatosMateria.Text = "Datos de la materia";
            this.grbDatosMateria.Name = "grbDatosMateria";

            this.lblIdMateria.AutoSize = true;
            this.lblIdMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblIdMateria.Location = new System.Drawing.Point(16, 32);
            this.lblIdMateria.Text = "ID:";
            this.lblIdMateria.Name = "lblIdMateria";

            this.idMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            this.idMateria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.idMateria.Location = new System.Drawing.Point(110, 29);
            this.idMateria.Size = new System.Drawing.Size(90, 25);
            this.idMateria.Text = "";
            this.idMateria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.idMateria.Name = "idMateria";

            this.lblCodigoMateria.AutoSize = true;
            this.lblCodigoMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblCodigoMateria.Location = new System.Drawing.Point(16, 65);
            this.lblCodigoMateria.Text = "Código:";
            this.lblCodigoMateria.Name = "lblCodigoMateria";

            this.txtCodigoMateria.Location = new System.Drawing.Point(110, 62);
            this.txtCodigoMateria.MaxLength = 6;
            this.txtCodigoMateria.Size = new System.Drawing.Size(120, 25);
            this.txtCodigoMateria.TabIndex = 0;
            this.txtCodigoMateria.Name = "txtCodigoMateria";

            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblNombreMateria.Location = new System.Drawing.Point(16, 98);
            this.lblNombreMateria.Text = "Nombre:";
            this.lblNombreMateria.Name = "lblNombreMateria";

            this.txtNombreMateria.Location = new System.Drawing.Point(110, 95);
            this.txtNombreMateria.MaxLength = 65;
            this.txtNombreMateria.Size = new System.Drawing.Size(230, 25);
            this.txtNombreMateria.TabIndex = 1;
            this.txtNombreMateria.Name = "txtNombreMateria";

            this.lblUvMateria.AutoSize = true;
            this.lblUvMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblUvMateria.Location = new System.Drawing.Point(16, 131);
            this.lblUvMateria.Text = "UV:";
            this.lblUvMateria.Name = "lblUvMateria";

            this.txtUvMateria.Location = new System.Drawing.Point(110, 128);
            this.txtUvMateria.MaxLength = 2;
            this.txtUvMateria.Size = new System.Drawing.Size(60, 25);
            this.txtUvMateria.TabIndex = 2;
            this.txtUvMateria.Name = "txtUvMateria";

            this.grbNavegacionMateria.Controls.Add(this.btnUltimoMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnSiguienteMateria);
            this.grbNavegacionMateria.Controls.Add(this.lblnRegistrosMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnAnteriorMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnPrimeroMateria);
            this.grbNavegacionMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(94)))), ((int)(((byte)(89)))));
            this.grbNavegacionMateria.Location = new System.Drawing.Point(16, 244);
            this.grbNavegacionMateria.Size = new System.Drawing.Size(360, 66);
            this.grbNavegacionMateria.TabIndex = 2;
            this.grbNavegacionMateria.TabStop = false;
            this.grbNavegacionMateria.Text = "Navegación";
            this.grbNavegacionMateria.Name = "grbNavegacionMateria";

            this.btnPrimeroMateria.Location = new System.Drawing.Point(12, 24);
            this.btnPrimeroMateria.Size = new System.Drawing.Size(50, 30);
            this.btnPrimeroMateria.TabIndex = 0;
            this.btnPrimeroMateria.Text = "|<";
            this.btnPrimeroMateria.UseVisualStyleBackColor = true;
            this.btnPrimeroMateria.Name = "btnPrimeroMateria";
            this.btnPrimeroMateria.Click += new System.EventHandler(this.btnPrimeroMateria_Click);

            this.btnAnteriorMateria.Location = new System.Drawing.Point(66, 24);
            this.btnAnteriorMateria.Size = new System.Drawing.Size(50, 30);
            this.btnAnteriorMateria.TabIndex = 1;
            this.btnAnteriorMateria.Text = "<";
            this.btnAnteriorMateria.UseVisualStyleBackColor = true;
            this.btnAnteriorMateria.Name = "btnAnteriorMateria";
            this.btnAnteriorMateria.Click += new System.EventHandler(this.btnAnteriorMateria_Click);

            this.lblnRegistrosMateria.BackColor = System.Drawing.Color.White;
            this.lblnRegistrosMateria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnRegistrosMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblnRegistrosMateria.Location = new System.Drawing.Point(122, 24);
            this.lblnRegistrosMateria.Size = new System.Drawing.Size(116, 30);
            this.lblnRegistrosMateria.TabIndex = 2;
            this.lblnRegistrosMateria.Text = "0 de 0";
            this.lblnRegistrosMateria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblnRegistrosMateria.Name = "lblnRegistrosMateria";

            this.btnSiguienteMateria.Location = new System.Drawing.Point(244, 24);
            this.btnSiguienteMateria.Size = new System.Drawing.Size(50, 30);
            this.btnSiguienteMateria.TabIndex = 3;
            this.btnSiguienteMateria.Text = ">";
            this.btnSiguienteMateria.UseVisualStyleBackColor = true;
            this.btnSiguienteMateria.Name = "btnSiguienteMateria";
            this.btnSiguienteMateria.Click += new System.EventHandler(this.btnSiguienteMateria_Click);

            this.btnUltimoMateria.Location = new System.Drawing.Point(298, 24);
            this.btnUltimoMateria.Size = new System.Drawing.Size(50, 30);
            this.btnUltimoMateria.TabIndex = 4;
            this.btnUltimoMateria.Text = ">|";
            this.btnUltimoMateria.UseVisualStyleBackColor = true;
            this.btnUltimoMateria.Name = "btnUltimoMateria";
            this.btnUltimoMateria.Click += new System.EventHandler(this.btnUltimoMateria_Click);

            this.grbEdicionMateria.Controls.Add(this.btnEliminarMateria);
            this.grbEdicionMateria.Controls.Add(this.btnModificarMateria);
            this.grbEdicionMateria.Controls.Add(this.btnAgregarMateria);
            this.grbEdicionMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(94)))), ((int)(((byte)(89)))));
            this.grbEdicionMateria.Location = new System.Drawing.Point(16, 316);
            this.grbEdicionMateria.Size = new System.Drawing.Size(360, 72);
            this.grbEdicionMateria.TabIndex = 3;
            this.grbEdicionMateria.TabStop = false;
            this.grbEdicionMateria.Text = "Edición";
            this.grbEdicionMateria.Name = "grbEdicionMateria";

            this.btnAgregarMateria.Location = new System.Drawing.Point(12, 24);
            this.btnAgregarMateria.Size = new System.Drawing.Size(105, 36);
            this.btnAgregarMateria.TabIndex = 0;
            this.btnAgregarMateria.Text = "Nuevo";
            this.btnAgregarMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(94)))), ((int)(((byte)(89)))));
            this.btnAgregarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMateria.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMateria.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMateria.UseVisualStyleBackColor = false;
            this.btnAgregarMateria.FlatAppearance.BorderSize = 0;
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);

            this.btnModificarMateria.Location = new System.Drawing.Point(127, 24);
            this.btnModificarMateria.Size = new System.Drawing.Size(105, 36);
            this.btnModificarMateria.TabIndex = 1;
            this.btnModificarMateria.Text = "Modificar";
            this.btnModificarMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            this.btnModificarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMateria.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMateria.ForeColor = System.Drawing.Color.White;
            this.btnModificarMateria.UseVisualStyleBackColor = false;
            this.btnModificarMateria.FlatAppearance.BorderSize = 0;
            this.btnModificarMateria.Name = "btnModificarMateria";
            this.btnModificarMateria.Click += new System.EventHandler(this.btnModificarMateria_Click);

            this.btnEliminarMateria.Location = new System.Drawing.Point(242, 24);
            this.btnEliminarMateria.Size = new System.Drawing.Size(105, 36);
            this.btnEliminarMateria.TabIndex = 2;
            this.btnEliminarMateria.Text = "Eliminar";
            this.btnEliminarMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnEliminarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMateria.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMateria.ForeColor = System.Drawing.Color.White;
            this.btnEliminarMateria.UseVisualStyleBackColor = false;
            this.btnEliminarMateria.FlatAppearance.BorderSize = 0;
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Click += new System.EventHandler(this.btnEliminarMateria_Click);

            this.lblBuscarMaterias.AutoSize = true;
            this.lblBuscarMaterias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblBuscarMaterias.Location = new System.Drawing.Point(392, 68);
            this.lblBuscarMaterias.Text = "Buscar por:";
            this.lblBuscarMaterias.Name = "lblBuscarMaterias";

            this.cboBuscarMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarMaterias.Items.AddRange(new object[] {
            "Código",
            "Nombre"});
            this.cboBuscarMaterias.Location = new System.Drawing.Point(472, 65);
            this.cboBuscarMaterias.Size = new System.Drawing.Size(110, 25);
            this.cboBuscarMaterias.TabIndex = 4;
            this.cboBuscarMaterias.Name = "cboBuscarMaterias";

            this.txtBuscarMaterias.Location = new System.Drawing.Point(592, 65);
            this.txtBuscarMaterias.MaxLength = 65;
            this.txtBuscarMaterias.Size = new System.Drawing.Size(212, 25);
            this.txtBuscarMaterias.TabIndex = 5;
            this.txtBuscarMaterias.Name = "txtBuscarMaterias";
            this.txtBuscarMaterias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarMaterias_KeyUp);

            this.grdMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.colCodigo,
            this.colNombre,
            this.colUv});
            this.grdMaterias.AllowUserToAddRows = false;
            this.grdMaterias.AllowUserToDeleteRows = false;
            this.grdMaterias.AllowUserToResizeRows = false;
            this.grdMaterias.BackgroundColor = System.Drawing.Color.White;
            this.grdMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMaterias.Location = new System.Drawing.Point(392, 100);
            this.grdMaterias.MultiSelect = false;
            this.grdMaterias.RowHeadersVisible = false;
            this.grdMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMaterias.Size = new System.Drawing.Size(412, 288);
            this.grdMaterias.TabIndex = 20;
            this.grdMaterias.ReadOnly = true;
            this.grdMaterias.Name = "grdMaterias";
            this.grdMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMaterias_CellClick);

            this.id.DataPropertyName = "idMateria";
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

            this.colUv.DataPropertyName = "uv";
            this.colUv.HeaderText = "UV";
            this.colUv.Name = "colUv";
            this.colUv.Width = 55;

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(820, 404);
            this.Controls.Add(this.grdMaterias);
            this.Controls.Add(this.txtBuscarMaterias);
            this.Controls.Add(this.cboBuscarMaterias);
            this.Controls.Add(this.lblBuscarMaterias);
            this.Controls.Add(this.grbEdicionMateria);
            this.Controls.Add(this.grbNavegacionMateria);
            this.Controls.Add(this.grbDatosMateria);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materias - USTR081726";
            this.Name = "frmMaterias";
            this.Load += new System.EventHandler(this.frmMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterias)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.grbDatosMateria.ResumeLayout(false);
            this.grbDatosMateria.PerformLayout();
            this.grbNavegacionMateria.ResumeLayout(false);
            this.grbNavegacionMateria.PerformLayout();
            this.grbEdicionMateria.ResumeLayout(false);
            this.grbEdicionMateria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.GroupBox grbDatosMateria;
        private System.Windows.Forms.Label lblIdMateria;
        private System.Windows.Forms.Label idMateria;
        private System.Windows.Forms.Label lblCodigoMateria;
        private System.Windows.Forms.TextBox txtCodigoMateria;
        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.Label lblUvMateria;
        private System.Windows.Forms.TextBox txtUvMateria;
        private System.Windows.Forms.GroupBox grbNavegacionMateria;
        private System.Windows.Forms.Button btnPrimeroMateria;
        private System.Windows.Forms.Button btnAnteriorMateria;
        private System.Windows.Forms.Label lblnRegistrosMateria;
        private System.Windows.Forms.Button btnSiguienteMateria;
        private System.Windows.Forms.Button btnUltimoMateria;
        private System.Windows.Forms.GroupBox grbEdicionMateria;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.Button btnModificarMateria;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.Label lblBuscarMaterias;
        private System.Windows.Forms.ComboBox cboBuscarMaterias;
        private System.Windows.Forms.TextBox txtBuscarMaterias;
        private System.Windows.Forms.DataGridView grdMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUv;
    }
}
