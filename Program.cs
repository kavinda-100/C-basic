using System;
using Program.controllFlow;
using Program.Date_and_time;
using Program.Functions;
using Program.List_and_ArrayList;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Basic ----------------------------------------------------------------------------
            // for strings
            StringsPractice stringsPractice = new StringsPractice();
            // stringsPractice.Run();
            // for numbers
            Numbers numbers = new Numbers();
            // numbers.Run();
            
            // for control flow -----------------------------------------------------------------------
            // if else statement
            ifelseStatment ifelseStatment = new ifelseStatment();
            // ifelseStatment.Run();
            // switch statement
            SwitchStatment switchStatment = new SwitchStatment();
            // switchStatment.Run();
            
            // for looping -----------------------------------------------------------------------
            Looping looping = new Looping();
            // looping.Run();
            
            // for functions -----------------------------------------------------------------------
            Function function = new Function();
            // function.Run();
            
            // for arrays -----------------------------------------------------------------------
            Arrays.Array array = new Arrays.Array(); 
            // this is the same as `using Program.Arrays;
            // because we are in the same namespace and Arrays is a built-in data type
            // array.Run();
            
            // for exception handling -----------------------------------------------------------------------
            ExceptionHandling.ExceptionHandling exceptionHandling = new ExceptionHandling.ExceptionHandling();
            // exceptionHandling.Run();
            
            // for delegates -----------------------------------------------------------------------
            Delegates.DelegatesExamples delegatesExamples = new Delegates.DelegatesExamples();
            // delegatesExamples.Run();
            
            // for Lists -----------------------------------------------------------------------
            // ListExample.Run();
            
            // for ArrayLists -----------------------------------------------------------------------
            // ArrayListExamples.Run();
            
            // for Date and Time -----------------------------------------------------------------------
            DateAndTime.Run();
        }
    }
}

