Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int a,b,c;
c = number % 10;
b = (number / 10) % 10;
a = number / 100;
Console.WriteLine("Вторая цифра: "+b);
