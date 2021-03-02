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
            }
            else
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
        public static bool IsDegree2(double esponente, double a)
        {
            if (esponente == 2 && a != 0)
            {
                return true;
            }
            else
                return false;
        }
        public static double Delta(double b, double a, double c)
        {
            double delta = (b * b) - (4 * a * c);
            return delta;
        }
        public static string Soluzioni(double a, double b, double c)
        {

            double delta = Delta(a, b, c);
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return $"x1:{x1}, x2:{x2}";
            }
            else
            {
                return "Impossibile";
            }
        }
        public static string EquationDegree1(double a, double b)
        {

            if (a == 0 && b == 0)
                return "Indeterminato";
            else if (a != 0 && b == 0)
                return "Impossibile";
            else
            {
                double str = b / a;
                return $"{str}";
            }
            
        }
    }
}
