using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FenixBarberr.Presentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal;
            btnRestaurar.Visible= false;
            btnMaximizar.Visible= true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
           this.WindowState=FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Submenu.Visible = true;
        }

        private void btnOc1_Click(object sender, EventArgs e)
        {
            Submenu.Visible = false;
        }

        private void btnOc2_Click(object sender, EventArgs e)
        {
            Submenu.Visible = false;
        }

        private void btnOc3_Click(object sender, EventArgs e)
        {
            Submenu.Visible = false;
        }
    }
}
