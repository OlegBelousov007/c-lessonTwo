//z1
//String a = "Hellow";
//String b = "Oleg";

//Console.WriteLine(a);
//Console.WriteLine(b);

//z2
//Console.WriteLine("Введите два числа через пробел:");
//string input = Console.ReadLine();
//string[] numbers = input.Split(' ');
//if (numbers.Length == 2 && double.TryParse(numbers[0], out double num1) && double.TryParse(numbers[1], out double num2))
//{
//    Console.WriteLine($"{num1}+{num2}={num1 + num2}");
//    Console.WriteLine($"{num1}-{num2}={num1 - num2}");
//    Console.WriteLine($"{num1}×{num2}={num1 * num2}");
//    if (num2 != 0)
//    {
//        Console.WriteLine($"{num1}÷{num2}={num1 / num2}");
//    }
//            else
//            {
//             Console.WriteLine("На ноль делить нельзя");
//            }
//        }
//            else
//            {
//                Console.WriteLine("Некорректный ввод. Пожалуйста, введите два числа через пробел.");
//            }

//3
//int number = 42;
//string strNumber = number.ToString();
//Console.WriteLine("Преобразование Integer в String:");
//Console.WriteLine($"Число {number} преобразовано в строку: {strNumber}");


//4
//string numberString = "3.14159";
//float number = float.Parse(numberString.Replace(".", ","));
//Console.WriteLine(number);

//5
//double celsius, fahrenheit;

//Console.Write("Введите температуру по Цельсию: ");
//celsius = Convert.ToDouble(Console.ReadLine());

//fahrenheit = celsius * 9 / 5 + 32;

//Console.WriteLine("Температура по Фаренгейту: " + fahrenheit);


//6
int N = 256; 

TimeSpan timePassed = TimeSpan.FromSeconds(N);
DateTime currentTime = DateTime.Today.Add(timePassed);

Console.WriteLine("Текущее время: {0:hh:mm:ss}", currentTime);