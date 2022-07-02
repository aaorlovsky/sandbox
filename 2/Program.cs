var countOfSets = int.Parse(Console.ReadLine()!);

for (var i = 0; i < countOfSets; i++)
{
    var countOfGoods = Console.ReadLine();
    var collection = Console.ReadLine()!.Split(' ')
                    .Select(el => int.Parse(el)).ToArray();
    int sum = 0;
    foreach (var good in collection.GroupBy(el => el)
                        .Select(group => new
                        {
                            Price = group.Key,
                            Count = group.Count()
                        }))
    {
        sum += good.Price * (good.Count - (int)(good.Count / 3));
    }
    Console.WriteLine(sum);
}
