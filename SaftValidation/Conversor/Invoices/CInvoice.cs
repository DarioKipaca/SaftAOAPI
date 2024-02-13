using SaftValidation.Model;
using SaftValidation.Model.MasterFiles;
using SaftValidation.Model.SalesInvoice;
using SaftValidation.Model.SalesInvoice.Invoices;
using SaftValidation.Model.SalesInvoice.Invoices.LineModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SaftValidation.Conversor.Invoices
{
    internal class CInvoice : VarGlobal
    {

        internal static void Conversor(List<Invoice> _invoice, XmlReader xmlReader)
        {



            flag27 = true;
            Invoice itemBE = new Invoice();
            while (flag27 && xmlReader.Read())
            {
                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.Element:
                        switch (xmlReader.Name)
                        {

                            case "InvoiceNo":
                                flag29 = true;
                                while (flag29 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            itemBE.InvoiceNo = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "InvoiceNo")
                                            {
                                                flag29 = false;
                                            }
                                            break;
                                    }
                                }
                                break;

                            case "DocumentStatus":
                                flag39 = true;
                                itemBE.DocumentStatus = new DocumentStatus();
                                while (flag39 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Element:
                                            switch (xmlReader.Name)
                                            {
                                                case "InvoiceStatus":
                                                    flag51 = true;
                                                    while (flag51 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                itemBE.DocumentStatus.InvoiceStatus = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "InvoiceStatus")
                                                                {
                                                                    flag51 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                case "InvoiceStatusDate":
                                                    flag52 = true;
                                                    while (flag52 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                itemBE.DocumentStatus.InvoiceStatusDate = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "InvoiceStatusDate")
                                                                {
                                                                    flag52 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                case "SourceID":
                                                    flag53 = true;
                                                    while (flag53 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                itemBE.DocumentStatus.SourceID = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "SourceID")
                                                                {
                                                                    flag53 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                case "SourceBilling":
                                                    flag54 = true;
                                                    while (flag54 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                itemBE.DocumentStatus.SourceBilling = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "SourceBilling")
                                                                {

                                                                    flag54 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;

                                                case "Reason":
                                                    flag55 = true;
                                                    while (flag55 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                itemBE.DocumentStatus.Reason = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "Reason")
                                                                {

                                                                    flag55 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;
                                            }
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "DocumentStatus")
                                            {
                                                flag39 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "Hash":
                                flag40 = true;
                                while (flag40 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            itemBE.Hash = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "Hash")
                                            {
                                                flag40 = false;
                                            }
                                            break;
                                    }
                                }
                                break;


                            case "HashControl":
                                flag41 = true;
                                while (flag41 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            itemBE.HashControl = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "HashControl")
                                            {
                                                flag41 = false;
                                            }
                                            break;
                                    }
                                }
                                break;

                            case "Period":
                                flag42 = true;
                                while (flag42 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            itemBE.Period = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "Period")
                                            {
                                                flag42 = false;
                                            }
                                            break;
                                    }
                                }
                                break;

                            case "InvoiceDate":
                                flag43 = true;
                                while (flag43 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            itemBE.InvoiceDate = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "InvoiceDate")
                                            {
                                                flag43 = false;
                                            }
                                            break;
                                    }
                                }
                                break;

                            case "InvoiceType":
                                flag44 = true;
                                while (flag44 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            itemBE.InvoiceType = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "InvoiceType")
                                            {
                                                flag44 = false;
                                            }
                                            break;
                                    }
                                }
                                break;



                            case "SpecialRegimes":
                                flag39 = true;
                                itemBE.SpecialRegimes = new SpecialRegimes();
                                while (flag39 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Element:
                                            switch (xmlReader.Name)
                                            {
                                                case "SelfBillingIndicator":
                                                    flag51 = true;
                                                    while (flag51 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                itemBE.SpecialRegimes.SelfBillingIndicator = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "SelfBillingIndicator")
                                                                {
                                                                    flag51 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                case "CashVATSchemeIndicator":
                                                    flag52 = true;
                                                    while (flag52 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                itemBE.SpecialRegimes.SelfBillingIndicator = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "CashVATSchemeIndicator")
                                                                {
                                                                    flag52 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                case "ThirdPartiesBillingIndicator":
                                                    flag53 = true;
                                                    while (flag53 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                itemBE.SpecialRegimes.ThirdPartiesBillingIndicator = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "ThirdPartiesBillingIndicator")
                                                                {
                                                                    flag53 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;


                                            }
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "SpecialRegimes")
                                            {
                                                flag39 = false;
                                            }
                                            break;
                                    }
                                }
                                break;


                            case "SourceID":
                                flag44 = true;
                                while (flag44 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            itemBE.SourceID = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "SourceID")
                                            {
                                                flag44 = false;
                                            }
                                            break;
                                    }
                                }
                                break;


                            case "EACCode":
                                flag44 = true;
                                while (flag44 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            itemBE.EACCode = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "EACCode")
                                            {
                                                flag44 = false;
                                            }
                                            break;
                                    }
                                }
                                break;


                            case "SystemEntryDate":
                                flag44 = true;
                                while (flag44 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            itemBE.SystemEntryDate = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "SystemEntryDate")
                                            {
                                                flag44 = false;
                                            }
                                            break;
                                    }
                                }
                                break;


                            case "CustomerID":
                                flag44 = true;
                                while (flag44 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            itemBE.CustomerID = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "CustomerID")
                                            {
                                                flag44 = false;
                                            }
                                            break;
                                    }
                                }
                                break;



                            case "Line":

                                if (itemBE.Lines == null)
                                    itemBE.Lines = new List<Line>();

                                ResetVar();
                                Line _lines= CLine.Conversor(itemBE.Lines.Count,xmlReader);
                                itemBE.Lines.Add(_lines);
                                flag27 = true;
                                break;


                            case "DocumentTotals":
                                flag39 = true;
                                itemBE.DocumentTotals = new DocumentTotals();
                                while (flag39 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Element:
                                            switch (xmlReader.Name)
                                            {
                                                case "TaxPayable":
                                                    flag51 = true;
                                                    while (flag51 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                itemBE.DocumentTotals.TaxPayable = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "TaxPayable")
                                                                {
                                                                    flag51 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                case "NetTotal":
                                                    flag52 = true;
                                                    while (flag52 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                itemBE.DocumentTotals.NetTotal = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "NetTotal")
                                                                {
                                                                    flag52 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                case "GrossTotal":
                                                    flag53 = true;
                                                    while (flag53 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                itemBE.DocumentTotals.GrossTotal = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "GrossTotal")
                                                                {
                                                                    flag53 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;
                                            }
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "DocumentTotals")
                                            {
                                                flag39 = false;
                                            }
                                            break;
                                    }
                                }
                                break;







                        }
                        break;
                    case XmlNodeType.EndElement:
                        if (xmlReader.Name == "Invoice")
                        {
                            itemBE.index = _invoice.Count + 1;
                            _invoice.Add(itemBE);
                            flag27 = false;
                        }
                        break;
                }
            }
            ResetVar();

        }


    }
}
