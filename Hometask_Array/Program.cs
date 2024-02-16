// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#region Task1
//int[] arr = { 1, 3, 5, 7, 8, 6, 5, 3, 5, 6, 3, 1, 2, 4 };
//int sum = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    sum += arr[i];
//}
//Console.WriteLine(sum);
#endregion
#region Task2v1
//int[] arr = { 1, 3, 5, 10, 7, 9, 20, 30, 50, 70, 999 };
//int i = 0;

//for (int a = 0; a < arr.Length; a++)
//{
//    for (int b = 0; b < arr.Length - 1; b++)
//    {
//        if (arr[b] > arr[b + 1])
//        {
//            i = arr[b + 1];
//            arr[b + 1] = arr[b];
//            arr[b] = i;
//        }
//    }
//}
//Console.WriteLine(arr[arr.Length - 1]);
#endregion
#region Task2v2
int[] arr = { 9, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int a = 0;
int b = 0;

for (int i = arr.Length-1; i > -1; i--)
{
    a = arr[i];
    if (a > b)
    {
        b = a;
    }
}
Console.WriteLine(b);
#endregion
#region Task3
//int[] arr = { 1, 3, 5, 6, 7, 8, 9, 4, 3, 5, 6, 8, 5, 3, 8};

//int lastElement = 0;
//for (int i = 0; i < arr.Length-1; i++)
//{
//    lastElement++;
//}
//Console.WriteLine(arr[0] + arr[lastElement]);
#endregion