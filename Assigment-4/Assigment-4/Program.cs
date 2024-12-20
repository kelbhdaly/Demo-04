using System.ComponentModel;

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
        }
    }
}
