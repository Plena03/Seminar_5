// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray()
{
    var random = new Random();
    var result = new int[6];
    for (long i = 0; i < result.Length; i++)   
    {
        result[i] = random.Next(-9, 9);
    }
    return result;
}

int SumOddNumbers(int[] array) {
var sum = 0;
       for (int i = 1; i < array.Length; i += 2)   
       {
            sum += array[i];
       }
       return sum;
}

void PrintArray(int[] array) {     
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
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях, равна: "  );
Console.WriteLine(SumOddNumbers(array));
Console.WriteLine();
