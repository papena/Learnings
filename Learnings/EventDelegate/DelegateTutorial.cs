using System;

namespace EventDelegate
{
    public class DelegateTutorial
    {
        public delegate string ReturnsString(string text1, string text2);
    }
    public class ExecutionClass
    {
        public void PopulateString()
        {
            // DelegateTutorial.ReturnsString dele = new DelegateTutorial.ReturnsString(PrintLocal);
            // //dele("This is from one message1", "This is from one message2");
            // dele += new DelegateTutorial.ReturnsString(PrintLocal1);
            //// dele("This is from 2 message1", "This is from 2 message2");
            ///

            EventClass eve = new EventClass();
            eve.ActionCompletedEvent += Eve_ActionCompletedEvent; 
            eve.ExecuteAction();
        }

        private string Eve_ActionCompletedEvent(string text1, string text2)
        {
            throw new NotImplementedException();
        }

        public string PrintLocal(string message1, string message2)
        {
            Console.WriteLine(String.Concat(message1, message2));
            return String.Concat(message1, message2);
        }
        public string PrintLocal1(string message1, string message2)
        {
            Console.WriteLine(String.Concat("Method1", message1, message2));
            return String.Concat(message1, message2);
        }
    }
    public class EventClass
    {
        public event DelegateTutorial.ReturnsString ActionCompletedEvent;
        public void ExecuteAction()
        {
            ActionCompletedEvent("Executed", "Event");
        }
    }
}
