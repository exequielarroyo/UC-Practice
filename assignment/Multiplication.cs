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
    public partial class Multiplication : UserControl
    {
        public Multiplication()
        {
            InitializeComponent();
        }

        private void calcuButton_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(firstnumberTextbox.Text);
            int second = Convert.ToInt32(secondnumberTextbox.Text);
            int result = 0;

            for (int i = 0; i < second; i++)
            {
                result += first;
            }

            answerLabel.Text = first + " * " + second + " = " + Convert.ToString(result);
        }
    }
}
