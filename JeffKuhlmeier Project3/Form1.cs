using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeffKuhlmeier_Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /***********************************
         Input button action -> click - JK
        This function calls the calculateDasInput
         * and puts the result in the display
         * textbox.
        *************************************/
        private void button1_Click(object sender, EventArgs e)
        {
            
                displayTextBox.Text = dasInputCalc.calculateDasInput(inputBox.Text).ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
