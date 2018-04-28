using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
namespace sigkepri
{
    class appCommand
    {
        private MySqlConnection conn;
        private MySqlCommand comm;
        private MySqlDataAdapter tampil;
        private DataSet ds = new DataSet();
        private MySqlDataReader reader;
        private DataTable tbl;

        private string sql;
        //private string tgl,tahun,digit;
        private string ConnString;
        
        public void TampilData(DataGridView dgv, string perintah)
        {
            ConnString = Properties.Settings.Default.sigConnectionString;
            conn = new MySqlConnection(ConnString);
            sql = perintah;
            try
            {
                conn.Open();
                comm = new MySqlCommand(sql, conn);
                tampil = new MySqlDataAdapter(comm);
                ds.Clear();
                tampil.Fill(ds);
                dgv.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox .Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public void TampilCombo(ComboBox cb, string perintah, string member, string value)
        {
            ConnString = Properties.Settings.Default.sigConnectionString;
            conn = new MySqlConnection(ConnString);
            sql = perintah;
            try
            {
                conn.Open();
                comm = new MySqlCommand(sql, conn);
                tbl = new DataTable();
                reader = comm.ExecuteReader();
                tbl.Load(reader);
                cb.ValueMember = value;
                cb.DisplayMember = member;
                cb.DataSource = tbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        void kode_otomatis(DataTable adap, TextBox lb, string kolom)
        {
            String sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

            String dy = datevalue.Day.ToString();
            String mn = datevalue.Month.ToString();
            String yy = datevalue.Year.ToString();

        }

        private void autoNumberKD_Pembayaran(string sql,string empatkode,Label lb)
        {
            long hitung;
            string urut;
            ConnString = Properties.Settings.Default.sigConnectionString;
            conn = new MySqlConnection(ConnString);
            conn.Open();
            // Perintah untuk mendapatkan nilai terbesar dari field nomor
            comm = new MySqlCommand(sql, conn);
            reader = comm.ExecuteReader();
            reader.Read();
            // Jika data ditemukan
            if (reader.HasRows)
            {
                // Menambahkan data dari field nomor
                hitung = Convert.ToInt64(reader[0].ToString().Substring(reader["KD_Pembayaran"].ToString().Length - 4, 4)) + 1;
                string joinstr = "0000" + hitung;
                // Mengambil 4 karakter kanan terakhir dari string joinstr lalu di tambahkan dengan string URUT
                urut = empatkode + "-" + joinstr.Substring(joinstr.Length - 4, 4);
            }
            else
            {
                // Jika tidak ditemukan maka mengisi variable urut dengan YPMB-0001
                urut = empatkode + "-0001";
            }
            reader.Close();
            lb.Text = urut; // Nama textBox nya adalah kdPembayaran.Text
            conn.Close();
        }
        public double tampilScalar(string perintah)
        {
            ConnString = Properties.Settings.Default.sigConnectionString;
            conn = new MySqlConnection(ConnString);
            string sql = perintah;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            double total;
            try
            {
                conn.Open();
                total = double.Parse(cmd.ExecuteScalar() + "");
            }
            catch (Exception ex)
            {
                total = 0;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return total;
        }

        public void simpanOrUbahData(string perintah, string pesan)
        {
            try
            {
                ConnString = Properties.Settings.Default.sigConnectionString;
                conn = new MySqlConnection(ConnString);
                string sql = perintah;
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText=sql;
                cmd.Connection=conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data telah "  + pesan + ".", "Informasi");
                              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void simpanOrUbahData(string perintah)
        {
            try
            {
               ConnString = Properties.Settings.Default.sigConnectionString;
                conn = new MySqlConnection(ConnString);
                string sql = perintah;
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                cmd.CommandText =sql;
                cmd.Connection=conn;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void hapusData(string perintah, string pesan)
        {
            try
            {
                if ((MessageBox.Show("Apakah akan dihapus ?", "Pertanyaaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes))
                {
                    ConnString = Properties.Settings.Default.sigConnectionString;
                conn = new MySqlConnection(ConnString);
                    string sql = perintah;
                    MySqlCommand cmd = new MySqlCommand();
                    conn.Open();
                     cmd.CommandText =sql;
                cmd.Connection=conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(("data telah " + (pesan + ".")), "Informasi");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
