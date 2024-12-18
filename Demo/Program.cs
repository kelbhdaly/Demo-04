namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers; // stack
            //Declare For Reference(Pointer) From type Array Of Integers
            //Numbers : Can Refere To Object From Array of Integers
            // Refere To Null
            //Numbers 8 Bytes stack
            //        0 Bytes Heap


            //Numbers = new int[Size];
            Numbers = new int[5];
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
            Console.WriteLine("Enter the number in array");
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine($"Enter the number [{i}]");

                Numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("===============================");
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }
        }
    }
}
