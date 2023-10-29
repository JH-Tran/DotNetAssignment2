namespace CarServiceSystem.Forms
{
    partial class ServiceAdminMainMenu
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
            showCustomersButton = new Button();
            showMechanicsButton = new Button();
            showCarsButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // showCustomersButton
            // 
            showCustomersButton.Location = new Point(12, 91);
            showCustomersButton.Name = "showCustomersButton";
            showCustomersButton.Size = new Size(142, 56);
            showCustomersButton.TabIndex = 0;
            showCustomersButton.Text = "Show all Customers";
            showCustomersButton.UseVisualStyleBackColor = true;
            showCustomersButton.Click += showCustomersButton_Click;
            // 
            // showMechanicsButton
            // 
            showMechanicsButton.Location = new Point(12, 153);
            showMechanicsButton.Name = "showMechanicsButton";
            showMechanicsButton.Size = new Size(142, 56);
            showMechanicsButton.TabIndex = 1;
            showMechanicsButton.Text = "Show all Mechanics";
            showMechanicsButton.UseVisualStyleBackColor = true;
            showMechanicsButton.Click += showMechanicsButton_Click;
            // 
            // showCarsButton
            // 
            showCarsButton.Location = new Point(12, 215);
            showCarsButton.Name = "viewCarHistButton";
            showCarsButton.Size = new Size(142, 56);
            showCarsButton.TabIndex = 3;
            showCarsButton.Text = "Show All Cars";
            showCarsButton.UseVisualStyleBackColor = true;
            showCarsButton.Click += showCarsButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 46);
            label1.TabIndex = 4;
            label1.Text = "Admin Menu";
            // 
            // ServiceAdminMainMenu
            // 
            ClientSize = new Size(531, 459);
            Controls.Add(label1);
            Controls.Add(showCarsButton);
            Controls.Add(showMechanicsButton);
            Controls.Add(showCustomersButton);
            Name = "ServiceAdminMainMenu";
            Text = "ServiceAdminMainMenu";
            Load += ServiceAdminMainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button showCustomersButton;
        private Button showMechanicsButton;
        private Button showCarsButton;
        private Label label1;
    }
}