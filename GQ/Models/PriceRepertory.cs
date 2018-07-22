using System;
using System.Collections.Generic;
using System.Text;

namespace GQ
{
    public class PriceRepertoryFinancialYearsSelectListAction
    {

        public PriceRepertoryFinancialYearsSelectListAction() { }
        /// <summary>
        /// <Description>شناسه سال مالی</Description>
        /// </summary>
        public string ACC_FinancialYearID { get; set; }
        /// <summary>
        /// <Description>سال مالی</Description>
        /// </summary>
        public string ACC_FinancialYearName { get; set; }
        ///// <summary>
        ///// <Description>توضیحات</Description>
        ///// </summary>
        //public string ACC_FinancialYearNote { get; set; }
        /// <summary>
        /// <Description>پیش فرض سال مالی</Description>
        /// </summary>
        public string ACC_FinancialYearIsDefault { get; set; }

    }

    public class BasePriceRepertorySelectListAction {
        public BasePriceRepertorySelectListAction() { }
        /// <summary>
        /// <Description>شناسه فهرست بهاء</Description>
        /// </summary>
        public string TBL_PrcID { get; set; }
        /// <summary>
        /// <Description>شناسه والد</Description>
        /// </summary>
        public string TBL_PrcParentID_fk { get; set; }
        /// <summary>
        /// <Description>فهرست بهاء</Description>
        /// </summary>
        public string TBL_PrcName { get; set; }
        /// <summary>
        /// <Description>سال مالی</Description>
        /// </summary>
        public string ACC_FinancialYearID { get; set; }

        ///// <summary>
        ///// <Description></Description>
        ///// </summary>
        //public string TBL_PrcExecuteDate { get; set; }
        ///// <summary>
        ///// <Description></Description>
        ///// </summary>
        //public string TBL_PrcExpireDate { get; set; }
        ///// <summary>
        ///// <Description></Description>
        ///// </summary>
        //public string TBL_PrcNote { get; set; }
        ///// <summary>
        ///// <Description></Description>
        ///// </summary>
        //public string TBL_PrcType { get; set; }
        ///// <summary>
        ///// <Description></Description>
        ///// </summary>
        //public string TBL_PrcActive { get; set; }
        ///// <summary>
        ///// <Description></Description>
        ///// </summary>
        //public string TBL_PrcStatus { get; set; }
        ///// <summary>
        ///// <Description></Description>
        ///// </summary>
        //public string TBL_PrcRegisterDate { get; set; }
        ///// <summary>
        ///// <Description></Description>
        ///// </summary>
        //public string TBL_PrcDeleteDate { get; set; }
        ///// <summary>
        ///// <Description></Description>
        ///// </summary>
        //public string TBL_UserID { get; set; }
    }

    public class PriceRepertoryGridAction{
        public PriceRepertoryGridAction(){ }

        /// <summary>
        /// <Description>شناسه فهرست بهاء</Description>
        /// </summary>
        public string TBL_BprHasChildren { get; set; }
        /// <summary>
        /// <Description>شناسه فهرست بهاء</Description>
        /// </summary>
        public string TBL_BprID { get; set; }
        /// <summary>
        /// <Description>شناسه والد </Description>
        /// </summary>
        public string TBL_BprParentID_fk { get; set; }
        /// <summary>
        /// <Description>توضیحات</Description>
        /// </summary>
        public string TBL_BprDescription { get; set; }

        /// <summary>
        /// <Description>گره ها</Description>
        /// </summary>
       // public List<PriceRepertoryGridAction> PriceRepertoryGridActions { get; set; }
        
        ///// <summary>
        ///// <Description>عنوان</Description>
        ///// </summary>
        //public string TBL_BprNote { get; set; }
    }
}