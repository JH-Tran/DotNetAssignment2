namespace CarServiceSystem.Forms
{
    partial class ViewAllCars
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
            myCarListLabel = new Label();
            carHistoryTableLayout = new TableLayoutPanel();
            carodometer = new Label();
            servicePerformedLabel = new Label();
            startDateTimeLabel = new Label();
            endDateTimeLogLabel = new Label();
            mechanicNameLogLabel = new Label();
            carServiceHistoryLabel = new Label();
            carNameLabel = new Label();
            bookServiceLabel = new Label();
            bookServicePanel = new Panel();
            bookingErrorLabel = new Label();
            timeComboBox = new ComboBox();
            confirmBooking = new Button();
            bookingAndTimeLabel = new Label();
            mechanicNameBookingLabel = new Label();
            mechanicComboBox = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            carListFlowLayout = new FlowLayoutPanel();
            secondaryOwnersLabel = new Label();
            secondaryOwnersPanel = new Panel();
            SecondaryOwnerError = new Label();
            CurrentSecondaryOwnerLabel = new Label();
            label1 = new Label();
            button2 = new Button();
            EmailTextBoxSecondaryOwner = new TextBox();
            bookServicePanel.SuspendLayout();
            secondaryOwnersPanel.SuspendLayout();
            SuspendLayout();
            // 
            // myCarListLabel
            // 
            myCarListLabel.AutoSize = true;
            myCarListLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            myCarListLabel.Location = new Point(14, 28);
            myCarListLabel.Name = "myCarListLabel";
            myCarListLabel.Size = new Size(163, 38);
            myCarListLabel.TabIndex = 2;
            myCarListLabel.Text = "My Car List";
            // 
            // carHistoryTableLayout
            // 
            carHistoryTableLayout.AutoScroll = true;
            carHistoryTableLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            carHistoryTableLayout.ColumnCount = 5;
            carHistoryTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            carHistoryTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            carHistoryTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            carHistoryTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            carHistoryTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            carHistoryTableLayout.Location = new Point(14, 716);
            carHistoryTableLayout.Name = "carHistoryTableLayout";
            carHistoryTableLayout.RowCount = 1;
            carHistoryTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            carHistoryTableLayout.Size = new Size(735, 191);
            carHistoryTableLayout.TabIndex = 3;
            // 
            // carodometer
            // 
            carodometer.AutoSize = true;
            carodometer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            carodometer.Location = new Point(475, 693);
            carodometer.Name = "carodometer";
            carodometer.Size = new Size(107, 20);
            carodometer.TabIndex = 3;
            carodometer.Text = "Car Odometer";
            // 
            // servicePerformedLabel
            // 
            servicePerformedLabel.AutoSize = true;
            servicePerformedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            servicePerformedLabel.Location = new Point(611, 693);
            servicePerformedLabel.Name = "servicePerformedLabel";
            servicePerformedLabel.Size = new Size(138, 20);
            servicePerformedLabel.TabIndex = 4;
            servicePerformedLabel.Text = "Service Performed";
            // 
            // startDateTimeLabel
            // 
            startDateTimeLabel.AutoSize = true;
            startDateTimeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            startDateTimeLabel.Location = new Point(24, 693);
            startDateTimeLabel.Name = "startDateTimeLabel";
            startDateTimeLabel.Size = new Size(119, 20);
            startDateTimeLabel.TabIndex = 0;
            startDateTimeLabel.Text = "Start Date Time";
            // 
            // endDateTimeLogLabel
            // 
            endDateTimeLogLabel.AutoSize = true;
            endDateTimeLogLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            endDateTimeLogLabel.Location = new Point(179, 693);
            endDateTimeLogLabel.Name = "endDateTimeLogLabel";
            endDateTimeLogLabel.Size = new Size(111, 20);
            endDateTimeLogLabel.TabIndex = 1;
            endDateTimeLogLabel.Text = "End Date Time";
            // 
            // mechanicNameLogLabel
            // 
            mechanicNameLogLabel.AutoSize = true;
            mechanicNameLogLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mechanicNameLogLabel.Location = new Point(319, 693);
            mechanicNameLogLabel.Name = "mechanicNameLogLabel";
            mechanicNameLogLabel.Size = new Size(121, 20);
            mechanicNameLogLabel.TabIndex = 2;
            mechanicNameLogLabel.Text = "Mechanic Name";
            // 
            // carServiceHistoryLabel
            // 
            carServiceHistoryLabel.AutoSize = true;
            carServiceHistoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            carServiceHistoryLabel.Location = new Point(14, 640);
            carServiceHistoryLabel.Name = "carServiceHistoryLabel";
            carServiceHistoryLabel.Size = new Size(234, 28);
            carServiceHistoryLabel.TabIndex = 6;
            carServiceHistoryLabel.Text = "Car Service Log History";
            // 
            // carNameLabel
            // 
            carNameLabel.AutoSize = true;
            carNameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            carNameLabel.ForeColor = Color.Red;
            carNameLabel.Location = new Point(14, 233);
            carNameLabel.Name = "carNameLabel";
            carNameLabel.Size = new Size(236, 38);
            carNameLabel.TabIndex = 12;
            carNameLabel.Text = "Car Not Selected";
            // 
            // bookServiceLabel
            // 
            bookServiceLabel.AutoSize = true;
            bookServiceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bookServiceLabel.Location = new Point(14, 282);
            bookServiceLabel.Name = "bookServiceLabel";
            bookServiceLabel.Size = new Size(141, 28);
            bookServiceLabel.TabIndex = 11;
            bookServiceLabel.Text = " Book Service";
            // 
            // bookServicePanel
            // 
            bookServicePanel.Controls.Add(bookingErrorLabel);
            bookServicePanel.Controls.Add(timeComboBox);
            bookServicePanel.Controls.Add(confirmBooking);
            bookServicePanel.Controls.Add(bookingAndTimeLabel);
            bookServicePanel.Controls.Add(mechanicNameBookingLabel);
            bookServicePanel.Controls.Add(mechanicComboBox);
            bookServicePanel.Controls.Add(dateTimePicker1);
            bookServicePanel.Location = new Point(14, 313);
            bookServicePanel.Name = "bookServicePanel";
            bookServicePanel.Size = new Size(738, 174);
            bookServicePanel.TabIndex = 10;
            // 
            // bookingErrorLabel
            // 
            bookingErrorLabel.AutoSize = true;
            bookingErrorLabel.ForeColor = Color.Red;
            bookingErrorLabel.Location = new Point(367, 130);
            bookingErrorLabel.Name = "bookingErrorLabel";
            bookingErrorLabel.Size = new Size(191, 20);
            bookingErrorLabel.TabIndex = 8;
            bookingErrorLabel.Text = "Invalid Information to Book";
            bookingErrorLabel.Visible = false;
            // 
            // timeComboBox
            // 
            timeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            timeComboBox.FormattingEnabled = true;
            timeComboBox.Location = new Point(212, 83);
            timeComboBox.Name = "timeComboBox";
            timeComboBox.Size = new Size(151, 28);
            timeComboBox.TabIndex = 7;
            timeComboBox.SelectedIndexChanged += TimePickerSelectedIndexChanged;
            // 
            // confirmBooking
            // 
            confirmBooking.Location = new Point(212, 126);
            confirmBooking.Name = "confirmBooking";
            confirmBooking.Size = new Size(136, 29);
            confirmBooking.TabIndex = 5;
            confirmBooking.Text = "Confirm Booking";
            confirmBooking.UseVisualStyleBackColor = true;
            confirmBooking.Click += ConfirmBookingClick;
            // 
            // bookingAndTimeLabel
            // 
            bookingAndTimeLabel.AutoSize = true;
            bookingAndTimeLabel.Location = new Point(10, 55);
            bookingAndTimeLabel.Name = "bookingAndTimeLabel";
            bookingAndTimeLabel.Size = new Size(169, 20);
            bookingAndTimeLabel.TabIndex = 4;
            bookingAndTimeLabel.Text = "Booking Date and Time:";
            // 
            // mechanicNameBookingLabel
            // 
            mechanicNameBookingLabel.AutoSize = true;
            mechanicNameBookingLabel.Location = new Point(10, 19);
            mechanicNameBookingLabel.Name = "mechanicNameBookingLabel";
            mechanicNameBookingLabel.Size = new Size(119, 20);
            mechanicNameBookingLabel.TabIndex = 3;
            mechanicNameBookingLabel.Text = "Mechanic Name:";
            // 
            // mechanicComboBox
            // 
            mechanicComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            mechanicComboBox.FormattingEnabled = true;
            mechanicComboBox.Location = new Point(212, 16);
            mechanicComboBox.Name = "mechanicComboBox";
            mechanicComboBox.Size = new Size(250, 28);
            mechanicComboBox.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(212, 50);
            dateTimePicker1.MinDate = new DateTime(2023, 10, 29, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // carListFlowLayout
            // 
            carListFlowLayout.Anchor = AnchorStyles.Top;
            carListFlowLayout.AutoScroll = true;
            carListFlowLayout.BorderStyle = BorderStyle.FixedSingle;
            carListFlowLayout.Location = new Point(63, 69);
            carListFlowLayout.Name = "carListFlowLayout";
            carListFlowLayout.Size = new Size(731, 161);
            carListFlowLayout.TabIndex = 13;
            carListFlowLayout.WrapContents = false;
            // 
            // secondaryOwnersLabel
            // 
            secondaryOwnersLabel.AutoSize = true;
            secondaryOwnersLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            secondaryOwnersLabel.Location = new Point(14, 490);
            secondaryOwnersLabel.Name = "secondaryOwnersLabel";
            secondaryOwnersLabel.Size = new Size(179, 28);
            secondaryOwnersLabel.TabIndex = 14;
            secondaryOwnersLabel.Text = "Secondary Owner";
            // 
            // secondaryOwnersPanel
            // 
            secondaryOwnersPanel.Controls.Add(SecondaryOwnerError);
            secondaryOwnersPanel.Controls.Add(CurrentSecondaryOwnerLabel);
            secondaryOwnersPanel.Controls.Add(label1);
            secondaryOwnersPanel.Controls.Add(button2);
            secondaryOwnersPanel.Controls.Add(EmailTextBoxSecondaryOwner);
            secondaryOwnersPanel.Location = new Point(14, 521);
            secondaryOwnersPanel.Name = "secondaryOwnersPanel";
            secondaryOwnersPanel.Size = new Size(738, 116);
            secondaryOwnersPanel.TabIndex = 15;
            // 
            // SecondaryOwnerError
            // 
            SecondaryOwnerError.AutoSize = true;
            SecondaryOwnerError.ForeColor = Color.Red;
            SecondaryOwnerError.Location = new Point(185, 53);
            SecondaryOwnerError.Name = "SecondaryOwnerError";
            SecondaryOwnerError.Size = new Size(91, 20);
            SecondaryOwnerError.TabIndex = 6;
            SecondaryOwnerError.Text = "Invalid Input";
            SecondaryOwnerError.Visible = false;
            // 
            // CurrentSecondaryOwnerLabel
            // 
            CurrentSecondaryOwnerLabel.AutoSize = true;
            CurrentSecondaryOwnerLabel.Location = new Point(92, 84);
            CurrentSecondaryOwnerLabel.Name = "CurrentSecondaryOwnerLabel";
            CurrentSecondaryOwnerLabel.Size = new Size(220, 20);
            CurrentSecondaryOwnerLabel.TabIndex = 5;
            CurrentSecondaryOwnerLabel.Text = "Current Secondary Owner: None";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 26);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "Email:";
            // 
            // button2
            // 
            button2.Location = new Point(393, 21);
            button2.Name = "button2";
            button2.Size = new Size(190, 29);
            button2.TabIndex = 3;
            button2.Text = "Update Secondary Owner";
            button2.UseVisualStyleBackColor = true;
            button2.Click += AddSecondaryOwners;
            // 
            // EmailTextBoxSecondaryOwner
            // 
            EmailTextBoxSecondaryOwner.Location = new Point(102, 23);
            EmailTextBoxSecondaryOwner.Name = "EmailTextBoxSecondaryOwner";
            EmailTextBoxSecondaryOwner.Size = new Size(276, 27);
            EmailTextBoxSecondaryOwner.TabIndex = 2;
            // 
            // ViewAllCars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Menu;
            Controls.Add(servicePerformedLabel);
            Controls.Add(carodometer);
            Controls.Add(secondaryOwnersPanel);
            Controls.Add(secondaryOwnersLabel);
            Controls.Add(mechanicNameLogLabel);
            Controls.Add(endDateTimeLogLabel);
            Controls.Add(startDateTimeLabel);
            Controls.Add(carListFlowLayout);
            Controls.Add(carNameLabel);
            Controls.Add(bookServiceLabel);
            Controls.Add(bookServicePanel);
            Controls.Add(carServiceHistoryLabel);
            Controls.Add(carHistoryTableLayout);
            Controls.Add(myCarListLabel);
            Name = "ViewAllCars";
            Size = new Size(698, 434);
            Load += ViewAllCarsInterfaceLoad;
            bookServicePanel.ResumeLayout(false);
            bookServicePanel.PerformLayout();
            secondaryOwnersPanel.ResumeLayout(false);
            secondaryOwnersPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label myCarListLabel;
        private TableLayoutPanel carHistoryTableLayout;
        private Label carServiceHistoryLabel;
        private Label carNameLabel;
        private Label bookServiceLabel;
        private Panel bookServicePanel;
        private FlowLayoutPanel carListFlowLayout;
        private Label secondaryOwnersLabel;
        private Panel secondaryOwnersPanel;
        private Label startDateTimeLabel;
        private Label endDateTimeLogLabel;
        private Label mechanicNameLogLabel;
        private Label carodometer;
        private Label servicePerformedLabel;
        private DateTimePicker dateTimePicker1;
        private Label bookingAndTimeLabel;
        private Label mechanicNameBookingLabel;
        private ComboBox mechanicComboBox;
        private Button confirmBooking;
        private ComboBox timeComboBox;
        private Button button2;
        private TextBox EmailTextBoxSecondaryOwner;
        private Label label1;
        private Label SecondaryOwnerError;
        private Label CurrentSecondaryOwnerLabel;
        private Label bookingErrorLabel;
    }
}
