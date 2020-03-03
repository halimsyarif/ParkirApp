using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UAS_ParkirApp
{
    public partial class Riwayat : UserControl
    {
        public Riwayat()
        {
            InitializeComponent();
        }

        private void Riwayat_Load(object sender, EventArgs e)
        {
            buatTabelParkir();
            buatTabelRiwayat();
        }
        private void buatTabelParkir()
        {
            //Tabel Parkir
            DataTable tabelParkir = new DataTable();
            tabelParkir.Columns.Add("ID", typeof(string));
            tabelParkir.Columns.Add("Plat Kendaraan", typeof(string));
            tabelParkir.Columns.Add("Jenis Kendaraan", typeof(string));
            tabelParkir.Columns.Add("Jam Masuk", typeof(string));
            string[] baris = File.ReadAllLines("../../DataParkir/DataParkir.csv");

            for (int i = 1; i < (baris.Length); i++)
            {
                string[] kend = baris[i].Trim().Split(';');
                string[] kolom = new string[kend.Length];
                for (int j = 0; j < (kend.Length); j++)
                {
                    kolom[j] = kend[j].Trim();
                }
                tabelParkir.Rows.Add(kolom);
            }
            dataGridParkir.DataSource = tabelParkir;
            dataGridParkir.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridParkir.BorderStyle = BorderStyle.FixedSingle;
        }
        private void buatTabelRiwayat()
        {
            //Tabel Riwayat
            DataTable tabelRiwayat = new DataTable();
            tabelRiwayat.Columns.Add("ID", typeof(string));
            tabelRiwayat.Columns.Add("Plat Kendaraan", typeof(string));
            tabelRiwayat.Columns.Add("Jenis Kendaraan", typeof(string));
            tabelRiwayat.Columns.Add("Jam Masuk", typeof(string));
            tabelRiwayat.Columns.Add("Jam Keluar", typeof(string));
            tabelRiwayat.Columns.Add("Lama Parkir", typeof(string));
            tabelRiwayat.Columns.Add("Anggota", typeof(string));
            tabelRiwayat.Columns.Add("Tarif Parkir", typeof(string));
            tabelRiwayat.Columns.Add("Total Tagihan", typeof(string));

            string[] baris = File.ReadAllLines("../../RiwayatParkir/RiwayatParkir.csv");
            for (int i = 1; i < (baris.Length); i++)
            {
                string[] kend = baris[i].Trim().Split(';');
                string[] kolom = new string[kend.Length];
                for (int j = 0; j < (kend.Length); j++)
                {
                    kolom[j] = kend[j].Trim();
                }
                tabelRiwayat.Rows.Add(kolom);
            }
            dataGridRiwayat.DataSource = tabelRiwayat;
            dataGridRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridRiwayat.BorderStyle = BorderStyle.FixedSingle;
        }
        private Form1 MainForm;
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            buatTabelParkir();
            buatTabelRiwayat();
            updateData(MainForm);
        }
        public void updateData(Form1 form)
        {
            MainForm = form;
            MainForm.hitungkndraan();
            MainForm = form;
        }
    }
}
