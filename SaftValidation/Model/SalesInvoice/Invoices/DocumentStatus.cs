using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SaftValidation.Model.SalesInvoice.Invoices
{
    internal class DocumentStatus
    {



        public string InvoiceStatusDate { get; set; }


        public string InvoiceStatus { get; set; }

        public string Reason { get; set; }


        public string SourceID { get; set; }

        public string SourceBilling { get; set; }


    }
}
