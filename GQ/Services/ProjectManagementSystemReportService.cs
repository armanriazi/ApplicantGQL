using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GQ
{
    public class ProjectManagementSystemProjectReportPlanItemsService: IProjectManagementSystemProjectReportPlanItemsService
    {              
        private readonly HttpClient _client;

        public ProjectManagementSystemProjectReportPlanItemsService(IHttpClientFactory client)
        {

            _client = client.Create();            
        }



        public async Task<IEnumerable<ProjectManagementSystemProjectReportPlanItems>> ProjectManagementSystemProjectReportPlanItemsByProjectIdAsync(string projectId, string orderBy)
        {
            var returnInfo = new List<ProjectManagementSystemProjectReportPlanItems>();            

          
                var stringContent = new StringContent(JsonConvert.SerializeObject(
                    new { BudgetProjectId_Fk = projectId,OrderBy = orderBy}),
                    UnicodeEncoding.UTF8, "application/json");

                HttpResponseMessage Res = await _client.PostAsync("api/ProjectManagementSystemProjectReport/PostProjectManagementSystemProjectReportPlanItemsGridAction", stringContent);
         
                if (Res.IsSuccessStatusCode)
                {

                   var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                   returnInfo = JsonConvert.DeserializeObject<List<ProjectManagementSystemProjectReportPlanItems>>(EmpResponse);                  

                }
            
            return returnInfo;
        }
        public async Task<IEnumerable<PostProjectManagementSystemProjectReportPlanDocuments>> ProjectManagementSystemProjectReportPlanDocumentsByBudgetProjectIdAsync(string budgetProjectId)
        {
            var returnInfo = new List<PostProjectManagementSystemProjectReportPlanDocuments>();


            var stringContent = new StringContent(JsonConvert.SerializeObject(budgetProjectId),
                UnicodeEncoding.UTF8, "application/json");

            HttpResponseMessage Res = await _client.PostAsync("api/ProjectManagementSystemProjectReport/PostProjectManagementSystemProjectReportPlanDocumentsGridAction", stringContent);

            if (Res.IsSuccessStatusCode)
            {

                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                returnInfo = JsonConvert.DeserializeObject<List<PostProjectManagementSystemProjectReportPlanDocuments>>(EmpResponse);

            }

            return returnInfo;
        }

        public async Task<IEnumerable<PostProjectManagementSystemProjectReportPlanContractorsPrice>> ProjectManagementSystemProjectReportPlanContractorsPriceByBudgetProjectIdAsync(string budgetProjectId)
        {
            var returnInfo = new List<PostProjectManagementSystemProjectReportPlanContractorsPrice>();


            var stringContent = new StringContent(JsonConvert.SerializeObject(budgetProjectId),
                UnicodeEncoding.UTF8, "application/json");

            HttpResponseMessage Res = await _client.PostAsync("api/ProjectManagementSystemProjectReport/PostProjectManagementSystemProjectReportContractItemsGridAction", stringContent);

            if (Res.IsSuccessStatusCode)
            {

                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                returnInfo = JsonConvert.DeserializeObject<List<PostProjectManagementSystemProjectReportPlanContractorsPrice>>(EmpResponse);

            }

            return returnInfo;
        }

        public async Task<IEnumerable<PostProjectManagementSystemProjectReportAttachmentsDialog>> PostProjectManagementSystemProjectReportAttachmentsDialogByDocumentCodeAsync(string documentCode)
        {
            var returnInfo = new List<PostProjectManagementSystemProjectReportAttachmentsDialog>();


            var stringContent = new StringContent(JsonConvert.SerializeObject(documentCode),
                UnicodeEncoding.UTF8, "application/json");

            HttpResponseMessage Res = await _client.PostAsync("api/ProjectManagementSystemProjectReport/PostProjectManagementSystemProjectReportAttachmentsDialogGridAction", stringContent);

            if (Res.IsSuccessStatusCode)
            {

                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                returnInfo = JsonConvert.DeserializeObject<List<PostProjectManagementSystemProjectReportAttachmentsDialog>>(EmpResponse);

            }

            return returnInfo;
        }

        public async Task<IEnumerable<PostProjectManagementSystemProjectReportSendToCartable>> PostProjectManagementSystemProjectReportSendToCartableByParamsAsync(string budProjectId, string nationalCode, string trackingCode, string accFinancialYearId)
        {
            var returnInfo =new List<PostProjectManagementSystemProjectReportSendToCartable>();

            var stringContent = new StringContent(JsonConvert.SerializeObject(
                new { BudProjectId = budProjectId, NationalCode = nationalCode , TrackingCode = trackingCode , AccFinancialYearID = accFinancialYearId }),
                UnicodeEncoding.UTF8, "application/json");

            HttpResponseMessage Res = await _client.PostAsync("api/ProjectManagementSystemProjectReport/PostProjectManagementSystemProjectReportSendToCartable", stringContent);

            if (Res.IsSuccessStatusCode)
            {
                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                var x = new PostProjectManagementSystemProjectReportSendToCartable();
                x.OutputMessage = EmpResponse;
                returnInfo.Add(x);
               // returnInfo = JsonConvert.DeserializeObject<List<object>>(outputMessage);
            }
            return returnInfo;
        }


        public async Task<IEnumerable<PostProjectManagementSystemProjectReportTechnicalPropertyItems>> ProjectManagementSystemProjectReportTechnicalPropertyItemsByParamsAsync(string budgetProjectId, string orderBy,string userId ,string accFinancialYearId, string desc)
        {
            var returnInfo = new List<PostProjectManagementSystemProjectReportTechnicalPropertyItems>();


            var stringContent = new StringContent(JsonConvert.SerializeObject(
                new { BudgetProjectId = budgetProjectId, OrderBy=orderBy, UserId= userId, AccFinancialYearId=accFinancialYearId, Desc=desc }),
                UnicodeEncoding.UTF8, "application/json");

            HttpResponseMessage Res = await _client.PostAsync("api/ProjectManagementSystemProjectReport/PostProjectManagementSystemProjectReportTechnicalPropertyItemsGridAction", stringContent);

            if (Res.IsSuccessStatusCode)
            {

                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                returnInfo = JsonConvert.DeserializeObject<List<PostProjectManagementSystemProjectReportTechnicalPropertyItems>>(EmpResponse);

            }

            return returnInfo;
        }


        public async  Task<IEnumerable<PostProjectManagementSystemProjectReportOptionsItems>> ProjectManagementSystemProjectReportOptionsItemsByParamsAsync(string budgetProjectId, string orderBy, string userId, string accFinancialYearId, string desc)
        {
            var returnInfo = new List<PostProjectManagementSystemProjectReportOptionsItems>();


            var stringContent = new StringContent(JsonConvert.SerializeObject(
                new { BudgetProjectId = budgetProjectId, OrderBy = orderBy, UserId=userId, AccFinancialYearId = accFinancialYearId, Desc = desc }),
                UnicodeEncoding.UTF8, "application/json");

            HttpResponseMessage Res = await _client.PostAsync("api/ProjectManagementSystemProjectReport/PostProjectManagementSystemProjectReportOptionsItemsGridAction", stringContent);

            if (Res.IsSuccessStatusCode)
            {

                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                returnInfo = JsonConvert.DeserializeObject<List<PostProjectManagementSystemProjectReportOptionsItems>>(EmpResponse);

            }

            return returnInfo;
        }

        public async Task<IEnumerable<PostProjectManagementSystemProjectReportApprovedBudgetItems>> ProjectManagementSystemProjectReportApprovedBudgetItemsByParamsAsync(string budgetProjectId, string orderBy, string userId,string accFinancialYearId, string desc)
        {
            var returnInfo = new List<PostProjectManagementSystemProjectReportApprovedBudgetItems>();


            var stringContent = new StringContent(JsonConvert.SerializeObject(
                new { BudgetProjectId = budgetProjectId, OrderBy = orderBy,UserId= userId, AccFinancialYearId = accFinancialYearId, Desc = desc }),
                UnicodeEncoding.UTF8, "application/json");

            HttpResponseMessage Res = await _client.PostAsync("api/ProjectManagementSystemProjectReport/PostProjectManagementSystemProjectReportApprovedBudgetItemsGridAction", stringContent);

            if (Res.IsSuccessStatusCode)
            {

                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                returnInfo = JsonConvert.DeserializeObject<List<PostProjectManagementSystemProjectReportApprovedBudgetItems>>(EmpResponse);

            }

            return returnInfo;
        }


        public async Task<IEnumerable<PostProjectManagementSystemProjectReportContractItems>> ProjectManagementSystemProjectReportContractItemsByParamsAsync(string budgetProjectId, string orderBy, string userId,string accFinancialYearId, string desc)
        {
            var returnInfo = new List<PostProjectManagementSystemProjectReportContractItems>();


            var stringContent = new StringContent(JsonConvert.SerializeObject(
                new { BudgetProjectId = budgetProjectId, OrderBy = orderBy,UserId= userId, AccFinancialYearId = accFinancialYearId, Desc = desc }),
                UnicodeEncoding.UTF8, "application/json");

            HttpResponseMessage Res = await _client.PostAsync("api/ProjectManagementSystemProjectReport/PostProjectManagementSystemProjectReportContractItemsGridAction", stringContent);

            if (Res.IsSuccessStatusCode)
            {

                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                returnInfo = JsonConvert.DeserializeObject<List<PostProjectManagementSystemProjectReportContractItems>>(EmpResponse);

            }

            return returnInfo;
        }

        public async Task<IEnumerable<PostProjectManagementSystemProjectReportAgendaItems>> ProjectManagementSystemProjectReportAgendaByParamsAsync(string budgetProjectId, string orderBy, string userId, string accFinancialYearId, string desc)
        {
            var returnInfo = new List<PostProjectManagementSystemProjectReportAgendaItems>();


            var stringContent = new StringContent(JsonConvert.SerializeObject(
                new { BudgetProjectId = budgetProjectId, OrderBy = orderBy, UserId = userId, AccFinancialYearId = accFinancialYearId, Desc = desc }),
                UnicodeEncoding.UTF8, "application/json");

            HttpResponseMessage Res = await _client.PostAsync("api/ProjectManagementSystemProjectReport/PostProjectManagementSystemProjectAgendaGridAction", stringContent);

            if (Res.IsSuccessStatusCode)
            {

                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                returnInfo = JsonConvert.DeserializeObject<List<PostProjectManagementSystemProjectReportAgendaItems>>(EmpResponse);

            }

            return returnInfo;
        }
    }
}
