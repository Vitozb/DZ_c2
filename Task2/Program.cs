System.Console.Write("Введите число: ");
int num = Convert.ToInt32(System.Console.ReadLine());

if (num >= 100 & num < 1000) 
{
    int result = num % 10;
    System.Console.WriteLine("Третье число равно "+result);
}
else if (num < 100) System.Console.WriteLine("Третьего числа нет");

if (num >= 1000 & num < 10000) 
{
    int result = (num % 100 - num % 10) / 10;
    System.Console.WriteLine("Третье число равно "+result);
}

if (num >= 10000 & num < 100000) 
{
    int result = (num % 1000 - num % 100) / 100;
    System.Console.WriteLine("Третье число равно "+result);
}

if (num >= 100000 & num < 1000000) 
{
    int result = (num % 10000 - num % 1000) / 1000;
    System.Console.WriteLine("Третье число равно "+result);
}
