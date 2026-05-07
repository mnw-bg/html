namespace ProjeckPizza
{
	partial class Maksu
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
			label1 = new Label();
			textBox1 = new TextBox();
			button1 = new Button();
			button2 = new Button();
			label2 = new Label();
			label3 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = SystemColors.ScrollBar;
			label1.Location = new Point(26, 22);
			label1.MinimumSize = new Size(262, 300);
			label1.Name = "label1";
			label1.Size = new Size(262, 300);
			label1.TabIndex = 0;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(339, 91);
			textBox1.Margin = new Padding(3, 2, 3, 2);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(88, 23);
			textBox1.TabIndex = 1;
			// 
			// button1
			// 
			button1.Location = new Point(353, 116);
			button1.Margin = new Padding(3, 2, 3, 2);
			button1.Name = "button1";
			button1.Size = new Size(66, 38);
			button1.TabIndex = 5;
			button1.Text = "Maksa";
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.BackColor = SystemColors.ButtonShadow;
			button2.Location = new Point(596, 272);
			button2.Margin = new Padding(3, 2, 3, 2);
			button2.Name = "button2";
			button2.Size = new Size(94, 50);
			button2.TabIndex = 3;
			button2.Text = "BACK";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(431, 96);
			label2.Name = "label2";
			label2.Size = new Size(13, 15);
			label2.TabIndex = 4;
			label2.Text = "€";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(338, 64);
			label3.Name = "label3";
			label3.Size = new Size(38, 15);
			label3.TabIndex = 6;
			label3.Text = "label3";
			// 
			// Maksu
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.tausta;
			ClientSize = new Size(722, 371);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Margin = new Padding(3, 2, 3, 2);
			Name = "Maksu";
			Text = "Maksu";
			Load += Maksu_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label2;
		private Label label3;
	}
}