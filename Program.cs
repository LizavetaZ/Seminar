Console.WriteLine("Введите числа");
string value1 = Console.ReadLine();
string value2 = Console.ReadLine();
int a = int.Parse(value1);
int b = int.Parse(value2);
int max = a;
if (a>max) max = a;
if (b>max) max = b;
Console.Write("max=");
Console.WriteLine(max);

