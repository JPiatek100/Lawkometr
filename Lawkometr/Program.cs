namespace Lawkometr
{
    /*
    todo:
    obliczanie rozkładu
    defaulty
    kombinacje  


    */

    internal class Program
    {
        static void Main(string[] args)
        {
            GetData.GetHour("podaj godzinę startu [hh mm]: ");
            int startTimeHours = GetData.hours, startTimeMinutes = GetData.minutes;
            GetData.GetHour("podaj godzinę zakończenia [hh mm]: ");
            int endTimeHours = GetData.hours, endTimeMinutes = GetData.minutes;
            bool useDefaults = GetData.GetDefault("Czy użyć wartości domyślnych? [y/n]");


            int time = endTimeMinutes + endTimeHours*60 - startTimeHours*60 + startTimeMinutes; // międzyczas [min] = time

            //defaults:
            int waga = 53; // [kg]
            double wk = 0.7D; // współczynnik K
            double wr = 9; // Szybkość rozkładu gram ma minutę

            if (!useDefaults)
            {
                waga = GetData.GetVar("Waga [kg]: ");
                wr = GetData.GetVar("Szybkość rozkładu [g/min]");
            }


            //calc
            double ileGram = Math.Round((double)time / 60 * wr, 2);
            double ileWod = Math.Round((double)ileGram / 20, 2);
            double ileSet = Math.Round((double)ileGram / 30, 2);
            double ilePiw = Math.Round((double)ileGram / 26, 2);



            //imput
            Console.WriteLine();
            Console.WriteLine("Dziś można " + ileGram + " gram:");
            Console.WriteLine("[" + ileWod*50 + "ml] " + ileWod + " kieliszków (50ml 40%)");
            Console.WriteLine("[" + ileSet*100 + "ml] " + ileSet + " setek (100ml 30%)");
            Console.WriteLine("[" + ilePiw*400 + "ml] " + ilePiw + " piw (400ml 6%)");
            Console.WriteLine();
            Console.WriteLine("Optymalnie: ");



        }
    }



}