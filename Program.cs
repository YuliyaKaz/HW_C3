//Задача 64: Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
int rec(int N){
    if (N<=1) {
        return 1;
    }
    Console.Write(N + ",");
    return rec(N-1);   
}
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(N));

//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
int sums(int m, int n){
    if (m<n)
        return m + sums(m+1,n);
    else if (m>n)
        return m + sums(m-1,n);
    else return n; 
}

Console.WriteLine("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма чисел от M до N равна: " + sums(M,N));


//Задача 68: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.
int Accerman(int m,int n){
    if (m == 0) return n+1;
    else if (n == 0) return Accerman(m-1,1);
    else return Accerman(m-1,Accerman(m,n-1));
}

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Accerman(m,n));