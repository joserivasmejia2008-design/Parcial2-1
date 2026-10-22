namespace Parcial2_1
{
    partial class login
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(94)))), ((int)(((byte)(89)))));
            this.pnlHeader.Controls.Add(this.lblCarnet);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(420, 68);
            this.pnlHeader.Name = "pnlHeader";

            this.lblCarnet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarnet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(238)))), ((int)(((byte)(232)))));
            this.lblCarnet.Location = new System.Drawing.Point(0, 42);
            this.lblCarnet.Size = new System.Drawing.Size(420, 20);
            this.lblCarnet.Text = "USTR081726";
            this.lblCarnet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCarnet.Name = "lblCarnet";

            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 4);
            this.lblTitulo.Size = new System.Drawing.Size(420, 40);
            this.lblTitulo.Text = "Iniciar sesión";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Name = "lblTitulo";

            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblUsuario.Location = new System.Drawing.Point(40, 82);
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.Name = "lblUsuario";

            this.txtUsuario.Location = new System.Drawing.Point(130, 79);
            this.txtUsuario.MaxLength = 35;
            this.txtUsuario.Size = new System.Drawing.Size(250, 25);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Name = "txtUsuario";

            this.lblClave.AutoSize = true;
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblClave.Location = new System.Drawing.Point(40, 122);
            this.lblClave.Text = "Clave:";
            this.lblClave.Name = "lblClave";

            this.txtClave.Location = new System.Drawing.Point(130, 119);
            this.txtClave.MaxLength = 35;
            this.txtClave.Size = new System.Drawing.Size(250, 25);
            this.txtClave.TabIndex = 1;
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.Name = "txtClave";

            this.lblIntentos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblIntentos.Location = new System.Drawing.Point(40, 150);
            this.lblIntentos.Size = new System.Drawing.Size(340, 20);
            this.lblIntentos.Text = "";
            this.lblIntentos.Name = "lblIntentos";

            this.btnIngresar.Location = new System.Drawing.Point(40, 176);
            this.btnIngresar.Size = new System.Drawing.Size(105, 36);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(94)))), ((int)(((byte)(89)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);

            this.btnRegistrarse.Location = new System.Drawing.Point(157, 176);
            this.btnRegistrarse.Size = new System.Drawing.Size(106, 36);
            this.btnRegistrarse.TabIndex = 3;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);

            this.btnSalir.Location = new System.Drawing.Point(275, 176);
            this.btnSalir.Size = new System.Drawing.Size(105, 36);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Name = "btnSalir";

            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(420, 232);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - USTR081726";
            this.MinimizeBox = false;
            this.Name = "login";
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnSalir;
    }
}
