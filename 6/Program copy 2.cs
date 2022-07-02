/*var numberOfSets = int.Parse(Console.ReadLine()!);
HashSet<int> seats = new HashSet<int>();

for (var i = 0; i < numberOfSets; i++)
{
    Console.ReadLine();
    var collection = Console.ReadLine()!.Split(' ').Select(el => int.Parse(el)).ToArray();

    for (var j = 0; j < collection.Last(); j++)
    {
        var command = Console.ReadLine()!.Split(' ');

        switch (int.Parse(command.First()))
        {
            case 1:
                {
                    if (seats.Contains(int.Parse(command.Last())))
                    {
                        Console.WriteLine("FAIL");
                    }
                    else
                    {
                        Console.WriteLine("SUCCESS");
                        seats.Add(int.Parse(command.Last()));
                    }
                    break;
                }
            case 2:
                {
                    if (seats.Contains(int.Parse(command.Last())))
                    {
                        Console.WriteLine("SUCCESS");
                        seats.Remove(int.Parse(command.Last()));
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
                        if (!seats.Contains(k) && !seats.Contains(k + 1))
                        {
                            seats.Add(k);
                            seats.Add(k + 1);
                            Console.WriteLine($"SUCCESS {k}-{k + 1}");
                            break;
                        }
                        k = k + 2;
                        if (k == (collection.First() * 2) + 1)
                        {
                            Console.WriteLine("FAIL");
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