// See https://aka.ms/new-console-template for more information

using csv_parser;
using System.Text.RegularExpressions;

string data;
int option;
string[] arguments = Environment.GetCommandLineArgs();
if (arguments.Length == 3)
{
    data = System.IO.File.ReadAllText(arguments[1]);
    option = int.Parse(arguments[2]);
    if (option > 6 || option < 1)
    {
        Console.WriteLine("Enter a valid option (between 1 and 6)");
        Console.ReadLine();
        System.Environment.Exit(1);
    }
}
else
{
    data = System.IO.File.ReadAllText(@"input.csv");
    option = 2;
}

var runner = new OptionsDisplay(data, option);

//var parser = new CsvParser();
//var list = parser.Parse(data, ",");
//var searchTerm1 = new Regex(@"[Ee]sq");
//var searchTerm2 = new Regex(@"[Dd]erbyshire");
//var searchTerm3 = new Regex(@"^\d{3}\s");
//var searchTerm5 = new Regex(@"^[A-Za-z]+\d\s");



//var option1 = list.Where(p => p.company_name.Contains("Esq")).ToList();
//var option2 = list.Where(p => p.county.Contains("Derbyshire")).ToList();
//var option3 = list.Where(p => searchTerm3.IsMatch(p.address)).ToList();
//var option4 = list.Where(p => p.web.Length > 35).ToList();
//var option5 = list.Where(p => searchTerm5.IsMatch(p.postal)).ToList();
//var option6 = list.Where(p => Int64.Parse(p.phone1.Replace("-","")) > Int64.Parse(p.phone2.Replace("-", ""))).ToList();



//Console.WriteLine("Hmm");
Console.ReadLine();