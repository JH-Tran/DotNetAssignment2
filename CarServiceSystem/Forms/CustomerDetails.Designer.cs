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
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            EmailLabel = new Label();
            EmailTextBox = new TextBox();
            ConfirmButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(273, 99);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(83, 20);
            FirstNameLabel.TabIndex = 0;
            FirstNameLabel.Text = "First Name:";
            // 
            // label2
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(273, 160);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(82, 20);
            LastNameLabel.TabIndex = 1;
            LastNameLabel.Text = "Last Name:";
            // 
            // textBox1
            // 
            FirstNameTextBox.Location = new Point(371, 96);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(125, 27);
            FirstNameTextBox.TabIndex = 2;
            // 
            // textBox2
            // 
            LastNameTextBox.Location = new Point(371, 157);
            LastNameTextBox.Name = "LastNameTextbox";
            LastNameTextBox.Size = new Size(125, 27);
            LastNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(273, 227);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(49, 20);
            EmailLabel.TabIndex = 4;
            EmailLabel.Text = "Email:";
            // 
            // textBox3
            // 
            EmailTextBox.Location = new Point(371, 220);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(125, 27);
            EmailTextBox.TabIndex = 5;
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new Point(344, 313);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(82, 33);
            ConfirmButton.TabIndex = 6;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // CustomerDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ConfirmButton);
            Controls.Add(EmailTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameLabel);
            Name = "CustomerDetails";
            Size = new Size(802, 373);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Label EmailLabel;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox EmailTextBox;
        private Button ConfirmButton;
    }
}
