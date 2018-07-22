using GraphQL.Types;

namespace GQ
{
    public class BudgetProjectType : ObjectGraphType<BudgetProject>
    {
        public BudgetProjectType()
        {          
            Field(c => c.BUD_ProjectID, nullable: false).Description("BUD_ProjectID");
            Field(c => c.ProjectName, nullable: true).Description("ProjectName");
        }
       
    }
}
