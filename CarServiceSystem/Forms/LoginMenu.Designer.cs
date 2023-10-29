namespace CarServiceSystem
{
    partial class LoginMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            EmailInput = new TextBox();
            PasswordInput = new TextBox();
            LoginBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            InvalidUserPassLbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 82);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 0;
            label1.Text = "Car Maintenance System";
            // 
            // EmailInput
            // 
            EmailInput.ForeColor = Color.Gray;
            EmailInput.Location = new Point(226, 125);
            EmailInput.Margin = new Padding(3, 2, 3, 2);
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(226, 23);
            EmailInput.TabIndex = 1;
            // 
            // PasswordInput
            // 
            PasswordInput.Anchor = AnchorStyles.Top;
            PasswordInput.ForeColor = Color.Gray;
            PasswordInput.Location = new Point(226, 171);
            PasswordInput.Margin = new Padding(3, 2, 3, 2);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.Size = new Size(226, 23);
            PasswordInput.TabIndex = 3;
            // 
            // LoginBtn
            // 
            LoginBtn.Anchor = AnchorStyles.Top;
            LoginBtn.Location = new Point(288, 210);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(75, 23);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 128);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 174);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // InvalidUserPassLbl
            // 
            InvalidUserPassLbl.AutoSize = true;
            InvalidUserPassLbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            InvalidUserPassLbl.ForeColor = Color.Red;
            InvalidUserPassLbl.Location = new Point(203, 246);
            InvalidUserPassLbl.Name = "InvalidUserPassLbl";
            InvalidUserPassLbl.Size = new Size(267, 19);
            InvalidUserPassLbl.TabIndex = 7;
            InvalidUserPassLbl.Text = "Invalid email or password please try again.";
            InvalidUserPassLbl.Visible = false;
            // 
            // LoginMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(InvalidUserPassLbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordInput);
            Controls.Add(EmailInput);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox EmailInput;
        private TextBox PasswordInput;
        private Button LoginBtn;
        private Label label2;
        private Label label3;
        private Label InvalidUserPassLbl;
    }
}