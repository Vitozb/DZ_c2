System.Console.Write("Введите цифру обозначающую день недели: ");
int num = Convert.ToInt32(System.Console.ReadLine());
if (num > 0 & num <=7)
{
    if (num == 6) System.Console.WriteLine("Отлично это Суббота");
    if (num == 7) System.Console.WriteLine("Отлично это Воскресенье");
    if (num > 0 & num < 6) System.Console.WriteLine("Это рабочий день");
}
else 
    System.Console.WriteLine("Вы ввели неверное число");