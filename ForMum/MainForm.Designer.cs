
namespace ForMum
{
	partial class MainForm
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
			this.DrugNameLabel = new System.Windows.Forms.Label();
			this.AddDrugButton = new System.Windows.Forms.Button();
			this.DeleteDragButton = new System.Windows.Forms.Button();
			this.DrugNameList = new System.Windows.Forms.ListBox();
			this.ReceptionCountLabel = new System.Windows.Forms.Label();
			this.DrugDosageLabel = new System.Windows.Forms.Label();
			this.DaysCountLabel = new System.Windows.Forms.Label();
			this.EditButton = new System.Windows.Forms.Button();
			this.ReceptionDosageTextBox = new System.Windows.Forms.TextBox();
			this.DaysCountTextBox = new System.Windows.Forms.TextBox();
			this.ReceptionCountTextBox = new System.Windows.Forms.TextBox();
			this.TabletsCountComboBox = new System.Windows.Forms.ComboBox();
			this.TabletsCountLabel = new System.Windows.Forms.Label();
			this.DosageComboBox = new System.Windows.Forms.ComboBox();
			this.DosageLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// DrugNameLabel
			// 
			this.DrugNameLabel.AutoSize = true;
			this.DrugNameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DrugNameLabel.Location = new System.Drawing.Point(12, 9);
			this.DrugNameLabel.Name = "DrugNameLabel";
			this.DrugNameLabel.Size = new System.Drawing.Size(183, 25);
			this.DrugNameLabel.TabIndex = 0;
			this.DrugNameLabel.Text = "Список препаратов";
			// 
			// AddDrugButton
			// 
			this.AddDrugButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AddDrugButton.Location = new System.Drawing.Point(293, 37);
			this.AddDrugButton.Name = "AddDrugButton";
			this.AddDrugButton.Size = new System.Drawing.Size(29, 29);
			this.AddDrugButton.TabIndex = 2;
			this.AddDrugButton.Text = "+";
			this.AddDrugButton.UseVisualStyleBackColor = true;
			this.AddDrugButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddDrugButton_MouseDown);
			this.AddDrugButton.MouseEnter += new System.EventHandler(this.AddDrugButton_MouseEnter);
			// 
			// DeleteDragButton
			// 
			this.DeleteDragButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DeleteDragButton.Location = new System.Drawing.Point(293, 107);
			this.DeleteDragButton.Name = "DeleteDragButton";
			this.DeleteDragButton.Size = new System.Drawing.Size(29, 29);
			this.DeleteDragButton.TabIndex = 4;
			this.DeleteDragButton.Text = "-";
			this.DeleteDragButton.UseVisualStyleBackColor = true;
			this.DeleteDragButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DeleteDragButton_MouseDown);
			this.DeleteDragButton.MouseEnter += new System.EventHandler(this.DeleteDragButton_MouseEnter);
			// 
			// DrugNameList
			// 
			this.DrugNameList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DrugNameList.FormattingEnabled = true;
			this.DrugNameList.ItemHeight = 21;
			this.DrugNameList.Location = new System.Drawing.Point(13, 37);
			this.DrugNameList.Name = "DrugNameList";
			this.DrugNameList.Size = new System.Drawing.Size(274, 382);
			this.DrugNameList.TabIndex = 10;
			this.DrugNameList.SelectedIndexChanged += new System.EventHandler(this.DrugNameList_SelectedIndexChanged);
			// 
			// ReceptionCountLabel
			// 
			this.ReceptionCountLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ReceptionCountLabel.Location = new System.Drawing.Point(342, 158);
			this.ReceptionCountLabel.Name = "ReceptionCountLabel";
			this.ReceptionCountLabel.Size = new System.Drawing.Size(196, 53);
			this.ReceptionCountLabel.TabIndex = 11;
			this.ReceptionCountLabel.Text = "Количество приемов в день";
			// 
			// DrugDosageLabel
			// 
			this.DrugDosageLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DrugDosageLabel.Location = new System.Drawing.Point(342, 246);
			this.DrugDosageLabel.Name = "DrugDosageLabel";
			this.DrugDosageLabel.Size = new System.Drawing.Size(196, 53);
			this.DrugDosageLabel.TabIndex = 13;
			this.DrugDosageLabel.Text = "Доза препарата за прием";
			// 
			// DaysCountLabel
			// 
			this.DaysCountLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DaysCountLabel.Location = new System.Drawing.Point(342, 334);
			this.DaysCountLabel.Name = "DaysCountLabel";
			this.DaysCountLabel.Size = new System.Drawing.Size(196, 53);
			this.DaysCountLabel.TabIndex = 15;
			this.DaysCountLabel.Text = "Количество дней приема";
			// 
			// EditButton
			// 
			this.EditButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.EditButton.Image = global::ForMum.Properties.Resources.pencil2;
			this.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.EditButton.Location = new System.Drawing.Point(293, 72);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(29, 29);
			this.EditButton.TabIndex = 17;
			this.EditButton.UseVisualStyleBackColor = true;
			// 
			// ReceptionDosageTextBox
			// 
			this.ReceptionDosageTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ReceptionDosageTextBox.Location = new System.Drawing.Point(342, 302);
			this.ReceptionDosageTextBox.Name = "ReceptionDosageTextBox";
			this.ReceptionDosageTextBox.Size = new System.Drawing.Size(196, 29);
			this.ReceptionDosageTextBox.TabIndex = 18;
			// 
			// DaysCountTextBox
			// 
			this.DaysCountTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DaysCountTextBox.Location = new System.Drawing.Point(342, 390);
			this.DaysCountTextBox.Name = "DaysCountTextBox";
			this.DaysCountTextBox.Size = new System.Drawing.Size(196, 29);
			this.DaysCountTextBox.TabIndex = 19;
			// 
			// ReceptionCountTextBox
			// 
			this.ReceptionCountTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ReceptionCountTextBox.Location = new System.Drawing.Point(342, 214);
			this.ReceptionCountTextBox.Name = "ReceptionCountTextBox";
			this.ReceptionCountTextBox.Size = new System.Drawing.Size(196, 29);
			this.ReceptionCountTextBox.TabIndex = 20;
			// 
			// TabletsCountComboBox
			// 
			this.TabletsCountComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TabletsCountComboBox.FormattingEnabled = true;
			this.TabletsCountComboBox.Location = new System.Drawing.Point(342, 126);
			this.TabletsCountComboBox.Name = "TabletsCountComboBox";
			this.TabletsCountComboBox.Size = new System.Drawing.Size(196, 29);
			this.TabletsCountComboBox.TabIndex = 9;
			// 
			// TabletsCountLabel
			// 
			this.TabletsCountLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TabletsCountLabel.Location = new System.Drawing.Point(342, 69);
			this.TabletsCountLabel.Name = "TabletsCountLabel";
			this.TabletsCountLabel.Size = new System.Drawing.Size(196, 54);
			this.TabletsCountLabel.TabIndex = 8;
			this.TabletsCountLabel.Text = "Количество таблеток в упаковке";
			// 
			// DosageComboBox
			// 
			this.DosageComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DosageComboBox.FormattingEnabled = true;
			this.DosageComboBox.Location = new System.Drawing.Point(342, 37);
			this.DosageComboBox.Name = "DosageComboBox";
			this.DosageComboBox.Size = new System.Drawing.Size(196, 29);
			this.DosageComboBox.TabIndex = 7;
			// 
			// DosageLabel
			// 
			this.DosageLabel.AutoSize = true;
			this.DosageLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DosageLabel.Location = new System.Drawing.Point(432, 9);
			this.DosageLabel.Name = "DosageLabel";
			this.DosageLabel.Size = new System.Drawing.Size(106, 25);
			this.DosageLabel.TabIndex = 6;
			this.DosageLabel.Text = "Дозировка";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(550, 434);
			this.Controls.Add(this.ReceptionCountTextBox);
			this.Controls.Add(this.DaysCountTextBox);
			this.Controls.Add(this.ReceptionDosageTextBox);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.DaysCountLabel);
			this.Controls.Add(this.DrugDosageLabel);
			this.Controls.Add(this.ReceptionCountLabel);
			this.Controls.Add(this.DrugNameList);
			this.Controls.Add(this.TabletsCountComboBox);
			this.Controls.Add(this.TabletsCountLabel);
			this.Controls.Add(this.DosageComboBox);
			this.Controls.Add(this.DosageLabel);
			this.Controls.Add(this.DeleteDragButton);
			this.Controls.Add(this.AddDrugButton);
			this.Controls.Add(this.DrugNameLabel);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label DrugNameLabel;
		private System.Windows.Forms.Button AddDrugButton;
		private System.Windows.Forms.Button DeleteDragButton;
		private System.Windows.Forms.ListBox DrugNameList;
		private System.Windows.Forms.Label ReceptionCountLabel;
		private System.Windows.Forms.Label DrugDosageLabel;
		private System.Windows.Forms.Label DaysCountLabel;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.TextBox ReceptionDosageTextBox;
		private System.Windows.Forms.TextBox DaysCountTextBox;
		private System.Windows.Forms.TextBox ReceptionCountTextBox;
		private System.Windows.Forms.ComboBox TabletsCountComboBox;
		private System.Windows.Forms.Label TabletsCountLabel;
		private System.Windows.Forms.ComboBox DosageComboBox;
		private System.Windows.Forms.Label DosageLabel;
	}
}