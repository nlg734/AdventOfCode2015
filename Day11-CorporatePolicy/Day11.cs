/* Author: Natasha Graham
 * Code for Advent of Code 2015, Day 11
 * https://adventofcode.com/2015/day/11
 * Dec 2021
 * Updated: Jan 2022
 */

// Take in string input, convert to character array
char[] password = Console.ReadLine()!.ToCharArray();

Increment(password, password.Length - 1);


// Loop through each iteration of a password until all three conditions are met
while (true)
{
    // If the password contains i, o, or l, increment the password and restart loop
    if(password.Contains('i') || password.Contains('o') || password.Contains('l'))
    {
        Increment(password, password.Length - 1);
        continue;
    }

    // If the conditions or HasSuccession() is not met, increment password and continue
    if(!HasSuccession(password))
    {
        Increment(password, password.Length - 1);
        continue;
    }

    // If the conditions of Repeats() are not met, increment password and continue
    if(!Repeats(password))
    {
        Increment(password, password.Length - 1);
        continue;
    }

    // All conditions met, write new password, end loop
    Console.WriteLine(password);
    break;
}

/// <summary>
/// Increments the password by 1. The last character is increased by 1, or rolled-over to 'a' when it is 'z' and the
/// next letter is increased similarly. Recursive. 
/// </summary>
static void Increment(char[] pass, int index)
{
    if(index < 0)
    {
        return;
    }
    if(pass[index] == 'z')
    {
        pass[index] = 'a';
        Increment(pass, index - 1);
        return;
    }

    pass[index]++;
    return;
}


/// <summary>
/// Checks if the password string contains a substring that is an increasing sequence of letters of at least length 3. 
/// This is a substring such as "abc", "bcd", up to "xyz", anywhere in the string. 
/// </summary>
static bool HasSuccession(char[] pass)
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


/// <summary>
/// This looks for two sets of repeating letters. A password should have something like "aa" and "zz" anywhere
/// in the string. The sets cannot overlap, as in "aaa" does not count as two sets of repeating letters. 
/// </summary>
static bool Repeats(char[] pass)
{
    List<char> c = new List<char>();

    for(int i=0; i < pass.Length-1; i++)
    {
        if(pass[i] == pass[i+1])
        {
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

// Part 2 Solution - just run the part 1 answer through again. hxcaabcc