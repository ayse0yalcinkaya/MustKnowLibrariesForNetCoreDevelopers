using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.OCP.Bad
{
    public class SalaryCalculator
    {
        public decimal Calculate(decimal salary, SalaryType salaryType)
        {
            decimal calculatedSalary = 0;

            switch (salaryType)
            {
                case SalaryType.Low:
                    calculatedSalary = salary * 0.8m;
                    break;
                case SalaryType.Middle:
                    calculatedSalary = salary * 1.0m;
                    break;
                case SalaryType.High:
                    calculatedSalary = salary * 1.2m;
                    break;
                default:
                    break;
            }
            
            return calculatedSalary;
        }
    }


    public enum SalaryType
    {
        Low, 
        Middle,
        High
    }
}
