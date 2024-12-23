using System.ComponentModel;
using System.Net;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace ass05
{
    class Program
    {
        // Method that passes by value
        static void ModifyValue(int num)
        {
            num = 20; 
        }
        // Method that passes by reference
        static void ModifyReference(ref int num)
        {
            num = 20;
        }
        static void Main(string[] args)
        {
            #region  pro1
            //1 - Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example.
            //            Passing by Value
            //When a parameter is passed by value, a copy of the value is passed to the method.
            //Changes made to the parameter inside the method do not affect the original variable.
            //This is the default behavior in C#.

            //            Passing by Reference
            //When a parameter is passed by reference, the memory address of the original variable is passed to the method.
            //Changes made to the parameter inside the method do affect the original variable.
            //You need to explicitly use the ref or out keywords to pass by reference.

            int valueType = 10;
            ModifyValue(valueType);
            Console.WriteLine("After passing by value: " + valueType); // Output: 10

            // Passing by Reference
            int refType = 10;
            ModifyReference(ref refType);
            Console.WriteLine("After passing by reference: " + refType); // Output: 20

            #endregion

        }
    }