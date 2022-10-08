//Задача 23. Нахождение кубов всех числе от 1 до заданного N.
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
Console.Write($"{i * i * i} ");