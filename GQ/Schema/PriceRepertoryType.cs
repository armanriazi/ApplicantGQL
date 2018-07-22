using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GQ
{
    public class PriceRepertoryFinancialYearsType : ObjectGraphType<PriceRepertoryFinancialYearsSelectListAction>
    {
        public PriceRepertoryFinancialYearsType()
        {
            Field(c => c.ACC_FinancialYearID, nullable: false).Description("ACC_FinancialYearID");
            Field(c => c.ACC_FinancialYearIsDefault, nullable: true).Description("ACC_FinancialYearIsDefault");
            Field(c => c.ACC_FinancialYearName, nullable: true).Description("ACC_FinancialYearName");            
        }

    }
    public class BasePriceRepertoryType : ObjectGraphType<BasePriceRepertorySelectListAction>
    {
        public BasePriceRepertoryType()
        {
            Field(c => c.ACC_FinancialYearID, nullable: true).Description("ACC_FinancialYearID");
            Field(c => c.TBL_PrcID, nullable: true).Description("TBL_PrcID");
            Field(c => c.TBL_PrcName, nullable: false).Description("TBL_PrcName");
            Field(c => c.TBL_PrcParentID_fk, nullable: true).Description("TBL_PrcParentID_fk");            
        }

    }
    public class PriceRepertoryType : ObjectGraphType<PriceRepertoryGridAction>
    {
        public PriceRepertoryType()
        {
            Field(c => c.TBL_BprDescription, nullable: true).Description("TBL_BprDescription");
            Field(c => c.TBL_BprHasChildren, nullable: true).Description("TBL_BprHasChildren");
            Field(c => c.TBL_BprID, nullable: false).Description("TBL_BprID");
            //Field(c => c.TBL_BprNote, nullable: true).Description("TBL_BprNote");
            Field(c => c.TBL_BprParentID_fk, nullable: true).Description("TBL_BprParentID_fk");
           // Field(c => c.PriceRepertoryGridActions, nullable: true).Description("PriceRepertoryGridActions");
        }
    }
}
