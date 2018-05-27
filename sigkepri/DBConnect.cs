using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
//Add MySql Library
using MySql.Data.MySqlClient;
using System.Data;

namespace ConnectCsharpToMysql
{
    class DBConnect
    {
        public MySqlConnection connection;
    
        public MySqlDataAdapter adapt = null;
        public MySqlCommand cmd;
        public MySqlDataAdapter tampil;
        public DataSet ds = new DataSet();
        public DataTable dt = new DataTable();

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            string connectionString;
            connectionString = sigkepri.Properties.Settings.Default.sigConnectionString; ;// System.Configuration.ConfigurationManager.ConnectionStrings["sigkepri.Properties.Settings.sigConnectionString"].ConnectionString;
            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                connection.Open();
                return true;
               // MessageBox.Show(ex.Message);
               // return false;
            }
        }

        public void pencarian(DataGridView dgv, string _namaPerusahaan)
        {
            //string sql = "select * from esdm_perusahaan where namaPerusahaan like '%" + _namaPerusahaan + "%'";
            //dbConnect.tampilData(dgv, sql);
            //if (dgvList.Rows.Count == 0)
            //{
            //    MessageBox.Show("data tidak ditemukan.", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void tampilData(DataGridView dgv, string perintah)
        {
            try
            {
                this.OpenConnection();
                cmd = new MySqlCommand(perintah, connection);
                tampil = new MySqlDataAdapter(cmd);
                ds.Clear();
                tampil.Fill(ds);
                dgv.DataSource = ds.Tables[0];
                this.CloseConnection();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void tampilCombo(ComboBox dgv, string perintah,string list,string nilai)
        {
            try
            {
                this.OpenConnection();
                cmd = new MySqlCommand(perintah, connection);
                tampil = new MySqlDataAdapter(cmd);
                ds.Clear();
                tampil.Fill(dt);
                DataView dv = new DataView(dt);
                dgv.DataSource = dv;
                dgv.DisplayMember = list;
                dgv.ValueMember = nilai;
                this.CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public void Insert(String sql)
        {
            string query = sql;
            try
            {
                //open connection
                if (this.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        //Update statement
        public void Update(String sql)
        {
            string query = sql;

            //Open connection
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Informasi");
            }

        }

        //Delete statement
        public void Delete(String sql)
        {
            string query = sql;
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    if (MessageBox.Show("Apakah yakin ?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Berhasil dihapus", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CloseConnection();
                    }
                    else {
                        this.CloseConnection();
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        //Select statement
        public List<string>[] SelectLokasiDetil(string nama)
        {
            string query = "SELECT eld.pLat,eld.pLong FROM esdm_perusahaan p " +
                    " INNER JOIN esdm_izin_perusahaan ip ON p.idPerusahaan = ip.idPerusahaan " +
                    " INNER JOIN esdm_lokasi el ON ip.idLokasi = el.idLokasi " +
                    " INNER JOIN esdm_lokasi_detil eld ON el.idLokasi = eld.idLokasi " +
                    " where p.namaPerusahaan like '%" + nama + "%'";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["pLat"] + "");
                    list[1].Add(dataReader["pLong"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] SelectLokasiKota(string nama)
        {
            string query = "SELECT eld.pLat,eld.pLong FROM esdm_perusahaan p " +
                "INNER JOIN esdm_izin_perusahaan ip ON p.idPerusahaan = ip.idPerusahaan   " +
                "INNER JOIN esdm_lokasi el ON ip.idLokasi = el.idLokasi  " +
                "INNER JOIN esdm_kab_kota kk ON el.idKabKota = kk.idKabKota  " +
                "INNER JOIN esdm_lokasi_detil eld ON el.idLokasi = eld.idLokasi  " +
                " WHERE kk.namaKabKota like '%" + nama + "%'";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["pLat"] + "");
                    list[1].Add(dataReader["pLong"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }


        public List<string>[] SelectLokasiKomoditi(string nama)
        {
            string query = "SELECT bg.namaBahanGalian,eld.pLat,eld.pLong FROM esdm_perusahaan p   " +
                "INNER JOIN esdm_izin_perusahaan ip ON p.idPerusahaan = ip.idPerusahaan  " +
                "INNER JOIN esdm_lokasi el ON ip.idLokasi = el.idLokasi   " +
                "INNER JOIN esdm_bahan_galian bg ON ip.idBahanGalian = bg.idBahanGalian  " +
                "INNER JOIN esdm_lokasi_detil eld ON el.idLokasi = eld.idLokasi  " +
                "WHERE bg.namaBahanGalian like '%" + nama + "%'";
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["pLat"] + "");
                    list[1].Add(dataReader["pLong"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] SelectPerusahaan()
        {
            string query = "select * from esdm_perusahaan";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[1] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[1].Add(dataReader["namaPerusahaan"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] SelectKota()
        {
            string query = "select * from esdm_kab_kota";

            //Create a list to store the result
            List<string>[] list = new List<string>[1];
            list[1] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[1].Add(dataReader["namaKabKota"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] SelectKomoditi()
        {
            string query = "select * from esdm_bahan_galian";

            //Create a list to store the result
            List<string>[] list = new List<string>[1];
            list[1] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[1].Add(dataReader["namaBahanGalian"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] selectPenanda()
        {
            string query = "SELECT p.namaPerusahaan,eld.pLat,eld.pLong FROM esdm_perusahaan p " +
                    " INNER JOIN esdm_izin_perusahaan ip ON p.idPerusahaan = ip.idPerusahaan " +
                    " INNER JOIN esdm_lokasi el ON ip.idLokasi = el.idLokasi " +
                    " INNER JOIN esdm_lokasi_detil eld ON el.idLokasi = eld.idLokasi " +
                    " group by eld.idlokasi";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["namaPerusahaan"] + "");
                    list[1].Add(dataReader["pLat"] + "");
                    list[2].Add(dataReader["pLong"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] SelectLokasiDetil()
        {
            string query = "SELECT idLokasi,pLat,pLong FROM esdm_lokasi_detil";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["pLat"] + "");
                    list[1].Add(dataReader["pLong"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] selectPenandaDetil(string nama)
        {

            string query = "SELECT p.namaPerusahaan,eld.pLat,eld.pLong FROM esdm_perusahaan p " +
                    " INNER JOIN esdm_izin_perusahaan ip ON p.idPerusahaan = ip.idPerusahaan " +
                    " INNER JOIN esdm_lokasi el ON ip.idLokasi = el.idLokasi " +
                    " INNER JOIN esdm_lokasi_detil eld ON el.idLokasi = eld.idLokasi " +
                    " where p.namaPerusahaan like '%" + nama + "%'" +
                    " group by eld.idlokasi";

           

            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["namaPerusahaan"] + "");
                    list[1].Add(dataReader["pLat"] + "");
                    list[2].Add(dataReader["pLong"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] SelectLokasiMaster()
        {
            string query = "SELECT * FROM esdm_lokasi";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["long"] + "");
                    list[1].Add(dataReader["lat"] + "");
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }


        //Count statement
        public int Count(String sql)
        {
            string query = sql;
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup
        public void Backup()
        {
            try
            {
                //DateTime Time = DateTime.Now;
                //int year = Time.Year;
                //int month = Time.Month;
                //int day = Time.Day;
                //int hour = Time.Hour;
                //int minute = Time.Minute;
                //int second = Time.Second;
                //int millisecond = Time.Millisecond;

                ////Save file to C:\ with the current date as a filename
                //string path;
                //path = "C:\\" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                //StreamWriter file = new StreamWriter(path);


                //ProcessStartInfo psi = new ProcessStartInfo();
                //psi.FileName = "mysqldump";
                //psi.RedirectStandardInput = false;
                //psi.RedirectStandardOutput = true;
                //psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                //psi.UseShellExecute = false;

                //Process process = Process.Start(psi);

                //string output;
                //output = process.StandardOutput.ReadToEnd();
                //file.WriteLine(output);
                //process.WaitForExit();
                //file.Close();
                //process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to backup!" + ex);
            }
        }

        //Restore
        public void Restore()
        {
            try
            {
                //Read file from C:\
                //string path;
                //path = "C:\\MySqlBackup.sql";
                //StreamReader file = new StreamReader(path);
                //string input = file.ReadToEnd();
                //file.Close();


                //ProcessStartInfo psi = new ProcessStartInfo();
                //psi.FileName = "mysql";
                //psi.RedirectStandardInput = true;
                //psi.RedirectStandardOutput = false;
                //psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                //psi.UseShellExecute = false;


                //Process process = Process.Start(psi);
                //process.StandardInput.WriteLine(input);
                //process.StandardInput.Close();
                //process.WaitForExit();
                //process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore!" + ex);
            }
        }
    }
}
