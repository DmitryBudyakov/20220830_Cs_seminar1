// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Clear();
Console.Write("Введите номер дня недели в диапазоне 1...7: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 < 8 && num1 > 0)    // проверяем чтобы юзер вводил от 1 до 7
{
    if (num1 == 1) Console.WriteLine("Понедельник");
    if (num1 == 2) Console.WriteLine("Вторник");
    if (num1 == 3) Console.WriteLine("Среда");
    if (num1 == 4) Console.WriteLine("Четверг");
    if (num1 == 5) Console.WriteLine("Пятница");
    if (num1 == 6) Console.WriteLine("Суббота");
    if (num1 == 7) Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Ошибка, введите число от 1 до 7.");
}
