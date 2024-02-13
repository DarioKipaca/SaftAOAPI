using SaftValidation.Model;
using SaftValidation.Model.MasterFiles;
using SaftValidation.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SaftValidation.Conversor
{
    public  class SaftConvert : VarGlobal
    {


        public static List<Messageresult> Validetion(Stream filePath, Stream Publickey)
        {
            _messageresults.Clear();
            Validation.Validation Hashvalidetion=new Validation.Validation(Publickey);

            using (XmlReader xmlReader = XmlReader.Create(filePath, new XmlReaderSettings
            {
                DtdProcessing = DtdProcessing.Parse
            }))
            {
         

                xmlReader.MoveToContent();
                while (xmlReader.Read())
                {
                    if (xmlReader.NodeType != XmlNodeType.Element || string.IsNullOrWhiteSpace(xmlReader.Name))
                    {
                        continue;
                    }
                    switch (xmlReader.Name)
                    {

                        case "Header":
                            CHeader.Conversor(ref _header, xmlReader);
                            break;

                        case "Customer":
                            CCustomer.Conversor(_customers, xmlReader);
                            break;

                        case "Supplier":

                            CSupplier.Conversor(_suppliers, xmlReader);
                            break;

                        case "Product":
                            CProduct.Conversor(_products, xmlReader);
                            break;

                        case "TaxTableEntry":
                            CTaxTable.Conversor(_taxTableEntry, xmlReader);
                            break;

                        case "SalesInvoices":



                            CSalesInvoices.Conversor(ref _salesInvoices, xmlReader);



                            break;

                        //case "Invoice":
                        //    CInvoice.Conversor(_invoice, xmlReader);
                        //    break;


                    }
                }
      
            }
            Hashvalidetion.ValidationHash();
            Hashvalidetion.Validationserie();
            Hashvalidetion.ValidationTotalCreditanddebit();
            Hashvalidetion.ValidationFormatDate();

            ResetList();
            return _messageresults;
        }
    }
}
