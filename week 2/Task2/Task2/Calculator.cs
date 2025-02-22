using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Calculator
    {
        public int x;
        public int y;
        public Calculator() { }
        public int add(int x, int y) {  return x + y; }
        public int subtract(int x, int y) {return x - y; }
        public int multiply(int x, int y) {return x * y; }
        public int divide(int x, int y) {return x / y; }
    }
}
