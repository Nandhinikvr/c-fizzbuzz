// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;

// List<string> result = new List<string>();
for (int i = 1; i <= 256; i++)
{
    string three = "Fizz",
        five = "Buzz",
        seven = "Bang",
        thirteen = "Fezz",
        eleven = "Bong";
    string Output = "";
    bool elevenMultiple = false;
    string[] reverseString = [];
    if (i % 3 == 0)
    {
        Output += three;
    }
    if (i % 13 == 0)
    {
        Output += thirteen;
        elevenMultiple = true;
    }
    if (i % 5 == 0)
    {
        Output += five;
    }
    if (i % 7 == 0)
    {
        Output += seven;
    }
    if (i % 11 == 0)
    {
        if (elevenMultiple)
        {
            Output += eleven;
        }
        else
        {
            Output = "";
            Output += eleven;
        }
    }
    if (i % 17 == 0)
    {
        Output = Output.Substring(4) + Output.Substring(0, 4);
    }
    if (Output == "")
    {
        Output += Convert.ToString(i);
    }

    Console.WriteLine(Output);
}
