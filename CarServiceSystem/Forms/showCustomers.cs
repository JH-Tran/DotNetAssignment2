using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceSystem.Forms
{
    public partial class showCustomers : Form
    {
        public showCustomers()
        {
            InitializeComponent();
            listBox1.BeginUpdate();
            for (int i = 0; i < 20; i++)
            {
                listBox1.Items.Add("Item " + i.ToString());
            }
            listBox1.EndUpdate();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
