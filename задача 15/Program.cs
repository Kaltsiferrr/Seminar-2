Console.WriteLine("Введите день месяца: ");
int a = int.Parse(Console.ReadLine());
if ( a%6==0 || a%13==0 || a%20==0 || a%27==0  || a%7==0) Console.WriteLine("Этот день является выходным.");
else Console.WriteLine("Этот день не является выходным.");
