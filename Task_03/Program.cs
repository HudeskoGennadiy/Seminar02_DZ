/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

    
int saturday = 6;
int sunday  = 7;

    Console.WriteLine("Введите цифру любого дня недели, от 1 до 7 ");
    int x = Convert.ToInt32(Console.ReadLine()); 

if (x == saturday | x == sunday)
    {
        Console.WriteLine("Сегодня выходной день! ");
    }
else 
    {
        Console.WriteLine("Сегодня рабочий день! ");
    }




