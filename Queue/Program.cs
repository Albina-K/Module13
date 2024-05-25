using System;
using System.Collections.Generic;

namespace StackTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enqueue() — добавляет элемент в конец очереди.
            //Dequeue() — извлекает и возвращает первый элемент очереди.
            //Peek() Так же, как и у стека, есть метод для просмотра крайнего элемента очереди без его удаления

            // создаем очередь
            Queue<int> q = new Queue<int>();

            // добавляем в нее целые числа от 0 до 10
            for (int i = 0; i <= 10; i++)
            {
                q.Enqueue(i);
                Console.WriteLine($"{i} зашёл в очередь");
            }

                // Посмотрим, кто первый в очереди
                Console.WriteLine($"Первый элемент:   {q.Peek()}");

                // Обратите внимание, после  вызова Peek() элемент остается в очереди

                //  Посмотрим всю очередь
                Console.WriteLine("Элементы в очереди");
                foreach (int i in q)
                    Console.Write(i + " ");

                Console.WriteLine();
                Console.WriteLine($"В очереди  {q.Count} элементов");
                // обработаем очередь -
                // достанем из неё элементы один за другим
                var queueLength = q.Count;
                for (int i = 0; i < queueLength ; i++)
                    Console.WriteLine($"{q.Dequeue()} вышел из очереди");
                //  Посмотрим, сколько элементов осталось
                Console.WriteLine($"В очереди  {q.Count} элементов");
            
        }
    }
}
