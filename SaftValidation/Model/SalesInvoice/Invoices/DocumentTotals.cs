using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SaftValidation.Model.SalesInvoice.Invoices
{
    internal class DocumentTotals
    {

        public string TaxPayable { get; set; }

        public string NetTotal { get; set; }

        public string GrossTotal { get; set; }

    }
}
