using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Models
{
    internal class DerivedButton : BaseButton
    {
        private string _displayText;

        [Category("Custom Properties")]
        [Description("表示文字")]
        public string DisplayText
        {
            get { return _displayText; }
            set
            {
                _displayText = value;
                this.Text = value;
                Invalidate();  // ボタンの再描画
            }
        }

        public DerivedButton()
        {
            this.Size = new Size(60, 60);
        }
    }
}
