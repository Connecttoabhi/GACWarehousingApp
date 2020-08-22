using DotNetty.Common;
using DotNetty.Common.Concurrency;
using Microsoft.Extensions.Hosting;
using NCrontab;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;


namespace GACWarehousingApp.backgroudservice
{
    public class MyTestHostedService : IScheduledTask
    {
        public string Schedule => "* */6 * * *";

        public PreciseTimeSpan Deadline => throw new NotImplementedException();

        public Task Completion => throw new NotImplementedException();

        public bool Cancel()
        {
            throw new NotImplementedException();
        }

        public async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            var httpClient = new HttpClient();

            var quoteJson = JObject.Parse(await httpClient.GetStringAsync("https://localhost:44392/api/salesOrder/Post"));

            SalesOrder.Current = JsonConvert.DeserializeObject<SalesOrder>(quoteJson["contents"]["quotes"][0].ToString());
        }

        public TaskAwaiter GetAwaiter()
        {
            throw new NotImplementedException();
        }

        public class SalesOrder
        {
            public static SalesOrder Current { get; set; }

            static SalesOrder()
            {
                Current = new SalesOrder { OrderID = 1, ProductList="xyz", ProductQuantity="123", ProductID = 1 };
            }

            public int OrderID { get; set; }

            public string ProductList { get; set; }
            public string ProductQuantity { get; set; }

            public int ProductID { get; set; }
        }
    }
}
