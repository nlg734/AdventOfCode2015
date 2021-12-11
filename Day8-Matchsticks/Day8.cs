// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string? s = Console.ReadLine();
int code_total = 0;
int str_total = 0;

while(!String.IsNullOrEmpty(s))
{
    code_total += s.Length;

    str_total += string_parser(s);

    s = Console.ReadLine();
}

Console.WriteLine(code_total);
Console.WriteLine(str_total);
Console.WriteLine(code_total - str_total); 

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