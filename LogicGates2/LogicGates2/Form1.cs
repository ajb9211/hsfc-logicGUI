using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicGates2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        public void Calculate()
        {
            int i1 = 0;
            int i2 = 0;

            try
            {
                i1 = Convert.ToInt32(Input1.Text);
                i2 = Convert.ToInt32(Input2.Text);
            }
            catch
            {
                label8.Text = "Error: Invalid input";
            }

            if (IsBinary(i1) && IsBinary(i2))
            {
                label3.Text = "NOT: " + Not(i1);
                label4.Text = "OR: " + Or(i1, i2);
                label5.Text = "AND: " + And(i1, i2);
                label6.Text = "NOR: " + Nor(i1, i2);
                label7.Text = "NAND: " + Nand(i1, i2);
                label8.Text = "Errors: None.";
            }
            else
            {
                label8.Text = "Error: Invalid input";
            }
            
            
        }

        public bool IsBinary(int number)
        {
            if (number == 1 || number == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Not(int number)
        {
            
            if (number == 1)
            {
                return 0;
            }
            else
            {
                return 1;
            }
            
        }

        public int Or(int number, int number2)
        {
            if (number == 1 || number2 == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int And(int number, int number2)
        {
            if (number == 1 && number2 == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Nor(int number, int number2)
        {
            if (number == 1 || number2 == 1)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public int Nand(int number, int number2)
        {
            if (number == 1 && number2 == 1)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
