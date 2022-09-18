Console.WriteLine("Введите первое число.");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число.");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число.");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number3<number1&&number1>number2)
{
    Console.WriteLine("Максимальное число " + number1 + ".");
}
else if (number1<number2&&number2>number3)
{
    Console.WriteLine("Максимальное число " + number2 + ".");
}
else if (number1<number3&&number3>number2)
{
    Console.WriteLine("Максимальное число " +number3 + ".");
}
else if (number1==number2&&number1==number3&&number2==number3)
{
    Console.WriteLine("Числа равны.");
}
else if (number1==number2&&number2>number3&&number1>number3)
{
    Console.WriteLine("Числа " + number1 + " , " + number2 + " равны между собой и больше числа " + number3 + ".");
}
else if (number1==number3&&number3>number2&&number1>number2)
{
    Console.WriteLine("Числа " + number1 + " , " + number3 + " равны между собой и больше числа " + number2 + ".");
}
else if (number3==number2&&number2>number1&&number3>number1)
{
    Console.WriteLine("Числа " + number3 + " , " + number2 + " равны между собой и больше числа " + number1 + ".");
}
            
