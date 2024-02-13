using SaftValidation.Model.MasterFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SaftValidation.Conversor
{
    internal class CCustomer:VarGlobal
    {

        internal static void Conversor(List<Customer> _customers, XmlReader xmlReader)
        {


           bool  flag = true;
            Customer entity = new Customer();
            while (flag && xmlReader.Read())
            {
                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.Element:
                        switch (xmlReader.Name)
                        {
                            case "CustomerID":
                                flag2 = true;
                                while (flag2 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.CustomerID = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "CustomerID")
                                            {
                                                flag2 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "CustomerTaxID":
                                flag3 = true;
                                while (flag3 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.CustomerTaxID = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "CustomerTaxID")
                                            {
                                                flag3 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "CompanyName":
                                flag4 = true;
                                while (flag4 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.CompanyName = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "CompanyName")
                                            {
                                                flag4 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "BillingAddress":
                                flag5 = true;
                                while (flag5 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Element:
                                            switch (xmlReader.Name)
                                            {
                                                case "AddressDetail":
                                                    flag6 = true;
                                                    while (flag6 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                entity.AddressDetail = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "AddressDetail")
                                                                {
                                                                    flag6 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                case "City":
                                                    flag7 = true;
                                                    while (flag7 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                entity.City = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "City")
                                                                {
                                                                    flag7 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                case "PostalCode":
                                                    flag8 = true;
                                                    while (flag8 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                entity.PostalCode = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "PostalCode")
                                                                {
                                                                    flag8 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                case "Country":
                                                    flag9 = true;
                                                    while (flag9 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                entity.Country = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "Country")
                                                                {
                                                                    flag9 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;
                                            }
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "BillingAddress")
                                            {
                                                flag5 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "Contact":
                                flag10 = true;
                                while (flag10 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.Contact = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "Contact")
                                            {
                                                flag10 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "Telephone":
                                flag11 = true;
                                while (flag11 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.Telephone = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "Telephone")
                                            {
                                                flag11 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "Email":
                                flag12 = true;
                                while (flag12 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.Email = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "Email")
                                            {
                                                flag12 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "Fax":
                                flag13 = true;
                                while (flag13 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.Fax = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "Fax")
                                            {
                                                flag13 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                        }
                        break;
                    case XmlNodeType.EndElement:
                        if (xmlReader.Name == "Customer")
                        {
                            entity.index= _customers.Count+1;

                            _customers.Add(entity);
                            flag = false;
                        }
                        break;
                }
            }
            ResetVar();
        }
    }
}
