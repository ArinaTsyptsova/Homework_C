Console.WriteLine("Введите число a: ");
int numbera = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int numberb = int.Parse(Console.ReadLine());
if (numbera > numberb) {
    Console.WriteLine($" max = {numbera}, min = {numberb}");
}
else if (numbera == numberb) {
    Console.WriteLine("Числа a и b равны");
}
else {
    Console.WriteLine($" min = {numbera}, max = {numberb}");
}