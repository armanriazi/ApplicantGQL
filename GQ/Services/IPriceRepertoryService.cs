using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GQ
{
    public interface IPriceRepertoryService
    {

        Task<IEnumerable<PriceRepertoryFinancialYearsSelectListAction>> PriceRepertoryFinancialYearsSelectListActionByAccFinancialYearIdAsync(string query);
        Task<IEnumerable<BasePriceRepertorySelectListAction>> BasePriceRepertorySelectListActionByQueryAsync(string query);
        Task<IEnumerable<VMPriceRepertoryGridAction>> PriceRepertoryGridActionByParamsAsync(string accFinancialYearID,string tblPrcID,string tblPrcIDParent,string tblBprParentId, string sortExpression);
        Task<IEnumerable<BasePriceRepertoryPriceTextFieldAction>> BasePriceRepertoryPriceTextFieldActionByQueryAsync(string query);
        Task<IEnumerable<ProjectManagementSystemProjectReportGridAction>> ProjectManagementSystemProjectReportGridActionByParamsAsync(string accFinancialYearID, string tblBprID, string sortExpression, string orderBy);


    }
}
