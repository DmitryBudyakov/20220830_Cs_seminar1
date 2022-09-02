// Напишите программу, которая:
// 1. на вход принимает число
// 2. и выдаёт его квадрат (число
// умноженное на само себя).
// 3. выводит результат
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Clear();
Console.Write("Введите целое число: ");
//int num = int.Parse(Console.ReadLine());
int num = Convert.ToInt32(Console.ReadLine()); // - аналог Parse 
// int32 - от -2 147 483 647 до +2 147 483 647

int square = num * num;

Console.WriteLine($"Квадрат числа {num} = {square}");
//Console.WriteLine("Квадрат числа " + num + " = " + square); // с конкатенацией
