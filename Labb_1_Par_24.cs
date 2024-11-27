namespace Flygtidsberäknaren_Par_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************************************");

            Console.WriteLine("Hej och välkommen till flygtidsberäknaren!");
            Console.WriteLine();
            Console.WriteLine("Vilket flyg vill du se detaljerad information om? (svara med siffra)");
            Console.Write(" 1. Stockholm - New York \n 2. New York - Stockholm \n 3. Avsluta programmet \n Skriv in ditt val här:"); 

            string input = Console.ReadLine();
            int choice;
            Console.WriteLine("*******************************************************************");
            

            if (int.TryParse(input, out choice))
            {
                int flighttimeH = 7;
                int flighttimeM = 25;
                int timediff = 6;

                int departH, departM, arriveH, arriveM;

                Console.WriteLine("*******************************************************************");

                if (choice == 1)
                {
                    departH = 14;
                    departM = 3;
                    string departtimeSTHML = $"{departH:D2}:{departM:D2}";

                    arriveH = departH + flighttimeH - timediff;
                    arriveM = departM - flighttimeM;

                    if (arriveM < 0)
                    {
                        arriveM += 50;
                       
                    }

                    Console.WriteLine($"Avgångstid från Stockholm: {departtimeSTHML}");
                    Console.WriteLine($"Ankomsttid till New York: {arriveH}:{arriveM}");
                }

                else if (choice == 2)
                {
                    departH = 10;
                    departM = 10;
                    string departtimeNY = $"{departH:D2}:{departM:D2}";

                    arriveH = departH + flighttimeH + timediff;
                    arriveM = departM + flighttimeM;

                    if (arriveM >= 60)
                    {
                        arriveM -= 60;
                      
                    }

                    Console.WriteLine($"Avgångstid från New York: {departtimeNY}");
                    Console.WriteLine($"Ankomsttid till Stockholm: {arriveH}:{arriveM}");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Hejdå:)");
                    Environment.Exit(0);


                }

                Console.WriteLine("*******************************************************************");
            }


        }
    }
}
