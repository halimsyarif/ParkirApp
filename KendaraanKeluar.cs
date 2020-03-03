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
    public partial class KendaraanKeluar : UserControl
    {
        public KendaraanKeluar()
        {
            InitializeComponent();
        }
        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            textBox1.Text = time;
        }
        private void KendaraanKeluar_Load(object sender, EventArgs e)
        {
            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();

        }
        
        private void lihatTagihan_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime jamKeluar = dateTimePicker1.Value;
                string noPlat = txtBoxPlat.Text;
                string jm = "";
                string jnskndrn = "";
                TimeSpan durasiParkir;
                string hasil = File.ReadAllText("../../DataParkir/DataParkir.csv").Trim();
                string[] baris = hasil.Trim().Split('\n');

                for (int i = 1; i < baris.Length; i++)
                {
                    string[] kolom = baris[i].Trim().Split(';');
                    if (noPlat == kolom[1])
                    {
                        jm = kolom[3];
                        jnskndrn = kolom[2];
                    }
                }
                DateTime jamMasuk = Convert.ToDateTime(jm);
                durasiParkir = jamKeluar - jamMasuk;
                struk struk = new struk(durasiParkir, jamMasuk, jamKeluar, noPlat, jnskndrn, karcisHilang);
                struk.Show();
                txtBoxPlat.Text = "";
                checkBox1.Checked = false;
            }
            catch
            {
                MessageBox.Show("Data Kendaraan tidak ditemukan", "ERROR", MessageBoxButtons.OK);
                txtBoxPlat.Text = "";
                checkBox1.Checked = false;
            }
        }
        string karcisHilang;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { karcisHilang = "yes"; }
            else { karcisHilang = "no"; }
        }
    }
}
