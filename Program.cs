//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

using static System.Console;
Clear();

(int rows, int cols, int level) EnterParametrsArray()
{
    (int rows, int cols, int level) parametrs;
    Write("Введите количество строк-> ");
    parametrs.rows=Convert.ToInt16(ReadLine());
    Write("Введите количество столбцов-> ");
    parametrs.cols=Convert.ToInt16(ReadLine());
    Write("Введите количество уровней-> ");
    parametrs.level=Convert.ToInt16(ReadLine());
    return parametrs;
}

int[,,] FillRandomArray(int rows, int cols,int level)
{
    int [,,] array= new int[rows,cols,level];
    for(int k=0; k<level; k++)
    {
        for(int i=0; i<rows; i++)
        {
            WriteLine($"Введите строку {i+1} уровня {k+1}");
            for(int j=0; j<cols; j++)
                array[i,j,k]=Convert.ToInt32(ReadLine());
            WriteLine();
        }
        WriteLine();
    }
    PrintArrayThreeDimensional (array);
    return array;
}

void PrintArrayThreeDimensional (int [,,] array)
{
    for(int k=0; k<array.GetLength(2); k++)
    {
        for(int i=0; i<array.GetLength(0); i++)
        {
            for(int j=0; j<array.GetLength(1); j++)
                Write($" {array[i,j,k]}  i,j,k({k+1},{i+1},{j+1}{k+1})\t");
            WriteLine();
        }
    WriteLine();
    }
}


WriteLine("Создайте трехмерный массив");
(int rows, int cols, int level)parametrs=EnterParametrsArray();
int[,,] massiv=FillRandomArray(parametrs.rows, parametrs.cols,parametrs.level);