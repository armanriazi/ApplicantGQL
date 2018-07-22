using GraphQL.Types;

namespace GQ
{
    public class ProjectQuery : ObjectGraphType<object>
    {
        public ProjectQuery(IBudgetProjectService budgetProjectService,
            IProjectManagementSystemProjectReportPlanItemsService projectManagementSystemProjectReportPlanItemsService,
            IPriceRepertoryService priceRepertoryService)
        {
            #region budgetProjectService
            Name = "Query";
            Field<ListGraphType<BudgetProjectType>>(
                   "BudgetBycodemeli",
                   Description = "This field returns the projects of the submitted codemeli",
                   arguments: new QueryArguments(
                              new QueryArgument<StringGraphType> { Name = "codemeli" }
                   ),
                     resolve: context =>
                     {
                         var x = context.GetArgument<string>("codemeli");
                         return budgetProjectService.BudgetByCodeMeliAsync(x);
                         
                     }
               );
            #endregion
            #region projectManagementSystemProjectReportPlanItemsService
            Field<ListGraphType<ProjectManagementSystemProjectReportPlanItemsType>>(
                 "ProjectManagementSystemProjectReportPlanItemsByProjectId",
                 Description = "This field returns the projects of the submitted projectid",
                 arguments: new QueryArguments(
                            new QueryArgument<StringGraphType> { Name = "projectId" },
                            new QueryArgument<StringGraphType> { Name = "orderBy" }
                 ),
                           resolve: context => projectManagementSystemProjectReportPlanItemsService.ProjectManagementSystemProjectReportPlanItemsByProjectIdAsync(context.GetArgument<string>("projectId"), context.GetArgument<string>("orderBy"))
                     );
            Field<ListGraphType<PostProjectManagementSystemProjectReportPlanDocumentsType>>(
                   "ProjectManagementSystemProjectReportPlanDocumentsByBudgetProjectId",
                   Description = "This field returns the plan documents of the submitted budget project id",
                   arguments: new QueryArguments(
                              new QueryArgument<StringGraphType> { Name = "budgetProjectId" }
                   ),

                           resolve: context => projectManagementSystemProjectReportPlanItemsService.ProjectManagementSystemProjectReportPlanDocumentsByBudgetProjectIdAsync(context.GetArgument<string>("budgetProjectId"))
             );
            Field<ListGraphType<PostProjectManagementSystemProjectReportPlanContractorsPriceType>>(
                     "ProjectManagementSystemProjectReportPlanContractorsPriceByBudgetProjectId",
                     Description = "This field returns the plan contractors price of the submitted budget project id",
                     arguments: new QueryArguments(
                                new QueryArgument<StringGraphType> { Name = "budgetProjectId" }                        
                     ),
               
                         resolve: context => projectManagementSystemProjectReportPlanItemsService.ProjectManagementSystemProjectReportPlanContractorsPriceByBudgetProjectIdAsync(context.GetArgument<string>("budgetProjectId"))                
               );
            Field<ListGraphType<PostProjectManagementSystemProjectReportAttachmentsDialogType>>(
                   "ProjectManagementSystemProjectReportAttachmentsDialogByDocumentCode",
                   Description = "This field returns the plan contractors attachment of the plan items",
                   arguments: new QueryArguments(
                              new QueryArgument<StringGraphType> { Name = "documentCode" }
                   ),

                       resolve: context => projectManagementSystemProjectReportPlanItemsService.PostProjectManagementSystemProjectReportAttachmentsDialogByDocumentCodeAsync(context.GetArgument<string>("documentCode"))
             );

            Field<ListGraphType<PostProjectManagementSystemProjectReportSendToCartableType>>(
                 "ProjectManagementSystemProjectReportSendToCartableByParams",
                 Description = "This field returns the mesage contractors attachment of the send to cartable",
                 arguments: new QueryArguments(
                            new QueryArgument<StringGraphType> { Name = "budProjectId" },
                            new QueryArgument<StringGraphType> { Name = "nationalCode" },
                            new QueryArgument<StringGraphType> { Name = "trackingCode" },
                            new QueryArgument<StringGraphType> { Name = "accFinancialYearID" }
                 ),

                     resolve: context => projectManagementSystemProjectReportPlanItemsService.PostProjectManagementSystemProjectReportSendToCartableByParamsAsync(context.GetArgument<string>("budProjectId"), context.GetArgument<string>("nationalCode"), context.GetArgument<string>("trackingCode"), context.GetArgument<string>("accFinancialYearID"))
           );
            #endregion
            #region priceRepertoryService
            Field<ListGraphType<PriceRepertoryType>>(
                   "PriceRepertoryGridActionByParams",
                   Description = "This field returns the price repertory of the submitted params",
                   arguments: new QueryArguments(
                              new QueryArgument<StringGraphType> { Name = "accFinancialYearID" },
                               new QueryArgument<StringGraphType> { Name = "tblPrcID" },                                
                                new QueryArgument<StringGraphType> { Name = "tblPrcIDParent" },
                                new QueryArgument<StringGraphType> { Name = "tblBprParentId" },
                                 new QueryArgument<StringGraphType> { Name = "sortExpression" }
                   ),
                    resolve: context => priceRepertoryService.PriceRepertoryGridActionByParamsAsync(context.GetArgument<string>("accFinancialYearID"), context.GetArgument<string>("tblPrcID"), context.GetArgument<string>("tblPrcIDParent"), context.GetArgument<string>("tblBprParentId"), context.GetArgument<string>("sortExpression"))
             );
            Field<ListGraphType<PriceRepertoryFinancialYearsType>>(
                     "PriceRepertoryFinancialYearsSelectListActionByAccFinancialYearId",
                     Description = "This field returns the financial years of the submitted accfinancialyearid",
                     arguments: new QueryArguments(
                                new QueryArgument<StringGraphType> { Name = "qparam" }
                     ),

                         resolve: context => priceRepertoryService.PriceRepertoryFinancialYearsSelectListActionByAccFinancialYearIdAsync(context.GetArgument<string>("qparam"))
               );
            Field<ListGraphType<BasePriceRepertoryType>>(
                   "BasePriceRepertorySelectListActionByQuery",
                   Description = "This field returns the basepricerepertory of the submitted the query",
                   arguments: new QueryArguments(
                              new QueryArgument<StringGraphType> { Name = "qparam" }
                   ),

                       resolve: context => priceRepertoryService.BasePriceRepertorySelectListActionByQueryAsync(context.GetArgument<string>("qparam"))
             );
            #endregion
        }
    }
}
