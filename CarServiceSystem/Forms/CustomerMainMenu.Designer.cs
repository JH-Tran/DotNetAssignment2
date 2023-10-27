namespace CarServiceSystem.Forms
{
    partial class CustomerMainMenu
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
            CustomerDetailButton = new Button();
            ViewAllCarButton = new Button();
            ViewScheduleButton = new Button();
            AddCarButton = new Button();
            CompanyTitle = new Label();
            HeaderPanel = new Panel();
            InformationPanel = new Panel();
            AddCar1 = new AddCar();
            ViewCustomerSchedule1 = new ViewCustomerSchedule();
            CustomerDetails1 = new CustomerDetails();
            ViewAllCars1 = new ViewAllCars();
            HeaderPanel.SuspendLayout();
            InformationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CustomerDetailButton
            // 
            CustomerDetailButton.Location = new Point(10, 37);
            CustomerDetailButton.Name = "CustomerDetailButton";
            CustomerDetailButton.Size = new Size(176, 34);
            CustomerDetailButton.TabIndex = 0;
            CustomerDetailButton.Text = "Customer Details";
            CustomerDetailButton.UseVisualStyleBackColor = true;
            CustomerDetailButton.Click += ViewCustomerDetailClick;
            // 
            // ViewAllCarButton
            // 
            ViewAllCarButton.Location = new Point(206, 37);
            ViewAllCarButton.Name = "ViewAllCarButton";
            ViewAllCarButton.Size = new Size(176, 34);
            ViewAllCarButton.TabIndex = 1;
            ViewAllCarButton.Text = "View All Cars";
            ViewAllCarButton.UseVisualStyleBackColor = true;
            ViewAllCarButton.Click += ViewAllCarsClick;
            // 
            // ViewScheduleButton
            // 
            ViewScheduleButton.Location = new Point(399, 37);
            ViewScheduleButton.Name = "ViewScheduleButton";
            ViewScheduleButton.Size = new Size(176, 34);
            ViewScheduleButton.TabIndex = 2;
            ViewScheduleButton.Text = "View Scheduled Service";
            ViewScheduleButton.UseVisualStyleBackColor = true;
            ViewScheduleButton.Click += ViewScheduleClick;
            // 
            // AddCarButton
            // 
            AddCarButton.Location = new Point(592, 39);
            AddCarButton.Name = "AddCarButton";
            AddCarButton.Size = new Size(176, 30);
            AddCarButton.TabIndex = 3;
            AddCarButton.Text = "Add Car";
            AddCarButton.UseVisualStyleBackColor = true;
            AddCarButton.Click += AddCarClick;
            // 
            // CompanyTitle
            // 
            CompanyTitle.AutoSize = true;
            CompanyTitle.Location = new Point(10, 5);
            CompanyTitle.Name = "CompanyTitle";
            CompanyTitle.Size = new Size(98, 20);
            CompanyTitle.TabIndex = 4;
            CompanyTitle.Text = "Car Mechanic";
            // 
            // HeaderPanel
            // 
            HeaderPanel.Controls.Add(CompanyTitle);
            HeaderPanel.Controls.Add(AddCarButton);
            HeaderPanel.Controls.Add(ViewScheduleButton);
            HeaderPanel.Controls.Add(ViewAllCarButton);
            HeaderPanel.Controls.Add(CustomerDetailButton);
            HeaderPanel.Location = new Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(800, 450);
            HeaderPanel.TabIndex = 5;
            // 
            // InformationPanel
            // 
            InformationPanel.Controls.Add(AddCar1);
            InformationPanel.Controls.Add(ViewCustomerSchedule1);
            InformationPanel.Controls.Add(CustomerDetails1);
            InformationPanel.Controls.Add(ViewAllCars1);
            InformationPanel.Location = new Point(-1, 77);
            InformationPanel.Name = "InformationPanel";
            InformationPanel.Size = new Size(802, 373);
            InformationPanel.TabIndex = 6;
            // 
            // AddCar1
            // 
            AddCar1.Location = new Point(-1, -2);
            AddCar1.Name = "AddCar1";
            AddCar1.Size = new Size(805, 372);
            AddCar1.TabIndex = 4;
            // 
            // ViewCustomerSchedule1
            // 
            ViewCustomerSchedule1.Location = new Point(1, -2);
            ViewCustomerSchedule1.Name = "ViewCustomerSchedule1";
            ViewCustomerSchedule1.Size = new Size(803, 372);
            ViewCustomerSchedule1.TabIndex = 3;
            // 
            // CustomerDetails1
            // 
            CustomerDetails1.Location = new Point(-1, -2);
            CustomerDetails1.Name = "CustomerDetails1";
            CustomerDetails1.Size = new Size(802, 375);
            CustomerDetails1.TabIndex = 2;
            // 
            // ViewAllCars1
            // 
            ViewAllCars1.BackColor = SystemColors.ActiveCaption;
            ViewAllCars1.Location = new Point(0, 0);
            ViewAllCars1.Name = "ViewAllCars1";
            ViewAllCars1.Size = new Size(801, 373);
            ViewAllCars1.TabIndex = 1;
            // 
            // CustomerMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InformationPanel);
            Controls.Add(HeaderPanel);
            Name = "CustomerMainMenu";
            Text = "CustomerMainMenu";
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            InformationPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button CustomerDetailButton;
        private Button ViewAllCarButton;
        private Button ViewScheduleButton;
        private Button AddCarButton;
        private Label CompanyTitle;
        private Panel HeaderPanel;
        private Panel InformationPanel;
        private ViewAllCars ViewAllCars1;
        private CustomerDetails CustomerDetails1;
        private ViewCustomerSchedule ViewCustomerSchedule1;
        private AddCar AddCar1;
    }
}