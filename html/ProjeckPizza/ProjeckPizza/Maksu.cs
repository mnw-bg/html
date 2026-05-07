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
	public partial class Maksu : Form
	{
		public Maksu()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MainMenu menu = new MainMenu();
			menu.Show();

		}

		private void Maksu_Load(object sender, EventArgs e)
		{
			
			label1.Text = IsoAiti.kuitisisalto;

			
			label3.Text = IsoAiti.kuiti.ToString("0.00") + " €";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			if (double.TryParse(textBox1.Text, out double customerMoney))
			{
				double totalToPay = IsoAiti.kuiti; 

				
				if (customerMoney >= totalToPay)
				{
					
					double change = customerMoney - totalToPay;

					
					MessageBox.Show($"Payment Successful!\nTotal: {totalToPay:0.00} €\nReceived: {customerMoney:0.00} €\nChange: {change:0.00} €", "Receipt");

					
					IsoAiti.myynti += totalToPay;
					IsoAiti.asiakas += 1;

					this.Close(); 
				}
				else
				{
				
					MessageBox.Show("Raha ei riitä! (eiriitä)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("Syötä voimakas summa! (oikein määrä)", "Error");
			}
		}
	}

}
