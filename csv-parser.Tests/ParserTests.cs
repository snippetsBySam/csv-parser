using FluentAssertions;

namespace csv_parser.Tests;

public class ParserTests : CsvParser
{
    string TestData1 = @"first_name,last_name,company_name,address,city,county,postal,phone1,phone2,email,web
Aleshia,Tomkiewicz,Alan D Rosenburg Cpa Pc,14 Taylor St,St. Stephens Ward,Kent,CT2 7PP,01835-703597,01944-369967,atomkiewicz@hotmail.com,http://www.alandrosenburgcpapc.co.uk
Evan,Zigomalas,Cap Gemini America,5 Binney St,Abbey Ward,Buckinghamshire,HP11 2AX,01937-864715,01714-737668,evan.zigomalas@gmail.com,http://www.capgeminiamerica.co.uk
France,Andrade,""Elliott, John W Esq"",8 Moor Place,East Southbourne and Tuckton W,Bournemouth,BH6 3BE,01347-368222,01935-821636,france.andrade@hotmail.com,http://www.elliottjohnwesq.co.uk
Ulysses,Mcwalters,""Mcmahan, Ben L"",505 Exeter Rd, Hawerby cum Beesby, Lincolnshire, DN36 5RP,01912-771311,01302-601380,ulysses @hotmail.com, http://www.mcmahanbenl.co.uk";

    CsvParser solution = new CsvParser();



    [Test]
    public void HeaderExtractionTest()
    {
        GetHeaders("first_name,last_name,company_name,address,city,county,postal,phone1,phone2,email,web", ",")
            .Count().Should().Be(11);

        GetHeaders("first_name\tlast_name\tcompany_name\taddress\tcity\tcounty\tpostal\tphone1\tphone2\temail\tweb", "\t")
            .Count().Should().Be(11);

    }

    [Test]
    public void GetLinesShouldSkipWhiteSpaces()
    {
        GetLines("").Count().Should().Be(0);
        GetLines(" ").Count().Should().Be(0);
        GetLines("\r").Count().Should().Be(0);
        GetLines("\n").Count().Should().Be(0);
        GetLines("\r\n").Count().Should().Be(0);
    }

    [Test]
    public void GetLinesShouldSplitContent()
    {
        GetLines("a\rb").Count().Should().Be(2);
        GetLines("a\nb").Count().Should().Be(2);
        GetLines("a\r\nb").Count().Should().Be(2);
        GetLines(TestData1).Count().Should().Be(5);
    }

    [Test]
    public void Test4()
    {
        Assert.Pass();
    }
}