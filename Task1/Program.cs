System.Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(System.Console.ReadLine());

if (num >= 100 & num < 1000)
{
int result = (num % 100 - num % 10) / 10;
System.Console.WriteLine("Второе число равно "+result);
}
else System.Console.WriteLine("Ввели некоректное число");