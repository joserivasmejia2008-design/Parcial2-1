using System;
using System.Windows.Forms;

namespace Parcial2_1
{
    public partial class frmPrincipal : Form
    {
        private readonly string usuarioActual;

        public bool CerrarSesion { get; private set; }

        public frmPrincipal() : this("")
        {
        }

        public frmPrincipal(string usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tslUsuario.Text = "Usuario: " + usuarioActual;
            tslFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void abrirFormulario(Form hijo)
        {
            foreach (Form abierto in this.MdiChildren)
            {
                abierto.Close();
            }
            hijo.MdiParent = this;
            hijo.Show();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objAlumnos = new Form1();
            abrirFormulario(objAlumnos);
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterias objMaterias = new frmMaterias();
            abrirFormulario(objMaterias);
        }

        private void periodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeriodos objPeriodo = new frmPeriodos();
            abrirFormulario(objPeriodo);
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotas objNota = new frmNotas();
            abrirFormulario(objNota);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_usuario objUsuarios = new frm_usuario();
            abrirFormulario(objUsuarios);
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarSesion = true;
            Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
