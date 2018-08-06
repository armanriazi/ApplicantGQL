using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GQ
{
    public interface IBudgetProjectService
    {

        Task<IEnumerable<BudgetProject>> BudgetByCodeMeliAsync(string codeMeli);
        Task<IEnumerable<BudgetProjectPlanIdentity>> BudgetProjectPlanByBudgetProjectIdAsync(string qparam);


    }
}
