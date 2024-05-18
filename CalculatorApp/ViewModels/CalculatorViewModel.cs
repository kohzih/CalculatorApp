using CalculatorApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.ViewModels
{
    internal class CalculatorViewModel : INotifyPropertyChanged
    {
        private double _currentValue;
        private string _displayText;
        private IOperation _currentOperation;

        public event PropertyChangedEventHandler PropertyChanged;

        public CalculatorViewModel()
        {
            DisplayText = string.Empty;
        }

        public string DisplayText
        {
            get => _displayText;
            set
            {
                _displayText = value;
                OnPropertyChanged();
            }
        }

        public void EnterNumber(string number)
        {
            DisplayText += number;
        }

        public void SetOperation(IOperation operation, string operationSymbol)
        {
            _currentOperation = operation;
            _currentValue = double.Parse(DisplayText);
            DisplayText = string.Empty;
        }

        public void Calculate()
        {
            if (_currentOperation != null)
            {
                double newValue = double.Parse(DisplayText);
                double result = _currentOperation.Execute(_currentValue, newValue);
                DisplayText = result.ToString("F5");
                _currentOperation = null;
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
