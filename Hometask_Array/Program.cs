// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#region Task1
int[] arr = { 1, 3, 5, 7, 8, 6, 5, 3, 5, 6, 3, 1, 2, 4 };
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    sum += arr[i];
}
Console.WriteLine(sum);
#endregion