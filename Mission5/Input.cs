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
    public partial class Input : Form
    {
        SqlConnection connection = new SqlConnection("server=DESKTOP-P6DOGIP\\SQLEXPRESS;database=Mission5;Integrated Security = True;");
        public Input()
        {
            InitializeComponent();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed) {
                connection.Open();
                string query = "Insert into Pegawai (nama,posisi,gaji) values (@Nama, @Posisi, @Gaji)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nama", textBoxNama.Text);
                cmd.Parameters.AddWithValue("@Posisi", textBoxPosisi.Text);
                cmd.Parameters.AddWithValue("@Gaji", textBoxGaji.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil ditambahkan");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi Kesalahan :" + ex.Message);
                }

                finally {
                    if (connection.State == ConnectionState.Open) {
                        connection.Close();
                    }
                }

            }
        }
    }
}
