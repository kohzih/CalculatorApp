using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Models
{
    internal interface IOperation
    {
        double Execute(double left, double right);
    }
}
