namespace TemperatureApplication
{
    internal class Program
    {

       
        static void Main(string[] args)
        {
            Random r = new Random();


            Alarm a = new Alarm();

            a.SomethingHappend += A_SomethingHappend;
           
            for (int i = 0; i < 10; i++)
            {
                int t = r.Next(1, 18);
                Console.WriteLine( t);
                a.Temperature = t;
                Thread.Sleep(1000);

            }

            Console.ReadKey();
        }

        private static void A_SomethingHappend()
        {
            Console.WriteLine("Something happend");
        }
    }
}
