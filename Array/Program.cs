// Создать массив с заданными характеристиками и случайными числами
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] array = GetArray(5, 100, 999);
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");


// Создает массив случайных чисел с заданными пользователем значениями 
int[] FillArray()
{
    Console.Write("Введите длинну массива: ");
    int size = int.Parse(Console.ReadLine()!);

    Console.Write("Введите минимальное значение элемента массива: ");
    int minValue = int.Parse(Console.ReadLine()!);

    Console.Write("Введите максимальное значение элемента массива: ");
    int maxValue = int.Parse(Console.ReadLine()!);

    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;

}

FillArray();


// Ввод характеристики матрицы через консоль
int[] MatrixDataInput()
{
    Console.Clear();

    Console.Write("Введите количество строк числовой матрицы: ");
    int rows = int.Parse(Console.ReadLine()!);

    Console.Write("Введите количество столбцов числовой матрицы: ");
    int colums = int.Parse(Console.ReadLine()!);

    Console.Write("Введите минимальное значение элемента матрицы: ");
    int minValue = int.Parse(Console.ReadLine()!);

    Console.Write("Введите максимальное значение элемента матрицы: ");
    int maxValue = int.Parse(Console.ReadLine()!);
    
    int[] data = {rows, colums, minValue, maxValue};

    return data;
}


//Создает числовую матрицу 
int[,] NewMatrix(int rows, int colums, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, colums];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}


// Выводит в консоль матрицу
void PrintMatrix(int[,] matrix)
{
    int count = 1;
    int length = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (count <= Math.Abs(matrix[i, j])) 
            {
            count *= 10;
            length++;
            }
        }
    }

    Console.Clear();
    
    int leftPosition;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            leftPosition = j * (length + 1);
            if (matrix[i, j] >= 0) leftPosition++;
            Console.SetCursorPosition(leftPosition, i);
            Console.Write($"{matrix[i, j]} ");
        }
    }
}


//Написание программы вывода матрицы с характеристиками введенными с консоли
int[] dataArray = MatrixDataInput();
int[,] matrix = NewMatrix(dataArray[0], dataArray[1], dataArray[2], dataArray[3]);
PrintMatrix(matrix);