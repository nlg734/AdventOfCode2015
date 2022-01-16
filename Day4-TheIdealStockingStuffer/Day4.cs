/* Author: Natasha Graham
 * Code for Advent of Code 2015, Day 4
 * https://adventofcode.com/2015/day/4
 * Dec 2021
 * Updated: Jan 2022
 */


using System.Security.Cryptography;
using System.Text;


MD5 create_md5 = MD5.Create();
string puzzle = "yzbqklnj";

// Set initial added number to 1. 
int i = 1;
while(true)
{
    // Append integer to puzzle string in new string
    string test = puzzle + i.ToString();

    // Convert to bytes
    byte[] data = Encoding.UTF8.GetBytes(test);

    // create MD5 hash, convert to hex
    byte[] hash = create_md5.ComputeHash(data);
    string final = Convert.ToHexString(hash);

    // If final hex string starts with six zeros, break loop. Otherwise, increment integer by 1
    // Part 1 of the problem asked for a hex that started with five zeros. 
    if(final.StartsWith("000000"))
    {
        Console.WriteLine(final);
        Console.WriteLine(test);
        break;
    }

    i++;
}