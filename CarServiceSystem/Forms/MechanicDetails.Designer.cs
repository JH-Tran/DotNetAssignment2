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
            label5 = new Label();
            SaveChangesBtn = new Button();
            MechanicEmailLbl = new Label();
            SuspendLayout();
            // 
            // MechanicWorkshopLbl
            // 
            MechanicWorkshopLbl.Anchor = AnchorStyles.Top;
            MechanicWorkshopLbl.AutoSize = true;
            MechanicWorkshopLbl.Location = new Point(342, 106);
            MechanicWorkshopLbl.Name = "MechanicWorkshopLbl";
            MechanicWorkshopLbl.Size = new Size(67, 15);
            MechanicWorkshopLbl.TabIndex = 0;
            MechanicWorkshopLbl.Text = "Workshop: ";
            MechanicWorkshopLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(318, 20);
            label2.Name = "label2";
            label2.Size = new Size(205, 37);
            label2.TabIndex = 1;
            label2.Text = "Personal Details";
            // 
            // FirstNameInput
            // 
            FirstNameInput.Anchor = AnchorStyles.Top;
            FirstNameInput.Location = new Point(396, 198);
            FirstNameInput.Name = "FirstNameInput";
            FirstNameInput.Size = new Size(218, 23);
            FirstNameInput.TabIndex = 2;
            // 
            // LastNameInput
            // 
            LastNameInput.Anchor = AnchorStyles.Top;
            LastNameInput.Location = new Point(396, 246);
            LastNameInput.Name = "LastNameInput";
            LastNameInput.Size = new Size(218, 23);
            LastNameInput.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(325, 198);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 5;
            label3.Text = "First name:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(326, 246);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 6;
            label4.Text = "Last name:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(351, 151);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 7;
            label5.Text = "Email:";
            // 
            // SaveChangesBtn
            // 
            SaveChangesBtn.Anchor = AnchorStyles.Top;
            SaveChangesBtn.Location = new Point(423, 303);
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
            MechanicEmailLbl.Location = new Point(405, 151);
            MechanicEmailLbl.Name = "MechanicEmailLbl";
            MechanicEmailLbl.Size = new Size(0, 15);
            MechanicEmailLbl.TabIndex = 9;
            MechanicEmailLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // MechanicDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MechanicEmailLbl);
            Controls.Add(SaveChangesBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LastNameInput);
            Controls.Add(FirstNameInput);
            Controls.Add(label2);
            Controls.Add(MechanicWorkshopLbl);
            Name = "MechanicDetails";
            Size = new Size(838, 564);
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
        private Label label5;
        private Button SaveChangesBtn;
        public Label MechanicEmailLbl;
    }
}
