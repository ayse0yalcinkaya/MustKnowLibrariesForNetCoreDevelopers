using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.OCP.Good
{


    public interface ISalaryCalculate
    {
        decimal Calculate(decimal salary);
    }

    public class LowSalaryCalculator : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 0.8m;
        }
    }

    public class MiddleSalaryCalculator : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 1.0m;
        }
    }

    public class HighSalaryCalculator : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 1.2m;
        }
    }

    public class SalaryCalculator
    {
        public decimal Calculate(decimal salary, ISalaryCalculate salaryCalculate)
        {
            return salaryCalculate.Calculate(salary);

        }
    }



}