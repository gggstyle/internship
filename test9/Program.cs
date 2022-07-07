// See https://aka.ms/new-console-template for more information
class Revert
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input Text");
        string str = Console.ReadLine()!;
        string[] arr = str.Split(' ');
        string result = "";
        foreach (string item in arr)
        {
            string temp = "";
            for(int i = item.Length-1; i >= 0; i--)
            {
                temp += item[i];
            }
            result += temp +" "; 
        }
        Console.WriteLine(result);

    }
}
