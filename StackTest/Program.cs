using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace StackTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();
            //Push() для добавления элемента в коллекцию
            stack.Push("FirstWorld");
            stack.Push("LastWorld");
            //   в стеке; FirstWord, LastWord

            //Pop() извлекает и возвращает первый(он же последний добавленный) элемент из стека
            // достанем  слово LastWord. FirstWord осталось в стеке
            var element = stack.Pop();

            // Peek() метод для просмотра первого элемента без его удаления
            // просмотрим  слово LastWord.  оба слова остались в стеке
            var element2 = stack.Peek();




            //  создадим числовой стек
            Stack<int> numbers = new Stack<int>();

            numbers.Push(3); // в стеке 3
            numbers.Push(5); // в стеке 5, 3
            numbers.Push(8); // в стеке 8, 5, 3

            Console.WriteLine("Элемент числового стека");
            foreach(var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine($"Извлеаем верхний элемент из стека{numbers.Pop()}");
            // в стеке осталось 5 и 3

            Console.WriteLine();

            //создадим стек объектов
            Stack<Person> persons = new Stack<Person>();
            persons.Push(new Person() { Name = "Ivan" });
            persons.Push(new Person() { Name = "Sergey" });
            persons.Push(new Person() { Name = "Anna" });

            Console.WriteLine("Элементы стека объектов");
            foreach (Person p in persons)
                Console.WriteLine(p.Name);

            Console.WriteLine($"Извлекаем верхний элемент из стека объектов: {persons.Pop().Name}");

        }
    }

    class Person
    {
        public string Name { get; set; }
    }
}
