namespace WinFormsApp3
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            button4 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            button11 = new Button();
            button10 = new Button();
            button6 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            button7 = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            button8 = new Button();
            label5 = new Label();
            button9 = new Button();
            buttonkayit = new Button();
            button12 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.AppWorkspace;
            dataGridView1.Location = new Point(14, 211);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1158, 423);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Location = new Point(3, 11);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Komedi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Location = new Point(3, 45);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Dram";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 5;
            label1.Text = "Film Türünü Seçiniz";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.Location = new Point(1033, 44);
            button3.Name = "button3";
            button3.Size = new Size(94, 41);
            button3.TabIndex = 6;
            button3.Text = "Göster";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1003, 9);
            label2.Name = "label2";
            label2.Size = new Size(169, 20);
            label2.TabIndex = 7;
            label2.Text = "En Yüksek Puanlı 25 Film";
            // 
            // button4
            // 
            button4.BackColor = Color.Gold;
            button4.Location = new Point(3, 80);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 8;
            button4.Text = "Aksiyon";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Location = new Point(16, 175);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 9;
            button5.Text = "Sıfırla";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(11, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 125);
            panel1.TabIndex = 10;
            // 
            // button11
            // 
            button11.BackColor = Color.Gold;
            button11.Location = new Point(105, 45);
            button11.Name = "button11";
            button11.Size = new Size(94, 29);
            button11.TabIndex = 21;
            button11.Text = "Korku";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Gold;
            button10.Location = new Point(105, 11);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 21;
            button10.Text = "Animasyon";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Highlight;
            button6.Location = new Point(1033, 128);
            button6.Name = "button6";
            button6.Size = new Size(94, 41);
            button6.TabIndex = 11;
            button6.Text = "Göster";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(998, 93);
            label3.Name = "label3";
            label3.Size = new Size(179, 20);
            label3.TabIndex = 12;
            label3.Text = "En Çok Gişe Yapan Filmler";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(433, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 27);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Highlight;
            button7.Location = new Point(670, 43);
            button7.Name = "button7";
            button7.Size = new Size(94, 32);
            button7.TabIndex = 14;
            button7.Text = "Ara";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(267, 43);
            label4.Name = "label4";
            label4.Size = new Size(160, 28);
            label4.TabIndex = 15;
            label4.Text = "Oyuncu adı girin:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(433, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 27);
            textBox2.TabIndex = 16;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.Highlight;
            button8.Location = new Point(670, 91);
            button8.Name = "button8";
            button8.Size = new Size(94, 33);
            button8.TabIndex = 17;
            button8.Text = "Ara";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(247, 93);
            label5.Name = "label5";
            label5.Size = new Size(180, 28);
            label5.TabIndex = 18;
            label5.Text = "Yönetmen adı girin:";
            // 
            // button9
            // 
            button9.BackColor = Color.Silver;
            button9.Location = new Point(117, 175);
            button9.Name = "button9";
            button9.Size = new Size(74, 29);
            button9.TabIndex = 19;
            button9.Text = "Hepsi";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // buttonkayit
            // 
            buttonkayit.BackColor = Color.Lime;
            buttonkayit.ForeColor = SystemColors.ControlText;
            buttonkayit.Location = new Point(433, 155);
            buttonkayit.Name = "buttonkayit";
            buttonkayit.Size = new Size(231, 49);
            buttonkayit.TabIndex = 20;
            buttonkayit.Text = "Yeni Kayıt Ekle";
            buttonkayit.UseVisualStyleBackColor = false;
            buttonkayit.Click += buttonkayit_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Gold;
            button12.Location = new Point(105, 80);
            button12.Name = "button12";
            button12.Size = new Size(94, 29);
            button12.TabIndex = 21;
            button12.Text = "Bilim Kurgu";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1185, 628);
            Controls.Add(buttonkayit);
            Controls.Add(button9);
            Controls.Add(label5);
            Controls.Add(button8);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(button7);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button6);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Film Veritabanı";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Label label2;
        private Button button4;
        private Button button5;
        private Panel panel1;
        private Button button6;
        private Label label3;
        private TextBox textBox1;
        private Button button7;
        private Label label4;
        private TextBox textBox2;
        private Button button8;
        private Label label5;
        private Button button9;
        private Button buttonkayit;
        private Button button10;
        private Button button11;
        private Button button12;
    }
}