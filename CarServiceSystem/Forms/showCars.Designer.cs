namespace CarServiceSystem.Forms
{
    partial class showCars
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
            Titles = new ListBox();
            label3 = new Label();
            label2 = new Label();
            carProperties = new ListBox();
            viewCarButton = new Button();
            backButton = new Button();
            carList = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Titles
            // 
            Titles.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Titles.FormattingEnabled = true;
            Titles.ItemHeight = 25;
            Titles.Location = new Point(453, 124);
            Titles.Name = "Titles";
            Titles.Size = new Size(107, 179);
            Titles.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(566, 88);
            label3.Name = "label3";
            label3.Size = new Size(118, 32);
            label3.TabIndex = 29;
            label3.Text = "Car Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(57, 32);
            label2.TabIndex = 28;
            label2.Text = "Cars";
            // 
            // carProperties
            // 
            carProperties.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            carProperties.FormattingEnabled = true;
            carProperties.ItemHeight = 25;
            carProperties.Location = new Point(566, 124);
            carProperties.Name = "carProperties";
            carProperties.Size = new Size(325, 354);
            carProperties.TabIndex = 27;
            // 
            // viewCarButton
            // 
            viewCarButton.Location = new Point(343, 124);
            viewCarButton.Name = "viewCarButton";
            viewCarButton.Size = new Size(104, 50);
            viewCarButton.TabIndex = 26;
            viewCarButton.Text = "View Car";
            viewCarButton.UseVisualStyleBackColor = true;
            viewCarButton.Click += viewCarButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 510);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 24;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // carList
            // 
            carList.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            carList.FormattingEnabled = true;
            carList.ItemHeight = 25;
            carList.Location = new Point(12, 124);
            carList.Margin = new Padding(3, 4, 3, 4);
            carList.Name = "carList";
            carList.Size = new Size(325, 354);
            carList.TabIndex = 23;
            carList.SelectedIndexChanged += carList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(131, 46);
            label1.TabIndex = 22;
            label1.Text = "All Cars";
            // 
            // showCars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 551);
            Controls.Add(Titles);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(carProperties);
            Controls.Add(viewCarButton);
            Controls.Add(backButton);
            Controls.Add(carList);
            Controls.Add(label1);
            Name = "showCars";
            Text = "showCars";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Titles;
        private Label label3;
        private Label label2;
        private ListBox carProperties;
        private Button viewCarButton;
        private Button backButton;
        private ListBox carList;
        private Label label1;
    }
}