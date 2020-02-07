using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoFacExample.Models
{
    public class IoCBuilder
    {
        public static IContainer Build()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DataProvider>().As<IDataProvider>();
            return builder.Build();
        }
    }
}
