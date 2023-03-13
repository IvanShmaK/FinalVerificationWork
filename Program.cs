void ArrayOfStrings()
{
    string [] stringArray = new string [] {"hello", "22", "world", ":-)"};//массив из строк
    Console.Write("The initial array of strings: ");
    ShowArray(stringArray);//вывод исходного массива
    
    int size = ArrayLength(stringArray);//вводим переменную, которая будет равна длине второго массива, находим ее с помощью метода
    
    if (size > 0)//проверка, будет ли во втором массиве содержаться хотя бы один элемент
    {
        string [] shortStringArray = new string [size];//создаем второй массив, который будет состоять из коротких элементов,
        int ind = 0;                                   //и переменную, которая будет работать как счетчик индексов в нем

        for (int i = 0; i < stringArray.Length; i++)//цикл по перезаписи элементов длиной <4
            {
                string str = stringArray [i];//каждый элемент первого массива переводим в строку
                if (str.Length < 4)          //и проверяем количество символов в нем
                {
                    shortStringArray[ind] = stringArray [i];//если элемент меньше 4 символов длиной, записываем его во второй массив
                    ind++;
                }
            }

        Console.Write("The array of strings whose length is less than or equal to three characters: ");
        ShowArray(shortStringArray);//выводим второй массив пользователю
    }
    else
        Console.Write("There are no strings in this array whose length is less than or equal to three characters");
}       // или пишем, что коротких элементов в данном массиве нет

void ShowArray (string [] array)//метод по выводу массива
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}");//последний элемент выводим отдельной записью, чтобы после него не стояла запятая
}

int ArrayLength(string [] array)//метод по нахождению длины второго массива
{
    int count = 0;//создаем переменную-счетчик   
    for (int i = 0; i < array.Length; i++)
    {
        string str = array [i];
        if (str.Length < 4) count++;//если длина строки < 4 символов, счетчик увеличивается на 1
    }
    return count;
}

ArrayOfStrings();