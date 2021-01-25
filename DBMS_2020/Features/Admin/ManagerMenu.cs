﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMS_2020;
using System.IO;

namespace DBMS_2020.Features.Admin
{
    
    public partial class ManagerMenu : UserControl
    {
        string err;
        DataTable DT;
        private Controllers.Admin.Menu Menu;
        private string srcImg;
        private string nameImg;
        private bool flag;
        public ManagerMenu()
        {
            InitializeComponent();
            Menu = new Controllers.Admin.Menu();
            loadDataGridiew();

            picb_img.SizeMode = PictureBoxSizeMode.Zoom;
            openFileDialog1.Title = "Select Picture";
            openFileDialog1.Filter = "JPEG Image|*.jpg|Windows Bitmap|*.bmp|All Files|*.*";
            
            flag = false;//flase thì add true thì update or delete
            enabled();
        }
        private void enabled()
        {
            this.txt_Code.Enabled = !this.flag;
            this.txt_Name.Enabled = !this.flag;
            this.txt_Price.Enabled = !this.flag;
            this.btn_Update.Enabled = this.flag;
            this.btn_Del.Enabled = this.flag;
        }
        public void loadDataGridiew()
        {
            var data = this.Menu.loadViewManagerMenu();
            DT = data.Tables[0];
            this.dgv_Menu.Rows.Clear();
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                var item = DT.Rows[i];
                dgv_Menu.Rows.Add(item[0], item[1], item[2], item[4]);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(flag==false)
            {
                DataSet check = Menu.pickItem(this.txt_Code.Text);
                if (check.Tables[0].Rows.Count == 0)
                {
                    float price;
                    if (!float.TryParse(this.txt_Price.Text, out price))
                    {
                        MessageBox.Show("Giá tiền không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if(srcImg==null)
                    {
                        MessageBox.Show("Bạn chưa chọn ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DialogResult result = openFileDialog1.ShowDialog();
                        //Kiểm tra xem người dùng đã chọn file chưa
                        if (result == DialogResult.OK)
                        {
                            // Lấy hình ảnh
                            Image img = Image.FromFile(openFileDialog1.FileName);

                            // Gán ảnh
                            picb_img.Image = img;
                            this.srcImg = openFileDialog1.FileName;
                            this.nameImg = openFileDialog1.SafeFileName;
                        }
                        {
                            return;
                        }
                    }    
                    Menu.addMenu(MaMon: this.txt_Code.Text, TenMon: this.txt_Name.Text, GiaTien: price, AnhMinhHoa: this.txt_Name.Text, DaBan: 0, ref err);
                    if (err == null)
                    {
                        try
                        {
                            string dst = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                            File.Copy(srcImg, $@"{dst}\img\{nameImg}");
                            srcImg = null;
                            nameImg = null;
                            loadDataGridiew();
                            MessageBox.Show("Thêm món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Bạn Không có quyền truy cập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        err = null;
                    }
                }
                else
                {
                    MessageBox.Show("Đã có món trong menu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                resetTextBox();
            }
            else
            {
                flag = false;
                this.enabled();
                resetTextBox();
            }
            
        }
        private void resetTextBox()
        {
            this.txt_Code.Text = "";
            this.txt_Name.Text = "";
            this.txt_Price.Text = "";
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            float price;
            if (!float.TryParse(this.txt_Price.Text, out price))
            {
                MessageBox.Show("Giá trị Price nhập sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataSet check = Menu.pickItem(this.txt_Code.Text);
            if (check.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy món ăn để update", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                this.Menu.updateMenu(MaMon: this.txt_Code.Text, TenMon: this.txt_Name.Text, GiaTien: price, AnhMinhHoa:"", ref err) ;
                if (err == null)
                {
                   
                    try
                    {
                        loadDataGridiew();
                        MessageBox.Show("Update món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Bạn Không có quyền truy cập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    err = null;
                }
            }
            resetTextBox();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            this.Menu.deleteMenu(this.txt_Code.Text, ref err);
            if (err == null)
            {
                try
                {
                    loadDataGridiew();
                    MessageBox.Show("Xóa món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Bạn Không có quyền truy cập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                err = null;
            }
        }

        private void dgv_Menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = true;
            this.enabled();
            this.txt_Code.Text = this.dgv_Menu.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.txt_Name.Text = this.dgv_Menu.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.txt_Price.Text = this.dgv_Menu.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.picb_img.Image = Image.FromFile("../../img/" + DT.Rows[e.RowIndex][3]);
        
        }

        private void picb_img_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            //Kiểm tra xem người dùng đã chọn file chưa
            if (result == DialogResult.OK)
            {
                // Lấy hình ảnh
                Image img = Image.FromFile(openFileDialog1.FileName);

                // Gán ảnh
                picb_img.Image = img;
                this.srcImg = openFileDialog1.FileName;
                this.nameImg = openFileDialog1.SafeFileName;
            }
        }
    }
}
