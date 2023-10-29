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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 82);
            button1.Name = "button1";
            button1.Size = new Size(122, 42);
            button1.TabIndex = 0;
            button1.Text = "Show all Customers";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 130);
            button2.Name = "button2";
            button2.Size = new Size(122, 42);
            button2.TabIndex = 1;
            button2.Text = "Show all Mechanics";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 178);
            button3.Name = "button3";
            button3.Size = new Size(122, 42);
            button3.TabIndex = 2;
            button3.Text = "Show Mechanic Timetable";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 226);
            button4.Name = "button4";
            button4.Size = new Size(122, 42);
            button4.TabIndex = 3;
            button4.Text = "View Car History";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 37);
            label1.TabIndex = 4;
            label1.Text = "Admin Menu";
            // 
            // ServiceAdminMainMenu
            // 
            ClientSize = new Size(433, 420);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ServiceAdminMainMenu";
            Text = "ServiceAdminMainMenu";
            FormClosing += ServiceAdminMainMenu_FormClosing;
            Load += ServiceAdminMainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
    }
}