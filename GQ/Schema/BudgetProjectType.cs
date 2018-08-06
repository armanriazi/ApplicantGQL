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
    public class BudgetProjectPlanIdentityType : ObjectGraphType<BudgetProjectPlanIdentity>
    {
        public BudgetProjectPlanIdentityType()
        {
            Field(c => c.BUD_ProjectCode, nullable: true).Description("BUD_ProjectCode");
            Field(c => c.BUD_ProjectApproveDate, nullable: true).Description("BUD_ProjectApproveDate");
            Field(c => c.BUD_ProjectName, nullable: true).Description("BUD_ProjectName");
            Field(c => c.BUD_ProjectAddress, nullable: true).Description("BUD_ProjectAddress");
        }

    }
}
