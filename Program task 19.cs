// Задача 19. Проверка числа на палиндром. 
Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = n/10000;
int b = (n%10000)/1000;
int c = (n%100)/10;
int d = n%10;
if (a == d && b == c)
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");
