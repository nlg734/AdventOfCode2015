// See https://aka.ms/new-console-template for more information

using System.Linq;

int[,] lights = new int[1000,1000];
string input = Console.ReadLine();

do
{
    string[] instructions = input.Split(' ');
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

int sum = lights.Cast<int>().Sum();

Console.WriteLine(sum);