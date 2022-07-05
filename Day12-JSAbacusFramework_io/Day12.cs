/* Author: Natasha Graham
 * Code for Advent of Code 2015, Day 12
 * https://adventofcode.com/2015/day/12
 * Jan 2022
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;


long sum(JObject convert)
{
    long sumNumbers = 0;
    foreach (var c in convert.Children())
    {
        if(c.Type == JTokenType.Integer || c.Type == JTokenType.Float)
        {
            sumNumbers += c.Value<long>();
        }
        else if(c.Type == JTokenType.Object || c.Type == JTokenType.Array || c.Type == JTokenType.Property)
        {
            sumNumbers += sum(c.ToObject<JObject>());
        }
    }

    return sumNumbers;
}


string jsonInput = File.ReadAllText("input.json");
JObject convert = JObject.Parse(jsonInput);

long summed = sum(convert);

System.Console.WriteLine(summed);

System.Console.ReadLine();


// Not 0