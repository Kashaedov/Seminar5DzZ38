int size = 5; 
double [] array = new double [size];


void FillArray (double [] array)

{
    Random random = new Random ();
    for (int i = 0; i < array.Length; i++)
    {
    array [i] = random.NextDouble ();
    }
}

void PrintArray (double [] array)
{
    Console.WriteLine ("Ввывод массива:");
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write (array[i] + "\t");
    }
   Console.WriteLine ();
}
void RaznichaMinMax (double [] array)
{
    double max = array[0];
    double min = array[0];
    

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array [i];
        else if (array[i] < min) min = array [i];
    }
    double Raznicha = max - min;
Console.WriteLine ();
Console.WriteLine ($"Максимальное значение = {max}");
Console.WriteLine ($"Максимальное значение = {min}");
Console.WriteLine ($"Разница между максимальным и минимальным элементов массива  = {Raznicha}");
Console.WriteLine ();
}


FillArray (array);
PrintArray (array);
RaznichaMinMax (array);

