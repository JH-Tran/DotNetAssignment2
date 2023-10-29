namespace CarServiceSystem.Forms
{
    partial class showMechanics
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
            backButton = new Button();
            mechanicsList = new ListBox();
            label1 = new Label();
            delMechButton = new Button();
            viewMechButton = new Button();
            mechanicProperties = new ListBox();
            label2 = new Label();
            label3 = new Label();
            Titles = new ListBox();
            addMechButton = new Button();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 509);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 5;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // mechanicsList
            // 
            mechanicsList.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            mechanicsList.FormattingEnabled = true;
            mechanicsList.ItemHeight = 25;
            mechanicsList.Location = new Point(12, 123);
            mechanicsList.Margin = new Padding(3, 4, 3, 4);
            mechanicsList.Name = "mechanicsList";
            mechanicsList.Size = new Size(325, 354);
            mechanicsList.TabIndex = 4;
            mechanicsList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(225, 46);
            label1.TabIndex = 3;
            label1.Text = "All Mechanics";
            // 
            // delMechButton
            // 
            delMechButton.Location = new Point(343, 179);
            delMechButton.Name = "delMechButton";
            delMechButton.Size = new Size(104, 50);
            delMechButton.TabIndex = 7;
            delMechButton.Text = "Delete Mechanic";
            delMechButton.UseVisualStyleBackColor = true;
            delMechButton.Click += delMechButton_Click;
            // 
            // viewMechButton
            // 
            viewMechButton.Location = new Point(343, 123);
            viewMechButton.Name = "viewMechButton";
            viewMechButton.Size = new Size(104, 50);
            viewMechButton.TabIndex = 8;
            viewMechButton.Text = "View Mechanic";
            viewMechButton.UseVisualStyleBackColor = true;
            viewMechButton.Click += viewMechButton_Click;
            // 
            // mechanicProperties
            // 
            mechanicProperties.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            mechanicProperties.FormattingEnabled = true;
            mechanicProperties.ItemHeight = 25;
            mechanicProperties.Location = new Point(566, 123);
            mechanicProperties.Name = "mechanicProperties";
            mechanicProperties.Size = new Size(325, 354);
            mechanicProperties.TabIndex = 9;
            mechanicProperties.SelectedIndexChanged += mechanicProperties_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 10;
            label2.Text = "Mechanics";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(566, 87);
            label3.Name = "label3";
            label3.Size = new Size(177, 32);
            label3.TabIndex = 11;
            label3.Text = "Mechanic Details";
            // 
            // Titles
            // 
            Titles.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Titles.FormattingEnabled = true;
            Titles.ItemHeight = 25;
            Titles.Location = new Point(453, 123);
            Titles.Name = "Titles";
            Titles.Size = new Size(107, 104);
            Titles.TabIndex = 12;
            Titles.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // addMechButton
            // 
            addMechButton.Location = new Point(343, 427);
            addMechButton.Name = "button1";
            addMechButton.Size = new Size(104, 50);
            addMechButton.TabIndex = 13;
            addMechButton.Text = "Add Mechanic";
            addMechButton.UseVisualStyleBackColor = true;
            addMechButton.Click += addMechButton_Click;
            // 
            // showMechanics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 550);
            Controls.Add(addMechButton);
            Controls.Add(Titles);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(mechanicProperties);
            Controls.Add(viewMechButton);
            Controls.Add(delMechButton);
            Controls.Add(backButton);
            Controls.Add(mechanicsList);
            Controls.Add(label1);
            Name = "showMechanics";
            Text = "showMechanics";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private ListBox mechanicsList;
        private Label label1;
        private Button delMechButton;
        private Button viewMechButton;
        private ListBox mechanicProperties;
        private Label label2;
        private Label label3;
        private ListBox Titles;
        private Button addMechButton;
    }
}