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
            panel2 = new Panel();
            customerDetails1 = new CustomerDetails();
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
            button1.Click += ViewCustomerDetail;
            // 
            // ViewAllCar
            // 
            ViewAllCar.Location = new Point(206, 37);
            ViewAllCar.Name = "ViewAllCar";
            ViewAllCar.Size = new Size(176, 34);
            ViewAllCar.TabIndex = 1;
            ViewAllCar.Text = "View All Cars";
            ViewAllCar.UseVisualStyleBackColor = true;
            ViewAllCar.Click += ViewAllCars;
            // 
            // button3
            // 
            button3.Location = new Point(399, 37);
            button3.Name = "button3";
            button3.Size = new Size(176, 34);
            button3.TabIndex = 2;
            button3.Text = "View Scheduled Service";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ViewSchedule;
            // 
            // button2
            // 
            button2.Location = new Point(592, 39);
            button2.Name = "button2";
            button2.Size = new Size(176, 30);
            button2.TabIndex = 3;
            button2.Text = "Add Car";
            button2.UseVisualStyleBackColor = true;
            button2.Click += AddCar;
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
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(ViewAllCar);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 82);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(customerDetails1);
            panel2.Location = new Point(-1, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 373);
            panel2.TabIndex = 6;
            // 
            // customerDetails1
            // 
            customerDetails1.Location = new Point(0, 0);
            customerDetails1.Name = "customerDetails1";
            customerDetails1.Size = new Size(802, 373);
            customerDetails1.TabIndex = 0;
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
        private CustomerDetails customerDetails1;
    }
}