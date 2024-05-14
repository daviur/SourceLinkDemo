namespace VerySmartLib;

public class NumberCalculator
{
    public long CalculateFibonacci(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("n must be greater than or equal to 0", nameof(n));
        }

        return Fibonacci(n);
    }

    private long Fibonacci(int i)
    {
        if (i == 0)
        {
            return 0;
        }

        if (i == 1)
        {
            return 1;
        }

        return Fibonacci(i - 1) + Fibonacci(i - 2);
    }
}