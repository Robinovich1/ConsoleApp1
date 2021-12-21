namespace Cas
{
    class program
    {
        static void Main(string[] args)
        {
            Asc();
        }
        static void Asc()
        {
            string WantPlay;
            Console.WriteLine("You want play???");
            WantPlay = Console.ReadLine();
            if (WantPlay == "Yes")
            {
                Game();
            }
            else
            {
                Console.WriteLine("Good Bye");
            }
        }
        static void Game()
        {
            int WinNum;
            int UserNum;
            Console.WriteLine("Your num is...");
            Random rnd = new Random();
            WinNum =rnd.Next(10);
            UserNum = Convert.ToInt32(Console.ReadLine());
            if (UserNum == WinNum)
            {
                Console.WriteLine("You Win!!!");
                Asc();
            }
            else
            {
                Console.WriteLine("You Luse");
                Console.WriteLine("Win Num is:" + WinNum);
                Asc();
            }

        }
    }
}
