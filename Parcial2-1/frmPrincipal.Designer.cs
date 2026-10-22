namespace Parcial2_1
{
    partial class frmPrincipal
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.ssPrincipal = new System.Windows.Forms.StatusStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslCarnet = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuPrincipal.SuspendLayout();
            this.ssPrincipal.SuspendLayout();
            this.SuspendLayout();

            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.aplicacionesToolStripMenuItem});
            this.mnuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            this.mnuPrincipal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.mnuPrincipal.Size = new System.Drawing.Size(1000, 29);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Name = "mnuPrincipal";

            this.ssPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslUsuario,
            this.tslCarnet,
            this.tslFecha});
            this.ssPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(94)))), ((int)(((byte)(89)))));
            this.ssPrincipal.Location = new System.Drawing.Point(0, 596);
            this.ssPrincipal.Size = new System.Drawing.Size(1000, 24);
            this.ssPrincipal.SizingGrip = false;
            this.ssPrincipal.TabIndex = 1;
            this.ssPrincipal.Name = "ssPrincipal";

            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Text = "&Archivo";
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";

            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);

            this.toolStripSeparator1.Name = "toolStripSeparator1";

            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);

            this.aplicacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.docentesToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.periodosToolStripMenuItem,
            this.notasToolStripMenuItem,
            this.toolStripSeparator2,
            this.usuariosToolStripMenuItem});
            this.aplicacionesToolStripMenuItem.Text = "A&plicaciones";
            this.aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";

            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);

            this.docentesToolStripMenuItem.Enabled = false;
            this.docentesToolStripMenuItem.Text = "Docentes";
            this.docentesToolStripMenuItem.ToolTipText = "La guía no incluye un formulario de docentes";
            this.docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";

            this.materiasToolStripMenuItem.Text = "Materias";
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Click += new System.EventHandler(this.materiasToolStripMenuItem_Click);

            this.periodosToolStripMenuItem.Text = "Periodos";
            this.periodosToolStripMenuItem.Name = "periodosToolStripMenuItem";
            this.periodosToolStripMenuItem.Click += new System.EventHandler(this.periodosToolStripMenuItem_Click);

            this.notasToolStripMenuItem.Text = "Notas";
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Click += new System.EventHandler(this.notasToolStripMenuItem_Click);

            this.toolStripSeparator2.Name = "toolStripSeparator2";

            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);

            this.tslUsuario.ForeColor = System.Drawing.Color.White;
            this.tslUsuario.Text = "Usuario:";

            this.tslCarnet.ForeColor = System.Drawing.Color.White;
            this.tslCarnet.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslCarnet.Text = "USTR081726";
            this.tslCarnet.Name = "tslCarnet";
            this.tslUsuario.Name = "tslUsuario";

            this.tslFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(238)))), ((int)(((byte)(232)))));
            this.tslFecha.Spring = true;
            this.tslFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tslFecha.Name = "tslFecha";

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.ssPrincipal);
            this.Controls.Add(this.mnuPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Académico - USTR081726";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Name = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ssPrincipal.ResumeLayout(false);
            this.ssPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.StatusStrip ssPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tslUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tslFecha;
        private System.Windows.Forms.ToolStripStatusLabel tslCarnet;
    }
}
