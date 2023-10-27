namespace CarServiceSystem.Forms
{
    partial class ViewAllCars
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
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button4 = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(173, 106);
            button1.TabIndex = 0;
            button1.Text = "Car Name\r\nModel\r\nColour\r\nLicence number";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Location = new Point(16, 81);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(202, 341);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(3, 115);
            button2.Name = "button2";
            button2.Size = new Size(173, 106);
            button2.TabIndex = 1;
            button2.Text = "Car Name\r\nModel\r\nColour\r\nLicence number";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 227);
            button3.Name = "button3";
            button3.Size = new Size(173, 106);
            button3.TabIndex = 2;
            button3.Text = "Car Name\r\nModel\r\nColour\r\nLicence number";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(3, 339);
            button5.Name = "button5";
            button5.Size = new Size(173, 106);
            button5.TabIndex = 4;
            button5.Text = "Car Name\r\nModel\r\nColour\r\nLicence number";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(3, 451);
            button4.Name = "button4";
            button4.Size = new Size(173, 106);
            button4.TabIndex = 3;
            button4.Text = "Car Name\r\nModel\r\nColour\r\nLicence number";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(19, 27);
            label1.Name = "label1";
            label1.Size = new Size(113, 38);
            label1.TabIndex = 2;
            label1.Text = "Car List";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(235, 373);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(531, 191);
            tableLayoutPanel1.TabIndex = 3;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(235, 342);
            label3.Name = "label3";
            label3.Size = new Size(234, 28);
            label3.TabIndex = 6;
            label3.Text = "Car Service Log History";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(235, 84);
            label2.Name = "label2";
            label2.Size = new Size(141, 28);
            label2.TabIndex = 8;
            label2.Text = " Book Service";
            // 
            // panel1
            // 
            panel1.Location = new Point(235, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 206);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(235, 27);
            label4.Name = "label4";
            label4.Size = new Size(146, 38);
            label4.TabIndex = 9;
            label4.Text = "Car Name";
            // 
            // ViewAllCars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Name = "ViewAllCars";
            Size = new Size(763, 427);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label4;
    }
}
