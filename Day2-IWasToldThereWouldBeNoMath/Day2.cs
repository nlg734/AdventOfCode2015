// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter the Dimensions:");

long paper_total = 0;
long ribbon_total = 0;

while (true)
{
    string? dim = Console.ReadLine();

    if (string.IsNullOrEmpty(dim))
    {
        break;
    }

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
}

Console.WriteLine(paper_total);
Console.WriteLine(ribbon_total);