namespace CarServiceSystem.Forms
{
    partial class showCustomers
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
            Titles = new ListBox();
            label3 = new Label();
            label2 = new Label();
            customerProperties = new ListBox();
            viewCustButton = new Button();
            delCustButton = new Button();
            backButton = new Button();
            customerList = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(226, 46);
            label1.TabIndex = 0;
            label1.Text = "All Customers";
            // 
            // Titles
            // 
            Titles.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Titles.FormattingEnabled = true;
            Titles.ItemHeight = 25;
            Titles.Location = new Point(453, 123);
            Titles.Name = "Titles";
            Titles.Size = new Size(107, 79);
            Titles.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(566, 87);
            label3.Name = "label3";
            label3.Size = new Size(179, 32);
            label3.TabIndex = 20;
            label3.Text = "Customer Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 19;
            label2.Text = "Customers";
            // 
            // customerProperties
            // 
            customerProperties.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            customerProperties.FormattingEnabled = true;
            customerProperties.ItemHeight = 25;
            customerProperties.Location = new Point(566, 123);
            customerProperties.Name = "customerProperties";
            customerProperties.Size = new Size(325, 354);
            customerProperties.TabIndex = 18;
            // 
            // viewCustButton
            // 
            viewCustButton.Location = new Point(343, 123);
            viewCustButton.Name = "viewCustButton";
            viewCustButton.Size = new Size(104, 50);
            viewCustButton.TabIndex = 17;
            viewCustButton.Text = "View Customer";
            viewCustButton.UseVisualStyleBackColor = true;
            viewCustButton.Click += viewCustButton_Click_1;
            // 
            // delCustButton
            // 
            delCustButton.Location = new Point(343, 179);
            delCustButton.Name = "delCustButton";
            delCustButton.Size = new Size(104, 50);
            delCustButton.TabIndex = 16;
            delCustButton.Text = "Delete Customer";
            delCustButton.UseVisualStyleBackColor = true;
            delCustButton.Click += delCustButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 509);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 15;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click_1;
            // 
            // customerList
            // 
            customerList.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            customerList.FormattingEnabled = true;
            customerList.ItemHeight = 25;
            customerList.Location = new Point(12, 123);
            customerList.Margin = new Padding(3, 4, 3, 4);
            customerList.Name = "customerList";
            customerList.Size = new Size(325, 354);
            customerList.TabIndex = 14;
            customerList.SelectedIndexChanged += customerList_SelectedIndexChanged;
            // 
            // showCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 548);
            Controls.Add(Titles);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(customerProperties);
            Controls.Add(viewCustButton);
            Controls.Add(delCustButton);
            Controls.Add(backButton);
            Controls.Add(customerList);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "showCustomers";
            Text = "showCustomers";
            Load += showCustomers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox Titles;
        private Label label3;
        private Label label2;
        private ListBox customerProperties;
        private Button viewCustButton;
        private Button delCustButton;
        private Button backButton;
        private ListBox customerList;
    }
}