using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GQ
{
    public class BudgetProjectService : IBudgetProjectService
    {
        private readonly HttpClient _client;
        public BudgetProjectService(IHttpClientFactory client)
        {
            _client = client.Create();
        }
        public async Task<IEnumerable<BudgetProject>> BudgetByCodeMeliAsync(string codemeli)
        {                       
            var returnInfo = new List<BudgetProject>();
            
            var stringContent = new StringContent(JsonConvert.SerializeObject(
                new {codeMeli = codemeli}),
                UnicodeEncoding.UTF8, "application/json");
                
            HttpResponseMessage Res = await _client.PostAsync("api/BudgetProject/Login", stringContent);

                
            if (Res.IsSuccessStatusCode)
            {
                
                var EmpResponse = Res.Content.ReadAsStringAsync().Result;            
                returnInfo = JsonConvert.DeserializeObject<List<BudgetProject>>(EmpResponse);

            }
    
            return returnInfo;
        }


        public async Task<IEnumerable<BudgetProjectPlanIdentity>> BudgetProjectPlanByBudgetProjectIdAsync(string qparam)
        {
            var returnInfo = new List<BudgetProjectPlanIdentity>();

            var stringContent = new StringContent(JsonConvert.SerializeObject(qparam),
                UnicodeEncoding.UTF8, "application/json");

            HttpResponseMessage Res = await _client.PostAsync("api/BudgetProject/PostBudgetProjectPlanTextFieldsAction", stringContent);


            if (Res.IsSuccessStatusCode)
            {

                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                returnInfo = JsonConvert.DeserializeObject<List<BudgetProjectPlanIdentity>>(EmpResponse);

            }

            return returnInfo;
        }


    }
}
