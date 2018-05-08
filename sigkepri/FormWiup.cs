﻿using ConnectCsharpToMysql;
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
    public partial class FormWiup : Form
    {
        private string idizin;
        private DBConnect dbConnect;
        public DataTable dtPerusahaan = new DataTable();
        public DataTable dtlokasi = new DataTable();
        public DataTable dtkomoditi = new DataTable();
        private readonly FormListWiup frmFormListWiup;
        public string Idizin { get => idizin; set => idizin = value; }

        public FormWiup(FormListWiup formListWiup)
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            this.frmFormListWiup = formListWiup;
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

        private void FormWiup_Load(object sender, EventArgs e)
        {
            try
            {
                this.tampilComboPerusahaan(cbPerusahaan, "namaPerusahaan", "idPerusahaan");
                this.tampilComboLokasi(cbbLokasi, "alamatLokasi", "idLokasi");
                this.tampilComboKomoditi(bdKomoditi, "namaBahanGalian", "idBahanGalian");
                string sql = "select * from esdm_wiup ew " +
                    "inner join esdm_perusahaan ep on ew.idPerusahaan=ep.idPerusahaan " +
                    "inner join esdm_lokasi el on ew.idLokasi=el.idLokasi " +
                    "where  idWiup='" + this.idizin + "'";
                if (dbConnect.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, dbConnect.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        cbPerusahaan.Text = dataReader["namaPerusahaan"] + "";
                        NoIzinTextBox.Text = dataReader["noIzin"] + "";
                        tglPicker.Text = dataReader["tglIzin"].ToString() + "";
                        cbbLokasi.Text = dataReader["alamatLokasi"].ToString() + "";
                        txtLuas.Text = dataReader["luas"].ToString() + "";
                    }
                    dataReader.Close();
                    dbConnect.CloseConnection();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if(btnSimpan.Text=="Simpan")
                {
                    dbConnect.Insert("insert into  esdm_wiup (idPerusahaan,idLokasi,idBahanGalian,noIzin,tglIzin,luas) values" +
                   "('" + cbPerusahaan.SelectedValue + "','" + cbbLokasi.SelectedValue + "','" + bdKomoditi.SelectedValue + "','" + NoIzinTextBox.Text.Trim() + "','" + tglPicker.Value.ToString("yyyy-MM-dd") + "','" + txtLuas.Text.Trim() + "')");
                    frmFormListWiup.tampilkan();
                }
                else
                {
                    dbConnect.Insert("update esdm_wiup set idPerusahaan='"+ cbPerusahaan.SelectedValue + "',idLokasi='"+ cbbLokasi.SelectedValue + "',idBahanGalian='"+ bdKomoditi.SelectedValue + "',noIzin='" + NoIzinTextBox.Text.Trim() + "',tglIzin='"+ tglPicker.Value.ToString("yyyy-MM-dd") + "',luas='"+ txtLuas.Text.Trim() + "' where idWiup='"+ this.idizin +"'");
                    frmFormListWiup.tampilkan();
                }
               
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
