namespace CarServiceSystem.Forms
{
    partial class MechanicDetails
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
            MechanicWorkshopLbl = new Label();
            label2 = new Label();
            FirstNameInput = new TextBox();
            LastNameInput = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SaveChangesBtn = new Button();
            MechanicEmailLbl = new Label();
            InvalidInputLbl = new Label();
            SuspendLayout();
            // 
            // MechanicWorkshopLbl
            // 
            MechanicWorkshopLbl.Anchor = AnchorStyles.Top;
            MechanicWorkshopLbl.AutoSize = true;
            MechanicWorkshopLbl.Location = new Point(168, 97);
            MechanicWorkshopLbl.Name = "MechanicWorkshopLbl";
            MechanicWorkshopLbl.Size = new Size(79, 15);
            MechanicWorkshopLbl.TabIndex = 0;
            MechanicWorkshopLbl.Text = "Workshop:     ";
            MechanicWorkshopLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 24);
            label2.Name = "label2";
            label2.Size = new Size(635, 40);
            label2.TabIndex = 1;
            label2.Text = "Personal Details";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FirstNameInput
            // 
            FirstNameInput.Anchor = AnchorStyles.Top;
            FirstNameInput.Location = new Point(241, 164);
            FirstNameInput.Name = "FirstNameInput";
            FirstNameInput.Size = new Size(218, 23);
            FirstNameInput.TabIndex = 2;
            // 
            // LastNameInput
            // 
            LastNameInput.Anchor = AnchorStyles.Top;
            LastNameInput.Location = new Point(241, 212);
            LastNameInput.Name = "LastNameInput";
            LastNameInput.Size = new Size(218, 23);
            LastNameInput.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(170, 164);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 5;
            label3.Text = "First name:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(171, 212);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 6;
            label4.Text = "Last name:";
            // 
            // SaveChangesBtn
            // 
            SaveChangesBtn.Anchor = AnchorStyles.Top;
            SaveChangesBtn.Location = new Point(266, 257);
            SaveChangesBtn.Name = "SaveChangesBtn";
            SaveChangesBtn.Size = new Size(92, 23);
            SaveChangesBtn.TabIndex = 8;
            SaveChangesBtn.Text = "Save Changes";
            SaveChangesBtn.UseVisualStyleBackColor = true;
            SaveChangesBtn.Click += SaveChangesBtn_Click;
            // 
            // MechanicEmailLbl
            // 
            MechanicEmailLbl.Anchor = AnchorStyles.Top;
            MechanicEmailLbl.AutoSize = true;
            MechanicEmailLbl.Location = new Point(193, 129);
            MechanicEmailLbl.Name = "MechanicEmailLbl";
            MechanicEmailLbl.Size = new Size(54, 15);
            MechanicEmailLbl.TabIndex = 9;
            MechanicEmailLbl.Text = "Email:     ";
            MechanicEmailLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // InvalidInputLbl
            // 
            InvalidInputLbl.Anchor = AnchorStyles.Top;
            InvalidInputLbl.AutoSize = true;
            InvalidInputLbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            InvalidInputLbl.ForeColor = Color.Red;
            InvalidInputLbl.Location = new Point(198, 304);
            InvalidInputLbl.Name = "InvalidInputLbl";
            InvalidInputLbl.Size = new Size(235, 19);
            InvalidInputLbl.TabIndex = 10;
            InvalidInputLbl.Text = "First and Last name can not be blank";
            InvalidInputLbl.Visible = false;
            // 
            // MechanicDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(InvalidInputLbl);
            Controls.Add(MechanicEmailLbl);
            Controls.Add(SaveChangesBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LastNameInput);
            Controls.Add(FirstNameInput);
            Controls.Add(label2);
            Controls.Add(MechanicWorkshopLbl);
            Name = "MechanicDetails";
            Size = new Size(635, 565);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label MechanicWorkshopLbl;
        private Label label2;
        public TextBox FirstNameInput;
        public TextBox LastNameInput;
        private Label label3;
        private Label label4;
        private Button SaveChangesBtn;
        public Label MechanicEmailLbl;
        private Label InvalidInputLbl;
    }
}
