using AutoMapper;
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
        public bool TBL_BprHasChildren { get; set; }
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


    public class BasePriceRepertoryPriceTextFieldAction
    {
        public BasePriceRepertoryPriceTextFieldAction(){}

             public string TBL_BprID { get; set; }
             public string  TBL_BprParentID_fk      { get; set; }
             public string  TBL_PrcID_fk                   { get; set; }
             public string  WHS_GuID_fk                    { get; set; }
             public string  CNT_CbID_fk                    { get; set; }
             public string  TBL_BprCode                    { get; set; }
             public string  TBL_BprOldCode                 { get; set; }
             public string  TBL_BprDescription             { get; set; }
             public string  TBL_BprWarehouseCoding         { get; set; }
             public string  TBL_BprTransportCoefficient     { get; set; } 
             public string  TBL_BprMaterialPrice            { get; set; }
             public string  TBL_BprPayPrice                 { get; set; }
             public string  TBL_BprMachineryPrice           { get; set; }
             public string  TBL_BprDeparePrice1             { get; set; }
             public string  TBL_BprDeparePrice2             { get; set; }
             public string TBL_BprDeparePrice3              { get; set; }
             public string TBL_BprMachineryDeparePrice      { get; set; }
             public string TBL_BprPayDeparePrice            { get; set; }
             public string TBL_BprDisposePrice              { get; set; }
             public string TBL_BprMachineryMovePrice        { get; set; }
             public string TBL_BprPayMovePrice              { get; set; }
             public string TBL_BprPrice                     { get; set; }
             public string TBL_BprQuantity                  { get; set; }
             public string TBL_BprNote                      { get; set; }
             public string TBL_BprType                      { get; set; }
             public string TBL_BprActive                    { get; set; }
             public string   TBL_BprStatus                  { get; set; }
             public string   TBL_BprRegisterDate            { get; set; }
             public string   TBL_BprDeleteDate              { get; set; }
             public string   ACC_FinancialYearID            { get; set; }
             public string TBL_UserID                      { get; set; }
    }


public class ProjectManagementSystemProjectReportGridAction
    {
        public ProjectManagementSystemProjectReportGridAction(){ }
        public string TBL_BprhID { get; set; }
        public string TBL_BprID_fk { get; set; }
        public string TBL_BprhExecuteDate { get; set; }
        public string TBL_BprhExpireDate { get; set; }
        public string TBL_BprhMaterialPrice { get; set; }
        public string TBL_BprhPayPrice { get; set; }
        public string TBL_BprhMachineryPrice { get; set; }
        public string TBL_BprhDeparePrice1 { get; set; }
        public string TBL_BprhDeparePrice2 { get; set; }
        public string TBL_BprhDeparePrice3 { get; set; }
        public string TBL_BprhMachineryDeparePrice { get; set; }
        public string TBL_BprhPayDeparePrice { get; set; }
        public string TBL_BprhDisposePrice { get; set; }
        public string TBL_BprhMachineyMovePrice { get; set; }
        public string TBL_BprhPayMovePrice { get; set; }
        public string TBL_BprhNote { get; set; }
        public string TBL_BprhType { get; set; }
        public string TBL_BprhActive { get; set; }
        public string TBL_BprhStatus { get; set; }
        public string TBL_BprhRegisterDate { get; set; }
        public string TBL_BprhDeleteDate { get; set; }
        public string ACC_FinancialYearID { get; set; }
        public string TBL_UserID { get; set; }
    }
 }

  