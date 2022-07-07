// See https://aka.ms/new-console-template for more information
class TV
{
    static void Main(string[] args)
    {
        Console.Write("Input size of Array : ");
        int size = int.Parse(Console.ReadLine()!);
        int[] arr = new int[size];
        string result = "";
       
        for (int i = 0; i < size; i++)
        {
            Console.Write("Input value index[" + i + "] : ");
            arr[i] = int.Parse(Console.ReadLine()!);
            
        }
        result += arr[0];
        for (int i = 1; i < size; i++)
        {
            if(arr[i]-arr[i-1] == 1)
            {
                if(i+1 == arr.Length-1)
                {
                    result += "-"+arr[i+1];
                    continue;
                }
            }else if (i+1 < arr.Length)
            {
                if(arr[i+1] - arr[i] != 1)
                {
                    result += ","+arr[i];
                }
                else
                {
                    result += "," + arr[i]+"-"+ arr[i+1];
                }
            }
            else
            {
                result += "," + arr[i];
            }
        }
        Console.WriteLine(result);
        
    }
}

