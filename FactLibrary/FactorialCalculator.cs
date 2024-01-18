namespace FactLibrary;

public class FactorialCalculator
{
    public long Calculate(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Factorial is not defined for negative numbers.");
        }

        if (number == 0 || number == 1)
        {
            return 1;
        }

        long result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }
}

