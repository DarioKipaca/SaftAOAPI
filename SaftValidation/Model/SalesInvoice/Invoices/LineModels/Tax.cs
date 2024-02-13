using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SaftValidation.Model.SalesInvoice.Invoices.LineModels
{
    internal class Tax
    {


        public string TaxType { get; set; }
        public string TaxCountryRegion { get; set; }
        public string TaxCode { get; set; }
        public string TaxPercentage { get; set; }
        public string TaxAmount { get; set; }



    }
}
