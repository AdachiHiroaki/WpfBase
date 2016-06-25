using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculater
{
    interface ICalculator
    {
        string Number { get; }
        string Operator { get; }
        void AddNumber(int num);
        void Add();
        void Subtract();
        void Multiple();
        void Divide();
        void Enter();
    }
}
