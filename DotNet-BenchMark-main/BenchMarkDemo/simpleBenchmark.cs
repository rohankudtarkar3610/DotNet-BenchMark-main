using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchMarkDemo
{
    //[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    [RankColumn]
    public  class simpleBenchmark
    {
        [Benchmark (Baseline=true)]
        public string usingPlus()
        {
            string output = "";
            for (int i = 0; i < 10; i++)
            {
                output += i;
            }
            return output;
        }

        [Benchmark]
        public string usingAppend()
        {
            StringBuilder output =new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                output.Append(i);
            }
            return output.ToString();
        }
    }
}
