
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace GQ
{ 
    public class HttpClientFactory : IHttpClientFactory
    {
        static IDictionary<string, HttpClient> cache = new Dictionary<string, HttpClient>();

        public HttpClient Create()
        {
            string endpoint = "http://localhost:5589";
            HttpClient client = null;

            if (cache.TryGetValue(endpoint, out client))
            {
                return client;
            }

            client = new HttpClient
            {
                BaseAddress = new Uri(endpoint),

            };

            client.DefaultRequestHeaders.Clear();  
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            cache[endpoint] = client;

            return client;
        }

        //public ElasticClient CreateElastic()
        //{    
        //    var nodes = new Uri[]
        //       {
        //        new Uri("http://localhost:5589")                
        //       };

        //    var pool = new StaticConnectionPool(nodes);
        //    var settings = new ConnectionSettings(pool).DisableDirectStreaming();
        //    var client = new ElasticClient(settings);
        //    return client;
        //}
    }
}
//HttpClient client = new HttpClient();

//            string Baseurl = "/";

//            client.BaseAddress = new Uri(Baseurl);

//            client.DefaultRequestHeaders.Clear();
//            //Define request data format  
//            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));  