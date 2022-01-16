/* Author: Natasha Graham
 * Code for Advent of Code 2015, Day 8
 * https://adventofcode.com/2015/day/8
 * Dec 2021
 * Updated: Jan 2022
 */


string? s = Console.ReadLine();
int code_total = 0;
int str_total = 0;

while(!String.IsNullOrEmpty(s))
{
    code_total += s.Length;

    // str_total += string_parser(s);  // Part 1
    str_total += str_build(s);  // Part 2

    s = Console.ReadLine();
}

Console.WriteLine(code_total);
Console.WriteLine(str_total);
// Console.WriteLine(code_total - str_total);  // Part 1
Console.WriteLine(str_total - code_total);  // Part 2

/// <summary>
/// Parses string to determine number of characters in memory (as in, '\"' becomes one character,
/// "\x27" becomes one character)
/// Returns the number of characters
/// </summary>
int string_parser(string str)
{
    int count = 0;

    for(int i = 1; i< str.Length-1; i++)
    {
        if(str[i] == '\\')
        {
            // Determines if character is hex code for character, adds one to count
            if (str[i + 1] == 'x')
            {
                count++;
                i += 3;
                continue;
            }
            // If the character is a quote " or back slash \, add one to the count
            else if (str[i + 1] == '"' || str[i + 1] == '\\')
            {
                count++;
                i++;
                continue;
            }
        }

        count++;
    }

    return count;
}

// Part 1 solution: 1350

int str_build(string str)
{
    int count = 0;

    count += str.Count(c => c == '"');  // +1 for each " in string
    count += str.Count(c => c == '\\');  // +1 for each \ in string
    count += 2;  // +2 for new quotes
    count += str.Length;   // total length of string

    return count;
}

// Part 2 Solution: 2085

/* Test string
""
"abc"
"aaa\"aaa"
"\x27"
 
 */