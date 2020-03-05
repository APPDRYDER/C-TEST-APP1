using System;
using System.Threading;

// Maintainer: David Ryder
// Example C# .NET Console Application and AppDynamics BT Detection Rules

namespace CTESTAPP1
{
    // Define the interface Adds
    interface Adds
    {
        int add1(int total, int i);
        int add2(int total, int i);
        int add3(int total, int i);
    }

    // Generic Class
    class Response1<T>
    {
        public void Success<U>(U v)
        {
            Console.WriteLine($"Response1.Success {v}");

        }
    }

    // Generic Class with return value
    class Response2<T>
    {
        public U Success<U>(U v)
        {
            Console.WriteLine($"Response2.Success {v}");
            return v;
        }
    }

    class Test1
    {
         public void test(int v)
         {
            Console.WriteLine($"Test1.test {v}");
         }
    } 

    class MainClass
    {

        // Generic Class - Repeating Class in MainClass
        class Response3<T>
        {
            public void Success<U>(U v)
            {
                Console.WriteLine($"Response11.Success {v}");

            }
        }

        class Test1
        {
            public void test(int v)
            {
                Console.WriteLine($"Test1.test {v}");
            }
        }

        // Implement the class CTESTAPP1.MainClass.theAdds1 using interface defined by Adds
        class theAdds1 : Adds
        {
            public int add1(int total, int i)
            {
                return total + i;
            }

            public int add2(int total, int i)
            {
                return total + i;
            }

            public int add3(int total, int i)
            {
                return total + i;
            }
        }

        // Implement the class CTESTAPP1.MainClass.theAdds2 using interface defined by Adds
        class theAdds2 : Adds
        {
            public int add1(int total, int i)
            {
                return total + i;
            }

            public int add2(int total, int i)
            {
                return total + i;
            }

            public int add3(int total, int i)
            {
                return total + i;
            }
        }

        // Class CTESTAPP1.MainClass
        public int sum1(int total, int i)
        {
            return total + i;
        }

        public int sum2(int total, int i)
        {
            return total + i;
        }

        public int sum3(int total, int i)
        {
            return total + i;
        }

        // Class CTESTAPP1.MainClass -> testLoop1
        public int testLoop1()
        {
            theAdds1 ta1 = new theAdds1();
            theAdds2 ta2 = new theAdds2();

            Response1<int> r11 = new CTESTAPP1.Response1<int>();
            Response1<string> r12 = new CTESTAPP1.Response1<string>();

            Response2<int> r21 = new CTESTAPP1.Response2<int>();
            Response2<string> r22 = new CTESTAPP1.Response2<string>();

            int total = 0;
            int count = 10000;
            for (int i=0;i<count;i++)
            {
                total = sum1(total, i);
                int t1 = sum2(total, i);
                int t2 = sum3(total, i);

                int t3 = ta1.add1(total, i);
                int t4 = ta1.add2(total, i);
                int t5 = ta1.add3(total, i);

                int t6 = ta2.add1(total, i);
                int t7 = ta2.add2(total, i);
                int t8 = ta2.add3(total, i);

                r11.Success<int>(i);
                r12.Success<string>(i.ToString());

                int v1 = r21.Success<int>(i);
                string v2 = r22.Success<string>(i.ToString());

                int t = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8;
                Console.WriteLine($"Total: {i} {total} {t}");
                Thread.Sleep(2000);
            }
            return total;
        }

        public static void Main(string[] args)
        {
            MainClass mc1 = new MainClass();
            Console.WriteLine("Starting");
            int total = mc1.testLoop1();
            Console.WriteLine($"End Total:  {total}");
            Console.WriteLine("Complete");
        }
    }
}
