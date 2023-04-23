using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanMaytinh
{
    public partial class Trang_chu : Form
    {
        public bool isThoat=true;
        public String username;
        Doi_MK doimk;
        public Trang_chu()
        {
            InitializeComponent();
        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Hang_hoa f = new Hang_hoa();
            Addform(f); 
            
        }

        private void hoaĐơnBanHangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HoaDonBanHang f = new HoaDonBanHang();
            Addform(f);
        }

        private void hoaĐơnNhâpHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDonNhapHang f = new HoaDonNhapHang();
            Addform(f);
        }

  

        private void đôiMâtKhâuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            Doi_MK f = new Doi_MK();
            f.username = username;
            Addform(f);
            
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        void Addform(Form f)
        {
            this.plncontrol.Controls.Clear();
            f.TopLevel = false;
            f.AutoSize = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.plncontrol.Controls.Add(f);
            f.Show();
            

        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Nhan_vien f = new Nhan_vien();
            Addform(f);
        }

        private void khachHangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Khach_hang f = new Khach_hang();
            Addform(f);
        }

        private void nhomHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhom_hang f = new Nhom_hang();
            Addform(f);
        }

        private void nhaCungCâpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nha_Cung_cap f = new Nha_Cung_cap();
            Addform(f);
        }
        
        private void Trang_chu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
