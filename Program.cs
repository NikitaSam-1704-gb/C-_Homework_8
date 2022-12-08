//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18


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

int[,] FillRandomArray(int rows, int cols, int minValue, int maxValue)
{
    int [,] array= new int[rows,cols];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<cols; j++)
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


int[,]  Multiplication(int[,] array1, int[,] array2)
{
    int[,] multArray=new int[array1.GetLength(0),array2.GetLength(1)];
    int summ;
    //int k=0;
    for(int i=0; i<array1.GetLength(0); i++)
    {
        for(int j=0; j<array2.GetLength(1); j++)
        {
            summ=0;
            for(int k=0; k<array2.GetLength(1); k++) 
                summ=summ+array1[i,k]*array2[k,j];
            multArray[i,j]=summ;
        }
    }
    WriteLine("Результат умножения");
    PrintArrayTwoDimensional (multArray);
    return multArray;
}

WriteLine("Создайте две квадратных матрицы");
(int rows, int cols)parametrs=EnterParametrsArray();
int[,] massiv1=FillRandomArray(parametrs.rows, parametrs.cols,0,10);
int[,] massiv2=FillRandomArray(parametrs.rows, parametrs.cols,0,10);
int[,] multMassiv=Multiplication(massiv1, massiv2);