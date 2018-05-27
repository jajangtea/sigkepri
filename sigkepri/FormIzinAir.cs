using ConnectCsharpToMysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sigkepri
{
    public partial class FormIzinAir : Form
    {
        private DBConnect dbConnect;
        public DataTable dtPerusahaan = new DataTable();
        public DataTable dtlokasi = new DataTable();
        private FormListAir formListAir;

        private string _idizin;

        public string Idizin
        {
            get { return _idizin; }
            set { _idizin = value; }
        }

        //public string Idizin { get => _idizin; set => _idizin = value; }

        public FormIzinAir(FormListAir formListAir)
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            this.formListAir = formListAir;
        }

        private void FormIzinAir_Load(object sender, EventArgs e)
        {
            this.tampilComboLokasi(cbbLokasi,"alamatLokasi","idLokasi");
            this.tampilComboPerusahaan(cbbPerusahaan, "namaPerusahaan", "idPerusahaan");
        }

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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (btnSimpan.Text == "Simpan")
            {
                dbConnect.CloseConnection();
                dbConnect.Insert("insert into  esdm_izin_perusahaan_air (idLokasi,idPerusahaan,nomorSK,tglBerlaku,tglKadaluwarsa,sumberAir,debit) values" +
               "('" + cbbLokasi.SelectedValue + "','" + cbbPerusahaan.SelectedValue + "','" + txtNomorSK.Text + "','" + tb.Value.ToString("yyyy-MM-dd") + "','" + tk.Value.ToString("yyyy-MM-dd") + "','" + txtSumberAir.Text.Trim() + "','" + txtDebit.Text.Trim() + "')");
                formListAir.tampildata();
                formListAir.ubahGrid();
                this.Close();
            }
            else
            {

                string sqledit = "update insert into  esdm_izin_perusahaan_air (idLokasi='" + cbbLokasi.SelectedValue + "',idPerusahaan='" + cbbPerusahaan.SelectedValue + "',nomorSK='" + txtNomorSK.Text + "',tglBerlaku='"+ tb.Value.ToString("yyyy-MM-dd") + "',tglKadaluwarsa='"+ tk.Value.ToString("yyyy-MM-dd") + "',sumberAir='"+ txtSumberAir.Text +"',debit='"+ txtDebit.Text +"' where idIzinPerusahaanAir='" + this.Idizin + "'";
                dbConnect.CloseConnection();
                dbConnect.Update(sqledit);
                formListAir.tampildata();
                formListAir.ubahGrid();
                this.Close();
            }
            
        }
    }
}
