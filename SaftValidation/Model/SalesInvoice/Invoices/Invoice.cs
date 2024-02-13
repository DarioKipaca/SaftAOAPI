using SaftValidation.Model.SalesInvoice.Invoices.LineModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SaftValidation.Model.SalesInvoice.Invoices
{
    internal class Invoice
    {

        public int index { get; set; }

        public string InvoiceNo { get; set; }


        public string Hash { get; set; }


        public string HashControl { get; set; }


        public string SourceID { get; set; }

        public string SupplierID { get; set; }


        public string EACCode { get; set; }


        public DocumentStatus DocumentStatus { get; set; }


        public SpecialRegimes SpecialRegimes { get; set; }


        public string InvoiceDate { get; set; }


        public string Period { get; set; }

        public string InvoiceType { get; set; }


        public string SystemEntryDate { get; set; }

        public string TransactionID { get; set; }


        public string CustomerID { get; set; }

        // public ShipTo ShipTo = new ShipTo();

        //public ShipFrom ShipFrom = new ShipFrom();


        public DocumentTotals DocumentTotals { get; set; }

        public string MovementEndTime { get; set; }

        public string MovementStartTime { get; set; }
         public List<Line> Lines { get; set; }

        //public WithholdingTax WithholdingTax = new WithholdingTax();










    }
}
