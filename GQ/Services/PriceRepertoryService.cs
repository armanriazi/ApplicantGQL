using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace GQ
{
    public class PriceRepertoryService : IPriceRepertoryService
    {
        private readonly HttpClient _client;
        private readonly IMapper _mapper;        
        public PriceRepertoryService(IHttpClientFactory client,IMapper mapper)
        {
            _client = client.Create();
            _mapper = mapper;
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

        public async Task<IEnumerable<VMPriceRepertoryGridAction>> PriceRepertoryGridActionByParamsAsync(string accFinancialYearID, string tblPrcID, string tblPrcIDParent,string tblBprParentId, string sortExpression)
        {
            var returnInfo = new List<PriceRepertoryGridAction>();
            var returnOutInfo = new List<VMPriceRepertoryGridAction>();

            var stringContent = new StringContent(JsonConvert.SerializeObject(
                new { AccFinancialYearID = accFinancialYearID, TblPrcID= tblPrcID, TblPrcIDParent= tblPrcIDParent, TblBprParentId= tblBprParentId, SortExpression = sortExpression }),
                UnicodeEncoding.UTF8, "application/json");

            HttpResponseMessage Res = await _client.PostAsync("api/PriceRepertory/PostPriceRepertoryGridAction", stringContent);


            if (Res.IsSuccessStatusCode)
            {

                var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                
                returnInfo = JsonConvert.DeserializeObject<List<PriceRepertoryGridAction>>(EmpResponse);
                returnOutInfo=_mapper.Map<List<VMPriceRepertoryGridAction>>(returnInfo);
            }

            return returnOutInfo;
        }


        public async Task<IEnumerable<BasePriceRepertoryPriceTextFieldAction>> BasePriceRepertoryPriceTextFieldActionByQueryAsync(string query)
        {
            var returnInfo = new List<BasePriceRepertoryPriceTextFieldAction>();

            var stringContent = new StringContent(JsonConvert.SerializeObject(query),
                UnicodeEncoding.UTF8, "application/json");

            HttpResponseMessage Res = await _client.PostAsync("api/PriceRepertory/PostBasePriceRepertoryPriceTextFieldAction", stringContent);


            if (Res.IsSuccessStatusCode)
            {

                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                returnInfo = JsonConvert.DeserializeObject<List<BasePriceRepertoryPriceTextFieldAction>>(EmpResponse);

            }

            return returnInfo;
        }

        public async Task<IEnumerable<ProjectManagementSystemProjectReportGridAction>> ProjectManagementSystemProjectReportGridActionByParamsAsync(string accFinancialYearID, string tblBprID, string sortExpression, string orderBy)
        {
            var returnInfo = new List<ProjectManagementSystemProjectReportGridAction>();

            var stringContent = new StringContent(JsonConvert.SerializeObject(
                                new { AccFinancialYearID = accFinancialYearID, TblBprID = tblBprID, SortExpression = sortExpression, OrderBy= orderBy }),
                UnicodeEncoding.UTF8, "application/json");

            HttpResponseMessage Res = await _client.PostAsync("api/PriceRepertory/PostProjectManagementSystemProjectReportGridAction", stringContent);


            if (Res.IsSuccessStatusCode)
            {

                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                returnInfo = JsonConvert.DeserializeObject<List<ProjectManagementSystemProjectReportGridAction>>(EmpResponse);

            }

            return returnInfo;
        }
    }
}
