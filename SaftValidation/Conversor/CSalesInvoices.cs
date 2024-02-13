using SaftValidation.Conversor.Invoices;
using SaftValidation.Model;
using SaftValidation.Model.SalesInvoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SaftValidation.Conversor
{
    internal class CSalesInvoices:VarGlobal
    {

        internal static void Conversor(ref SalesInvoices _salesInvoices, XmlReader xmlReader)
        {


            flag32 = true;
            SalesInvoices entity2 = new SalesInvoices();
            while (flag32 && xmlReader.Read())
            {
                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.Element:
                        switch (xmlReader.Name)
                        {
                            case "NumberOfEntries":
                                flag33 = true;
                                while (flag33 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity2.NumberOfEntries = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "NumberOfEntries")
                                            {
                                                flag33 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "TotalDebit":
                                flag34 = true;
                                while (flag34 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity2.TotalDebit = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "TotalDebit")
                                            {
                                                flag34 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "TotalCredit":
                                flag35 = true;
                                while (flag35 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity2.TotalCredit = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "TotalCredit")
                                            {
                                                flag35 = false;
                                            }
                                            break;
                                    }
                                }
                                break;

                            case "Invoice":
                                ResetVar();
                    
                                CInvoice.Conversor( _invoice, xmlReader);
                                flag32 = true;

                                break;

                        }

                        break;
                    case XmlNodeType.EndElement:
                        if (xmlReader.Name == "SalesInvoices")
                        {
                            _salesInvoices = entity2;
                            flag32 = false;
                        }
                        break;

                }
            }
            ResetVar();



        }

    }
}
