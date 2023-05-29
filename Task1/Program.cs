System.Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(System.Console.ReadLine());
int result = (num % 100 - num % 10) / 10;
System.Console.WriteLine("Второе число равно "+result);