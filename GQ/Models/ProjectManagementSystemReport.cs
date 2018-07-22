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
        /// <summary>
        /// <Description>نام فایل</Description>
        /// </summary>
        public string TBL_OdName { get; set; }
        /// <summary>
        /// <Descriptionپسوند فایل></Description>
        /// </summary>
        //public string DocumentFileTypeExtention { get; set; }
        /// <summary>
        /// <Description>کد نوع فایل</Description>
        /// </summary>
        //public string FileTypeId { get; set; }
        /// <summary>
        /// <Description>شرح مستند</Description>
        /// </summary>
        public string DocumentNote { get; set; }
    }

    public class PostProjectManagementSystemProjectReportSendToCartable
    {
        public PostProjectManagementSystemProjectReportSendToCartable() { }
        /// <summary>
        /// <Description>پیام</Description>
        /// </summary>
        public string OutputMessage { get; set; }       
    }
}
