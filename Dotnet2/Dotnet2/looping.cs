//using System;


//namespace Dotnet2
//{
//    class looping
//    {
//        static void Main(string[] args)
//        {
//            int j,n;
//            Console.WriteLine("multiplication table");
//            Console.WriteLine();
//            n = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("\n");
//            for(j=1;j<=10;j++)
//            {
//                Console.WriteLine(" {0} * {1} ={2} \n", n, j, n * j);
//            }
//            Console.ReadLine();
//        }
//    }
//}


//using System;


//namespace Dotnet2
//{
//    class looping
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 100; i >= 1; i--)
//            {
//                Console.WriteLine(i);
//            }
//            Console.ReadLine();
//        }
//    }

//}


using System;

namespace Dotnet2
{
    class looping
    {
        static void Main(string[] args)
        {
            string a;
            do
            {
                Console.WriteLine("enter rollno");
                int rollno = int.Parse(Console.ReadLine());
                Console.WriteLine("enter name");
                String name = Console.ReadLine();
                Console.WriteLine("Do yo want to continue?");
                a = Console.ReadLine();
            }
            while (a == "yes" || a == "YES" || a == "y" || a == "Y");
                Console.ReadLine();
        }
    }
}



