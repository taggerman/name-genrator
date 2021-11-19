using System;

namespace name_genrator
{
    class Program
    {
        static string[] firstNames = new string[20];
        static string[] lastNames = new string[20];
        static string[] work = new string[20];
        static void Main(string[] args)
        {

            //firstNames
            firstNames[0] = "Adam";
            firstNames[1] = "Mille";
            firstNames[2] = "Jens";
            firstNames[3] = "Tage";
            firstNames[4] = "Bo";
            firstNames[5] = "Liva";
            firstNames[6] = "Sylvester";
            firstNames[7] = "Benjamin";
            firstNames[8] = "Emil";
            firstNames[9] = "Elina";
            firstNames[10] = "Malou";
            firstNames[11] = "Luna";
            firstNames[12] = "Anton";
            firstNames[13] = "Ditte";
            firstNames[14] = "Noah";
            firstNames[15] = "Kri";
            firstNames[16] = "Topz";
            firstNames[17] = "Jokke";
            firstNames[18] = "Jonas";
            firstNames[19] = "Mads";
            //last Names
            lastNames[0] = "Petersen";
            lastNames[1] = "Jensen";
            lastNames[2] = "Falk";
            lastNames[3] = "Sørnsen";
            lastNames[4] = "Hansen";
            lastNames[5] = "Ravn";
            lastNames[6] = "Kristiansen";
            lastNames[7] = "Stensen";
            lastNames[8] = "Vermund";
            lastNames[9] = "Frederiksen";
            lastNames[10] = "Møller";
            lastNames[11] = "Brun";
            lastNames[12] = "Nors";
            lastNames[13] = "Magnusen";
            lastNames[14] = "Parker";
            lastNames[15] = "Larsen";
            lastNames[16] = "Gaard";
            lastNames[17] = "Smed";
            lastNames[18] = "Karlsen";
            lastNames[19] = "Mikkelsen";
            //arbejde
            work[0] = "Brandmand";
            work[1] = "Tømmer";
            work[2] = "VVS";
            work[3] = "Mure";
            work[4] = "elektriker";
            work[5] = "Læge";
            work[6] = "Sygeplejerske";
            work[7] = "Lære";
            work[8] = "Slagter";
            work[9] = "Astronaut";
            work[10] = "Bager";
            work[11] = "Diktator";
            work[12] = "Pilot";
            work[13] = "Bil Sælger";
            work[14] = "Kok";
            work[15] = "fisker";
            work[16] = "tjæner";
            work[17] = "Skraldemand";
            work[18] = "Dykker";
            work[19] = "Soldat";



            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine(firstNames[GenrateRandomIndex(firstNames)] + " "+ lastNames[GenrateRandomIndex(lastNames)] + " " + work[GenrateRandomIndex(work)]);
            }


        }

        static int GenrateRandomIndex(string[] arr)
        {
            Random random = new Random();
            return random.Next(0, arr.Length);
        }
    }
}
