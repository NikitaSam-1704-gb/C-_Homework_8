//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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
    int [,] array= new int[parametrs.rows,parametrs.cols];
    for(int i=0; i<parametrs.rows; i++)
    {
        for(int j=0; j<parametrs.cols; j++)
            array[i,j]=new Random().Next(minValue,maxValue+1);
    }
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


int[,] BubblesLineArray(int[,] array)
{
    int max=0;
    int k=0;
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1)-1; j++)
        {  
           max=array[i,j];
           k=j+1;
            while (k<array.GetLength(1))
            {
                if(max<array[i,k])
                {
                    max=array[i,k];
                    array[i,k]=array[i,j];
                    array[i,j]=max;
                }
                k++;
            }
        }
    }
    return array;
}

int[,] massiv=FillRandomArray(0,10);
PrintArrayTwoDimensional (massiv);
int[,] massivBabls=BubblesLineArray(massiv);
PrintArrayTwoDimensional (massivBabls);
