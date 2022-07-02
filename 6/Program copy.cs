/*var numberOfSets = int.Parse(Console.ReadLine()!);
Dictionary<int, bool> seats = new Dictionary<int, bool>();

for (var i = 0; i < numberOfSets; i++)
{
    Console.ReadLine();
    var collection = Console.ReadLine()!.Split(' ').Select(el => int.Parse(el)).ToArray();

    for (var j = 0; j < (collection.First() * 2); j++)
    {
        seats.Add(j + 1, false);
    }

    for (var j = 0; j < collection.Last(); j++)
    {
        var command = Console.ReadLine()!.Split(' ');

        switch (int.Parse(command.First()))
        {
            case 1:
                {
                    if (seats[int.Parse(command.Last())])
                    {
                        Console.WriteLine("FAIL");
                    }
                    else
                    {
                        Console.WriteLine("SUCCESS");
                        seats[int.Parse(command.Last())] = true;
                    }
                    break;
                }
            case 2:
                {
                    if (seats[int.Parse(command.Last())])
                    {
                        Console.WriteLine("SUCCESS");
                        seats[int.Parse(command.Last())] = false;
                    }
                    else
                    {
                        Console.WriteLine("FAIL");
                    }
                    break;
                }
            case 3:
                {
                    var k = 1;
                    while (true)
                    {
                        if (!seats[k] && !seats[k + 1])
                        {
                            seats[k] = true;
                            seats[k + 1] = true;
                            Console.WriteLine($"SUCCESS {k}-{k + 1}");
                            break;
                        }
                        k = k + 2;
                        if (k == seats.Count() + 1)
                        {
                            Console.WriteLine($"FAIL");
                            break;
                        }
                    }
                }
                break;
            default:
                break;
        }
    }
    seats.Clear();
    Console.WriteLine();
}*/