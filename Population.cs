using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            int countyears = 0;
            while (initialPopulation < currentPopulation)
            {
                initialPopulation += Convert.ToInt32(initialPopulation / 100 * percent)+visitors;
                countyears++;
            }
            return countyears;
        }
    }
}
