using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventDelegate
{
    class ValueReferenceTypes
    {
        public int intMember = 3; // Data members will be part of object instance 
        public bool flag = true; // so they will be stored on the heap
        public void func1(int f, bool b, int[] intAry)//value type parameters will be allocated on the stack
        {
            int[] arr3 = new int[5];
            //foreach (var item in intAry.ToList())
            //{
            //    arr3
            //}
            int index = 5; // Integer local variable will be allocated on the Stack
            string str = "string"; // string local variable will be allocated on the Heap
            int[] ary = { 1, 2, 3 };// Integer array will be allocated on the Heap
            for (int i = 0; i < intAry.Length; i++)
            {
                intAry[i] = intAry[i] + 100;
            }
            f = 123;
            b = true;
        }

        public void execute()
        {
           // Program obj = new Program();
            int[] ary1 = { 1, 2, 3, 4, 5 };
            int intLocal = 5;
            bool boolLocal = false;
            func1(intLocal, boolLocal, ary1);
            // The changes done for the array in the called function will be reflecting
            for (int i = 0; i < ary1.Length; i++)
            {
                Console.WriteLine("ary1 [" + i + "]=" + ary1[i]);
            }
            // The changes done for value types in the called function will not reflect
            Console.WriteLine("intLocal=" + intLocal + ", boolLocal = " + boolLocal);
        }
    }
}
