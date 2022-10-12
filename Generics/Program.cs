using System;

namespace Generics
    //generics = "not specific to a particular data type"
    // add <T> to: classes, methods, fields, etc...
    //allow for code reusability for differenet data types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3 };
            string[] stringArray = { "Dulanjana", "Dinesha", "Dissanayaka" };
            double[] doubleArray = { 1.5, 2.7, 3.1 };

            displayElements(intArray);
            displayElements(stringArray);
            displayElements(doubleArray);

            Console.ReadKey();
        }


        //Generic method to display all data type arrays
        public static void displayElements<T>(T[] array)
        {
            foreach (T element in array)
            {
                Console.Write(element + " ");
            }
        }

        //method to display int data type array
        //public static void displayElements (int[] array)
        //{
        //    foreach (int element in array)
        //    {
        //        Console.Write(element + " ");
        //    }
        //}

        //method to display string data type array
        //public static void displayElements(string[] array)
        //{
        //    foreach (string element in array)
        //    {
        //        Console.Write(element + " ");
        //    }
        //}

        //method to display double data type array
        //public static void displayElements(double[] array)
        //{
        //    foreach (double element in array)
        //    {
        //        Console.Write(element + " ");
        //    }
        //}







    }
}
