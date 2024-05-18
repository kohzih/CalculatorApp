using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp.Models
{
    internal class BaseButton : Button
    {
        public BaseButton()
        {
            this.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Size = new System.Drawing.Size(50, 50);
            this.Margin = new Padding(5);
        }
    }
}
