
namespace ForMum
{
	partial class AddDrugForm
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
			this.DrugNameBox = new System.Windows.Forms.TextBox();
			this.AddDrugButton = new System.Windows.Forms.Button();
			this.TabletsCountLabel = new System.Windows.Forms.Label();
			this.DosageLabel = new System.Windows.Forms.Label();
			this.DeleteDosageButton = new System.Windows.Forms.Button();
			this.AddDosageButton = new System.Windows.Forms.Button();
			this.DeleteTabletsCountButton = new System.Windows.Forms.Button();
			this.AddTabletsCountButton = new System.Windows.Forms.Button();
			this.TabletsCountComboBox = new System.Windows.Forms.ComboBox();
			this.DosageComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// DrugNameLabel
			// 
			this.DrugNameLabel.AutoSize = true;
			this.DrugNameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DrugNameLabel.Location = new System.Drawing.Point(12, 9);
			this.DrugNameLabel.Name = "DrugNameLabel";
			this.DrugNameLabel.Size = new System.Drawing.Size(187, 25);
			this.DrugNameLabel.TabIndex = 0;
			this.DrugNameLabel.Text = "Название лекарства";
			this.DrugNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// DrugNameBox
			// 
			this.DrugNameBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DrugNameBox.Location = new System.Drawing.Point(12, 37);
			this.DrugNameBox.Name = "DrugNameBox";
			this.DrugNameBox.Size = new System.Drawing.Size(187, 29);
			this.DrugNameBox.TabIndex = 1;
			this.DrugNameBox.TextChanged += new System.EventHandler(this.DrugNameBox_TextChanged);
			this.DrugNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DrugNameBox_KeyDown);
			// 
			// AddDrugButton
			// 
			this.AddDrugButton.AutoSize = true;
			this.AddDrugButton.Enabled = false;
			this.AddDrugButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AddDrugButton.Location = new System.Drawing.Point(12, 221);
			this.AddDrugButton.Name = "AddDrugButton";
			this.AddDrugButton.Size = new System.Drawing.Size(187, 31);
			this.AddDrugButton.TabIndex = 2;
			this.AddDrugButton.Text = "Добавить";
			this.AddDrugButton.UseVisualStyleBackColor = true;
			this.AddDrugButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddDrugButton_MouseDown);
			// 
			// TabletsCountLabel
			// 
			this.TabletsCountLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TabletsCountLabel.Location = new System.Drawing.Point(12, 129);
			this.TabletsCountLabel.Name = "TabletsCountLabel";
			this.TabletsCountLabel.Size = new System.Drawing.Size(199, 54);
			this.TabletsCountLabel.TabIndex = 12;
			this.TabletsCountLabel.Text = "Количество таблеток в упаковке";
			// 
			// DosageLabel
			// 
			this.DosageLabel.AutoSize = true;
			this.DosageLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DosageLabel.Location = new System.Drawing.Point(12, 69);
			this.DosageLabel.Name = "DosageLabel";
			this.DosageLabel.Size = new System.Drawing.Size(106, 25);
			this.DosageLabel.TabIndex = 10;
			this.DosageLabel.Text = "Дозировка";
			// 
			// DeleteDosageButton
			// 
			this.DeleteDosageButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DeleteDosageButton.Location = new System.Drawing.Point(170, 97);
			this.DeleteDosageButton.Name = "DeleteDosageButton";
			this.DeleteDosageButton.Size = new System.Drawing.Size(29, 29);
			this.DeleteDosageButton.TabIndex = 15;
			this.DeleteDosageButton.Text = "-";
			this.DeleteDosageButton.UseVisualStyleBackColor = true;
			// 
			// AddDosageButton
			// 
			this.AddDosageButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AddDosageButton.Location = new System.Drawing.Point(135, 97);
			this.AddDosageButton.Name = "AddDosageButton";
			this.AddDosageButton.Size = new System.Drawing.Size(29, 29);
			this.AddDosageButton.TabIndex = 14;
			this.AddDosageButton.Text = "+";
			this.AddDosageButton.UseVisualStyleBackColor = true;
			this.AddDosageButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddDosageButton_MouseDown);
			// 
			// DeleteTabletsCountButton
			// 
			this.DeleteTabletsCountButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DeleteTabletsCountButton.Location = new System.Drawing.Point(170, 186);
			this.DeleteTabletsCountButton.Name = "DeleteTabletsCountButton";
			this.DeleteTabletsCountButton.Size = new System.Drawing.Size(29, 29);
			this.DeleteTabletsCountButton.TabIndex = 17;
			this.DeleteTabletsCountButton.Text = "-";
			this.DeleteTabletsCountButton.UseVisualStyleBackColor = true;
			// 
			// AddTabletsCountButton
			// 
			this.AddTabletsCountButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AddTabletsCountButton.Location = new System.Drawing.Point(135, 186);
			this.AddTabletsCountButton.Name = "AddTabletsCountButton";
			this.AddTabletsCountButton.Size = new System.Drawing.Size(29, 29);
			this.AddTabletsCountButton.TabIndex = 16;
			this.AddTabletsCountButton.Text = "+";
			this.AddTabletsCountButton.UseVisualStyleBackColor = true;
			this.AddTabletsCountButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddTabletsCountButton_MouseDown);
			// 
			// TabletsCountComboBox
			// 
			this.TabletsCountComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TabletsCountComboBox.FormattingEnabled = true;
			this.TabletsCountComboBox.Location = new System.Drawing.Point(12, 186);
			this.TabletsCountComboBox.Name = "TabletsCountComboBox";
			this.TabletsCountComboBox.Size = new System.Drawing.Size(117, 29);
			this.TabletsCountComboBox.TabIndex = 13;
			// 
			// DosageComboBox
			// 
			this.DosageComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DosageComboBox.FormattingEnabled = true;
			this.DosageComboBox.Location = new System.Drawing.Point(12, 97);
			this.DosageComboBox.Name = "DosageComboBox";
			this.DosageComboBox.Size = new System.Drawing.Size(117, 29);
			this.DosageComboBox.TabIndex = 11;
			this.DosageComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DosageComboBox_KeyPress);
			// 
			// AddDrugForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(211, 261);
			this.Controls.Add(this.DeleteTabletsCountButton);
			this.Controls.Add(this.AddTabletsCountButton);
			this.Controls.Add(this.DeleteDosageButton);
			this.Controls.Add(this.AddDosageButton);
			this.Controls.Add(this.TabletsCountComboBox);
			this.Controls.Add(this.TabletsCountLabel);
			this.Controls.Add(this.DosageComboBox);
			this.Controls.Add(this.DosageLabel);
			this.Controls.Add(this.AddDrugButton);
			this.Controls.Add(this.DrugNameBox);
			this.Controls.Add(this.DrugNameLabel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddDrugForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Добавить лекарство";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label DrugNameLabel;
		private System.Windows.Forms.TextBox DrugNameBox;
		private System.Windows.Forms.Button AddDrugButton;
		private System.Windows.Forms.Label TabletsCountLabel;
		private System.Windows.Forms.Label DosageLabel;
		private System.Windows.Forms.Button DeleteDosageButton;
		private System.Windows.Forms.Button AddDosageButton;
		private System.Windows.Forms.Button DeleteTabletsCountButton;
		private System.Windows.Forms.Button AddTabletsCountButton;
		private System.Windows.Forms.ComboBox TabletsCountComboBox;
		private System.Windows.Forms.ComboBox DosageComboBox;
	}
}