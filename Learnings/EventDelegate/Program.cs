using System;
namespace EventDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //ExecutionClass obj = new ExecutionClass();
            //obj. PopulateString();
            ValueReferenceTypes valuetype = new ValueReferenceTypes();
            valuetype.execute();
        }

        private static string Eve_ActionCompletedEvent(string text1, string text2)
        {
            Console.WriteLine("Hello World!");
            return string.Empty;
        }
    }
}
