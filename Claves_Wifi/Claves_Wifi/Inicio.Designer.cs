namespace Claves_Wifi
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panel_base = new System.Windows.Forms.Panel();
            this.panel_padre_centro = new System.Windows.Forms.Panel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panel_izq = new System.Windows.Forms.Panel();
            this.tmContraerMenu = new System.Windows.Forms.Timer(this.components);
            this.tmExpandirMenu = new System.Windows.Forms.Timer(this.components);
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ptb_cerrar = new System.Windows.Forms.PictureBox();
            this.ptb_toda_info = new System.Windows.Forms.PictureBox();
            this.ptb_buscar_perfil = new System.Windows.Forms.PictureBox();
            this.ptb_perfiles = new System.Windows.Forms.PictureBox();
            this.ptb_ocultar_botones = new System.Windows.Forms.PictureBox();
            this.panel_base.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.panel_izq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_toda_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_buscar_perfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_perfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ocultar_botones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_base
            // 
            this.panel_base.Controls.Add(this.panel_padre_centro);
            this.panel_base.Controls.Add(this.panel_menu);
            this.panel_base.Controls.Add(this.panel_izq);
            this.panel_base.Location = new System.Drawing.Point(0, 0);
            this.panel_base.Name = "panel_base";
            this.panel_base.Size = new System.Drawing.Size(768, 451);
            this.panel_base.TabIndex = 0;
            // 
            // panel_padre_centro
            // 
            this.panel_padre_centro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel_padre_centro.AutoSize = true;
            this.panel_padre_centro.Location = new System.Drawing.Point(206, 52);
            this.panel_padre_centro.Name = "panel_padre_centro";
            this.panel_padre_centro.Size = new System.Drawing.Size(552, 396);
            this.panel_padre_centro.TabIndex = 2;
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.Black;
            this.panel_menu.Controls.Add(this.lbFecha);
            this.panel_menu.Controls.Add(this.lblHora);
            this.panel_menu.Controls.Add(this.ptb_cerrar);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(768, 43);
            this.panel_menu.TabIndex = 1;
            this.panel_menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_menu_MouseDown);
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(121, 9);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(224, 20);
            this.lbFecha.TabIndex = 5;
            this.lbFecha.Text = "Lunes, 26 de septiembre 2018";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.Location = new System.Drawing.Point(12, 7);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(103, 29);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "21:49:45";
            // 
            // panel_izq
            // 
            this.panel_izq.BackColor = System.Drawing.Color.Indigo;
            this.panel_izq.Controls.Add(this.ptb_toda_info);
            this.panel_izq.Controls.Add(this.ptb_buscar_perfil);
            this.panel_izq.Controls.Add(this.ptb_perfiles);
            this.panel_izq.Controls.Add(this.ptb_ocultar_botones);
            this.panel_izq.Location = new System.Drawing.Point(0, 49);
            this.panel_izq.Name = "panel_izq";
            this.panel_izq.Size = new System.Drawing.Size(200, 402);
            this.panel_izq.TabIndex = 0;
            // 
            // tmContraerMenu
            // 
            this.tmContraerMenu.Interval = 10;
            this.tmContraerMenu.Tick += new System.EventHandler(this.tmContraerMenu_Tick);
            // 
            // tmExpandirMenu
            // 
            this.tmExpandirMenu.Interval = 10;
            this.tmExpandirMenu.Tick += new System.EventHandler(this.tmExpandirMenu_Tick);
            // 
            // tmFechaHora
            // 
            this.tmFechaHora.Enabled = true;
            this.tmFechaHora.Tick += new System.EventHandler(this.tmFechaHora_Tick);
            // 
            // ptb_cerrar
            // 
            this.ptb_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("ptb_cerrar.Image")));
            this.ptb_cerrar.Location = new System.Drawing.Point(717, 7);
            this.ptb_cerrar.Name = "ptb_cerrar";
            this.ptb_cerrar.Size = new System.Drawing.Size(31, 27);
            this.ptb_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_cerrar.TabIndex = 3;
            this.ptb_cerrar.TabStop = false;
            this.ptb_cerrar.Click += new System.EventHandler(this.ptb_cerrar_Click);
            // 
            // ptb_toda_info
            // 
            this.ptb_toda_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_toda_info.Image = global::Claves_Wifi.Properties.Resources.wifi_clave21;
            this.ptb_toda_info.Location = new System.Drawing.Point(39, 301);
            this.ptb_toda_info.Name = "ptb_toda_info";
            this.ptb_toda_info.Size = new System.Drawing.Size(102, 85);
            this.ptb_toda_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_toda_info.TabIndex = 5;
            this.ptb_toda_info.TabStop = false;
            this.ptb_toda_info.Click += new System.EventHandler(this.ptb_toda_info_Click);
            this.ptb_toda_info.MouseLeave += new System.EventHandler(this.ptb_toda_info_MouseLeave);
            this.ptb_toda_info.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptb_toda_info_MouseMove);
            // 
            // ptb_buscar_perfil
            // 
            this.ptb_buscar_perfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_buscar_perfil.Image = ((System.Drawing.Image)(resources.GetObject("ptb_buscar_perfil.Image")));
            this.ptb_buscar_perfil.Location = new System.Drawing.Point(39, 192);
            this.ptb_buscar_perfil.Name = "ptb_buscar_perfil";
            this.ptb_buscar_perfil.Size = new System.Drawing.Size(102, 85);
            this.ptb_buscar_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_buscar_perfil.TabIndex = 4;
            this.ptb_buscar_perfil.TabStop = false;
            this.ptb_buscar_perfil.Click += new System.EventHandler(this.ptb_buscar_perfil_Click);
            this.ptb_buscar_perfil.MouseLeave += new System.EventHandler(this.ptb_buscar_perfil_MouseLeave);
            this.ptb_buscar_perfil.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptb_buscar_perfil_MouseMove);
            // 
            // ptb_perfiles
            // 
            this.ptb_perfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_perfiles.Image = global::Claves_Wifi.Properties.Resources.wifi_3;
            this.ptb_perfiles.Location = new System.Drawing.Point(39, 86);
            this.ptb_perfiles.Name = "ptb_perfiles";
            this.ptb_perfiles.Size = new System.Drawing.Size(102, 85);
            this.ptb_perfiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_perfiles.TabIndex = 3;
            this.ptb_perfiles.TabStop = false;
            this.ptb_perfiles.Click += new System.EventHandler(this.ptb_perfiles_Click);
            this.ptb_perfiles.MouseLeave += new System.EventHandler(this.ptb_perfiles_MouseLeave);
            this.ptb_perfiles.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptb_perfiles_MouseMove);
            // 
            // ptb_ocultar_botones
            // 
            this.ptb_ocultar_botones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_ocultar_botones.Image = ((System.Drawing.Image)(resources.GetObject("ptb_ocultar_botones.Image")));
            this.ptb_ocultar_botones.Location = new System.Drawing.Point(153, 3);
            this.ptb_ocultar_botones.Name = "ptb_ocultar_botones";
            this.ptb_ocultar_botones.Size = new System.Drawing.Size(41, 41);
            this.ptb_ocultar_botones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_ocultar_botones.TabIndex = 2;
            this.ptb_ocultar_botones.TabStop = false;
            this.ptb_ocultar_botones.Click += new System.EventHandler(this.ptb_ocultar_botones_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.panel_base);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.panel_base.ResumeLayout(false);
            this.panel_base.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel_izq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_toda_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_buscar_perfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_perfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ocultar_botones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_base;
        private System.Windows.Forms.Panel panel_izq;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.PictureBox ptb_cerrar;
        private System.Windows.Forms.PictureBox ptb_ocultar_botones;
        private System.Windows.Forms.PictureBox ptb_perfiles;
        private System.Windows.Forms.PictureBox ptb_toda_info;
        private System.Windows.Forms.PictureBox ptb_buscar_perfil;
        private System.Windows.Forms.Timer tmContraerMenu;
        private System.Windows.Forms.Timer tmExpandirMenu;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Timer tmFechaHora;
        private System.Windows.Forms.Panel panel_padre_centro;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}