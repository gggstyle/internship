// See https://aka.ms/new-console-template for more information
class Stars
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input Number");
        int num = int.Parse(Console.ReadLine()!);
        int star;
        for (int i = 0; i < num; i++)
        {
            star = num - i;
            for (int j = 0; j < star; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < num - star; j++)
            {
                Console.Write("*");
            }
            for (int j = num - star - 1; j > 0; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}