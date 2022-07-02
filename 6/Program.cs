var numberOfSets = int.Parse(Console.ReadLine()!);

for (var i = 0; i < numberOfSets; i++)
{
    Console.ReadLine();
    Dictionary<int, bool> seats = new Dictionary<int, bool>();
    SortedSet<int> freeCoupes = new SortedSet<int>();

    var collection = Console.ReadLine()!.Split(' ').Select(el => int.Parse(el)).ToArray();
    var coupeCount = collection.First();
    var commandCount = collection.Last();

    for (var j = 0; j < coupeCount; j++)
    {
        seats.Add(2 * j + 1, true);
        seats.Add(2 * j + 2, true);
        freeCoupes.Add(j);
    }

    for (var j = 0; j < commandCount; j++)
    {

        var command = Console.ReadLine()!.Split(' ').Select(el => int.Parse(el)).ToArray();
        var cmdNumber = command.First();
        var cmdSeat = command.LastOrDefault();


        if (cmdNumber == 1)
        {
            if (seats[cmdSeat])
            {
                Console.WriteLine("SUCCESS");
                seats[cmdSeat] = false;
                var coupe = cmdSeat % 2 == 0 ? (cmdSeat - 2) / 2 : (cmdSeat - 1) / 2;
                freeCoupes.Remove(coupe);
            }
            else
            {
                Console.WriteLine("FAIL");
            }
        }
        else if (cmdNumber == 2)
        {
            if (seats[cmdSeat])
            {
                Console.WriteLine("FAIL");
            }
            else
            {
                Console.WriteLine("SUCCESS");
                seats[cmdSeat] = true;
                var secondSeat = cmdSeat % 2 == 0 ? cmdSeat - 1 : cmdSeat + 1;
                var coupe = cmdSeat % 2 == 0 ? (cmdSeat - 2) / 2 : (cmdSeat - 1) / 2;
                if (seats[cmdSeat] && seats[secondSeat])
                {
                    freeCoupes.Add(coupe);
                }
            }
        }
        else
        {
            var min = freeCoupes.Count() == 0 ? -1 : freeCoupes.Min;
            if (min >= 0)
            {
                Console.WriteLine($"SUCCESS {2 * min + 1}-{2 * min + 2}");
                seats[2 * min + 1] = false;
                seats[2 * min + 2] = false;
                freeCoupes.Remove(min);
            }
            else
            {
                Console.WriteLine("FAIL");
            }
        }
    }
    Console.WriteLine();
}