Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int a,b,c;
c = number % 10;
b = (number / 10) % 10;
a = number / 100;
if (a == 0) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine("Третья цифра: "+ c);