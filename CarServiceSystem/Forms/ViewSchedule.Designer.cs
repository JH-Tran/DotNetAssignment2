namespace CarServiceSystem.Forms
{
    partial class ViewSchedule
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
            panel1 = new Panel();
            NoAppointmentsLbl = new Label();
            ScheduleGridView = new DataGridView();
            CustomerName = new DataGridViewTextBoxColumn();
            CarName = new DataGridViewTextBoxColumn();
            DateAndTime = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ScheduleGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 24);
            label1.Name = "label1";
            label1.Size = new Size(635, 40);
            label1.TabIndex = 0;
            label1.Text = "View Schedule";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(ScheduleGridView);
            panel1.Location = new Point(0, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 434);
            panel1.TabIndex = 1;
            // 
            // NoAppointmentsLbl
            // 
            NoAppointmentsLbl.Anchor = AnchorStyles.Top;
            NoAppointmentsLbl.AutoSize = true;
            NoAppointmentsLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NoAppointmentsLbl.ForeColor = Color.Red;
            NoAppointmentsLbl.Location = new Point(204, 77);
            NoAppointmentsLbl.Name = "NoAppointmentsLbl";
            NoAppointmentsLbl.Size = new Size(224, 21);
            NoAppointmentsLbl.TabIndex = 2;
            NoAppointmentsLbl.Text = "No Upcoming Services Booked";
            NoAppointmentsLbl.Visible = false;
            // 
            // ScheduleGridView
            // 
            ScheduleGridView.AllowUserToAddRows = false;
            ScheduleGridView.AllowUserToDeleteRows = false;
            ScheduleGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ScheduleGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ScheduleGridView.BackgroundColor = SystemColors.Window;
            ScheduleGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ScheduleGridView.Columns.AddRange(new DataGridViewColumn[] { CustomerName, CarName, DateAndTime });
            ScheduleGridView.Dock = DockStyle.Fill;
            ScheduleGridView.GridColor = SystemColors.WindowText;
            ScheduleGridView.Location = new Point(0, 0);
            ScheduleGridView.Name = "ScheduleGridView";
            ScheduleGridView.ReadOnly = true;
            ScheduleGridView.RowHeadersVisible = false;
            ScheduleGridView.RowTemplate.Height = 25;
            ScheduleGridView.ScrollBars = ScrollBars.Vertical;
            ScheduleGridView.Size = new Size(618, 434);
            ScheduleGridView.TabIndex = 3;
            ScheduleGridView.Visible = false;
            // 
            // CustomerName
            // 
            CustomerName.HeaderText = "Customer";
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            // 
            // CarName
            // 
            CarName.HeaderText = "Car";
            CarName.Name = "CarName";
            CarName.ReadOnly = true;
            // 
            // DateAndTime
            // 
            DateAndTime.HeaderText = "Date/Time";
            DateAndTime.Name = "DateAndTime";
            DateAndTime.ReadOnly = true;
            // 
            // ViewSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NoAppointmentsLbl);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "ViewSchedule";
            Size = new Size(635, 565);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ScheduleGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        public DataGridView ScheduleGridView;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn CarName;
        private DataGridViewTextBoxColumn DateAndTime;
        public Label NoAppointmentsLbl;
    }
}
