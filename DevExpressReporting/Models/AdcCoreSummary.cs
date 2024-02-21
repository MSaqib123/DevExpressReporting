using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpressReporting.Models
{
    public class AdcCoreSummary
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Branch { get; set; }
        public string GlCode { get; set; }
        public string Description { get; set; }
        public decimal Op_Bal_A { get; set; }
        public decimal Cl_Bal_B { get; set; }
        public decimal Trans_Count { get; set; }
        public decimal debit_amount { get; set; }
        public decimal credit_amount { get; set; }
        public decimal Diff_in_Open_Cls_Bal_A { get; set; }
        public decimal Sum_of_Db_Cr_Summation_B { get; set; }
        public decimal Differnce_A_B { get; set; }
    }
}