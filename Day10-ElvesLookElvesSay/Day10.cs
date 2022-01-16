/* Author: Natasha Graham
 * Code for Advent of Code 2015, Day 10
 * https://adventofcode.com/2015/day/10
 * Dec 2021
 * Updated: Jan 2022
 */


using System.Text;

string? input = Console.ReadLine();

char current;
char prev = input[0];
int count = 1;

// Create new string for 50 iterations
// Part 1 had just 40 iterations
for (int j = 0; j < 50; j++)
{
    StringBuilder new_str = new StringBuilder();
    // Build string by going through each character in the input string
    for (int i = 1; i < input.Length; i++)
    {
        current = input[i];
        // If the character matches the previous character, add to the count
        // this counts up how many times a given digit occurs in a row
        if (current == prev)
        {
            count++;
        }
        // Appends the count and the digit to the new string. So, 111 becomes 31; 111224 becomes 312214
        // Sets up for next digit
        else
        {
            new_str.Append(count.ToString() + prev);
            prev = current;
            count = 1;
        }
    }

    // Set up for next iteration - new string becomes the input,
    // previous character becomes the beginning of the new input
    // reset count to 1
    new_str.Append(count.ToString() + prev);
    input = new_str.ToString();
    prev = input[0];
    count = 1;
}

Console.WriteLine(input.Length);

// 146794 - too low - Part 1 Solution 252594
// Part 2 - 3579328