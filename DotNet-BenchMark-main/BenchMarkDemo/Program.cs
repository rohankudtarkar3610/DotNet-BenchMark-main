using BenchMarkDemo;
using BenchmarkDotNet.Running;

class Program
{
    static void Main(string[] args)
    {
        //var summary = BenchmarkRunner.Run<MemoryBenchmarkerDemo>();
        //var summary1 = BenchmarkRunner.Run<MyBenchmark>();

        var summary1 = BenchmarkRunner.Run<simpleBenchmark>();
        
    }
    
}

