// See https://aka.ms/new-console-template for more information
namespace PackageDelivery 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Calculations c1 = new Calculations();
            Console.WriteLine("Please enter the weight of your package in kg: ");
            c1.Weight=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the height of your package in cm: ");
            c1.Height=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the length of your package in cm: ");
            c1.Length=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the width of your package in cm: ");
            c1.Width=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(c1.Description);
        }
    }
}