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
            button4 = new Button();
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
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Location = new Point(34, 24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(719, 323);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(182, 3);
            button2.Name = "button2";
            button2.Size = new Size(173, 106);
            button2.TabIndex = 1;
            button2.Text = "Car Name\r\nModel\r\nColour\r\nLicence number";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(361, 3);
            button3.Name = "button3";
            button3.Size = new Size(173, 106);
            button3.TabIndex = 2;
            button3.Text = "Car Name\r\nModel\r\nColour\r\nLicence number";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(540, 3);
            button4.Name = "button4";
            button4.Size = new Size(173, 106);
            button4.TabIndex = 3;
            button4.Text = "Car Name\r\nModel\r\nColour\r\nLicence number";
            button4.UseVisualStyleBackColor = true;
            // 
            // ViewAllCars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(flowLayoutPanel1);
            Name = "ViewAllCars";
            Size = new Size(802, 373);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
