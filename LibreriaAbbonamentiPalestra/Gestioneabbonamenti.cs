using System;

namespace LibreriaAbbonamentiPalestra
{
    public class Gestioneabbonamenti
    {
        public static string Scelta(int mesi)
        {
            double tariffa1 = 115.99, tariffa2 = 99.99, tariffa3 = 79.99;
            if (mesi >= 10&&mesi<=12)
            {
                return $"tariffa3 {tariffa3 * 12}";
            }
            if (mesi < 3)
            {
                double totale = 0;
                if (mesi == 1)
                    totale += tariffa1;
                else
                    totale += (tariffa1 * 2);
                return $"2tariffa1 {totale}";
            }
            if (mesi == 3)
                return $"tariffa2 {tariffa2 * 3}";
            if(mesi>3&& mesi < 6)
            {
                if (mesi == 4)
                {
                    double totale = 0;
                    totale += (tariffa2 * 3) + tariffa1;
                    return $"tariffa2+tariffa1 {totale}";
                }else
                {
                    double totale = 0;
                    totale += (tariffa2 * 3) + (tariffa1*2);
                    return $"tariffa2+2tariffa1 {totale}";
                }
            }
            if (mesi == 6)
                return $"2tariffa2 {tariffa2 * 6}";
            if (mesi > 6 && mesi < 9)
            {
                if (mesi == 7)
                {
                    double totale = 0;
                    totale += (tariffa2 * 6) + tariffa1;
                    return $"2tariffa2+tariffa1 {totale}";
                }
                else
                {
                    double totale = 0;
                    totale += (tariffa2 * 6) + (tariffa1 * 2);
                    return $"2tariffa2+2tariffa1 {totale}";
                }
            }
            if (mesi == 9)
                return $"3tariffa2 {tariffa2 * 9}";
            else
                return "inserire numero mesi valido";

        }
    }
}
