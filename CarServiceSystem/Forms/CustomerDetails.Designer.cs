namespace CarServiceSystem.Forms
{
    partial class CustomerDetails
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
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            emailLabel = new Label();
            confirmButton = new Button();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(276, 156);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(83, 20);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(276, 217);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(82, 20);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(374, 153);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(125, 27);
            firstNameTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(374, 214);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(125, 27);
            lastNameTextBox.TabIndex = 3;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(276, 104);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(49, 20);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(344, 313);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(82, 33);
            confirmButton.TabIndex = 6;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += ConfirmButton_Click;
            // 
            // CustomerDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(confirmButton);
            Controls.Add(emailLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Name = "CustomerDetails";
            Size = new Size(802, 373);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label emailLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Button confirmButton;
    }
}
