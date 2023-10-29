namespace CarServiceSystem.Forms
{
    partial class addMechanic
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
            fNameTxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lNameTxt = new TextBox();
            workshopTxt = new TextBox();
            emailTxt = new TextBox();
            passwordTxt = new TextBox();
            button1 = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(235, 46);
            label1.TabIndex = 0;
            label1.Text = "Add Mechanic";
            // 
            // fNameTxt
            // 
            fNameTxt.Location = new Point(158, 108);
            fNameTxt.Name = "fNameTxt";
            fNameTxt.Size = new Size(266, 27);
            fNameTxt.TabIndex = 1;
            fNameTxt.TextChanged += fNameTxt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 145);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 180);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 4;
            label4.Text = "Workshop";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 270);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 304);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 6;
            label6.Text = "Password";
            // 
            // lNameTxt
            // 
            lNameTxt.Location = new Point(158, 143);
            lNameTxt.Name = "lNameTxt";
            lNameTxt.Size = new Size(266, 27);
            lNameTxt.TabIndex = 7;
            lNameTxt.TextChanged += lNameTxt_TextChanged;
            // 
            // workshopTxt
            // 
            workshopTxt.Location = new Point(158, 178);
            workshopTxt.Name = "workshopTxt";
            workshopTxt.Size = new Size(266, 27);
            workshopTxt.TabIndex = 8;
            workshopTxt.TextChanged += workshopTxt_TextChanged;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(158, 268);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(266, 27);
            emailTxt.TabIndex = 9;
            emailTxt.TextChanged += emailTxt_TextChanged;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(158, 302);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(266, 27);
            passwordTxt.TabIndex = 10;
            passwordTxt.TextChanged += passwordTxt_TextChanged;
            // 
            // addButton
            // 
            button1.Location = new Point(12, 409);
            button1.Name = "addButton";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += addButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(112, 409);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 12;
            backButton.Text = "Cancel";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // addMechanic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(button1);
            Controls.Add(passwordTxt);
            Controls.Add(emailTxt);
            Controls.Add(workshopTxt);
            Controls.Add(lNameTxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(fNameTxt);
            Controls.Add(label1);
            Name = "addMechanic";
            Text = "addMechanic";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox fNameTxt;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox lNameTxt;
        private TextBox workshopTxt;
        private TextBox emailTxt;
        private TextBox passwordTxt;
        private Button button1;
        private Button backButton;
    }
}