using System;
using System.Collections.Generic;
using System.Text;

namespace GQ
{
    public class ProjectManagementSystemProjectReportPlanItems
    {

        public ProjectManagementSystemProjectReportPlanItems() { }
        /// <summary>
        /// <Description></Description>
        /// </summary>
        public string BUD_ProjectID_fk { get; set; }
        /// <summary>
        /// <Description></Description>
        /// </summary>
        public string PMS_PdID { get; set; }
        /// <summary>
        /// <Description>ماهیت دستور کار</Description>
        /// </summary>
        public string WOS_WonName { get; set; }
        /// <summary>
        /// <Description>نوع دستور کار</Description>
        /// </summary>
        public string WOS_WotNote { get; set; }
        /// <summary>
        /// <Description>کد فهرست بهاء</Description>
        /// </summary>
        public string TBL_BprCode { get; set; }
        /// <summary>
        /// <Description>عنوان فهرست بهاء</Description>
        /// </summary>
        public string TBL_BprDescription { get; set; }
        /// <summary>
        /// <Description>نحوه تامین</Description>
        /// </summary>
        public string PMS_PdProvideWayId_fk { get; set; }
        public string TBL_BprID_fk { get; set; }
        /// <summary>
        /// <Description>تعداد</Description>
        /// </summary>
        public string PMS_PdFirstQuantity { get; set; }
        /// <summary>
        /// <Description>نوع کالا</Description>
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// <Description>بهاء مصالح</Description>
        /// </summary>
        public string PMS_PdMaterialPrice { get; set; }
        /// <summary>
        /// <Description>بهاء حمل</Description>
        /// </summary>
        public string PMS_PdMachineryPrice { get; set; }
        /// <summary>
        /// <Description>دستمزد و حقوق</Description>
        /// </summary>
        public string PMS_PdPayPrice { get; set; }
        /// <summary>
        /// <Description>بهای کل</Description>
        /// </summary>
        public string PMS_PdPrice { get; set; }




        //public DateTime Created { get; private set; }

        //public BudgetStatuses Status { get; private set; }

        //public void Close()
        //{
        //    Status = BudgetStatuses.CLOSED;
        //}

        //public void Start()
        //{
        //    Status = BudgetStatuses.PROCESSING;
        //}

        //public void Cancel()
        //{
        //    Status = BudgetStatuses.CANCELLED;
        //}

        //public void Complete()
        //{
        //    Status = BudgetStatuses.COMPLETED;
        //}

    }

    public class PostProjectManagementSystemProjectReportPlanDocuments
    {

        public PostProjectManagementSystemProjectReportPlanDocuments() { }
        /// <summary>
        /// <Description></Description>
        /// </summary>
        public string PMS_PaID { get; set; }
        /// <summary>
        /// <Description>کد پیمانکار</Description>
        /// </summary>
        public string PMS_PdtID_fk { get; set; }
        /// <summary>
        /// <Description>نوع مستند</Description>
        /// </summary>
        public string PMS_PdtName { get; set; }
        /// <summary>
        /// <Description>تاریخ مستند</Description>
        /// </summary>
        public string PMS_PaDate { get; set; }
        /// <summary>
        /// <Description>شرح مستند</Description>
        /// </summary>
        public string PMS_PaDescription { get; set; }
        //public string PMS_PaNote { get; set; }
        //public string PMS_PaActive { get; set; }
        //public string PMS_PaStaus { get; set; }
        //public string PMS_PaType { get; set; }
        //public string PMS_PaRegisterDate { get; set; }
        //public string PMS_PaDeleteDate { get; set; }
        //public string ACC_FinancialYearID { get; set; }
        //public string TBL_UserID { get; set; }
        //public string PMS_PdtID { get; set; }
        //public string PMS_PdtparentID_fk { get; set; }        
        //public string PMS_PdtNote { get; set; }
        //public string PMS_PdtType { get; set; }
        //public string PMS_PdtActive { get; set; }
        //public string PMS_PdtStatus { get; set; }
        //public string PMS_PdtRegisterDate { get; set; }
        //public string PMS_PdtDeleteDate { get; set; }
    }

    public class PostProjectManagementSystemProjectReportPlanContractorsPrice
    {
        public PostProjectManagementSystemProjectReportPlanContractorsPrice() { }
        /// <summary>
        /// <Description></Description>
        /// </summary>
        public string PMS_PppID { get; set; }
        /// <summary>
        /// <Description>کد پیمانکار</Description>
        /// </summary>
        public string TBL_CustomerID_fk { get; set; }
        /// <summary>
        /// <Description>نام پیمانکار</Description>
        /// </summary>
        public string TBL_CustomerTitle { get; set; }
        /// <summary>
        /// <Description>شماره همراه</Description>
        /// </summary>
        public string TBL_CustomerMobile { get; set; }
        /// <summary>
        /// <Description>مانده اعتبار</Description>
        /// </summary>
        public string TBL_CustomerCredit { get; set; }
        /// <summary>
        /// <Description>ظرفیت باقیمانده</Description>
        /// </summary>
        public string TBL_CustomerCapacity { get; set; }
        /// <summary>
        /// <Description>شرایط پرداخت</Description>
        /// </summary>
        public string PMS_PppPayCondition { get; set; }
        /// <summary>
        /// <Description>سایر شرایط</Description>
        /// </summary>
        public string PMS_PppOtherCondition { get; set; }
        /// <summary>
        /// <Description>قیمت پیمانکار</Description>
        /// </summary>
        public string PMS_PppPrice { get; set; }
        //public string  BUD_ProjectID { get; set; }
        //public string  BUD_ProjectName { get; set; }
        //public string  BUD_ProjectCode { get; set; }
        //public string  TBL_PrcName { get; set; }
        //public string  TBL_PlaceID { get; set; }
        //public string  TBL_PlaceName { get; set; }
        //public string  BUD_ProjectPrice { get; set; }
    }

    public class PostProjectManagementSystemProjectReportAttachmentsDialog
    {
        public PostProjectManagementSystemProjectReportAttachmentsDialog() { }
        /// <summary>
        /// <Description>شناسه مستند</Description>
        /// </summary>
        public string DocumentID { get; set; }
        /// <summary>
        /// <Descriptions>کد مستند</Description>
        /// </summary>
        public string DocumentCode { get; set; }
        /// <summary>
        /// <Description>نام مستند</Description>
        /// </summary>
        public string DocumentName { get; set; }
        /// <summary>
        /// <Description>نوع فایل</Description>
        /// </summary>
        public string DocumentFileType { get; set; }
        ///// <summary>
        ///// <Description>نام فایل</Description>
        ///// </summary>
        //public string TBL_OdName { get; set; }
        /// <summary>
        /// <Descriptionپسوند فایل></Description>
        /// </summary>
        //public string DocumentFileTypeExtention { get; set; }
        /// <summary>
        // <Description>کد نوع فایل</Description>
        // </summary>
        public string FileTypeId { get; set; }
        /// <summary>
        /// <Description>شرح مستند</Description>
        /// </summary>
        public string DocumentNote { get; set; }
    }

    public class PostProjectManagementSystemProjectReportFileDownload
    {
        public PostProjectManagementSystemProjectReportFileDownload() { }
        /// <summary>
        /// <Description>Image فایل</Description>
        /// </summary>
        public string TBL_IdBody { get; set; }
        /// <summary>
        /// <Description>Office فایل</Description>
        /// </summary>
        public string TBL_OdBody { get; set; }
        /// <summary>
        /// <Description> PDF فایل</Description>
        /// </summary>

        public string TBL_ApdBody { get; set; }


    }

    public class PostProjectManagementSystemProjectReportSendToCartable
    {
        public PostProjectManagementSystemProjectReportSendToCartable() { }
        /// <summary>
        /// <Description>پیام</Description>
        /// </summary>
        public string OutputMessage { get; set; }
    }

    public class PostProjectManagementSystemProjectReportSetWinner
    {
        public PostProjectManagementSystemProjectReportSetWinner() { }
        /// <summary>
        /// <Description>پیام</Description>
        /// </summary>
        public string OutputMessage { get; set; }
    }

    public class PostProjectManagementSystemProjectReportTechnicalPropertyItems
    {
        public PostProjectManagementSystemProjectReportTechnicalPropertyItems() { }
        public string PMS_PtID { get; set; }
        //public string BUD_ProjectID_fk { get; set; }
        //public string PMS_PtpID_fk { get; set; }
        //public string RMS_SubstationID_fk { get; set; }
        //public string RMS_TlID_fk { get; set; }
        public string PMS_PtValue { get; set; }

        //public string PMS_PtNote { get; set; }
        //public string PMS_PtRegisterDate { get; set; }
        //public string PMS_PtType { get; set; }
        //public string PMS_PtActive { get; set; }
        //public string PMS_PtStatus { get; set; }
        //public string PMS_PtDeleteDate { get; set; }
        //public string ACC_FinancialYearID { get; set; }
        //public string TBL_UserID { get; set; }
        //public string PMS_PtpID { get; set; }
        //public string PMS_PtpParentID_fk { get; set; }
        //public string TBL_UnitID_fk { get; set; }
        //public string PMS_PtpName { get; set; }
        public string PMS_PtpNote { get; set; }
        //public string PMS_PtpRegisterDate { get; set; }
        //public string PMS_PtpType { get; set; }
        //public string PMS_PtpActive { get; set; }
        //public string PMS_PtpStatus { get; set; }
        //public string PMS_PtpDeleteDate { get; set; }
    }

    public class PostProjectManagementSystemProjectReportApprovedBudgetItems
    {
        public PostProjectManagementSystemProjectReportApprovedBudgetItems() { }
        public string TBL_ResourceID { get; set; }
        //public string TBL_ResourceParentID_fk { get; set; }
        public string TBL_ResourceName { get; set; }
        //public string BUD_BcID { get; set; }
        //public string BUD_BcParentID_fk { get; set; }
        //public string BUD_BcDescription { get; set; }
        //public string BUD_BcTotalDescription { get; set; }
        //public string BUD_BcActive { get; set; }
        public string BUD_RcID { get; set; }
        public string BUD_RcName { get; set; }
        public string BUD_BaID { get; set; }
        //public string BUD_BaParentID_fk { get; set; }
        public string BUD_BaDebit { get; set; }
        public string BUD_BaCredit { get; set; }
        //public string TBL_DepartmentName { get; set; }
        //public string TBL_DepartmentDescription { get; set; }
        //public string TBL_DepartmentID { get; set; }
        //public string BUD_BaActive { get; set; }
        //public string BUD_BcID_fk { get; set; }
        //public string TBL_PlaceID_fk { get; set; }
        //public string BUD_RcID_fk { get; set; }
        //public string TBL_DepartmentID_fk { get; set; }
        //public string ACC_FinancialYearID { get; set; }
        //public string TBL_UserID { get; set; }
        //public string BUD_ProjectName { get; set; }
        //public string BUD_ProjectAccountCode { get; set; }
        //public string BUD_ProjectPlanNo { get; set; }
        //public string BUD_ProjectPrice { get; set; }
        //public string BUD_ProjectID_fk { get; set; }
        //public string TBL_PlaceID { get; set; }
        //public string TBL_PlaceNote { get; set; }
        public string TBL_PlaceName { get; set; }
        //public string WOS_WonID { get; set; }
        //public string WOS_WonID_fk { get; set; }
        //public string WOS_WotID_fk { get; set; }
        //public string BUD_BdtID_fk { get; set; }
        //public string PMS_PcID_fk { get; set; }
        //public string BUD_BdtID { get; set; }
        //public string PMS_PcName { get; set; }
        //public string BUD_BdtName { get; set; }
        //public string WOS_WotName { get; set; }
        //public string WOS_WotNote { get; set; }
        //public string WOS_WonName { get; set; }
        //public string WOS_WonNote { get; set; }
        //public string BUD_BaNote { get; set; }
        //public string BUD_BaRegisterDate { get; set; }
        //public string BUD_BaType { get; set; }
        //public string BUD_BaStatus { get; set; }
        //public string BUD_BaDeleteDate { get; set; }
        //public string Bud_TamarkozCode { get; set; }
        //public string Bud_SubTamarkozCode { get; set; }
        //public string Bud_TamarkozName { get; set; }
        //public string Bud_SubTamarkozName { get; set; }
        //public string TBL_ResourceNote { get; set; }
        //public string BUD_BaEstimateContent1 { get; set; }
        //public string BUD_BaEstimateContent2 { get; set; }
        //public string BUD_BaEstimateContent3 { get; set; }
        public string BUD_BaOfferPrice { get; set; }
        //public string FinancialYearID { get; set; }
        //public string Type { get; set; }

    }

    public class PostProjectManagementSystemProjectReportContractItems {
        public PostProjectManagementSystemProjectReportContractItems() { }

        //public string WOS_WocID { get; set; }
        //public string WOS_WoID_fk { get; set; }
        //public string BUD_ProjectID_fk { get; set; }
        //public string CNT_ContractID_fk { get; set; }
        //public string WOS_WocRecordTemproryNo { get; set; }
        //public string WOS_WocRecordPermanentNo { get; set; }
        //public string WOS_WocRecordTemproryDate { get; set; }
        //public string WOS_WocRecordPermanentDate { get; set; }
        //public string WOS_WocShare { get; set; }
        //public string WOS_WocNote { get; set; }
        //public string WOS_WocActive { get; set; }
        //public string WOS_WocRegisterDate { get; set; }
        //public string WOS_WocDeleteDate { get; set; }
        //public string WOS_WocStatus { get; set; }
        //public string WOS_WocType { get; set; }
        //public string ACC_FinancialYearID { get; set; }
        //public string TBL_UserID { get; set; }
        //public string PMS_PnID_fk { get; set; }
        //public string PMS_PsID_fk { get; set; }
        //public string PMS_PcID_fk { get; set; }
        //public string TBL_PlaceID_fk { get; set; }
        //public string BUD_ProjectName { get; set; }
        //public string BUD_ProjectPrice { get; set; }
        //public string CNT_ContractID { get; set; }
        //public string TBL_CustomerID_fk { get; set; }
        //public string TBL_ResourceID_fk { get; set; }
        //public string CNT_CtID_fk { get; set; }
        //public string TBL_AdviserID_fk { get; set; }
        //public string TBL_SupervisorID_fk { get; set; }
        public string CNT_ContractCode { get; set; }
        public string CNT_ContractTitle { get; set; }
        public string CustomerTitle { get; set; }
        //public string AdviserTitle { get; set; }
        //public string SupervisorTitle { get; set; }
        //public string BUD_ProjectApproveDate { get; set; }
        public string CNT_ContractPrice { get; set; }
        //public string WOS_WoTitle { get; set; }
        //public string WOS_WoEstimatedPrice { get; set; }
        //public string WOS_WotID_fk { get; set; }
        //public string WOS_WotName { get; set; }
        //public string TBL_CrtID_fk { get; set; }
        //public string WOS_WoID { get; set; }
        //public string WOS_WoParentID_fk { get; set; }
        //public string TBL_FormID_fk { get; set; }
        //public string WOS_WonID_fk { get; set; }
        //public string TBL_DepartmentID_fk { get; set; }
        //public string TBL_PrcID_fk { get; set; }
        //public string WOS_WoRefrenceID_fk { get; set; }
        //public string WOS_WoEndDate { get; set; }
        //public string WOS_WoStartDate { get; set; }
        //public string WOS_WoInternalMaterial { get; set; }
        //public string WOS_WoExternalMaterial { get; set; }
        //public string WOS_WoInternalTransport { get; set; }
        //public string WOS_WoInternalResourceWage { get; set; }
        //public string WOS_WoInternalResourceScoria { get; set; }
        //public string WOS_WoInternalResourceDispose { get; set; }
        //public string WOS_WoExternalTransport { get; set; }
        //public string WOS_WoExternalResourceScoria { get; set; }
        //public string WOS_WoExternalResourceWage { get; set; }
        //public string WOS_WoExternalResourceDispose { get; set; }
        //public string BUD_ProjectID { get; set; }
        //public string WOS_WonName { get; set; }
        //public string TBL_PrcName { get; set; }
        //public string TBL_PrcNote { get; set; }
        //public string WOS_WosID_fk { get; set; }
        //public string WOS_WosName { get; set; }
        //public string WOS_WosNote { get; set; }
        //public string PMS_PcName { get; set; }
        //public string PMS_PcNote { get; set; }
        //public string FinancialYearWos { get; set; }
        //public string BUD_ProjectCode { get; set; }
        //public string BUD_ProjectAddress { get; set; }
        //public string WOS_AtName { get; set; }
        //public string WOS_AtNote { get; set; }
        //public string WOS_AtParentID_fk { get; set; }
        //public string PcName { get; set; }
        //public string PcNote { get; set; }
        //public string BUD_ProjectStartDate { get; set; }
        //public string BUD_ProjectEndDate { get; set; }
        //public string TBL_PlaceID { get; set; }
        //public string TBL_PlaceName { get; set; }
        //public string CNT_FinancialYearID { get; set; }
        public string CrtName { get; set; }       
    }

    public class PostProjectManagementSystemProjectReportAgendaItems
    {
        public PostProjectManagementSystemProjectReportAgendaItems() { }
        //public string WOS_WocID { get; set; }
        //public string WOS_WoID_fk { get; set; }
        //public string BUD_ProjectID_fk { get; set; }
        //public string CNT_ContractID_fk { get; set; }
        //public string WOS_WocRecordTemproryNo { get; set; }
        //public string WOS_WocRecordPermanentNo { get; set; }
        //public string WOS_WocRecordTemproryDate { get; set; }
        //public string WOS_WocRecordPermanentDate { get; set; }
        //public string WOS_WocShare { get; set; }
        //public string WOS_WocNote { get; set; }
        //public string WOS_WocActive { get; set; }
        //public string WOS_WocRegisterDate { get; set; }
        //public string WOS_WocDeleteDate { get; set; }
        //public string WOS_WocStatus { get; set; }
        //public string WOS_WocType { get; set; }
        //public string ACC_FinancialYearID { get; set; }
        //public string TBL_UserID { get; set; }
        //public string PMS_PnID_fk { get; set; }
        //public string PMS_PsID_fk { get; set; }
        //public string PMS_PcID_fk { get; set; }
        //public string TBL_PlaceID_fk { get; set; }
        //public string BUD_ProjectName { get; set; }
        //public string BUD_ProjectPrice { get; set; }
        //public string CNT_ContractID { get; set; }
        //public string TBL_CustomerID_fk { get; set; }
        //public string TBL_ResourceID_fk { get; set; }
        //public string CNT_CtID_fk { get; set; }
        //public string TBL_AdviserID_fk { get; set; }
        //public string TBL_SupervisorID_fk { get; set; }
        //public string CNT_ContractCode { get; set; }
        //public string CNT_ContractTitle { get; set; }
        //public string CustomerTitle { get; set; }
        //public string AdviserTitle { get; set; }
        //public string SupervisorTitle { get; set; }
        //public string BUD_ProjectApproveDate { get; set; }
        //public string CNT_ContractPrice { get; set; }
        //public string WOS_WoTitle { get; set; }
        public string WOS_WoEstimatedPrice { get; set; }
        //public string WOS_WotID_fk { get; set; }
        //public string WOS_WotName { get; set; }
        //public string TBL_CrtID_fk { get; set; }
        public string WOS_WoID { get; set; }
        //public string WOS_WoParentID_fk { get; set; }
        //public string TBL_FormID_fk { get; set; }
        //public string WOS_WonID_fk { get; set; }
        //public string TBL_DepartmentID_fk { get; set; }
        //public string TBL_PrcID_fk { get; set; }
        //public string WOS_WoRefrenceID_fk { get; set; }
        //public string WOS_WoEndDate { get; set; }
        //public string WOS_WoStartDate { get; set; }
        //public string WOS_WoInternalMaterial { get; set; }
        //public string WOS_WoExternalMaterial { get; set; }
        //public string WOS_WoInternalTransport { get; set; }
        //public string WOS_WoInternalResourceWage { get; set; }
        //public string WOS_WoInternalResourceScoria { get; set; }
        //public string WOS_WoInternalResourceDispose { get; set; }
        //public string WOS_WoExternalTransport { get; set; }
        //public string WOS_WoExternalResourceScoria { get; set; }
        //public string WOS_WoExternalResourceWage { get; set; }
        //public string WOS_WoExternalResourceDispose { get; set; }
        //public string BUD_ProjectID { get; set; }
        //public string WOS_WonName { get; set; }
        public string TBL_PrcName { get; set; }
        //public string TBL_PrcNote { get; set; }
        //public string WOS_WosID_fk { get; set; }
        public string WOS_WosName { get; set; }
        //public string WOS_WosNote { get; set; }
        public string PMS_PcName { get; set; }
        //public string PMS_PcNote { get; set; }
        public string FinancialYearWos { get; set; }
        //public string BUD_ProjectCode { get; set; }
        //public string BUD_ProjectAddress { get; set; }
        public string WOS_AtName { get; set; }
        public string WOS_AtNote { get; set; }
        //public string WOS_AtParentID_fk { get; set; }
        public string PcName { get; set; }
        //public string PcNote { get; set; }
        //public string BUD_ProjectStartDate { get; set; }
        //public string BUD_ProjectEndDate { get; set; }
        //public string TBL_PlaceID { get; set; }
        //public string TBL_PlaceName { get; set; }
        //public string CNT_FinancialYearID { get; set; }
    }

    public class PostProjectManagementSystemProjectReportOptionsItems
    {
        public PostProjectManagementSystemProjectReportOptionsItems() { }
        //public string PMS_PdID { get; set; }
        //public string BUD_ProjectID_fk { get; set; }
        //public string WHS_WarehouseID_fk { get; set; }
        //public string WHS_GoodsID_fk { get; set; }
        //public string COM_ServiceID_fk { get; set; }
        //public string TBL_BprID_fk { get; set; }
        //public string WOS_WotID_fk { get; set; }
        //public string WOS_WonID_fk { get; set; }
        public string PMS_PdProvideWayId_fk { get; set; }
        public string PMS_PdFirstQuantity { get; set; }
        //public string PMS_PdQuantity { get; set; }
        //public string PMS_PdFinalQuantity { get; set; }
        //public string PMS_PdDeparePrice { get; set; }
        //public string PMS_PdPayPrice { get; set; }
        //public string PMS_PdDisposePrice { get; set; }
        //public string PMS_PdMaterialPrice { get; set; }
        //public string PMS_PdMachineryPrice { get; set; }
        //public string PMS_PdPrice { get; set; }
        //public string PMS_PdDescription { get; set; }
        //public string PMS_PdType { get; set; }
        //public string PMS_PdNote { get; set; }
        //public string PMS_PdRegisterDate { get; set; }
        //public string PMS_PdActive { get; set; }
        //public string PMS_PdStatus { get; set; }
        //public string PMS_PdDeleteDate { get; set; }
        //public string ACC_FinancialYearID { get; set; }
        //public string TBL_UserID { get; set; }
        //public string TBL_BprID { get; set; }
        //public string TBL_BprParentID_fk { get; set; }
        //public string TBL_PrcID_fk { get; set; }
        //public string WHS_GuID_fk { get; set; }
        //public string CNT_CbID_fk { get; set; }
        public string TBL_BprCode { get; set; }
        //public string TBL_BprOldCode { get; set; }
        public string TBL_BprDescription { get; set; }
        //public string TBL_BprWarehouseCoding { get; set; }
        //public string TBL_BprTransportCoefficient { get; set; }
        //public string TBL_BprMaterialPrice { get; set; }
        //public string TBL_BprPayPrice { get; set; }
        //public string TBL_BprMachineryPrice { get; set; }
        //public string TBL_BprDeparePrice1 { get; set; }
        //public string TBL_BprDeparePrice2 { get; set; }
        //public string TBL_BprDeparePrice3 { get; set; }
        //public string TBL_BprMachineryDeparePrice { get; set; }
        //public string TBL_BprPayDeparePrice { get; set; }
        //public string TBL_BprDisposePrice { get; set; }
        //public string TBL_BprMachineryMovePrice { get; set; }
        //public string TBL_BprPayMovePrice { get; set; }
        //public string TBL_BprPrice { get; set; }
        //public string TBL_BprQuantity { get; set; }
        //public string TBL_BprNote { get; set; }
        //public string TBL_BprType { get; set; }
        //public string TBL_BprActive { get; set; }
        //public string TBL_BprStatus { get; set; }
        //public string TBL_BprRegisterDate { get; set; }
        //public string TBL_BprDeleteDate { get; set; }
        //public string WOS_WonID { get; set; }
        //public string WOS_WonParentID_fk { get; set; }
        //public string WOS_WonSystemCode { get; set; }
        public string WOS_WonName { get; set; }
        //public string WOS_WonNote { get; set; }
        //public string WOS_WonRegisterDate { get; set; }
        //public string WOS_WonType { get; set; }
        //public string WOS_WonActive { get; set; }
        //public string WOS_WonStatus { get; set; }
        //public string WOS_WonDeleteDate { get; set; }
        //public string WOS_WotID { get; set; }
        //public string WOS_WotParentID_fk { get; set; }
        //public string ACC_AcID_fk { get; set; }
        //public string WOS_WotSystemCode { get; set; }
        //public string WOS_WotName { get; set; }
        //public string WOS_WotWageCoefficient { get; set; }
        public string WOS_WotNote { get; set; }
        //public string WOS_WotRegisterDate { get; set; }
        //public string WOS_WotType { get; set; }
        //public string WOS_WotActive { get; set; }
        //public string WOS_WotStatus { get; set; }
        //public string WOS_WotDeleteDate { get; set; }
        //public string Status { get; set; }

    }

    public class PostProjectManagementSystemProjectExecutionAgents
    {
        public PostProjectManagementSystemProjectExecutionAgents() { }
        //public string BUD_PepID              {get; set; }
        //public string CNT_CetID_fk              {get; set; }
        //public string BUD_ProjectID_fk              {get; set; }
        public string TBL_CustomerID_fk              {get; set; }
        public string BUD_PepDescription              {get; set; }
        public string BUD_PepStartDate              {get; set; }
        public string BUD_PepEndDate              {get; set; }
        //public string BUD_PepLetterNo              {get; set; }
        //public string BUD_PepLetterDate              {get; set; }
        //public string BUD_PepAddress              {get; set; }
        public string BUD_PepMobail              {get; set; }
        public string BUD_PepJob              {get; set; }
        //public string BUD_PepDaily              {get; set; }
        //public string BUD_PepOverTime              {get; set; }
        //public string BUD_PepNote              {get; set; }
        //public string BUD_PepActive              {get; set; } 
        // public string BUD_PepStatus              {get; set; }
        //public string BUD_PepType              {get; set; }
        //public string BUD_PepRegisterDate              {get; set; }
        //public string BUD_PepDeleteDate              {get; set; }
        //public string ACC_FinancialYearID              {get; set; }
        //public string TBL_UserID              {get; set; }
        //public string CNT_CetDescription              {get; set; }
        public string CNT_CetNote              {get; set; }
        //public string CNT_CetActive              {get; set; }
        //public string CNT_CetStatus              {get; set; }
        //public string CNT_CetType              {get; set; }


    }

    public class PostProjectManagementSystemProjectSupervistoryHistory
    {
        public PostProjectManagementSystemProjectSupervistoryHistory() { }
        //public string PMS_WbsprID             { get; set; }        
        //public string PMS_PshID            { get; set; } 
        //public string PMS_PshLetterDate            { get; set; } 
        //public string PMS_PshLetterNo            { get; set; } 
        public string PMS_PshDate            { get; set; } 
        public string PMS_PshDescription            { get; set; } 
        //public string WOS_WoID_fk            { get; set; } 
        //public string PMS_PshActive            { get; set; } 
        //public string BUD_ProjectID_fk            { get; set; } 
        //public string TBL_FormID_fk            { get; set; }
        public string TBL_FormFarsiName            { get; set; } 
        //public string color             { get; set; }
    }

    public class PostProjectManagementSystemProjectPhysicalExtend
    {
        public PostProjectManagementSystemProjectPhysicalExtend() { }
        //public string PMS_WbsprID                               { get; set; } 
        //public string BUD_ProjectID_fk                               { get; set; } 
        public string WOS_WoID_fk                               { get; set; } 
        public string PMS_WbsprDate                               { get; set; } 
        //public string PMS_WbsprNextReviewDate                               { get; set; }
        public string PMS_WbsprLetterDate                               { get; set; } 
        public string PMS_WbsprLetterNo                               { get; set; }
        public string PMS_WbsprTitle                               { get; set; }
        public string Name                                   { get; set; }
        public string PMS_WbsprPhysicalAdvancementPercent                               { get; set; } 
        //public string PMS_WbsprDefects                               { get; set; } 
        public string PMS_WbsprNote                               { get; set; } 
        //public string PMS_WbsprRegisterDate                               { get; set; }
        //public string PMS_WbsprType                               { get; set; } 
        public string PMS_WbsprActive                               { get; set; } 
        //public string PMS_WbsprStatus                               { get; set; } 
        //public string PMS_WbsprDeleteDate                               { get; set; } 
        //public string ACC_FinancialYearID                               { get; set; } 
        //public string TBL_UserID                               { get; set; } 
        //public string WOS_WoID                               { get; set; } 
        //public string WOS_WoParentID_fk                               { get; set; } 
        //public string TBL_FormID_fk                               { get; set; } 
        //public string WOS_WonID_fk                               { get; set; } 
        //public string WOS_WosID_fk                               { get; set; } 
        //public string WOS_WotID_fk                               { get; set; } 
        //public string TBL_PlaceID_fk                               { get; set; } 
        //public string PMS_PcID_fk                               { get; set; } 
        //public string TBL_DepartmentID_fk                               { get; set; } 
        //public string TBL_ResourceID_fk                               { get; set; } 
        //public string TBL_PrcID_fk                               { get; set; } 
        //public string WOS_WoRefrenceID_fk                               { get; set; } 
        //public string WOS_AtID_fk                               { get; set; } 
        //public string WOS_WoOldCode                               { get; set; } 
        //public string WOS_WoRecordPermanentNo                               { get; set; } 
        //public string WOS_WoRecordPermanentDate                               { get; set; } 
        //public string WOS_WoTitle                               { get; set; }
        //public string WOS_WoStartDate                               { get; set; } 
        //public string WOS_WoEndDate                               { get; set; } 
        //public string WOS_WoApproveDate                               { get; set; } 
        //public string WOS_WoEstimatedPrice                               { get; set; } 
        //public string WOS_WoActualPrice                               { get; set; } 
        //public string WOS_WoInternalMaterial                               { get; set; } 
        //public string WOS_WoExternalMaterial                               { get; set; } 
        //public string WOS_WoInternalResourceWage                               { get; set; } 
        //public string WOS_WoExternalResourceWage                               { get; set; } 
        //public string WOS_WoInternalResourceScoria                               { get; set; } 
        //public string WOS_WoExternalResourceScoria                               { get; set; } 
        //public string WOS_WoInternalResourceDispose                               { get; set; } 
        //public string WOS_WoExternalResourceDispose                               { get; set; } 
        //public string WOS_WoExternalTransport                               { get; set; } 
        //public string WOS_WoInternalTransport                               { get; set; } 
        //public string WOS_WoPhysicalContent                               { get; set; } 
        //public string WOS_WoWageCoefficient                               { get; set; } 
        //public string WOS_WoPlaceCoefficient                               { get; set; } 
        //public string WOS_WoMinCoefficient                               { get; set; } 
        //public string WOS_WoMaxCoefficient                               { get; set; } 
        //public string WOS_WoPlanTechnicalDescription                               { get; set; } 
        //public string WOS_WoCaseNo                               { get; set; } 
        //public string WOS_WoCaseDate                               { get; set; }
        //public string WOS_WoUsageDate                               { get; set; }
        //public string WOS_WoActualPhysicalSize                               { get; set; } 
        //public string WOS_WoScore                               { get; set; } 
        //public string WOS_WoFolderNo                               { get; set; } 
        //public string WOS_WoNote                               { get; set; } 
        //public string WOS_WoRegisterDate                               { get; set; } 
        //public string WOS_WoType                               { get; set; } 
        //public string WOS_WoActive                               { get; set; } 
        //public string WOS_WoDeleteDate                               { get; set; } 
        //public string WOS_WotID                               { get; set; } 
        //public string WOS_WotParentID_fk                               { get; set; } 
        //public string ACC_AcID_fk                               { get; set; } 
        //public string WOS_WotSystemCode                               { get; set; } 
        public string WOS_WotName                               { get; set; }
        //public string WOS_WotWageCoefficient                               { get; set; } 
        //public string WOS_WotNote                               { get; set; } 
        //public string WOS_WotRegisterDate                               { get; set; } 
        //public string WOS_WotType                               { get; set; } 
        //public string WOS_WotActive                               { get; set; } 
        //public string WOS_WotStatus                               { get; set; } 
        //public string WOS_WotDeleteDate                               { get; set; } 
        //public string Name                               { get; set; } 

    }


    public class PostProjectManagementSystemReportPriceContextTableView        
     {
        public PostProjectManagementSystemReportPriceContextTableView(){ }
            public string TBL_PrcID_fk                 { get;  set; } 
            public string TBL_PrcName                 { get;  set; }  
            public string TBL_BprParentID_fk                 { get;  set; }  
            public string TBL_BprID                 { get;  set; } 
            public string TBL_BprPrice                 { get;  set; }  
            public string TBL_BprDescription                 { get;  set; }  
            public string TBL_BprQuantity                 { get;  set; }  
            public string TBL_BprActive                 { get;  set; }  
            public string TBL_BprNote                 { get;  set; }  
            public string TBL_PrcNote                 { get;  set; }  
            public string WHS_GuID_fk                 { get;  set; }  
            public string TBL_BprCode                 { get;  set; }  
            public string TBL_BprMachineryPrice                 { get;  set; }  
            public string TBL_BprMaterialPrice                 { get;  set; }  
            public string TBL_BprDeparePrice1                 { get;  set; }  
            public string TBL_BprDeparePrice2                 { get;  set; }  
            public string TBL_BprDeparePrice3                 { get;  set; }  
            public string TBL_BprDisposePrice                 { get;  set; }  
            public string TBL_BprPayPrice                 { get;  set; }      
            public string TBL_BprWarehouseCoding                 { get;  set; } 
            public string TBL_BprType                 { get;  set; }  
            public string TBL_BprStatus                 { get;  set; }  
            public string WHS_GuName                 { get;  set; } 
            public string WHS_GuNote                 { get;  set; }  
            public string ACC_FinancialYearID                 { get;  set; }
            public string TBL_PrcType                 { get;  set; } 
            public string TBL_BprMachineryDeparePrice                 { get;  set; }  
            public string TBL_BprPayDeparePrice                 { get;  set; }  
            public string TBL_BprTransportCoefficient                 { get;  set; }  
            public string TBL_BprOldCode                 { get;  set; }  
            public string TBL_BprMachineryMovePrice                 { get;  set; } 
            public string TBL_BprPayMovePrice                 { get;  set; }  
            public string CNT_CbID_fk                 { get;  set; }  
}
}