using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public interface ICalculator
    {
        public int Add(int a, int b);

        public int Subtract(int a, int b);
    }
}