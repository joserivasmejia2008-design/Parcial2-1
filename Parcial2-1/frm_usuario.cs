using System;
using System.Data;
using System.Windows.Forms;

namespace Parcial2_1
{
    public partial class frm_usuario : Form
    {
        Conexion_base_datos objConexion = new Conexion_base_datos();
        DataTable miTabla = new DataTable();
        int posicion = 0;
        string accion = "nuevo";

        readonly bool soloRegistro;
        public string UsuarioRegistrado { get; private set; }

        public frm_usuario() : this(false)
        {
        }

        public frm_usuario(bool soloRegistro)
        {
            InitializeComponent();
            this.soloRegistro = soloRegistro;
        }

        private void frm_usuario_Load(object sender, EventArgs e)
        {
            if (soloRegistro)
            {
                Text = "Registrarse";
                lblTitulo.Text = "Crear una cuenta";
                StartPosition = FormStartPosition.CenterParent;
            }

            modoEdicion(false);
            obtenerDatos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (soloRegistro)
                DialogResult = UsuarioRegistrado != null ? DialogResult.OK : DialogResult.Cancel;
            else
                Close();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || btnNuevo.Text != "Nuevo") return;

            int id = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["colId"].Value);
            for (int i = 0; i < miTabla.Rows.Count; i++)
            {
                if (Convert.ToInt32(miTabla.Rows[i]["idUsuario"]) == id)
                {
                    posicion = i;
                    mostrarDatos();
                    return;
                }
            }
        }

        private void obtenerDatos()
        {
            try
            {
                miTabla = objConexion.crearDs().Tables["usuarios"];
                dgvUsuarios.AutoGenerateColumns = false;
                dgvUsuarios.DataSource = miTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los usuarios.\n\n" + ex.Message,
                    "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (posicion > miTabla.Rows.Count - 1) posicion = miTabla.Rows.Count - 1;
            if (posicion < 0) posicion = 0;
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            if (miTabla.Rows.Count == 0)
            {
                limpiarCajas();
                lblRegistro.Text = "No hay registros";
                return;
            }

            DataRow fila = miTabla.Rows[posicion];
            txtIdUsuario.Text = fila["idUsuario"].ToString();
            txtUsuario.Text = fila["usuario"].ToString();
            txtClave.Text = fila["clave"].ToString();
            txtConfirmar.Text = fila["clave"].ToString();
            txtNombre.Text = fila["nombre"].ToString();
            txtDireccion.Text = fila["direccion"].ToString();
            txtTelefono.Text = fila["telefono"].ToString();

            lblRegistro.Text = "Registro " + (posicion + 1) + " de " + miTabla.Rows.Count;
        }

        private void limpiarCajas()
        {
            txtIdUsuario.Text = "";
            txtUsuario.Text = "";
            txtClave.Text = "";
            txtConfirmar.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Ya está en el primer registro.", "Navegación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Ya está en el último registro.", "Navegación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            if (posicion < 0) posicion = 0;
            mostrarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "Nuevo")
            {
                accion = "nuevo";
                modoEdicion(true);
                limpiarCajas();
                txtIdUsuario.Text = "(automático)";
                txtUsuario.Focus();
            }
            else
            {
                guardar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar")
            {
                if (miTabla.Rows.Count == 0)
                {
                    MessageBox.Show("No hay registros para modificar.", "Modificar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                accion = "modificar";
                modoEdicion(true);
                txtConfirmar.Text = "";
                txtUsuario.Focus();
            }
            else
            {
                modoEdicion(false);
                mostrarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (miTabla.Rows.Count == 0) return;

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar al usuario \"" + txtUsuario.Text + "\"?",
                "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes) return;

            string[] datos = { txtIdUsuario.Text, "", "", "", "", "" };
            string resultado = objConexion.mantenimiento_usuarios_usis018804(datos, "eliminar");

            if (resultado == "1")
            {
                MessageBox.Show("Usuario eliminado.", "Eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                obtenerDatos();
            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardar()
        {
            if (!validarDatos()) return;

            string[] datos =
            {
                txtIdUsuario.Text,
                txtUsuario.Text.Trim(),
                txtClave.Text,
                txtNombre.Text.Trim(),
                txtDireccion.Text.Trim(),
                txtTelefono.Text.Trim()
            };

            string resultado = objConexion.mantenimiento_usuarios_usis018804(datos, accion);

            if (resultado == "1")
            {
                if (accion == "nuevo") UsuarioRegistrado = datos[1];

                MessageBox.Show("Datos guardados correctamente.", "Guardar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                modoEdicion(false);
                if (accion == "nuevo") posicion = int.MaxValue;
                obtenerDatos();
            }
            else
            {
                MessageBox.Show(resultado, "No se pudo guardar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarDatos()
        {
            string usuario = txtUsuario.Text.Trim();

            if (usuario.Length < 6 || usuario.Length > 16)
            {
                avisar("El usuario debe tener como mínimo 6 caracteres y como máximo 16.", txtUsuario);
                return false;
            }

            if (txtClave.Text == "")
            {
                avisar("Escriba la clave.", txtClave);
                return false;
            }

            if (txtClave.Text != txtConfirmar.Text)
            {
                avisar("La clave y su confirmación no coinciden. No se guardará.", txtConfirmar);
                return false;
            }

            bool tieneLetra = false;
            bool tieneNumero = false;
            foreach (char c in txtClave.Text)
            {
                if (char.IsLetter(c)) tieneLetra = true;
                if (char.IsDigit(c)) tieneNumero = true;
            }

            if (!tieneLetra || !tieneNumero)
            {
                avisar("La clave debe llevar letras y números. No se guardará.", txtClave);
                return false;
            }

            if (txtNombre.Text.Trim() == "")
            {
                avisar("Escriba el nombre del usuario.", txtNombre);
                return false;
            }

            return true;
        }

        private void avisar(string mensaje, TextBox caja)
        {
            MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            caja.Focus();
            caja.SelectAll();
        }

        private void modoEdicion(bool editando)
        {
            txtUsuario.ReadOnly = !editando;
            txtClave.ReadOnly = !editando;
            txtConfirmar.ReadOnly = !editando;
            txtNombre.ReadOnly = !editando;
            txtDireccion.ReadOnly = !editando;
            txtTelefono.ReadOnly = !editando;

            btnPrimero.Enabled = !editando;
            btnAnterior.Enabled = !editando;
            btnSiguiente.Enabled = !editando;
            btnUltimo.Enabled = !editando;
            btnEliminar.Enabled = !editando;

            btnNuevo.Text = editando ? "Guardar" : "Nuevo";
            btnModificar.Text = editando ? "Cancelar" : "Modificar";
        }
    }
}
