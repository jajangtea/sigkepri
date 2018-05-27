using ConnectCsharpToMysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sigkepri
{
    public partial class FormIup : Form
    {
        private DBConnect dbConnect;
        public DataTable dtPerusahaan = new DataTable();
        public DataTable dtlokasi = new DataTable();
        public DataTable dttahap = new DataTable();
        public DataTable dtjenis = new DataTable();
        public DataTable dtkomoditi = new DataTable();

        private readonly FormListIup frmFormListIup;
        private string idizin;

        public string Idizin
        {
            get { return idizin; }
            set { idizin = value; }
        }
        private string idtahap;

        public string Idtahap
        {
            get { return idtahap; }
            set { idtahap = value; }
        }
        //public string Idizin { get => idizin; set => idizin = value; }
       // public string Idtahap { get => idtahap; set => idtahap = value; }

        string __cbPerusahaan, __NoIzinTextBox, __tglPickertb, __tglPickertk, __cbbLokasi, __txtLuasTambang, __tahap, __txtLuasPenunjang, __namaBahanGalian,__cnc;

        public void tampilComboPerusahaan(ComboBox cbPerusahaan, string list, string nilai)
        {
            try
            {
                string sql = "select * from esdm_perusahaan order by namaPerusahaan";
                dbConnect.OpenConnection();
                dbConnect.cmd = new MySqlCommand(sql, dbConnect.connection);
                dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
                dbConnect.ds.Clear();
                dbConnect.tampil.Fill(dtPerusahaan);
                DataView dvPerusahaan = new DataView(dtPerusahaan);
                cbPerusahaan.DataSource = dvPerusahaan;
                cbPerusahaan.DisplayMember = list;
                cbPerusahaan.ValueMember = nilai;
                dbConnect.CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void FormIup_Load(object sender, EventArgs e)
        {
            dbConnect.CloseConnection();
            this.tampilComboPerusahaan(cbbPerusahaan, "namaPerusahaan", "idPerusahaan");
            this.tampilComboLokasi(cbbLokasi, "alamatLokasi", "idLokasi");
            this.tampilComboKomoditi(cbbKomoditi, "namaBahanGalian", "idBahanGalian");
            this.tampilComboTahap(cbbTahapKegiatan, "namaTahapKegiatan", "idTahapKegiatan");
            this.tampilComboJenis(cbbJenisPerizinan, "namaPerizinan", "idJenisPerizinan");
            try
            {
                if (btnSimpan.Text == "Edit")
                {
                    string sql = "select * from esdm_izin_perusahaan ew " +
                    "inner join esdm_perusahaan ep on ew.idPerusahaan=ep.idPerusahaan " +
                    "inner join esdm_lokasi el on ew.idLokasi=el.idLokasi " +
                    "inner join esdm_bahan_galian bg on ew.idBahanGalian=bg.idBahanGalian " +
                    "inner join esdm_tahap_kegiatan tk on ew.idTahapKegiatan=tk.idTahapKegiatan " +
                    "where  idIzinPerusahaan='" + this.idizin + "'";
                    if (dbConnect.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(sql, dbConnect.connection);
                        MySqlDataReader dataReader = cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            __cbPerusahaan = dataReader["namaPerusahaan"] + "";
                            __NoIzinTextBox = dataReader["nomorSK"] + "";
                            __tglPickertb = dataReader["tglBerlaku"].ToString() + "";
                            __tglPickertk = dataReader["tglKadaluwarsa"].ToString() + "";
                            __cbbLokasi = dataReader["alamatLokasi"].ToString() + "";
                            __cnc = dataReader["cnc"].ToString() + "";
                            string b1 = dataReader["luasWilayahTambang"].ToString() + "";
                            string b2 = dataReader["luasWilayahPenunjang"].ToString() + "";
                            var k = "";
                            var l = "";
                            if (b1.Contains(",") || b2.Contains(","))
                            {
                                k = b1.Replace(",", ".");
                                l = b2.Replace(",", ".");
                                __txtLuasTambang = k;
                                __txtLuasPenunjang = l;
                            }
                            else
                            {
                                __txtLuasTambang =  dataReader["luasWilayahTambang"].ToString() + "";
                                __txtLuasPenunjang = dataReader["luasWilayahPenunjang"].ToString() + "";
                            }
                           
                            __tahap = dataReader["namaTahapKegiatan"].ToString() + "";
                            __namaBahanGalian = dataReader["namaBahanGalian"].ToString() + "";
                        }
                        dataReader.Close();
                        dbConnect.CloseConnection();
                        cbbPerusahaan.Text = __cbPerusahaan;
                        txtNomorSK.Text = __NoIzinTextBox;
                        tb.Value = Convert.ToDateTime(__tglPickertb);
                        tk.Value = Convert.ToDateTime(__tglPickertk);
                        cbbLokasi.Text = __cbbLokasi;
                        txtLuasTambang.Text = __txtLuasTambang;
                        txtLuasPenunjang.Text = __txtLuasPenunjang;
                        cbbKomoditi.Text = __namaBahanGalian;
                        cbbTahapKegiatan.Text = __tahap;
                        cbbCNC.Text = __cnc;
                    }
                }
                else
                {
                    tb.Value = DateTime.Now;
                    tk.Value = DateTime.Now;

                    FormListIup fp = new FormListIup();
                    cbbTahapKegiatan.SelectedValue = this.Idtahap;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void tampilComboLokasi(ComboBox cblokasi, string list, string nilai)
        {
            try
            {

                string sql = "select * from esdm_lokasi order by alamatLokasi";
                dbConnect.OpenConnection();
                dbConnect.cmd = new MySqlCommand(sql, dbConnect.connection);
                dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
                dbConnect.ds.Clear();
                dbConnect.tampil.Fill(dtlokasi);
                DataView dvLokasi = new DataView(dtlokasi);
                cblokasi.DataSource = dvLokasi;
                cblokasi.DisplayMember = list;
                cblokasi.ValueMember = nilai;
                dbConnect.CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void tampilComboTahap(ComboBox cbtahap, string list, string nilai)
        {
            try
            {

                string sql = "select * from esdm_tahap_kegiatan order by namaTahapKegiatan";
                dbConnect.OpenConnection();
                dbConnect.cmd = new MySqlCommand(sql, dbConnect.connection);
                dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
                dbConnect.ds.Clear();
                dbConnect.tampil.Fill(dttahap);
                DataView dvTahap = new DataView(dttahap);
                cbtahap.DataSource = dvTahap;
                cbtahap.DisplayMember = list;
                cbtahap.ValueMember = nilai;
                dbConnect.CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void tampilComboJenis(ComboBox cbJenis, string list, string nilai)
        {
            try
            {

                string sql = "select * from esdm_jenis_perizinan order by namaPerizinan";
                dbConnect.OpenConnection();
                dbConnect.cmd = new MySqlCommand(sql, dbConnect.connection);
                dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
                dbConnect.ds.Clear();
                dbConnect.tampil.Fill(dtjenis);
                DataView dvJenis = new DataView(dtjenis);
                cbJenis.DataSource = dvJenis;
                cbJenis.DisplayMember = list;
                cbJenis.ValueMember = nilai;
                dbConnect.CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void tampilComboKomoditi(ComboBox cbKomoditi, string list, string nilai)
        {
            try
            {
                string sql = "select * from esdm_bahan_galian order by namaBahanGalian";
                dbConnect.OpenConnection();
                dbConnect.cmd = new MySqlCommand(sql, dbConnect.connection);
                dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
                dbConnect.ds.Clear();
                dbConnect.tampil.Fill(dtkomoditi);
                DataView dvKomoditi = new DataView(dtkomoditi);
                cbKomoditi.DataSource = dvKomoditi;
                cbKomoditi.DisplayMember = list;
                cbKomoditi.ValueMember = nilai;
                dbConnect.CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }




        public FormIup(FormListIup formListIup)
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            this.frmFormListIup = formListIup;


        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                var t1 = txtLuasTambang.Text;
                var t2 = txtLuasPenunjang.Text;

                if (t1.Contains(",") || t2.Contains(","))
                {
                    MessageBox.Show("gunakan tanda Titik (.) untuk input angka pecahan.", "Infomrasi");
                }
                else if (cbbCNC.Text == "" || t1 == "" || t2 == "" || txtNomorSK.Text=="")
                {
                    MessageBox.Show("Semua Kolom harus diisi.", "Infomrasi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    if (btnSimpan.Text == "Simpan")
                    {
                        dbConnect.CloseConnection();
                        dbConnect.Insert("insert into  esdm_izin_perusahaan (idJenisPerizinan,idTahapKegiatan,idLokasi,idBahanGalian,idPerusahaan,nomorSK,tglBerlaku,tglKadaluwarsa,luasWilayahTambang,luasWilayahPenunjang,cnc) values" +
                       "('" + cbbJenisPerizinan.SelectedValue + "','" + cbbTahapKegiatan.SelectedValue + "','" + cbbLokasi.SelectedValue + "','" + cbbKomoditi.SelectedValue + "','" + cbbPerusahaan.SelectedValue + "','" + txtNomorSK.Text.Trim() + "','" + tb.Value.ToString("yyyy-MM-dd") + "','" + tk.Value.ToString("yyyy-MM-dd") + "','" + txtLuasTambang.Text.Trim() + "','" + txtLuasPenunjang.Text.Trim() + "','" + cbbCNC.Text + "')");
                        frmFormListIup.tampilkan();
                        this.Close();
                    }
                    else
                    {

                        string sqledit = "update esdm_izin_perusahaan set idJenisPerizinan='" + cbbJenisPerizinan.SelectedValue + "',idTahapKegiatan='" + cbbTahapKegiatan.SelectedValue + "',idLokasi='" + cbbLokasi.SelectedValue + "',idBahanGalian='" + cbbKomoditi.SelectedValue + "',idPerusahaan='" + cbbPerusahaan.SelectedValue + "',nomorSK='" + txtNomorSK.Text.Trim() + "',tglBerlaku='" + tb.Value.ToString("yyyy-MM-dd") + "',tglKadaluwarsa='" + tk.Value.ToString("yyyy-MM-dd") + "',luasWilayahTambang='" + txtLuasTambang.Text + "',luasWilayahPenunjang='" + txtLuasPenunjang.Text + "',cnc='" + cbbCNC.Text + "' where idIzinPerusahaan='" + this.idizin + "'";
                        dbConnect.CloseConnection();
                        dbConnect.Update(sqledit);
                        frmFormListIup.tampilkan();
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
