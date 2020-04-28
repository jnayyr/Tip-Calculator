using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValidatePositiveDouble(string text, out Double number, out string errorMessage)
        {
            errorMessage = null;
            number = 0;

            try
            {
                number = double.Parse(text);

                if (number > 0)
                {
                    return true;
                }
                else
                {
                    errorMessage = "Enter a positive number";
                    return false;
                }
            }
            catch (FormatException)
            {
                errorMessage = "Enter a number";
                return false;
            }
            catch(OverflowException)
            {
                errorMessage = "Enter a smaller number";
                return false;
            }
        }

        private bool ValidateName(string text, out string name, out string errorMessage)
        {
            errorMessage = null;
            name = text;

            if(string.IsNullOrEmpty(text))
            {
                errorMessage = "Please enter something";
                return false;
            }
            if (text.Length < 3)
            {
                errorMessage = "Enter at least 3 characters";
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!ValidateName(txtRestaurantName.Text, out string restaurantName, out string nameErrorMessage))
            {
                MessageBox.Show(nameErrorMessage, "Restaurant name error");
                txtRestaurantName.Focus(); // Moves focus to restaurant name textbox so user can fix the error
                return; // stop processing event
            }

            if (!ValidatePositiveDouble(txtBillAmount.Text, out double billAmount, out string billErrorMessage))
            {
                MessageBox.Show(billErrorMessage, "Bill total error");
                txtBillAmount.Focus(); // Moves focus to the bill textbox for user
            }

            double totalBillAmount = Double.Parse(txtBillAmount.Text);
            int numberOfPeople = int.Parse(txtNumberOfPeople.Text);
            double tipPercent = Double.Parse(txtTipPercent.Text);

            double totalBeforeTip = totalBillAmount / numberOfPeople;
            double tipAmount = totalBeforeTip * (tipPercent/100);
            double totalAfterTip = totalBeforeTip + tipAmount;

            txtTotalBeforeTip.Text = totalBeforeTip.ToString();
            txtTipAmount.Text = tipAmount.ToString();
            txtTotalWithTip.Text = totalAfterTip.ToString();

        }
    }
}
