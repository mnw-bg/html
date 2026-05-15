using System.Configuration;
using System.Data;
using System.Diagnostics.Metrics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static ProjeckPizza.Sydan;

namespace ProjeckPizza
{
	public partial class MainMenu : Form
	{
		double nykyinenSumma = 0;
		private DataTable taulu;
		public MainMenu()
		{
			InitializeComponent();

		}

		private void checkBox25_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
		private void MainMenu_Load(object sender, EventArgs e)
		{

		}
		private void button1_Click(object sender, EventArgs e)
		{
			lisapizza();
		}
		private void button2_Click(object sender, EventArgs e)
		{
			lisapizza();
		}
		private void button3_Click(object sender, EventArgs e)
		{
			lisapizza();
		}
		private void button4_Click(object sender, EventArgs e)
		{
			lisapizza();
		}
		private void button5_Click(object sender, EventArgs e)
		{
			lisapizza();
		}
		private void button6_Click(object sender, EventArgs e)
		{
			lisapizza();
		}

		private void juoma()
		{

			string Nimi = "";
			double Hinta = 0;
			string lisa = "";
			double lisaH = 0;
			string koko = "";
			double size = 0;
			if (checkBox20.Checked) { Nimi = "Cola"; Hinta = 2.49; }
			else if (checkBox21.Checked) { Nimi = "Fanta"; Hinta = 2.49; }
			else if (checkBox22.Checked) { Nimi = "Sprite"; Hinta = 2.49; }
			else if (checkBox23.Checked) { Nimi = "Pepsi"; Hinta = 2.49; }
			else
			{
				MessageBox.Show("Valitse Juoma");
				return;
			}
			if (checkBox24.Checked == false)
			{
				lisaH = 2.0;
			}
			else
			{
				lisaH = 1;
			}

			if (radioButton1.Checked == true)
			{
				koko = "S";
				size = 0.50;
			}
			else if (radioButton2.Checked == true)
			{
				koko = "M";
				size = 1.0;
			}
			else if (radioButton3.Checked == true)
			{
				koko = "L";
				size = 2.0;
			}
			else if (radioButton4.Checked == true)
			{
				koko = "S";
				size = 0.50;
			}
			else if (radioButton5.Checked == true)
			{
				koko = "M";
				size = 1.0;
			}
			else if (radioButton6.Checked == true)
			{
				koko = "L";
				size = 2.0;
			}
			else if (radioButton7.Checked == true)
			{
				koko = "S";
				size = 0.50;
			}
			else if (radioButton8.Checked == true)
			{
				koko = "M";
				size = 1.0;
			}
			else if (radioButton9.Checked == true)
			{
				koko = "L";
				size = 2.0;
			}
			else if (radioButton10.Checked == true)
			{
				koko = "S";
				size = 0.50;
			}
			else if (radioButton11.Checked == true)
			{
				koko = "M";
				size = 1.0;
			}
			else if (radioButton12.Checked == true)
			{
				koko = "L";
				size = 2.0;
			}
			else
			{
				koko = "S";
				size = 0.50;
			}

			double loppuSumma = Hinta + lisaH + size;
			dataGridView1.Rows.Add(Nimi, lisa, koko, 1, loppuSumma);

			nykyinenSumma += loppuSumma;
			label4.Text = nykyinenSumma.ToString("0.00") + " €";
			checkBox20.Checked = false;
			checkBox21.Checked = false;
			checkBox22.Checked = false;
			checkBox23.Checked = false;
			checkBox24.Checked = false;
			radioButton1.Checked = false;
			radioButton2.Checked = false;
			radioButton3.Checked = false;
			radioButton4.Checked = false;
			radioButton5.Checked = false;
			radioButton6.Checked = false;
			radioButton7.Checked = false;
			radioButton8.Checked = false;
			radioButton9.Checked = false;
			radioButton10.Checked = false;
			radioButton11.Checked = false;
			radioButton12.Checked = false;


		}

		private void lisapizza()
		{
			string Nimi = "";
			double Hinta = 0;
			string lisa = "";
			double lisaH = 0;
			string koko = comboBox1.SelectedItem?.ToString()??"Normaali";

			if (checkBox1.Checked) { Nimi = "Pepperoni"; Hinta = 12.0; }
			else if (checkBox2.Checked) { Nimi = "Margarita"; Hinta = 10.0; }
			else if (checkBox3.Checked) { Nimi = "BBQ chicken"; Hinta = 13.0; }
			else if (checkBox4.Checked) { Nimi = "Supreme"; Hinta = 12.0; }
			else if (checkBox5.Checked) { Nimi = "Veggie Lovers"; Hinta = 11.0; }
			else if (checkBox6.Checked) { Nimi = "Super supreme"; Hinta = 15.0; }
			else
			{
				MessageBox.Show("Valitse pizza");
				return;
			}

			int count = 0;
			foreach (Control c in groupBox5.Controls)
			{
				if (c is CheckBox cb && cb.Checked)
				{
					if (count < 2)
					{
						lisa += cb.Text + ", ";
						lisaH += 1.0;
						count++;
					}
					else
					{
						cb.Checked = false;
					}
				}
			}
			lisa = lisa.TrimEnd(' ', ',');


			double size = 0;
			if (koko == "M") size = 2.0;
			else if (koko == "L") size = 5.0;
			else if (koko == "SUPER SIZE") size = 8.0;

			double loppuSumma = Hinta + lisaH + size;
			dataGridView1.Rows.Add(Nimi, lisa, koko, 1, loppuSumma);

			nykyinenSumma += loppuSumma;
			label4.Text = nykyinenSumma.ToString("0.00") + " €";

			checkBox1.Checked = false;
			checkBox2.Checked = false;
			checkBox3.Checked = false;
			checkBox4.Checked = false;
			checkBox5.Checked = false;
			checkBox6.Checked = false;
			checkBox7.Checked = false;
			checkBox8.Checked = false;
			checkBox9.Checked = false;
			checkBox10.Checked = false;
			checkBox11.Checked = false;
			checkBox12.Checked = false;
			checkBox13.Checked = false;
			checkBox14.Checked = false;
			checkBox15.Checked = false;
			checkBox16.Checked = false;
			checkBox17.Checked = false;
			checkBox18.Checked = false;
			checkBox19.Checked = false;

		}
		private void checkBox7_CheckedChanged(object sender, EventArgs e)
		{
			groupBox5.Visible = checkBox7.Checked;

		}
		private void checkBox8_CheckedChanged_1(object sender, EventArgs e)
		{
			groupBox5.Visible = checkBox8.Checked;
		}

		private void checkBox9_CheckedChanged(object sender, EventArgs e)
		{
			groupBox5.Visible = checkBox9.Checked;
		}

		private void checkBox10_CheckedChanged(object sender, EventArgs e)
		{
			groupBox5.Visible = checkBox10.Checked;
		}

		private void checkBox11_CheckedChanged(object sender, EventArgs e)
		{
			groupBox5.Visible = checkBox11.Checked;
		}

		private void checkBox12_CheckedChanged(object sender, EventArgs e)
		{
			groupBox5.Visible = checkBox12.Checked;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				foreach (DataGridViewRow row in dataGridView1.SelectedRows)
				{
					if (!row.IsNewRow)
					{ 
						double r_hinta = Convert.ToDouble(row.Cells[4].Value);
						nykyinenSumma -= r_hinta;
						dataGridView1.Rows.Remove(row);
					}
				}

				if (nykyinenSumma < 0) nykyinenSumma = 0;
				label4.Text = nykyinenSumma.ToString("0.00") + " €";
			}
			else
			{
				MessageBox.Show("Valitse ensin poistettava rivi!"); // เตือนถ้าไม่ได้คลิกเลือกแถวที่จะลบ
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{


			IsoAiti.kuiti = nykyinenSumma; 
			IsoAiti.kuitisisalto = "";

			
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (row.Cells[0].Value != null) // jos rivissa toeto
				{
					string nimi = row.Cells[0].Value.ToString();       // pizza
					string topping = row.Cells[1].Value.ToString();    // toping
					string koko = row.Cells[2].Value.ToString();       // size
					string hinta = row.Cells[4].Value.ToString();      // hinta

					
					IsoAiti.kuitisisalto += $"{nimi} ({koko})\n  > {topping} \n  Hinta: {hinta} €\n--------------------\n";
				}
			}

		
			Maksu payForm = new Maksu();
			payForm.ShowDialog();

		}

		private void button9_Click(object sender, EventArgs e)
		{
			history his = new history();
			his.Show();
			this.Hide();
		}

		private void lisa_cola_Click(object sender, EventArgs e)
		{
			juoma();
		}

		private void lisa_fanta_Click(object sender, EventArgs e)
		{
			juoma();
		}

		private void lisa_sprite_Click(object sender, EventArgs e)
		{
			juoma();
		}

		private void lisa_pepsi_Click(object sender, EventArgs e)
		{
			juoma();
		}
	}
}
