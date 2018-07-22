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
        Task<IEnumerable<PriceRepertoryGridAction>> PriceRepertoryGridActionByParamsAsync(string accFinancialYearID,string tblPrcID,string tblPrcIDParent,string tblBprParentId, string sortExpression);


    }
}
