using System.Security.Cryptography;
using System.Text;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

MD5 create_md5 = MD5.Create();
string puzzle = "yzbqklnj";

int i = 1;
while(true)
{
    string test = puzzle + i.ToString();

    byte[] data = Encoding.UTF8.GetBytes(test);

    byte[] hash = create_md5.ComputeHash(data);
    string final = Convert.ToHexString(hash);

    if(final.StartsWith("000000"))
    {
        Console.WriteLine(final);
        Console.WriteLine(test);
        break;
    }

    i++;
}