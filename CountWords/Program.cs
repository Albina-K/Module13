using System.Collections.Generic;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запускаем бесконечный цикл
            while (true)
            {
                Console.WriteLine("Введите текст:");
                // Сохраняем предложение в строку
                var sentence = Console.ReadLine();
                // "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";

                // сохраняем в массив char
                var characters = sentence.ToCharArray();

                var symbols = new HashSet<char>();

                // добавляем во множество. Сохраняются только неповторяющиеся символы
                foreach (var symbol in characters)
                    symbols.Add(symbol);

                // Выводим результат
                Console.WriteLine(symbols.Count);

                // сохраняем знаки препинания в массив Char
                var signs = new[] { ',', ' ', '.' };

                // сохраняем числовые символы в массив Char
                var numbers = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                //  Проверяем, есть ли цифры
                bool containsNumbers = symbols.Overlaps(numbers);
                Console.WriteLine($"Коллекция содержит цифры: {containsNumbers}");

                // Отбрасываем знаки препинания и заново считаем
                symbols.ExceptWith(signs);
                Console.WriteLine($"Символов без знаков препинания:: {symbols.Count}");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}