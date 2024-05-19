using CalculatorApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace CalculatorApp.ViewModels
{
    internal class CalculatorViewModel : INotifyPropertyChanged
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(CalculatorViewModel));
        
        private IOperation _currentOperation;
        private double _currentValue;
        private double _newValue;
        private string _displayText;
        private bool _isEnteringNumber = false;
        private bool _isOperationButtonPressed = false;

        public event PropertyChangedEventHandler PropertyChanged;

        public CalculatorViewModel()
        {
            DisplayText = "0";
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
            if (DisplayText == "0" && number == "0")
            {
                _isEnteringNumber = false;
            }

            if (DisplayText == "0" || !_isEnteringNumber)
            {
                DisplayText = string.Empty;
                _isEnteringNumber = true;
            }

            DisplayText += number;
            log.Debug($"Entered number: {number}");
        }

        public void EnterDecimal()
        {
            if (!DisplayText.Contains("."))
            {
                DisplayText += ".";
                _isEnteringNumber = true;
            }
            log.Debug("Entered decimal point");
        }

        public void SetOperation(IOperation operation, string operationSymbol)
        {
            if (DisplayText == string.Empty)
            {
                return;
            }

            if (_isEnteringNumber)
            {
                Calculate();
            }

            _currentOperation = operation;
            _currentValue = double.Parse(DisplayText);

            _isEnteringNumber = false;
            _isOperationButtonPressed = true;
            log.Debug($"Set operation: {operationSymbol} with current value: {_currentValue}");
        }

        public void Calculate()
        {
            if (_currentOperation == null)
            {
                return;
            }

            if (_isEnteringNumber || _isOperationButtonPressed)
            {
                _newValue = double.Parse(DisplayText);
            }

            double result = _currentOperation.Execute(_currentValue, _newValue);
            log.Debug($"Calculated result: {_currentValue} {_currentOperation.GetType().Name} {_newValue} = {result}");
            DisplayText = (result == (int)result) ? result.ToString() : result.ToString("0.#####");
            _currentValue = result;
            _isEnteringNumber = false;
            _isOperationButtonPressed = false;
        }

        public void Clear()
        {
            DisplayText = "0";
            _currentValue = 0;
            _isEnteringNumber = false;
            log.Debug("Cleared current entry");
        }

        public void AllClear()
        {
            DisplayText = "0";
            _currentValue = 0;
            _currentOperation = null;
            _newValue = 0;
            _isEnteringNumber = false;
            _isOperationButtonPressed = false;
            log.Debug("All cleared");
        }

        public void Backspace()
        {
            if (!_isEnteringNumber)
            {
                return;
            }

            DisplayText = DisplayText.Length > 1 ? DisplayText.Substring(0, DisplayText.Length - 1) : "0";
            log.Debug("Backspace pressed");
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
