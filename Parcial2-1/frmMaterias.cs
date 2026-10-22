using System;
using System.Data;
using System.Windows.Forms;

namespace Parcial2_1
{
    public partial class frmMaterias : Form
    {
        Conexion_base_datos objConexion = new Conexion_base_datos();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();
        public int posicion = 0;
        public string accion = "nuevo";

        public frmMaterias()
        {
            InitializeComponent();
        }

        private void frmMaterias_Load(object sender, EventArgs e)
        {
            grdMaterias.AutoGenerateColumns = false;
            estadoControles(false);
            actualizarDs();
            cboBuscarMaterias.SelectedIndex = 1;
        }

        private void actualizarDs()
        {
            try
            {
                objDs = objConexion.crearDs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las materias.\n\n" + ex.Message, "Materias",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            objDt = objDs.Tables["materias"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idMateria"] };
            grdMaterias.DataSource = objDt.DefaultView;

            if (posicion > objDt.Rows.Count - 1) posicion = objDt.Rows.Count - 1;
            if (posicion < 0) posicion = 0;
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idMateria.Text = objDt.Rows[posicion]["idMateria"].ToString();
                txtCodigoMateria.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreMateria.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtUvMateria.Text = objDt.Rows[posicion]["uv"].ToString();
                lblnRegistrosMateria.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
            else
            {
                limpiarControles();
                lblnRegistrosMateria.Text = "0 de 0";
            }
        }

        private void btnPrimeroMateria_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnAnteriorMateria_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estás en el primer registro.", "Navegación de Materias",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSiguienteMateria_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estás en el último registro.", "Navegación de Materias",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoMateria_Click(object sender, EventArgs e)
        {
            posicion = Math.Max(objDt.Rows.Count - 1, 0);
            mostrarDatos();
        }

        private void estadoControles(bool estado)
        {
            grbDatosMateria.Enabled = estado;
            grbNavegacionMateria.Enabled = !estado;
            btnEliminarMateria.Enabled = !estado;
            txtBuscarMaterias.Enabled = !estado;
            cboBuscarMaterias.Enabled = !estado;
            grdMaterias.Enabled = !estado;
        }

        private void limpiarControles()
        {
            idMateria.Text = "";
            txtCodigoMateria.Text = "";
            txtNombreMateria.Text = "";
            txtUvMateria.Text = "";
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            if (btnAgregarMateria.Text == "Nuevo")
            {
                btnAgregarMateria.Text = "Guardar";
                btnModificarMateria.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
                txtCodigoMateria.Focus();
            }
            else
            {
                int codigo, uv;
                if (!int.TryParse(txtCodigoMateria.Text.Trim(), out codigo) || codigo <= 0)
                {
                    MessageBox.Show("El código debe ser un número entero.", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtNombreMateria.Text.Trim() == "")
                {
                    MessageBox.Show("Escriba el nombre de la materia.", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(txtUvMateria.Text.Trim(), out uv) || uv < 1 || uv > 10)
                {
                    MessageBox.Show("Las UV deben ser un número entre 1 y 10.", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string[] materias = { idMateria.Text, codigo.ToString(), txtNombreMateria.Text.Trim(), uv.ToString() };
                string respuesta = objConexion.administrarDatosMaterias(materias, accion);

                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar materias.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarMateria.Text = "Nuevo";
                    btnModificarMateria.Text = "Modificar";
                    if (accion == "nuevo") posicion = int.MaxValue;
                    actualizarDs();
                }
            }
        }

        private void btnModificarMateria_Click(object sender, EventArgs e)
        {
            if (btnModificarMateria.Text == "Modificar")
            {
                if (objDt.Rows.Count == 0) return;
                btnAgregarMateria.Text = "Guardar";
                btnModificarMateria.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";
            }
            else
            {
                mostrarDatos();
                estadoControles(false);
                btnAgregarMateria.Text = "Nuevo";
                btnModificarMateria.Text = "Modificar";
            }
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (objDt.Rows.Count == 0) return;

            if (MessageBox.Show("¿Está seguro de eliminar la materia " + txtNombreMateria.Text +
                    "?\nTambién se borrarán las notas de esa materia.", "Eliminando materias",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string respuesta = objConexion.administrarDatosMaterias(
                    new string[] { idMateria.Text, "0", "", "0" }, "eliminar");

                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar materias.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                }
            }
        }

        private void txtBuscarMaterias_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBuscarMaterias.Text.Trim());
        }

        private void filtrarDatos(string valor)
        {
            try
            {
                DataView objDv = objDt.DefaultView;

                if (valor == "")
                {
                    objDv.RowFilter = "";
                }
                else if (cboBuscarMaterias.SelectedIndex == 0)
                {
                    int codigo;
                    objDv.RowFilter = int.TryParse(valor, out codigo) ? "codigo = " + codigo : "1 = 0";
                }
                else
                {
                    valor = valor.Replace("[", "").Replace("]", "").Replace("*", "").Replace("%", "").Replace("'", "''");
                    objDv.RowFilter = "nombre LIKE '%" + valor + "%'";
                }

                grdMaterias.DataSource = objDv;
                seleccionarMateria();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void seleccionarMateria()
        {
            if (grdMaterias.CurrentRow == null) return;

            string id = grdMaterias.CurrentRow.Cells["id"].Value.ToString();
            DataRow fila = objDt.Rows.Find(int.Parse(id));
            if (fila == null) return;

            posicion = objDt.Rows.IndexOf(fila);
            mostrarDatos();
        }

        private void grdMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarMateria();
        }
    }
}
