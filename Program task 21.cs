//Задача 21. Нахождение расстояния между двумя точками в трехмерном пространстве. 
Console.Clear();
Console.Write("Введите координату х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату у1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату х2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату у2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2)), 2));