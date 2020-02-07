using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoFacExample.Models
{
    public interface IDataProvider
    {
        string Get();
    }

    public class DataProvider : IDataProvider
    {
        public string Get()
        {
            return "Test data";
        }
    }
}
