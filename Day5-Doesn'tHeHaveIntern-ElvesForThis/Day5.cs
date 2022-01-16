/* Author: Natasha Graham
 * Code for Advent of Code 2015, Day 5
 * https://adventofcode.com/2015/day/5
 * Dec 2021
 * Updated: Jan 2022
 */

string text = Console.ReadLine();

int naughty = 0;
int nice = 0;

while(!string.IsNullOrEmpty(text))
{
    /* Part 1
    
    // If the string contains ab, cd, pq, or xy, is is naughty
    if(text.Contains("ab") || text.Contains("cd") || text.Contains("pq") || text.Contains("xy"))
    {
        Console.WriteLine("Naughty");
        naughty++;
        text = Console.ReadLine();
        continue;
    }

    // If the strings doesn't have at least 3 vowels, it is naughty
    if(text.Count(c => "aeiou".Contains(c)) < 3)
    {
        Console.WriteLine("Naughty");
        naughty++;
        text = Console.ReadLine();
        continue;
    }

    // Check is at least one letter appears twice in a row
    // isNice becomes true when that happens
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

    // When isNice is flase, the string is naughty
    if(!isNice)
    {
        Console.WriteLine("Naughty");
        naughty++;
    }
    */


    // Part 2
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

    // Create dictionary of 2 character substrings
    for(int i = 0; i < text.Length-1; i++)
    {
        string chars = text[i].ToString() + text[i+1];
        dict.TryGetValue(chars, out int count);
        dict[chars] = count + 1;
    }

    // For each substring, see if it appears twice
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

    // When both conditions are met, the string is nice
    // else it is naughty
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
