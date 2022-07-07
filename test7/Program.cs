// See https://aka.ms/new-console-template for more information
class Time
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input Second");
        int num = int.Parse(Console.ReadLine()!);
        int hours = (num / 60)/60;
        int minutes = (num / 60)%60;
        int seconds = num % 60;
        Console.WriteLine("{0:D2}:{1:D2}:{2:D2}",hours,minutes,seconds);
    }
}
