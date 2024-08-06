 Console.WriteLine($"Введите год в формате \"yyyy\" ");

int year = Convert.ToInt32(Console.ReadLine());
int remains1 = year % 400;
int remains2 = year % 4;
int remains3 = year % 100;

if ((remains1 == 0) || (remains2 == 0 && remains3 != 0))
{
    Console.WriteLine("Количество дней 366");
}
else
{
    Console.WriteLine("Количество дней 365");
}