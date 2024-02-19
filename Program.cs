// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;

Console.WriteLine("Please enter the Maximum range for the Number");
var maxValue = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine($"Printing the numbers upto {maxValue}!");
List<string> output = new List<string>();
for (int i = 1; i <= maxValue; i++)
{
    string three = "Fizz",
        five = "Buzz",
        seven = "Bang",
        thirteen = "Fezz",
        eleven = "Bong";
    //string Output = "";
    output.Clear();
    bool elevenMultiple = false;
    string[] reverseString = [];
    if (i % 3 == 0)
    {
        output.Add(three);
        // Output += three;
    }
    if (i % 13 == 0)
    {
        output.Add(thirteen);
        //  Output += thirteen;
        elevenMultiple = true;
    }
    if (i % 5 == 0)
    {
        output.Add(five);
        // Output += five;
    }
    if (i % 7 == 0)
    {
        output.Add(seven);
        //Output += seven;
    }
    if (i % 11 == 0)
    {
        if (elevenMultiple)
        {
            output.Add(eleven);
            // Output += eleven;
        }
        else
        {
            output.Clear();
            output.Add(eleven);
            //Output="";
            //Output += eleven;
        }
    }
    // if (i % 17 == 0)
    // {
    //     if (Output != "")
    //         Output = Output.Substring(4) + Output.Substring(0, 4);
    // }
    // if (Output == "")
    // {
    //     Output += Convert.ToString(i);
    // }
    if (i % 17 == 0 && output.Count > 1)
    {
        output.Reverse();
    }
    if (output.Count == 0)
    {
        Console.WriteLine(i);
    }
    else
    {
        Console.WriteLine(string.Join("", output));
    }

    // Console.WriteLine(Output);
}
