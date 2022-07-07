// See https://aka.ms/new-console-template for more information

class Sum
{
    public static object Int { get; private set; }

    static void Main(string[] args)
    {
        Console.Write("Input size of Array : ");
        int size = int.Parse(Console.ReadLine()!);
        int[] arr = new int[size];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Input value index[" + i + "] : ");
            arr[i] = int.Parse(Console.ReadLine()!);
            Console.WriteLine("{0}", string.Join(", ", arr));
        }
        Console.Write("Input Sum : ");
        int sum = int.Parse(Console.ReadLine()!);
        List<int> visible = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] + arr[j] == sum && i != j)
                {
                    if (!(visible.Contains(arr[i]) && visible.Contains(arr[j])))
                    {
                        visible.Add(arr[i]);
                        visible.Add(arr[j]);
                        Console.WriteLine(arr[i] + "," + arr[j]);
                        break;
                    }
                }  
            }
        }
    }
}
