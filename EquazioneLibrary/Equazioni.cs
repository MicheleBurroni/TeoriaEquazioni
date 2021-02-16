using System;

namespace EquazioneLibrary
{
    public class Equazioni
    {
        public static bool IsDeterminated(double a)
        {
            if (a != 0)
            {
                return true;
            } else
                return false;
        }
        public static bool IsInconsisted(double a, double b)
        {
            if (a == 0 && b != 0)
            {
                return true;
            }
            else
                return false;

        }
        public static bool IsDegree2(double esponente, double a, )
        {
            if (esponente == 2 && a != 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
