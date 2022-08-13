// Напишите программу, которая на вход принимает цифру, обозначающую день недели и проверяет не является ли этот день выходным
string Vihodnoy ()
{
    Console.WriteLine("Введите цифру, обозначающую порядковый день в неделе");
    int day = Convert.ToInt32(Console.Readline());
    if (day == 6 || day == 7)
    {
        string otvet = "день является выходным";
        Console.WriteLine(otvet);
        return otvet;
    }
    else
    {
        string otvet = "день является рабочим";
        Console.WriteLine(otvet);
        return otvet;
    }
    
}
Vihodnoy ();