namespace Demo
{

    //Class ->Function
    //Instructor -> Function
    //Interface -> Function
    //enum
    internal class Program
    {


        //static void PrintShap()
        // {
        //     for (int i = 0; i < 10; i++)
        //     {
        //         Console.WriteLine("^-^");
        //     }
        // }

        //static void PrintShap(int count)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine("^-^");
        //    }
        //}
        //static void PrintShap(int count, string Pattern)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine(Pattern);
        //    }
        //}

        //static void PrintShap(int count , string Pattern="*-*")
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine(Pattern);
        //    }
        //}

       static int SumNumbers(int Number01 , int Number02)
        {
            return Number01 + Number02;
        }
        //Entery point
        static void Main(string[] args)
        {
            #region One D Array
            //int[] Numbers; // stack
            //Declare For Reference(Pointer) From type Array Of Integers
            //Numbers : Can Refere To Object From Array of Integers
            // Refere To Null
            //Numbers 8 Bytes stack
            //        0 Bytes Heap


            //Numbers = new int[Size];
            //Numbers = new int[5];
            //new 
            //1- Number Of Required Bytes Of The Object At Heap (20)
            //2- Initialized Allocated With The Defult Value of The Date Type
            //3- Call User-Defined Constructor if Exists
            //4- Assign The Object To References



            //Numbers[0] = 5;
            //Numbers[1] = 10;
            //Numbers[2] = 15;
            //Numbers[3] = 8;
            //Numbers[4] = 7;
            //Numbers[5] = 30; // out Of range
            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[2]);
            //Console.WriteLine(Numbers[3]);
            //Console.WriteLine(Numbers[4]);

            //int[] Numbers02 = { 1, 2, 3, 4, 5, 6, };
            //int[] Numbers03 = new int[5] { 1, 2, 6, 5, 6 };
            //Console.WriteLine("Enter the number in array");
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine($"Enter the number [{i}]");

            //    Numbers[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("===============================");
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);

            //} 
            #endregion

            #region Two D Array
            //int[,] Marks = new int[3, 3];
            //Marks[0, 0] = 1;
            //Marks[0, 1] = 2;
            //Marks[0, 2] = 3;

            //Marks[1, 0] = 1;
            //Marks[1, 1] = 2;
            //Marks[1, 2] = 3;

            //Marks[2, 0] = 1;
            //Marks[2, 1] = 2;
            //Marks[2, 2] = 3;

            //Console.WriteLine(Marks[0,0]);
            //Console.WriteLine(Marks[0, 1]);
            //Console.WriteLine(Marks[0, 2]);

            //Console.WriteLine(Marks[1, 0]);
            //Console.WriteLine(Marks[1, 1]);
            //Console.WriteLine(Marks[1, 2]);

            //Console.WriteLine(Marks[2, 0]);
            //Console.WriteLine(Marks[2, 1]);
            //Console.WriteLine(Marks[2, 2]);

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine($"Enter {i} {j} : ");
            //        Marks[i, j] =int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{Marks[i , j] } ");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            //int[][] Marks = new int[3][];
            //Marks[0] = new int[] { 1, 2, 3 };
            //Marks[1] = new int[] { 2, 6 };
            //Marks[2] = new int[] { 20, 30, 40, 50 };

            #region Two D Juddged
            //int[][] Marks = new int[3][];
            //Marks[0] = new int[3];
            //Marks[1]= new int[1];
            //Marks[2]= new int[5];

            //for (int i = 0; i < Marks.Length; i++) 
            //{
            //    for(int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.Write($"Enter the number {i} {j} : ");
            //        Marks[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < Marks.Length; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.Write($" {Marks[i] [j]} : ");

            //    }
            //    Console.WriteLine(); 


            //}
            #endregion

            // Function : Block of code 

            //Function Prototype
            // 1-  Signature
            // 1-1 Name
            // 1-2 Return Type
            // 1-3 Parameters(Input)
            // 2-  Body (Code)

            //calling For The Functions
            //PrintShap(5 , "khaled"); //Passing By Order
           // PrintShap(Pattern:"ayhaga",count: 5); //Passing By Name
           //var sum =SumNumbers(1, 2);
           // Console.WriteLine(sum);
           // Console.WriteLine(SumNumbers(2,3));
        }
    }
}
