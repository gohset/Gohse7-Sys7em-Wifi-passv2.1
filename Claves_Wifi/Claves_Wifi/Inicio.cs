using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Resources;

namespace Claves_Wifi
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            MostrarFormLogo();
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panel_menu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ptb_cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ptb_ocultar_botones_Click(object sender, EventArgs e)
        {
            //-------CON EFECTO SLIDING
            if (panel_izq.Width == 200)
            {
                this.tmContraerMenu.Start();
            }
            else if (panel_izq.Width == 55)
            {
                this.tmExpandirMenu.Start();
            }
        }

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            int x = panel_padre_centro.Location.X;
            int y = panel_padre_centro.Location.Y;
            if (panel_izq.Width >= 200)
                this.tmExpandirMenu.Stop();
            else
                panel_izq.Width = panel_izq.Width + 5;
                panel_padre_centro.Width = panel_padre_centro.Width - 5;
                panel_padre_centro.Location = new Point(x + 5, y);
        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            int x = panel_padre_centro.Location.X;
            int y = panel_padre_centro.Location.Y;
            if (panel_izq.Width <= 55)
                this.tmContraerMenu.Stop();
            else
                panel_izq.Width = panel_izq.Width - 5;
                panel_padre_centro.Width = panel_padre_centro.Width + 5;
                panel_padre_centro.Location = new Point(x - 5, y);
              
        }
        
        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.panel_padre_centro.Controls.Count > 0)
                this.panel_padre_centro.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel_padre_centro.Controls.Add(fh);
            this.panel_padre_centro.Tag = fh;
            fh.Show();
        }

        //METODO PARA MOSTRAR FORMULARIO DE LOGO Al INICIAR ----------------------------------------------------------
        private void MostrarFormLogo()
        {
            AbrirFormEnPanel(new frm_logo());
        }

        // EVENTOS DE LOS BOTONES...
        private void ptb_perfiles_MouseMove(object sender, MouseEventArgs e)
        {
            ptb_perfiles.Image = Claves_Wifi.Properties.Resources.wifi_1;
            this.toolTip1.SetToolTip(this.ptb_perfiles, "Perfiles");
        }

        private void ptb_perfiles_MouseLeave(object sender, EventArgs e)
        {
            ptb_perfiles.Image = Claves_Wifi.Properties.Resources.wifi_3;
        }

        private void ptb_buscar_perfil_MouseMove(object sender, MouseEventArgs e)
        {
            ptb_buscar_perfil.Image = Claves_Wifi.Properties.Resources.wifi2_2;
            this.toolTip1.SetToolTip(this.ptb_buscar_perfil, "Buscar Perfil");
        }

        private void ptb_buscar_perfil_MouseLeave(object sender, EventArgs e)
        {
            ptb_buscar_perfil.Image = Claves_Wifi.Properties.Resources.wifi22;
        }

        private void ptb_toda_info_MouseMove(object sender, MouseEventArgs e)
        {
            ptb_toda_info.Image = Claves_Wifi.Properties.Resources.wifi_clave22;
            this.toolTip1.SetToolTip(ptb_toda_info, "Informacion detallada");
        }

        private void ptb_toda_info_MouseLeave(object sender, EventArgs e)
        {
            ptb_toda_info.Image = Claves_Wifi.Properties.Resources.wifi_clave21;
        }

        private void ptb_perfiles_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frm_perfiles());
        }

        private void ptb_buscar_perfil_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frm_buscar());
        }

        private void ptb_toda_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opcion en desarrollo", "Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
