/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите число от 1 до 7: ");
string dayoftheweek = Console.ReadLine();
if (dayoftheweek=="1")
Console.WriteLine("Понедельник. Этот день не выходной");

else if (dayoftheweek=="2")
Console.WriteLine("Вторник. Этот день не выходной");

else if (dayoftheweek=="3")
Console.WriteLine("Среда. Этот день не выходной");

else if (dayoftheweek=="4")
Console.WriteLine("Четверг. Этот день не выходной");

else if (dayoftheweek=="5")
Console.WriteLine("Пятница. Этот день не выходной");

else if (dayoftheweek=="6")
Console.WriteLine("Суббота. Ура, этот день выходной!");

else if(dayoftheweek=="7")
Console.WriteLine("Воскресенье. Ура, этот день выходной!");

else 
Console.WriteLine("Вы ввели неверное число. Необходимо ввести от 1 до 7");
