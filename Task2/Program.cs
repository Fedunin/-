Console.Clear();
Console.Write("Введите первое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n > m)
    Console.WriteLine("Первое число больше второго");
else if (n < m)
    Console.WriteLine("Второе число больше первого");
else
    Console.WriteLine("Числа равны");