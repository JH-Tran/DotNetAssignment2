namespace CarServiceSystem.Forms
{
    partial class CustomerRegistration
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            FirstNameInput = new TextBox();
            LastNameInput = new TextBox();
            EmailInput = new TextBox();
            PasswordInput = new TextBox();
            CreateBtn = new Button();
            label5 = new Label();
            InvalidInputLbl = new Label();
            EmailInUseLbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 117);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 156);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 200);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Email: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 243);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // FirstNameInput
            // 
            FirstNameInput.Location = new Point(338, 114);
            FirstNameInput.Name = "FirstNameInput";
            FirstNameInput.Size = new Size(100, 23);
            FirstNameInput.TabIndex = 4;
            // 
            // LastNameInput
            // 
            LastNameInput.Location = new Point(338, 156);
            LastNameInput.Name = "LastNameInput";
            LastNameInput.Size = new Size(100, 23);
            LastNameInput.TabIndex = 5;
            // 
            // EmailInput
            // 
            EmailInput.Location = new Point(338, 200);
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(100, 23);
            EmailInput.TabIndex = 6;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(338, 243);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(100, 23);
            PasswordInput.TabIndex = 7;
            // 
            // CreateBtn
            // 
            CreateBtn.Location = new Point(309, 286);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(103, 23);
            CreateBtn.TabIndex = 8;
            CreateBtn.Text = "Create Account";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 41);
            label5.Name = "label5";
            label5.Size = new Size(717, 42);
            label5.TabIndex = 9;
            label5.Text = "Customer Registration";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InvalidInputLbl
            // 
            InvalidInputLbl.AutoSize = true;
            InvalidInputLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            InvalidInputLbl.ForeColor = Color.Red;
            InvalidInputLbl.Location = new Point(418, 288);
            InvalidInputLbl.Name = "InvalidInputLbl";
            InvalidInputLbl.Size = new Size(180, 17);
            InvalidInputLbl.TabIndex = 10;
            InvalidInputLbl.Text = "Invalid Input, Please try again.";
            InvalidInputLbl.Visible = false;
            // 
            // EmailInUseLbl
            // 
            EmailInUseLbl.AutoSize = true;
            EmailInUseLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailInUseLbl.ForeColor = Color.Red;
            EmailInUseLbl.Location = new Point(444, 201);
            EmailInUseLbl.Name = "EmailInUseLbl";
            EmailInUseLbl.Size = new Size(124, 17);
            EmailInUseLbl.TabIndex = 11;
            EmailInUseLbl.Text = "Email already in use";
            EmailInUseLbl.Visible = false;
            // 
            // CustomerRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 450);
            Controls.Add(EmailInUseLbl);
            Controls.Add(InvalidInputLbl);
            Controls.Add(label5);
            Controls.Add(CreateBtn);
            Controls.Add(PasswordInput);
            Controls.Add(EmailInput);
            Controls.Add(LastNameInput);
            Controls.Add(FirstNameInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerRegistration";
            Text = "CustomerRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox FirstNameInput;
        private TextBox LastNameInput;
        private TextBox EmailInput;
        private TextBox PasswordInput;
        private Button CreateBtn;
        private Label label5;
        private Label InvalidInputLbl;
        private Label EmailInUseLbl;
    }
}