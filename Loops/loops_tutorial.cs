// In this tutorial, we will be teaching you everything you need to know about loops In C#.

using System; 

namespace loops
{
    class loops
    {
        static void Main(string[] args)
        {

            int a = 1;
            while (x <= 50)
            {
                Console.WriteLine("The number is {0}", x);
                x += 1;
            }

            int b = 1;
            do
            {
                Console.WriteLine("The number is {0}", y);
                y ++;
            }
            while (y <= 50);

              
             for (int i = 1; i < 20; i++)
            {
                Console.WriteLine("The number is {0}", i);
            }

            int[] list1to20 = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};

            foreach (var value in list1to20)
            {
                Console.WriteLine("The number is {0}", value);
            }
        }
    }
}