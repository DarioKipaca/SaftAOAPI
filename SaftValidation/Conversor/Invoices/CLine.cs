using SaftValidation.Model.MasterFiles;
using SaftValidation.Model.SalesInvoice.Invoices.LineModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SaftValidation.Conversor.Invoices
{
    internal class CLine:VarGlobal
    {

        internal static Line Conversor(int Count, XmlReader xmlReader)
        {


            bool flag = true;
            Line entity = new Line();
            while (flag && xmlReader.Read())
            {
                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.Element:
                        switch (xmlReader.Name)
                        {
                            case "LineNumber":
                                flag2 = true;
                                while (flag2 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.LineNumber = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "LineNumber")
                                            {
                                                flag2 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "ProductCode":
                                flag3 = true;
                                while (flag3 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.ProductCode = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "ProductCode")
                                            {
                                                flag3 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "ProductDescription":
                                flag4 = true;
                                while (flag4 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.ProductDescription = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "ProductDescription")
                                            {
                                                flag4 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                    

                            case "Quantity":
                                flag10 = true;
                                while (flag10 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.Quantity = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "Quantity")
                                            {
                                                flag10 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "UnitOfMeasure":
                                flag11 = true;
                                while (flag11 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.UnitOfMeasure = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "UnitOfMeasure")
                                            {
                                                flag11 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "UnitPrice":
                                flag12 = true;
                                while (flag12 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.UnitPrice = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "UnitPrice")
                                            {
                                                flag12 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "TaxPointDate":
                                flag13 = true;
                                while (flag13 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.TaxPointDate = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "TaxPointDate")
                                            {
                                                flag13 = false;
                                            }
                                            break;
                                    }
                                }
                                break;

                            //******************************/
                            case "References":
                                entity.References=new References();
                                flag5 = true;
                                while (flag5 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Element:
                                            switch (xmlReader.Name)
                                            {
                                                case "Reference":
                                                    flag6 = true;
                                                    while (flag6 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                entity.References.Reference = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "Reference")
                                                                {
                                                                    flag6 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                case "Reason":
                                                    flag7 = true;
                                                    while (flag7 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                entity.References.Reason = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "Reason")
                                                                {
                                                                    flag7 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;
                    

                                            }
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "References")
                                            {
                                                flag5 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            //******************************/
                            
                            case "Description":
                                flag13 = true;
                                while (flag13 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.Description = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "Description")
                                            {
                                                flag13 = false;
                                            }
                                            break;
                                    }
                                }
                             break;


                            case "DebitAmount":
                                flag13 = true;
                                while (flag13 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.DebitAmount = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "DebitAmount")
                                            {
                                                flag13 = false;
                                            }
                                            break;
                                    }
                                }
                                break;

                            case "CreditAmount":
                                flag13 = true;
                                while (flag13 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.CreditAmount = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "CreditAmount")
                                            {
                                                flag13 = false;
                                            }
                                            break;
                                    }
                                }
                                break;

                            //******************************/
                            case "Tax":
                                entity.Tax=new Tax();
                                flag5 = true;
                                while (flag5 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Element:
                                            switch (xmlReader.Name)
                                            {
                                                case "TaxType":
                                                    flag6 = true;
                                                    while (flag6 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                entity.Tax.TaxType = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "TaxType")
                                                                {
                                                                    flag6 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                case "TaxCountryRegion":
                                                    flag7 = true;
                                                    while (flag7 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                entity.Tax.TaxCountryRegion = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "TaxCountryRegion")
                                                                {
                                                                    flag7 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;

                                                case "TaxCode":
                                                    flag7 = true;
                                                    while (flag7 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                entity.Tax.TaxCode = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "TaxCode")
                                                                {
                                                                    flag7 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;

                                                case "TaxPercentage":
                                                    flag7 = true;
                                                    while (flag7 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                entity.Tax.TaxPercentage = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "TaxPercentage")
                                                                {
                                                                    flag7 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;
                                            }
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "Tax")
                                            {
                                                flag5 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            //******************************/



                        }
                        break;
                    case XmlNodeType.EndElement:
                        if (xmlReader.Name == "Line")
                        {
                            entity.index= Count + 1;
                            flag = false;
                        }
                        break;
                }
            }
            ResetVar();
            return entity;
        }








    }
}
