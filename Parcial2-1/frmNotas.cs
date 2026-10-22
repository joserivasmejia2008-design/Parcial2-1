using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Parcial2_1
{
    public partial class frmNotas : Form
    {
        Conexion_base_datos objConexion = new Conexion_base_datos();
        DataTable objNotas = new DataTable();
        bool cargando = true;

        public frmNotas()
        {
            InitializeComponent();
        }

        private void frmNotas_Load(object sender, EventArgs e)
        {
            dnotasDataGridView.AutoGenerateColumns = false;
            try
            {
                DataSet ds = objConexion.crearDs();

                cboMateria.DisplayMember = "nombre";
                cboMateria.ValueMember = "idMateria";
                cboMateria.DataSource = ds.Tables["materias"].Copy();

                cboPeriodo.DisplayMember = "periodo";
                cboPeriodo.ValueMember = "idPeriodo";
                cboPeriodo.DataSource = ds.Tables["periodos"].Copy();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar materias y períodos.\n\n" + ex.Message, "Notas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cargando = false;
            actualizarGrid();
        }

        private void actualizarDs()
        {
            if (!(cboMateria.SelectedValue is int) || !(cboPeriodo.SelectedValue is int))
            {
                objNotas = new DataTable();
                return;
            }
            objNotas = objConexion.obtenerNotas((int)cboMateria.SelectedValue, (int)cboPeriodo.SelectedValue);
        }

        private void actualizarGrid()
        {
            if (cargando) return;
            try
            {
                actualizarDs();
                dnotasDataGridView.DataSource = objNotas;

                DataRowView periodo = cboPeriodo.SelectedItem as DataRowView;
                if (periodo != null) fechaDateTimePicker.Value = (DateTime)periodo["fecha"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboMateria_SelectedValueChanged(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void cboPeriodo_SelectedValueChanged(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void dnotasDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columna = dnotasDataGridView.Columns[e.ColumnIndex].Name;
            if (columna != "lab1" && columna != "lab2" && columna != "parcial") return;

            decimal nota;
            string texto = e.FormattedValue.ToString().Replace(',', '.');
            if (!decimal.TryParse(texto, NumberStyles.Number, CultureInfo.InvariantCulture, out nota) || nota < 0 || nota > 10)
            {
                MessageBox.Show("Escriba una nota entre 0 y 10.", "Notas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void dnotasDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Valor no válido. Use números como 8.5", "Notas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            e.Cancel = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dnotasDataGridView.EndEdit();
            int nFilas = dnotasDataGridView.Rows.Count;
            int errores = 0;

            for (int i = 0; i < nFilas; i++)
            {
                DataGridViewRow fila = dnotasDataGridView.Rows[i];
                int idDetalle = Convert.ToInt32(fila.Cells["idDetalle"].Value);
                decimal lab1 = Convert.ToDecimal(fila.Cells["lab1"].Value);
                decimal lab2 = Convert.ToDecimal(fila.Cells["lab2"].Value);
                decimal parcial = Convert.ToDecimal(fila.Cells["parcial"].Value);

                string resp = objConexion.actualizarNota(idDetalle, lab1, lab2, parcial);
                if (resp != "1")
                {
                    errores++;
                    MessageBox.Show(resp, "Error al actualizar notas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            actualizarGrid();

            if (errores == 0)
                MessageBox.Show("Notas guardadas. NF actualizada.", "Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
