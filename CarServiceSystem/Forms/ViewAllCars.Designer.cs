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
            carServiceHistoryLabel = new Label();
            carNameLabel = new Label();
            bookServiceLabel = new Label();
            bookServicePanel = new Panel();
            carListFlowLayout = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            secondaryOwnersLabel = new Label();
            secondaryOwnersPanel = new Panel();
            carListFlowLayout.SuspendLayout();
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
            carHistoryTableLayout.ColumnCount = 2;
            carHistoryTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            carHistoryTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            carHistoryTableLayout.Location = new Point(17, 710);
            carHistoryTableLayout.Name = "carHistoryTableLayout";
            carHistoryTableLayout.RowCount = 2;
            carHistoryTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            carHistoryTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            carHistoryTableLayout.Size = new Size(735, 191);
            carHistoryTableLayout.TabIndex = 3;
            // 
            // carServiceHistoryLabel
            // 
            carServiceHistoryLabel.AutoSize = true;
            carServiceHistoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            carServiceHistoryLabel.Location = new Point(17, 679);
            carServiceHistoryLabel.Name = "carServiceHistoryLabel";
            carServiceHistoryLabel.Size = new Size(234, 28);
            carServiceHistoryLabel.TabIndex = 6;
            carServiceHistoryLabel.Text = "Car Service Log History";
            // 
            // carNameLabel
            // 
            carNameLabel.AutoSize = true;
            carNameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            carNameLabel.Location = new Point(14, 233);
            carNameLabel.Name = "carNameLabel";
            carNameLabel.Size = new Size(146, 38);
            carNameLabel.TabIndex = 12;
            carNameLabel.Text = "Car Name";
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
            bookServicePanel.Location = new Point(14, 313);
            bookServicePanel.Name = "bookServicePanel";
            bookServicePanel.Size = new Size(738, 206);
            bookServicePanel.TabIndex = 10;
            // 
            // carListFlowLayout
            // 
            carListFlowLayout.Anchor = AnchorStyles.Top;
            carListFlowLayout.AutoScroll = true;
            carListFlowLayout.Controls.Add(button1);
            carListFlowLayout.Controls.Add(button2);
            carListFlowLayout.Controls.Add(button3);
            carListFlowLayout.Controls.Add(button4);
            carListFlowLayout.Controls.Add(button5);
            carListFlowLayout.Location = new Point(3, 69);
            carListFlowLayout.Name = "carListFlowLayout";
            carListFlowLayout.Size = new Size(738, 161);
            carListFlowLayout.TabIndex = 13;
            carListFlowLayout.WrapContents = false;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(165, 122);
            button1.TabIndex = 14;
            button1.Text = "Car Model\r\nColour\r\nLicense Plate";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(174, 3);
            button2.Name = "button2";
            button2.Size = new Size(165, 122);
            button2.TabIndex = 15;
            button2.Text = "Car Model\r\nColour\r\nLicense Plate";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(345, 3);
            button3.Name = "button3";
            button3.Size = new Size(165, 122);
            button3.TabIndex = 16;
            button3.Text = "Car Model\r\nColour\r\nLicense Plate";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(516, 3);
            button4.Name = "button4";
            button4.Size = new Size(165, 122);
            button4.TabIndex = 17;
            button4.Text = "Car Model\r\nColour\r\nLicense Plate";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(687, 3);
            button5.Name = "button5";
            button5.Size = new Size(165, 122);
            button5.TabIndex = 18;
            button5.Text = "Car Model\r\nColour\r\nLicense Plate";
            button5.UseVisualStyleBackColor = true;
            // 
            // secondaryOwnersLabel
            // 
            secondaryOwnersLabel.AutoSize = true;
            secondaryOwnersLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            secondaryOwnersLabel.Location = new Point(14, 536);
            secondaryOwnersLabel.Name = "secondaryOwnersLabel";
            secondaryOwnersLabel.Size = new Size(188, 28);
            secondaryOwnersLabel.TabIndex = 14;
            secondaryOwnersLabel.Text = "Secondary Owners";
            // 
            // secondaryOwnersPanel
            // 
            secondaryOwnersPanel.Location = new Point(14, 567);
            secondaryOwnersPanel.Name = "secondaryOwnersPanel";
            secondaryOwnersPanel.Size = new Size(738, 92);
            secondaryOwnersPanel.TabIndex = 15;
            // 
            // ViewAllCars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(secondaryOwnersPanel);
            Controls.Add(secondaryOwnersLabel);
            Controls.Add(carListFlowLayout);
            Controls.Add(carNameLabel);
            Controls.Add(bookServiceLabel);
            Controls.Add(bookServicePanel);
            Controls.Add(carServiceHistoryLabel);
            Controls.Add(carHistoryTableLayout);
            Controls.Add(myCarListLabel);
            Name = "ViewAllCars";
            Size = new Size(781, 373);
            carListFlowLayout.ResumeLayout(false);
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
        private Button button1;
        private Label secondaryOwnersLabel;
        private Panel secondaryOwnersPanel;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
