using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using test.Database;

namespace test
{
    public partial class FormLogin : Form
    {
        private TaiKhoan _taikhoan = new TaiKhoan();

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-T3Q5P887\WINCC;Initial Catalog=SCADA;Integrated Security=True");

        public FormLogin()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" & txtPassword.Text != "")
            {
                // Kết nối và lấy dữ liệu từ SQL
                try
                {
                    string query = "SELECT * FROM Account_db WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        // Lấy thông tin từ tài khoản đầu tiên đúng thông tin đăng nhập
                        DataRow row = dtable.Rows[0];
                        _taikhoan.TenTaiKhoan = row["username"].ToString();
                        _taikhoan.MatKhau = row["password"].ToString();
                        _taikhoan.QuyenTruyCap = (bool)row["access_level"];
                    }
                    else
                    {
                        MessageBox.Show("SAI THÔNG TIN ĐĂNG NHẬP !", "ERROR");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("LỖI ĐĂNG NHẬP !!!", "FATAL ERROR");
                }
                finally
                {
                    conn.Close();
                }

                // Kiểm tra quyền
                if (_taikhoan.QuyenTruyCap == true)
                {
                    this.Hide();
                    FormMenu f = new FormMenu();
                    f.Show();
                    f.DangXuat += F_DangXuat;
                }
                else
                {
                    MessageBox.Show("BẠN KHÔNG CÓ QUYỀN TRUY CẬP !", "WARNING");
                }
            }
            else
            {
                MessageBox.Show("TÀI KHOẢN VÀ MẬT KHẨU KHÔNG ĐƯỢC ĐỂ TRỐNG !", "WARNING");
            }
        }

        public void F_DangXuat(object sender, EventArgs e)
        {
            this.Show();
            (sender as FormMenu).Close();
        }
    }
}
