namespace DBMS_2020
{
    partial class FormMain
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
            this.pnl_FormMain = new Guna.UI.WinForms.GunaPanel();
            this.SuspendLayout();
            // 
            // pnl_FormMain
            // 
            this.pnl_FormMain.BackColor = System.Drawing.Color.White;
            this.pnl_FormMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_FormMain.Location = new System.Drawing.Point(0, 0);
            this.pnl_FormMain.Name = "pnl_FormMain";
            this.pnl_FormMain.Size = new System.Drawing.Size(895, 598);
            this.pnl_FormMain.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 598);
            this.Controls.Add(this.pnl_FormMain);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBMS";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_FormMain;
    }
}

