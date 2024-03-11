namespace justmath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rakamlarinin toplamini istediginiz sayiyi giriniz: ");
            int n = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine($"{n} sayinin rakamlari toplami = {math.RakamToplam(n)}");
        }
    }
}