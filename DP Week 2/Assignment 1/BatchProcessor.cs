using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class BatchProcessor
    {
        List<BigDataLoader> loaders;
        public BatchProcessor()
        {
            loaders = new List<BigDataLoader>();
        }
        public void Add(BigDataLoader loader)
        {
            loaders.Add(loader);
        }
        public void Print()
        {
            foreach (BigDataLoader loader in loaders)
            {
                loader.ETL();
            }
        }
    }
}
