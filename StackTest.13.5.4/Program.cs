using System;
using System.Collections.Generic;

namespace StackTest
{
    class Program
    {
        public static Stack<string> words = new Stack<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
            Console.WriteLine();

            while (true)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    //   если  команда pop - пробуем достать элемент
                    case "pop":
                        words.TryPop(out string popResult);
                        break;
                    //   если  команда peek - пробуем  просмотреть элемент
                    case "peek":
                        words.TryPeek(out string peekResult); 
                        break;
                    default:
                        // если ни одна из команд не распознана - простов стек добавляем то что введено
                        words.Push(input); 
                        break;
                }
               


                Console.WriteLine();
                Console.WriteLine("В стеке:");

                foreach (var word in words)
                {
                    Console.WriteLine(" " + word);
                }
            }
        }
    }
}
