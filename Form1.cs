using System;
using System.Globalization;
using System.Windows.Forms;

namespace PrediksiAyamSakit
{
    public partial class PrediksiAyam : Form
    {
        public PrediksiAyam()
        {
            InitializeComponent();
            AturTabel();   
        }
        private void AturTabel()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Hari", "Hari");
            dataGridView1.Columns.Add("JumlahAyam", "Jumlah Ayam");
            dataGridView1.Columns.Add("AyamSakit", "Ayam Sakit");
            dataGridView1.Columns.Add("Persentase", "Persentase (%)");
            dataGridView1.Columns.Add("Status", "Status");

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}
        private void textBoxSakit_TextChanged(object sender, EventArgs e){}
        private void textBoxJumlah_TextChanged(object sender, EventArgs e){}
        private void textBox3_TextChanged(object sender, EventArgs e){}
        private void label3_Click(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime tanggal;
            int jumlahAyam, ayamSakit;

            if (!DateTime.TryParseExact(textBoxTanggal.Text.Trim(), "dd/MM/yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out tanggal) ||
                !int.TryParse(txtJumlahAyam.Text, out jumlahAyam) ||
                !int.TryParse(txtAyamSakit.Text, out ayamSakit))
            {
                MessageBox.Show("Masukkan data dengan benar!");
                return;
            }
            PrediksiAyamSakit model =
                new PrediksiAyamSakit(jumlahAyam, ayamSakit);

            double sekarang = model.HitungPersentase();
            double sebelumnya = sekarang;

            if (dataGridView1.Rows.Count > 0)
            {
                int barisTerakhir = dataGridView1.Rows.Count - 1;

                sebelumnya = Convert.ToDouble(
                    dataGridView1.Rows[barisTerakhir].Cells[3].Value);
            }
            string status;
            if (dataGridView1.Rows.Count == 0)
            {
                status = "Data Awal";
            }
            else
            {
                status = model.Status(sebelumnya, sekarang);
            }
            dataGridView1.Rows.Add(
                tanggal.ToString("dd/MM/yyyy"),
                jumlahAyam,
                ayamSakit,
                sekarang.ToString("F2"),
                status
            );
            MessageBox.Show("Data berhasil disimpan!");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBoxTanggal.Clear();
            txtJumlahAyam.Clear();
            txtAyamSakit.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e){}
    }
}
