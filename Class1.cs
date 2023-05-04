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
            if(c1.Weight>29.9)
            {
                if(c1.Volume>100000)
                {
                    Console.WriteLine("Your package is too big, and too heavy.");
                }
                else
                {
                    Console.WriteLine("Your package is too heavy, but not too big.");
                }
            }
            else
            {
                if(c1.Volume>100000)
                {
                    Console.WriteLine("Your package is too big, but not too heavy.");
                }
                else
                {
                    Console.WriteLine("Your package is good to go.");
                }
            }
            
        }
    }
}