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
            label1.Location = new Point(303, 109);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 0;
            label1.Text = "Car Maintenance System";
            // 
            // EmailInput
            // 
            EmailInput.ForeColor = Color.Black;
            EmailInput.Location = new Point(258, 167);
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(258, 27);
            EmailInput.TabIndex = 1;
            // 
            // PasswordInput
            // 
            PasswordInput.Anchor = AnchorStyles.Top;
            PasswordInput.ForeColor = Color.Black;
            PasswordInput.Location = new Point(258, 228);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.Size = new Size(258, 27);
            PasswordInput.TabIndex = 3;
            // 
            // LoginBtn
            // 
            LoginBtn.Anchor = AnchorStyles.Top;
            LoginBtn.Location = new Point(329, 280);
            LoginBtn.Margin = new Padding(3, 4, 3, 4);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(86, 31);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 171);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 232);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // InvalidUserPassLbl
            // 
            InvalidUserPassLbl.AutoSize = true;
            InvalidUserPassLbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            InvalidUserPassLbl.ForeColor = Color.Red;
            InvalidUserPassLbl.Location = new Point(232, 328);
            InvalidUserPassLbl.Name = "InvalidUserPassLbl";
            InvalidUserPassLbl.Size = new Size(332, 23);
            InvalidUserPassLbl.TabIndex = 7;
            InvalidUserPassLbl.Text = "Invalid email or password please try again.";
            InvalidUserPassLbl.Visible = false;
            // 
            // LoginMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(InvalidUserPassLbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordInput);
            Controls.Add(EmailInput);
            Controls.Add(label1);
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