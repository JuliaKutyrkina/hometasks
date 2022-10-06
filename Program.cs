// №15, определение выходных и будней по номеру дня недели
Console.Clear();
Console.WriteLine("Введите номер дня недели");
int n = Convert.ToInt32(Console.ReadLine());
if (n<1 || n>7)
    Console.WriteLine("Вы ошиблись! ВВедите номер дня недели в промежутке от 1 до 7");
if (n == 6 || n == 7)
    Console.WriteLine("yes");
else 
    Console.WriteLine("no");
