﻿using GQ.Schemas.Budgets;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GQ
{
    public interface IProjectManagementSystemProjectReportPlanItemsService
    {

        Task<IEnumerable<ProjectManagementSystemProjectReportPlanItems>> ProjectManagementSystemProjectReportPlanItemsByProjectIdAsync(string projectId,string orderBy);
        Task<IEnumerable<PostProjectManagementSystemProjectReportPlanDocuments>> ProjectManagementSystemProjectReportPlanDocumentsByBudgetProjectIdAsync(string budgetProjectId);
        Task<IEnumerable<PostProjectManagementSystemProjectReportPlanContractorsPrice>> ProjectManagementSystemProjectReportPlanContractorsPriceByBudgetProjectIdAsync(string budgetProjectId);
        Task<IEnumerable<PostProjectManagementSystemProjectReportAttachmentsDialog>> PostProjectManagementSystemProjectReportAttachmentsDialogByDocumentCodeAsync(string documentCode);
        Task<IEnumerable<PostProjectManagementSystemProjectReportSendToCartable>> PostProjectManagementSystemProjectReportSendToCartableByParamsAsync(string budProjectId, string nationalCode, string trackingCode, string accFinancialYearId);
        Task<IEnumerable<PostProjectManagementSystemProjectReportTechnicalPropertyItems>> ProjectManagementSystemProjectReportTechnicalPropertyItemsByParamsAsync(string budgetProjectId, string orderby, string userId, string accFinancialYearId, string desc);
        Task<IEnumerable<PostProjectManagementSystemProjectReportApprovedBudgetItems>> ProjectManagementSystemProjectReportApprovedBudgetItemsByParamsAsync(string budgetProjectId, string orderby, string userId, string accFinancialYearId, string desc);
        Task<IEnumerable<PostProjectManagementSystemProjectReportContractItems>> ProjectManagementSystemProjectReportContractItemsByParamsAsync(string budgetProjectId, string orderby, string userId, string accFinancialYearId, string desc);
        Task<IEnumerable<PostProjectManagementSystemProjectReportAgendaItems>> ProjectManagementSystemProjectReportAgendaByParamsAsync(string budgetProjectId, string orderby, string userId, string accFinancialYearId, string desc);
        Task<IEnumerable<PostProjectManagementSystemProjectReportOptionsItems>> ProjectManagementSystemProjectReportOptionsItemsByParamsAsync(string budgetProjectId, string orderby, string userId, string accFinancialYearId, string desc);

    }
}
