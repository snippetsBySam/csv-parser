using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csv_parser
{
    public class CsvParser
    {
        public virtual List<T> Parse<T>(string data, string delimiter)
        {
            List<T> items = new List<T>();
            return items;
        }

        public virtual string[] GetHeaders(string header, string delimiter)
        {
            string[] test = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            return test;
        }
    }
}
