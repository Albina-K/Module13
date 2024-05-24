using System.Collections;
using System.Collections.Immutable;
using System.Text;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;// подключаем пространство имён с обобщёнными коллекциями

namespace Module13
{
    class Program
    {
        static void Main(string[] args)
        {
            //создание телефонной книги
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("aaa", 21574568, "aaa@mail.ru"));
            phoneBook.Add(new Contact("bbb", 12545747, "bbb@mail.ru"));

            // проверяем, что добавилось в список
            foreach(var contact in phoneBook)
                Console.WriteLine(contact.Name + ": " + contact.PhoneNumbers);



            //Напишите метод для нашей телефонной книги,
            //который получает на вход список и новый контакт,
            //и добавляет его, только если он уникален.
            private static void AddUnique(Contact newContact, List<Contact> phoneBook) 
            {
                bool alreadyExists = false;

                // пробегаемся по списку и смотрим, есть ли уже с таким именем
                foreach (var contact2 in phoneBook) 
                {
                    //  если вдруг находим  -  выставляем флаг и прерываем цикл
                    if (contact2.Name == newContact.Name)
                    {
                        alreadyExists = true;
                        break;
                    }
                }

                if (!alreadyExists)
                    phoneBook.Add(newContact);

                //  сортируем список по имени
                phoneBook.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));

                foreach (var contact3 in phoneBook)
                    Console.WriteLine(contact3.Name + ": " + contact3.PhoneNumbers);
            }

           // Напишите метод, который примет на вход обе коллекции,
           // вырежет из второй недостающие месяцы и добавит в наш список.
           // Затем выведет результат в консоль.
           var months = new List<string>()
           {
               "Jan", "Feb", "Mar", "Apr", "May"
           };

            var missing = new ArrayList()
            {
                1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };


            private static void GetMissing(List<string> months, ArrayList missing)
            {
                // инициализируем массив для 7 нужных нам недостающих элементов
                var missedArray = new string[7];

                // извлекаем эти элементы из ArrayList, и копируем в массив
                missing.GetRange(4, 7).CopyTo(missedArray);

                // Добавляем наш массив в конец списка
                months.AddRange(missedArray);

                // смотрим, что получилось
                foreach (var month in months)
                    Console.WriteLine(month);
            }

            //использование HashSet<T>
            // Создаем массив строк
            string[] names =
            {
                "aaa", //  повторяющееся значение
                "bbb",
                "ccc",
                "ddd",
                "eee",
                "fff",
                "aaa" //  повторяющееся значение
            };

            // Выведем длину массива в консоль
            Console.WriteLine("Длина массива " + names.Length);
            Console.WriteLine();
            Console.WriteLine("Данные в массиве");
            foreach (var name in names) 
                Console.WriteLine(name);
            Console.WriteLine();

            // Создаем хэш-сет, передавая в конструктор наш массив
            HashSet<string> set = new HashSet<string>(names);
            // Посчитаем объекты в массиве
            Console.WriteLine("Длина хэш-сета " + set.Count);
            Console.WriteLine();
            // Выведем все элементы в консоль и посмотрим, есть ли дубликаты
            Console.WriteLine("Элементы в хэшсете:");
            foreach (var name in set)
                Console.WriteLine(name);


            //UnionWith()
            //Используется для объединения сета с другой коллекцией.
            set.UnionWith(new[] { "jjj", "kkk", "aaa" });
            Console.WriteLine("Элементы после объединения с новой коллекцией:");
            foreach(var name in set)
                Console.WriteLine(name);

            //ExceptWith(otherCollection)
            //Удаляет из хэш - сета все элементы, содержащиеся в другой коллекции.
            // Создадим два множества
            SortedSet<char>lettersOne = new SortedSet<char>();
            SortedSet<char> lettersTwo = new SortedSet<char>();

            //  Добавим элементы в первую
            lettersOne.Add('a');
            lettersOne.Add('b');
            lettersOne.Add('c');
            lettersOne.Add('d');

            // выведем
            PrintCollection(letterOne, "Первая коллекция:");

            // Добавим элементы во вторую
            lettersTwo.Add('e');
            lettersTwo.Add('f');
            lettersTwo.Add('d');

            // выведем
            PrintCollection(lettersTwo, "Вторая коллекция");

            //  Выполним вычитание множеств
            lettersOne.ExceptWith(lettersTwo);

            // Выведем результат
            PrintCollection(lettersOne, "Результат вычитания");


            static void PrintCollection(SortedSet<char> set, string name)
            {
                Console.WriteLine(name);
                foreach(char ch in set) Console.WriteLine(ch + " ");
                Console.WriteLine("\n");
            }


            //SymmetricExceptWith(otherCollection)
            //Специфичный метод. Изменяет HashSet<T> таким образом,
            //чтобы он содержал только те элементы,
            //которые есть в нём самом или otherCollection,
            //исключая дубликаты на уровне обеих коллекций.

            var hSet = new HashSet<string>()
            {
                "aaa", "ddd"
            };

            hSet.SymmetricExceptWith(new[] { "aaa", "bbb", "ccc" });
            Console.WriteLine("Элементы после объединения с новой коллекцией:");

            foreach (var n in hSet)
                Console.WriteLine(n);


            // Dictionary<TKey, TValue> Словарь
            // Создадим словарь. Ключом будет строка, а значением - массив строк
            var cities = new Dictionary<string, string[]>(3 /* Размер (указывать необязательно))*/);

            // Добавим новые значения
            cities.Add("Россия", new[] { "Москва", "Санкт-Петербург", "Волгоград" });
            cities.Add("Украина", new[] { "Киев", "Львов", "Николаев", "Одесса" });
            cities.Add("Беларусь", new[] { "Минск", "Витебск", "Гродно" });
            //  Посмотрим всё что есть в словаре
            foreach (var citiesByCountry in cities)
            {
                Console.Write(citiesByCountry.Key + ": " );
                foreach (var city in  citiesByCountry.Value) Console.WriteLine(city + ": ");
            }
            Console.WriteLine();

            // Теперь попробуем вывести значения по ключу
            var russianCities = cities["Россия"];
            Console.WriteLine("Города России:");
            foreach (var city in russianCities)
                Console.WriteLine(city);
            // изменение объекта
            cities["Россия"] = new[] { "Мурманск", "Казань" };

            // удаление по ключу
            cities.Remove("Беларусь");

            //SortedDictionary <TKey, TValue>
            // Создаем сортированный словарь
            SortedDictionary<string, int> sortedDictionary = new SortedDictionary<string, int>();
            // Добавим несколько элементов в случайном порядке
            sortedDictionary.Add("zebra", 5);
            sortedDictionary.Add("cat", 2);
            sortedDictionary.Add("dog", 9);
            sortedDictionary.Add("mouse", 4);
            sortedDictionary.Add("programmer", 100);
            // Ищем собаку
            if (sortedDictionary.ContainsKey("dog"))
                Console.WriteLine("Нашли собаку");
            // Ищем зебру
            if (sortedDictionary.ContainsKey("zebra"))
                Console.WriteLine("Нашли зебру");
            // Ищем обезьяну
            if (sortedDictionary.ContainsKey("ape"))
                Console.WriteLine("Нашли обезьяну");

            Console.WriteLine();

            // Теперь посмотрим, кто у нас живёт и в каком порядке
            Console.WriteLine("Посмотрим всех:");

            foreach (KeyValuePair<string, int> p in sortedDictionary)
                Console.WriteLine($"{p.Key} = {p.Value}");












            var strings = new List<string>();//  в квадратных скобках укажем тип данных



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


        public class Contact // модель класса
        {
            public String Name {  get; set; }
            public long PhoneNumbers {  get; set; }
            public String Email { get; set; }

            public Contact(string name, long phoneNamber, String email) // метод-конструктор
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
    
