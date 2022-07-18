// See https://aka.ms/new-console-template for more information

using csv_parser;

string data = System.IO.File.ReadAllText(@"../../../../input.csv");

var parser = new CsvParser();
var list = parser.Parse(data, ",");


Console.WriteLine("Hmm");