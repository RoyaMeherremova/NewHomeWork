using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Calculator
    {
        public string Calculation(int number1,int number2,string operation)
        {
            double result = 0;
            switch(operation)
            {
                case "+":
                    result=number1+ number2;
                   return result.ToString();
                    case "-":
                    result=number1- number2;
                    return result.ToString();
                    case "*":
                    result=number1* number2;
                    return result.ToString();
                    case "/":
                    result=number1/ number2;
                    return result.ToString();

                   default:
                    return "Please add correct operation";

            }
            
        }
    }
}
