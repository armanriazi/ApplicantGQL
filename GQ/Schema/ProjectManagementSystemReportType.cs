using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GQ
{
    public class ProjectManagementSystemProjectReportPlanItemsType : ObjectGraphType<ProjectManagementSystemProjectReportPlanItems>
    {
        public ProjectManagementSystemProjectReportPlanItemsType()
        {
            Field(c => c.BUD_ProjectID_fk, nullable: false).Description("BUD_ProjectID_fk");
            Field(c => c.PMS_PdID, nullable: true).Description("PMS_PdID");
            Field(c => c.PMS_PdMachineryPrice, nullable: true).Description("PMS_PdMachineryPrice");
            Field(c => c.PMS_PdPayPrice, nullable: true).Description("PMS_PdPayPrice");
            Field(c => c.PMS_PdProvideWayId_fk, nullable: true).Description("PMS_PdProvideWayId_fk");
            Field(c => c.PMS_PdFirstQuantity, nullable: true).Description("PMS_PdFirstQuantity");
            Field(c => c.PMS_PdMaterialPrice, nullable: true).Description("PMS_PdMaterialPrice");
            Field(c => c.TBL_BprCode, nullable: true).Description("TBL_BprCode");
            Field(c => c.TBL_BprDescription, nullable: true).Description("TBL_BprDescription");
            Field(c => c.TBL_BprID_fk, nullable: true).Description("TBL_BprID_fk");            
            Field(c => c.WOS_WonName, nullable: true).Description("WOS_WonName");
            Field(c => c.WOS_WotNote, nullable: true).Description("WOS_WotNote");                      
            Field(c => c.Status, nullable: true).Description("Status");

        }

    }

    public class PostProjectManagementSystemProjectReportPlanDocumentsType : ObjectGraphType<PostProjectManagementSystemProjectReportPlanDocuments>
    {
        public PostProjectManagementSystemProjectReportPlanDocumentsType()
        {
            Field(c => c.PMS_PaID, nullable: true).Description("PMS_PaID");
            Field(c => c.PMS_PdtID_fk, nullable: true).Description("PMS_PdtID_fk");
            Field(c => c.PMS_PdtName, nullable: true).Description("PMS_PdtName");
            Field(c => c.PMS_PaDate, nullable: true).Description("PMS_PaDate");
            Field(c => c.PMS_PaDescription, nullable: true).Description("PMS_PaDescription");            
            //Field(c => c.ACC_FinancialYearID, nullable: false).Description("ACC_FinancialYearID");
            //Field(c => c.PMS_PaActive, nullable: true).Description("PMS_PaActive");            
            //Field(c => c.PMS_PaDeleteDate, nullable: true).Description("PMS_PaDeleteDate");

            //Field(c => c.PMS_PaNote, nullable: true).Description("PMS_PaNote");
            //Field(c => c.PMS_PaRegisterDate, nullable: true).Description("PMS_PaRegisterDate");
            //Field(c => c.PMS_PaStaus, nullable: true).Description("PMS_PaStaus");
            //Field(c => c.PMS_PaType, nullable: true).Description("PMS_PaType");
            //Field(c => c.PMS_PdtActive, nullable: true).Description("PMS_PdtActive");
            //Field(c => c.PMS_PdtDeleteDate, nullable: true).Description("PMS_PdtDeleteDate");
            //Field(c => c.PMS_PdtID, nullable: true).Description("PMS_PdtID");

            //Field(c => c.PMS_PdtNote, nullable: true).Description("PMS_PdtNote");
            //Field(c => c.PMS_PdtparentID_fk, nullable: true).Description("PMS_PdtparentID_fk");
            //Field(c => c.PMS_PdtRegisterDate, nullable: true).Description("PMS_PdtRegisterDate");
            //Field(c => c.PMS_PdtStatus, nullable: true).Description("PMS_PdtStatus");
            //Field(c => c.PMS_PdtType, nullable: true).Description("PMS_PdtType");
            //Field(c => c.TBL_UserID, nullable: true).Description("TBL_UserID");

        }

    }

    public class PostProjectManagementSystemProjectReportPlanContractorsPriceType : ObjectGraphType<PostProjectManagementSystemProjectReportPlanContractorsPrice>
    {
        public PostProjectManagementSystemProjectReportPlanContractorsPriceType()
        {
            Field(c => c.PMS_PppID, nullable: true).Description("PMS_PppID");
            Field(c => c.PMS_PppOtherCondition, nullable: true).Description("PMS_PppOtherCondition");
            Field(c => c.PMS_PppPayCondition, nullable: true).Description("PMS_PppPayCondition");
            Field(c => c.PMS_PppPrice, nullable: true).Description("PMS_PppPrice");
            Field(c => c.TBL_CustomerCapacity, nullable: true).Description("TBL_CustomerCapacity");
            Field(c => c.TBL_CustomerCredit, nullable: true).Description("TBL_CustomerCredit");
            Field(c => c.TBL_CustomerID_fk, nullable: true).Description("TBL_CustomerID_fk");
            Field(c => c.TBL_CustomerMobile, nullable: true).Description("TBL_CustomerMobile");
            Field(c => c.TBL_CustomerTitle, nullable: true).Description("TBL_CustomerTitle");
            //Field(c => c.BUD_ProjectCode, nullable: false).Description("BUD_ProjectCode");
            //Field(c => c.BUD_ProjectID, nullable: true).Description("BUD_ProjectID");
            //Field(c => c.BUD_ProjectName, nullable: true).Description("BUD_ProjectName");
            //Field(c => c.BUD_ProjectPrice, nullable: true).Description("BUD_ProjectPrice");          
            //Field(c => c.TBL_PlaceID, nullable: true).Description("TBL_PlaceID");
            //Field(c => c.TBL_PlaceName, nullable: true).Description("TBL_PlaceName");
            //Field(c => c.TBL_PrcName, nullable: true).Description("TBL_PrcName");            

        }

    }

    public class PostProjectManagementSystemProjectReportAttachmentsDialogType : ObjectGraphType<PostProjectManagementSystemProjectReportAttachmentsDialog>
    {
        public PostProjectManagementSystemProjectReportAttachmentsDialogType()
        {
            Field(c => c.DocumentID, nullable: true).Description("DocumentID");
            Field(c => c.DocumentCode, nullable: true).Description("DocumentCode");
            Field(c => c.DocumentFileType, nullable: true).Description("DocumentFileType");
            Field(c => c.DocumentName, nullable: true).Description("DocumentName");
            Field(c => c.DocumentNote, nullable: true).Description("DocumentNote");
            Field(c => c.TBL_OdName, nullable: true).Description("TBL_OdName");            

        }

    }

    public class PostProjectManagementSystemProjectReportSendToCartableType : ObjectGraphType<PostProjectManagementSystemProjectReportSendToCartable>
    {
        public PostProjectManagementSystemProjectReportSendToCartableType()
        {
            Field(c => c.OutputMessage, nullable: true).Description("OutputMessage");           
        }

    }
}
