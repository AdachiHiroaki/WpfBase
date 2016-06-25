using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculater
{
    delegate double MyFunc(double num1, double num2);


    class Calculator : ICalculator
    {

        private int _number1;
        private int _number2;
        private int _P = 1;
        public string Number
        {
            get
            {
                switch (_P)
                {
                    case 1:
                        return _number1.ToString();
                    case 2:
                        return _number2.ToString();
                    case 3:
                        return _answer.ToString();
                    default:
                        return "";
                }
            }
        }



        public string Operator
        {
            get;private set;
        }

        public void Add()
        {
            _func = (num1, num2) =>
            {
                return num1 + num2;
            };
           _P = 2;
            Operator = "+";
        }

        public void Substract()
        {
            _func = (num1, num2) =>
            {
                return num1 - num2;
            };
            _P = 2;
            Operator = "-";
        }

        public void Multiple()
        {
            _func = (num1, num2) =>
            {
                return num1 * num2;
            };
            _P = 2;
            Operator = "*";
        }

         public void Divide()
        {
            _func = (num1, num2) =>
            {
                return num1 / num2;
            };
            _P = 2;
            Operator = "/";
        }

        public void AddNumber(int num)
        {
            switch (_P)
            {
                case 1:
                    _number1 = int.Parse(_number1.ToString() + num.ToString());
                    break;
                case 2:
                    _number2 = int.Parse(_number2.ToString() + num.ToString());
                    break;
            }
        }
           
        public void Enter()
        {
            _answer = _func((double)_number1, (double)_number2);
            _P = 3;
            _func = null;
        }

        public void Subtract()
        {
            throw new NotImplementedException();
        }

        private MyFunc _func;
        private object _answer;
    }
}
