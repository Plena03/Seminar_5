// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateArray()
{
    var random = new Random();

    var result = new double[6];

    for (long i = 0; i < result.Length; i++)   
    {
        result[i] = random.Next(-9, 9);
    }
    return result;
}

double MaxArrayNumbers(double [] array) {
    double max = array[0];//максимальный элемент   var
        for (int i = 0; i < array.Length; i++)
        {
         if (array[i] > max)
           {
            max = array[i];
            //array[i]++;
           }
        }
    return max;
        
}

double MinArrayNumbers(double[] array) {     
    double min = array[0];// минимальный элемент  
    for (int i = 0; i < array.Length; i++)     
{         
    if (array[i] < min)    
    {
    min = array[i]; 
    //array[i]++;    
    }  
}    
    return min; 
}

void PrintArray(double[] array) {     
    Console.Write("["); 

    for(var i = 0; i < array.Length; i++) {         
        Console.Write(array[i]);  

        if (i != array.Length - 1)             
        Console.Write(", ");     
    }          
        Console.Write("]");     
        Console.WriteLine(); 
}   

var array = CreateArray();

Console.WriteLine();
Console.WriteLine("Сгенерировали массив из 6 элементов в диапазоне от [-9, 9]:");

PrintArray(array);

Console.WriteLine();

Console.WriteLine("Максимальный элемент массива:");
Console.WriteLine(MaxArrayNumbers(array));
Console.WriteLine();

Console.WriteLine("Минимальный элемент массива:");
Console.WriteLine(MinArrayNumbers(array));
Console.WriteLine();

Console.WriteLine("Разница между максимальным и минимальным элементами массива равна:");
Console.WriteLine(MaxArrayNumbers(array) - MinArrayNumbers(array));
Console.WriteLine();

