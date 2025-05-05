namespace _224410072_Muhammet_Ali_Kocabiyik
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(336, 258);
            button1.Name = "button1";
            button1.Size = new Size(114, 73);
            button1.TabIndex = 0;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Green;
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(290, 22);
            label1.Name = "label1";
            label1.Padding = new Padding(60, 40, 60, 40);
            label1.Size = new Size(214, 100);
            label1.TabIndex = 1;
            label1.Text = "ShadowBank";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(132, 146);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 2;
            label2.Text = "Kullanıcı TC No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumBlue;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(165, 199);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.PaleGoldenrod;
            textBox1.Location = new Point(250, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.PaleGoldenrod;
            textBox2.Location = new Point(250, 196);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 27);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkOrchid;
            label4.ForeColor = SystemColors.InfoText;
            label4.Location = new Point(620, 22);
            label4.MaximumSize = new Size(300, 300);
            label4.Name = "label4";
            label4.Padding = new Padding(20, 0, 20, 0);
            label4.Size = new Size(138, 20);
            label4.TabIndex = 6;
            label4.Text = "Yönetici Girişi";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Location = new Point(634, 56);
            button2.Name = "button2";
            button2.Size = new Size(112, 66);
            button2.TabIndex = 7;
            button2.Text = "Giriş";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Button button2;
    }
}
