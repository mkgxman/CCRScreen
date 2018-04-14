using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CCRScreen
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i == 0)
                label1.ForeColor = Color.Red;
            else if (i == 1)
                label1.ForeColor = Color.Lime;
            else if (i == 2)
                label1.ForeColor = Color.Gray;

            i++;
            if (i == 3)
                i = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Control ctl in tabPage2.Controls)
            {
                    if(ctl is Station)
                        MessageBox.Show(ctl.Name);
                        
                
            }
        }
    }
}
