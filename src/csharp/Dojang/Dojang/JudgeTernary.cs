public class JudgeTernary
{
    static void Main()
    {
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0}", num % 3 == 0 ? "true" : "false");
    }
}
