namespace CalısanYonetimSistemi_2._0
{
    partial class ANAMENU
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
            BTNFRM = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BTNFRM
            // 
            BTNFRM.BackgroundImage = Properties.Resources.icons8_save_48;
            BTNFRM.BackgroundImageLayout = ImageLayout.Center;
            BTNFRM.Cursor = Cursors.Hand;
            BTNFRM.FlatStyle = FlatStyle.Flat;
            BTNFRM.Location = new Point(15, 139);
            BTNFRM.Name = "BTNFRM";
            BTNFRM.Size = new Size(100, 100);
            BTNFRM.TabIndex = 0;
            BTNFRM.Text = "KAYDET FORM";
            BTNFRM.TextAlign = ContentAlignment.BottomCenter;
            BTNFRM.UseVisualStyleBackColor = true;
            BTNFRM.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.icons8_update_50;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(224, 139);
            button2.Name = "button2";
            button2.Size = new Size(100, 100);
            button2.TabIndex = 1;
            button2.Text = "GÜNCELLE FORM";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.icons8_delete_64;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(121, 139);
            button3.Name = "button3";
            button3.Size = new Size(100, 100);
            button3.TabIndex = 2;
            button3.Text = "SİL FORM";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.icons8_data_processing_64;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(27, 245);
            button4.Name = "button4";
            button4.Size = new Size(393, 100);
            button4.TabIndex = 3;
            button4.Text = "VERİ İŞLEM";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(402, 12);
            button5.Name = "button5";
            button5.Size = new Size(28, 23);
            button5.TabIndex = 4;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(370, 12);
            button6.Name = "button6";
            button6.Size = new Size(26, 23);
            button6.TabIndex = 5;
            button6.Text = "—";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.icons8_company_64;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(147, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 121);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.icons8_department_48;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(330, 139);
            button1.Name = "button1";
            button1.Size = new Size(100, 100);
            button1.TabIndex = 7;
            button1.Text = "Depertman EKLE";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // ANAMENU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(442, 360);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(BTNFRM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ANAMENU";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ANAMENU";
            Load += ANAMENU_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BTNFRM;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private PictureBox pictureBox1;
        private Button button1;
    }
}