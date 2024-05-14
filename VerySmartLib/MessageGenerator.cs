namespace VerySmartLib;

public class MessageGenerator
{
    private readonly NumberCalculator _numberCalculator = new NumberCalculator();
    public string GetMessage() => "Hello from VerySmartLib!";

    public string GetVerySmartMessage() => "Hello from VerySmartLib! I'm very smart!";
}