using System.IO;

namespace Cas
{
    class program
    {
        static int Balance = 10;
        static void Main(string[] args)
        {
            Asc();
        }
        static void Asc()
        {
            string WantPlay;
            Console.WriteLine("Во что хотите сыграть?");
            Console.WriteLine("1 - каз");
            Console.WriteLine("2 - каз");
            Console.WriteLine("Ваш баланс: " + Convert.ToInt32(Balance));
            WantPlay = Console.ReadLine();
            if (WantPlay == "1")
            {
                Game1();
            }
            else if (WantPlay == "2")
            {
                Game21();
            }
            else
            {
                Console.WriteLine("Good Bye");
            }
        }
        static void Game1()
        {
            int CurMon; //Текущая ставка
            int WinNum;
            int UserNum; 
            Console.WriteLine("Введите вашу ставку");
            CurMon = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your num is...");
            Random rnd = new Random();
            WinNum = rnd.Next(10);
            UserNum = Convert.ToInt32(Console.ReadLine());
            if (UserNum == WinNum)
            {
                Console.WriteLine("You Win!!!");
                Balance += CurMon;
                Asc();
            }
            else
            {
                Console.WriteLine("You Luse");
                Console.WriteLine("Win Num is:" + WinNum);
                Balance -= CurMon;
                Asc();
            }

        }
        static void Game21()
        {
            int CardScore;
            int CurScore;
            int CurCard;
            int[] cards = new int[36] {6, 7, 8, 9, 10, 8, 9, 10, 11, 6, 7, 8, 9, 10, 8, 9, 10, 11, 6, 7, 8, 9, 10, 8, 9, 10, 11, 6, 7, 8, 9, 10, 8, 9, 10, 11, };
            String Answer21;
            int BotScore;
            CurScore = 0;
            Random rndBot21 = new Random();
            BotScore = rndBot21.Next(14,21);
            Random rndCard21 = new Random();
            CardScore = rndCard21.Next(36);
            CurCard = cards[CardScore];
            Console.WriteLine("Взять еще kарту?");
            Answer21 = Console.ReadLine();
            if (Answer21 == "+")
            {
                CurScore = CurCard + CurScore;
                Console.WriteLine(CurScore);
                Game21();
            }


        }
    }
}
