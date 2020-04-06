using Caliburn.Micro;
using demo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace demo.ViewModels
{
    class CalculatorChildViewModel : Screen
    {
        private string _expression;
        private Operand _firstOperand;
        private Operand _secondOperand;
        private string _operator;

        public string Expression
        {
            get { return _expression; }
            set 
            { 
                _expression = value;
                NotifyOfPropertyChange(() => Expression);
            }
        }

        public string Result
        {
            get
            {
                if (String.IsNullOrEmpty(Operator))
                {
                    return FirstOperand.FullPart;
                }
                else
                {
                    return FirstOperand.FullPart +
                    $" {_operator} " +
                    SecondOperand.FullPart;
                }
            }
            set 
            { 
                NotifyOfPropertyChange(() => Result);
            }
        }

        public Operand FirstOperand
        {
            get { return _firstOperand; }
            set 
            { 
                _firstOperand = value;
                NotifyOfPropertyChange(() => Result);
            }
        }

        public Operand SecondOperand
        {
            get { return _secondOperand; }
            set 
            {
                _secondOperand = value;
                NotifyOfPropertyChange(() => Result);
            }
        }

        public string Operator
        {
            get { return _operator; }
            set 
            { 
                _operator = value;
                NotifyOfPropertyChange(() => Result);
            }
        }

        public CalculatorChildViewModel()
        {
            ACButton();
        }

        public void NumberButton(string number)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(Operator))
                {
                    FirstOperand += number;
                }
                else
                {
                    SecondOperand += number;
                }
            } 
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            
        }

        public void OperatorButton(string _operator)
        {
            Operator = _operator;
        }

        public void DotButton()
        {
            if (String.IsNullOrWhiteSpace(Operator))
            {
                FirstOperand.IsDotted = true;
            } 
            else
            {
                SecondOperand.IsDotted = true;
            }
            NotifyOfPropertyChange(() => Result);
        }

        public void EqualButton()
        {
            decimal result;
            Expression = Result;
            try
            {
                switch (Operator)
                {
                    case "+":
                        result = Convert.ToDecimal(FirstOperand.FullPart) + Convert.ToDecimal(SecondOperand.FullPart);
                        SecondOperand = new Operand();
                        FirstOperand.Equal(result);
                        Operator = "";
                        break;
                    case "-":
                        result = Convert.ToDecimal(FirstOperand.FullPart) - Convert.ToDecimal(SecondOperand.FullPart);
                        SecondOperand = new Operand();
                        FirstOperand.Equal(result);
                        Operator = "";
                        break;
                    case "*":
                        result = Convert.ToDecimal(FirstOperand.FullPart) * Convert.ToDecimal(SecondOperand.FullPart);
                        SecondOperand = new Operand();
                        FirstOperand.Equal(result);
                        Operator = "";
                        break;
                    case "/":
                        result = Convert.ToDecimal(FirstOperand.FullPart) / Convert.ToDecimal(SecondOperand.FullPart);
                        SecondOperand = new Operand();
                        FirstOperand.Equal(result);
                        Operator = "";
                        break;
                    default:
                        return;
                }
                NotifyOfPropertyChange(() => Result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void PercentButton()
        {
            if (String.IsNullOrEmpty(Operator))
            {
                decimal result = Convert.ToDecimal(FirstOperand.FullPart);
                result = (result == 0 ? (decimal)(1f / 100f) : (decimal)(result / 100));
                FirstOperand.Equal(result);
            }
            else
            {
                decimal result = Convert.ToDecimal(SecondOperand.FullPart);
                result = (result == 0 ? (decimal)(1f / 100f) : (decimal)(result / 100));
                SecondOperand.Equal(result);
            }
            NotifyOfPropertyChange(() => Result);
        }

        public void LunisolarButton()
        {
            if (String.IsNullOrEmpty(Operator))
            {
                if (FirstOperand.IsNegative == true)
                {
                    FirstOperand.IsNegative = false;
                }
                else 
                {
                    FirstOperand.IsNegative = true;
                }  
            }
            else
            {
                if (SecondOperand.IsNegative == true)
                {
                    SecondOperand.IsNegative = false;
                }
                else
                {
                    SecondOperand.IsNegative = true;
                }
            }
            NotifyOfPropertyChange(() => Result);
        }

        public void DelButton()
        {
            if (String.IsNullOrEmpty(Operator))
            {
                FirstOperand.Del();
                NotifyOfPropertyChange(() => Result);
            }
            else
            {
                SecondOperand.Del();
                NotifyOfPropertyChange(() => Result);
            }
        }

        public void ACButton()
        {
            FirstOperand = new Operand();
            SecondOperand = new Operand();
            Operator = "";
            Expression = "";
        }

    }
}
