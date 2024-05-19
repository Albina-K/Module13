using System.Collections;
using System.Collections.Immutable;
using System.Text;
using System.Xml.Linq;

namespace Module13
{
    class Program
    {
        static void Main(string[] args)
        {
            //подсчет слов в тексте

            // читаем весь файл с рабочего стола в строку текста
            string text = File.ReadAllText("ссылка на файл.");

            // Сохраняем символы-разделители в массив
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            // выводим количество
            Console.WriteLine(words.Length);


            //Инициализация ArrayList: 
            var list = new ArrayList() { 2, "Lol"};

            //Выведем объекты на консоль: 
            foreach (object o in list)
                Console.WriteLine(o);

            var months2 = new ArrayList()
             {
                "Jan", "Feb", "Mar", "Apr", "May", "Jul", "Aug", "Sep", "Oct", "Nov", "Des"
            };

            months2.Sort();
            foreach(var month in months2)
            {
                Console.WriteLine(month);
            }



            var months = new[]
            {
                "Jan", "Feb", "Mar", "Apr", "May", "Jul", "Aug", "Sep", "Oct", "Nov", "Des"
            };




            var numbers = new[]
            {
                1,2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,
            };


            var arrayList = new ArrayList();

            arrayList.Add(2);
            arrayList.Add("Lol");
            arrayList.Add(months);
            arrayList.Add(numbers);
            arrayList.Add(new Contact("aaa", 233585458, "bbbb"));

            foreach (var el in arrayList)
                Console.WriteLine(el);



            var arrayList2 = new ArrayList();
            arrayList2.AddRange(months);
            arrayList2.AddRange(numbers);


            var arrayList3 = new ArrayList();

            arrayList3.Clear();
           var cont = arrayList3.Contains(2);
            Console.WriteLine(cont);

            var list2 = new ArrayList()
            {
                "aaaa",
                "bbbb",
                2
            };

            var creatures = list2.GetRange(0, 2);

            foreach (var VARIABLE in creatures)
            {
                Console.WriteLine(VARIABLE);
            }

            creatures.IndexOf("aaa");


            list2.Insert(1, "ccc");

            list2.Remove(2);

            list2.RemoveAt(1);

            list2.RemoveRange(1, 2);

            list2.Reverse();

            list2.SetRange(1, numbers);




            var list4 = new ArrayList() { 2, "lol" };

            list4.Add(2.3);// добавим double
            list4.Add(55);// добавим int
            list4.AddRange(new string[] { "Hello", "world" });// добавим массив
            // выведем, что получилось
            foreach (var oo in list4)
            Console.WriteLine(oo);
            // добавим ещё строку
            list.Add("again");
            // отрежем часть длиной в 3 элемента, начиная с четвертого
            var slice = list.GetRange(4, 3);
            // выведем результат
            foreach (var oo in slice)
                Console.WriteLine(oo);

            // Объявим ArrayList с элементами разных типов
            var arlist = new ArrayList()
            {
                1,
                "aaa",
                300,
                4.5f
            };

            // Получим первый элемент по индексу
            int firstElement = (int)arlist[0];
            Console.WriteLine(firstElement);

            string secondElement = (string)arlist[1];
            Console.WriteLine(secondElement);
            //int secondElement = (int) arlist[1];Ошибка (пытаемся привести строку к числу)

            // используем ключевое слово var, чтобы не приводить к типу
            var firstElementVar = arlist[0];// получим запакованный объект
            var secondElementVar = arlist[1];
            // var fifthElement = arlist[5]; Error: Index out of range(обращение по несуществующему индексу)
           
            // Обновление элементов по индексу
            arlist[0] = "aaa";
            arlist[1] = 100;


            //Сохраните их значения в ArrayList так, чтобы после строкового названия месяца шёл его числовой номер.
            // инициализация ArrayList
            var combinedList = new ArrayList();

            //  пробегаемся по массиву чисел
            foreach (var number in numbers)
            {
                // добавляем в ArrayList строку месяца (начинаем с нулевого по индексу)
                combinedList.Add(months[number - 1]);

                // добавляем его порядковый номер
                combinedList.Add(number);
            }

            foreach (var value in combinedList)
                Console.WriteLine(value);




            //Напишите метод, который на вход принимает любой Arraylist input,
            //а на выходе выдает другой Arraylist с двумя элементами,
            //где первый — число(сумма целочисленных элементов input),
            //а второй — строка(текст, составленный из строковых элементов input).
            // Объявим ArrayList с элементами разных типов
            var arrayList10 = new ArrayList()
            {
                1,
                "aaa",
                2,
                "ddd"
            };
            // переменная для хранения суммы
            int sum = 0;
            // переменная для хранения текста.
            // Можно было бы использовать String, но в случае когда необходимо выполнять много
            // операций с одной строкой - лучше использовать класс StringBuilder
            StringBuilder text10 = new StringBuilder();
            // проходим список и проверяем элементы на соответствие типу
            foreach (var num in arrayList10)
            {
                //   если целое число - увеличиваем счётчик
                if (num is int)
                {
                    sum += (int)num;
                }

                // если строка - добавляем текст из неё
                if (num is string)
                {
                    text10.Append(num);
                }
            }
            // результат
            var result10 = new ArrayList() { sum, text10.ToString()};
            // вывод
             foreach (var re in result10)
                Console.WriteLine(re);
        }


        public class Contact
        {
            public String Name {  get; set; }
            public long PhoneNumbers {  get; set; }
            public String Email { get; set; }

            public Contact(string name, long phoneNamber, String email)
            {
                Name = name;
                PhoneNumbers = phoneNamber;
                Email = email;
            }
        }

        public class Contact10
        {
            public String Name { get; set; }
            public long PhoneNumbers { get; set; }
            public String Email { get; set;}
        }
    }
}
    
