/* Author: Natasha Graham
 * Code for Advent of Code 2015, Day 14
 * https://adventofcode.com/2015/day/14
 * Jul 2022
 */



Int32 Rudolph(int sec)
{
    int dist = 0;

    while (sec > 0 && sec > 8)
    {
        dist += 22 * 8;
        sec -= 8;

        if (sec < 165)
        {
            return dist;
        }

        sec -= 165;
    }

    return dist + (22 * sec);
}


Int32 Cupid(int sec)
{
    int dist = 0;

    while (sec > 0 && sec > 17)
    {
        dist += 8 * 17;
        sec -= 17;

        if (sec < 114)
        {
            return dist;
        }

        sec -= 114;
    }

    return dist + (8 * sec);
}


Int32 Prancer(int sec)
{
    int dist = 0;

    while (sec > 0 && sec > 6)
    {
        dist += 18 * 6;
        sec -= 6;

        if (sec < 103)
        {
            return dist;
        }

        sec -= 103;
    }

    return dist + (18 * sec);
}


Int32 Donner(int sec)
{
    int dist = 0;

    while (sec > 0 && sec > 6)
    {
        dist += 25 * 6;
        sec -= 6;

        if (sec < 145)
        {
            return dist;
        }

        sec -= 145;
    }

    return dist + (25 * sec);
}


Int32 Dasher(int sec)
{
    int dist = 0;

    while (sec > 0 && sec > 12)
    {
        dist += 11 * 12;
        sec -= 12;

        if (sec < 125)
        {
            return dist;
        }

        sec -= 125;
    }

    return dist + (11 * sec);
}


Int32 Comet(int sec)
{
    int dist = 0;

    while(sec > 0 && sec > 6)
    {
        dist += 21 * 6;
        sec -= 6;

        if(sec < 121)
        {
            return dist;
        }

        sec -= 121;
    }

    return dist + (21 * sec);
}


Int32 Blitzen(int sec)
{
    int dist = 0;

    while (sec > 0 && sec > 3)
    {
        dist += 18 * 3;
        sec -= 3;

        if (sec < 50)
        {
            return dist;
        }

        sec -= 50;
    }

    return dist + (18 * sec);
}


Int32 Vixen(int sec)
{
    int dist = 0;

    while (sec > 0 && sec > 4)
    {
        dist += 20 * 4;
        sec -= 4;

        if (sec < 75)
        {
            return dist;
        }

        sec -= 75;
    }

    return dist + (20 * sec);
}


Int32 Dancer(int sec)
{
    int dist = 0;

    while (sec > 0 && sec > 20)
    {
        dist += 7 * 20;
        sec -= 20;

        if (sec < 119)
        {
            return dist;
        }

        sec -= 119;
    }

    return dist + (7 * sec);
}


int time = Int32.Parse(Console.ReadLine());

Console.WriteLine("Rudolph: " + Rudolph(time));
Console.WriteLine("Cupid: " + Cupid(time));
Console.WriteLine("Prancer: " + Prancer(time));
Console.WriteLine("Donner: " + Donner(time));
Console.WriteLine("Dasher: " + Dasher(time));
Console.WriteLine("Dancer: " + Dancer(time));
Console.WriteLine("Comet: " + Comet(time));
Console.WriteLine("Blitzen: " + Blitzen(time));
Console.WriteLine("Vixen: " + Vixen(time));