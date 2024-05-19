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
        private bool _isNewEntry = true;
        private bool _isNewOperationButtonPressed = false;

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
            if (!_isNewEntry)
            {
                DisplayText = string.Empty;
                _isNewEntry = true;
            }

            DisplayText += number;
            log.Debug($"Entered number: {number}");
        }

        public void SetOperation(IOperation operation, string operationSymbol)
        {
            if (DisplayText == string.Empty)
            {
                return;
            }

            if (_isNewEntry)
            {
                Calculate();
            }

            _currentOperation = operation;
            _currentValue = double.Parse(DisplayText);

            _isNewEntry = false;
            _isNewOperationButtonPressed = true;
            log.Debug($"Set operation: {operationSymbol} with current value: {_currentValue}");
        }

        public void Calculate()
        {
            if (_currentOperation == null)
            {
                return;
            }

            if (_isNewEntry || _isNewOperationButtonPressed)
            {
                _newValue = double.Parse(DisplayText);
            }

            double result = _currentOperation.Execute(_currentValue, _newValue);
            log.Debug($"Calculated result: {_currentValue} {_currentOperation.GetType().Name} {_newValue} = {result}");
            DisplayText = (result == (int)result) ? result.ToString() : result.ToString("F5");
            _currentValue = result;
            _isNewEntry = false;
            _isNewOperationButtonPressed = false;
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
