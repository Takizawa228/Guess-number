using System;

namespace GameNum
{
    class Program
    {
        static bool NewGame()
        {
            Console.WriteLine("Хотите еще сыграть? Y N");

            string choice = Console.ReadLine().ToUpper();
            if (choice == "Y")
                return false;
            else
                return true;
            
        }
        static void DisplayMessage()
        {
            Console.WriteLine("Компьютер загадывает число от 1 до 10");
        }
        static void DisplayMessageWin()
        {
            Console.WriteLine("Вы угадали число!!!");
        }
        static int CheckGuess(int guess, int secretNumber)
        {
            if (guess == secretNumber)
                return 0;
            else if (guess > secretNumber)
                return 1;
            else
                return -1;
        }
        static bool ValidateGuess(int guessNum, int min, int max)
        {
            if (guessNum >= min && guessNum <= max)
                return true;
            else
                return false;
        }
        
        static int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();

            int number = random.Next(min,max);

            return number;
        }
        static int GetPlayerGuess()
        {
            try
            {
                Console.Write("Введите число: ");

                int number = Convert.ToInt32(Console.ReadLine());

                return number;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка ввода. {e.Message}");

                return -1;
            }
            
        }
        static void Main(string[] args)
        {

            DisplayMessage();

            int min = 1, max = 10, points = 0;
            int randomNum =  GenerateRandomNumber(min,max);

            int guessNum = GetPlayerGuess();
            
            bool flag = false;
            while(!flag)
            {
                bool res = ValidateGuess(guessNum, min, max);

                if (res == false)
                {
                    Console.WriteLine("Ваше число за диапазоном!");
                    guessNum = GetPlayerGuess();
                }
                else
                {
                    int result = CheckGuess(guessNum, randomNum);

                    if (result == 0)
                    {
                        DisplayMessageWin();

                        points++;
                        Console.WriteLine($"Количество баллов: {points}");

                        flag = NewGame();
                    }
                    else
                    {
                        points--;

                        Console.WriteLine($"У вас осталось баллов: {points}");
                       
                        guessNum = GetPlayerGuess();
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
