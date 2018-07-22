
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GQ
{
    public class PriceRepertoryService : IPriceRepertoryService
    {
        private readonly HttpClient _client;
      
        public PriceRepertoryService(IHttpClientFactory client)
        {
            _client = client.Create();
            //_clientElastic = client.CreateElastic();
        }
        public async Task<IEnumerable<BasePriceRepertorySelectListAction>> BasePriceRepertorySelectListActionByQueryAsync(string qparam)
        {
            var returnInfo = new List<BasePriceRepertorySelectListAction>();

            var stringContent = new StringContent(JsonConvert.SerializeObject(qparam),
                UnicodeEncoding.UTF8, "application/json");

            HttpResponseMessage Res = await _client.PostAsync("api/PriceRepertory/PostBasePriceRepertorySelectListAction", stringContent);


            if (Res.IsSuccessStatusCode)
            {

                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                returnInfo = JsonConvert.DeserializeObject<List<BasePriceRepertorySelectListAction>>(EmpResponse);

            }

            return returnInfo;
        }

        public async Task<IEnumerable<PriceRepertoryFinancialYearsSelectListAction>> PriceRepertoryFinancialYearsSelectListActionByAccFinancialYearIdAsync(string qparam)
        {
            var returnInfo = new List<PriceRepertoryFinancialYearsSelectListAction>();

            var stringContent = new StringContent(JsonConvert.SerializeObject(qparam),
                UnicodeEncoding.UTF8, "application/json");

            HttpResponseMessage Res = await _client.PostAsync("api/PriceRepertory/PostPriceRepertoryFinancialYearsSelectListAction", stringContent);


            if (Res.IsSuccessStatusCode)
            {

                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                returnInfo = JsonConvert.DeserializeObject<List<PriceRepertoryFinancialYearsSelectListAction>>(EmpResponse);

            }

            return returnInfo;
        }

        public async Task<IEnumerable<PriceRepertoryGridAction>> PriceRepertoryGridActionByParamsAsync(string accFinancialYearID, string tblPrcID, string tblPrcIDParent,string tblBprParentId, string sortExpression)
        {
            var returnInfo = new List<PriceRepertoryGridAction>();

            var stringContent = new StringContent(JsonConvert.SerializeObject(
                new { AccFinancialYearID = accFinancialYearID, TblPrcID= tblPrcID, TblPrcIDParent= tblPrcIDParent, TblBprParentId= tblBprParentId, SortExpression = sortExpression }),
                UnicodeEncoding.UTF8, "application/json");

            HttpResponseMessage Res = await _client.PostAsync("api/PriceRepertory/PostPriceRepertoryGridAction", stringContent);


            if (Res.IsSuccessStatusCode)
            {

                var EmpResponse = Res.Content.ReadAsStringAsync().Result;


                returnInfo = JsonConvert.DeserializeObject<List<PriceRepertoryGridAction>>(EmpResponse);

            }

            return returnInfo;
        }
    }
}
