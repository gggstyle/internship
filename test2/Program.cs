// See https://aka.ms/new-console-template for more information

class Compare
{
    static void Main(string[] args)
    {
        bool isMat;
        int duplicate = 0;
        Console.WriteLine("Input String : ");
        string str1 = Console.ReadLine()!;
        Console.WriteLine("Input String : ");
        string str2 = Console.ReadLine()!;
        string str1Lower = str1.ToLower();
        string str2Lower = str2.ToLower();
        if (str1.Length == str2.Length)
        {
            for (int i = 0; i < str1Lower.Length; i++)
            {
                for(int j = 0; j < str2Lower.Length; j++)
                {
                    if(str1Lower[i] == str2Lower[j])
                    {
                        duplicate ++;
                        break;
                    }
                }
               
            }
            if (duplicate == str1.Length)
            {
                Console.WriteLine("true");
            }
            else {
                Console.WriteLine("false");
            }
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}