namespace WinFormsApp5
{
    partial class Form2
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
            Label Cambria;
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            ExampleText = new Label();
            trackBar1 = new TrackBar();
            button4 = new Button();
            NSimSun = new Label();
            Candara = new Label();
            button5 = new Button();
            button6 = new Button();
            Cambria = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // Cambria
            // 
            Cambria.AutoSize = true;
            Cambria.Font = new Font("Calibri", 14F);
            Cambria.Location = new Point(212, 131);
            Cambria.Name = "Cambria";
            Cambria.Size = new Size(74, 23);
            Cambria.TabIndex = 7;
            Cambria.Text = "Cambria";
            Cambria.Click += label1_Click_1;
            // 
            // button2
            // 
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(60, 169);
            button2.Name = "button2";
            button2.Size = new Size(64, 20);
            button2.TabIndex = 1;
            button2.Text = "Blue";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(60, 131);
            button1.Name = "button1";
            button1.Size = new Size(64, 20);
            button1.TabIndex = 2;
            button1.Text = "Red";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.ForeColor = Color.Yellow;
            button3.Location = new Point(60, 213);
            button3.Name = "button3";
            button3.Size = new Size(64, 20);
            button3.TabIndex = 3;
            button3.Text = "Yellow";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // ExampleText
            // 
            ExampleText.AutoSize = true;
            ExampleText.Location = new Point(494, 176);
            ExampleText.Name = "ExampleText";
            ExampleText.Size = new Size(69, 13);
            ExampleText.TabIndex = 4;
            ExampleText.Text = "ExampleText";
            ExampleText.Click += label1_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(478, 36);
            trackBar1.Maximum = 36;
            trackBar1.Minimum = 8;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(89, 45);
            trackBar1.TabIndex = 5;
            trackBar1.Value = 8;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // button4
            // 
            button4.Location = new Point(60, 281);
            button4.Name = "button4";
            button4.Size = new Size(64, 20);
            button4.TabIndex = 6;
            button4.Tag = "1";
            button4.Text = "On";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // NSimSun
            // 
            NSimSun.AutoSize = true;
            NSimSun.Font = new Font("NSimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NSimSun.Location = new Point(212, 170);
            NSimSun.Name = "NSimSun";
            NSimSun.Size = new Size(79, 19);
            NSimSun.TabIndex = 8;
            NSimSun.Text = "NSimSun";
            NSimSun.Click += label1_Click_1;
            // 
            // Candara
            // 
            Candara.AutoSize = true;
            Candara.Font = new Font("Candara", 14F);
            Candara.Location = new Point(212, 213);
            Candara.Name = "Candara";
            Candara.Size = new Size(74, 23);
            Candara.TabIndex = 9;
            Candara.Text = "Candara";
            Candara.Click += label1_Click_1;
            // 
            // button5
            // 
            button5.DialogResult = DialogResult.OK;
            button5.Location = new Point(455, 325);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 10;
            button5.Text = "OK";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.DialogResult = DialogResult.Cancel;
            button6.Location = new Point(560, 325);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 11;
            button6.Text = "Cancle";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 390);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(Candara);
            Controls.Add(NSimSun);
            Controls.Add(Cambria);
            Controls.Add(button4);
            Controls.Add(trackBar1);
            Controls.Add(ExampleText);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Font = new Font("Segoe UI", 8.25F);
            Name = "Form2";
            Text = "Edit Text";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button button3;
        public Label ExampleText;
        private TrackBar trackBar1;
        public Button button4;
        private Label Cambria;
        private Label NSimSun;
        private Label Candara;
        private Button button5;
        private Button button6;
    }
}