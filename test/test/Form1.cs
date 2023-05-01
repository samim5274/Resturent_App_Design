using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            HideAllPanel();
        }

        private void HideAllPanel()
        {
            pnlNoodols.Hide();
            pnlFrideItem.Hide();
            pnlBurgur.Hide();
            pnlDrink.Hide();
            pnlSetMenu.Hide();
            gb.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlNoodols.Show();
            gb.Show();
            pnlFrideItem.Hide();
            pnlBurgur.Hide();
            pnlDrink.Hide();
            pnlSetMenu.Hide();
        }
        

        private void button3_Click_1(object sender, EventArgs e)
        {
            pnlFrideItem.Show();
            gb.Show();
            pnlNoodols.Hide();
            pnlBurgur.Hide();
            pnlDrink.Hide();
            pnlSetMenu.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlFrideItem.Show();
            gb.Show();
            pnlNoodols.Hide();
            pnlBurgur.Hide();
            pnlDrink.Hide();
            pnlSetMenu.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlBurgur.Show();
            gb.Show();
            pnlNoodols.Hide();
            pnlFrideItem.Hide();
            pnlDrink.Hide();
            pnlSetMenu.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pnlBurgur.Show();
            gb.Show();
            pnlNoodols.Hide();
            pnlFrideItem.Hide();
            pnlDrink.Hide();
            pnlSetMenu.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pnlDrink.Show();
            gb.Show();
            pnlNoodols.Hide();
            pnlFrideItem.Hide();
            pnlBurgur.Hide();
            pnlSetMenu.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pnlDrink.Show();
            gb.Show();
            pnlNoodols.Hide();
            pnlFrideItem.Hide();
            pnlBurgur.Hide();
            pnlSetMenu.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pnlSetMenu.Show();
            gb.Show();
            pnlNoodols.Hide();
            pnlFrideItem.Hide();
            pnlBurgur.Hide();
            pnlDrink.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pnlSetMenu.Show();
            gb.Show();
            pnlNoodols.Hide();
            pnlFrideItem.Hide();
            pnlBurgur.Hide();
            pnlDrink.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlNoodols.Show();
            gb.Show();
            pnlFrideItem.Hide();
            pnlBurgur.Hide();
            pnlDrink.Hide();
            pnlSetMenu.Hide();
        }
    }
}
