using System;
using System.Windows.Forms;

namespace Sample
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Addition Operation
            int firstnumber = int.Parse(txtFirstNumber.Text);
            int secondnumber = int.Parse(SecondNumber.Text);
            label3.Text = "Addition of 2 numbers is: ";
            int sum = firstnumber + secondnumber;
            Result.Text = sum.ToString();
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            //Substaction Operation
            int firstName = int.Parse(txtFirstNumber.Text);
            int secondNumber = int.Parse(SecondNumber.Text);
            label3.Text = "Substraction of 2 numbers is: ";
            int result = firstName - secondNumber;
            Result.Text = result.ToString();

        }

        private void MulButton_Click(object sender, EventArgs e)
        {
            //Multiplication Operation
            int firstName = int.Parse(txtFirstNumber.Text);
            int secondNumber = int.Parse(SecondNumber.Text);
            label3.Text = "Multiplication of 2 numbers is: ";
            int result = firstName * secondNumber;
            Result.Text = result.ToString();
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            //Division Operation

            int firstName = int.Parse(txtFirstNumber.Text);
            int secondNumber = int.Parse(SecondNumber.Text);
            if (secondNumber == 0)
            {
                MessageBox.Show("Please Enter Other than 0");
            }
            int result = firstName / secondNumber;
            label3.Text = "Divide of 2 numbers is: ";
            Result.Text = result.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Result.Text = " ";
            txtFirstNumber.Text = " ";
            SecondNumber.Text = " ";
        }
    }
}
