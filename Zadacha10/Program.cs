/* Задача 10. Напишите программу, которая принимает на вход трёхзначное чсило и на выходе показывает вторую цифру этого числа*/
char SecondNumber(string number)
{
char NumberTwo = Convert.ToChar(number[1]);
Console.WriteLine($"Было введено трёхзначное число {number}");
Console.WriteLine($"Значение второй цифры равно = {NumberTwo}");
return NumberTwo;
}
SecondNumber("456");
SecondNumber("782");
SecondNumber("918");
