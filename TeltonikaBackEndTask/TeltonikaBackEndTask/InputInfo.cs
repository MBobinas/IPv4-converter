namespace TeltonikaBackEndTask;

public class InputInfo
{
    private const int BitRate = 256;
    public string FirstInput { get; set; }
    public string SecondInput { get; set; }
    public long FirstInputNumeric { get; set; }
    public long SecondInputNumeric { get; set; }

    public bool TryParseNumericValues()
    {
        var startNumbers = FirstInput.Split(".");
        var endNumbers = SecondInput.Split(".");

        if (AreInputsValid(startNumbers, endNumbers))
        {
            FirstInputNumeric = Parse(startNumbers);
            SecondInputNumeric = Parse(endNumbers);

            return true;
        }

        Console.WriteLine("Problem getting IP address values");

        return false;
    }

    private static long Parse(string[] numbers)
    {
        long result = 0;

        foreach (var number in numbers)
        {
            var status = long.TryParse(number, out var realNumber);

            if (status)
                result = result * BitRate + realNumber;
        }

        return result;
    }

    public long GetDifferenceBetweenNumericInputs()
    {
        return SecondInputNumeric - FirstInputNumeric;
    }

    public bool AreInputsValid(string[] startNumbers, string[] endNumbers)
    {
        if (startNumbers.Length != 4 || endNumbers.Length != 4)
        {
            Console.WriteLine("Invalid IPs: incorrect IPs length");

            return false;
        }

        if (FirstInputNumeric > SecondInputNumeric)
        {
            Console.WriteLine("The first IP address cannot be greater than last");

            return false;
        }

        for (var x = 0; x < 4; x++)
        {
            if (!isNumeric(startNumbers[x]) || !isNumeric(endNumbers[x])
                || long.Parse(startNumbers[x]) < 0 || long.Parse(startNumbers[x]) > 255 ||
                long.Parse(endNumbers[x]) < 0 || long.Parse(endNumbers[x]) > 255)
                return false;
        }

        return true;
    }

    private static bool isNumeric(string str)
    {
        if (str == null || str.Equals(""))
        {
            Console.WriteLine("String cannot be parsed, it is null or empty.");

            return false;
        }

        return double.TryParse(str, out var result);
    }
}
