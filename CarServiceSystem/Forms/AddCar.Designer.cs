namespace CarServiceSystem.Forms
{
    partial class AddCar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            CarCompanyLabel = new Label();
            carModelLabel = new Label();
            yearModelLabel = new Label();
            licenseNumberLabel = new Label();
            vehicleIdentificationNumberLabel = new Label();
            carCompanyTextBox = new TextBox();
            carModelTextBox = new TextBox();
            yearModelTextBox = new TextBox();
            licenceNumberTextBox = new TextBox();
            vehicleIdentificationNumberTextBox = new TextBox();
            odometerLabel = new Label();
            odometerTextBox = new TextBox();
            TitleAddCar = new Label();
            ConfirmAddCarButton = new Button();
            informationLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(CarCompanyLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(carModelLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(yearModelLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(licenseNumberLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(vehicleIdentificationNumberLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(carCompanyTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(carModelTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(yearModelTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(licenceNumberTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(vehicleIdentificationNumberTextBox, 1, 4);
            tableLayoutPanel1.Controls.Add(odometerLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(odometerTextBox, 1, 5);
            tableLayoutPanel1.Location = new Point(51, 63);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.Size = new Size(659, 339);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // CarCompanyLabel
            // 
            CarCompanyLabel.AutoSize = true;
            CarCompanyLabel.Location = new Point(4, 1);
            CarCompanyLabel.Name = "CarCompanyLabel";
            CarCompanyLabel.Size = new Size(48, 20);
            CarCompanyLabel.TabIndex = 0;
            CarCompanyLabel.Text = "Brand";
            // 
            // carModelLabel
            // 
            carModelLabel.AutoSize = true;
            carModelLabel.Location = new Point(4, 57);
            carModelLabel.Name = "carModelLabel";
            carModelLabel.Size = new Size(78, 20);
            carModelLabel.TabIndex = 1;
            carModelLabel.Text = "Car Model";
            // 
            // yearModelLabel
            // 
            yearModelLabel.AutoSize = true;
            yearModelLabel.Location = new Point(4, 113);
            yearModelLabel.Name = "yearModelLabel";
            yearModelLabel.Size = new Size(84, 20);
            yearModelLabel.TabIndex = 2;
            yearModelLabel.Text = "Model Year";
            // 
            // licenseNumberLabel
            // 
            licenseNumberLabel.AutoSize = true;
            licenseNumberLabel.Location = new Point(4, 169);
            licenseNumberLabel.Name = "licenseNumberLabel";
            licenseNumberLabel.Size = new Size(116, 20);
            licenseNumberLabel.TabIndex = 3;
            licenseNumberLabel.Text = "Licence Number";
            // 
            // vehicleIdentificationNumberLabel
            // 
            vehicleIdentificationNumberLabel.AutoSize = true;
            vehicleIdentificationNumberLabel.Location = new Point(4, 225);
            vehicleIdentificationNumberLabel.Name = "vehicleIdentificationNumberLabel";
            vehicleIdentificationNumberLabel.Size = new Size(206, 20);
            vehicleIdentificationNumberLabel.TabIndex = 4;
            vehicleIdentificationNumberLabel.Text = "Vehicle Identification Number";
            // 
            // carCompanyTextBox
            // 
            carCompanyTextBox.Location = new Point(322, 4);
            carCompanyTextBox.Name = "carCompanyTextBox";
            carCompanyTextBox.Size = new Size(264, 27);
            carCompanyTextBox.TabIndex = 5;
            // 
            // carModelTextBox
            // 
            carModelTextBox.Location = new Point(322, 60);
            carModelTextBox.Name = "carModelTextBox";
            carModelTextBox.Size = new Size(264, 27);
            carModelTextBox.TabIndex = 6;
            // 
            // yearModelTextBox
            // 
            yearModelTextBox.Location = new Point(322, 116);
            yearModelTextBox.Name = "yearModelTextBox";
            yearModelTextBox.Size = new Size(264, 27);
            yearModelTextBox.TabIndex = 7;
            // 
            // licenceNumberTextBox
            // 
            licenceNumberTextBox.Location = new Point(322, 172);
            licenceNumberTextBox.Name = "licenceNumberTextBox";
            licenceNumberTextBox.Size = new Size(264, 27);
            licenceNumberTextBox.TabIndex = 8;
            // 
            // vehicleIdentificationNumberTextBox
            // 
            vehicleIdentificationNumberTextBox.Location = new Point(322, 228);
            vehicleIdentificationNumberTextBox.Name = "vehicleIdentificationNumberTextBox";
            vehicleIdentificationNumberTextBox.Size = new Size(264, 27);
            vehicleIdentificationNumberTextBox.TabIndex = 9;
            // 
            // odometerLabel
            // 
            odometerLabel.AutoSize = true;
            odometerLabel.Location = new Point(4, 281);
            odometerLabel.Name = "odometerLabel";
            odometerLabel.Size = new Size(77, 20);
            odometerLabel.TabIndex = 10;
            odometerLabel.Text = "Odometer";
            // 
            // odometerTextBox
            // 
            odometerTextBox.Location = new Point(322, 284);
            odometerTextBox.Name = "odometerTextBox";
            odometerTextBox.Size = new Size(264, 27);
            odometerTextBox.TabIndex = 11;
            // 
            // TitleAddCar
            // 
            TitleAddCar.AutoSize = true;
            TitleAddCar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            TitleAddCar.Location = new Point(55, 13);
            TitleAddCar.Name = "TitleAddCar";
            TitleAddCar.Size = new Size(122, 38);
            TitleAddCar.TabIndex = 0;
            TitleAddCar.Text = "Add Car";
            // 
            // ConfirmAddCarButton
            // 
            ConfirmAddCarButton.Location = new Point(320, 460);
            ConfirmAddCarButton.Name = "ConfirmAddCarButton";
            ConfirmAddCarButton.Size = new Size(94, 29);
            ConfirmAddCarButton.TabIndex = 1;
            ConfirmAddCarButton.Text = "Confirm";
            ConfirmAddCarButton.UseVisualStyleBackColor = true;
            ConfirmAddCarButton.Click += ConfirmAddingCar;
            // 
            // informationLabel
            // 
            informationLabel.AutoSize = true;
            informationLabel.BackColor = Color.White;
            informationLabel.ForeColor = Color.Red;
            informationLabel.Location = new Point(285, 405);
            informationLabel.Name = "informationLabel";
            informationLabel.Size = new Size(170, 40);
            informationLabel.TabIndex = 2;
            informationLabel.Text = "Invalid Model Year Input\r\nInvalid Odometer Input";
            informationLabel.Visible = false;
            // 
            // AddCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(informationLabel);
            Controls.Add(ConfirmAddCarButton);
            Controls.Add(TitleAddCar);
            Controls.Add(tableLayoutPanel1);
            Name = "AddCar";
            Size = new Size(803, 517);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label TitleAddCar;
        private Label CarCompanyLabel;
        private Label carModelLabel;
        private Label yearModelLabel;
        private Button ConfirmAddCarButton;
        private Label licenseNumberLabel;
        private Label vehicleIdentificationNumberLabel;
        private TextBox carCompanyTextBox;
        private TextBox carModelTextBox;
        private TextBox yearModelTextBox;
        private TextBox licenceNumberTextBox;
        private TextBox vehicleIdentificationNumberTextBox;
        private Label odometerLabel;
        private TextBox odometerTextBox;
        private Label informationLabel;
    }
}
