using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ForMum
{
	public partial class AddDrugForm : Form
	{
		public AddDrugForm()
		{
			InitializeComponent();
		}

		private void addDrug()
		{
			if (DrugNameBox.TextLength > 0)
			{
				MainForm main = (MainForm)Application.OpenForms["MainForm"];
				MainForm.Drug drug = new MainForm.Drug();
				drug.Name = DrugNameBox.Text;
				for (int i = 0; i < DosageComboBox.Items.Count; i++)
				{
					drug.Dosage.Add(Convert.ToDouble(DosageComboBox.Items[i]));
				}
				for (int i = 0; i < TabletsCountComboBox.Items.Count; i++)
				{
					drug.TabletsCount.Add(Convert.ToDouble(TabletsCountComboBox.Items[i]));
				}
				main.AddDrug(drug);
				Close();
			}
		}

		private void AddDrugButton_MouseDown(object sender, MouseEventArgs e)
		{
			addDrug();
		}

		private void DrugNameBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				addDrug();
			}
		}

		private void DrugNameBox_TextChanged(object sender, EventArgs e)
		{
			AddDrugButton.Enabled = DrugNameBox.TextLength > 0 ? true : false;
		}

		private void AddDosageButton_MouseDown(object sender, MouseEventArgs e)
		{
			DosageComboBox.Items.Add(DosageComboBox.Text);
		}

		private void AddTabletsCountButton_MouseDown(object sender, MouseEventArgs e)
		{
			TabletsCountComboBox.Items.Add(TabletsCountComboBox.Text);
		}

		private void DosageComboBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(Char.IsDigit(e.KeyChar)))
			{
				if (e.KeyChar != (char)Keys.Back)
				{
					e.Handled = true;
				}
			}
		}
	}
}
