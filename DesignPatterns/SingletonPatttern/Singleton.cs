using System;

namespace SingletonPatttern
{
    public sealed class Singleton
    {
        private static Singleton _singletonObject;
        private static object _lockobject = new object();
        private static readonly Lazy<Singleton> lazy =
       new Lazy<Singleton>(() => new Singleton());
        private Singleton()
        {
            Console.WriteLine("In Constructor");
        }
        public static Singleton GetObject()
        {
            //if (_singletonObject == null)
            //{
            //    lock (_lockobject)
            //    {
            //        if (_singletonObject == null)
            //        {
            //            _singletonObject = new Singleton();
            //        }
            //    }
            //}
            return lazy.Value;
        }
    }
   
}
