// №15, третья цифра произвольного числа
Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n>-100 && n<=99)
    Console.WriteLine("Третья цифра отсутствует");
else
{
   if   (n<-99)
   {
    string str = n.ToString();
    Console.WriteLine(str[3]);
   }
    
   else
   {
    string str = n.ToString();
    Console.WriteLine(str[2]);
   }
}
