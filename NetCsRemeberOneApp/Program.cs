// 1
//double a, b, c;

//Console.WriteLine("Решение квадратных уравнений");
//Console.WriteLine("Введите коэффициенты уравнения");
//Console.Write("Введите a: ");
//a = Convert.ToDouble(Console.ReadLine());
//Console.Write("Введите b: ");
//b = Convert.ToDouble(Console.ReadLine());
//Console.Write("Введите c: ");
//c = Convert.ToDouble(Console.ReadLine());

//double D = b * b - 4 * a * c;

//if(D > 0)
//{
//    Console.WriteLine("Дискриминант > 0");
//    Console.WriteLine($"x1 = {(-b + Math.Sqrt(D)) / (2 * a)}");
//    Console.WriteLine($"x2 = {(-b - Math.Sqrt(D)) / 2 / a}");
//}
//else if(D == 0)
//{
//    Console.WriteLine("Дискриминант == 0");
//    Console.WriteLine($"x = {-b / 2 / a}");
//}
//else
//    Console.WriteLine($"Дискриминант < 0. Корней нет");


//2
//int number;
//do
//{
//    Console.Write("Введите целое положительное двузначное число: ");
//    number = Convert.ToInt32(Console.ReadLine());
//} while (number <= 0 || number >= 100);

//int units = number % 10;
//int tens = number / 10;

//string numberString = "";

//if(number >= 10 && number < 20)
//{
//    switch(units)
//    {
//        case 0: numberString = "десять"; break;
//        case 1: numberString = "одиннадцать"; break;
//        case 2: numberString = "двенадцать"; break;
//        case 3: numberString = "тринадцать"; break;
//        case 4: numberString = "четырнадцать"; break;
//        case 5: numberString = "пятнадцать"; break;
//        case 6: numberString = "шестнадцать"; break;
//        case 7: numberString = "семнадцать"; break;
//        case 8: numberString = "восемнадцать"; break;
//        case 9: numberString = "девятнадцать"; break;
//    }
//}
//else
//{
//    switch(tens)
//    {
//        case 2: numberString = "двадцать"; break;
//        case 3: numberString = "тридцать"; break;
//        case 4: numberString = "сорок"; break;
//        case 5: numberString = "пятьдесят"; break;
//        case 6: numberString = "шестьдесят"; break;
//        case 7: numberString = "семьдесят"; break;
//        case 8: numberString = "восемьдесят"; break;
//        case 9: numberString = "девяносто"; break;
//    }
//    numberString += " ";

//    switch (units)
//    {
//        case 1: numberString += "один"; break;
//        case 2: numberString += "два"; break;
//        case 3: numberString += "три"; break;
//        case 4: numberString += "четыре"; break;
//        case 5: numberString += "пять"; break;
//        case 6: numberString += "шесть"; break;
//        case 7: numberString += "семь"; break;
//        case 8: numberString += "восемь"; break;
//        case 9: numberString += "девять"; break;
//    }
//}
//Console.WriteLine($"{number}: {numberString}");


//ulong number, copyNumber, result = 0;
//Console.Write("Введите целое положительное число: ");
//number = Convert.ToUInt64(Console.ReadLine());
//copyNumber = number;

//while(number > 0)
//{
//    result += number % 10;
//    number /= 10;
//}
//Console.WriteLine($"Сумма цифр числа {copyNumber} = {result}");
