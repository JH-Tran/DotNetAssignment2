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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            carHistoryTableLayout.SuspendLayout();
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
            carHistoryTableLayout.ColumnCount = 5;
            carHistoryTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            carHistoryTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            carHistoryTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            carHistoryTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            carHistoryTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            carHistoryTableLayout.Controls.Add(label1, 0, 0);
            carHistoryTableLayout.Controls.Add(label2, 1, 0);
            carHistoryTableLayout.Controls.Add(label3, 2, 0);
            carHistoryTableLayout.Controls.Add(label4, 3, 0);
            carHistoryTableLayout.Controls.Add(label5, 4, 0);
            carHistoryTableLayout.Location = new Point(17, 710);
            carHistoryTableLayout.Name = "carHistoryTableLayout";
            carHistoryTableLayout.RowCount = 1;
            carHistoryTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            carHistoryTableLayout.Size = new Size(735, 191);
            carHistoryTableLayout.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 0;
            label1.Text = "Start Date Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "End Date Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(297, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 2;
            label3.Text = "Mechanic Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(444, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 3;
            label4.Text = "Car Odometer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(591, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 4;
            label5.Text = "Service Done";
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
            carListFlowLayout.Location = new Point(16, 69);
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
            Size = new Size(798, 352);
            carHistoryTableLayout.ResumeLayout(false);
            carHistoryTableLayout.PerformLayout();
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
