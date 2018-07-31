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
    public class PriceRepertoryType : ObjectGraphType<VMPriceRepertoryGridAction>
    {
        public PriceRepertoryType()
        {
            Field(c => c.Name, nullable: true, type: typeof(StringGraphType)).Description("Replace Prop-TBL_BprDescription");
            //Field(c => c.Children, nullable: true, type: typeof(ObjectGraphType<Dictionary<string,string>>)).Description("New Prop-Children");
            Field(c => c.IsExpanded, nullable: true, type: typeof(BooleanGraphType)).Description("New Prop-Collapsed");
            Field(c => c.HasChildren, nullable: true, type: typeof(BooleanGraphType)).Description("TBL_BprHasChildren");
            Field(c => c.Id, nullable: false, type: typeof(StringGraphType)).Description("New Prop-TBL_BprID");
            Field(c => c.TBL_BprParentID_fk, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprParentID_fk");
            //Field(c =>  c.Icon, nullable: true).Description("New Prop-Icon");
            //Field(c => c.Leaf, nullable: true).Description("New Prop-Leaf");
            //Field(c => c.Checked, nullable: true).Description("New Prop-Checked");
            //Field(c => c.TBL_BprNote, nullable: true).Description("TBL_BprNote");            
            //Field(c => c.PriceRepertoryGridActions, nullable: true).Description("PriceRepertoryGridActions");
        }
    }

    public class BasePriceRepertoryPriceType : ObjectGraphType<BasePriceRepertoryPriceTextFieldAction>
    {
        public BasePriceRepertoryPriceType()
        {
            Field(c => c.ACC_FinancialYearID, nullable: true, type: typeof(StringGraphType)).Description("ACC_FinancialYearID");
            Field(c => c.CNT_CbID_fk, nullable: true, type: typeof(BooleanGraphType)).Description("CNT_CbID_fk");
            Field(c => c.TBL_BprActive, nullable: true, type: typeof(BooleanGraphType)).Description("TBL_BprActive");
            Field(c => c.TBL_BprCode, nullable: false, type: typeof(StringGraphType)).Description("TBL_BprCode");
            Field(c => c.TBL_BprDeleteDate, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprDeleteDate");
            Field(c => c.TBL_BprDeparePrice1, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprDeparePrice1");
            Field(c => c.TBL_BprDeparePrice2, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprDeparePrice2");
            Field(c => c.TBL_BprDeparePrice3, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprDeparePrice3");
            Field(c => c.TBL_BprDescription, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprDescription");
            Field(c => c.TBL_BprDisposePrice, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprDisposePrice");
            Field(c => c.TBL_BprID, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprID");
            Field(c => c.TBL_BprMachineryDeparePrice, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprMachineryDeparePrice");
            Field(c => c.TBL_BprMachineryMovePrice, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprMachineryMovePrice");
            Field(c => c.TBL_BprMachineryPrice, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprMachineryPrice");
            Field(c => c.TBL_BprMaterialPrice, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprMaterialPrice");
            Field(c => c.TBL_BprNote, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprNote");
            Field(c => c.TBL_BprOldCode, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprNote");
            Field(c => c.TBL_BprParentID_fk, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprParentID_fk");
            Field(c => c.TBL_BprPayDeparePrice, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprPayDeparePrice");
            Field(c => c.TBL_BprPayMovePrice, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprPayMovePrice");
            Field(c => c.TBL_BprPayPrice, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprPayPrice");
            Field(c => c.TBL_BprQuantity, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprQuantity");
            Field(c => c.TBL_BprRegisterDate, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprRegisterDate");
            Field(c => c.TBL_BprStatus, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprStatus");
            Field(c => c.TBL_BprTransportCoefficient, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprTransportCoefficient");
            Field(c => c.TBL_BprType, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprType");
            Field(c => c.TBL_BprWarehouseCoding, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprType");
            Field(c => c.TBL_PrcID_fk, nullable: true, type: typeof(StringGraphType)).Description("TBL_PrcID_fk");
            Field(c => c.TBL_BprPrice, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprPrice");
            Field(c => c.TBL_UserID, nullable: true, type: typeof(StringGraphType)).Description("TBL_UserID");

        }
    }


    public class ProjectManagementSystemProjectReportType : ObjectGraphType<ProjectManagementSystemProjectReportGridAction>
    {
        public ProjectManagementSystemProjectReportType()
        {
            Field(c => c.ACC_FinancialYearID, nullable: true, type: typeof(StringGraphType)).Description("ACC_FinancialYearID");
            Field(c => c.TBL_BprhActive, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprhActive");
            Field(c => c.TBL_BprhDeleteDate, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprhDeleteDate");
            Field(c => c.TBL_BprhDeparePrice1, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprhDeparePrice1");
            Field(c => c.TBL_BprhDeparePrice2, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprhDeparePrice2");
            Field(c => c.TBL_BprhDeparePrice3, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprhDeparePrice3");
            Field(c => c.TBL_BprhDisposePrice, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprhDisposePrice");
            Field(c => c.TBL_BprhExecuteDate, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprhExecuteDate");
            Field(c => c.TBL_BprhExpireDate, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprhExpireDate");
            Field(c => c.TBL_BprhID, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprhID");
            Field(c => c.TBL_BprhMachineryDeparePrice, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprhMachineryDeparePrice");
            Field(c => c.TBL_BprhMachineryPrice, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprhMachineryPrice");
            Field(c => c.TBL_BprhMaterialPrice, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprhMaterialPrice");
            Field(c => c.TBL_BprhMachineyMovePrice, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprhMachineyMovePrice");
            Field(c => c.TBL_BprhNote, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprhNote");            
            Field(c => c.TBL_BprhPayDeparePrice, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprhPayDeparePrice");
            Field(c => c.TBL_BprhPayMovePrice, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprhPayMovePrice");
            Field(c => c.TBL_BprhPayPrice, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprhPayPrice");
            Field(c => c.TBL_BprhRegisterDate, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprhRegisterDate");
            Field(c => c.TBL_BprhType, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprhType");
            Field(c => c.TBL_BprhStatus, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprhStatus");
            Field(c => c.TBL_BprID_fk, nullable: true, type: typeof(StringGraphType)).Description("TBL_BprID_fk");
            Field(c => c.TBL_UserID, nullable: true, type: typeof(StringGraphType)).Description("TBL_UserID");

        }
    }
}