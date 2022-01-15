/* Author: Natasha Graham
 * Code for Advent of Code 2015, Day 11
 * https://adventofcode.com/2015/day/11
 * Dec 2021
 */

char[] password = Console.ReadLine().ToCharArray();

char[] pass = increment(password, password.Length - 1);

while (true)
{
    if(pass[4] == 'f' && pass[5] == 'f')
    {
        
    }

    if(pass.Contains('i') || pass.Contains('o') || pass.Contains('l'))
    {
        pass = increment(pass, pass.Length - 1);
        continue;
    }

    if(!success(pass))
    {
        pass = increment(pass, pass.Length - 1);
        continue;
    }
    if(!repeat(pass))
    {
        pass = increment(pass, pass.Length - 1);
        continue;
    }

    Console.WriteLine(pass);

    break;
}


char[] increment(char[] pass, int index)
{
    if(index < 0)
    {
        return new char[0];
    }
    if(pass[index] == 'z')
    {
        pass[index] = 'a';
        return increment(pass, index - 1);
    }

    pass[index]++;
    return pass;
}


bool success(char[] pass)
{
    for(int i = 0; i < pass.Length - 2; i++)
    {
        if(pass[i+1] == pass[i] + 1 && pass[i+2] == pass[i] + 2)
        {
            return true;
        }
    }

    return false;
}


bool repeat(char[] pass)
{
    int doubles = 0;
    List<char> c = new List<char>();

    for(int i=0; i < pass.Length-1; i++)
    {
        if(pass[i] == pass[i+1])
        {
            doubles++;
            i++;
            if(!c.Contains(pass[i]))
                c.Add(pass[i]);
        }
    }

    if(c.Count >= 2)
        return true;

    return false;
}


// Part 1 Solution: hxbxxyzz

