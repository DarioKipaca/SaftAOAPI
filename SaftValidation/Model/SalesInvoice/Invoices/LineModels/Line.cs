using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SaftValidation.Model.SalesInvoice.Invoices.LineModels
{
    internal class Line
    {


        public int index { get; set; }
        public string LineNumber { get; set; }

        //   public OrderReferences OrderReferences = new OrderReferences();

        public string ProductCode { get; set; }

        public string ProductDescription { get; set; }

        public string Quantity { get; set; }

        public string UnitOfMeasure { get; set; }

        public string UnitPrice { get; set; }

        public int TaxBase { get; set; }


        public string TaxPointDate { get; set; }


        public References References { get; set; }

        public string Description { get; set; }

        // public ProductSerialNumber[] ProductSerialNumber = new ProductSerialNumber[0];

        public string DebitAmount { get; set; }


        public string CreditAmount { get; set; }


        public Tax Tax { get; set; }

        public double SettlementAmount { get; set; }

        //public CustomsInformation CustomsInformation = new CustomsInformation();

        public string TaxExemptionReason { get; set; }

        public string TaxExemptionCode { get; set; }




    }
}
