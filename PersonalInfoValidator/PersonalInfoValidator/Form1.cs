using System;
using System.Windows.Forms;

namespace PersonalInfoValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Connect event handler
            menuRegisterPerson.Click += new EventHandler(menuRegisterPerson_Click);
        }

        private void menuRegisterPerson_Click(object sender, EventArgs e)
        {
            // Show input boxes and associated labels when "Register" is clicked
            txtFirstName.Visible = true;
            txtLastName.Visible = true;
            txtPersonalNumber.Visible = true;
            btnCheck.Visible = true;
            FirstName.Visible = true;
            LastName.Visible = true;
            PersonalNumber.Visible = true;
            Result.Visible = true;
            lblResult.Visible = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Retrieve values from text boxes
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string personalNumber = txtPersonalNumber.Text;

            // Create an instance of the person class with specified values
            Person person = new Person(firstName, lastName, personalNumber);

            // Check the personal number and determine gender
            string result = person.CheckPersonalNumber();

            // Display the result in label
            lblResult.Text = result;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit the application when the user clicks on "Exit"
            Application.Exit();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalNumber { get; set; }

        public Person(string firstName, string lastName, string personalNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PersonalNumber = personalNumber;
        }

        public string CheckPersonalNumber()
        {
            // Remove any dashes from the personal number
            string cleanPersonalNumber = PersonalNumber.Replace("-", "");

            // Check that the personal number consists of 10 digits
            if (cleanPersonalNumber.Length != 10 || !System.Text.RegularExpressions.Regex.IsMatch(cleanPersonalNumber, @"^\d{10}$"))
            {
                return "Invalid personal number (incorrect format).";
            }

            // Calculate subtotals according to the Luhn algorithm
            int sum = 0;
            for (int i = 0; i < cleanPersonalNumber.Length - 1; i++)
            {
                int digit = int.Parse(cleanPersonalNumber[i].ToString());
                if (i % 2 == 0) // Alternate digits starting from the second last digit
                {
                    digit *= 2;
                    sum += digit > 9 ? digit - 9 : digit; // If double digits are over 9, subtract 9.
                }
                else
                {
                    sum += digit;
                }
            }

            // Calculate the check digit (the last digit of the personal number)
            int checkDigit = 10 - (sum % 10);
            checkDigit = checkDigit % 10; // If check digit is 10, set to 0.

            // Check if the last digit of the personal number matches the calculated check digit
            if (int.Parse(cleanPersonalNumber[9].ToString()) == checkDigit)
            {
                string gender = (int.Parse(cleanPersonalNumber[8].ToString()) % 2 == 0) ? "Female" : "Male";
                return $"The personal number is valid \n{gender}.";
            }
            else
            {
                return "Invalid personal number.";
            }
        }

        private int DigitSum(int number)
        {
            // Calculate the digit sum for a number
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
