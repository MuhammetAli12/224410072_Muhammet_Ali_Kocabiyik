namespace _224410072_Muhammet_Ali_Kocabiyik
{
    partial class YöneticiGİRİŞİ
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
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(309, 313);
            button3.Name = "button3";
            button3.Padding = new Padding(1);
            button3.Size = new Size(126, 62);
            button3.TabIndex = 0;
            button3.Text = "Giriş";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HotTrack;
            textBox1.ForeColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(222, 176);
            textBox1.Margin = new Padding(10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Highlight;
            textBox2.ForeColor = SystemColors.ButtonHighlight;
            textBox2.Location = new Point(222, 238);
            textBox2.Margin = new Padding(1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(313, 27);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(84, 181);
            label1.Margin = new Padding(1);
            label1.MaximumSize = new Size(300, 300);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 1, 20, 1);
            label1.Size = new Size(92, 22);
            label1.TabIndex = 3;
            label1.Text = "TC No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(84, 241);
            label2.Margin = new Padding(1);
            label2.Name = "label2";
            label2.Padding = new Padding(20, 1, 20, 1);
            label2.Size = new Size(110, 22);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(239, 84);
            label4.MaximumSize = new Size(500, 500);
            label4.Name = "label4";
            label4.Padding = new Padding(90, 20, 90, 20);
            label4.Size = new Size(278, 60);
            label4.TabIndex = 7;
            label4.Text = "Yönetici Girişi";
            // 
            // YöneticiGİRİŞİ
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Name = "YöneticiGİRİŞİ";
            Padding = new Padding(20, 1, 20, 1);
            Text = "YöneticiGİRİŞİ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}