// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int m = InputNumbers("Введите m: "); //введение
int n = InputNumbers("Введите n: "); // введение

int fun = Ack(m, n); // Объявление

Console.Write($"Функция Аккермана = {fun} "); // Вывод

int Ack(int m, int n) // Запуск 
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
