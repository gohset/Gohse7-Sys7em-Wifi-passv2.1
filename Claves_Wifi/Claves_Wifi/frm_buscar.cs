using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Claves_Wifi
{
    public partial class frm_buscar : Form
    {
        public frm_buscar()
        {
            InitializeComponent();
        }

        private void frm_buscar_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.txtbox_info.Dock = DockStyle.Fill;
            this.txtbox_info.ReadOnly = true;
            //buscar_perfil();
        }

        private void buscar_perfil()
        {
            using ( Process info = new Process())
            {
                info.StartInfo.FileName = "cmd.exe";
                info.StartInfo.Arguments = "/c netsh wlan show profile "+ txt_buscar.Text +" key=clear";
                info.StartInfo.UseShellExecute = false;
                info.StartInfo.RedirectStandardOutput = true;
                info.StartInfo.CreateNoWindow = true;
                info.Start();

                StreamReader reader = info.StandardOutput;
                string salida = reader.ReadToEnd();
                //MessageBox.Show(salida);
                this.txtbox_info.Text = salida;
                //this.txtbox_info.Enabled = false;
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            buscar_perfil();
        }
    }
}
