namespace CarServiceSystem.Forms
{
    partial class AddCar
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
            tableLayoutPanel1 = new TableLayoutPanel();
            CarCompanyLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(CarCompanyLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox5, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(textBox6, 1, 5);
            tableLayoutPanel1.Location = new Point(112, 63);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.Size = new Size(564, 286);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // CarCompanyLabel
            // 
            CarCompanyLabel.AutoSize = true;
            CarCompanyLabel.Location = new Point(4, 1);
            CarCompanyLabel.Name = "CarCompanyLabel";
            CarCompanyLabel.Size = new Size(98, 20);
            CarCompanyLabel.TabIndex = 0;
            CarCompanyLabel.Text = "Car Company";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 57);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 1;
            label3.Text = "Car Model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 113);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 2;
            label4.Text = "Release Year of Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 169);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 3;
            label2.Text = "Licence Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 225);
            label5.Name = "label5";
            label5.Size = new Size(206, 20);
            label5.TabIndex = 4;
            label5.Text = "Vehicle Identification Number";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(275, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(275, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(275, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(264, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(275, 172);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(264, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(275, 228);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(264, 27);
            textBox5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 281);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 10;
            label6.Text = "Car Colour";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(275, 284);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(264, 27);
            textBox6.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(112, 11);
            label1.Name = "label1";
            label1.Size = new Size(122, 38);
            label1.TabIndex = 0;
            label1.Text = "Add Car";
            // 
            // button1
            // 
            button1.Location = new Point(682, 305);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            // 
            // AddCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Name = "AddCar";
            Size = new Size(803, 372);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label CarCompanyLabel;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label2;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
    }
}
