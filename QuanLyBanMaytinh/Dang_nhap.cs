using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyBanMaytinh
{
    public partial class Dang_nhap : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String connectionString = "Data source=LAPTOP-ENGKIS0L; Initial Catalog=dbQuanLyBanHang_TBMayTinh; Integrated Security=true";
        
        public Dang_nhap()
        {
            InitializeComponent();
        }
        private String username, password;
        private void btnnhap_Click(object sender, EventArgs e)
        {
            if(txtTaikhoan.Text!="" && txtMatkhau.Text!="")
            {
                if (login(txtTaikhoan.Text, txtMatkhau.Text))
                {

                    Trang_chu f = new Trang_chu();
                    f.username = txtTaikhoan.Text;
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTaikhoan.Text = "";
                    txtMatkhau.Text = "";
                    txtTaikhoan.Focus();
                }
            }
            
        }
        
       
        bool login(String username, String password)
        {


            using (SqlConnection cnn = new SqlConnection(connectionString))

            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "checkDangnhap";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cnn.Open();
                    var dataread = cmd.ExecuteReader();                    
                    return dataread.HasRows;
                    cnn.Close();
                }

            }



        }

        private void Dang_nhap_Load(object sender, EventArgs e)
        {
            
        }
    }
}
