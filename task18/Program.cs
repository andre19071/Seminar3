// Задача 18: Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).


Console.WriteLine("Номер координатной четверти");
int x = Convert.ToInt32(Console.ReadLine());


if (x == 1)
{
    Console.WriteLine( "Точка находится в  диапазоне (X>0,Y>0)");
}
else if (x == 2)
{
    Console.WriteLine("Точка находится в диапазоне (X<0,Y>0)");
}
else if (x == 3)
{
    Console.WriteLine("Точка находится в диапазоне (X<0,Y<0)");
}    
else if (x == 4)
{
    Console.WriteLine("Точка находится в  диапазоне (X>0,Y<0)");
}
else
{
    Console.WriteLine("нет такой четверти");
}

