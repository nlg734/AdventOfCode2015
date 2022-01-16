/* Author: Natasha Graham
 * Code for Advent of Code 2015, Day 2
 * https://adventofcode.com/2015/day/2
 * Dec 2021
 * Updated: Jan 2022
 */


Console.WriteLine("Enter the Dimensions:");


// Initial wrapping paper area, ribbon length
long paper_total = 0;
long ribbon_total = 0;

string? dim = Console.ReadLine();

// For each line of input, determine the side lengths, the area of the paper
// needed, and the length of ribbon needed, and add the paper and ribbon to the totals
while (!string.IsNullOrEmpty(dim))
{
    string[] sides = dim.Split('x');
    int l = int.Parse(sides[0]);
    int w = int.Parse(sides[1]);
    int h = int.Parse(sides[2]);

    int lw = 2 * l * w;
    int wh = 2 * w * h;
    int hl = 2 * h * l;

    int min = Math.Min(hl, Math.Min(wh, lw)) / 2;

    int box = lw + wh + hl + min;
    paper_total += box;

    ribbon_total += l * w * h;
    int min2 = Math.Min(2*l+2*w, Math.Min(2*w+2*h, 2*l+2*h));
    ribbon_total += min2;

    dim = Console.ReadLine();
}

Console.WriteLine(paper_total);
Console.WriteLine(ribbon_total);