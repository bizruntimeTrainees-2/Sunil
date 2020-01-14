using System;

namespace ConsoleApp1
{
    class DivideByOddNumber : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "You Are Trying To Divide With Odd Number";
            }
        }
    }

    class DivideByEvenNumber : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "You are trying to divide with even number";
            }
        }
    }
}
