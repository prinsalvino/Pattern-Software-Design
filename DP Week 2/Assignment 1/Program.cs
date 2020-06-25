using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            TwitterLoader twitter = new TwitterLoader();
            CellDataLoader data = new CellDataLoader();
            SensorDataLoader sensorData = new SensorDataLoader();
            BatchProcessor batchProcessor = new BatchProcessor();

            batchProcessor.Add(twitter);
            batchProcessor.Add(data);
            batchProcessor.Add(sensorData);

            batchProcessor.Print();

            Console.ReadKey();
        }
    }
}
