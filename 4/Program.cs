using System.Text.RegularExpressions;

var numberOfSets = int.Parse(Console.ReadLine()!);
string pattern = @"^[0-9a-zA-Z_][0-9a-zA-Z_-]{1,23}$";

for (var i = 0; i < numberOfSets; i++)
{
    IList<string> tries = new List<string>();
    var numberOfTries = int.Parse(Console.ReadLine()!);
    for (var j = 0; j < numberOfTries; j++)
    {
        tries.Add(Console.ReadLine()!);
    }

    HashSet<string> successList = new HashSet<string>();
    foreach (string elem in tries)
    {
        if (Regex.IsMatch(elem, pattern) && !successList.Contains(elem.ToLower()))
        {
            Console.WriteLine("Yes");
            successList.Add(elem.ToLower());
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    Console.WriteLine();
}

