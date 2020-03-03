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
    public partial class KendaraanMasuk : UserControl
    {
        public KendaraanMasuk()
        {
            InitializeComponent();
        }
        public DateTimePicker date
        {
            get { return dateTimePicker1; }
            set { dateTimePicker1 = value; }

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label6.Visible = true;
            txtboxNo.Visible = true;
            textBox2.Visible = true;
            panel2.Location = new Point(60, 190);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            label6.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            txtboxNo.Visible = false;
            textBox2.Visible = false;
            panel2.Location = new Point(60, 120);

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
        private void KendaraanMasuk_Load(object sender, EventArgs e)
        {
            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
            comboBoxTipe.SelectedItem = "motor";
            panel2.Location = new Point(60, 120);
        }
        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            string jamMasuk = Convert.ToString(dateTimePicker1.Value);
            string noPlat = txtBoxPlat.Text;
            string jenisKend = comboBoxTipe.Text;
            karcis karcis = new karcis(jamMasuk, noPlat, jenisKend);
            karcis.Show();

            tambahData();
        }
        private void tambahData()
        {
            int no;
            string fileHasil = "../../DataParkir/DataParkir.csv";
            string hasil = File.ReadAllText("../../DataParkir/DataParkir.csv").Trim();
            string[] baris = hasil.Split('\n');
            string[] kolom = baris[baris.Length-1].Split(';');
            no = Convert.ToInt32(kolom[0]);
            no += + 1;
            hasil = hasil + "\n" + no + ";" + txtBoxPlat.Text + ";" + comboBoxTipe.Text + ";" + dateTimePicker1.Value;

            File.WriteAllText(fileHasil, hasil);
            txtBoxPlat.Text = "";
        }

        private void txtBoxPlat_KeyUp(object sender, KeyEventArgs e)
        {
            string[] anggota = File.ReadAllLines("../../anggota.txt");
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            for (int i = 0; i < anggota.Length; i++)
            {
                string[] kolom = anggota[i].Trim().Split('|');
                if (txtBoxPlat.Text == kolom[2])
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    txtboxNo.Text = kolom[0];
                    comboBoxTipe.SelectedItem = kolom[3];
                    textBox2.Text = kolom[1];
                }
            }

        }

        private void txtboxNo_KeyUp(object sender, KeyEventArgs e)
        {
            string[] anggota = File.ReadAllLines("../../anggota.txt");

            for (int i = 0; i < anggota.Length; i++)
            {
                string[] kolom = anggota[i].Trim().Split('|');
                if (txtboxNo.Text == kolom[0])
                {
                    txtBoxPlat.Text = kolom[2];
                    comboBoxTipe.SelectedItem = kolom[3];
                    textBox2.Text = kolom[1];
                }
            }

        }
    }
}
