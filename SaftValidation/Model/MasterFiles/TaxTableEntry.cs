using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SaftValidation.Model.MasterFiles
{
    internal class TaxTableEntry
    {


        public int index { get; set; }
        public string TaxType { get; set; }
        public string TaxCountryRegion { get; set; }
        public string TaxCode { get; set; }

        public string Description { get; set; }

        public string TaxExpirationDate { get; set; }
        public string TaxPercentage { get; set; }
        public string TaxAmount { get; set; }
    }
}
