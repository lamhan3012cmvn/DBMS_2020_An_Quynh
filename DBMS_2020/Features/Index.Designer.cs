namespace DBMS_2020.Features
{
    partial class Index
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
            this.pnl_load_ui = new Guna.UI.WinForms.GunaPanel();
            this.SuspendLayout();
            // 
            // pnl_load_ui
            // 
            this.pnl_load_ui.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_load_ui.Location = new System.Drawing.Point(0, 0);
            this.pnl_load_ui.Name = "pnl_load_ui";
            this.pnl_load_ui.Size = new System.Drawing.Size(884, 561);
            this.pnl_load_ui.TabIndex = 0;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_load_ui);
            this.Name = "Index";
            this.Size = new System.Drawing.Size(884, 561);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_load_ui;
    }
}
