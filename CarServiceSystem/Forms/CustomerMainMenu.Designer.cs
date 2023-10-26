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
            // button1
            // 
            CustomerDetailButton.Location = new Point(10, 37);
            CustomerDetailButton.Name = "button1";
            CustomerDetailButton.Size = new Size(176, 34);
            CustomerDetailButton.TabIndex = 0;
            CustomerDetailButton.Text = "Customer Details";
            CustomerDetailButton.UseVisualStyleBackColor = true;
            CustomerDetailButton.Click += ViewCustomerDetailClick;
            // 
            // ViewAllCar
            // 
            ViewAllCarButton.Location = new Point(206, 37);
            ViewAllCarButton.Name = "ViewAllCar";
            ViewAllCarButton.Size = new Size(176, 34);
            ViewAllCarButton.TabIndex = 1;
            ViewAllCarButton.Text = "View All Cars";
            ViewAllCarButton.UseVisualStyleBackColor = true;
            ViewAllCarButton.Click += ViewAllCarsClick;
            // 
            // button3
            // 
            ViewScheduleButton.Location = new Point(399, 37);
            ViewScheduleButton.Name = "button3";
            ViewScheduleButton.Size = new Size(176, 34);
            ViewScheduleButton.TabIndex = 2;
            ViewScheduleButton.Text = "View Scheduled Service";
            ViewScheduleButton.UseVisualStyleBackColor = true;
            ViewScheduleButton.Click += ViewScheduleClick;
            // 
            // button2
            // 
            AddCarButton.Location = new Point(592, 39);
            AddCarButton.Name = "button2";
            AddCarButton.Size = new Size(176, 30);
            AddCarButton.TabIndex = 3;
            AddCarButton.Text = "Add Car";
            AddCarButton.UseVisualStyleBackColor = true;
            AddCarButton.Click += AddCarClick;
            // 
            // label1
            // 
            CompanyTitle.AutoSize = true;
            CompanyTitle.Location = new Point(10, 5);
            CompanyTitle.Name = "label1";
            CompanyTitle.Size = new Size(98, 20);
            CompanyTitle.TabIndex = 4;
            CompanyTitle.Text = "Car Mechanic";
            // 
            // panel1
            // 
            HeaderPanel.Controls.Add(CompanyTitle);
            HeaderPanel.Controls.Add(AddCarButton);
            HeaderPanel.Controls.Add(ViewScheduleButton);
            HeaderPanel.Controls.Add(ViewAllCarButton);
            HeaderPanel.Controls.Add(CustomerDetailButton);
            HeaderPanel.Location = new Point(0, 0);
            HeaderPanel.Name = "panel1";
            HeaderPanel.Size = new Size(800, 450);
            HeaderPanel.TabIndex = 5;
            // 
            // panel2
            // 
            InformationPanel.Controls.Add(AddCar1);
            InformationPanel.Controls.Add(ViewCustomerSchedule1);
            InformationPanel.Controls.Add(CustomerDetails1);
            InformationPanel.Controls.Add(ViewAllCars1);
            InformationPanel.Location = new Point(-1, 77);
            InformationPanel.Name = "panel2";
            InformationPanel.Size = new Size(802, 373);
            InformationPanel.TabIndex = 6;
            // 
            // addCar1
            // 
            AddCar1.Location = new Point(-1, -2);
            AddCar1.Name = "addCar1";
            AddCar1.Size = new Size(805, 372);
            AddCar1.TabIndex = 4;
            // 
            // viewCustomerSchedule1
            // 
            ViewCustomerSchedule1.Location = new Point(1, -2);
            ViewCustomerSchedule1.Name = "viewCustomerSchedule1";
            ViewCustomerSchedule1.Size = new Size(803, 372);
            ViewCustomerSchedule1.TabIndex = 3;
            // 
            // customerDetails1
            // 
            CustomerDetails1.Location = new Point(-1, -2);
            CustomerDetails1.Name = "customerDetails1";
            CustomerDetails1.Size = new Size(802, 375);
            CustomerDetails1.TabIndex = 2;
            // 
            // viewAllCars1
            // 
            ViewAllCars1.BackColor = SystemColors.ActiveCaption;
            ViewAllCars1.Location = new Point(0, 0);
            ViewAllCars1.Name = "viewAllCars1";
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