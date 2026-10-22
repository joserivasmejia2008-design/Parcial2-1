using System;
using System.Data;
using System.Windows.Forms;

namespace Parcial2_1
{
    public partial class Form1 : Form
    {
        Conexion_base_datos objConexion = new Conexion_base_datos();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();
        public int posicion = 0;
        public string accion = "nuevo";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grdAlumnos.AutoGenerateColumns = false;
            estadoControles(false);
            actualizarDs();
        }

        private void actualizarDs()
        {
            try
            {
                objDs = objConexion.crearDs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los alumnos.\n\n" + ex.Message, "Alumnos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            objDt = objDs.Tables["alumnos"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idAlumno"] };
            grdAlumnos.DataSource = objDt.DefaultView;

            if (posicion > objDt.Rows.Count - 1) posicion = objDt.Rows.Count - 1;
            if (posicion < 0) posicion = 0;
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idAlumno.Text = objDt.Rows[posicion]["idAlumno"].ToString();
                txtCodigoAlumno.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreAlumno.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDireccionAlumno.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoAlumno.Text = objDt.Rows[posicion]["telefono"].ToString();
                lblnRegistrosAlumno.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
            else
            {
                limpiarControles();
                lblnRegistrosAlumno.Text = "0 de 0";
            }
        }

        private void btnPrimeroAlumno_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnAnteriorAlumno_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estás en el primer registro.", "Navegación de Alumnos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSiguienteAlumno_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estás en el último registro.", "Navegación de Alumnos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoAlumno_Click(object sender, EventArgs e)
        {
            posicion = Math.Max(objDt.Rows.Count - 1, 0);
            mostrarDatos();
        }

        private void estadoControles(bool estado)
        {
            grbDatosAlumno.Enabled = estado;
            grbNavegacionAlumno.Enabled = !estado;
            btnEliminarAlumno.Enabled = !estado;
            txtBuscarAlumnos.Enabled = !estado;
            grdAlumnos.Enabled = !estado;
        }

        private void limpiarControles()
        {
            idAlumno.Text = "";
            txtCodigoAlumno.Text = "";
            txtNombreAlumno.Text = "";
            txtDireccionAlumno.Text = "";
            txtTelefonoAlumno.Text = "";
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            if (btnAgregarAlumno.Text == "Nuevo")
            {
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
                txtCodigoAlumno.Focus();
            }
            else
            {
                if (txtCodigoAlumno.Text.Trim() == "" || txtNombreAlumno.Text.Trim() == "")
                {
                    MessageBox.Show("El código y el nombre son obligatorios.", "Alumnos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string[] alumnos =
                {
                    idAlumno.Text, txtCodigoAlumno.Text.Trim(), txtNombreAlumno.Text.Trim(),
                    txtDireccionAlumno.Text.Trim(), txtTelefonoAlumno.Text.Trim()
                };
                string respuesta = objConexion.administrarDatosAlumnos(alumnos, accion);

                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarAlumno.Text = "Nuevo";
                    btnModificarAlumno.Text = "Modificar";
                    if (accion == "nuevo") posicion = int.MaxValue;
                    actualizarDs();
                }
            }
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            if (btnModificarAlumno.Text == "Modificar")
            {
                if (objDt.Rows.Count == 0) return;
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";
            }
            else
            {
                mostrarDatos();
                estadoControles(false);
                btnAgregarAlumno.Text = "Nuevo";
                btnModificarAlumno.Text = "Modificar";
            }
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (objDt.Rows.Count == 0) return;

            if (MessageBox.Show("¿Está seguro de eliminar a " + txtNombreAlumno.Text +
                    "?\nTambién se borrarán sus notas.", "Eliminando alumnos",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string respuesta = objConexion.administrarDatosAlumnos(
                    new string[] { idAlumno.Text, "", "", "", "" }, "eliminar");

                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                }
            }
        }

        private void txtBuscarAlumnos_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBuscarAlumnos.Text);
        }

        private void filtrarDatos(string valor)
        {
            try
            {
                valor = valor.Replace("[", "").Replace("]", "").Replace("*", "").Replace("%", "").Replace("'", "''");

                DataView objDv = objDt.DefaultView;
                objDv.RowFilter = "codigo LIKE '%" + valor + "%' OR nombre LIKE '%" + valor + "%'";
                grdAlumnos.DataSource = objDv;
                seleccionarAlumno();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void seleccionarAlumno()
        {
            if (grdAlumnos.CurrentRow == null) return;

            string id = grdAlumnos.CurrentRow.Cells["id"].Value.ToString();
            DataRow fila = objDt.Rows.Find(int.Parse(id));
            if (fila == null) return;

            posicion = objDt.Rows.IndexOf(fila);
            mostrarDatos();
        }

        private void grdAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarAlumno();
        }
    }
}
