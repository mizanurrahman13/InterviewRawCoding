using System.Diagnostics;
using System.Text.RegularExpressions;

/***
 * ^ - Starts with
 * $ - Ends with
 * [] - Range
 * () - Group
 * . - Single character once
 * + - One or more character in a row
 * ? - Optional preceding character match
 * \ - Escape character
 * \n - New line
 * \d - Digit
 * \D - Non-Digit
 * \s - White space
 * \S - Non-White space
 * \w - Alphanumeric/Underscore character (word chars)
 * \W - Non-Word characters
 * {x,y} - Repeat low (x) to high (y) (no "y" means at least x, no ",y" means that many)
 * (x|y) - Alternative - x or y 
 * [^x] - Anything but x (where x is whatever character you want)
 ***/

string toSearch = File.ReadAllText("test.txt");

// (440) 555-4567

// this pattern matches phone numbers in the following patterns
string pattern = @"\(?\d{3}\)?(-|.|\s)?\d{3}(-|.)?\d{4}";

MatchCollection matches = Regex.Matches(toSearch, pattern);

foreach (Match match in matches)
{
    Console.WriteLine(match.Value);
}

//string pattern = "Lamia";
//string patternWithWhiteSpace = @"(\s|^)Lamia(\s|$)";
////string toSearch = "Lamia Ahmed";

////Console.WriteLine("Lamia Ahmed: " + Regex.IsMatch("Lamia Ahmed", pattern));
////Console.WriteLine("Lamiaamu Ahmed: " + Regex.IsMatch("Lamiaamu Ahmed", pattern));
////Console.WriteLine("jannatlamiajannat: " + Regex.IsMatch("jannatlamiajannat", pattern));
////Console.WriteLine("lamia ahmed: " + Regex.IsMatch("lamia Ahmed", pattern));
////Console.WriteLine("Lamia Ahmed: " + Regex.IsMatch("Lamia Ahmed", patternWithWhiteSpace));
////Console.WriteLine("I am Lamia Ahmed: " + Regex.IsMatch("I am Lamia Ahmed", patternWithWhiteSpace));

//var stopwatch = new Stopwatch();

//stopwatch.Start();
//Regex test = new Regex(patternWithWhiteSpace);

//for (int i = 0; i < 100000; i++)
//{
//    //Regex.IsMatch("I am Lamia Ahmed", patternWithWhiteSpace);
//    test.IsMatch("I am Lamia Ahmed");
//}

//stopwatch.Stop();

//Console.WriteLine($"Time Elapsed in MS: {stopwatch.ElapsedMilliseconds}");