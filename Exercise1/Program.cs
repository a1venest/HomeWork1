Console.WriteLine("Введите первое число.");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число.");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1>number2)
{
    Console.WriteLine("Число " + number1 + " больше числа " + number2 + ".");
}
else if (number1<number2)
{
    Console.WriteLine("Число " + number2 + " больше числа " + number1 + ".");
}
else if (number1==number2)
{
    Console.WriteLine("Число " + number2 + " равно числу " + number1 + ".");
}