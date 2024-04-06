using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Claves_Wifi
{
    public partial class frm_perfiles : Form
    {
        public frm_perfiles()
        {
            InitializeComponent();
        }

        private void frm_perfiles_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.txtbox_info.Dock = DockStyle.Fill;
            this.txtbox_info.ReadOnly = true;
            info_perfiles();
        }

        private void info_perfiles()
        {
            using (Process info = new Process())
            {
                info.StartInfo.FileName = "cmd.exe";
                info.StartInfo.Arguments = @"/c netsh wlan show profile";
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
       
    }
}
