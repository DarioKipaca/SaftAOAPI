using SaftValidation.Model;
using SaftValidation.Model.MasterFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SaftValidation.Conversor
{
    internal class CHeader:VarGlobal
    {
        internal static void Conversor(ref Header _header, XmlReader xmlReader)
        {
            flag32 = true;
            Header entity2 = new Header();
       
            while (flag32 && xmlReader.Read())
            {
                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.Element:
                        switch (xmlReader.Name)
                        {
                            case "AuditFileVersion":
                                flag33 = true;
                                while (flag33 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity2.AuditFileVersion = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "AuditFileVersion")
                                            {
                                                flag33 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "CompanyID":
                                flag34 = true;
                                while (flag34 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity2.CompanyID = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "CompanyID")
                                            {
                                                flag34 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "TaxRegistrationNumber":
                                flag35 = true;
                                while (flag35 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity2.TaxRegistrationNumber = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "TaxRegistrationNumber")
                                            {
                                                flag35 = false;
                                            }
                                            break;
                                    }
                                }
                                break;

                            case "TaxAccountingBasis":
                                flag36 = true;
                                while (flag36 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity2.TaxAccountingBasis = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "TaxAccountingBasis")
                                            {
                                                flag36 = false;
                                            }
                                            break;
                                    }
                                }
                                break;

                            case "CompanyName":
                                flag37 = true;
                                while (flag37 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity2.CompanyName = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "CompanyName")
                                            {
                                                flag37 = false;
                                            }
                                            break;
                                    }
                                }
                                break;

                            case "BusinessName":
                                flag38 = true;
                                while (flag38 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity2.BusinessName = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "BusinessName")
                                            {
                                                flag38 = false;
                                            }
                                            break;
                                    }
                                }
                                break;


                             
                            case "CompanyAddress":
                                flag39 = true;
                                entity2.CompanyAddress = new CompanyAddress();
                                while (flag39 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Element:
                                            switch (xmlReader.Name)
                                            {
                                                case "AddressDetail":
                                                    flag51 = true;
                                                    while (flag51 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                entity2.CompanyAddress.AddressDetail = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "AddressDetail")
                                                                {
                                                                    flag51 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                case "City":
                                                    flag52 = true;
                                                    while (flag52 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                entity2.CompanyAddress.City = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "City")
                                                                {
                                                                    flag52 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                case "PostalCode":
                                                    flag53 = true;
                                                    while (flag53 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                entity2.CompanyAddress.PostalCode = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "PostalCode")
                                                                {
                                                                    flag53 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                case "Country":
                                                    flag54 = true;
                                                    while (flag54 && xmlReader.Read())
                                                    {
                                                        switch (xmlReader.NodeType)
                                                        {
                                                            case XmlNodeType.Text:
                                                                entity2.CompanyAddress.Country = xmlReader.Value;
                                                                break;
                                                            case XmlNodeType.EndElement:
                                                                if (xmlReader.Name == "Country")
                                                                {

                                                                    flag54 = false;
                                                                }
                                                                break;
                                                        }
                                                    }
                                                    break;
                                            }
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "CompanyAddress")
                                            {
                                                flag39 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "FiscalYear":
                                flag55 = true;
                                while (flag55 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity2.FiscalYear = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "FiscalYear")
                                            {
                                                flag55 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "StartDate":
                                flag40 = true;
                                while (flag40 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity2.StartDate = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "StartDate")
                                            {
                                                flag40 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "EndDate":
                                flag41= true;
                                while (flag41 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity2.EndDate = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "EndDate")
                                            {
                                                flag41 = false;
                                            }
                                            break;
                                    }
                                }
                                break;

                            case "CurrencyCode":
                                flag42 = true;
                                while (flag42 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity2.CurrencyCode = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "CurrencyCode")
                                            {
                                                flag42 = false;
                                            }
                                            break;
                                    }
                                }


                                break;

                            case "DateCreated":
                                flag43 = true;
                                while (flag43 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity2.DateCreated = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "DateCreated")
                                            {
                                                flag43 = false;
                                            }
                                            break;
                                    }
                                }
                                break;

                            case "TaxEntity":
                                flag44 = true;
                                while (flag44 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity2.TaxEntity = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "TaxEntity")
                                            {
                                                flag44 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                                
                            case "ProductCompanyTaxID":
                                flag45 = true;
                                while (flag45 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity2.TaxEntity = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "ProductCompanyTaxID")
                                            {
                                                flag45 = false;
                                            }
                                            break;
                                    }
                                }
                                break;

                            case "SoftwareValidationNumber":
                                flag45 = true;
                                while (flag45 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity2.SoftwareValidationNumber = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "SoftwareValidationNumber")
                                            {
                                                flag45 = false;
                                            }
                                            break;
                                    }
                                }
                                break;


                            case "ProductID":
                                flag46 = true;
                                while (flag46 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity2.ProductID = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "ProductID")
                                            {
                                                flag46 = false;
                                            }
                                            break;
                                    }
                                }
                                break;

                            case "ProductVersion":
                                flag47 = true;
                                while (flag47 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity2.ProductVersion = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "ProductVersion")
                                            {
                                                flag47 = false;
                                            }
                                            break;
                                    }
                                }
                                break;



                            case "Telephone":
                                flag48 = true;
                                while (flag48 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity2.Telephone = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "Telephone")
                                            {
                                                flag48 = false;
                                            }
                                            break;
                                    }
                                }
                                break;


                            case "Email":
                                flag49 = true;
                                while (flag49 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity2.Email = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "Email")
                                            {
                                                flag49 = false;
                                            }
                                            break;
                                    }
                                }
                                break;

                            case "Website":
                                flag50 = true;
                                while (flag50 && xmlReader.Read() && xmlReader.Name != "Header")
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                            
                                            entity2.Website = xmlReader.Value;

                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "Website"|| xmlReader.NodeType== XmlNodeType.EndElement)
                                            {
                                                flag50 = false;
                                                flag32 = false;
                                            }
                                            break;
                                    }
                                }
                                break;

  
                        }

                        break;

                    case XmlNodeType.EndElement:
                        if (xmlReader.Name == "Header")
                        {
                            _header = new Header();
                            _header = entity2;
                            flag32 = false;
                        }
                        break;

                }
            }
            if(_header == null)
            {
                _header = new Header();
                _header = entity2;
            }
            ResetVar();
        }
    }
}
