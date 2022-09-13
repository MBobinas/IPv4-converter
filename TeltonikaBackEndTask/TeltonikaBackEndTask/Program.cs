using TeltonikaBackEndTask;

var input = ParseInput(args);

if (input is null)
{
    Console.WriteLine("Provided inputs are wrong");
    return;
}

if (input.TryParseNumericValues())
{
    var result = input.GetDifferenceBetweenNumericInputs();
    Console.WriteLine("First IPv4: " + input.FirstInput + " " + "Second IPv4: " + input.SecondInput + " " + "=>" + " " + result);
}
else
{
    Console.WriteLine("Program terminated");
}

Console.ReadKey();


InputInfo ParseInput(string[] args)
{
    return args.Length == 0
        ? GetInputs()
        : ParseArgs(args);
}

InputInfo ParseArgs(string[] args)
{
    if (args.Length != 2)
    {
        Console.WriteLine("Failed to parse arguments");
        return null;
    }

    return new InputInfo()
    {
        FirstInput = args[0],
        SecondInput = args[1]
    };
}

InputInfo GetInputs()
{
    Console.WriteLine("Write first IP address.");
    var firstInput = Console.ReadLine();

    Console.WriteLine("Write second IP address.");
    var secondInput = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(firstInput) || string.IsNullOrWhiteSpace(secondInput))
        return null;

    return new InputInfo()
    {
        FirstInput = firstInput,
        SecondInput = secondInput
    };
}
