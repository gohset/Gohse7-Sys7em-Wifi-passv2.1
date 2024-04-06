namespace Claves_Wifi
{
    partial class frm_perfiles
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
            this.txtbox_info = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbox_info
            // 
            this.txtbox_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_info.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtbox_info.ForeColor = System.Drawing.Color.White;
            this.txtbox_info.Location = new System.Drawing.Point(12, 36);
            this.txtbox_info.Multiline = true;
            this.txtbox_info.Name = "txtbox_info";
            this.txtbox_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbox_info.Size = new System.Drawing.Size(493, 276);
            this.txtbox_info.TabIndex = 0;
            // 
            // frm_perfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(536, 357);
            this.Controls.Add(this.txtbox_info);
            this.Name = "frm_perfiles";
            this.Text = "frm_perfiles";
            this.Load += new System.EventHandler(this.frm_perfiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_info;
    }
}