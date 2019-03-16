// Car Rental
// Written by Bryce Graham
// CS 1181
// Use a form to process the cost of a car rental

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Cost Per Day, Cost Per Mile, Gas Tank Size
        double[] outback = { 55.75, 0.12, 18.5 }; 
        double[] silverado = { 62.65, .16, 26.0 };
        double[] camaro = { 70.53, .14, 19 };
        

        const double GAS_PRICE = 3.75;
        const double SENIOR_DISCOUNT = 0.05;
        const double FREQUENT_DISCOUNT = 0.03;


        // Place choices into combo box
        // Check first choice
        // Check first radio button
        private void Form1_Load(object sender, EventArgs e)
        {
            carComboBox.Items.Add("2013 Subaru Outback");
            carComboBox.Items.Add("2008 Chevy Silvarado");
            carComboBox.Items.Add("2010 Chevy Camaro");
            carComboBox.SelectedIndex = 0;

            emptyButton.Checked = true;
        }

        // Display the cost per day and cost per mile
        // change the display when different car is selected
        private void carComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(carComboBox.SelectedIndex == 0)
            {
                costPerDayDisplay.Text = outback[0].ToString();
                costPerMileDisplay.Text = outback[1].ToString();
            }
            else if (carComboBox.SelectedIndex == 1)
            {
                costPerDayDisplay.Text = silverado[0].ToString();
                costPerMileDisplay.Text = silverado[1].ToString();
            }
            else
            {
                costPerDayDisplay.Text = camaro[0].ToString();
                costPerMileDisplay.Text = camaro[1].ToString();
            }
            
        }

        // Begin the processing of input information
        // Display the processed information
        private void showBillButton_Click(object sender, EventArgs e)
        {
            string[] chargeType = { "Daily Charge", "Mileage Charge", "Gas Charge", 
                               "Total Charge", "Discount", "Amount Due" };
            string firstName;       
            string lastName;
            double days;
            double startMiles;
            double endMiles;
            double[] charges = new double[6];
            
            bool valid = validateInput(out firstName, out lastName,
                    out days, out startMiles, out endMiles);
            
            

            if (valid)
            {
                rentalBillDisplay.Clear(); // Clears textbox

                charges[0] = getDailyCharge();
                charges[1] = getMileageCharge();
                charges[2] = getGasCharge();
                charges[3] = charges[0] + charges [1] + charges [2];
                charges[4] = applyDiscount(charges[3]);
                charges[5] = charges [3] - charges[4];

                for (int x = 0; x < chargeType.Length; x++)
                {
                    rentalBillDisplay.Text += String.Format("{0, -10}{1, 7:C}\r\n", chargeType[x], charges[x]);
                }

                rentalBillDisplay.Text += "\r\n";
            }
         }

        // Receive firstName, lastName, days, startMiles and endMiles
        // inputs and vailidate them
        private bool validateInput(out string firstName, out string lastName,
                out double days, out double startMiles, out double endMiles)
    {
        bool valid = true;
        bool validNumber;

        errorProvider1.Clear();

            // Validate first name
            // cannot be empty string
            if (firstNameBox.Text.Trim() == "")
            {
                firstName = null;
                errorProvider1.SetError(firstNameBox, "First name is required");
                valid = false;
            }
            else
            {
                firstName = firstNameBox.Text.Trim();
            }

            // Validate last name
            // cannot be empty string
            if (lastNameBox.Text.Trim() == "")
            {
                lastName = null;
                errorProvider1.SetError(lastNameBox, "last name is required");
                valid = false;
            }
            else
            {
                lastName = lastNameBox.Text.Trim();
            }

            // Validate days
            // cannont be empty string
            // cannot be 0 or less than 0
            validNumber = double.TryParse(daysBox.Text, out days);

            if (!validNumber)
            {
                days = 1;
                errorProvider1.SetError(daysBox, "Invalid days");
                valid = false;
            }
            
            if (days <= 0)
            {
                errorProvider1.SetError(daysBox, "Days cannot be 0");
                valid = false;
            }

            // Validate starting miles
            // cannot be empty string
            // cannot be less than 0
            validNumber = double.TryParse(startMilesBox.Text, out startMiles);
            if (!validNumber)
            {
                errorProvider1.SetError(startMilesBox, "Invalid starting miles");
                valid = false;
            }

            if (startMiles < 0)
            {
                errorProvider1.SetError(startMilesBox, "Starting miles cannot be less than 0");
                valid = false;
            }

            // Validate ending miles
            // cannot be empty string
            // cannot be less than 0
            // cannot be less than starting miles
            validNumber = double.TryParse(endMilesBox.Text, out endMiles);
            if (!validNumber)
            {
                errorProvider1.SetError(endMilesBox, "Invalid ending miles");
                valid = false;
            }

            if (endMiles < 0)
            {
                errorProvider1.SetError(endMilesBox, "Ending miles cannot be less than 0");
                valid = false;
            }

            if (startMiles > endMiles)
            {
                errorProvider1.SetError(endMilesBox, "Ending miles cannot be less than starting miles");
                valid = false;
            }

            return valid;
    }

        // Calculate the daily charge
        // depending on selected car
        // and number of days
        private double getDailyCharge()
    {
        double dailyCharge;

        if (carComboBox.SelectedIndex == 0)
        {
            dailyCharge = outback[0] * double.Parse(daysBox.Text);
        }
        else if (carComboBox.SelectedIndex == 1)
        {
            dailyCharge = silverado[0] * double.Parse(daysBox.Text);
        }
        else
        {
            dailyCharge = camaro[0] * double.Parse(daysBox.Text);
        }
        return dailyCharge;
    }

        // Calculate the mileage charge
        // depending on selected car
        // and miles traveled
        private double getMileageCharge()
        {
            double mileageCharge;
            double totalMiles;

            totalMiles = double.Parse(endMilesBox.Text) - double.Parse(startMilesBox.Text);

            if (carComboBox.SelectedIndex == 0)
            {
                mileageCharge = outback[1] * totalMiles;
            }
            else if (carComboBox.SelectedIndex == 1)
            {
                mileageCharge = silverado[1] * totalMiles;
            }
            else
            {
                mileageCharge = camaro[1] * totalMiles;
            }
            return mileageCharge;
        }

        // Calculate the gas charge
        // depending on amount of gas used
        private double getGasCharge()
        {
            double gasCharge;
            double gasLeft;

            if (emptyButton.Checked)
            {
                gasLeft = 0;
            }
            else if (quarterButton.Checked)
            {
                gasLeft = .25;
            }
            else if (halfButton.Checked)
            {
                gasLeft = .5;
            }
            else if (threeQuartersButton.Checked)
            {
                gasLeft = .75;
            }
            else
            {
                gasLeft = 1;
            }

            if (carComboBox.SelectedIndex == 0)
            {
                gasCharge = (outback[2] - outback[2] * gasLeft) * GAS_PRICE;
            }
            else if (carComboBox.SelectedIndex == 1)
            {
                gasCharge = (silverado[2] - silverado[2] * gasLeft) * GAS_PRICE;
            }
            else
            {
                gasCharge = (camaro[2] - camaro[2] * gasLeft) * GAS_PRICE;
            }
            return gasCharge;
        }

        // Obtain the type(s) of discount
        // apply the discount to the total charge
        private double applyDiscount(double totalCharge)
        {
            double discountApplied;

            if (seniorCitizenCheck.Checked && frequentRenterCheck.Checked)
            {
                discountApplied = totalCharge * (FREQUENT_DISCOUNT + SENIOR_DISCOUNT);
            }
            else if (seniorCitizenCheck.Checked)
            {
                discountApplied = totalCharge * SENIOR_DISCOUNT;
            }
            else if (frequentRenterCheck.Checked)
            {
                discountApplied = totalCharge * FREQUENT_DISCOUNT;
            }
            else
            {
                discountApplied = 0;
            }

            return discountApplied;
        }
        

    }
}
