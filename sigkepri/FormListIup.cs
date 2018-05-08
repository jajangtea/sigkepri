using ConnectCsharpToMysql;
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
    public partial class FormListIup : Form
    {
        private DBConnect dbConnect;
        string sqlTampil;
        public int selectedId;
        private MenuUtama menuUtama;
        private FormMenuUtama formMenuUtama;
        private FormWiup formWiup;
        public const string tblPrefik = "esdm_";
        public FormListIup()
        {
            InitializeComponent();
            dbConnect = new DBConnect();

        }

        private void btnTutup_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormIup fi = new FormIup();
            fi.btnSimpan.Text = "Simpan";
            fi.ShowDialog();

        }

        private void FormListIup_Load(object sender, EventArgs e)
        {

        }

        public void tampilkan()
        {
            sqlTampil = "select w.idWiup,p.namaPerusahaan,w.noIzin,w.tglIzin,l.alamatLokasi,w.luas,bg.namaBahanGalian from " + tblPrefik + "wiup w inner join " + tblPrefik + "perusahaan p on w.idPerusahaan=p.idPerusahaan ";
            sqlTampil += "inner join " + tblPrefik + "lokasi l on w.idLokasi=l.idLokasi ";
            sqlTampil += "inner join " + tblPrefik + "bahan_galian bg on w.idBahanGalian=bg.idBahanGalian order by w.idWiup desc";
            dbConnect.tampilData(dgvList, sqlTampil);
        }
    }
}
