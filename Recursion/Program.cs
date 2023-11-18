// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NToOne(int n)
{   
    if (n >= 1)
    {
        Console.Write(n + " ");
        NToOne(n-1);
    }
}

 Console.WriteLine("Input number N: ");
 int n = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine($"A sequence of numbers from {n} to 1:");
 NToOne(n);

//  Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int SumMtoN(int m, int n)
{
if (m == 0) return (n * (n + 1)) / 2;
    else if (n == 0) return (m * (m + 1)) / 2;
    else if (m == n) return m; 
    else if (m < n) return n + SumMtoN(m, n - 1); 
    else return n + SumMtoN(m, n + 1);            // если m > n
}

Console.WriteLine("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = SumMtoN(m,n);
Console.WriteLine($"Sum of numbers from {m} to {n}: {result}" );

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FunctionAkkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return FunctionAkkerman(m - 1, 1);
  else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}
Console.WriteLine("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" Ackerman function A({m},{n}) -> {FunctionAkkerman(m, n)}");
