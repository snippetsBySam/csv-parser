using csv_parser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace csv_parser
{
    public class OptionsDisplay
    {
        List<Person> ParsedPersons;
        Regex searchTerm1 = new Regex(@"[Ee]sq");
        Regex searchTerm2 = new Regex(@"[Dd]erbyshire");
        Regex searchTerm3 = new Regex(@"^\d{3}\s");
        Regex searchTerm5 = new Regex(@"^[A-Za-z]+\d\s");

        List<Person> optionResult;

        public OptionsDisplay(string fileData, int option)
        {
            var parser = new CsvParser();
            var ParsedPersons = parser.Parse(fileData, ",");
            optionResult = option switch
            {
                1 => ParsedPersons.Where(p => p.company_name.Contains("Esq")).ToList(),
                2 => ParsedPersons.Where(p => p.county.Contains("Derbyshire")).ToList(),
                3 => ParsedPersons.Where(p => searchTerm3.IsMatch(p.address)).ToList(),
                4 => ParsedPersons.Where(p => p.web.Length > 35).ToList(),
                5 => ParsedPersons.Where(p => searchTerm5.IsMatch(p.postal)).ToList(),
                6 => ParsedPersons.Where(p => Int64.Parse(p.phone1.Replace("-", "")) > Int64.Parse(p.phone2.Replace("-", ""))).ToList(),
            };
            PrintResults(optionResult);
        }
        public void PrintResults(List<Person> results)
        {
            int counter = 1;
            Console.WriteLine($"Count: {results.Count}");
            results.ForEach(person => {
                Console.WriteLine($"{counter}\t- {person.ToString()}");
                counter++;
            });
        }
    }
}
