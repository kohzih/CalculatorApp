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

            btnDecimal.Click += DecimalButton_Click;

            btnEquals.Click += EqualsButton_Click;

            btnClear.Click += ClearButton_Click;
            btnAllClear.Click += AllClearButton_Click;
            btnBackspace.Click += BackspaceButton_Click;

            // キーボードイベント処理を有効にする
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(MainForm_KeyDown);
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            var button = sender as CalculatorButton ;
            _viewModel.EnterNumber(button.DisplayText);
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            _viewModel.EnterDecimal();
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            var button = sender as CalculatorButton ;

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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _viewModel.Clear();
        }

        private void AllClearButton_Click(object sender, EventArgs e)
        {
            _viewModel.AllClear();
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            _viewModel.Backspace();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Enterキー押下は計算ボタン押下として扱う
            if (keyData == Keys.Enter)
            {
                MainForm_KeyDown(this, new KeyEventArgs(keyData));
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // 数字キーの処理
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                _viewModel.EnterNumber((e.KeyCode - Keys.D0).ToString());
            }
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                _viewModel.EnterNumber((e.KeyCode - Keys.NumPad0).ToString());
            }
            // 小数点キーの処理
            else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
            {
                _viewModel.EnterDecimal();
            }
            // 演算子キーの処理
            else if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus && e.Shift)
            {
                _viewModel.SetOperation(new AdditionOperation(), btnAdd.DisplayText);
            }
            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus && !e.Shift)
            {
                _viewModel.SetOperation(new SubtractionOperation(), btnSubtract.DisplayText);
            }
            else if (e.KeyCode == Keys.Multiply || e.KeyCode == Keys.Oem1 && e.Shift)
            {
                _viewModel.SetOperation(new MultiplicationOperation(), btnMultiply.DisplayText);
            }
            else if (e.KeyCode == Keys.Divide || e.KeyCode == Keys.OemQuestion && !e.Shift)
            {
                _viewModel.SetOperation(new DivisionOperation(), btnDivide.DisplayText);
            }
            // 等号キーの処理
            else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Oemplus)
            {
                _viewModel.Calculate();
            }
            // バックスペースキーの処理
            else if (e.KeyCode == Keys.Back)
            {
                _viewModel.Backspace();
            }
            // クリアキーの処理
            else if (e.KeyCode == Keys.Delete)
            {
                _viewModel.Clear();
            }
            // オールクリアキーの処理
            else if (e.KeyCode == Keys.Escape)
            {
                _viewModel.AllClear();
            }

            e.Handled = true;
        }
    }
}
