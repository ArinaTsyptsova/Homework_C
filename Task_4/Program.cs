// Задача 4
// Напишите программу, которая принимает на вход три числа 
// и выдает максимальное из этих чисел

Console.WriteLine("Введите число a: ");
int numa = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int numb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int numc = int.Parse(Console.ReadLine());
int max = numa;
if (numb > max) {
    max = numb;
}
if (numc > max) {
    max = numc;
}
Console.WriteLine($" Максимальное число: {max} ");