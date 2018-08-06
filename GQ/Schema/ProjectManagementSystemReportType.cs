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
            Field(c => c.PMS_PppID, nullable: false).Description("PMS_PppID");
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

    public class ProjectManagementSystemProjectReportTechnicalPropertyItemsType : ObjectGraphType<PostProjectManagementSystemProjectReportTechnicalPropertyItems>
    {
        public ProjectManagementSystemProjectReportTechnicalPropertyItemsType()
        {
            Field(c => c.PMS_PtID, nullable: false).Description("PMS_PtID");
            //Field(c => c.BUD_ProjectID_fk, nullable: false).Description("BUD_ProjectID_fk");
            //Field(c => c.PMS_PtpID_fk, nullable: true).Description("PMS_PtpID_fk");
            //Field(c => c.RMS_SubstationID_fk, nullable: true).Description("RMS_SubstationID_fk");
            //Field(c => c.RMS_TlID_fk, nullable: true).Description("RMS_TlID_fk");
            Field(c => c.PMS_PtValue, nullable: true).Description("PMS_PtValue");
            Field(c => c.PMS_PtpNote, nullable: true).Description("PMS_PtpNote");
            //Field(c => c.PMS_PtRegisterDate, nullable: true).Description("PMS_PtRegisterDate");
            //Field(c => c.PMS_PtType, nullable: true).Description("PMS_PtType");
            //Field(c => c.PMS_PtActive, nullable: true).Description("PMS_PtActive");
            //Field(c => c.PMS_PtStatus, nullable: true).Description("PMS_PtStatus");
            //Field(c => c.PMS_PtDeleteDate, nullable: true).Description("PMS_PtDeleteDate");
            //Field(c => c.ACC_FinancialYearID, nullable: true).Description("ACC_FinancialYearID");
            //Field(c => c.TBL_UserID, nullable: true).Description("TBL_UserID");
            //Field(c => c.PMS_PtpID, nullable: true).Description("PMS_PtpID");
            //Field(c => c.PMS_PtpParentID_fk, nullable: true).Description("PMS_PtpParentID_fk");
            //Field(c => c.TBL_UnitID_fk, nullable: true).Description("TBL_UnitID_fk");
            //Field(c => c.PMS_PtpName, nullable: true).Description("PMS_PtpName");
            //Field(c => c.PMS_PtpNote, nullable: true).Description("PMS_PtpNote");
            //Field(c => c.PMS_PtpRegisterDate, nullable: true).Description("PMS_PtpRegisterDate");
            //Field(c => c.PMS_PtpType, nullable: true).Description("PMS_PtpType");
            //Field(c => c.PMS_PtpActive, nullable: true).Description("PMS_PtpActive");
            //Field(c => c.PMS_PtpStatus, nullable: true).Description("PMS_PtpStatus");
            //Field(c => c.PMS_PtpDeleteDate, nullable: true).Description("PMS_PtpDeleteDate");




        }

    }

    public class ProjectManagementSystemProjectReportApprovedBudgetItemsType : ObjectGraphType<PostProjectManagementSystemProjectReportApprovedBudgetItems>
    {
        public ProjectManagementSystemProjectReportApprovedBudgetItemsType()
        {

            Field(c => c.TBL_ResourceID, nullable: false).Description("TBL_ResourceID");
            //Field(c => c.TBL_ResourceParentID_fk, nullable: true).Description("TBL_ResourceParentID_fk");
            Field(c => c.TBL_ResourceName, nullable: true).Description("TBL_ResourceName");
            //Field(c => c.BUD_BcID, nullable: false).Description("BUD_BcID");
            //Field(c => c.BUD_BcParentID_fk, nullable: true).Description("BUD_BcParentID_fk");
            //Field(c => c.BUD_BcDescription, nullable: true).Description("BUD_BcDescription");
            //Field(c => c.BUD_BcTotalDescription, nullable: true).Description("BUD_BcTotalDescription");
            //Field(c => c.BUD_BcActive, nullable: true).Description("BUD_BcActive");
            Field(c => c.BUD_RcID, nullable: true).Description("BUD_RcID");
            Field(c => c.BUD_RcName, nullable: true).Description("BUD_RcName");
            Field(c => c.BUD_BaID, nullable: true).Description("BUD_BaID ");
            //Field(c => c.BUD_BaParentID_fk, nullable: true).Description("BUD_BaParentID_fk");
            Field(c => c.BUD_BaDebit, nullable: true).Description("BUD_BaDebit");
            Field(c => c.BUD_BaCredit, nullable: true).Description("BUD_BaCredit");
            //Field(c => c.TBL_DepartmentName, nullable: true).Description("TBL_DepartmentName");
            //Field(c => c.TBL_DepartmentDescription, nullable: true).Description("TBL_DepartmentDescription");
            //Field(c => c.TBL_DepartmentID, nullable: true).Description("TBL_DepartmentID");
            //Field(c => c.BUD_BaActive, nullable: true).Description("BUD_BaActive");
            //Field(c => c.BUD_BcID_fk, nullable: true).Description("BUD_BcID_fk");
            //Field(c => c.TBL_PlaceID_fk, nullable: true).Description("TBL_PlaceID_fk");
            //Field(c => c.BUD_RcID_fk, nullable: true).Description("BUD_RcID_fk");
            //Field(c => c.TBL_DepartmentID_fk, nullable: true).Description("TBL_DepartmentID_fk");
            //Field(c => c.ACC_FinancialYearID, nullable: true).Description("ACC_FinancialYearID");
            //Field(c => c.TBL_UserID, nullable: true).Description("TBL_UserID");
            //Field(c => c.BUD_ProjectName, nullable: true).Description("BUD_ProjectName");
            //Field(c => c.BUD_ProjectAccountCode, nullable: true).Description("BUD_ProjectAccountCode");
            //Field(c => c.BUD_ProjectPlanNo, nullable: true).Description("BUD_ProjectPlanNo");
            //Field(c => c.BUD_ProjectPrice, nullable: true).Description("BUD_ProjectPrice");
            //Field(c => c.BUD_ProjectID_fk, nullable: true).Description("BUD_ProjectID_fk");
            //Field(c => c.TBL_PlaceID, nullable: true).Description("TBL_PlaceID");
            //Field(c => c.TBL_PlaceNote, nullable: true).Description("TBL_PlaceNote");
            Field(c => c.TBL_PlaceName, nullable: true).Description("TBL_PlaceName");
            //Field(c => c.WOS_WonID, nullable: true).Description("WOS_WonID");
            //Field(c => c.WOS_WonID_fk, nullable: true).Description("WOS_WonID_fk");
            //Field(c => c.WOS_WotID_fk, nullable: true).Description("WOS_WotID_fk");
            //Field(c => c.BUD_BdtID_fk, nullable: true).Description("BUD_BdtID_fk");
            //Field(c => c.PMS_PcID_fk, nullable: true).Description("PMS_PcID_fk");
            //Field(c => c.BUD_BdtID, nullable: true).Description("BUD_BdtID");
            //Field(c => c.PMS_PcName, nullable: true).Description("PMS_PcName");
            //Field(c => c.BUD_BdtName, nullable: true).Description("BUD_BdtName");
            //Field(c => c.WOS_WotName, nullable: true).Description("WOS_WotName");
            //Field(c => c.WOS_WotNote, nullable: true).Description("WOS_WotNote");
            //Field(c => c.WOS_WonName, nullable: true).Description("WOS_WonName");
            //Field(c => c.WOS_WonNote, nullable: true).Description("WOS_WonNote");
            //Field(c => c.BUD_BaNote, nullable: true).Description("BUD_BaNote");
            //Field(c => c.BUD_BaRegisterDate, nullable: true).Description("BUD_BaRegisterDate");
            //Field(c => c.BUD_BaType, nullable: true).Description("BUD_BaType");
            //Field(c => c.BUD_BaStatus, nullable: true).Description("BUD_BaStatus");
            //Field(c => c.BUD_BaDeleteDate, nullable: true).Description("BUD_BaDeleteDate");
            //Field(c => c.Bud_TamarkozCode, nullable: true).Description("Bud_TamarkozCode");
            //Field(c => c.Bud_SubTamarkozCode, nullable: true).Description("Bud_SubTamarkozCode");
            //Field(c => c.Bud_TamarkozName, nullable: true).Description("Bud_TamarkozName");
            //Field(c => c.Bud_SubTamarkozName, nullable: true).Description("Bud_SubTamarkozName");
            //Field(c => c.TBL_ResourceNote, nullable: true).Description("TBL_ResourceNote");
            //Field(c => c.BUD_BaEstimateContent1, nullable: true).Description("BUD_BaEstimateContent1");
            //Field(c => c.BUD_BaEstimateContent2, nullable: true).Description("BUD_BaEstimateContent2");
            //Field(c => c.BUD_BaEstimateContent3, nullable: true).Description("BUD_BaEstimateContent3");
            Field(c => c.BUD_BaOfferPrice, nullable: true).Description("BUD_BaOfferPrice");
            //Field(c => c.FinancialYearID, nullable: true).Description("FinancialYearID");
            //Field(c => c.Type, nullable: true).Description("Type");

        }
    }

    public class ProjectManagementSystemProjectReportContractItemsType : ObjectGraphType<PostProjectManagementSystemProjectReportContractItems>
    {
        public ProjectManagementSystemProjectReportContractItemsType()
        {

            //Field(c => c.WOS_WocID, nullable: false).Description("WOS_WocID");
            //Field(c => c.WOS_WoID_fk, nullable: true).Description("WOS_WoID_fk");
            //Field(c => c.BUD_ProjectID_fk, nullable: false).Description("BUD_ProjectID_fk");
            //Field(c => c.CNT_ContractID_fk, nullable: true).Description("CNT_ContractID_fk");
            //Field(c => c.WOS_WocRecordTemproryNo, nullable: true).Description("WOS_WocRecordTemproryNo");
            //Field(c => c.WOS_WocRecordPermanentNo, nullable: true).Description("WOS_WocRecordPermanentNo");
            //Field(c => c.WOS_WocRecordTemproryDate, nullable: true).Description("WOS_WocRecordTemproryDate");
            //Field(c => c.WOS_WocRecordPermanentDate, nullable: true).Description("WOS_WocRecordPermanentDate");
            //Field(c => c.WOS_WocShare, nullable: true).Description("WOS_WocShare");
            //Field(c => c.WOS_WocNote, nullable: true).Description("WOS_WocNote");
            //Field(c => c.WOS_WocActive, nullable: true).Description("WOS_WocActive");
            //Field(c => c.WOS_WocRegisterDate, nullable: true).Description("WOS_WocRegisterDate");
            //Field(c => c.WOS_WocDeleteDate, nullable: true).Description("WOS_WocDeleteDate");
            //Field(c => c.WOS_WocStatus, nullable: true).Description("WOS_WocStatus");
            //Field(c => c.WOS_WocType, nullable: true).Description("WOS_WocType");
            //Field(c => c.ACC_FinancialYearID, nullable: true).Description("ACC_FinancialYearID");
            //Field(c => c.TBL_UserID, nullable: true).Description("TBL_UserID");
            //Field(c => c.PMS_PnID_fk, nullable: true).Description("PMS_PnID_fk");
            //Field(c => c.PMS_PsID_fk, nullable: true).Description("PMS_PsID_fk");
            //Field(c => c.PMS_PcID_fk, nullable: true).Description("PMS_PcID_fk");
            //Field(c => c.TBL_PlaceID_fk, nullable: true).Description("TBL_PlaceID_fk");
            //Field(c => c.BUD_ProjectName, nullable: true).Description("BUD_ProjectName");
            //Field(c => c.BUD_ProjectPrice, nullable: true).Description("BUD_ProjectPrice");
            //Field(c => c.CNT_ContractID, nullable: true).Description("CNT_ContractID");
            //Field(c => c.TBL_CustomerID_fk, nullable: true).Description("TBL_CustomerID_fk");
            //Field(c => c.TBL_ResourceID_fk, nullable: true).Description("TBL_ResourceID_fk");
            //Field(c => c.CNT_CtID_fk, nullable: true).Description("CNT_CtID_fk");
            //Field(c => c.TBL_AdviserID_fk, nullable: true).Description("TBL_AdviserID_fk");
            //Field(c => c.TBL_SupervisorID_fk, nullable: true).Description("TBL_SupervisorID_fk");
            Field(c => c.CNT_ContractCode, nullable: true).Description("CNT_ContractCode ");
            Field(c => c.CNT_ContractTitle, nullable: true).Description("CNT_ContractTitle");
            Field(c => c.CustomerTitle, nullable: true).Description("CustomerTitle");
            //Field(c => c.AdviserTitle, nullable: true).Description("AdviserTitle");
            //Field(c => c.SupervisorTitle, nullable: true).Description("SupervisorTitle  ");
            //Field(c => c.BUD_ProjectApproveDate, nullable: true).Description("BUD_ProjectApproveDate");
            Field(c => c.CNT_ContractPrice, nullable: true).Description("CNT_ContractPrice");
            //Field(c => c.WOS_WoTitle, nullable: true).Description("WOS_WoTitle");
            //Field(c => c.WOS_WoEstimatedPrice, nullable: true).Description("WOS_WoEstimatedPrice");
            //Field(c => c.WOS_WotID_fk, nullable: true).Description("WOS_WotID_fk");
            //Field(c => c.WOS_WotName, nullable: true).Description("WOS_WotName");
            //Field(c => c.TBL_CrtID_fk, nullable: true).Description("TBL_CrtID_fk");
            //Field(c => c.WOS_WoID, nullable: true).Description("WOS_WoID");
            //Field(c => c.WOS_WoParentID_fk, nullable: true).Description("WOS_WoParentID_fk");
            //Field(c => c.TBL_FormID_fk, nullable: true).Description("TBL_FormID_fk");
            //Field(c => c.WOS_WonID_fk, nullable: true).Description("WOS_WonID_fk");
            //Field(c => c.TBL_DepartmentID_fk, nullable: true).Description("TBL_DepartmentID_fk");
            //Field(c => c.TBL_PrcID_fk, nullable: true).Description("TBL_PrcID_fk");
            //Field(c => c.WOS_WoRefrenceID_fk, nullable: true).Description("WOS_WoRefrenceID_fk");
            //Field(c => c.WOS_WoEndDate, nullable: true).Description("WOS_WoEndDate");
            //Field(c => c.WOS_WoStartDate, nullable: true).Description("WOS_WoStartDate");
            //Field(c => c.WOS_WoInternalMaterial, nullable: true).Description("WOS_WoInternalMaterial");
            //Field(c => c.WOS_WoExternalMaterial, nullable: true).Description("WOS_WoExternalMaterial");
            //Field(c => c.WOS_WoInternalTransport, nullable: true).Description("WOS_WoInternalTransport");
            //Field(c => c.WOS_WoInternalResourceWage, nullable: true).Description("WOS_WoInternalResourceWage");
            //Field(c => c.WOS_WoInternalResourceScoria, nullable: true).Description("WOS_WoInternalResourceScoria");
            //Field(c => c.WOS_WoInternalResourceDispose, nullable: true).Description("WOS_WoInternalResourceDispose");
            //Field(c => c.WOS_WoExternalTransport, nullable: true).Description("WOS_WoExternalTransport");
            //Field(c => c.WOS_WoExternalResourceScoria, nullable: true).Description("WOS_WoExternalResourceScoria");
            //Field(c => c.WOS_WoExternalResourceWage, nullable: true).Description("WOS_WoExternalResourceWage");
            //Field(c => c.WOS_WoExternalResourceDispose, nullable: true).Description("WOS_WoExternalResourceDispose");
            //Field(c => c.BUD_ProjectID, nullable: true).Description("BUD_ProjectID");
            //Field(c => c.WOS_WonName, nullable: true).Description("WOS_WonName");
            //Field(c => c.TBL_PrcName, nullable: true).Description("TBL_PrcName");
            //Field(c => c.TBL_PrcNote, nullable: true).Description("TBL_PrcNote");
            //Field(c => c.WOS_WosID_fk, nullable: true).Description("WOS_WosID_fk");
            //Field(c => c.WOS_WosName, nullable: true).Description("WOS_WosName");
            //Field(c => c.WOS_WosNote, nullable: true).Description("WOS_WosNote");
            //Field(c => c.PMS_PcName, nullable: true).Description("PMS_PcName");
            //Field(c => c.PMS_PcNote, nullable: true).Description("PMS_PcNote");
            //Field(c => c.FinancialYearWos, nullable: true).Description("FinancialYearWos");
            //Field(c => c.BUD_ProjectCode, nullable: true).Description("BUD_ProjectCode");
            //Field(c => c.BUD_ProjectAddress, nullable: true).Description("BUD_ProjectAddress");
            //Field(c => c.WOS_AtName, nullable: true).Description("WOS_AtName");
            //Field(c => c.WOS_AtNote, nullable: true).Description("WOS_AtNote");
            //Field(c => c.WOS_AtParentID_fk, nullable: true).Description("WOS_AtParentID_fk");
            //Field(c => c.PcName, nullable: true).Description("PcName");
            //Field(c => c.PcNote, nullable: true).Description("PcNote");
            //Field(c => c.BUD_ProjectStartDate, nullable: true).Description("BUD_ProjectStartDate");
            //Field(c => c.BUD_ProjectEndDate, nullable: true).Description("BUD_ProjectEndDate");
            //Field(c => c.TBL_PlaceID, nullable: true).Description("TBL_PlaceID");
            //Field(c => c.TBL_PlaceName, nullable: true).Description("TBL_PlaceName");
            //Field(c => c.CNT_FinancialYearID, nullable: true).Description("CNT_FinancialYearID");
            Field(c => c.CrtName, nullable: true).Description("CrtName");
        }
    }

    public class ProjectManagementSystemProjectReportAgendaType : ObjectGraphType<PostProjectManagementSystemProjectReportAgendaItems>
    {
        public ProjectManagementSystemProjectReportAgendaType()
        {
            //Field(c => c.WOS_WocID, nullable: true).Description("WOS_WocID");
            //Field(c => c.WOS_WoID_fk, nullable: true).Description("WOS_WoID_fk");
            //Field(c => c.BUD_ProjectID_fk, nullable: true).Description("BUD_ProjectID_fk");
            //Field(c => c.CNT_ContractID_fk, nullable: true).Description("CNT_ContractID_fk");
            //Field(c => c.WOS_WocRecordTemproryNo, nullable: true).Description("WOS_WocRecordTemproryNo");
            //Field(c => c.WOS_WocRecordPermanentNo, nullable: true).Description("WOS_WocRecordPermanentNo");
            //Field(c => c.WOS_WocRecordTemproryDate, nullable: true).Description("WOS_WocRecordTemproryDate");
            //Field(c => c.WOS_WocRecordPermanentDate, nullable: true).Description("WOS_WocRecordPermanentDate");
            //Field(c => c.WOS_WocShare, nullable: true).Description("WOS_WocShare");
            //Field(c => c.WOS_WocNote, nullable: true).Description("WOS_WocNote");
            //Field(c => c.WOS_WocActive, nullable: true).Description("WOS_WocActive");
            //Field(c => c.WOS_WocRegisterDate, nullable: true).Description("WOS_WocRegisterDate");
            //Field(c => c.WOS_WocDeleteDate, nullable: true).Description("WOS_WocDeleteDate");
            //Field(c => c.WOS_WocStatus, nullable: true).Description("WOS_WocStatus");
            //Field(c => c.WOS_WocType, nullable: true).Description("WOS_WocType");
            //Field(c => c.ACC_FinancialYearID, nullable: true).Description("ACC_FinancialYearID");
            //Field(c => c.TBL_UserID, nullable: true).Description("TBL_UserID");
            //Field(c => c.PMS_PnID_fk, nullable: true).Description("PMS_PnID_fk");
            //Field(c => c.PMS_PsID_fk, nullable: true).Description("PMS_PsID_fk");
            //Field(c => c.PMS_PcID_fk, nullable: true).Description("PMS_PcID_fk");
            //Field(c => c.TBL_PlaceID_fk, nullable: true).Description("TBL_PlaceID_fk");
            //Field(c => c.BUD_ProjectName, nullable: true).Description("BUD_ProjectName");
            //Field(c => c.BUD_ProjectPrice, nullable: true).Description("BUD_ProjectPrice");
            //Field(c => c.CNT_ContractID, nullable: true).Description("CNT_ContractID");
            //Field(c => c.TBL_CustomerID_fk, nullable: true).Description("TBL_CustomerID_fk");
            //Field(c => c.TBL_ResourceID_fk, nullable: true).Description("TBL_ResourceID_fk");
            //Field(c => c.CNT_CtID_fk, nullable: true).Description("CNT_CtID_fk");
            //Field(c => c.TBL_AdviserID_fk, nullable: true).Description("TBL_AdviserID_fk");
            //Field(c => c.TBL_SupervisorID_fk, nullable: true).Description("TBL_SupervisorID_fk");
            //Field(c => c.CNT_ContractCode, nullable: true).Description("CNT_ContractCode");
            //Field(c => c.CNT_ContractTitle, nullable: true).Description("CNT_ContractTitle");
            //Field(c => c.CustomerTitle, nullable: true).Description("CustomerTitle");
            //Field(c => c.AdviserTitle, nullable: true).Description("AdviserTitle");
            //Field(c => c.SupervisorTitle, nullable: true).Description("SupervisorTitle");
            //Field(c => c.BUD_ProjectApproveDate, nullable: true).Description("BUD_ProjectApproveDate");
            //Field(c => c.CNT_ContractPrice, nullable: true).Description("CNT_ContractPrice");
            //Field(c => c.WOS_WoTitle, nullable: true).Description("WOS_WoTitle");
            Field(c => c.WOS_WoEstimatedPrice, nullable: true).Description("WOS_WoEstimatedPrice");
            //Field(c => c.WOS_WotID_fk, nullable: true).Description("WOS_WotID_fk");
            //Field(c => c.WOS_WotName, nullable: true).Description("WOS_WotName");
            //Field(c => c.TBL_CrtID_fk, nullable: true).Description("TBL_CrtID_fk");
            Field(c => c.WOS_WoID, nullable: true).Description("WOS_WoID");
            //Field(c => c.WOS_WoParentID_fk, nullable: true).Description("WOS_WoParentID_fk");
            //Field(c => c.TBL_FormID_fk, nullable: true).Description("TBL_FormID_fk");
            //Field(c => c.WOS_WonID_fk, nullable: true).Description("WOS_WonID_fk");
            //Field(c => c.TBL_DepartmentID_fk, nullable: true).Description("TBL_DepartmentID_fk");
            //Field(c => c.TBL_PrcID_fk, nullable: true).Description("TBL_PrcID_fk");
            //Field(c => c.WOS_WoRefrenceID_fk, nullable: true).Description("WOS_WoRefrenceID_fk");
            //Field(c => c.WOS_WoEndDate, nullable: true).Description("WOS_WoEndDate");
            //Field(c => c.WOS_WoStartDate, nullable: true).Description("WOS_WoStartDate");
            //Field(c => c.WOS_WoInternalMaterial, nullable: true).Description("WOS_WoInternalMaterial");
            //Field(c => c.WOS_WoExternalMaterial, nullable: true).Description("WOS_WoExternalMaterial");
            //Field(c => c.WOS_WoInternalTransport, nullable: true).Description("WOS_WoInternalTransport");
            //Field(c => c.WOS_WoInternalResourceWage, nullable: true).Description("WOS_WoInternalResourceWage");
            //Field(c => c.WOS_WoInternalResourceScoria, nullable: true).Description("WOS_WoInternalResourceScoria");
            //Field(c => c.WOS_WoInternalResourceDispose, nullable: true).Description("WOS_WoInternalResourceDispose");
            //Field(c => c.WOS_WoExternalTransport, nullable: true).Description("WOS_WoExternalTransport");
            //Field(c => c.WOS_WoExternalResourceScoria, nullable: true).Description("WOS_WoExternalResourceScoria");
            //Field(c => c.WOS_WoExternalResourceWage, nullable: true).Description("WOS_WoExternalResourceWage");
            //Field(c => c.WOS_WoExternalResourceDispose, nullable: true).Description("WOS_WoExternalResourceDispose");
            //Field(c => c.BUD_ProjectID, nullable: true).Description("BUD_ProjectID");
            //Field(c => c.WOS_WonName, nullable: true).Description("WOS_WonName");
            Field(c => c.TBL_PrcName, nullable: true).Description("TBL_PrcName");
            //Field(c => c.TBL_PrcNote, nullable: true).Description("TBL_PrcNote");
            //Field(c => c.WOS_WosID_fk, nullable: true).Description("WOS_WosID_fk");
            Field(c => c.WOS_WosName, nullable: true).Description("WOS_WosName");
            //Field(c => c.WOS_WosNote, nullable: true).Description("WOS_WosNote");
            Field(c => c.PMS_PcName, nullable: true).Description("PMS_PcName");
            //Field(c => c.PMS_PcNote, nullable: true).Description("PMS_PcNote");
            Field(c => c.FinancialYearWos, nullable: true).Description("FinancialYearWos");
            //Field(c => c.BUD_ProjectCode, nullable: true).Description("BUD_ProjectCode");
            //Field(c => c.BUD_ProjectAddress, nullable: true).Description("BUD_ProjectAddress");
            Field(c => c.WOS_AtName, nullable: true).Description("WOS_AtName");
            Field(c => c.WOS_AtNote, nullable: true).Description("WOS_AtNote");
            //Field(c => c.WOS_AtParentID_fk, nullable: true).Description("WOS_AtParentID_fk");
            Field(c => c.PcName, nullable: true).Description("PcName");
            //Field(c => c.PcNote, nullable: true).Description("PcNote");
            //Field(c => c.BUD_ProjectStartDate, nullable: true).Description("BUD_ProjectStartDate");
            //Field(c => c.BUD_ProjectEndDate, nullable: true).Description("BUD_ProjectEndDate");
            //Field(c => c.TBL_PlaceID, nullable: true).Description("TBL_PlaceID");
            //Field(c => c.TBL_PlaceName, nullable: true).Description("TBL_PlaceName");
            //Field(c => c.CNT_FinancialYearID, nullable: true).Description("CNT_FinancialYearID");


        }
    }

    public class ProjectManagementSystemProjectReportOptionsItemsType : ObjectGraphType<PostProjectManagementSystemProjectReportOptionsItems>
    {
        public ProjectManagementSystemProjectReportOptionsItemsType()
        {
            //Field(c => c.PMS_PdID, nullable: false).Description("PMS_PdID");
            //Field(c => c.BUD_ProjectID_fk, nullable: true).Description("BUD_ProjectID_fk");
            //Field(c => c.WHS_WarehouseID_fk, nullable: true).Description("WHS_WarehouseID_fk");
            //Field(c => c.WHS_GoodsID_fk, nullable: true).Description("WHS_GoodsID_fk");
            //Field(c => c.COM_ServiceID_fk, nullable: true).Description("COM_ServiceID_fk");
            //Field(c => c.TBL_BprID_fk, nullable: false).Description("TBL_BprID_fk");
            //Field(c => c.WOS_WotID_fk, nullable: true).Description("WOS_WotID_fk");
            //Field(c => c.WOS_WonID_fk, nullable: true).Description("WOS_WonID_fk");
            Field(c => c.PMS_PdProvideWayId_fk, nullable: true).Description("PMS_PdProvideWayId_fk");
            Field(c => c.PMS_PdFirstQuantity, nullable: true).Description("PMS_PdFirstQuantity");
            //Field(c => c.PMS_PdQuantity, nullable: true).Description("PMS_PdQuantity");
            //Field(c => c.PMS_PdFinalQuantity, nullable: true).Description("PMS_PdFinalQuantity");
            //Field(c => c.PMS_PdDeparePrice, nullable: true).Description("PMS_PdDeparePrice");
            //Field(c => c.PMS_PdPayPrice, nullable: true).Description("PMS_PdPayPrice");
            //Field(c => c.PMS_PdDisposePrice, nullable: true).Description("PMS_PdDisposePrice");
            //Field(c => c.PMS_PdMaterialPrice, nullable: true).Description("PMS_PdMaterialPrice");
            //Field(c => c.PMS_PdMachineryPrice, nullable: true).Description("PMS_PdMachineryPrice");
            //Field(c => c.PMS_PdPrice, nullable: true).Description("PMS_PdPrice");
            //Field(c => c.PMS_PdDescription, nullable: true).Description("PMS_PdDescription");
            //Field(c => c.PMS_PdType, nullable: true).Description("PMS_PdType");
            //Field(c => c.PMS_PdNote, nullable: true).Description("PMS_PdNote");
            //Field(c => c.PMS_PdRegisterDate, nullable: true).Description("PMS_PdRegisterDate");
            //Field(c => c.PMS_PdActive, nullable: true).Description("PMS_PdActive");
            //Field(c => c.PMS_PdStatus, nullable: true).Description("PMS_PdStatus");
            //Field(c => c.PMS_PdDeleteDate, nullable: true).Description("PMS_PdDeleteDate");
            //Field(c => c.ACC_FinancialYearID, nullable: true).Description("ACC_FinancialYearID");
            //Field(c => c.TBL_UserID, nullable: true).Description("TBL_UserID");
            //Field(c => c.TBL_BprID, nullable: true).Description("TBL_BprID");
            //Field(c => c.TBL_BprParentID_fk, nullable: true).Description("TBL_BprParentID_fk");
            //Field(c => c.TBL_PrcID_fk, nullable: true).Description("TBL_PrcID_fk");
            //Field(c => c.WHS_GuID_fk, nullable: true).Description("WHS_GuID_fk");
            //Field(c => c.CNT_CbID_fk, nullable: true).Description("CNT_CbID_fk");
            Field(c => c.TBL_BprCode, nullable: true).Description("TBL_BprCode");
            //Field(c => c.TBL_BprOldCode, nullable: true).Description("TBL_BprOldCode");
            Field(c => c.TBL_BprDescription, nullable: true).Description("TBL_BprDescription");
            //Field(c => c.TBL_BprWarehouseCoding, nullable: true).Description("TBL_BprWarehouseCoding");
            //Field(c => c.TBL_BprTransportCoefficient, nullable: true).Description("TBL_BprTransportCoefficient");
            //Field(c => c.TBL_BprMaterialPrice, nullable: true).Description("TBL_BprMaterialPrice         ");
            //Field(c => c.TBL_BprPayPrice, nullable: true).Description("TBL_BprPayPrice");
            //Field(c => c.TBL_BprMachineryPrice, nullable: true).Description("TBL_BprMachineryPrice");
            //Field(c => c.TBL_BprDeparePrice1, nullable: true).Description("TBL_BprDeparePrice1");
            //Field(c => c.TBL_BprDeparePrice2, nullable: true).Description("TBL_BprDeparePrice2");
            //Field(c => c.TBL_BprDeparePrice3, nullable: true).Description("TBL_BprDeparePrice3");
            //Field(c => c.TBL_BprMachineryDeparePrice, nullable: true).Description("TBL_BprMachineryDeparePrice");
            //Field(c => c.TBL_BprPayDeparePrice, nullable: true).Description("TBL_BprPayDeparePrice");
            //Field(c => c.TBL_BprDisposePrice, nullable: true).Description("TBL_BprDisposePrice");
            //Field(c => c.TBL_BprMachineryMovePrice, nullable: true).Description("TBL_BprMachineryMovePrice");
            //Field(c => c.TBL_BprPayMovePrice, nullable: true).Description("TBL_BprPayMovePrice");
            //Field(c => c.TBL_BprPrice, nullable: true).Description("TBL_BprPrice");
            //Field(c => c.TBL_BprQuantity, nullable: true).Description("TBL_BprQuantity");
            //Field(c => c.TBL_BprNote, nullable: true).Description("TBL_BprNote");
            //Field(c => c.TBL_BprType, nullable: true).Description("TBL_BprType");
            //Field(c => c.TBL_BprActive, nullable: true).Description("TBL_BprActive");
            //Field(c => c.TBL_BprStatus, nullable: true).Description("TBL_BprStatus");
            //Field(c => c.TBL_BprRegisterDate, nullable: true).Description("TBL_BprRegisterDate");
            //Field(c => c.TBL_BprDeleteDate, nullable: true).Description("TBL_BprDeleteDate");
            //Field(c => c.WOS_WonID, nullable: true).Description("WOS_WonID");
            //Field(c => c.WOS_WonParentID_fk, nullable: true).Description("WOS_WonParentID_fk");
            //Field(c => c.WOS_WonSystemCode, nullable: true).Description("WOS_WonSystemCode");
            Field(c => c.WOS_WonName, nullable: true).Description("WOS_WonName");
            //Field(c => c.WOS_WonNote, nullable: true).Description("WOS_WonNote");
            //Field(c => c.WOS_WonRegisterDate, nullable: true).Description("WOS_WonRegisterDate");
            //Field(c => c.WOS_WonType, nullable: true).Description("WOS_WonType");
            //Field(c => c.WOS_WonActive, nullable: true).Description("WOS_WonActive");
            //Field(c => c.WOS_WonStatus, nullable: true).Description("WOS_WonStatus");
            //Field(c => c.WOS_WonDeleteDate, nullable: true).Description("WOS_WonDeleteDate");
            //Field(c => c.WOS_WotID, nullable: true).Description("WOS_WotID");
            //Field(c => c.WOS_WotParentID_fk, nullable: true).Description("WOS_WotParentID_fk");
            //Field(c => c.ACC_AcID_fk, nullable: true).Description("ACC_AcID_fk");
            //Field(c => c.WOS_WotSystemCode, nullable: true).Description("WOS_WotSystemCode");
            //Field(c => c.WOS_WotName, nullable: true).Description("WOS_WotName");
            //Field(c => c.WOS_WotWageCoefficient, nullable: true).Description("WOS_WotWageCoefficient");
            Field(c => c.WOS_WotNote, nullable: true).Description("WOS_WotNote");
            //Field(c => c.WOS_WotRegisterDate, nullable: true).Description("WOS_WotRegisterDate");
            //Field(c => c.WOS_WotType, nullable: true).Description("WOS_WotType");
            //Field(c => c.WOS_WotActive, nullable: true).Description("WOS_WotActive");
            //Field(c => c.WOS_WotStatus, nullable: true).Description("WOS_WotStatus");
            //Field(c => c.WOS_WotDeleteDate, nullable: true).Description("WOS_WotDeleteDate");
            //Field(c => c.Status, nullable: true).Description("Status");


        }
    }

    public class ProjectManagementSystemProjectReportExecutionAgentsType : ObjectGraphType<PostProjectManagementSystemProjectExecutionAgents>
    {
        public ProjectManagementSystemProjectReportExecutionAgentsType()
        {
            //Field(c => c.BUD_PepID, nullable: false).Description(" BUD_PepID");
            //Field(c => c.CNT_CetID_fk, nullable: true).Description(" CNT_CetID_fk");
            //Field(c => c.BUD_ProjectID_fk, nullable: true).Description(" BUD_ProjectID_fk");
            Field(c => c.TBL_CustomerID_fk, nullable: true).Description(" TBL_CustomerID_fk");
            Field(c => c.BUD_PepDescription, nullable: true).Description(" BUD_PepDescription");
            Field(c => c.BUD_PepStartDate, nullable: true).Description(" BUD_PepStartDate");
            Field(c => c.BUD_PepEndDate, nullable: true).Description(" BUD_PepEndDate");
            //Field(c => c.BUD_PepLetterNo, nullable: true).Description(" BUD_PepLetterNo");
            //Field(c => c.BUD_PepLetterDate, nullable: true).Description(" BUD_PepLetterDate");
            //Field(c => c.BUD_PepAddress, nullable: true).Description(" BUD_PepAddress");
            Field(c => c.BUD_PepMobail, nullable: true).Description(" BUD_PepMobail");
            Field(c => c.BUD_PepJob, nullable: true).Description(" BUD_PepJob ");
            //Field(c => c.BUD_PepDaily, nullable: true).Description(" BUD_PepDaily");
            //Field(c => c.BUD_PepOverTime, nullable: true).Description(" BUD_PepOverTime");
            //Field(c => c.BUD_PepNote, nullable: true).Description(" BUD_PepNote");
            //Field(c => c.BUD_PepActive, nullable: true).Description(" BUD_PepActive");
            //Field(c => c.BUD_PepStatus, nullable: true).Description(" BUD_PepStatus");
            //Field(c => c.BUD_PepType, nullable: true).Description(" BUD_PepType");
            //Field(c => c.BUD_PepRegisterDate, nullable: true).Description(" BUD_PepRegisterDate ");
            //Field(c => c.BUD_PepDeleteDate, nullable: true).Description(" BUD_PepDeleteDate");
            //Field(c => c.ACC_FinancialYearID, nullable: true).Description(" ACC_FinancialYearID");
            //Field(c => c.TBL_UserID, nullable: true).Description(" TBL_UserID ");
            //Field(c => c.CNT_CetDescription, nullable: true).Description(" CNT_CetDescription");
            Field(c => c.CNT_CetNote, nullable: true).Description(" CNT_CetNote");
            //Field(c => c.CNT_CetActive, nullable: true).Description(" CNT_CetActive");
            //Field(c => c.CNT_CetStatus, nullable: true).Description(" CNT_CetStatus");
            //Field(c => c.CNT_CetType, nullable: true).Description(" CNT_CetType");
        }
    }

    public class ProjectManagementSystemProjectReportSupervistoryHistoryType : ObjectGraphType<PostProjectManagementSystemProjectSupervistoryHistory>
    {
        public ProjectManagementSystemProjectReportSupervistoryHistoryType()
        {
            //Field(c => c.PMS_WbsprID, nullable: false).Description("PMS_WbsprID");
            //Field(c => c.PMS_PshID, nullable: false).Description("PMS_PshID");
            //Field(c => c.PMS_PshLetterDate, nullable: false).Description("PMS_PshLetterDate");
            //Field(c => c.PMS_PshLetterNo, nullable: false).Description("PMS_PshLetterNo");
            Field(c => c.PMS_PshDate, nullable: false).Description("PMS_PshDate");
            Field(c => c.PMS_PshDescription, nullable: false).Description("PMS_PshDescription");
            //Field(c => c.WOS_WoID_fk, nullable: false).Description("WOS_WoID_fk");
            //Field(c => c.PMS_PshActive, nullable: false).Description("PMS_PshActive");
            //Field(c => c.BUD_ProjectID_fk, nullable: false).Description("BUD_ProjectID_fk");
            //Field(c => c.TBL_FormID_fk, nullable: false).Description("TBL_FormID_fk");
            Field(c => c.TBL_FormFarsiName, nullable: false).Description("TBL_FormFarsiName");
            //Field(c => c.color, nullable: false).Description("color");
        }

    }

    public class ProjectManagementSystemProjectReportPhysicalExtendType : ObjectGraphType<VMProjectManagementSystemProjectPhysicalExtend>
    {
        public ProjectManagementSystemProjectReportPhysicalExtendType()
        {
            //Field(c => c.PMS_WbsprID                                , nullable: false).Description("PMS_WbsprID");  
            //Field(c => c.BUD_ProjectID_fk                           , nullable: false).Description("BUD_ProjectID_fk");  
            Field(c => c.WOS_WoID_fk, nullable: true).Description("WOS_WoID_fk");
            Field(c => c.PMS_WbsprDate, nullable: true).Description("PMS_WbsprDate");
            //Field(c => c.PMS_WbsprNextReviewDate                    , nullable: true).Description("PMS_WbsprNextReviewDate"); 
            Field(c => c.PMS_WbsprLetterDate, nullable: true).Description("PMS_WbsprLetterDate");
            Field(c => c.PMS_WbsprLetterNo, nullable: true).Description("PMS_WbsprLetterNo");
            Field(c => c.PMS_WbsprTitle, nullable: true).Description("PMS_WbsprTitle");
            Field(c => c.PhysicalExtend_Name, nullable: true).Description("already it was Name");
            Field(c => c.PMS_WbsprPhysicalAdvancementPercent, nullable: true).Description("PMS_WbsprPhysicalAdvancementPercent");
            //Field(c => c.PMS_WbsprDefects                           , nullable: true).Description("PMS_WbsprDefects"); 
            Field(c => c.PMS_WbsprNote, nullable: true).Description("PMS_WbsprNote");
            //Field(c => c.PMS_WbsprRegisterDate                      , nullable: true).Description("PMS_WbsprRegisterDate"); 
            //Field(c => c.PMS_WbsprType                              , nullable: true).Description("PMS_WbsprType"); 
            Field(c => c.PMS_WbsprActive, nullable: true).Description("PMS_WbsprActive");
            //Field(c => c.PMS_WbsprStatus                            , nullable: true).Description("PMS_WbsprStatus"); 
            //Field(c => c.PMS_WbsprDeleteDate                        , nullable: true).Description("PMS_WbsprDeleteDate"); 
            //Field(c => c.ACC_FinancialYearID                        , nullable: true).Description("ACC_FinancialYearID"); 
            //Field(c => c.TBL_UserID                                 , nullable: true).Description("TBL_UserID"); 
            //Field(c => c.WOS_WoID                                   , nullable: true).Description("WOS_WoID"); 
            //Field(c => c.WOS_WoParentID_fk                          , nullable: true).Description("WOS_WoParentID_fk"); 
            //Field(c => c.TBL_FormID_fk                              , nullable: true).Description("TBL_FormID_fk"); 
            //Field(c => c.WOS_WonID_fk                               , nullable: true).Description("WOS_WonID_fk"); 
            //Field(c => c.WOS_WosID_fk                               , nullable: true).Description("WOS_WosID_fk"); 
            //Field(c => c.WOS_WotID_fk                               , nullable: true).Description("WOS_WotID_fk"); 
            //Field(c => c.TBL_PlaceID_fk                             , nullable: true).Description("TBL_PlaceID_fk"); 
            //Field(c => c.PMS_PcID_fk                                , nullable: true).Description("PMS_PcID_fk"); 
            //Field(c => c.TBL_DepartmentID_fk                        , nullable: true).Description("TBL_DepartmentID_fk"); 
            //Field(c => c.TBL_ResourceID_fk                          , nullable: true).Description("TBL_ResourceID_fk"); 
            //Field(c => c.TBL_PrcID_fk                               , nullable: true).Description("TBL_PrcID_fk"); 
            //Field(c => c.WOS_WoRefrenceID_fk                        , nullable: true).Description("WOS_WoRefrenceID_fk"); 
            //Field(c => c.WOS_AtID_fk                                , nullable: true).Description("WOS_AtID_fk"); 
            //Field(c => c.WOS_WoOldCode                              , nullable: true).Description("WOS_WoOldCode"); 
            //Field(c => c.WOS_WoRecordPermanentNo                    , nullable: true).Description("WOS_WoRecordPermanentNo"); 
            //Field(c => c.WOS_WoRecordPermanentDate                  , nullable: true).Description("WOS_WoRecordPermanentDate"); 
            //Field(c => c.WOS_WoTitle                                , nullable: true).Description("WOS_WoTitle "); 
            //Field(c => c.WOS_WoStartDate                            , nullable: true).Description("WOS_WoStartDate"); 
            //Field(c => c.WOS_WoEndDate                              , nullable: true).Description("WOS_WoEndDate"); 
            //Field(c => c.WOS_WoApproveDate                          , nullable: true).Description("WOS_WoApproveDate"); 
            //Field(c => c.WOS_WoEstimatedPrice                       , nullable: true).Description("WOS_WoEstimatedPrice"); 
            //Field(c => c.WOS_WoActualPrice                          , nullable: true).Description("WOS_WoActualPrice"); 
            //Field(c => c.WOS_WoInternalMaterial                     , nullable: true).Description("WOS_WoInternalMaterial"); 
            //Field(c => c.WOS_WoExternalMaterial                     , nullable: true).Description("WOS_WoExternalMaterial"); 
            //Field(c => c.WOS_WoInternalResourceWage                 , nullable: true).Description("WOS_WoInternalResourceWage"); 
            //Field(c => c.WOS_WoExternalResourceWage                 , nullable: true).Description("WOS_WoExternalResourceWage"); 
            //Field(c => c.WOS_WoInternalResourceScoria               , nullable: true).Description("WOS_WoInternalResourceScoria"); 
            //Field(c => c.WOS_WoExternalResourceScoria               , nullable: true).Description("WOS_WoExternalResourceScoria"); 
            //Field(c => c.WOS_WoInternalResourceDispose              , nullable: true).Description("WOS_WoInternalResourceDispose"); 
            //Field(c => c.WOS_WoExternalResourceDispose              , nullable: true).Description("WOS_WoExternalResourceDispose"); 
            //Field(c => c.WOS_WoExternalTransport                    , nullable: true).Description("WOS_WoExternalTransport"); 
            //Field(c => c.WOS_WoInternalTransport                    , nullable: true).Description("WOS_WoInternalTransport"); 
            //Field(c => c.WOS_WoPhysicalContent                      , nullable: true).Description("WOS_WoPhysicalContent"); 
            //Field(c => c.WOS_WoWageCoefficient                      , nullable: true).Description("WOS_WoWageCoefficient"); 
            //Field(c => c.WOS_WoPlaceCoefficient                     , nullable: true).Description("WOS_WoPlaceCoefficient"); 
            //Field(c => c.WOS_WoMinCoefficient                       , nullable: true).Description("WOS_WoMinCoefficient"); 
            //Field(c => c.WOS_WoMaxCoefficient                       , nullable: true).Description("WOS_WoMaxCoefficient"); 
            //Field(c => c.WOS_WoPlanTechnicalDescription             , nullable: true).Description("WOS_WoPlanTechnicalDescription"); 
            //Field(c => c.WOS_WoCaseNo                               , nullable: true).Description("WOS_WoCaseNo"); 
            //Field(c => c.WOS_WoCaseDate                             , nullable: true).Description("WOS_WoCaseDate"); 
            //Field(c => c.WOS_WoUsageDate                            , nullable: true).Description("WOS_WoUsageDate"); 
            //Field(c => c.WOS_WoActualPhysicalSize                   , nullable: true).Description("WOS_WoActualPhysicalSize"); 
            //Field(c => c.WOS_WoScore                                , nullable: true).Description("WOS_WoScore "); 
            //Field(c => c.WOS_WoFolderNo                             , nullable: true).Description("WOS_WoFolderNo"); 
            //Field(c => c.WOS_WoNote                                 , nullable: true).Description("WOS_WoNote"); 
            //Field(c => c.WOS_WoRegisterDate                         , nullable: true).Description("WOS_WoRegisterDate"); 
            //Field(c => c.WOS_WoType                                 , nullable: true).Description("WOS_WoType"); 
            //Field(c => c.WOS_WoActive                               , nullable: true).Description("WOS_WoActive"); 
            //Field(c => c.WOS_WoDeleteDate                           , nullable: true).Description("WOS_WoDeleteDate"); 
            //Field(c => c.WOS_WotID                                  , nullable: true).Description("WOS_WotID "); 
            //Field(c => c.WOS_WotParentID_fk                         , nullable: true).Description("WOS_WotParentID_fk"); 
            //Field(c => c.ACC_AcID_fk                                , nullable: true).Description("ACC_AcID_fk"); 
            //Field(c => c.WOS_WotSystemCode                          , nullable: true).Description("WOS_WotSystemCode"); 
            Field(c => c.WOS_WotName, nullable: true).Description("WOS_WotName ");
            //Field(c => c.WOS_WotWageCoefficient                     , nullable: true).Description("WOS_WotWageCoefficient"); 
            //Field(c => c.WOS_WotNote                                , nullable: true).Description("WOS_WotNote "); 
            //Field(c => c.WOS_WotRegisterDate                        , nullable: true).Description("WOS_WotRegisterDate"); 
            //Field(c => c.WOS_WotType                                , nullable: true).Description("WOS_WotType"); 
            //Field(c => c.WOS_WotActive                              , nullable: true).Description("WOS_WotActive"); 
            //Field(c => c.WOS_WotStatus                              , nullable: true).Description("WOS_WotStatus"); 
            //Field(c => c.WOS_WotDeleteDate                          , nullable: true).Description("WOS_WotDeleteDate");             
        }
    }

    public class ProjectManagementSystemReportPriceContextTableViewType : ObjectGraphType<PostProjectManagementSystemReportPriceContextTableView>
    {
        public ProjectManagementSystemReportPriceContextTableViewType()
        {
            Field(c => c.TBL_PrcID_fk, nullable: false).Description("TBL_PrcID_fk"); 
            Field(c => c.TBL_PrcName                 , nullable: true).Description("TBL_PrcName"); 
            Field(c => c.TBL_BprParentID_fk          , nullable: true).Description("TBL_BprParentID_fk"); 
            Field(c => c.TBL_BprID                   , nullable: false).Description("TBL_BprID"); 
            Field(c => c.TBL_BprPrice                , nullable: true).Description("TBL_BprPrice"); 
            Field(c => c.TBL_BprDescription          , nullable: true).Description("TBL_BprDescription"); 
            Field(c => c.TBL_BprQuantity             , nullable: true).Description("TBL_BprQuantity"); 
            Field(c => c.TBL_BprActive               , nullable: true).Description("TBL_BprActive"); 
            Field(c => c.TBL_BprNote                 , nullable: true).Description("TBL_BprNote"); 
            Field(c => c.TBL_PrcNote                 , nullable: true).Description("TBL_PrcNote"); 
            Field(c => c.WHS_GuID_fk                 , nullable: true).Description("WHS_GuID_fk"); 
            Field(c => c.TBL_BprCode                 , nullable: true).Description("TBL_BprCode"); 
            Field(c => c.TBL_BprMachineryPrice       , nullable: true).Description("TBL_BprMachineryPrice"); 
            Field(c => c.TBL_BprMaterialPrice        , nullable: true).Description("TBL_BprMaterialPrice"); 
            Field(c => c.TBL_BprDeparePrice1         , nullable: true).Description("TBL_BprDeparePrice1"); 
            Field(c => c.TBL_BprDeparePrice2         , nullable: true).Description("TBL_BprDeparePrice2"); 
            Field(c => c.TBL_BprDeparePrice3         , nullable: true).Description("TBL_BprDeparePrice3"); 
            Field(c => c.TBL_BprDisposePrice         , nullable: true).Description("TBL_BprDisposePrice"); 
            Field(c => c.TBL_BprPayPrice             , nullable: true).Description("TBL_BprPayPrice"); 
            Field(c => c.TBL_BprWarehouseCoding      , nullable: true).Description("TBL_BprWarehouseCoding"); 
            Field(c => c.TBL_BprType                 , nullable: true).Description("TBL_BprType"); 
            Field(c => c.TBL_BprStatus               , nullable: true).Description("TBL_BprStatus"); 
            Field(c => c.WHS_GuName                  , nullable: true).Description("WHS_GuName"); 
            Field(c => c.WHS_GuNote                  , nullable: true).Description("WHS_GuNote"); 
            Field(c => c.ACC_FinancialYearID         , nullable: true).Description("ACC_FinancialYearID"); 
            Field(c => c.TBL_PrcType                 , nullable: true).Description("TBL_PrcType"); 
            Field(c => c.TBL_BprMachineryDeparePrice , nullable: true).Description("TBL_BprMachineryDeparePrice"); 
            Field(c => c.TBL_BprPayDeparePrice       , nullable: true).Description("TBL_BprPayDeparePrice"); 
            Field(c => c.TBL_BprTransportCoefficient , nullable: true).Description("TBL_BprTransportCoefficient"); 
            Field(c => c.TBL_BprOldCode              , nullable: true).Description("TBL_BprOldCode"); 
            Field(c => c.TBL_BprMachineryMovePrice   , nullable: true).Description("TBL_BprMachineryMovePrice"); 
            Field(c => c.TBL_BprPayMovePrice         , nullable: true).Description("TBL_BprPayMovePrice"); 
            Field(c => c.CNT_CbID_fk                 , nullable: true).Description("CNT_CbID_fk");
        }
    }
}
 