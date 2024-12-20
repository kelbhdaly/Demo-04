using System.ComponentModel;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assigment_4
{

    internal class Program
    {

        //value
        //static void Temp(int Num01 ,int  Num02)
        // {
        //     int temp = Num01;
        //     Num01 = Num02;
        //     Num02 = temp;

        // }

        //Reference

        //static void Temp( ref int Num01 ,ref int  Num02)
        // {
        //     int temp = Num01;
        //Num01 = Num02;
        //     Num02 = temp;

        // }


        //------------------------------------------------------------------

        //reference

        //value
        //static int Sum(int[] arr)
        //{
        //    ;
        //    int sum = 0;
        //         arr[0] = 100;
        //          for (int i = 0; i < arr.Length; i++)
        //          {
        //                sum += arr[i];
        //          }
        //         return sum;
        //}


        //ref
        //static int Sum( ref int[] arr)
        //{
        //    ;
        //    int sum = 0;

        //    arr[0] = 100;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}



        //-----------------------------------------------------

        //static void SumAndSub4Numbers(int Num01 , int Num02, int Num03 , int Num04 ,  out int Sum , out int Sub)
        // {

        //     Sum = Num01 + Num02 ;
        //     Sub = Num03 - Num04;
        // }


        //-------------------------------------------------------------------------------------
        //static int IndividualDigits(int Number)
        //{
        //    int sum = 0;
        //    while (Number != 0)
        //    {
        //        sum += Number % 10;
        //        Number /= 10;

        //    }
        //    return sum;
        //}


        //--------------------------------------------------------------------------


        //static bool IsPrime(int Number)
        //{
        //    if (Number < 2)
        //    {
        //        return false;
        //    }

        //    for (int i = 2; i <= Number / 2; i++)
        //    {
        //        if (Number % i == 0)
        //        {
        //            return false;
        //        }
               
        //    }
        //    return true;
        //}
        static void Main(string[] args)
        {
            #region Q01
            //Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example.
            // value => No Action will be Occure stackfram remove 
            //int Number01=5 , Number02=10;
            //Temp(Number01, Number02);
            //Console.WriteLine(Number01);//5
            //Console.WriteLine(Number02);//10
            //Nothing 


            //ref => Action will be occure 
            //int Number01 = 5, Number02 = 10;
            //Temp(ref Number01,ref Number02);
            //Console.WriteLine(Number01);//10
            //Console.WriteLine(Number02);//5
            #endregion


            #region Q02
            //Explain the difference between passing(Reference type parameters) by value and by reference then write a suitable c# example.

            //reference in two status will be change 
            // different in memory
            //value
            //int[] Numbers = { 3, 5, 3,10, 7 };
            //Console.WriteLine(Sum(Numbers)); // 100+......
            //Console.WriteLine(Numbers[0]); //100


            //ref

            //int[] Numbers = { 3, 5, 3, 10, 7 };
            //Console.WriteLine(Sum(ref Numbers)); // 100+......
            //Console.WriteLine(Numbers[0]);


            ////summary
            //By Value: A copy is made; changes do not affect the original.
            // By Reference: A reference to the original is passed; changes affect the original.

            #endregion


            #region Q03
            // Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //Console.WriteLine("Enter The Number01");
            //int Number01 =int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter The Number02");
            //int Number02 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter The Number03");
            //int Number03 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter The Number04");
            //int Number04 = int.Parse(Console.ReadLine());
            //int Sum, Sub;



            //SumAndSub4Numbers(Number01, Number02, Number03, Number04, out Sum, out Sub);
            //Console.WriteLine($"Sum = {Sum}");
            //Console.WriteLine($"Sub = {Sub}");
            #endregion


            #region Q04

            //Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //    Output should be like
            //    Enter a number: 25
            //    The sum of the digits of the number 25 is: 7

            //Console.WriteLine("Enter The Number : = ");
            //int Number = int.Parse(Console.ReadLine());


            //int Digital = IndividualDigits(Number);
            //Console.WriteLine($"The sum of the digits of the number {Number} is : {Digital}");
            #endregion

            #region Q05
            // Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:


            //Console.WriteLine("Enter The Number : =");
            //int Number = int.Parse(Console.ReadLine());

            //if (IsPrime(Number))
            //{
            //    Console.WriteLine("The Number is Prime");

            //}
            //else
            //{
            //    Console.WriteLine("The Number is Not Prime");

            //}
            #endregion


        }
    }
}
