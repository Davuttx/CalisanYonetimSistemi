namespace CalısanYonetimSistemi_2._0
{
    partial class KAYDET
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
            button1 = new Button();
            button6 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            comboBox2 = new ComboBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label10 = new Label();
            textBox7 = new TextBox();
            label9 = new Label();
            textBox4 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            label7 = new Label();
            textBox8 = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.icons8_save_48;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(274, 158);
            button1.Name = "button1";
            button1.Size = new Size(75, 75);
            button1.TabIndex = 0;
            button1.Text = "KAYDET";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(1048, 7);
            button6.Name = "button6";
            button6.Size = new Size(26, 23);
            button6.TabIndex = 17;
            button6.Text = "—";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(1080, 7);
            button5.Name = "button5";
            button5.Size = new Size(28, 23);
            button5.TabIndex = 16;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.DarkGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(355, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(692, 374);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(249, 9);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 23);
            comboBox2.TabIndex = 65;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 70);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 64;
            label8.Text = "SOYAD";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Erkek", "Kadın" });
            comboBox1.Location = new Point(65, 128);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(101, 23);
            comboBox1.TabIndex = 63;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(192, 70);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 62;
            label6.Text = "E-POSTA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(205, 41);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 61;
            label5.Text = "MAAŞ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(170, 12);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 60;
            label4.Text = "DEPARTMAN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 132);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 59;
            label3.Text = "CİNSİYET";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 39);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 58;
            label2.Text = "AD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 13);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 57;
            label1.Text = "İD";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(249, 69);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 56;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(249, 39);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 55;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(65, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 54;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(65, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 53;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(65, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 52;
            textBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(182, 100);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 69;
            label10.Text = "Telefon No";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(249, 99);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 68;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 101);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 67;
            label9.Text = "T.C.";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(65, 99);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 66;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(171, 132);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 51;
            label7.Text = "GİRİŞ TARİHİ";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(249, 129);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 70;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 395);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 71;
            label11.Text = "label11";
            // 
            // KAYDET
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1124, 419);
            Controls.Add(label11);
            Controls.Add(textBox8);
            Controls.Add(label10);
            Controls.Add(textBox7);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KAYDET";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KAYDET";
            Load += KAYDET_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button6;
        private Button button5;
        private DataGridView dataGridView1;
        private ComboBox comboBox2;
        private Label label8;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label10;
        private TextBox textBox7;
        private Label label9;
        private TextBox textBox4;
        private OpenFileDialog openFileDialog1;
        private Label label7;
        private TextBox textBox8;
        private Label label11;
    }
}