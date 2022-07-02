
var numberOfSets = int.Parse(Console.ReadLine()!);

for (var i = 0; i < numberOfSets; i++)
{
    var numberOfRecords = int.Parse(Console.ReadLine()!);

    IList<string> records = new List<string>();
    for (var j = 0; j < numberOfRecords; j++)
    {
        string collection = Console.ReadLine()!;
        records.Add(collection);
    }

    HashSet<string> reverseHashSet = new HashSet<string>(records.Reverse());

    Lookup<string, string> lookup = (Lookup<string, string>)reverseHashSet.Select(l => l.Split(' ').ToArray())
    .OrderBy(p => p.First()).ToLookup(p => p.First(), p => p.Last());
    foreach (IGrouping<string, string> abonentGroup in lookup)
    {
        Console.Write($"{abonentGroup.Key}: {abonentGroup.Take(5).Count()}");

        foreach (string str in abonentGroup.Take(5))
        {
            Console.Write(" {0}", str);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

