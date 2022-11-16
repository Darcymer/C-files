// In this tutorial, we will be teaching you everything you need to know about loops In C#.

using System; 

namespace loops
{
    class loops
    {
        static void Main(string[] args)
        {
            /* This shows an example of a while loop, a loop that runs while a certain parameter is still true. In the case below 
            interger a is 15, while  a is less than or equal to 15, do the code in the {}*/
            int a = 15;
            while (a <= 50)
            {
                Console.WriteLine("Your number(#) is ", a);
            }

            /* This shows an example of a do loop, a loop that runs whenever it is called. In the case below 
            interger b is 1, do the code in the {} and add 1 to b to the code*/


            int b = 1;
            do
            {
                Console.WriteLine("Your number(#) is ", b);
                b ++;
            }

            /* Now this code is interesting. This shows an example of a while for loop, a loop that runs while a certain parameter while
            it is still running and for each parameter in () do the things in the {}. In the case below, while the interger y is 
            less than or equal to 50, for  interget x which is 1, less than 20, and added up until otherwise, do the code in the {}*/
            while (y <= 50);

              
             for (int x = 1; x < 20; x++)
            {
                Console.WriteLine("The number is {0}", i);
            }
            // As you probably guess form above, we can do loops inside of loops



            /* Below we have a interger which holds a list of numbers from 1 to 20. The foreach loop allows us to look at each instance we made, 
            and utilize our code to do something with it.*/
            int[] list1to20 = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};

            foreach (var value in list1to20)
            {
                Console.WriteLine("The number is", value);
            }
        }
    }
}