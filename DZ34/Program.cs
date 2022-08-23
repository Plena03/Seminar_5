// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] createArray()
{
    var random = new Random();
    var result = new int[12];
    for (long i = 0; i < result.Length; i++)   
    {
        result[i] = random.Next(100, 999);
    }
    return result;
}

int ellEvenNumbers(int[] array) {
var result = 0;
       for (int i = 0; i < array.Length; i++)   
       {
        if (array[i] % 2 == 0)
            result ++;
       }
       return result;
}

void printArray(int[] array) {     
    Console.Write("[");
    for(var i = 0; i < array.Length; i++) {         
        Console.Write(array[i]);  
        if (i != array.Length - 1)             
        Console.Write(", ");     
    }          
        Console.Write("]");     
        Console.WriteLine(); 
}   

var array = createArray();

Console.WriteLine();
Console.WriteLine("Сгенерировали массив из 12 элементов в диапазоне от [100, 999]:");

printArray(array);

Console.WriteLine();
Console.WriteLine("Количество четных элементов массива: "  );
Console.WriteLine(ellEvenNumbers(array));
Console.WriteLine();
