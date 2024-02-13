using SaftValidation.Model.MasterFiles;
using SaftValidation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaftValidation.Model.SalesInvoice;
using SaftValidation.Model.SalesInvoice.Invoices;
using SaftValidation.Conversor;
using System.Reflection.PortableExecutable;

namespace SaftValidation
{
    public class VarGlobal
    {
        internal static List<Customer> _customers = new List<Customer>();

        internal static List<Supplier2> _suppliers = new List<Supplier2>();

        internal static List<Product> _products = new List<Product>();

        internal static Header _header;

        internal static SalesInvoices _salesInvoices = new SalesInvoices();

        internal static List<TaxTableEntry> _taxTableEntry = new List<TaxTableEntry>();

        internal static List<Invoice> _invoice = new List<Invoice>();
        internal static List<Messageresult> _messageresults = new List<Messageresult>();
        internal static Messageresult _message = new Messageresult();


        internal static void ResetList()
        {
            _invoice.Clear();
            _customers.Clear();
            _suppliers.Clear();
            _products.Clear();
            _header = null;
            _salesInvoices = new SalesInvoices();
            _message = new Messageresult();
            _taxTableEntry.Clear();
        }

        internal static bool flag = false;
        internal static bool flag2 = false;
        internal static bool flag3 = false;
        internal static bool flag4 = false;
        internal static bool flag5 = false;
        internal static bool flag6 = false;
        internal static bool flag7 = false;
        internal static bool flag8 = false;
        internal static bool flag9 = false;
        internal static bool flag10 = false;
        internal static bool flag11 = false;
        internal static bool flag12 = false;
        internal static bool flag13 = false;
        internal static bool flag14 = false;
        internal static bool flag15 = false;
        internal static bool flag16 = false;
        internal static bool flag17 = false;
        internal static bool flag18 = false;
        internal static bool flag19 = false;
        internal static bool flag20 = false;
        internal static bool flag21 = false;
        internal static bool flag22 = false;
        internal static bool flag23 = false;
        internal static bool flag24 = false;
        internal static bool flag25 = false;
        internal static bool flag26 = false;
        internal static bool flag27 = false;
        internal static bool flag28 = false;
        internal static bool flag29 = false;
        internal static bool flag30 = false;
        internal static bool flag31 = false;
        internal static bool flag32 = false;
        internal static bool flag33 = false;
        internal static bool flag34 = false;
        internal static bool flag35 = false;
        internal static bool flag36 = false;
        internal static bool flag37 = false;
        internal static bool flag38 = false;
        internal static bool flag39 = false;
        internal static bool flag40 = false;
        internal static bool flag41 = false;
        internal static bool flag42 = false;
        internal static bool flag43 = false;
        internal static bool flag44 = false;
        internal static bool flag45 = false;
        internal static bool flag46 = false;
        internal static bool flag47 = false;
        internal static bool flag48 = false;
        internal static bool flag49 = false;
        internal static bool flag50 = false;
        internal static bool flag51 = false;
        internal static bool flag52 = false;
        internal static bool flag53 = false;
        internal static bool flag54 = false;
        internal static bool flag55 = false;
        internal static bool flag56 = false;
        internal static bool flag57 = false;
        internal static bool flag58 = false;
        internal static bool flag59 = false;
        internal static bool flag60 = false;
        internal static bool flag61 = false;
        internal static bool flag62 = false;
        internal static bool flag63 = false;
        internal static bool flag64 = false;
        internal static bool flag65 = false;

        public static void ResetVar()
        {

            flag = false;
            flag2 = false;
            flag3 = false;
            flag4 = false;
            flag5 = false;
            flag6 = false;
            flag7 = false;
            flag8 = false;
            flag9 = false;
            flag10 = false;
            flag11 = false;
            flag12 = false;
            flag13 = false;
            flag14 = false;
            flag15 = false;
            flag16 = false;
            flag17 = false;
            flag18 = false;
            flag19 = false;
            flag20 = false;
            flag21 = false;
            flag22 = false;
            flag23 = false;
            flag24 = false;
            flag25 = false;
            flag26 = false;
            flag27 = false;
            flag28 = false;
            flag29 = false;
            flag30 = false;
            flag31 = false;
            flag32 = false;
            flag33 = false;
            flag34 = false;
            flag35 = false;
            flag36 = false;
            flag37 = false;
            flag38 = false;
            flag39 = false;
            flag40 = false;
            flag41 = false;
            flag42 = false;
            flag43 = false;
            flag44 = false;
            flag45 = false;
            flag46 = false;
            flag47 = false;
            flag48 = false;
            flag49 = false;
            flag50 = false;
            flag51 = false;
            flag52 = false;
            flag53 = false;
            flag54 = false;
            flag55 = false;
            flag56 = false;
            flag57 = false;
            flag58 = false;
            flag59 = false;
            flag60 = false;
            flag61 = false;
            flag62 = false;
            flag63 = false;
            flag64 = false;
            flag65 = false;

        }

    }
}
