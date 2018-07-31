using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace GQ
{

   
    public class VMPriceRepertoryGridAction
    {

        public VMPriceRepertoryGridAction()
        {

        }
        /// <summary>
        /// <Description>شناسه فهرست بهاء</Description>
        /// </summary>
        public bool HasChildren { get; set; }
        /// <summary>
        /// <Description>شناسه فهرست بهاء</Description>
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// <Description>شناسه والد </Description>
        /// </summary>
        public string TBL_BprParentID_fk { get; set; }
        /// <summary>
        /// <Description>گره</Description>
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// <Description></Description>
        /// </summary>
        public bool IsExpanded { get; set; }
        /// <summary>
        /// <Description></Description>
        /// </summary>
        //public Dictionary<string,string> Children { get; set; }


        ///// <summary>
        ///// <Description></Description>
        ///// </summary>
        //public string Icon { get; set; } = "fa fa-database fa-fw";
        ///// <summary>
        ///// <Description></Description>
        ///// </summary>
        //public string Checked { get; set; }="false";
        ///// <summary>
        ///// <Description>نود</Description>
        ///// </summary>
        //public string Leaf { get; set; } = "true";
        /// <summary>
        /// <Description></Description>
        /// </summary>
        //public bool HasChildren { get; set; }


    }
}