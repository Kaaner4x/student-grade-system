namespace öğrenci_not.Model
{
    public class CalculateScore
    {
        public static double Calculate(double midTerm, double final)
        {
            return (midTerm * 0.4) + (final * 0.6);
        }
    }
}
