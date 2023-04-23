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
    public partial class Doi_MK : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String connectionString = "Data source=LAPTOP-ENGKIS0L; Initial Catalog=dbQuanLyBanHang_TBMayTinh; Integrated Security=true";
        public String username;
        

        public Doi_MK()
        {
            InitializeComponent();
        }

        private void btnDoimk_Click(object sender, EventArgs e)
        {
            


        }
        
        private void Doi_MK_Load(object sender, EventArgs e)
        {
           
            using (SqlConnection cnn = new SqlConnection(connectionString))

            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {

                    cnn.Open();
                    cmd.CommandText = "select *from tblNhanVien where iMaNV='" + username + "'";
                    var dataread = cmd.ExecuteReader();
                    Console.WriteLine(dataread.HasRows);
                    while (dataread.Read())
                    {
                        txtMaNV.Text = username;
                        txtHoten.Text = (string)dataread["sTenNV"];
                        txtDiachi.Text = (string)dataread["sDiachi"];
                        txtDienthoai.Text = (string)dataread["sDienthoai"];
                        //txtDiachi.Text=(String)dataread["sGioitinh"];

                        txtNgaysinh.Value = (DateTime)dataread["dNgaysinh"];
                        txtNgayvaolam.Value = (DateTime)dataread["dNgayvaolam"];
                        String s = "Nam";
                        if ((String)dataread["sGioitinh"]==s)
                        {
                            rbtnNam.Checked = true;
                        }
                        else
                            rbtnNu.Checked = true;

                    }
                    cnn.Close();
                }

            }

        }
    }
}
