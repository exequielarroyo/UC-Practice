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
    public partial class Nested : UserControl
    {
        public Nested()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            int width = Convert.ToInt32(widthTextbox.Text);
            int length = Convert.ToInt32(lengthTextbox.Text);

            
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    resultLabel.Text += simbolCombobox.SelectedItem.ToString();
                }
                resultLabel.Text += "\n";
            }
            
        }
    }
}
