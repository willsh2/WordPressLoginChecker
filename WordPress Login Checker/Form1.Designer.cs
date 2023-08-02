namespace WordPress_Login_Checker
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
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            progressBar1 = new ProgressBar();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            listBox2 = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(687, 290);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ayarlar";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(9, 76);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(672, 204);
            listBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(460, 26);
            button3.Name = "button3";
            button3.Size = new Size(221, 34);
            button3.TabIndex = 2;
            button3.Text = "Durdur";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(236, 26);
            button2.Name = "button2";
            button2.Size = new Size(221, 34);
            button2.TabIndex = 1;
            button2.Text = "Site listesi ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(9, 26);
            button1.Name = "button1";
            button1.Size = new Size(221, 34);
            button1.TabIndex = 0;
            button1.Text = "Başlat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(progressBar1);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(3, 297);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(687, 126);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "İstatistikler";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(9, 70);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(660, 42);
            progressBar1.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(591, 30);
            numericUpDown1.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(78, 27);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(515, 32);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 6;
            label7.Text = "Threads:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(416, 32);
            label6.Name = "label6";
            label6.Size = new Size(17, 20);
            label6.TabIndex = 5;
            label6.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(342, 32);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 4;
            label5.Text = "Başarısız:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(257, 32);
            label4.Name = "label4";
            label4.Size = new Size(18, 20);
            label4.TabIndex = 3;
            label4.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(192, 32);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Başarılı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(103, 32);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 1;
            label2.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(9, 32);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Toplam site:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listBox2);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.Location = new Point(3, 429);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(687, 199);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Çıktılar";
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(9, 26);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(672, 164);
            listBox2.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 636);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "WordPress Login Checker";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ProgressBar progressBar1;
        private GroupBox groupBox3;
        private ListBox listBox2;
        private OpenFileDialog openFileDialog1;
    }
}