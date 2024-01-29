/*using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchMarkDemo
{
    public class MyBenchmark
    {

        [Params(100, 10000, 100000, 1000000)]
        public int size { get; set; } = 100;
        [Benchmark]
        public int LoopBenchmark()
        {
            int[] array = new int[10000];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        [Benchmark]
        public void SortBenchmark(int size)
        {
            int[] data = new int[size];
            // Populate the array with random data
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                data[i] = random.Next();
            }
            // Call the sort method to be benchmarked
            Array.Sort(data);
        }
    }

}
*/