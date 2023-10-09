namespace пианино
{
    internal class Program
    {
        static int[] fiveoctave = new int[12] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
        static int[] sixoctave = new int[12] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
        static int[] nyloktave = new int[12];
        static void Main(string[] args)
        {
            Console.WriteLine("F1 и F2 - переключение между октавами.");
            Console.WriteLine("С D по L - белые клавиши, а с R по I - чёрные.");
            Console.WriteLine("Пятая октава.");
            nyloktave = fiveoctave;
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.F1 || key.Key == ConsoleKey.F2)
                {
                    Oktavi(key);
                }
                Zvuk(key);
            }
            while (true);
        }
        static int[] Oktavi(System.ConsoleKeyInfo key)
        {
            string okt = key.Key == ConsoleKey.F1 ? "Пятая октава" : "Шестаая октава";
            Console.WriteLine(okt);
            nyloktave = key.Key == ConsoleKey.F1 ? fiveoctave : sixoctave;
            return nyloktave;
        }
        static void Zvuk(System.ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.D:
                    Console.Beep(nyloktave[0], 500);
                    break;
                case ConsoleKey.F:
                    Console.Beep(nyloktave[2], 500);
                    break;
                case ConsoleKey.G:
                    Console.Beep(nyloktave[4], 500);
                    break;
                case ConsoleKey.H:
                    Console.Beep(nyloktave[5], 500);
                    break;
                case ConsoleKey.J:
                    Console.Beep(nyloktave[7], 500);
                    break;
                case ConsoleKey.K:
                    Console.Beep(nyloktave[9], 500);
                    break;
                case ConsoleKey.L:
                    Console.Beep(nyloktave[11], 500);
                    break;
                case ConsoleKey.R:
                    Console.Beep(nyloktave[1], 500);
                    break;
                case ConsoleKey.T:
                    Console.Beep(nyloktave[3], 500);
                    break;
                case ConsoleKey.Y:
                    Console.Beep(nyloktave[6], 500);
                    break;
                case ConsoleKey.U:
                    Console.Beep(nyloktave[8], 500);
                    break;
                case ConsoleKey.I:
                    Console.Beep(nyloktave[10], 500);
                    break;
            }
        }
    }
}