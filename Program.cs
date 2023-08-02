/*Task 1
void RandomNum(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int o = 0; o < array.GetLength(1); o++)
        {
            array[i, o] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}
void PArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int o = 0; o < array.GetLength(1); o++)
        {
            Console.Write(array[i, o] + " ");
        }
        Console.WriteLine("");
    }
}
Console.Write("Количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int stolb = Convert.ToInt32(Console.ReadLine());
double[,] num = new double[lines, stolb];
RandomNum(num);
PArray(num);
*/

/*Task 2

void RandomNum(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int o = 0; o < array.GetLength(1); o++)
            {
                array [i,o] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int o = 0; o < array.GetLength(1); o++)
        {
            Console.Write(array[i,o] + " ");
        }   
        Console.WriteLine(""); 
    }
}
Console.Write("Строка: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбец: ");
int stolb = Convert.ToInt32(Console.ReadLine());
int [,] num = new int [10,10];
RandomNum(num);
PArray(num);
if (lines > num.GetLength(0) || stolb > num.GetLength(1))
{
    Console.WriteLine("Элемента нет!");
}
else
{
    Console.WriteLine($"Элемент = {num[lines-1,stolb-1]}");
}
*/

/*Task 3
void RandomNum(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int o = 0; o < array.GetLength(1); o++)
        {
            array[i, o] = new Random().Next(0, 10);
        }
    }
}
void PArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int o = 0; o < array.GetLength(1); o++)
        {
            Console.Write(array[i, o] + " ");
        }
        Console.WriteLine("");
    }
}
Console.Write("Строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбцов: ");
int stolb = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[lines, stolb];
RandomNum(num);
for (int o = 0; o < num.GetLength(1); o++)
{
    double gob = 0;
    for (int i = 0; i < num.GetLength(0); i++)
    {
        gob = (gob + num[i, o]);
    }
    gob = gob / lines;
    Console.Write(gob + "; ");
}
Console.WriteLine();
PArray(num);
*/

