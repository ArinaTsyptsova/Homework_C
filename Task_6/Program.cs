// Задача 6
// Напишите программу, которая на вход принимает число и 
// выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int remDiv = num % 2;
if (remDiv == 0) {
    Console.WriteLine("Да, это четное число");
}
else {
    Console.WriteLine("Нет, это нечетное число");
}