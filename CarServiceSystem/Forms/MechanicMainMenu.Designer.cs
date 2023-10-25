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
            label1 = new Label();
            PersonalDetailsBtn = new Button();
            LookupCarBtn = new Button();
            AddServiceLogBtn = new Button();
            ViewScheduleBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(239, 9);
            label1.Name = "label1";
            label1.Size = new Size(294, 37);
            label1.TabIndex = 0;
            label1.Text = "Mechanic Home Page";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // PersonalDetailsBtn
            // 
            PersonalDetailsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PersonalDetailsBtn.Location = new Point(319, 94);
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
            LookupCarBtn.Location = new Point(319, 152);
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
            AddServiceLogBtn.Location = new Point(319, 213);
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
            ViewScheduleBtn.Location = new Point(319, 275);
            ViewScheduleBtn.Name = "ViewScheduleBtn";
            ViewScheduleBtn.Size = new Size(130, 31);
            ViewScheduleBtn.TabIndex = 4;
            ViewScheduleBtn.Text = "View Schedule";
            ViewScheduleBtn.UseVisualStyleBackColor = true;
            ViewScheduleBtn.Click += ViewScheduleBtn_Click;
            // 
            // MechanicMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ViewScheduleBtn);
            Controls.Add(AddServiceLogBtn);
            Controls.Add(LookupCarBtn);
            Controls.Add(PersonalDetailsBtn);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MechanicMainMenu";
            Text = "MechanicMainMenu";
            Load += MechanicMainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button PersonalDetailsBtn;
        private Button LookupCarBtn;
        private Button AddServiceLogBtn;
        private Button ViewScheduleBtn;
    }
}