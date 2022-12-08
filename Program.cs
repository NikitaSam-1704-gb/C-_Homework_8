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