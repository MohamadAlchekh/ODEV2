namespace odev2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            AdText = new TextBox();
            MesaiText = new TextBox();
            YasText = new TextBox();
            AdresText = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(22, 56);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(100, 36);
            label2.TabIndex = 1;
            label2.Text = "Adres :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(22, 163);
            label3.Name = "label3";
            label3.Size = new Size(81, 41);
            label3.TabIndex = 2;
            label3.Text = "Yaş :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(22, 224);
            label4.Name = "label4";
            label4.Size = new Size(90, 37);
            label4.TabIndex = 3;
            label4.Text = "Unvan :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Location = new Point(34, 283);
            label5.Name = "label5";
            label5.Size = new Size(69, 34);
            label5.TabIndex = 4;
            label5.Text = "Mesai :";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(281, 337);
            button1.Name = "button1";
            button1.Size = new Size(128, 23);
            button1.TabIndex = 5;
            button1.Text = "Personel Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AdText
            // 
            AdText.Location = new Point(147, 62);
            AdText.Name = "AdText";
            AdText.Size = new Size(100, 23);
            AdText.TabIndex = 6;
            // 
            // MesaiText
            // 
            MesaiText.Location = new Point(147, 290);
            MesaiText.Name = "MesaiText";
            MesaiText.Size = new Size(100, 23);
            MesaiText.TabIndex = 7;
            MesaiText.TextChanged += textBox2_TextChanged;
            // 
            // YasText
            // 
            YasText.Location = new Point(147, 173);
            YasText.Name = "YasText";
            YasText.Size = new Size(100, 23);
            YasText.TabIndex = 8;
            // 
            // AdresText
            // 
            AdresText.Location = new Point(147, 114);
            AdresText.Name = "AdresText";
            AdresText.Size = new Size(100, 23);
            AdresText.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(147, 232);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(AdresText);
            Controls.Add(YasText);
            Controls.Add(MesaiText);
            Controls.Add(AdText);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "A";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private TextBox AdText;
        private TextBox MesaiText;
        private TextBox YasText;
        private TextBox AdresText;
        private ComboBox comboBox1;
    }
}