using System;
using System.Data;
using System.Windows.Forms;

namespace Parcial2_1
{
    public partial class frmPeriodos : Form
    {
        Conexion_base_datos objConexion = new Conexion_base_datos();
        DataTable periodos;

        public frmPeriodos()
        {
            InitializeComponent();
        }

        private void frmPeriodos_Load(object sender, EventArgs e)
        {
            cargarPeriodos();

            Binding enlaceId = idPeriodoLabel1.DataBindings.Add("Text", periodosBindingSource, "idPeriodo", true);
            enlaceId.Format += (s, ev) =>
            {
                if (ev.Value is int && (int)ev.Value < 0) ev.Value = "(nuevo)";
            };
            periodoTextBox.DataBindings.Add("Text", periodosBindingSource, "periodo");
            fechaDateTimePicker.DataBindings.Add("Value", periodosBindingSource, "fecha", true);
        }

        private void cargarPeriodos()
        {
            try
            {
                periodos = objConexion.crearDs().Tables["periodos"].Copy();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los períodos.\n\n" + ex.Message, "Periodos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                periodos = new DataTable();
                return;
            }

            DataColumn id = periodos.Columns["idPeriodo"];
            id.AutoIncrement = true;
            id.AutoIncrementSeed = -1;
            id.AutoIncrementStep = -1;
            periodos.Columns["fecha"].DefaultValue = DateTime.Today;
            periodos.Columns["periodo"].DefaultValue = "";

            periodosBindingSource.DataSource = periodos;
        }

        private void periodosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.periodosBindingSource.EndEdit();

            foreach (DataRow fila in periodos.Rows)
            {
                if (fila.RowState != DataRowState.Deleted && fila["periodo"].ToString().Trim() == "")
                {
                    MessageBox.Show("Todos los períodos deben tener nombre.", "Periodos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string respuesta = objConexion.guardarPeriodos(periodos);
            if (respuesta == "1")
            {
                MessageBox.Show("Cambios guardados.", "Periodos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(respuesta, "Error al guardar períodos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cargarPeriodos();
        }
    }
}
