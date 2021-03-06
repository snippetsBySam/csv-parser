using csv_parser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace csv_parser
{
    public class CsvParser
    {

        public virtual List<Person> Parse(string data, string delimiter)
        {
            List<Person> items = new List<Person>();
            var lines = GetLines(data);
            Regex csvSplit = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
            lines.Skip(1).ToList().ForEach(line => items.Add(new Person(csvSplit.Split(line))));
            return items;
        }

        public virtual string[] GetHeaders(string headerLine, string delimiter)
        {
            var headers = headerLine.Split(delimiter)
                .Select(header => header.Trim())
                .Where(header =>
                   !string.IsNullOrWhiteSpace(header) ||
                   !string.IsNullOrEmpty(headerLine)).ToArray();
            return headers;
        }

        public virtual IEnumerable<string> GetLines(string data)
        {
            char[] LineBreaks = { '\r', '\n' };
            var lines = data.Split(LineBreaks).Where(line => !String.IsNullOrWhiteSpace(line));
            return lines;
        }
    }
}
