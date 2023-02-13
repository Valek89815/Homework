//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка)
//4 -> да
//-3 -> нет
//7 -> нет

int number_even_or_odd =Convert.ToInt32(Console.ReadLine());
if (number_even_or_odd %2 ==0)
{
    Console.WriteLine("yes");
}
else if (number_even_or_odd %2 ==1)
{
    Console.WriteLine("no");
}