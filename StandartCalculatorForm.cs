using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class StandartCalculatorForm : Form
    {
        private Size _oldSize;
        private StandartCalculator _calculator;
        private bool _enterValue = false;
        public StandartCalculatorForm()
        {
            InitializeComponent();
        }

        private void StandartCalculatorForm_Load(object sender, EventArgs e)
        {
            _oldSize = this.Size;
            _calculator = new StandartCalculator();
        }

        private void StandartCalculatorForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" || _enterValue) Display.Text = string.Empty;
            _enterValue = false;
            Button btn = (Button)sender;
            if (btn.Text == ".")
            {
                if (Display.Text.Contains(".")) return;
                Display.Text += btn.Text;
            }
            else
            {
                Display.Text += btn.Text;
            }

        }

        private void BtnBinaryOperation_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            if (!string.IsNullOrEmpty(_calculator.Operation))
            {
                _calculator.SecondValue = Display.Text;
                StandartCalculatorController.ApplyOperation(_calculator);
                Display.Text = _calculator.Result.ToString();
                _calculator.Result = Convert.ToDecimal(Display.Text);
            }
            _calculator.Operation = btn.Text;
            _calculator.FirstValue = !string.IsNullOrEmpty(subDisplay.Text) ? _calculator.Result.ToString() : Display.Text;
            subDisplay.Text += string.IsNullOrEmpty(subDisplay.Text) ? $"{_calculator.FirstValue} {_calculator.Operation} " : $"{_calculator.SecondValue} {_calculator.Operation} ";
            _enterValue = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            subDisplay.Text = string.Empty;
            if (!string.IsNullOrEmpty(Display.Text))
            {
                _calculator.SecondValue = Display.Text;
                StandartCalculatorController.ApplyOperation(_calculator);
                Display.Text = _calculator.Result.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text.Remove(Display.Text.Length - 1);
            if (Display.Text.Length == 0) Display.Text = "0";
        }
    }
}
