using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SaftValidation.Model
{
    internal class Header
    {

        public string AuditFileVersion { get; set; }

        public string CompanyID { get; set; }
        public string TaxRegistrationNumber { get; set; }
        public string TaxAccountingBasis { get; set; }
        public string CompanyName { get; set; }
        public string BusinessName { get; set; }
        public CompanyAddress CompanyAddress = new CompanyAddress();
        public string FiscalYear { get; set; }
        public string CurrencyCode { get; set; }
        public string DateCreated { get; set; }
        public string TaxEntity { get; set; }
        public string ProductCompanyTaxID { get; set; }
        public string SoftwareValidationNumber { get; set; }
        public string ProductID { get; set; }
        public string ProductVersion { get; set; }
        public string HeaderComment { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }






    }
}
