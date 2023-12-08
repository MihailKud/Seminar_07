/* Задача №1
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
промежутке от M до N. Использовать рекурсию. Не использовать циклы.
*/

// Задаем два произвольных натуральных числа при условии, 
// что M меньше или равно N.
int numberM = 9;
int numberN = 19;
void myFunctionPrintNat(int m, int n)
{
    System.Console.Write($"{m} ");
    if (!(m == n)) myFunctionPrintNat(m + 1, n);        
}
System.Console.WriteLine($"Результат задачи №1");
myFunctionPrintNat(numberM, numberN);
System.Console.WriteLine();
System.Console.WriteLine($"---------------------------");     


/* Задача №2
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
*/

// Задаем два произвольных натуральных числа
int numN = 3;
int numM = 3;
int accerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else
    {
        if ((n > 0) & (m == 0))
        {
            return accerman(n-1, 1);
        }
        else
        {
            return accerman(n-1, accerman(n, m - 1));            
        }
    }
}

System.Console.WriteLine($"Результат задачи №2");
System.Console.WriteLine(accerman(numN, numM));
System.Console.WriteLine($"---------------------------");

/* Задача №3
Задайте произвольный массив. Выведите его элементы, начиная с конца.
Использовать рекурсию. Не использовать циклы.
*/

// Задаем произвольный одномерный массив целых чисел.
int [] myArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
void printArrayRevers(int [] arg)
{
    if (arg.Length == 1)
    {
        System.Console.Write(arg[0]);
    }
    else
    {
        System.Console.Write($"{arg[arg.Length - 1]} ");
        int [] arrayTemp = new int [arg.Length - 1];

        // Эта строка кода:
        // for (int i = 0; i < arrayTemp.Length; i++) arrayTemp[i] = arg[i];
        // заменена следующей рекурсивной функцией, моделирующей цикл for.
        void arrayIncrement(int c)
        {
            if (c < 0)
            {
                return;
            }
            else
            {
                arrayTemp[c] = arg[c];
                arrayIncrement(c - 1);
            }
        }
        arrayIncrement(arrayTemp.Length - 1);    
        printArrayRevers(arrayTemp);        
    }
}
System.Console.WriteLine($"Результат задачи №3");
printArrayRevers(myArray);
System.Console.WriteLine();
System.Console.WriteLine($"---------------------------");




