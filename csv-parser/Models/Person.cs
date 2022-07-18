using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csv_parser.Models
{
    public class Person
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string company_name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public string postal { get; set; }
        public string phone1 { get; set; }
        public string phone2 { get; set; }
        public string email { get; set; }
        public string web { get; set; }

        public Person(string[] data)
        {
            if (data != null && data.Length > 10)
            {
                this.first_name = data[0];
                this.last_name = data[1];
                this.company_name = data[2];
                this.address = data[3];
                this.city = data[4];
                this.county = data[5];
                this.postal = data[6];
                this.phone1 = data[7];
                this.phone2 = data[8];
                this.email = data[9];
                this.web = data[10];
            }
        }
        public override string ToString()
        {
            return $"{first_name} {last_name} - {company_name}";
        }
    }

    
}
