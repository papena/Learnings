using System;

namespace SingletonPatttern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton.MyClass child = new Singleton.MyClass();
           var test= Singleton.GetObject();
           // var tes2t = Singleton.GetObject();
            //childclass test = new childclass();

        }
    }
    //public class childclass: Singleton
    //{
    //    public childclass()
    //    {

    //    }
    //}
}
