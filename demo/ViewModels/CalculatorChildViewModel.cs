using Caliburn.Micro;
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
        private string _result;
        private float _firstOperand;
        private float _secondOperand;
        private string _operator;
        private bool _isDotted;

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
                    return $"{String.Format("{0:0.########}", FirstOperand)}{(IsDotted == true && String.IsNullOrEmpty(Operator) ? "." : "")}";
                }
                else
                {
                    return $"{String.Format("{0:0.########}", FirstOperand)}{(IsDotted == true && String.IsNullOrEmpty(Operator) ? "." : "")} " +
                    $"{_operator} " +
                    $"{String.Format("{0:0.########}", SecondOperand)}{(IsDotted == true && !String.IsNullOrEmpty(Operator) ? "." : "")}";
                }
                
            }
            set 
            { 
                _result = value;
                NotifyOfPropertyChange(() => Result);
            }
        }

        public float FirstOperand
        {
            get { return _firstOperand; }
            set 
            { 
                _firstOperand = value;
                NotifyOfPropertyChange(() => Result);
            }
        }

        public float SecondOperand
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

        public bool IsDotted
        {
            get { return _isDotted; }
            set 
            { 
                _isDotted = value;
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
                    string strBuffer = FirstOperand.ToString();
                    if (IsDotted == true)
                    {
                        strBuffer = String.Concat(strBuffer, ".", number);
                        FirstOperand = Convert.ToSingle(strBuffer);
                        IsDotted = false;
                    }
                    else
                    {
                        strBuffer = String.Concat(strBuffer, number);
                        FirstOperand = Convert.ToSingle(strBuffer);
                    }
                }
                else
                {
                    string strBuffer = SecondOperand.ToString();
                    strBuffer = String.Concat(strBuffer, number);
                    SecondOperand = Convert.ToSingle(strBuffer);
                }
            } 
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            
        }
        public void OperatorButton(string _operator)
        {
            Debug.WriteLine(_operator);
            Operator = _operator;
        }

        public void DotButton()
        {
            IsDotted = true;
        }

        public void EqualButton()
        {
            float result;
            Expression = Result;
            try
            {
                switch (Operator)
                {
                    case "+":
                        result = FirstOperand + SecondOperand;
                        SecondOperand = 0;
                        FirstOperand = result;
                        Operator = "";
                        break;
                    case "-":
                        result = FirstOperand - SecondOperand;
                        SecondOperand = 0;
                        FirstOperand = result;
                        Operator = "";
                        break;
                    case "*":
                        result = FirstOperand * SecondOperand;
                        SecondOperand = 0;
                        FirstOperand = result;
                        Operator = "";
                        break;
                    case "/":
                        result = FirstOperand / SecondOperand;
                        SecondOperand = 0;
                        FirstOperand = result;
                        Operator = "";
                        break;
                    default:
                        return;
                }
                IsDotted = false;
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
                FirstOperand = (FirstOperand == 0 ? (float)(1f / 100f) : (float)(FirstOperand / 100));
            } 
            else
            {
                SecondOperand = (SecondOperand == 0 ? (float)(1f / 100f) : (float)(SecondOperand / 100));
            }
        }

        public void LunisolarButton()
        {
            if (String.IsNullOrEmpty(Operator))
            {
                FirstOperand = FirstOperand * -1;
            }
            else
            {
                SecondOperand = SecondOperand * -1;
            }
        }

        public void ACButton()
        {
            FirstOperand = 0;
            SecondOperand = 0;
            Operator = "";
            Expression = "";
            IsDotted = false;
        }

    }
}
