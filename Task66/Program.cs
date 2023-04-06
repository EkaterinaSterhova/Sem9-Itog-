// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



void PrintSumm(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {sum} ");
    return;
  }
  PrintSumm(m, n - 1, sum);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int In = Convert.ToInt32(Console.ReadLine());
  return In;
}
int m = InputNumbers("Введите значение М: ");
int n = InputNumbers("Введите значение N: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSumm(m, n, temp=0);