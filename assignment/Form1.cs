using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            MathSubPanel.Visible = false;
        }

        private void hideSubmenu()
        {
            if (MathSubPanel.Visible == true)
            {
                MathSubPanel.Visible = false;
            }

        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void MathButton_Click(object sender, EventArgs e)
        {
            showSubmenu(MathSubPanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Code Here!
            calculator1.Show();
            comparison1.Hide();
            multiplication1.Hide();
            nested1.Hide();
            hideSubmenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Code Here!
            calculator1.Hide();
            comparison1.Show();
            multiplication1.Hide();
            nested1.Hide();
            hideSubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Code Here!
            calculator1.Hide();
            comparison1.Hide();
            multiplication1.Show();
            nested1.Hide();
            hideSubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Code Here!
            calculator1.Hide();
            comparison1.Hide();
            multiplication1.Hide();
            nested1.Show();
            hideSubmenu();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            calculator1.Hide();
            comparison1.Hide();
            multiplication1.Hide();
            nested1.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void CLEARbtn_Click(object sender, EventArgs e)
        {
            calculator1.Visible = false;
            comparison1.Visible = false;
            multiplication1.Visible = false;
            nested1.Visible = false;
        }
    }
}
