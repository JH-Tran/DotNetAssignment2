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
            CustomerDetailButton.Location = new Point(9, 28);
            CustomerDetailButton.Margin = new Padding(3, 2, 3, 2);
            CustomerDetailButton.Name = "CustomerDetailButton";
            CustomerDetailButton.Size = new Size(154, 26);
            CustomerDetailButton.TabIndex = 0;
            CustomerDetailButton.Text = "Customer Details";
            CustomerDetailButton.UseVisualStyleBackColor = true;
            CustomerDetailButton.Click += ViewCustomerDetailClick;
            // 
            // ViewAllCarButton
            // 
            ViewAllCarButton.Location = new Point(180, 28);
            ViewAllCarButton.Margin = new Padding(3, 2, 3, 2);
            ViewAllCarButton.Name = "ViewAllCarButton";
            ViewAllCarButton.Size = new Size(154, 26);
            ViewAllCarButton.TabIndex = 1;
            ViewAllCarButton.Text = "View All Cars";
            ViewAllCarButton.UseVisualStyleBackColor = true;
            ViewAllCarButton.Click += ViewAllCarsClick;
            // 
            // ViewScheduleButton
            // 
            ViewScheduleButton.Location = new Point(349, 28);
            ViewScheduleButton.Margin = new Padding(3, 2, 3, 2);
            ViewScheduleButton.Name = "ViewScheduleButton";
            ViewScheduleButton.Size = new Size(154, 26);
            ViewScheduleButton.TabIndex = 2;
            ViewScheduleButton.Text = "View Scheduled Service";
            ViewScheduleButton.UseVisualStyleBackColor = true;
            ViewScheduleButton.Click += ViewScheduleClick;
            // 
            // AddCarButton
            // 
            AddCarButton.Location = new Point(518, 29);
            AddCarButton.Margin = new Padding(3, 2, 3, 2);
            AddCarButton.Name = "AddCarButton";
            AddCarButton.Size = new Size(154, 22);
            AddCarButton.TabIndex = 3;
            AddCarButton.Text = "Add Car";
            AddCarButton.UseVisualStyleBackColor = true;
            AddCarButton.Click += AddCarClick;
            // 
            // CompanyTitle
            // 
            CompanyTitle.AutoSize = true;
            CompanyTitle.Location = new Point(9, 4);
            CompanyTitle.Name = "CompanyTitle";
            CompanyTitle.Size = new Size(80, 15);
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
            HeaderPanel.Margin = new Padding(3, 2, 3, 2);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(700, 338);
            HeaderPanel.TabIndex = 5;
            // 
            // InformationPanel
            // 
            InformationPanel.Controls.Add(AddCar1);
            InformationPanel.Controls.Add(ViewCustomerSchedule1);
            InformationPanel.Controls.Add(CustomerDetails1);
            InformationPanel.Controls.Add(ViewAllCars1);
            InformationPanel.Location = new Point(-1, 58);
            InformationPanel.Margin = new Padding(3, 2, 3, 2);
            InformationPanel.Name = "InformationPanel";
            InformationPanel.Size = new Size(702, 280);
            InformationPanel.TabIndex = 6;
            // 
            // AddCar1
            // 
            AddCar1.AutoScroll = true;
            AddCar1.Location = new Point(-1, -2);
            AddCar1.Margin = new Padding(3, 2, 3, 2);
            AddCar1.Name = "AddCar1";
            AddCar1.Size = new Size(704, 279);
            AddCar1.TabIndex = 4;
            // 
            // ViewCustomerSchedule1
            // 
            ViewCustomerSchedule1.Location = new Point(1, -2);
            ViewCustomerSchedule1.Margin = new Padding(3, 2, 3, 2);
            ViewCustomerSchedule1.Name = "ViewCustomerSchedule1";
            ViewCustomerSchedule1.Size = new Size(703, 279);
            ViewCustomerSchedule1.TabIndex = 3;
            // 
            // CustomerDetails1
            // 
            CustomerDetails1.Location = new Point(-1, -2);
            CustomerDetails1.Margin = new Padding(3, 2, 3, 2);
            CustomerDetails1.Name = "CustomerDetails1";
            CustomerDetails1.Size = new Size(702, 281);
            CustomerDetails1.TabIndex = 2;
            // 
            // ViewAllCars1
            // 
            ViewAllCars1.AutoScroll = true;
            ViewAllCars1.BackColor = SystemColors.ActiveCaption;
            ViewAllCars1.Location = new Point(0, 0);
            ViewAllCars1.Margin = new Padding(3, 2, 3, 2);
            ViewAllCars1.Name = "ViewAllCars1";
            ViewAllCars1.Size = new Size(701, 280);
            ViewAllCars1.TabIndex = 1;
            // 
            // CustomerMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(InformationPanel);
            Controls.Add(HeaderPanel);
            Margin = new Padding(3, 2, 3, 2);
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