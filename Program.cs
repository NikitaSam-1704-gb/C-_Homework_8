// Задача №53. Создать духмерный массив
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

// Задача №57. Составить частотный словарь, вдухмерного массива.

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
FrequencyLog(massiv, parametrs.minValue, parametrs.maxValue);