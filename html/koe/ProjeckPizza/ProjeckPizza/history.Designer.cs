namespace ProjeckPizza
{
    partial class history
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
			textBox1 = new TextBox();
			label1 = new Label();
			textBox2 = new TextBox();
			label2 = new Label();
			textBox3 = new TextBox();
			label3 = new Label();
			button1 = new Button();
			button2 = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(14, 32);
			textBox1.Margin = new Padding(3, 2, 3, 2);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.ScrollBars = ScrollBars.Vertical;
			textBox1.Size = new Size(673, 255);
			textBox1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(14, 298);
			label1.Name = "label1";
			label1.Size = new Size(46, 15);
			label1.TabIndex = 1;
			label1.Text = "Asiakas";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(70, 296);
			textBox2.Margin = new Padding(3, 2, 3, 2);
			textBox2.Name = "textBox2";
			textBox2.ReadOnly = true;
			textBox2.Size = new Size(110, 23);
			textBox2.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(13, 324);
			label2.Name = "label2";
			label2.Size = new Size(48, 15);
			label2.TabIndex = 3;
			label2.Text = "Summa";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(70, 319);
			textBox3.Margin = new Padding(3, 2, 3, 2);
			textBox3.Name = "textBox3";
			textBox3.ReadOnly = true;
			textBox3.Size = new Size(110, 23);
			textBox3.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(185, 324);
			label3.Name = "label3";
			label3.Size = new Size(13, 15);
			label3.TabIndex = 5;
			label3.Text = "€";
			// 
			// button1
			// 
			button1.BackColor = Color.Red;
			button1.ForeColor = SystemColors.Control;
			button1.Location = new Point(14, 352);
			button1.Margin = new Padding(3, 2, 3, 2);
			button1.Name = "button1";
			button1.Size = new Size(82, 22);
			button1.TabIndex = 6;
			button1.Text = "Reset ";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(610, 352);
			button2.Margin = new Padding(3, 2, 3, 2);
			button2.Name = "button2";
			button2.Size = new Size(82, 56);
			button2.TabIndex = 7;
			button2.Text = "BACK";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// history
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(703, 416);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(textBox3);
			Controls.Add(label2);
			Controls.Add(textBox2);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Margin = new Padding(3, 2, 3, 2);
			Name = "history";
			Text = "history";
			Load += history_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}