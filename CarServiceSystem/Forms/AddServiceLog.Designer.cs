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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            AddServiceLogPnl = new Panel();
            InvoicePnl = new Panel();
            ServiceDescriptionTxtBox = new TextBox();
            InputCost = new TextBox();
            SendInvoiceBtn = new Button();
            label9 = new Label();
            MechanicNameLbl = new Label();
            Date = new Label();
            label8 = new Label();
            InvalidInputLbl = new Label();
            AddLogBtn = new Button();
            label7 = new Label();
            OdometerInput = new TextBox();
            label6 = new Label();
            TaskInput = new TextBox();
            label5 = new Label();
            CustomerComboBox = new ComboBox();
            label4 = new Label();
            CarNotFoundLbl = new Label();
            CarDetails = new Panel();
            OdometerLbl = new Label();
            YearLbl = new Label();
            MakeAndModelLbl = new Label();
            label3 = new Label();
            SearchLicenceBtn = new Button();
            LicenceNumberInput = new TextBox();
            label2 = new Label();
            label1 = new Label();
            customerBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            AddServiceLogPnl.SuspendLayout();
            InvoicePnl.SuspendLayout();
            CarDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(AddServiceLogPnl);
            panel1.Controls.Add(CarNotFoundLbl);
            panel1.Controls.Add(CarDetails);
            panel1.Controls.Add(SearchLicenceBtn);
            panel1.Controls.Add(LicenceNumberInput);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 753);
            panel1.TabIndex = 0;
            // 
            // AddServiceLogPnl
            // 
            AddServiceLogPnl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddServiceLogPnl.Controls.Add(InvoicePnl);
            AddServiceLogPnl.Controls.Add(InvalidInputLbl);
            AddServiceLogPnl.Controls.Add(AddLogBtn);
            AddServiceLogPnl.Controls.Add(label7);
            AddServiceLogPnl.Controls.Add(OdometerInput);
            AddServiceLogPnl.Controls.Add(label6);
            AddServiceLogPnl.Controls.Add(TaskInput);
            AddServiceLogPnl.Controls.Add(label5);
            AddServiceLogPnl.Controls.Add(CustomerComboBox);
            AddServiceLogPnl.Controls.Add(label4);
            AddServiceLogPnl.Location = new Point(0, 321);
            AddServiceLogPnl.Margin = new Padding(3, 4, 3, 4);
            AddServiceLogPnl.Name = "AddServiceLogPnl";
            AddServiceLogPnl.Size = new Size(726, 432);
            AddServiceLogPnl.TabIndex = 14;
            AddServiceLogPnl.Visible = false;
            // 
            // InvoicePnl
            // 
            InvoicePnl.Controls.Add(ServiceDescriptionTxtBox);
            InvoicePnl.Controls.Add(InputCost);
            InvoicePnl.Controls.Add(SendInvoiceBtn);
            InvoicePnl.Controls.Add(label9);
            InvoicePnl.Controls.Add(MechanicNameLbl);
            InvoicePnl.Controls.Add(Date);
            InvoicePnl.Controls.Add(label8);
            InvoicePnl.Location = new Point(3, 4);
            InvoicePnl.Margin = new Padding(3, 4, 3, 4);
            InvoicePnl.Name = "InvoicePnl";
            InvoicePnl.Size = new Size(722, 428);
            InvoicePnl.TabIndex = 10;
            InvoicePnl.Visible = false;
            // 
            // ServiceDescriptionTxtBox
            // 
            ServiceDescriptionTxtBox.Location = new Point(3, 100);
            ServiceDescriptionTxtBox.Margin = new Padding(3, 4, 3, 4);
            ServiceDescriptionTxtBox.Multiline = true;
            ServiceDescriptionTxtBox.Name = "ServiceDescriptionTxtBox";
            ServiceDescriptionTxtBox.ReadOnly = true;
            ServiceDescriptionTxtBox.ScrollBars = ScrollBars.Vertical;
            ServiceDescriptionTxtBox.Size = new Size(251, 115);
            ServiceDescriptionTxtBox.TabIndex = 9;
            // 
            // InputCost
            // 
            InputCost.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            InputCost.Location = new Point(72, 224);
            InputCost.Margin = new Padding(3, 4, 3, 4);
            InputCost.Name = "InputCost";
            InputCost.Size = new Size(114, 27);
            InputCost.TabIndex = 8;
            // 
            // SendInvoiceBtn
            // 
            SendInvoiceBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SendInvoiceBtn.Location = new Point(3, 269);
            SendInvoiceBtn.Margin = new Padding(3, 4, 3, 4);
            SendInvoiceBtn.Name = "SendInvoiceBtn";
            SendInvoiceBtn.Size = new Size(176, 31);
            SendInvoiceBtn.TabIndex = 7;
            SendInvoiceBtn.Text = "Send Confirmation Email";
            SendInvoiceBtn.UseVisualStyleBackColor = true;
            SendInvoiceBtn.Click += SendInvoiceBtn_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(3, 228);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 6;
            label9.Text = "Total Cost:";
            // 
            // MechanicNameLbl
            // 
            MechanicNameLbl.AutoSize = true;
            MechanicNameLbl.Location = new Point(3, 76);
            MechanicNameLbl.Name = "MechanicNameLbl";
            MechanicNameLbl.Size = new Size(116, 20);
            MechanicNameLbl.TabIndex = 4;
            MechanicNameLbl.Text = "Mechanic Name";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(0, 52);
            Date.Name = "Date";
            Date.Size = new Size(185, 20);
            Date.TabIndex = 3;
            Date.Text = "Thursday, 26 October 2023";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(208, 35);
            label8.TabIndex = 2;
            label8.Text = "Invoice Customer";
            // 
            // InvalidInputLbl
            // 
            InvalidInputLbl.Anchor = AnchorStyles.Top;
            InvalidInputLbl.AutoSize = true;
            InvalidInputLbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            InvalidInputLbl.ForeColor = Color.Red;
            InvalidInputLbl.Location = new Point(115, 340);
            InvalidInputLbl.Name = "InvalidInputLbl";
            InvalidInputLbl.Size = new Size(237, 23);
            InvalidInputLbl.TabIndex = 9;
            InvalidInputLbl.Text = "Invalid Input, Please Try again";
            InvalidInputLbl.Visible = false;
            // 
            // AddLogBtn
            // 
            AddLogBtn.Location = new Point(23, 340);
            AddLogBtn.Margin = new Padding(3, 4, 3, 4);
            AddLogBtn.Name = "AddLogBtn";
            AddLogBtn.Size = new Size(86, 31);
            AddLogBtn.TabIndex = 8;
            AddLogBtn.Text = "Add Log";
            AddLogBtn.UseVisualStyleBackColor = true;
            AddLogBtn.Click += AddLogBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 284);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 7;
            label7.Text = "Odometer";
            // 
            // OdometerInput
            // 
            OdometerInput.Location = new Point(97, 280);
            OdometerInput.Margin = new Padding(3, 4, 3, 4);
            OdometerInput.Name = "OdometerInput";
            OdometerInput.Size = new Size(138, 27);
            OdometerInput.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 135);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 5;
            label6.Text = "Task";
            // 
            // TaskInput
            // 
            TaskInput.Location = new Point(97, 135);
            TaskInput.Margin = new Padding(3, 4, 3, 4);
            TaskInput.Multiline = true;
            TaskInput.Name = "TaskInput";
            TaskInput.ScrollBars = ScrollBars.Vertical;
            TaskInput.Size = new Size(317, 116);
            TaskInput.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 76);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 3;
            label5.Text = "Customer";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(97, 76);
            CustomerComboBox.Margin = new Padding(3, 4, 3, 4);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(138, 28);
            CustomerComboBox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 35);
            label4.TabIndex = 1;
            label4.Text = "Add Log";
            // 
            // CarNotFoundLbl
            // 
            CarNotFoundLbl.Anchor = AnchorStyles.Top;
            CarNotFoundLbl.AutoSize = true;
            CarNotFoundLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CarNotFoundLbl.ForeColor = Color.Red;
            CarNotFoundLbl.Location = new Point(305, 152);
            CarNotFoundLbl.Name = "CarNotFoundLbl";
            CarNotFoundLbl.Size = new Size(137, 28);
            CarNotFoundLbl.TabIndex = 13;
            CarNotFoundLbl.Text = "Car not Found";
            CarNotFoundLbl.Visible = false;
            // 
            // CarDetails
            // 
            CarDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CarDetails.AutoSize = true;
            CarDetails.Controls.Add(OdometerLbl);
            CarDetails.Controls.Add(YearLbl);
            CarDetails.Controls.Add(MakeAndModelLbl);
            CarDetails.Controls.Add(label3);
            CarDetails.Location = new Point(3, 156);
            CarDetails.Margin = new Padding(3, 4, 3, 4);
            CarDetails.Name = "CarDetails";
            CarDetails.Size = new Size(719, 157);
            CarDetails.TabIndex = 12;
            CarDetails.Visible = false;
            // 
            // OdometerLbl
            // 
            OdometerLbl.AutoSize = true;
            OdometerLbl.Location = new Point(15, 128);
            OdometerLbl.Name = "OdometerLbl";
            OdometerLbl.Size = new Size(80, 20);
            OdometerLbl.TabIndex = 4;
            OdometerLbl.Text = "Odometer:";
            // 
            // YearLbl
            // 
            YearLbl.AutoSize = true;
            YearLbl.Location = new Point(15, 91);
            YearLbl.Name = "YearLbl";
            YearLbl.Size = new Size(44, 20);
            YearLbl.TabIndex = 3;
            YearLbl.Text = "Year: ";
            // 
            // MakeAndModelLbl
            // 
            MakeAndModelLbl.AutoSize = true;
            MakeAndModelLbl.Location = new Point(15, 57);
            MakeAndModelLbl.Name = "MakeAndModelLbl";
            MakeAndModelLbl.Size = new Size(97, 20);
            MakeAndModelLbl.TabIndex = 1;
            MakeAndModelLbl.Text = "Make/Model:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 35);
            label3.TabIndex = 0;
            label3.Text = "Car Details";
            // 
            // SearchLicenceBtn
            // 
            SearchLicenceBtn.Anchor = AnchorStyles.Top;
            SearchLicenceBtn.Location = new Point(426, 117);
            SearchLicenceBtn.Margin = new Padding(3, 4, 3, 4);
            SearchLicenceBtn.Name = "SearchLicenceBtn";
            SearchLicenceBtn.Size = new Size(86, 31);
            SearchLicenceBtn.TabIndex = 11;
            SearchLicenceBtn.Text = "Search";
            SearchLicenceBtn.UseVisualStyleBackColor = true;
            SearchLicenceBtn.Click += SearchLicenceBtn_Click;
            // 
            // LicenceNumberInput
            // 
            LicenceNumberInput.Anchor = AnchorStyles.Top;
            LicenceNumberInput.Location = new Point(305, 117);
            LicenceNumberInput.Margin = new Padding(3, 4, 3, 4);
            LicenceNumberInput.Name = "LicenceNumberInput";
            LicenceNumberInput.Size = new Size(114, 27);
            LicenceNumberInput.TabIndex = 10;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(194, 121);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 9;
            label2.Text = "Licence Number: ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(247, 33);
            label1.Name = "label1";
            label1.Size = new Size(262, 46);
            label1.TabIndex = 8;
            label1.Text = "Add Service Log";
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Customer);
            // 
            // AddServiceLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddServiceLog";
            Size = new Size(726, 753);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            AddServiceLogPnl.ResumeLayout(false);
            AddServiceLogPnl.PerformLayout();
            InvoicePnl.ResumeLayout(false);
            InvoicePnl.PerformLayout();
            CarDetails.ResumeLayout(false);
            CarDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button AddLogBtn;
        private Label label7;
        private TextBox OdometerInput;
        private Label label6;
        private TextBox TaskInput;
        private Label label5;
        private ComboBox CustomerComboBox;
        private Label label4;
        private Label CarNotFoundLbl;
        private Panel CarDetails;
        private Label OdometerLbl;
        private Label YearLbl;
        private Label MakeAndModelLbl;
        private Label label3;
        private Button SearchLicenceBtn;
        private TextBox LicenceNumberInput;
        private Label label2;
        private Label label1;
        private BindingSource customerBindingSource;
        private Label InvalidInputLbl;
        private Panel AddServiceLogPnl;
        private Panel InvoicePnl;
        private Label label8;
        private Label Date;
        private Label label9;
        private Label MechanicNameLbl;
        private TextBox InputCost;
        private Button SendInvoiceBtn;
        private TextBox ServiceDescriptionTxtBox;
    }
}
