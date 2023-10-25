namespace CarServiceSystem.Forms
{
    partial class AddServiceLog
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
            label1 = new Label();
            label2 = new Label();
            LicenceNumberInput = new TextBox();
            SearchLicenceBtn = new Button();
            CarDetails = new Panel();
            OdometerLbl = new Label();
            YearLbl = new Label();
            MakeAndModelLbl = new Label();
            label3 = new Label();
            CarNotFoundLbl = new Label();
            AddServiceLogPnl = new Panel();
            label4 = new Label();
            CarDetails.SuspendLayout();
            AddServiceLogPnl.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(216, 47);
            label1.Name = "label1";
            label1.Size = new Size(208, 37);
            label1.TabIndex = 0;
            label1.Text = "Add Service Log";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(170, 113);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "Licence Number: ";
            // 
            // LicenceNumberInput
            // 
            LicenceNumberInput.Anchor = AnchorStyles.Top;
            LicenceNumberInput.Location = new Point(267, 110);
            LicenceNumberInput.Name = "LicenceNumberInput";
            LicenceNumberInput.Size = new Size(100, 23);
            LicenceNumberInput.TabIndex = 2;
            // 
            // SearchLicenceBtn
            // 
            SearchLicenceBtn.Anchor = AnchorStyles.Top;
            SearchLicenceBtn.Location = new Point(373, 110);
            SearchLicenceBtn.Name = "SearchLicenceBtn";
            SearchLicenceBtn.Size = new Size(75, 23);
            SearchLicenceBtn.TabIndex = 3;
            SearchLicenceBtn.Text = "Search";
            SearchLicenceBtn.UseVisualStyleBackColor = true;
            SearchLicenceBtn.Click += SearchLicenceBtn_Click;
            // 
            // CarDetails
            // 
            CarDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CarDetails.AutoSize = true;
            CarDetails.Controls.Add(OdometerLbl);
            CarDetails.Controls.Add(YearLbl);
            CarDetails.Controls.Add(MakeAndModelLbl);
            CarDetails.Controls.Add(label3);
            CarDetails.Location = new Point(3, 139);
            CarDetails.Name = "CarDetails";
            CarDetails.Size = new Size(629, 118);
            CarDetails.TabIndex = 5;
            CarDetails.Visible = false;
            // 
            // OdometerLbl
            // 
            OdometerLbl.AutoSize = true;
            OdometerLbl.Location = new Point(13, 96);
            OdometerLbl.Name = "OdometerLbl";
            OdometerLbl.Size = new Size(64, 15);
            OdometerLbl.TabIndex = 4;
            OdometerLbl.Text = "Odometer:";
            // 
            // YearLbl
            // 
            YearLbl.AutoSize = true;
            YearLbl.Location = new Point(13, 68);
            YearLbl.Name = "YearLbl";
            YearLbl.Size = new Size(35, 15);
            YearLbl.TabIndex = 3;
            YearLbl.Text = "Year: ";
            // 
            // MakeAndModelLbl
            // 
            MakeAndModelLbl.AutoSize = true;
            MakeAndModelLbl.Location = new Point(13, 43);
            MakeAndModelLbl.Name = "MakeAndModelLbl";
            MakeAndModelLbl.Size = new Size(78, 15);
            MakeAndModelLbl.TabIndex = 1;
            MakeAndModelLbl.Text = "Make/Model:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 28);
            label3.TabIndex = 0;
            label3.Text = "Car Details";
            // 
            // CarNotFoundLbl
            // 
            CarNotFoundLbl.Anchor = AnchorStyles.Top;
            CarNotFoundLbl.AutoSize = true;
            CarNotFoundLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CarNotFoundLbl.ForeColor = Color.Crimson;
            CarNotFoundLbl.Location = new Point(267, 136);
            CarNotFoundLbl.Name = "CarNotFoundLbl";
            CarNotFoundLbl.Size = new Size(109, 21);
            CarNotFoundLbl.TabIndex = 6;
            CarNotFoundLbl.Text = "Car not Found";
            CarNotFoundLbl.Visible = false;
            // 
            // AddServiceLogPnl
            // 
            AddServiceLogPnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddServiceLogPnl.Controls.Add(label4);
            AddServiceLogPnl.Location = new Point(3, 263);
            AddServiceLogPnl.Name = "AddServiceLogPnl";
            AddServiceLogPnl.Size = new Size(629, 299);
            AddServiceLogPnl.TabIndex = 7;
            AddServiceLogPnl.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 1;
            label4.Text = "Add Log";
            // 
            // AddServiceLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddServiceLogPnl);
            Controls.Add(CarNotFoundLbl);
            Controls.Add(CarDetails);
            Controls.Add(SearchLicenceBtn);
            Controls.Add(LicenceNumberInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddServiceLog";
            Size = new Size(635, 565);
            CarDetails.ResumeLayout(false);
            CarDetails.PerformLayout();
            AddServiceLogPnl.ResumeLayout(false);
            AddServiceLogPnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox LicenceNumberInput;
        private Button SearchLicenceBtn;
        private Panel CarDetails;
        private Label OdometerLbl;
        private Label YearLbl;
        private Label MakeAndModelLbl;
        private Label label3;
        private Label CarNotFoundLbl;
        private Panel AddServiceLogPnl;
        private Label label4;
    }
}
