using System;
using System.Windows.Forms;

namespace Parcial2_1
{
    public partial class login : Form
    {
        Conexion_base_datos objConexion = new Conexion_base_datos();
        int intentos = 0;
        const int MAX_INTENTOS = 3;

        public string UsuarioIngresado { get; private set; }

        public login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text;

            if (usuario == "" || clave == "")
            {
                MessageBox.Show("Escriba el usuario y la clave.", "Acceso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool accesoPermitido;
            try
            {
                accesoPermitido = objConexion.validarUsuario(usuario, clave);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con la base de datos.\n" +
                    "Verifique que ejecutó el script SQL.\n\n" + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (accesoPermitido)
            {
                UsuarioIngresado = usuario;
                this.DialogResult = DialogResult.OK;
                return;
            }

            intentos++;
            int restantes = MAX_INTENTOS - intentos;

            if (restantes <= 0)
            {
                MessageBox.Show("Acceso denegado. Superó el número de intentos.", "Acceso denegado",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            MessageBox.Show("Acceso denegado. El usuario no está registrado o la clave es incorrecta.",
                "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            lblIntentos.Text = "Intentos restantes: " + restantes;
            txtClave.Clear();
            txtClave.Focus();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            using (frm_usuario registro = new frm_usuario(true))
            {
                if (registro.ShowDialog(this) == DialogResult.OK)
                {
                    txtUsuario.Text = registro.UsuarioRegistrado;
                    txtClave.Clear();
                    lblIntentos.Text = "";
                    txtClave.Focus();
                    MessageBox.Show("Cuenta creada. Ya puede iniciar sesión.", "Registro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
