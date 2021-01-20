namespace DBMS_2020.Features.Admin
{
    partial class Admin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Admin = new Guna.UI.WinForms.GunaPanel();
            this.SuspendLayout();
            // 
            // pnl_Admin
            // 
            this.pnl_Admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Admin.Location = new System.Drawing.Point(0, 0);
            this.pnl_Admin.Name = "pnl_Admin";
            this.pnl_Admin.Size = new System.Drawing.Size(884, 524);
            this.pnl_Admin.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.pnl_Admin);
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(884, 524);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_Admin;
    }
}
