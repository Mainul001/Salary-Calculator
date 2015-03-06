using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            Employee anEmployee = new Employee();

            anEmployee.Name = nameTextBox.Text;
            anEmployee.BasicAmount = double.Parse(basicTextBox.Text);
            anEmployee.HouseRentPercentage = double.Parse(rentTextBox.Text);
            anEmployee.MedicalAllowancePercentage = double.Parse(medicalTextBox.Text);

            MessageBox.Show(anEmployee.Name + " your salary is " + anEmployee.showSalary());
        }
    }
}
