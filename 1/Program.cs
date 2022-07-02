//Linq
var numberOfCount = int.Parse(Console.ReadLine());
for (int i = 0; i < numberOfCount; i++)
{
    var set = Console.ReadLine().Split(' ').Select(el => int.Parse(el));
    Console.WriteLine(set.Sum());
}

/*int numberOfCount = int.Parse(Console.ReadLine());
string[] set = new string[numberOfCount];

for (int i = 0; i < numberOfCount; i++)
{
    set[i] = Console.ReadLine();
}

for (int i = 0; i < numberOfCount; i++)
{
    int sum = 0;
    foreach (string num in set[i].Split(' '))
    {
        sum += int.Parse(num);
    }
    Console.WriteLine(sum);
}*/


