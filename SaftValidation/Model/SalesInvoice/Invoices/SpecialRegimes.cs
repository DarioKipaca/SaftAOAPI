using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SaftValidation.Model.SalesInvoice.Invoices
{
    internal class SpecialRegimes
    {


        public string SelfBillingIndicator { get; set; }

        public string CashVATSchemeIndicator { get; set; }

        public string ThirdPartiesBillingIndicator { get; set; }
    }
}
