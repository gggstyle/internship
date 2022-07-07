// See https://aka.ms/new-console-template for more information
class Triangle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input Number");
        int input = int.Parse(Console.ReadLine()!);
        int num;
        int[] number = { 1, 2, 3 ,4,5,6,7,8,9,0};
        int index = 0;
        for (int i = 0; i < input; i++)
        {
            num = input - i;
            for (int j = 0; j < num; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < input -  num + 1; j++)
            {
                Console.Write("{0} " , number[index]);
                if(index+1 < number.Length)
                {
                    index++;
                }
            }
            Console.WriteLine();
        }
    }
}
