/* Author: Natasha Graham
 * Code for Advent of Code 2015, Day 6
 * https://adventofcode.com/2015/day/6
 * Dec 2021
 * Updated: Jan 2022
 */


int[,] lights = new int[1000,1000];
string input = Console.ReadLine();

do
{
    // Contains an action and range of lights in [0,0] to [999,999]
    string[] instructions = input.Split(' ');

    // When instruction is "toggle", increase light brightness by 2
    // In Part 1, this turned off on-lights, turned on off-lights. 
    if (instructions[0] == "toggle")
    {
        string[] start = instructions[1].Split(",");
        int start_x = int.Parse(start[0]);
        int start_y = int.Parse(start[1]);

        string[] end = instructions[3].Split(",");
        int end_x = int.Parse(end[0]);
        int end_y = int.Parse(end[1]);

        for (int i = start_x; i <= end_x; i++)
        {
            for (int j = start_y; j <= end_y; j++)
            {
                /* 
                if (lights[i, j] == 0) { lights[i, j] = 1; }
                else { lights[i, j] = 0; }
                */
                lights[i, j] += 2;
            }
        }
    }
    // When the instruction is "on", turn up brightness by 1
    // In part 1, this turned on any off lights in the range
    else if (instructions[1] == "on")
    {
        string[] start = instructions[2].Split(",");
        int start_x = int.Parse(start[0]);
        int start_y = int.Parse(start[1]);

        string[] end = instructions[4].Split(",");
        int end_x = int.Parse(end[0]);
        int end_y = int.Parse(end[1]);

        for (int i = start_x; i <= end_x; i++)
        {
            for (int j = start_y; j <= end_y; j++)
            {
                lights[i, j] += 1;
            }
        }
    }
    // The Instruction is "off". Decreases brightness by 1.
    // In Part 1, this turned off lights in the range. 
    else
    {
        string[] start = instructions[2].Split(",");
        int start_x = int.Parse(start[0]);
        int start_y = int.Parse(start[1]);

        string[] end = instructions[4].Split(",");
        int end_x = int.Parse(end[0]);
        int end_y = int.Parse(end[1]);

        for (int i = start_x; i <= end_x; i++)
        {
            for (int j = start_y; j <= end_y; j++)
            {
                if(lights[i, j] == 0) { continue; }
                lights[i, j] -= 1;
            }
        }
    }

    input = Console.ReadLine();
} while (!String.IsNullOrEmpty(input));

// Determine total brightness and print
// Part 1, this was total lights on
int sum = lights.Cast<int>().Sum();
Console.WriteLine(sum);