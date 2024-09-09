﻿namespace MainProgram
{// другие пространства имен
 // классы
 // структуры
 // перечисления
 // делегаты

    namespace Second
    {
        // и тд
    }
    public class Program
    {
        // переменная доступна во всех методах, поскольку
        // разделяет с ними общее тело класса Program
        static int sometest = 10;
        public static void Test2()
        {
            sometest = 10;
        }
        public static void Main(string[] args)
        {
            sometest = 10;
            // точка начала исполнения приложения
            // переменная - ячейка для хранения данных
            // в одной области видимости не может быть
            // двух переменных с одним именем
            // у каждой переменной есть некоторый тип данных
            // тип данных - диапазон значений, которые 
            // может хранить переменная. тип данных задает 
            // требование к объему памяти, который будет
            // занимать переменная

            // типы данных можно разделить на 
            // ссылочные и значимые

            // ссылочные типы:
            // классы, object, массивы, строки, делегаты, 
            // события (event), 

            // значимые типы:
            // целые числа, дробные числа, символы, логический тип,
            // перечисления, структуры, 

            // класс - class
            // объект - object
            // массивы - тип[размерность]
            // строки - string
            // делегаты - delegate
            // события - event


            // целые числа
            // sbyte (1 -2^7 - (2^7-1)) short (2) int (4) long (8) - числа со знаком
            // byte (1) (0 - 2^8-1) ushort (2) uint (4) ulong (8)
            // дробные числа - числа с плавающей точкой, всегда со знаком
            // хранения дроби представляет собой 3 части - целая часть, знак, степень
            // всегда существует погрешность при хранении и доп вычисления 
            // при чтении/записи
            // float (4) double (8) decimal (16)
            // char 's' - 2 байта - UTF8 
            // bool - True False 
            // enum struct
            // иллюстрация округления с double
            Console.WriteLine(0.1 + 0.2);
            // таких ошибок округления меньше с decimal
            decimal d1 = 0.1M;
            decimal d2 = 0.2M;
            Console.WriteLine(d1 + d2);

            // операция присвоения = 
            // операция создания переменной
            // тип имя; Имя не может начинаться с цифры, не включает 
            // в себя пробелы и иные знаки кроме букв и знака _
            // имя переменных обычно с маленькой буквы или знака подчеркивания
            char c; // объявление переменной
            c = 'A'; // инициализация переменной
            char d = c; // копирование, поскольку тип значимый

            byte b = 10;
            int i = b; // неявное преобразование byte в int
            //b = i; b = 1 байт, i = 4 байта
            b = (byte)i; // явное преобразование типов, 3 байта будет отброшено

            float f = i;
            i = (int)f; // мы теряем остаток

            long l = i;

            string s = l.ToString(); // преобразование выглядит иначе
            i = int.Parse(s); // небезопасное преобразование
            bool result = int.TryParse(s, out i); // безопасное преобразование
            i = Convert.ToInt32(s); // аналог Parse
            i = BitConverter.ToInt32(new byte[] { 1, 2, 3, 4 });

            i = 1000;
            Console.WriteLine(i.ToString("x2")); // 16-ричный вывод
            byte[] bytes = BitConverter.GetBytes(i);
            /*foreach (var b1 in bytes)
            {
                Console.WriteLine(b1);
            }*/
            int charInt = 'g'; // мы получим индекс UTF8 для символа g
            // если один из аргументов при сложении является строкой
            // все остальные аргументы преобразуются в строку
            string s1 = 'п'.ToString() + 'р' + 'и' + 'в' + 'е' + 'т';
            Console.WriteLine(charInt);
            string ы = "ыыыыы"; // русский язык может использоваться 
            // в наименованиях, но к сожалению это неудобно
            Console.WriteLine(ы);
            // перечисления можно явно преобразовывать в целые числа
            // и обратно 

            // ссылочные типы объявляются также
            // но инициализация другая
            // пример инициализации класса
            // ключевое слово new указывает на создание
            // нового экземпляра класса Program
            // скобочки после Program указывают на вызов
            // конструктора. Пустые скобочки ставятся 
            // всегда, когда нет аргументов при создании 
            // объекта (или вызове метода)
            Program program = new Program();
            Program Program2 = program; // копирование ссылки

            // разница между ссылочными и значимыми типами:
            A a = new A { Value = 10 };
            A a2 = a; // копирование ссылки
            a2.Value = 100;
            Console.WriteLine(a.Value);
            Console.WriteLine(a2.Value);

            // структура значимый тип данных
            B b1 = new B { Value = 10 };
            B b2 = b1; // копирование значения
            b2.Value = 100;
            Console.WriteLine(b1.Value);
            Console.WriteLine(b2.Value);

            { // скобки обозначают рамки, в которых
              // задается область видимости и жизни переменных
                int i1 = 0; // переменная уничтожится в конце блока
            }
            // i1 = 10; // в данном контексте переменная i1 не существует

            //Main(args);
            // ; ставится в конце каждой строки кроме случаев,
            // когда строка предполагает тело, которое будет описано
            // дальше. Единственный вариант, когда ставится ; после
            // тела - это цикл do while

            // простые операции над типами данных
            // математические операции:
            int x1 = 10 + 20;
            int x2 = 10 - 20;
            int x3 = 10 * 20;
            int x4 = 10 / 20; // получение целого от деления целых чисел

            int x5 = 10 % 20; // остаток от деления
            int x6 = (int)(10f / 20); // получение целого от деления дробных чисел

            x1 = x1 + 10;
            x1 += 10; // сокращенная версия x1 = x1 + 10;
            x1 -= 10;
            x1 *= 10;
            x1 /= 10;
            x1 %= 10;

            x1 = x1 + 1;
            x1++; // инкремент (приращение единицы)
            x1--; // денкремент (приращение единицы)
            // приоритет у префиксных операций выше, чем у постфиксных
            ++x1;
            --x1;

            x1 = 1;
            x2 = (x1)++ * (++x1);
            // 1 * (++2);
            // 1 * 3;

            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);

            // логические операции
            bool bool0 = false;
            bool bool1 = true;

            bool bool2 = !bool0; // отрицание (инвертирование значения)
            bool bool3 = bool0 & bool1; // логическое И (true если bool0 = true и bool1 = true)
            bool bool4 = bool0 | bool1; // логическое ИЛИ (true если bool0 = true И/ИЛИ bool1 = true)
            bool bool5 = bool0 ^ bool2; // логическое исключающее ИЛИ (xor) // (true если bool0 = true либо bool1 = true)

            // разница между && и & для логических типов имеется в вычислении
            // если левый операнд вычисляется как false, правый операнд не вычисляется
            // в случае использования &&
            // в случае || операция может выдать true, если левый операнд уже равен true

            // операции сравнения (тоже логические)
            bool0 = x1 > x2;
            bool0 = x1 >= x2;
            bool0 = x1 < x2;
            bool0 = x1 <= x2;
            bool0 = x1 == x2; // строгое равенство
            bool0 = x1 != x2; // строгое неравенство
            

            // побитовые операции

            x1 = 5;
            x1 = x1 >> 2; // побитовый сдвиг вправо
            Console.WriteLine(x1);
            x1 = x1 << 2; // побитовый сдвиг влево
            Console.WriteLine(x1);
            x1 = x1 << 2; // побитовый сдвиг влево
            Console.WriteLine(x1);

            x1 >>= 2; // сокращенная запись x1 = x1 >> 2;

            x1 = 1;
            x2 = 2;
            x3 = x1 & x2;         // побитовое И
            //x1 = 0x 0000 0001
            //x2 = 0x 0000 0010
            //x3 = 0x 0000 0000   // рез 0
            Console.WriteLine("& = " + x3);
            x3 = x1 | x2;         // побитовое ИЛИ
            //x1 = 0x 0000 0001
            //x2 = 0x 0000 0010
            //x3 = 0x 0000 0011  // рез 3
            Console.WriteLine("| = " + x3);
            uint b4 = 1;
            b4 = ~b4;             // побитовое инвертирование
            //b4 = 0x 0000 0001
            //b4 = 0x 1111 1110  // рез 4294967294
            Console.WriteLine("~ = " + b4);
            x3 = x1 ^ x2;         // побитовое ЛИБО (xor)
            //x1 = 0x 0000 0001
            //x2 = 0x 0000 0010
            //x3 = 0x 0000 0011  // рез 3
            Console.WriteLine("^ = " + x3);

            x3 ^= x2; // сокращенная запись x3 = x3 ^ x2;


            Console.WriteLine("Определить четное ли число");
            Console.WriteLine("Введите целое число");
            int.TryParse(Console.ReadLine(), out int number);
            //123 0111 1011
            //1   0000 0001 
            //&   0000 0001 
            if ((number & 1) != 1) // операция менее затратная
            //if (number % 2 == 0)
                Console.WriteLine("Число четное");
            else
                Console.WriteLine("Число НЕ четное");


            // константы - используются для сохранения неизменного значения под
            // постоянным именем в некоторой области видимости
            // константа не меняет свое значение, имя константы обычно
            // указывается целиком в верхнем регистре
            // 10 - в данной строке - константное значение
            // предположим, что это значение зависит от каких-то настроек
            // проекта и используется еще в n-строчках проекта. Если потребуется
            // изменить эту константу, придется найти все n-строк. 
            // В случае использования константы, надо будет будет изменить только
            // значение константы.
            int some1 = 10;

            const int SOME_VALUE = 10;
            some1 = SOME_VALUE; // указание значения из константы

            // в проекте есть слово static, оно прописано в определении
            // метода Main. Слово указывает на то, что метод выполняется
            // без создания экземпляра класса Program.

            // Program pro = new Program(); - создание экземпляра 
            // При первом обращении к классу, он инициализируется -
            // в памяти создаются ссылки на все методы, которые есть в классе
            // Все методы в классе создаются один раз, выполняются они либо 
            // на экземпляре класса, либо (с помощью static) без экземлпяра
            // Статичному методу внутри класса для работы будут доступны 
            // только другие статичные методы и поля
            // Из нестатичных методов доступны все методы и поля класса
            // Пока что, если у нас будет два и более методов или поля за 
            // пределами метода Main, мы все будем помечать ключевым словом
            // static, чтобы работать без экземпляра класса
            /* многострочный
             * комментарий   */



            // точка выхода из приложения
        }

        class A
        { 
            int value1; // поле
            public int Value { get; set; } // свойство

            static bool testBool;
            /*static void Test()
            {
                testBool = true; // доступ к статичным данным
                value1 = 10; // нет доступа к нестатичным элементам
                Value = 20;  // нет доступа к нестатичным элементам
            }*/
        }

        struct B
        {
            public int Value { get; set; }
        }
    }
}