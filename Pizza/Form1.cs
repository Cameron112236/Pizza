using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
   
    public partial class Form1 : Form
    {
        //global variables
        double Pizza = 7.00;
        double topping = 1.25;
        double toppingAmount = 0;
        double totalcost = 0;
        public Form1()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get inputs
            toppingAmount = Convert.ToDouble(inputBox.Text);

            //do calculations
             totalcost = Pizza + topping * toppingAmount;

            //output values
            label3.Text = $"The price of pizza with {toppingAmount} toppings is ${totalcost}";
        }
    }
}
