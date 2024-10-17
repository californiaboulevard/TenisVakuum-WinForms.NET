namespace TenisVakuum
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox8 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 35);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "dt (default = 0.001)";
            textBox1.Size = new Size(114, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(42, 64);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "N (default = 500)";
            textBox2.Size = new Size(114, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(42, 93);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "m (default = 1.0)";
            textBox3.Size = new Size(114, 23);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(42, 183);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "x (default = 0.0)";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(42, 212);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "z (default = 1.5)";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 4;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(42, 241);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "vx (default = 35.0)";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 5;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(42, 270);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "vz (default = 0.0)";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 6;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(268, 36);
            button1.Name = "button1";
            button1.Size = new Size(31, 23);
            button1.TabIndex = 7;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(449, 47);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 8;
            label1.Text = "vysledna x suradnica";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(449, 96);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 9;
            label2.Text = "vysledna z suradnica";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(564, 212);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 10;
            label3.Click += label3_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(42, 122);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "g (default = -9.81)";
            textBox8.Size = new Size(114, 23);
            textBox8.TabIndex = 11;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox8);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox8;
    }
}