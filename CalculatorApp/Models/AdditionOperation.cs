﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Models
{
    internal class AdditionOperation : IOperation
    {
        public double Execute(double left, double right)
        {
            return left + right;
        }
    }
}
