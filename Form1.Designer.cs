namespace PrediksiAyamSakit
{
    partial class PrediksiAyam
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrediksiAyam));
            dataGridView1 = new DataGridView();
            txtAyamSakit = new TextBox();
            txtJumlahAyam = new TextBox();
            textBoxTanggal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonSimpan = new Button();
            buttonReset = new Button();
            buttonHapus = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(192, 255, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 331);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(849, 262);
            dataGridView1.TabIndex = 0;
            // 
            // txtAyamSakit
            // 
            txtAyamSakit.BackColor = Color.White;
            txtAyamSakit.Location = new Point(271, 144);
            txtAyamSakit.Name = "txtAyamSakit";
            txtAyamSakit.Size = new Size(208, 27);
            txtAyamSakit.TabIndex = 1;
            txtAyamSakit.TextChanged += textBoxSakit_TextChanged;
            // 
            // txtJumlahAyam
            // 
            txtJumlahAyam.Location = new Point(271, 96);
            txtJumlahAyam.Name = "txtJumlahAyam";
            txtJumlahAyam.Size = new Size(208, 27);
            txtJumlahAyam.TabIndex = 2;
            txtJumlahAyam.TextChanged += textBoxJumlah_TextChanged;
            // 
            // textBoxTanggal
            // 
            textBoxTanggal.Location = new Point(271, 45);
            textBoxTanggal.Name = "textBoxTanggal";
            textBoxTanggal.Size = new Size(208, 27);
            textBoxTanggal.TabIndex = 3;
            textBoxTanggal.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 50);
            label1.Name = "label1";
            label1.Size = new Size(79, 22);
            label1.TabIndex = 4;
            label1.Text = "Tanggal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 98);
            label2.Name = "label2";
            label2.Size = new Size(131, 22);
            label2.TabIndex = 5;
            label2.Text = "Jumlah Ayam ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 144);
            label3.Name = "label3";
            label3.Size = new Size(177, 22);
            label3.TabIndex = 6;
            label3.Text = "Jumlah Ayam Sakit";
            label3.Click += label3_Click;
            // 
            // buttonSimpan
            // 
            buttonSimpan.BackColor = Color.FromArgb(192, 255, 192);
            buttonSimpan.Location = new Point(69, 230);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(94, 29);
            buttonSimpan.TabIndex = 7;
            buttonSimpan.Text = "Simpan";
            buttonSimpan.UseVisualStyleBackColor = false;
            buttonSimpan.Click += button1_Click;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.FromArgb(255, 255, 192);
            buttonReset.Location = new Point(231, 230);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 8;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += button2_Click;
            // 
            // buttonHapus
            // 
            buttonHapus.BackColor = Color.FromArgb(255, 192, 192);
            buttonHapus.Location = new Point(385, 230);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(94, 29);
            buttonHapus.TabIndex = 9;
            buttonHapus.Text = "Hapus";
            buttonHapus.UseVisualStyleBackColor = false;
            buttonHapus.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(0, -12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(943, 629);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(543, 45);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(341, 214);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // PrediksiAyam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 629);
            Controls.Add(pictureBox2);
            Controls.Add(buttonHapus);
            Controls.Add(buttonReset);
            Controls.Add(buttonSimpan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxTanggal);
            Controls.Add(txtJumlahAyam);
            Controls.Add(txtAyamSakit);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "PrediksiAyam";
            Text = "Prediksi Ayam Sakit";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtAyamSakit;
        private TextBox txtJumlahAyam;
        private TextBox textBoxTanggal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonSimpan;
        private Button buttonReset;
        private Button buttonHapus;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
