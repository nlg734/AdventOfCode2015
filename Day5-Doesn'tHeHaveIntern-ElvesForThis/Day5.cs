// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string text = Console.ReadLine();

int naughty = 0;
int nice = 0;

while(!string.IsNullOrEmpty(text))
{
    /*
    if(text.Contains("ab") || text.Contains("cd") || text.Contains("pq") || text.Contains("xy"))
    {
        Console.WriteLine("Naughty");
        naughty++;
        text = Console.ReadLine();
        continue;
    }
    if(text.Count(c => "aeiou".Contains(c)) < 3)
    {
        Console.WriteLine("Naughty");
        naughty++;
        text = Console.ReadLine();
        continue;
    }
    bool isNice = false;
    char prev = text[0];
    for(int i = 1; i < text.Length; i++)
    {
        if(prev == text[i])
        {
            Console.WriteLine("Nice");
            isNice = true;
            nice++;
            break;
        }
        prev = text[i];
    }

    if(!isNice)
    {
        Console.WriteLine("Naughty");
    }
    */

    // Check if a letter repeats with a single character in between
    bool repeat = false;
    for(int i =0; i < text.Length-2; i++)
    {
        if(text[i] == text[i+2])
        {
            repeat = true;
            break;
        }
    }

    //check if a pair of letters repeats anywhere without overlap
    bool pair = false;
    var dict = new Dictionary<string, int>();

    for(int i = 0; i < text.Length-1; i++)
    {
        string chars = text[i].ToString() + text[i+1];
        dict.TryGetValue(chars, out int count);
        dict[chars] = count + 1;
    }

    foreach(string key in dict.Keys)
    {
        if(dict[key] > 1)
        {
            int index = text.IndexOf(key);
            int index2 = text.IndexOf(key, index+2);

            if(index2 != -1)
            {
                pair = true;
                break;
            }
        }
    }

    if(pair && repeat)
    {
        nice++;
        Console.WriteLine("Nice");
    }
    else
    {
        naughty++;
        Console.WriteLine("Naughty");
    }

    text = Console.ReadLine();
}

Console.WriteLine(nice);
