using System;
namespace uppgift5._1
{
    class program
    {
        static void Main(string[] args)
        {
            string[] meningar = new string[5];

            meningar[0] = "Hej där.";
            meningar[1] = "Hur mår du idag?";
            meningar[2] = "Vad är din favorit mat?";
            meningar[3] = "Vilket fint väder vi har idag.";
            meningar[4] = "Du tittar på en datorskärm just nu.";


            for (int i = 0; i < meningar.Length; i++)
            {
                Console.WriteLine(meningar[i]);
                Console.WriteLine("");
            }
        }
    }
}