Console.WriteLine("Введите числа");
string value1 = Console.ReadLine();
string value2 = Console.ReadLine();
string value3 = Console.ReadLine();
int a = int.Parse(value1);
int b = int.Parse(value2);
int c = int.Parse(value3);
int max = a;
if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = c;
Console.Write("max=");
Console.WriteLine(max);

