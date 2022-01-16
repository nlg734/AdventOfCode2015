/* Author: Natasha Graham
 * Code for Advent of Code 2015, Day 7
 * https://adventofcode.com/2015/day/7
 * Dec 2021
 * Updated: Jan 2022
 */


string? input = Console.ReadLine();
var wires = new Dictionary<string, string>();  // wires and their equivalent expressions
var values = new Dictionary<string, UInt16>();  // wires and their numerical values


/// <summary>
/// Takes input, puts into wires
/// </summary>
while (!String.IsNullOrEmpty(input))
{
    string[] eq = input.Split(" -> ");
    wires[eq[1]] = eq[0];

    input = Console.ReadLine();
}

values["b"] = 16076;  // For part 2

/// <summary>
/// fill in values for each key
/// </summary>
foreach(string key in wires.Keys)
{
    // For part 2
    if(key == "b")
    {
        continue;
    }
    values[key] = GetValue(key);
}


/// <summary>
/// Print out wires and values
/// </summary>
foreach(string key in values.Keys)
{
    Console.WriteLine(key + ": " + values[key]);
}


/// <summary>
/// Determines what kind of expression a key has and returns the resulting numerical value
/// after evaluating the exprssion. 
/// Returns existing value when it already exists in values. 
/// When not a key in wires (as in, not a wire name), returns the integer value. 
/// </summary>
UInt16 GetValue(string key)
{
    if(values.ContainsKey(key))
    {
        return values[key];
    }
    if(!wires.ContainsKey(key))
    {
        return UInt16.Parse(key);
    }
    if(wires[key].Contains("AND"))
    {
        string[] variables = wires[key].Split(" AND ");
        values[key] = AND(GetValue(variables[0]), GetValue(variables[1]));
        return values[key];
    }
    if (wires[key].Contains("OR"))
    {
        string[] variables = wires[key].Split(" OR ");
        values[key] =  OR(GetValue(variables[0]), GetValue(variables[1]));
        return values[key];
    }
    if (wires[key].Contains("NOT"))
    {
        string[] variables = wires[key].Split("NOT ");
        values[key] =  NOT(GetValue(variables[1]));
        return values[key];
    }
    if (wires[key].Contains("RSHIFT"))
    {
        string[] variables = wires[key].Split(" RSHIFT ");
        values[key] = RSHIFT(GetValue(variables[0]), GetValue(variables[1]));
        return values[key];
    }
    if (wires[key].Contains("LSHIFT"))
    {
        string[] variables = wires[key].Split(" LSHIFT ");
        values[key] = LSHIFT(GetValue(variables[0]), GetValue(variables[1]));
        return values[key];
    }

    values[key] = GetValue(wires[key]);
    return values[key];
}

// Bitewise NOT
UInt16 NOT(UInt16 x)
{
    return (UInt16)~x;
}

// Bitwise AND
UInt16 AND(UInt16 x, UInt16 y)
{
    return (UInt16)(x & y);
}

// Bitwise OR
UInt16 OR(UInt16 x, UInt16 y)
{
    return (UInt16)(x | y);
}

// Bitwise Right Shift
UInt16 RSHIFT(UInt16 x, UInt16 y)
{
    return (UInt16)(x >> y);
}

// Bitwise Left Shift
UInt16 LSHIFT(UInt16 x, UInt16 y)
{
    return (UInt16)(x << y);
}