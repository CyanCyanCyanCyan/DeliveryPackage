// See https://aka.ms/new-console-template for more information
namespace PackageDelivery 
{ 
    class Program 
    {
        public static void Main(string[] args)
        {
            Calculations c1 = new Calculations();
            Console.WriteLine("Please enter the weight of your package in kg: ");
            c1.Weight=Console.ReadLine();
            Console.WriteLine("Please enter the height of your package in cm: ");
            c1.Height=Console.ReadLine();
            Console.WriteLine("Please enter the length of your package in cm: ");
            c1.Length=Console.ReadLine();
            Console.WriteLine("Please enter the width of your package in cm: ");
            c1.Width=Console.ReadLine();
        }
    }
}


    