namespace Data_Siswa
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_input = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_input_nilai = new System.Windows.Forms.NumericUpDown();
            this.txtbox_input_kelas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_input_nama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.no_siswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_siswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kelas_siswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nilai_siswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.lb_ratarata = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_ratarata = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_edit_nilai = new System.Windows.Forms.NumericUpDown();
            this.txt_box_edit_kelas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_edit_nama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_cek_kkm = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown_atur_kkm = new System.Windows.Forms.NumericUpDown();
            this.btn_reset_KKM = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_input_nilai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_edit_nilai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_atur_kkm)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_input);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown_input_nilai);
            this.groupBox1.Controls.Add(this.txtbox_input_kelas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbox_input_nama);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(47, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data Siswa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(238, 160);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(75, 35);
            this.btn_input.TabIndex = 8;
            this.btn_input.Text = "Input";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nilai :";
            // 
            // numericUpDown_input_nilai
            // 
            this.numericUpDown_input_nilai.Location = new System.Drawing.Point(94, 135);
            this.numericUpDown_input_nilai.Name = "numericUpDown_input_nilai";
            this.numericUpDown_input_nilai.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_input_nilai.TabIndex = 6;
            // 
            // txtbox_input_kelas
            // 
            this.txtbox_input_kelas.Location = new System.Drawing.Point(94, 97);
            this.txtbox_input_kelas.Name = "txtbox_input_kelas";
            this.txtbox_input_kelas.Size = new System.Drawing.Size(215, 22);
            this.txtbox_input_kelas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kelas :";
            // 
            // txtbox_input_nama
            // 
            this.txtbox_input_nama.Location = new System.Drawing.Point(94, 58);
            this.txtbox_input_nama.Name = "txtbox_input_nama";
            this.txtbox_input_nama.Size = new System.Drawing.Size(215, 22);
            this.txtbox_input_nama.TabIndex = 1;
            this.txtbox_input_nama.TextChanged += new System.EventHandler(this.txtbox_input_nama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no_siswa,
            this.nama_siswa,
            this.kelas_siswa,
            this.nilai_siswa});
            this.dataGridView1.Location = new System.Drawing.Point(446, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 428);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // no_siswa
            // 
            this.no_siswa.HeaderText = "No";
            this.no_siswa.MinimumWidth = 6;
            this.no_siswa.Name = "no_siswa";
            this.no_siswa.Width = 125;
            // 
            // nama_siswa
            // 
            this.nama_siswa.HeaderText = "Nama";
            this.nama_siswa.MinimumWidth = 6;
            this.nama_siswa.Name = "nama_siswa";
            this.nama_siswa.Width = 125;
            // 
            // kelas_siswa
            // 
            this.kelas_siswa.HeaderText = "Kelas";
            this.kelas_siswa.MinimumWidth = 6;
            this.kelas_siswa.Name = "kelas_siswa";
            this.kelas_siswa.Width = 125;
            // 
            // nilai_siswa
            // 
            this.nilai_siswa.HeaderText = "Nilai";
            this.nilai_siswa.MinimumWidth = 6;
            this.nilai_siswa.Name = "nilai_siswa";
            this.nilai_siswa.Width = 125;
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(905, 491);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(75, 30);
            this.btn_hapus.TabIndex = 2;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // lb_ratarata
            // 
            this.lb_ratarata.AutoSize = true;
            this.lb_ratarata.Location = new System.Drawing.Point(428, 491);
            this.lb_ratarata.Name = "lb_ratarata";
            this.lb_ratarata.Size = new System.Drawing.Size(78, 16);
            this.lb_ratarata.TabIndex = 3;
            this.lb_ratarata.Text = "Rata-Rata : ";
            this.lb_ratarata.Click += new System.EventHandler(this.lb_ratarata_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(513, 491);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "0";
            // 
            // btn_ratarata
            // 
            this.btn_ratarata.Location = new System.Drawing.Point(757, 491);
            this.btn_ratarata.Name = "btn_ratarata";
            this.btn_ratarata.Size = new System.Drawing.Size(142, 30);
            this.btn_ratarata.TabIndex = 5;
            this.btn_ratarata.Text = "Hitung Rata-Rata";
            this.btn_ratarata.UseVisualStyleBackColor = true;
            this.btn_ratarata.Click += new System.EventHandler(this.btn_ratarata_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numericUpDown_edit_nilai);
            this.groupBox2.Controls.Add(this.txt_box_edit_kelas);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtbox_edit_nama);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(47, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 235);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Data Siswa";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(242, 167);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 35);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nilai :";
            // 
            // numericUpDown_edit_nilai
            // 
            this.numericUpDown_edit_nilai.Location = new System.Drawing.Point(98, 138);
            this.numericUpDown_edit_nilai.Name = "numericUpDown_edit_nilai";
            this.numericUpDown_edit_nilai.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_edit_nilai.TabIndex = 6;
            // 
            // txt_box_edit_kelas
            // 
            this.txt_box_edit_kelas.Location = new System.Drawing.Point(98, 100);
            this.txt_box_edit_kelas.Name = "txt_box_edit_kelas";
            this.txt_box_edit_kelas.Size = new System.Drawing.Size(215, 22);
            this.txt_box_edit_kelas.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Kelas :";
            // 
            // txtbox_edit_nama
            // 
            this.txtbox_edit_nama.Location = new System.Drawing.Point(98, 61);
            this.txtbox_edit_nama.Name = "txtbox_edit_nama";
            this.txtbox_edit_nama.Size = new System.Drawing.Size(215, 22);
            this.txtbox_edit_nama.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nama :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(446, 564);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(552, 214);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Kelas";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Nilai";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1264, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Siswa Diatas KKM";
            // 
            // btn_cek_kkm
            // 
            this.btn_cek_kkm.Location = new System.Drawing.Point(905, 784);
            this.btn_cek_kkm.Name = "btn_cek_kkm";
            this.btn_cek_kkm.Size = new System.Drawing.Size(75, 30);
            this.btn_cek_kkm.TabIndex = 12;
            this.btn_cek_kkm.Text = "Cek KKM";
            this.btn_cek_kkm.UseVisualStyleBackColor = true;
            this.btn_cek_kkm.Click += new System.EventHandler(this.btn_cek_kkm_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(666, 534);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Cek KKM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 564);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Atur KKM";
            // 
            // numericUpDown_atur_kkm
            // 
            this.numericUpDown_atur_kkm.Location = new System.Drawing.Point(137, 562);
            this.numericUpDown_atur_kkm.Name = "numericUpDown_atur_kkm";
            this.numericUpDown_atur_kkm.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_atur_kkm.TabIndex = 15;
            this.numericUpDown_atur_kkm.ValueChanged += new System.EventHandler(this.numericUpDown_atur_kkm_ValueChanged);
            // 
            // btn_reset_KKM
            // 
            this.btn_reset_KKM.Location = new System.Drawing.Point(456, 784);
            this.btn_reset_KKM.Name = "btn_reset_KKM";
            this.btn_reset_KKM.Size = new System.Drawing.Size(75, 30);
            this.btn_reset_KKM.TabIndex = 16;
            this.btn_reset_KKM.Text = "Reset";
            this.btn_reset_KKM.UseVisualStyleBackColor = true;
            this.btn_reset_KKM.Click += new System.EventHandler(this.btn_reset_KKM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 820);
            this.Controls.Add(this.btn_reset_KKM);
            this.Controls.Add(this.numericUpDown_atur_kkm);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_cek_kkm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_ratarata);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_ratarata);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_input_nilai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_edit_nilai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_atur_kkm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_siswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_siswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn kelas_siswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nilai_siswa;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Label lb_ratarata;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_ratarata;
        private System.Windows.Forms.TextBox txtbox_input_nama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_input_kelas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_input_nilai;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_edit_nilai;
        private System.Windows.Forms.TextBox txt_box_edit_kelas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_edit_nama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_cek_kkm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown_atur_kkm;
        private System.Windows.Forms.Button btn_reset_KKM;
    }
}

