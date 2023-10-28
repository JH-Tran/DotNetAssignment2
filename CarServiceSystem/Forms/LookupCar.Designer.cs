namespace CarServiceSystem.Forms
{
    partial class LookupCar
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
            CarDetailsPnl = new Panel();
            OdometerLbl = new Label();
            YearLbl = new Label();
            MakeAndModelLbl = new Label();
            label3 = new Label();
            CarNotFoundLbl = new Label();
            ServiceHistoryPnl = new Panel();
            label4 = new Label();
            CompletionDate = new DataGridViewTextBoxColumn();
            Odometer = new DataGridViewTextBoxColumn();
            Task = new DataGridViewTextBoxColumn();
            MechanicName = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            ServiceHistoryGridView = new DataGridView();
            CarDetailsPnl.SuspendLayout();
            ServiceHistoryPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ServiceHistoryGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(212, 57);
            label1.Name = "label1";
            label1.Size = new Size(153, 37);
            label1.TabIndex = 0;
            label1.Text = "Car Lookup";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(131, 119);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "Licence Number: ";
            // 
            // LicenceNumberInput
            // 
            LicenceNumberInput.Anchor = AnchorStyles.Top;
            LicenceNumberInput.Location = new Point(237, 116);
            LicenceNumberInput.Name = "LicenceNumberInput";
            LicenceNumberInput.Size = new Size(100, 23);
            LicenceNumberInput.TabIndex = 2;
            // 
            // SearchLicenceBtn
            // 
            SearchLicenceBtn.Anchor = AnchorStyles.Top;
            SearchLicenceBtn.Location = new Point(343, 116);
            SearchLicenceBtn.Name = "SearchLicenceBtn";
            SearchLicenceBtn.Size = new Size(75, 23);
            SearchLicenceBtn.TabIndex = 3;
            SearchLicenceBtn.Text = "Search";
            SearchLicenceBtn.UseVisualStyleBackColor = true;
            SearchLicenceBtn.Click += SearchLicenceBtn_Click;
            // 
            // CarDetailsPnl
            // 
            CarDetailsPnl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CarDetailsPnl.AutoSize = true;
            CarDetailsPnl.Controls.Add(OdometerLbl);
            CarDetailsPnl.Controls.Add(YearLbl);
            CarDetailsPnl.Controls.Add(MakeAndModelLbl);
            CarDetailsPnl.Controls.Add(label3);
            CarDetailsPnl.Location = new Point(3, 145);
            CarDetailsPnl.Name = "CarDetailsPnl";
            CarDetailsPnl.Size = new Size(566, 127);
            CarDetailsPnl.TabIndex = 4;
            CarDetailsPnl.Visible = false;
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
            CarNotFoundLbl.ForeColor = Color.Red;
            CarNotFoundLbl.Location = new Point(228, 145);
            CarNotFoundLbl.Name = "CarNotFoundLbl";
            CarNotFoundLbl.Size = new Size(109, 21);
            CarNotFoundLbl.TabIndex = 5;
            CarNotFoundLbl.Text = "Car not Found";
            CarNotFoundLbl.Visible = false;
            // 
            // ServiceHistoryPnl
            // 
            ServiceHistoryPnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ServiceHistoryPnl.Controls.Add(ServiceHistoryGridView);
            ServiceHistoryPnl.Controls.Add(label4);
            ServiceHistoryPnl.Location = new Point(3, 278);
            ServiceHistoryPnl.Name = "ServiceHistoryPnl";
            ServiceHistoryPnl.Size = new Size(566, 222);
            ServiceHistoryPnl.TabIndex = 6;
            ServiceHistoryPnl.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 28);
            label4.TabIndex = 1;
            label4.Text = "Service History";
            // 
            // CompletionDate
            // 
            CompletionDate.HeaderText = "Date";
            CompletionDate.Name = "CompletionDate";
            CompletionDate.ReadOnly = true;
            // 
            // Odometer
            // 
            Odometer.HeaderText = "Odometer";
            Odometer.Name = "Odometer";
            Odometer.ReadOnly = true;
            // 
            // Task
            // 
            Task.HeaderText = "Description";
            Task.Name = "Task";
            Task.ReadOnly = true;
            // 
            // MechanicName
            // 
            MechanicName.HeaderText = "Mechanic";
            MechanicName.Name = "MechanicName";
            MechanicName.ReadOnly = true;
            // 
            // CustomerName
            // 
            CustomerName.HeaderText = "Customer";
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            // 
            // ServiceHistoryGridView
            // 
            ServiceHistoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ServiceHistoryGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ServiceHistoryGridView.BackgroundColor = SystemColors.Window;
            ServiceHistoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServiceHistoryGridView.Columns.AddRange(new DataGridViewColumn[] { CustomerName, MechanicName, Task, Odometer, CompletionDate });
            ServiceHistoryGridView.Dock = DockStyle.Bottom;
            ServiceHistoryGridView.GridColor = SystemColors.WindowText;
            ServiceHistoryGridView.Location = new Point(0, 34);
            ServiceHistoryGridView.Name = "ServiceHistoryGridView";
            ServiceHistoryGridView.ReadOnly = true;
            ServiceHistoryGridView.RowHeadersVisible = false;
            ServiceHistoryGridView.RowTemplate.Height = 25;
            ServiceHistoryGridView.Size = new Size(566, 188);
            ServiceHistoryGridView.TabIndex = 2;
            // 
            // LookupCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ServiceHistoryPnl);
            Controls.Add(CarNotFoundLbl);
            Controls.Add(CarDetailsPnl);
            Controls.Add(SearchLicenceBtn);
            Controls.Add(LicenceNumberInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LookupCar";
            Size = new Size(572, 503);
            CarDetailsPnl.ResumeLayout(false);
            CarDetailsPnl.PerformLayout();
            ServiceHistoryPnl.ResumeLayout(false);
            ServiceHistoryPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ServiceHistoryGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox LicenceNumberInput;
        private Button SearchLicenceBtn;
        private Panel CarDetailsPnl;
        private Label label3;
        private Label CarNotFoundLbl;
        private Label OdometerLbl;
        private Label YearLbl;
        private Label MakeAndModelLbl;
        private Panel ServiceHistoryPnl;
        private Label label4;
        private DataGridView ServiceHistoryGridView;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn MechanicName;
        private DataGridViewTextBoxColumn Task;
        private DataGridViewTextBoxColumn Odometer;
        private DataGridViewTextBoxColumn CompletionDate;
    }
}
