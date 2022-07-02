var numberOfSets = int.Parse(Console.ReadLine()!);

for (var i = 0; i < numberOfSets; i++)
{
    Console.ReadLine();
    Dictionary<string, HashSet<string>> modulDep = new Dictionary<string, HashSet<string>>();
    HashSet<string> buildString = new HashSet<string>();
    var operations = 0;
    string result = string.Empty;
    var numberOfModuls = int.Parse(Console.ReadLine()!);

    for (var j = 0; j < numberOfModuls; j++)
    {
        var modul = Console.ReadLine()!.Split(":").ToArray();
        modulDep.Add(modul.First(), modul.Last().Trim().Split(" ").ToHashSet());
    }

    var numberOfBuilds = int.Parse(Console.ReadLine()!);
    for (var j = 0; j < numberOfBuilds; j++)
    {
        operations = 0;
        result = string.Empty;
        var modul = Console.ReadLine()!;
        buildModule(modul);
        result = $"{operations} " + result;
        Console.WriteLine(result.Trim());
    }

    Console.WriteLine();


    void buildModule(string modulName)
    {
        if (buildString.Contains(modulName))
        {
            return;
        }

        if (string.IsNullOrEmpty(modulDep[modulName].First()))
        {
            if (!buildString.Contains(modulName))
            {
                buildString.Add(modulName);
                result += modulName + " ";
                operations++;
            }
            return;
        }

        foreach (string modulDepString in modulDep[modulName])
        {
            buildModule(modulDepString);
        }

        if (modulDep[modulName].All(item => buildString.Contains(item)))
        {
            buildString.Add(modulName);
            result += modulName + " ";
            operations++;
        }
    }
}




