using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaftValidation.Model.MasterFiles
{
    internal class Product
    {

        public int index { get; set; }
        public string ProductType { get; set; }


        public string ProductCode { get; set; }


        public string ProductGroup { get; set; }


        public string ProductDescription { get; set; }

        public string ProductNumberCode { get; set; }

        public string CustomsDetails { get; set; }

        public string UNNumber { get; set; }
    }
}
