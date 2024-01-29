
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        //var summary = BenchmarkRunner.Run<MemoryBenchmarkerDemo>();
        //var summary1 = BenchmarkRunner.Run<MyBenchmark>();

        var summary1 = BenchmarkRunner.Run<SimpleDemo>();
    }
}

[MemoryDiagnoser]
[RankColumn]
public class SimpleDemo
{
    //[Benchmark(Baseline = true)]
    //public string usingPlus()
    //{
    //    string output = "";
    //    for (int i = 0; i < 5; i++)
    //    {
    //        output += i;
    //    }
    //    return output;
    //}

    //[Benchmark]
    //public string usingStringBuilder()
    //{
    //    StringBuilder sb = new StringBuilder();
    //    for (int i = 0; i < 5; i++)
    //    {
    //        sb.Append(i);
    //    }
    //    return sb.ToString();
    //}
    //[Benchmark]
    //public string usingStringAdd()
    //{
    //    string s = "1";
    //    s += "1";
    //    s += "1";
    //    s += "1";
    //    s += "1";
    //    return s;
    //}

    //[Benchmark]
    //public (int day, int month, int year) GetDateFromStringReadOnlySpan()
    //{
    //    ReadOnlySpan<char> date = "02 01 2022";
    //    var dayString = date.Slice(0, 2);
    //    var monthString = date.Slice(3, 2);
    //    var yearString = date.Slice(6, 2);
    //    var day = int.Parse(dayString);
    //    var month = int.Parse(monthString);
    //    var year = int.Parse(yearString);
    //    return (day, month, year);
    //}

    //[Benchmark (Baseline = true)]
    //public (int day, int month, int year) GetDateFromString()
    //{
    //    var date = "02 01 2022";
    //    var dayString = date.Substring(0, 2);
    //    var monthString = date.Substring(3, 2);
    //    var yearString = date.Substring(6, 2);
    //    var day = int.Parse(dayString);
    //    var month = int.Parse(monthString);
    //    var year = int.Parse(yearString);
    //    return (day, month, year);
    //}


}