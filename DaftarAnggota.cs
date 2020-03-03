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
    public partial class DaftarAnggota : UserControl
    {
        public DaftarAnggota()
        {
            InitializeComponent();
        }
        static void bacaFileAnggota()
        {
            
        }
        private void DaftarAnggota_Load(object sender, EventArgs e)
        {
            txtboxNama.Text = "";
            txtBoxPlat.Text = "";
            comboBoxTipe.SelectedItem = "motor";
            DataTable tabelAnggota = new DataTable();
            tabelAnggota.Columns.Add("No.Anggota", typeof(int));
            tabelAnggota.Columns.Add("Nama", typeof(string));
            tabelAnggota.Columns.Add("Plat Kendaraan", typeof(string));
            tabelAnggota.Columns.Add("Tipe Kendaraan", typeof(string));
            string[] anggota = File.ReadAllLines("../../anggota.txt");
            string[] anggotaParkir;
            int noAnggotaTerakhir=0;
            for (int i = 0; i < (anggota.Length); i++)
            {
                anggotaParkir = anggota[i].ToString().Split('|');
                string[] kolom = new string[anggotaParkir.Length];

                for (int j = 0; j < (anggotaParkir.Length); j++)
                {
                    kolom[j] = anggotaParkir[j].Trim();
                }
                tabelAnggota.Rows.Add(kolom);
                noAnggotaTerakhir = Convert.ToInt32(kolom[0]);
            }
            dataGridAnggota.DataSource = tabelAnggota;
            txtboxNoAnggota.Text = Convert.ToString(noAnggotaTerakhir + 1);
            dataGridAnggota.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            string fileanggota = "../../anggota.txt";
            string updateData = File.ReadAllText(fileanggota);
            updateData = updateData + "\n" + txtboxNoAnggota.Text + "|" + txtboxNama.Text + "|" + txtBoxPlat.Text + "|" + comboBoxTipe.Text;
            File.WriteAllText(fileanggota, updateData);
            MessageBox.Show("Anggota Baru Berhasil ditambahkan", "Berhasil!", MessageBoxButtons.OK);
            DaftarAnggota_Load(sender, e);
        }
    }
}
