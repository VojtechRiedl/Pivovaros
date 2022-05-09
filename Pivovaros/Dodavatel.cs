using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovaros
{
    internal class Dodavatel
    {
        private static Random rd = new Random();
        public static void Dodavka()
        {
            if(Pivovar.MameDostatekPivca() && Hospoda.PotrebujemePivco())
            {
                for (int i = 0; i <= 5; i++)
                {
                    int randomPivko = rd.Next(Hospoda.pivoSklad.Count);
                    string index = Hospoda.pivoSklad.Keys.ElementAt(randomPivko);
                    if (index == "10" && Pivovar.MameDostatekPivca(index))
                    {
                        Hospoda.pivoSklad["10"] += 1;
                        Pivovar.OdeberPivko("Pivo 10°");
                    }
                    else if (index == "11" && Pivovar.MameDostatekPivca(index))
                    {
                        Hospoda.pivoSklad["11"] += 1;
                        Pivovar.OdeberPivko("Pivo 11°");

                    }
                    else if (index == "12" && Pivovar.MameDostatekPivca(index))
                    {
                        Hospoda.pivoSklad["12"] += 1;
                        Pivovar.OdeberPivko("Pivo 12°");

                    }
                }
            }
        }

    }
}
