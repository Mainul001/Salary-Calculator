using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    class Employee
    {
        public string Name { get; set; }
        public double BasicAmount { get; set; }
        public double HouseRentPercentage { get; set; }
        public double MedicalAllowancePercentage { get; set; }

        public double showSalary()
        {
            double salary = 0;

            salary = BasicAmount + (BasicAmount*(HouseRentPercentage/100.0)) +
                           (BasicAmount*(MedicalAllowancePercentage/100.0));

            return salary;
        }
    }
}
