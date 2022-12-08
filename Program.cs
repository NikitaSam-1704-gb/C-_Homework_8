﻿// Задача №53. Создать духмерный массив
// Поменять первую и последнию строку местами

/*using static System.Console;
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
    PrintArray(array);
    return array;
}

void PrintArray (int [,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            Write($" {array[i,j]} \t");
        WriteLine();
    }
    WriteLine();
}

int[,] ChangeFirstLast (int[,] array)
{
    int temp;
    int fistI=0;
    int lastI=array.GetLength(0)-1;
    for(int j=0; j<array.GetLength(1); j++)
    {
       temp=array[fistI,j];
       array[fistI,j]=array[lastI,j];
       array[lastI,j]=temp;
    }
    PrintArray (array);
    return array;
}


(int rows, int cols) parametrsWork=EnterParametrsArray();
int[,] massiv=FillRandomArray(parametrsWork.rows, parametrsWork.cols, 0, 10);
massiv=ChangeFirstLast (massiv);*/

/*// Задача №55 Заменить строки на столбцы в двумерном массиве

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
    (int rows, int cols) parametrs=EnterParametrsArray();
    int [,] array= new int[parametrs.rows,parametrs.cols];
    for(int i=0; i<parametrs.rows; i++)
    {
        for(int j=0; j<parametrs.cols; j++)
            array[i,j]=new Random().Next(minValue,maxValue+1);
    }
    PrintArray(array);
    return array;
}

void PrintArray (int [,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            Write($" {array[i,j]} \t");
        WriteLine();
    }
    WriteLine();
}

int[,] ChangeRowsCols(int[,] array)
{
    int[,] chegeArray= new int[array.GetLength(1),array.GetLength(0)];
    for( int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            chegeArray[j,i]=array[i,j];
    }
    PrintArray (chegeArray);
    return chegeArray;
}

int[,] massiv=FillRandomArray(0, 10);
massiv=ChangeRowsCols(massiv);*/

/*// Задача №57. Составить частотный словарь, вдухмерного массива.

using static System.Console;
Clear();

(int rows, int cols, int minValue, int maxValue) EnterParametrsArray()
{
    (int rows, int cols, int minValue, int maxValue) parametrs;
    Write("Введите количество строк-> ");
    parametrs.rows=Convert.ToInt16(ReadLine());
    Write("Введите количество столбцов-> ");
    parametrs.cols=Convert.ToInt16(ReadLine());
    Write("Введите MIN значение-> ");
    parametrs.minValue=Convert.ToInt16(ReadLine());
    Write("Введите MAX значение-> ");
    parametrs.maxValue=Convert.ToInt16(ReadLine());

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
    PrintArrayTwoDimensional(array);
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

void PrintArrayOneDimensional (int[] valArray, int [] freqArray)
{
    Write("значение ");
    for(int i=0; i<valArray.Length; i++)
         Write($" {valArray[i]} \t");   
    WriteLine();
    Write("частота ");
    for(int i=0; i<freqArray.Length; i++)
         Write($" {freqArray[i]} \t"); 
    WriteLine();
}

void FrequencyLog(int[,] array, int minValue, int maxValue)
{
    int size=Math.Abs((maxValue+1)-minValue);
    int[] valuesArray= new int[size];
    int[] frequencyArray=new int[size];
    for(int k=0; k<valuesArray.Length; k++)
    {
        valuesArray[k]=minValue;
        minValue++;
    }
    for( int k=0; k<frequencyArray.Length; k++)
    {
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            if(valuesArray[k]==array[i,j])
                frequencyArray[k]++;
        }
    }
    }
    PrintArrayOneDimensional (valuesArray, frequencyArray);
}


(int rows, int cols, int minValue, int maxValue) parametrs=EnterParametrsArray();
int[,] massiv=FillRandomArray(parametrs.rows, parametrs.cols, parametrs.minValue, parametrs.maxValue);
FrequencyLog(massiv, parametrs.minValue, parametrs.maxValue);*/

/*//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
PrintArrayTwoDimensional (massivBabls);*/


/*//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
SummLineArray(massiv);*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18


/*using static System.Console;
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
int[,] multMassiv=Multiplication(massiv1, massiv2);*/

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
                Write($" {array[i,j,k]}  k,i,j({k+1},{i+1},{j+1})\t");
            WriteLine();
        }
    WriteLine();
    }
}


WriteLine("Создайте трехмерный массив");
(int rows, int cols, int level)parametrs=EnterParametrsArray();
int[,,] massiv=FillRandomArray(parametrs.rows, parametrs.cols,parametrs.level);