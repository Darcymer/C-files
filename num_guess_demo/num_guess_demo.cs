// This is a small demo of how loops work and how C# sytax are explained


namespace numguesser
{
    class Guesser
    {
        static void Main(string[] args)
        {
            Random r= new Random();
            int gamenumber = r.Next(0, 1000);
            bool winner = false;

            Console.Write("Welcome to Option 4, the Number Guesser! Pick a number between 0-1000, if you select the right number... you win");
            do
            {
                Console.Write("");
                Console.Write("Pick a number between 0-1000: ");
                string num = Console.ReadLine();
                int n = int.Parse(num);

                if(n > gamenumber)
                {
                    Console.WriteLine("Too High... try again");
                }
                else if (n < gamenumber)
                {
                    Console.WriteLine("Too Low... try again");
                }
                else if (n == gamenumber)
                {
                    Console.WriteLine("You did it! Horray!");
                    winner = true;
                }
            }
            while (winner == false);

        }


    }
}