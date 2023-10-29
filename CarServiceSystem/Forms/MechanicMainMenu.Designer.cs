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
            MenuPnl = new Panel();
            WelcomeLbl = new Label();
            DisplayPnl = new Panel();
            addServiceLog1 = new AddServiceLog();
            viewSchedule1 = new ViewSchedule();
            mechanicDetails1 = new MechanicDetails();
            lookupCar1 = new LookupCar();
            MenuPnl.SuspendLayout();
            DisplayPnl.SuspendLayout();
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
            // MenuPnl
            // 
            MenuPnl.Controls.Add(PersonalDetailsBtn);
            MenuPnl.Controls.Add(ViewScheduleBtn);
            MenuPnl.Controls.Add(LookupCarBtn);
            MenuPnl.Controls.Add(AddServiceLogBtn);
            MenuPnl.Dock = DockStyle.Left;
            MenuPnl.Location = new Point(0, 0);
            MenuPnl.Name = "MenuPnl";
            MenuPnl.Size = new Size(200, 529);
            MenuPnl.TabIndex = 5;
            // 
            // WelcomeLbl
            // 
            WelcomeLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            WelcomeLbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            WelcomeLbl.Location = new Point(200, 34);
            WelcomeLbl.Name = "WelcomeLbl";
            WelcomeLbl.Size = new Size(713, 51);
            WelcomeLbl.TabIndex = 6;
            WelcomeLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // DisplayPnl
            // 
            DisplayPnl.AutoScroll = true;
            DisplayPnl.Controls.Add(addServiceLog1);
            DisplayPnl.Controls.Add(viewSchedule1);
            DisplayPnl.Controls.Add(mechanicDetails1);
            DisplayPnl.Controls.Add(lookupCar1);
            DisplayPnl.Dock = DockStyle.Fill;
            DisplayPnl.Location = new Point(200, 0);
            DisplayPnl.Name = "DisplayPnl";
            DisplayPnl.Size = new Size(713, 529);
            DisplayPnl.TabIndex = 7;
            // 
            // addServiceLog1
            // 
            addServiceLog1.AutoScroll = true;
            addServiceLog1.Dock = DockStyle.Fill;
            addServiceLog1.Location = new Point(0, 0);
            addServiceLog1.Name = "addServiceLog1";
            addServiceLog1.Size = new Size(713, 529);
            addServiceLog1.TabIndex = 0;
            addServiceLog1.Load += addServiceLog1_Load;
            // 
            // viewSchedule1
            // 
            viewSchedule1.Dock = DockStyle.Fill;
            viewSchedule1.Location = new Point(0, 0);
            viewSchedule1.Name = "viewSchedule1";
            viewSchedule1.Size = new Size(713, 529);
            viewSchedule1.TabIndex = 3;
            // 
            // mechanicDetails1
            // 
            mechanicDetails1.Dock = DockStyle.Fill;
            mechanicDetails1.Location = new Point(0, 0);
            mechanicDetails1.Name = "mechanicDetails1";
            mechanicDetails1.Size = new Size(713, 529);
            mechanicDetails1.TabIndex = 2;
            mechanicDetails1.Load += mechanicDetails1_Load;
            // 
            // lookupCar1
            // 
            lookupCar1.Dock = DockStyle.Fill;
            lookupCar1.Location = new Point(0, 0);
            lookupCar1.Name = "lookupCar1";
            lookupCar1.Size = new Size(713, 529);
            lookupCar1.TabIndex = 1;
            // 
            // MechanicMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(913, 529);
            Controls.Add(DisplayPnl);
            Controls.Add(WelcomeLbl);
            Controls.Add(MenuPnl);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MechanicMainMenu";
            Text = "Car Service System";
            FormClosing += MechanicMainMenu_FormClosing;
            Load += MechanicMainMenu_Load;
            MenuPnl.ResumeLayout(false);
            DisplayPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button PersonalDetailsBtn;
        private Button LookupCarBtn;
        private Button AddServiceLogBtn;
        private Button ViewScheduleBtn;
        private Panel MenuPnl;
        private Label WelcomeLbl;
        private Panel DisplayPnl;
        private ViewSchedule viewSchedule1;
        private MechanicDetails mechanicDetails1;
        private LookupCar lookupCar1;
        private AddServiceLog addServiceLog1;
    }
}