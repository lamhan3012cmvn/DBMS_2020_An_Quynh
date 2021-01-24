namespace DBMS_2020.Componets
{
    partial class UserControl2
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
            this.lv_Bill = new System.Windows.Forms.ListView();
            this.c_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPrices = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lv_Bill
            // 
            this.lv_Bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.lv_Bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c_Name,
            this.c_Quantity,
            this.cPrices});
            this.lv_Bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Bill.GridLines = true;
            this.lv_Bill.HideSelection = false;
            this.lv_Bill.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lv_Bill.Location = new System.Drawing.Point(0, 0);
            this.lv_Bill.Name = "lv_Bill";
            this.lv_Bill.Scrollable = false;
            this.lv_Bill.Size = new System.Drawing.Size(774, 423);
            this.lv_Bill.TabIndex = 2;
            this.lv_Bill.UseCompatibleStateImageBehavior = false;
            this.lv_Bill.View = System.Windows.Forms.View.Details;
            // 
            // c_Name
            // 
            this.c_Name.Text = "Tên Món";
            this.c_Name.Width = 120;
            // 
            // c_Quantity
            // 
            this.c_Quantity.Text = "Số Lượng";
            this.c_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cPrices
            // 
            this.cPrices.Text = "Tổng giá";
            this.cPrices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cPrices.Width = 67;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lv_Bill);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(774, 423);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Bill;
        private System.Windows.Forms.ColumnHeader c_Name;
        private System.Windows.Forms.ColumnHeader c_Quantity;
        private System.Windows.Forms.ColumnHeader cPrices;
    }
}
