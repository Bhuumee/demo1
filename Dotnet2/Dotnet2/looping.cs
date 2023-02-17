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


//using System;

//namespace Dotnet2
//{
//    class looping
//    {
//        static void Main(string[] args)
//        {
//            string a;
//            do
//            {
//                Console.WriteLine("enter rollno");
//                int rollno = int.Parse(Console.ReadLine());
//                Console.WriteLine("enter name");
//                String name = Console.ReadLine();
//                Console.WriteLine("Do yo want to continue?");
//                a = Console.ReadLine();
//            }
//            while (a == "yes" || a == "YES" || a == "y" || a == "Y");
//                Console.ReadLine();
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
//            demo1 o1 = new demo1();
//            demo2 o2 = new demo2();
//            demo3 o3 = new demo3();

//            o1.function1();
//            demo1.function4();
//            o2.function2();
//            demo3.function3();

//            Console.ReadLine();
//        }
//    }
//    class demo1
//    {
//        public void function1()
//        {
//            demo3.function3();
//            Console.WriteLine("demo1 is invoked");
//        }
//        public static void function4()
//        {
//            Console.WriteLine("demo1 function4 is invoked");
//        }
//    }
//    class demo2
//    {
//        public void function2()
//        {
//            demo1.function4();
//            Console.WriteLine("demo2 is invoked");
//        }
//    }
//    class demo3
//    {
//        public static void function3()
//        {
//            demo1.function4();
//            Console.WriteLine("demo3 is invoked");
//        }
//    }

// }

using System;

namespace Dotnet2
{
        struct book
        {
           public int bid;
            public string btitle;
            public int bprice;
        }
        class looping
        {
           static void Main(string[] args)
        {
           book b1 = new book();
            b1.bid = 101;
            b1.btitle = "bleh";
            b1.bprice = 100;

            book b2= new book();
            b2.bid = 102;
            b2.btitle="boo";
            b1.bprice = 102;

            Console.WriteLine("book 1 details");
            Console.WriteLine(b1.bid);
            Console.WriteLine(b1.btitle);
            Console.WriteLine(b1.bprice);

            Console.WriteLine("book 2details");
            Console.WriteLine(b2.bid);
            Console.WriteLine(b2.btitle);
            Console.WriteLine(b2.bprice);

            Console.ReadLine();
        }
      
    }
    
  
}



