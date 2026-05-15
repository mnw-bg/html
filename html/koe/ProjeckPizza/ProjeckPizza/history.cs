using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static ProjeckPizza.Sydan;

namespace ProjeckPizza
{
	public partial class history : Form
	{
		public history()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MainMenu menu = new MainMenu();
			menu.Show();
			this.Hide();
		}

		private void history_Load(object sender, EventArgs e)
		{
			textBox1.Text = IsoAiti.myynti.ToString("0.00") + " €";
			textBox2.Text = IsoAiti.asiakas.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
