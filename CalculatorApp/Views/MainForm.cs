using CalculatorApp.Models;
using CalculatorApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorApp.Models;

namespace CalculatorApp
{
    public partial class MainForm : Form
    {
        private CalculatorViewModel _viewModel;

        public MainForm()
        {
            InitializeComponent();
            _viewModel = new CalculatorViewModel();
            DisplayTextBox.DataBindings.Add(new Binding("Text", _viewModel, "DisplayText", false, DataSourceUpdateMode.OnPropertyChanged));

            btnAdd.Click += OperatorButton_Click;
            btnSubtract.Click += OperatorButton_Click;
            btnMultiply.Click += OperatorButton_Click;
            btnDivide.Click += OperatorButton_Click;

            btnNumber0.Click += NumberButton_Click;
            btnNumber1.Click += NumberButton_Click;
            btnNumber2.Click += NumberButton_Click;
            btnNumber3.Click += NumberButton_Click;
            btnNumber4.Click += NumberButton_Click;
            btnNumber5.Click += NumberButton_Click;
            btnNumber6.Click += NumberButton_Click;
            btnNumber7.Click += NumberButton_Click;
            btnNumber8.Click += NumberButton_Click;
            btnNumber9.Click += NumberButton_Click;

            btnEquals.Click += EqualsButton_Click;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            var button = sender as DerivedButton;
            _viewModel.EnterNumber(button.DisplayText);
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            var button = sender as DerivedButton;

            switch (button.DisplayText)
            {
                case "＋":
                    _viewModel.SetOperation(new AdditionOperation(), button.DisplayText);
                    break;
                case "－":
                    _viewModel.SetOperation(new SubtractionOperation(), button.DisplayText);
                    break;
                case "×":
                    _viewModel.SetOperation(new MultiplicationOperation(), button.DisplayText);
                    break;
                case "÷":
                    _viewModel.SetOperation(new DivisionOperation(), button.DisplayText);
                    break;
                default:
                    throw new InvalidOperationException("Unknown operator");
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            _viewModel.Calculate();
        }
    }
}
