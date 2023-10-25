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
            test = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // test
            // 
            test.Location = new Point(10, 37);
            test.Name = "test";
            test.Size = new Size(176, 34);
            test.TabIndex = 0;
            test.Text = "testing button";
            test.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 5);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 4;
            label1.Text = "test label";
            // 
            // ServiceAdminMainMenu
            // 
            ClientSize = new Size(433, 420);
            Name = "ServiceAdminMainMenu";
            Text = "ServiceAdminMainMenu";
            Load += ServiceAdminMainMenu_Load;

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button test;
        private Label label1;
    }
}