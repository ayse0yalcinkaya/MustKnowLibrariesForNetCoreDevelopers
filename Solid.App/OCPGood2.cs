using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.OCP.Good2
{


    public interface ISalaryCalculate
    {
        decimal Calculate(decimal salary);
    }

    public class LowSalaryCalculator 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 0.8m;
        }
    }

    public class MiddleSalaryCalculator 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 1.0m;
        }
    }

    public class HighSalaryCalculator 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 1.2m;
        }
    }

    public class SalaryCalculator
    {
        // Action => void
        // Predicate => bool
        // Func => return value

        public decimal Calculate(decimal salary, Func<decimal, decimal> calculateDelegate) //artık interface almak yerine delege aldım o da metdou işaret ettiği için çağırdı
        {
            return calculateDelegate(salary);

        }
    }



}