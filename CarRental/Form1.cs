using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.formIsValid())
                {
                    string customerName = tbCustomerName.Text;
                    var dateOut = dtDateRented.Value;
                    var dateIn = dtDateReturned.Value;
                    var carType = cbTypeOfCar.Text;
                    double cost = Convert.ToDouble(tbCost.Text);

                    MessageBox.Show(
                        $"Customer Name: {customerName}\n\r" +
                        $"Date Rented: {dateOut.ToString()}\n\r" +
                        $"Date Returned: {dateIn.ToString()}\n\r" +
                        $"Car Type: {carType}\n\r" +
                        $"Cost: {cost}\n\r" +
                        $"THANK YOU FOR YOUR BUSINESS"
                    );
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Boolean formIsValid()
        {
            string customerName = tbCustomerName.Text;
            var dateOut = dtDateRented.Value;
            var dateIn = dtDateReturned.Value;
            var carType = cbTypeOfCar.Text;
           

            Boolean isValid = true;
            var errorMessage = "";

            if (
                string.IsNullOrWhiteSpace(customerName) ||
                string.IsNullOrWhiteSpace(carType))
            {
                isValid = false;
                errorMessage += "Please enter missing data.\n\r";
            }

            if (dateOut > dateIn)
            {
                isValid = false;
                errorMessage += "Illegal Date Selection.\n\r";
            }

            double number;
            if (!double.TryParse(tbCost.Text,out number))
            {
                isValid = false;
                errorMessage += "Illegal Cost Number.\n\r";
            }

            if (!isValid)
            {
                MessageBox.Show(errorMessage);
            }

            return isValid;
        }

        private void cbTypeOfCar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
