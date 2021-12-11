// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string? s = Console.ReadLine();
int code_total = 0;
int str_total = 0;

while(!String.IsNullOrEmpty(s))
{
    code_total += s.Length;

    str_total += str_build(s);

    s = Console.ReadLine();
}

Console.WriteLine(code_total);
Console.WriteLine(str_total);
// Console.WriteLine(code_total - str_total); 
Console.WriteLine(str_total - code_total);

int string_parser(string str)
{
    int count = 0;

    for(int i = 1; i< str.Length-1; i++)
    {
        if(str[i] == '\\')
        {
            if (str[i + 1] == 'x')
            {
                count++;
                i += 3;
                continue;
            }
            else if (str[i + 1] == '"' || str[i + 1] == '\\')
            {
                count++;
                i++;
                continue;
            }
        }

        count++;
    }

    return count;
}

// Part 1 solution: 1350

int str_build(string str)
{
    int count = 0;

    count += str.Count(c => c == '"');  // +1 for each " in string
    count += str.Count(c => c == '\\');  // +1 for each \ in string
    count += 2;  // +2 for new quotes
    count += str.Length;   // total length of string

    return count;
}

// Part 2 Solution: 2085

/* Test string
""
"abc"
"aaa\"aaa"
"\x27"
 
 */