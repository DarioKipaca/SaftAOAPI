using SaftValidation.Model.MasterFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SaftValidation.Conversor
{
    internal class CSupplier : VarGlobal
    {
        internal static void Conversor(List<Supplier2> _suppliers, XmlReader xmlReader)
        {

                flag14 = true;
                Supplier2 entity2 = new Supplier2();
                while (flag14 && xmlReader.Read())
                {
                    switch (xmlReader.NodeType)
                    {
                        case XmlNodeType.Element:
                            switch (xmlReader.Name)
                            {
                                case "SupplierID":
                                    flag15 = true;
                                    while (flag15 && xmlReader.Read())
                                    {
                                        switch (xmlReader.NodeType)
                                        {
                                            case XmlNodeType.Text:
                                                entity2.SupplierID = xmlReader.Value;
                                                break;
                                            case XmlNodeType.EndElement:
                                                if (xmlReader.Name == "SupplierID")
                                                {
                                                    flag15 = false;
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case "SupplierTaxID":
                                    flag16 = true;
                                    while (flag16 && xmlReader.Read())
                                    {
                                        switch (xmlReader.NodeType)
                                        {
                                            case XmlNodeType.Text:
                                                entity2.SupplierTaxID = xmlReader.Value;
                                                break;
                                            case XmlNodeType.EndElement:
                                                if (xmlReader.Name == "SupplierTaxID")
                                                {
                                                    flag16 = false;
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case "CompanyName":
                                    flag17 = true;
                                    while (flag17 && xmlReader.Read())
                                    {
                                        switch (xmlReader.NodeType)
                                        {
                                            case XmlNodeType.Text:
                                                entity2.CompanyName = xmlReader.Value;
                                                break;
                                            case XmlNodeType.EndElement:
                                                if (xmlReader.Name == "CompanyName")
                                                {
                                                    flag17 = false;
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case "BillingAddress":
                                    flag18 = true;
                                    while (flag18 && xmlReader.Read())
                                    {
                                        switch (xmlReader.NodeType)
                                        {
                                            case XmlNodeType.Element:
                                                switch (xmlReader.Name)
                                                {
                                                    case "AddressDetail":
                                                        flag19 = true;
                                                        while (flag19 && xmlReader.Read())
                                                        {
                                                            switch (xmlReader.NodeType)
                                                            {
                                                                case XmlNodeType.Text:
                                                                    entity2.AddressDetail = xmlReader.Value;
                                                                    break;
                                                                case XmlNodeType.EndElement:
                                                                    if (xmlReader.Name == "AddressDetail")
                                                                    {
                                                                        flag19 = false;
                                                                    }
                                                                    break;
                                                            }
                                                        }
                                                        break;
                                                    case "City":
                                                        flag20 = true;
                                                        while (flag20 && xmlReader.Read())
                                                        {
                                                            switch (xmlReader.NodeType)
                                                            {
                                                                case XmlNodeType.Text:
                                                                    entity2.City = xmlReader.Value;
                                                                    break;
                                                                case XmlNodeType.EndElement:
                                                                    if (xmlReader.Name == "City")
                                                                    {
                                                                        flag20 = false;
                                                                    }
                                                                    break;
                                                            }
                                                        }
                                                        break;
                                                    case "PostalCode":
                                                        flag21 = true;
                                                        while (flag21 && xmlReader.Read())
                                                        {
                                                            switch (xmlReader.NodeType)
                                                            {
                                                                case XmlNodeType.Text:
                                                                    entity2.PostalCode = xmlReader.Value;
                                                                    break;
                                                                case XmlNodeType.EndElement:
                                                                    if (xmlReader.Name == "PostalCode")
                                                                    {
                                                                        flag21 = false;
                                                                    }
                                                                    break;
                                                            }
                                                        }
                                                        break;
                                                    case "Country":
                                                        flag22 = true;
                                                        while (flag22 && xmlReader.Read())
                                                        {
                                                            switch (xmlReader.NodeType)
                                                            {
                                                                case XmlNodeType.Text:
                                                                    entity2.Country = xmlReader.Value;
                                                                    break;
                                                                case XmlNodeType.EndElement:
                                                                    if (xmlReader.Name == "Country")
                                                                    {

                                                                        flag22 = false;
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
                                                    flag18 = false;
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case "Contact":
                                    flag23 = true;
                                    while (flag23 && xmlReader.Read())
                                    {
                                        switch (xmlReader.NodeType)
                                        {
                                            case XmlNodeType.Text:
                                                entity2.Contact = xmlReader.Value;
                                                break;
                                            case XmlNodeType.EndElement:
                                                if (xmlReader.Name == "Contact")
                                                {
                                                    flag23 = false;
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case "Telephone":
                                    flag24 = true;
                                    while (flag24 && xmlReader.Read())
                                    {
                                        switch (xmlReader.NodeType)
                                        {
                                            case XmlNodeType.Text:
                                                entity2.Telephone = xmlReader.Value;
                                                break;
                                            case XmlNodeType.EndElement:
                                                if (xmlReader.Name == "Telephone")
                                                {
                                                    flag24 = false;
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case "Email":
                                    flag25 = true;
                                    while (flag25 && xmlReader.Read())
                                    {
                                        switch (xmlReader.NodeType)
                                        {
                                            case XmlNodeType.Text:
                                                entity2.Email = xmlReader.Value;
                                                break;
                                            case XmlNodeType.EndElement:
                                                if (xmlReader.Name == "Email")
                                                {
                                                    flag25 = false;
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case "Fax":
                                    flag26 = true;
                                    while (flag26 && xmlReader.Read())
                                    {
                                        switch (xmlReader.NodeType)
                                        {
                                            case XmlNodeType.Text:
                                                entity2.Fax = xmlReader.Value;
                                                break;
                                            case XmlNodeType.EndElement:
                                                if (xmlReader.Name == "Fax")
                                                {
                                                    flag26 = false;
                                                }
                                                break;
                                        }
                                    }
                                    break;
                            }
                            break;
                        case XmlNodeType.EndElement:
                            if (xmlReader.Name == "Supplier")
                            {
                                _suppliers.Add(entity2);
                                flag14 = false;
                            }
                            break;
                    }
                }

            ResetVar();

        }
    }
}
