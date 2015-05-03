using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calcualtor : Form
    {
        private double firstNumber;
        private double secondNubmer;
        Calculation cal = new Calculation();
        public Calcualtor()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            firstNumber = Convert.ToDouble(firstnumberTextBox.Text);
            secondNubmer = Convert.ToDouble(secondnumberTextBox.Text);
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            Initialize();
            resultTextBox.Text = cal.Add(firstNumber, secondNubmer).ToString();
        }

        private void substractButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = cal.Substract(firstNumber, secondNubmer).ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = cal.Myltiply(firstNumber, secondNubmer).ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = cal.Devide(firstNumber, secondNubmer).ToString();
        }
        
        
    }
}
