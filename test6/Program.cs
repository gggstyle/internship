// See https://aka.ms/new-console-template for more information
class Sort
{
    static void Main(string[] args)
    {
        int[] number = new int[10];
        for (int i = 0; i < number.Length; i++)
        {
            Console.Write("Input value index[" + i + "] : ");
            number[i] = int.Parse(Console.ReadLine()!);
        }
        AddNumbers(number);
    }
    public static void AddNumbers(int[] number)
    {
        int temp;
        for (int i = 0; i < number.Length; i++)
        {

            for (int j = 0; j < number.Length; j++)
            {
                if (number[i] > number[j])
                {
                    temp = number[i];
                    number[i] = number[j];
                    number[j] = temp;
                }

            }
           

        }
        Console.WriteLine("{0}", string.Join(", ", number));
        

    }

}
