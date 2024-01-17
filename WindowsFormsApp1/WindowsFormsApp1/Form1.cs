using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MayTinh : Form
    {
        public MayTinh()
        {
            InitializeComponent();
        }
         void numeric_calc( string butt_number)
        {
            if (this.txtVanban.Text == "0")
            {
                this.txtVanban.Text = butt_number ;
            }
            else
            {
                this.txtVanban.Text = this.txtVanban.Text + butt_number; 
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtVanban.Text = "0"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numeric_calc("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numeric_calc("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numeric_calc("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numeric_calc("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numeric_calc("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numeric_calc("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numeric_calc("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numeric_calc("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numeric_calc("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            numeric_calc("0");
        }
        void operator_buttons ( string op_type )
        {
            this.label1.Text = txtVanban.Text;
            this.label2.Text = op_type;
            this.txtVanban.Text = " ";
        }

        private void btnDivison_Click(object sender, EventArgs e)
        {
            operator_buttons("%");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operator_buttons("x");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operator_buttons("-");
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            operator_buttons("+");
        }
    }
}
