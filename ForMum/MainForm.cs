using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ForMum
{
	public partial class MainForm : Form
	{
		public class Drug
		{
			public string Name;
			public List<double> Dosage;
			public List<double> TabletsCount;

			public Drug()
			{
				Dosage = new List<double>();
				TabletsCount = new List<double>();
			}
		}

		private List<Drug> Drugs;

		public MainForm()
		{
			KeyPreview = true;
			InitializeComponent();
			Drugs = new List<Drug>();
			Drug d1 = new Drug();
			Drug d2 = new Drug();
			d1.Name = "Баралгин";
			d1.Dosage.Add(2.5f);
			d1.Dosage.Add(5f);
			d1.TabletsCount.Add(10);
			d1.TabletsCount.Add(15);
			d2.Name = "Парацетамол";
			d2.Dosage.Add(5f);
			d2.Dosage.Add(10f);
			d2.TabletsCount.Add(20);
			d2.TabletsCount.Add(40);
			AddDrug(d1);
			AddDrug(d2);

		}
		private void addDrugInDrugList()
		{
			Form form = new AddDrugForm();
			form.ShowDialog();
		}

		private void deleteDrugOutOfDrugList()
		{
			int index = DrugNameList.SelectedIndex;
			if (DrugNameList.Items.Count > 0)
			{
				DrugNameList.Items.Remove(DrugNameList.SelectedItem);
				if (DrugNameList.Items.Count >= 1)
				{
					DrugNameList.SelectedIndex = index - 1;
				}
			}
		}

		public void RefreshDrugs()
		{
			int lastSelected = DrugNameList.SelectedIndex == -1 ? 0 : DrugNameList.SelectedIndex;
			for (int i = 0; i < Drugs.Count; i++)
			{
				if (!DrugNameList.Items.Contains(Drugs[i].Name))
				{
					DrugNameList.Items.Add(Drugs[i].Name);
				}
			}
			TabletsCountComboBox.Items.Clear();
			for (int i = 0; i < Drugs[lastSelected].TabletsCount.Count; i++)
			{
				TabletsCountComboBox.Items.Add(Drugs[lastSelected].TabletsCount[i]);
			}
			DosageComboBox.Items.Clear();
			for (int i = 0; i < Drugs[lastSelected].Dosage.Count; i++)
			{
				DosageComboBox.Items.Add(Drugs[lastSelected].Dosage[i]);
			}
			if (TabletsCountComboBox.Items.Count > 0)
			{
				TabletsCountComboBox.SelectedIndex = 0;
			}
			if (DosageComboBox.Items.Count > 0)
			{
				DosageComboBox.SelectedIndex = 0;
			}
		}

		public void AddDrug(Drug drug)
		{
			Drugs.Add(drug);
			RefreshDrugs();
		}

		private void AddDrugButton_MouseDown(object sender, MouseEventArgs e)
		{
			Form form = new AddDrugForm();
			form.ShowDialog();
		}

		private void DeleteDragButton_MouseDown(object sender, MouseEventArgs e)
		{
			deleteDrugOutOfDrugList();
		}

		private void AddDrugButton_MouseEnter(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(AddDrugButton, "Добавить новый препарат (F1)");
		}

		private void DeleteDragButton_MouseEnter(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(AddDrugButton, "Добавить новый препарат (F2)");
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.F1:
					addDrugInDrugList();
					break;
				case Keys.F2:
					deleteDrugOutOfDrugList();
					break;
			}
		}

		private void DrugNameList_SelectedIndexChanged(object sender, EventArgs e)
		{
			RefreshDrugs();
		}
	}
}
