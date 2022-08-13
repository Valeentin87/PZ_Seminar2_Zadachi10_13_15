// Задача 13: напишите программу которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
string numberThRee ()
{
    Console.WriteLine("Введите целое число, не менее трёх знаков");
    string Nstring = Console.ReadLine();
        if (Nstring.Length < 3) 
    {
        string name = "Во введенном числе третьей цифры нет";
        Console.WriteLine("Во введенном числе третьей цифры нет");
        return name;
    }
    else
    {
        Console.WriteLine($"Третья цифра во введенном числе равна {Nstring[2]}");
        return Convert.ToString(Nstring[2]);
    }
} 
numberThRee();
