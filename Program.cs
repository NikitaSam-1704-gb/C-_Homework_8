//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



using static System.Console;
Clear();

(int rows, int cols) EnterParametrsArray()
{
    (int rows, int cols) parametrs;
    Write("Введите количество строк-> ");
    parametrs.rows=Convert.ToInt16(ReadLine());
    Write("Введите количество столбцов-> ");
    parametrs.cols=Convert.ToInt16(ReadLine());
    return parametrs;
}

int[,] FillRandomArray(int minValue, int maxValue)
{
    (int rows, int cols)parametrs=EnterParametrsArray();
    int [,] array= new int[parametrs.rows, parametrs.cols];
    for(int i=0; i<parametrs.rows; i++)
    {
        for(int j=0; j<parametrs.cols; j++)
            array[i,j]=new Random().Next(minValue,maxValue+1);
    }
    PrintArrayTwoDimensional (array);
    return array;
}

void PrintArrayTwoDimensional (int [,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            Write($" {array[i,j]} \t");
        WriteLine();
    }
    WriteLine();
}


void SummLineArray(int[,] array)
{
    int summ;
    int k=0;
    for(int i=0; i<array.GetLength(0); i++)
    {
        summ=0;
        for(int j=0; j<array.GetLength(1); j++) 
           summ+=array[i,j];
        WriteLine($"сумма значений элементов строки {i+1}, равна {summ}");
    }
}

int[,] massiv=FillRandomArray(0,10);
SummLineArray(massiv);