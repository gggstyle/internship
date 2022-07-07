// See https://aka.ms/new-console-template for more information
class Money
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input Pay");
        int price = int.Parse(Console.ReadLine()!);
        
        if(price <= 1000)
        {
            int money = 1000 - price;
            int[] pay = new int[6];

            int[] numpay = new int[] { 500, 100, 50, 10, 5,1 };
            for (int i = 0; i < pay.Length; i++)
            {
                pay[i] = money / numpay[i];
                money = money % numpay[i];
            }
            Console.WriteLine("500 is : " + pay[0]);
            Console.WriteLine("100 is : " + pay[1]);
            Console.WriteLine("50 is : " + pay[2]);
            Console.WriteLine("10 is : " + pay[3]);
            Console.WriteLine("5 is : " + pay[4]);
            Console.WriteLine("1 is : " + pay[5]);
            


        }
    }
}
