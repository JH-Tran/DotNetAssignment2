namespace CarServiceSystem.Forms
{
    partial class MechanicMainMenu
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
            PersonalDetailsBtn = new Button();
            LookupCarBtn = new Button();
            AddServiceLogBtn = new Button();
            ViewScheduleBtn = new Button();
            panel1 = new Panel();
            label1 = new Label();
            lookupCar1 = new LookupCar();
            mechanicDetails1 = new MechanicDetails();
            addServiceLog1 = new AddServiceLog();
            viewSchedule1 = new ViewSchedule();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PersonalDetailsBtn
            // 
            PersonalDetailsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PersonalDetailsBtn.Location = new Point(42, 54);
            PersonalDetailsBtn.Name = "PersonalDetailsBtn";
            PersonalDetailsBtn.Size = new Size(130, 31);
            PersonalDetailsBtn.TabIndex = 1;
            PersonalDetailsBtn.Text = "Personal Details";
            PersonalDetailsBtn.UseVisualStyleBackColor = true;
            PersonalDetailsBtn.Click += PersonalDetailsBtn_Click;
            // 
            // LookupCarBtn
            // 
            LookupCarBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LookupCarBtn.Location = new Point(42, 110);
            LookupCarBtn.Name = "LookupCarBtn";
            LookupCarBtn.Size = new Size(130, 31);
            LookupCarBtn.TabIndex = 2;
            LookupCarBtn.Text = "Lookup Car";
            LookupCarBtn.UseVisualStyleBackColor = true;
            LookupCarBtn.Click += LookupCarBtn_Click;
            // 
            // AddServiceLogBtn
            // 
            AddServiceLogBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddServiceLogBtn.Location = new Point(42, 175);
            AddServiceLogBtn.Name = "AddServiceLogBtn";
            AddServiceLogBtn.Size = new Size(130, 31);
            AddServiceLogBtn.TabIndex = 3;
            AddServiceLogBtn.Text = "Add Service Log";
            AddServiceLogBtn.UseVisualStyleBackColor = true;
            AddServiceLogBtn.Click += AddServiceLogBtn_Click;
            // 
            // ViewScheduleBtn
            // 
            ViewScheduleBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ViewScheduleBtn.Location = new Point(42, 236);
            ViewScheduleBtn.Name = "ViewScheduleBtn";
            ViewScheduleBtn.Size = new Size(130, 31);
            ViewScheduleBtn.TabIndex = 4;
            ViewScheduleBtn.Text = "View Schedule";
            ViewScheduleBtn.UseVisualStyleBackColor = true;
            ViewScheduleBtn.Click += ViewScheduleBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(PersonalDetailsBtn);
            panel1.Controls.Add(ViewScheduleBtn);
            panel1.Controls.Add(LookupCarBtn);
            panel1.Controls.Add(AddServiceLogBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 458);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(395, 73);
            label1.Name = "label1";
            label1.Size = new Size(135, 37);
            label1.TabIndex = 6;
            label1.Text = "Welcome!";
            // 
            // lookupCar1
            // 
            lookupCar1.Location = new Point(197, 0);
            lookupCar1.Name = "lookupCar1";
            lookupCar1.Size = new Size(591, 458);
            lookupCar1.TabIndex = 7;
            // 
            // mechanicDetails1
            // 
            mechanicDetails1.Location = new Point(197, 0);
            mechanicDetails1.Name = "mechanicDetails1";
            mechanicDetails1.Size = new Size(591, 458);
            mechanicDetails1.TabIndex = 8;
            // 
            // addServiceLog1
            // 
            addServiceLog1.Location = new Point(197, 0);
            addServiceLog1.Name = "addServiceLog1";
            addServiceLog1.Size = new Size(591, 458);
            addServiceLog1.TabIndex = 9;
            // 
            // viewSchedule1
            // 
            viewSchedule1.Location = new Point(197, 0);
            viewSchedule1.Name = "viewSchedule1";
            viewSchedule1.Size = new Size(591, 458);
            viewSchedule1.TabIndex = 10;
            // 
            // MechanicMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 458);
            Controls.Add(viewSchedule1);
            Controls.Add(addServiceLog1);
            Controls.Add(mechanicDetails1);
            Controls.Add(lookupCar1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MechanicMainMenu";
            Text = "Car Service System";
            Load += MechanicMainMenu_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button PersonalDetailsBtn;
        private Button LookupCarBtn;
        private Button AddServiceLogBtn;
        private Button ViewScheduleBtn;
        private Panel panel1;
        private Label label1;
        private LookupCar lookupCar1;
        private MechanicDetails mechanicDetails1;
        private AddServiceLog addServiceLog1;
        private ViewSchedule viewSchedule1;
    }
}