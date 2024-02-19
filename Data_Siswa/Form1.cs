using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Siswa
{
    public partial class Form1 : Form
    {
        List<Siswa> listsiswa = new List<Siswa>();
        private int nomorSiswaTerakhir = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void refresdata()
        {
            dataGridView1.Rows.Clear();
            foreach(Siswa getSiswa in listsiswa)
            {
                string[] newRow = { "", "", "", "", "" };
                newRow[0] = getSiswa.No.ToString();
                newRow[1] = getSiswa.Nama;
                newRow[2] = getSiswa.Kelas;
                newRow[3] = getSiswa.Nilai.ToString();
                dataGridView1.Rows.Add(newRow);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_input_nomor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_input_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            Siswa IsiSiswa = new Siswa();
            IsiSiswa.No = nomorSiswaTerakhir;
            nomorSiswaTerakhir++;
            IsiSiswa.InputSiswa(IsiSiswa.No,txtbox_input_nama.Text, txtbox_input_kelas.Text, (int)numericUpDown_input_nilai.Value);

            listsiswa.Add(IsiSiswa);
            listsiswa = listsiswa.OrderBy(s => s.Nama).ToList();

            for (int i = 0; i < listsiswa.Count; i++)
            {
                listsiswa[i].No = i + 1;
            }

            refresdata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                Siswa selectedSiswa = listsiswa[selectedRowIndex];
                nomorSiswaTerakhir = selectedSiswa.No;

              
                txtbox_edit_nama.Text = selectedSiswa.Nama;
                txt_box_edit_kelas.Text = selectedSiswa.Kelas;
                numericUpDown_edit_nilai.Value = selectedSiswa.Nilai;
                groupBox2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Pilih baris yang akan diedit terlebih dahulu.");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                Siswa selectedSiswa = listsiswa[selectedRowIndex];
                int editedNo = selectedSiswa.No;

                listsiswa[selectedRowIndex].Nama = txtbox_edit_nama.Text;
                listsiswa[selectedRowIndex].Kelas = txt_box_edit_kelas.Text;
                listsiswa[selectedRowIndex].Nilai = (int)numericUpDown_edit_nilai.Value;
                listsiswa = listsiswa.OrderBy(s => s.Nama).ToList();
                for (int i = 0; i < listsiswa.Count; i++)
                {
                    listsiswa[i].No = i + 1;
                }
                refresdata();
                int indexEditedSiswa = listsiswa.FindIndex(s => s.No == editedNo);
                nomorSiswaTerakhir = listsiswa[indexEditedSiswa].No + 1;
                groupBox2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Pilih baris yang akan disimpan perubahannya terlebih dahulu.");
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data siswa ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    listsiswa.RemoveAt(selectedRowIndex);
                    for (int i = 0; i < listsiswa.Count; i++)
                    {
                        listsiswa[i].No = i + 1;
                    }
                    refresdata();
                    groupBox2.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang akan dihapus terlebih dahulu.");
            }
        }

        private void lb_ratarata_Click(object sender, EventArgs e)
        {

        }

        private void btn_ratarata_Click(object sender, EventArgs e)
        {
            double nilaiRata = listsiswa.Average(s => s.Nilai);
            textBox1.Text = nilaiRata.ToString();
        }

        private void numericUpDown_atur_kkm_ValueChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            int kkm = (int)numericUpDown_atur_kkm.Value;
            var siswaDiatasKKM = listsiswa.Where(s => s.Nilai > kkm);
            foreach (var siswa in siswaDiatasKKM)
            {
                string[] newRow = { "", "", "", "" };
                newRow[0] = siswa.No.ToString();
                newRow[1] = siswa.Nama;
                newRow[2] = siswa.Kelas;
                newRow[3] = siswa.Nilai.ToString();
                dataGridView2.Rows.Add(newRow);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cek_kkm_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear ();
            int kkm = (int)numericUpDown_atur_kkm.Value;
            var siswadiataskkm = listsiswa.Where(s => s.Nilai > kkm);
            foreach (var siswa in siswadiataskkm)
            {
                string[] newRow = { "", "", "", "" };
                newRow[0] = siswa.No.ToString();
                newRow[1] = siswa.Nama;
                newRow[2] = siswa.Kelas;
                newRow[3] = siswa.Nilai.ToString();
                dataGridView2.Rows.Add(newRow);
            }
        }

        private void btn_reset_KKM_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }
    }
}
