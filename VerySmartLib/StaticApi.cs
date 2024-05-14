namespace VerySmartLib;

public static class StaticApi
{
    public static string GetMessage()
    {
        var msg = new MessageGenerator();
        return msg.GetMessage();
    }

    public static long CalculateFibonacci(int n)
    {
        var cal = new NumberCalculator();
        return cal.CalculateFibonacci(n);
    }
}