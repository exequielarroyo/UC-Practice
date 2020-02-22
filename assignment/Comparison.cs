using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class Comparison : UserControl
    {
        public Comparison()
        {
            InitializeComponent();
        }
        public static int number;
        public static int expo;
        private void compareButton_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(firstNumberTextbox.Text);
            expo = Convert.ToInt32(secondNumberTextbox.Text);
            resultLabel.Text = Compare(number, expo);
        }

        private string Compare(int x, int y)
        {
            if (x > y)
            {
                return x + " is greater than " + y;
            }
            else if (x < y)
            {
                return x + " is less than " + y;
            }
            else
            {
                return "Two numbers are equal";
            }

        }
    }
}
