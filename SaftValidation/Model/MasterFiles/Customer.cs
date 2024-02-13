using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaftValidation.Model.MasterFiles
{
    internal class Customer
    {

        public int index {  get; set; }
        public string CustomerID { get; set; }


        public string AccountID { get; set; }


        public string CustomerTaxID { get; set; }


        public string CompanyName { get; set; }

        public string Contact { get; set; }


        public string BuildingNumber { get; set; }

        public string StreetName { get; set; }


        public string AddressDetail { get; set; }


        public string City { get; set; }

        public string PostalCode { get; set; }


        public string Province { get; set; }

        public string Country { get; set; }


        public string Telephone { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        public string Website { get; set; }
        public int SelfBillingIndicator { get; set; }
    }
}
