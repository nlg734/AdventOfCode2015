// See https://aka.ms/new-console-template for more information

string input = Console.ReadLine();
var wires = new Dictionary<string, UInt16>();
while (!String.IsNullOrEmpty(input))
{
    if (input.Contains("AND"))
    {
        string[] values = input.Split(' ');
        string out_wire = values[4];
        bool l = wires.TryGetValue(values[0], out UInt16 left);
        bool r = wires.TryGetValue(values[2], out UInt16 right);

        if (!l)
        {
            left = UInt16.Parse(values[0]);
        }
        if (!r)
        {
            right = UInt16.Parse(values[2]);
        }

        wires[out_wire] = (UInt16)(left & right);
    }
    else if (input.Contains("OR"))
    {
        string[] values = input.Split(' ');
        string out_wire = values[4];
        bool l = wires.TryGetValue(values[0], out UInt16 left);
        bool r = wires.TryGetValue(values[2], out UInt16 right);

        if (!l)
        {
            left = UInt16.Parse(values[0]);
        }
        if (!r)
        {
            right = UInt16.Parse(values[2]);
        }

        wires[out_wire] = (UInt16)(left | right);
    }
    else if (input.Contains("LSHIFT"))
    {
        string[] values = input.Split(' ');
        string out_wire = values[4];
        bool l = wires.TryGetValue(values[0], out UInt16 left);
        bool r = wires.TryGetValue(values[2], out UInt16 right);

        if (!l)
        {
            left = UInt16.Parse(values[0]);
        }
        if (!r)
        {
            right = UInt16.Parse(values[2]);
        }

        wires[out_wire] = (UInt16)(left << right);
    }
    else if (input.Contains("RSHIFT"))
    {
        string[] values = input.Split(' ');
        string out_wire = values[4];
        bool l = wires.TryGetValue(values[0], out UInt16 left);
        bool r = wires.TryGetValue(values[2], out UInt16 right);

        if (!l)
        {
            left = UInt16.Parse(values[0]);
        }
        if (!r)
        {
            right = UInt16.Parse(values[2]);
        }

        wires[out_wire] = (UInt16)(left >> right);
    }
    else if (input.Contains("NOT"))
    {
        string[] values = input.Split(' ');
        string out_wire = values[3];
        bool r = wires.TryGetValue(values[1], out UInt16 right);

        if (!r)
        {
            right = UInt16.Parse(values[1]);
        }

        wires[out_wire] = (UInt16)~right;
    }
    else
    {
        string[] values = input.Split(" -> ");
        // wires.TryGetValue(values[1], out Int16 num);
        wires[values[1]] = UInt16.Parse(values[0]);
    }

    input = Console.ReadLine();
}

foreach(string key in wires.Keys)
{
    Console.WriteLine(key + ": " + wires[key]);
}