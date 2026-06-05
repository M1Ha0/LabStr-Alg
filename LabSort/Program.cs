using System;

int[] arrayA = [10, 20, 30, 40, 50, 60, 70, 80, 90, 100];
int[] arrayB = [45, 15, 65];
Console.Write($"Исходный массив A: ");
foreach (int ch in arrayA)
{
    Console.Write(ch+" ");
}
Console.WriteLine();
Console.Write($"Исходный массив B: ");
foreach (int cb in arrayB)
{
    Console.Write(cb + " ");
}
Console.WriteLine();
Console.WriteLine();

int[] arrayC = MergeArrays(arrayA, arrayB);

Console.Write($"Отсортированный массив C: ");
foreach (int cс in arrayC)
{
    Console.Write(cс + " ");
}
static int[] MergeArrays(int[] a, int[] b)
{
    Array.Sort(b);

    int m = a.Length;
    int n = b.Length;
    int[] c = new int[m + n];

    int i = 0, j = 0, k = 0;
    while (i < m && j < n)
    {
        if (a[i] <= b[j])
        {
            c[k++] = a[i++];
        }
        else
        {
            c[k++] = b[j++];
        }
    }
    while (i < m) c[k++] = a[i++];
    while (j < n) c[k++] = b[j++];

    return c;
}