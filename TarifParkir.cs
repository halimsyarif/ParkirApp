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
    public partial class TarifParkir : UserControl
    {
        public Dictionary<string, int> tarifParkir = new Dictionary<string, int>();
        private int parkirMobil = 3000;
        private int parkirMotor = 1000;
        public int trfMobil
        {
            get { return parkirMobil; }
            set { parkirMobil = value; }
        }
        public int trfMotor
        {
            get { return parkirMotor; }
            set { parkirMotor = value; }
        }

        public TarifParkir()
        {
            InitializeComponent();
        }
        
        private void updateData ()
        {
            if(tarifParkir.ContainsKey("mobil"))
            {
                tarifParkir["mobil"] = trfMobil;
            }
            else
            {
                tarifParkir.Add("mobil", trfMobil);
            }
            if (tarifParkir.ContainsKey("motor"))
            {
                tarifParkir["motor"] = trfMotor;
            }
            else
            {
                tarifParkir.Add("motor", trfMotor);
            }
            var tarif = tarifParkir.ToList();
            dataGridTarif.DataSource = tarif;
            dataGridTarif.Columns[0].HeaderText = "Kendaraan";
            dataGridTarif.Columns[1].HeaderText = "Tarif Parkir (Rp)";
            dataGridTarif.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            File.WriteAllText("../../tarif.txt", trfMobil + "|" + trfMotor);

            
        }
        private void TarifParkir_Load(object sender, EventArgs e)
        {
            updateData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tarifMobil.Text != "")
                { trfMobil = Convert.ToInt32(tarifMobil.Text); }
                if (tarifMotor.Text != "")
                { trfMotor = Convert.ToInt32(tarifMotor.Text); }
                updateData();
                tarifMobil.Text = "";
                tarifMotor.Text = "";

            }
            catch (Exception)
            {
                MessageBox.Show("isikan angka", "error", MessageBoxButtons.OK);
                tarifMobil.Text = "";
                tarifMotor.Text = "";
            }
        }
    }
}
