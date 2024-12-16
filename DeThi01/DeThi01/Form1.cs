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
using System.Data.Common;

namespace DeThi01
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=ADMIN-PC\\MSSQLSERVER2;Initial Catalog=QLSV;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadDataToListView()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open(); 

                    string query = "SELECT MaSV, HoTenSV, MaLop, NgaySinh FROM SinhVien";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            lvSinhvien.Items.Clear(); 

                            while (reader.Read()) 
                            {
                                ListViewItem item = new ListViewItem(reader["MaSV"].ToString());

                                item.SubItems.Add(reader["HoTenSV"].ToString());
                                item.SubItems.Add(reader["MaLop"].ToString());
                                item.SubItems.Add(Convert.ToDateTime(reader["NgaySinh"]).ToShortDateString());
                                lvSinhvien.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmSinhvien_Load(object sender, EventArgs e)
        {
            SetupListView();
            LoadDataToListView(); 
            LoadStudentData();
            LoadClassData();
            SetControlState(false);
        }
        private void SetupListView()
        {
            lvSinhvien.View = View.Details; 
            lvSinhvien.FullRowSelect = true; 

            lvSinhvien.Columns.Add("Mã SV", 100, HorizontalAlignment.Left);
            lvSinhvien.Columns.Add("Họ Tên", 150, HorizontalAlignment.Left);
            lvSinhvien.Columns.Add("Mã Lớp", 100, HorizontalAlignment.Left);
            lvSinhvien.Columns.Add("Ngày Sinh", 120, HorizontalAlignment.Left);
        }


 
        private void LoadStudentData() { /* Load students into ListView */ }
        private void LoadClassData() { /* Load class names into ComboBox */ }
        private void DeleteStudentData() { /* Delete selected record */ }
        private void UpdateStudentData() { /* Update selected record */ }
        private void SaveStudentData() { /* Add new student record */ }
        private void SetControlState(bool isEnabled) { /* Enable/Disable Controls */ }
        private void ClearControls() { /* Clear textboxes and reset inputs */ }

       
            private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT MaSV, HoTenSV, MaLop, NgaySinh FROM SinhVien WHERE HoTenSV LIKE @HoTenSV";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@HoTenSV", "%" + txtTim.Text + "%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            lvSinhvien.Items.Clear(); 

                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["MaSV"].ToString());
                                item.SubItems.Add(reader["HoTenSV"].ToString());
                                item.SubItems.Add(reader["MaLop"].ToString());
                                item.SubItems.Add(Convert.ToDateTime(reader["NgaySinh"]).ToShortDateString());

                                lvSinhvien.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }
        

        private void lvSinhvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvSinhvien.View = View.Details;
            lvSinhvien.Columns.Add("Mã SV", 100, HorizontalAlignment.Left);
            lvSinhvien.Columns.Add("Họ Tên", 150, HorizontalAlignment.Left);
            lvSinhvien.Columns.Add("Mã Lớp", 100, HorizontalAlignment.Left);
            lvSinhvien.Columns.Add("Ngày Sinh", 120, HorizontalAlignment.Left);

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO SinhVien (MaSV, HoTenSV, MaLop, NgaySinh) VALUES (@MaSV, @HoTenSV, @MaLop, @NgaySinh)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                    
                        cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                        cmd.Parameters.AddWithValue("@HoTenSV", txtHoTenSV.Text);
                        cmd.Parameters.AddWithValue("@MaLop", cbLop.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm dữ liệu thành công!");

                        LoadDataToListView(); 
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
        }
 

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (lvSinhvien.SelectedItems.Count > 0)
                {
                 
                    string maSV = lvSinhvien.SelectedItems[0].SubItems[0].Text;

                 
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        
                        string query = "UPDATE SinhVien SET HoTenSV = @HoTenSV, MaLop = @MaLop, NgaySinh = @NgaySinh WHERE MaSV = @MaSV";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                          
                            cmd.Parameters.AddWithValue("@MaSV", maSV);
                            cmd.Parameters.AddWithValue("@HoTenSV", txtHoTenSV.Text); 
                            cmd.Parameters.AddWithValue("@MaLop", cbLop.SelectedItem.ToString()); 
                            cmd.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value); 

             
                            int rowsAffected = cmd.ExecuteNonQuery();

                          
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật dữ liệu thành công!");
                                LoadDataToListView(); 
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy Mã Sinh Viên để sửa!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng cần sửa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message);
            }
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT MaSV, HoTenSV, MaLop, NgaySinh FROM SinhVien";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            lvSinhvien.Items.Clear();

                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["MaSV"].ToString());
                                item.SubItems.Add(reader["HoTenSV"].ToString());
                                item.SubItems.Add(reader["MaLop"].ToString());
                                item.SubItems.Add(Convert.ToDateTime(reader["NgaySinh"]).ToShortDateString());

                                lvSinhvien.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?",
               "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                if (lvSinhvien.SelectedItems.Count > 0)
                {
                   
                    string maSV = lvSinhvien.SelectedItems[0].SubItems[0].Text;

                  
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                       
                        string query = "DELETE FROM SinhVien WHERE MaSV = @MaSV";

                
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                 
                            cmd.Parameters.AddWithValue("@MaSV", maSV);

                          
                            int rowsAffected = cmd.ExecuteNonQuery();

                            
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa dữ liệu thành công!");
                                LoadDataToListView(); 
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy Mã Sinh Viên để xóa!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
            }
        }

    }
}


