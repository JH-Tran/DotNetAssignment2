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
            button1 = new Button();
            ViewAllCar = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            viewAllCars2 = new ViewAllCars();
            panel2 = new Panel();
            addCar1 = new AddCar();
            viewCustomerSchedule1 = new ViewCustomerSchedule();
            customerDetails1 = new CustomerDetails();
            viewAllCars1 = new ViewAllCars();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(10, 37);
            button1.Name = "button1";
            button1.Size = new Size(176, 34);
            button1.TabIndex = 0;
            button1.Text = "Customer Details";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ViewCustomerDetailClick;
            // 
            // ViewAllCar
            // 
            ViewAllCar.Location = new Point(206, 37);
            ViewAllCar.Name = "ViewAllCar";
            ViewAllCar.Size = new Size(176, 34);
            ViewAllCar.TabIndex = 1;
            ViewAllCar.Text = "View All Cars";
            ViewAllCar.UseVisualStyleBackColor = true;
            ViewAllCar.Click += ViewAllCarsClick;
            // 
            // button3
            // 
            button3.Location = new Point(399, 37);
            button3.Name = "button3";
            button3.Size = new Size(176, 34);
            button3.TabIndex = 2;
            button3.Text = "View Scheduled Service";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ViewScheduleClick;
            // 
            // button2
            // 
            button2.Location = new Point(592, 39);
            button2.Name = "button2";
            button2.Size = new Size(176, 30);
            button2.TabIndex = 3;
            button2.Text = "Add Car";
            button2.UseVisualStyleBackColor = true;
            button2.Click += AddCarClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 5);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 4;
            label1.Text = "Car Mechanic";
            // 
            // panel1
            // 
            panel1.Controls.Add(viewAllCars2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(ViewAllCar);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 5;
            // 
            // viewAllCars2
            // 
            viewAllCars2.BackColor = SystemColors.ActiveCaption;
            viewAllCars2.Location = new Point(-1, 75);
            viewAllCars2.Name = "viewAllCars2";
            viewAllCars2.Size = new Size(802, 375);
            viewAllCars2.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(addCar1);
            panel2.Controls.Add(viewCustomerSchedule1);
            panel2.Controls.Add(customerDetails1);
            panel2.Controls.Add(viewAllCars1);
            panel2.Location = new Point(-1, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 373);
            panel2.TabIndex = 6;
            // 
            // addCar1
            // 
            addCar1.Location = new Point(-1, -2);
            addCar1.Name = "addCar1";
            addCar1.Size = new Size(805, 372);
            addCar1.TabIndex = 4;
            // 
            // viewCustomerSchedule1
            // 
            viewCustomerSchedule1.Location = new Point(1, -2);
            viewCustomerSchedule1.Name = "viewCustomerSchedule1";
            viewCustomerSchedule1.Size = new Size(803, 372);
            viewCustomerSchedule1.TabIndex = 3;
            // 
            // customerDetails1
            // 
            customerDetails1.Location = new Point(-1, -2);
            customerDetails1.Name = "customerDetails1";
            customerDetails1.Size = new Size(802, 375);
            customerDetails1.TabIndex = 2;
            // 
            // viewAllCars1
            // 
            viewAllCars1.BackColor = SystemColors.ActiveCaption;
            viewAllCars1.Location = new Point(0, 0);
            viewAllCars1.Name = "viewAllCars1";
            viewAllCars1.Size = new Size(801, 373);
            viewAllCars1.TabIndex = 1;
            // 
            // CustomerMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CustomerMainMenu";
            Text = "CustomerMainMenu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button ViewAllCar;
        private Button button3;
        private Button button2;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private ViewAllCars viewAllCars1;
        private CustomerDetails customerDetails1;
        private ViewAllCars viewAllCars2;
        private ViewCustomerSchedule viewCustomerSchedule1;
        private AddCar addCar1;
    }
}