using System;
using System.Windows.Forms;

namespace Parcial2_1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                string usuario;
                using (login frmLogin = new login())
                {
                    if (frmLogin.ShowDialog() != DialogResult.OK) return;
                    usuario = frmLogin.UsuarioIngresado;
                }

                frmPrincipal principal = new frmPrincipal(usuario);
                Application.Run(principal);

                if (!principal.CerrarSesion) return;
            }
        }
    }
}
