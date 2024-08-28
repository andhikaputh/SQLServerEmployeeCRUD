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

namespace Mission5
{
    public partial class Read : Form
    {
        SqlConnection connection = new SqlConnection("server=DESKTOP-P6DOGIP\\SQLEXPRESS;database=Mission5;Integrated Security = True;");
        public Read()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData() 
        {
            if (connection.State == ConnectionState.Closed) {
                connection.Open();  
            }
            string query = "select * from pegawai";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Pegawai");
            dataGridView1.DataSource = ds.Tables["Pegawai"].DefaultView;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed) {
                connection.Open();
            }
            string query = "Update pegawai set Nama = @Nama, Posisi = @Posisi, Gaji = @Gaji where PegID= @PegID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PegID", textBoxID.Text);
            cmd.Parameters.AddWithValue("@Nama", textBoxNama.Text);
            cmd.Parameters.AddWithValue("@Posisi", textBoxPosisi.Text);
            cmd.Parameters.AddWithValue("@Gaji", textBoxGaji.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di update");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan :" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBoxID.Text = row.Cells["PegID"].Value.ToString();
                textBoxNama.Text = row.Cells["Nama"].Value.ToString();
                textBoxPosisi.Text = row.Cells["Posisi"].Value.ToString();
                textBoxGaji.Text = row.Cells["Gaji"].Value.ToString();

            }
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            string keyword = textBoxCari.Text.Trim();

            if (string.IsNullOrEmpty(keyword)) {
                MessageBox.Show("Masukkan nama atau posisi untuk mencari");
                return;
            }
            if (connection.State == ConnectionState.Closed) {
                connection.Open();
            }
            string query = "select * from pegawai where nama like @keyword or posisi like @keyword";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Pegawai");

            dataGridView1.DataSource = ds.Tables["Pegawai"].DefaultView;

            if (connection.State == ConnectionState.Open) {
                connection.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxID.Text)) {
                MessageBox.Show("Pilih pegawai yang ingin di hapus");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Apakah yakin ingin menghapus?", "Konfirmasi hapus", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                if (connection.State == ConnectionState.Closed) {
                    connection.Open();
                }

                string query = "delete from pegawai where PegID = @PegID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PegID", textBoxID.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data pegawai berhasil dihapus");
                    LoadData();
                    textBoxID.Clear();
                    textBoxNama.Clear();
                    textBoxPosisi.Clear();
                    textBoxGaji.Clear();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan " + ex.Message);
                }
                finally {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
