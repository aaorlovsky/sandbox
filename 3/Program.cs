var numberOfSets = int.Parse(Console.ReadLine()!.Trim());
IList<IList<IList<int>>> resultTables = new List<IList<IList<int>>>();

for (var i = 0; i < numberOfSets; i++)
{
    Console.ReadLine();
    var tableDimention = Console.ReadLine()!.Split(' ');
    var rowCount = int.Parse(tableDimention.First());
    var columnCount = int.Parse(tableDimention.Last());

    IList<IList<int>> table = new List<IList<int>>();

    for (var j = 0; j < rowCount; j++)
    {
        table.Add(Console.ReadLine()!.Split(' ').Select(el => int.Parse(el)).ToList());
    }

    var numberOfClicks = int.Parse(Console.ReadLine()!);

    var numberOfColumns = Console.ReadLine()!.Split(' ').Select(el => int.Parse(el)).ToArray();

    for (var j = 0; j < numberOfClicks; j++)
    {
        Dictionary<int, int> col = new Dictionary<int, int>();
        for (var k = 0; k < rowCount; k++)
        {
            col.Add(k, table.ElementAt(k).ElementAt(numberOfColumns[j] - 1));
        }
        Dictionary<int, int> sortCol = col.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        IList<IList<int>> sortTable = new List<IList<int>>();
        for (var h = 0; h < sortCol.Count(); h++)
        {
            sortTable.Add(table.ElementAt(sortCol.Keys.ElementAt(h)));
        }
        table = sortTable;
    }

    resultTables.Add(table);
}

foreach (var table in resultTables)
{
    for (int j = 0; j < table.Count(); j++)
    {
        for (int k = 0; k < table.ElementAt(j).Count(); k++)
        {
            Console.Write(table.ElementAt(j).ElementAt(k));
            if (k != table.ElementAt(j).Count() - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
