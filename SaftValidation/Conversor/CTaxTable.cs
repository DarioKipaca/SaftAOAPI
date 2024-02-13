using SaftValidation.Model;
using SaftValidation.Model.MasterFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SaftValidation.Conversor
{
    internal class CTaxTable:VarGlobal
    {
        internal static void Conversor(List<TaxTableEntry> _taxTableEntry, XmlReader xmlReader)
        {

            
            bool flag = true;
            TaxTableEntry entity = new TaxTableEntry();

            while (flag && xmlReader.Read())
            {
                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.Element:
                        switch (xmlReader.Name)
                        {
                            case "TaxType":
                                flag2 = true;
                                while (flag2 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.TaxType = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "TaxType")
                                            {
                                                flag2 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "TaxCountryRegion":
                                flag3 = true;
                                while (flag3 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.TaxCountryRegion = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "TaxCountryRegion")
                                            {
                                                flag3 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "TaxCode":
                                flag4 = true;
                                while (flag4 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.TaxCode = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "TaxCode")
                                            {
                                                flag4 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                       
                            case "Description":
                                flag10 = true;
                                while (flag10 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.Description = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "Description")
                                            {
                                                flag10 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "TaxPercentage":
                                flag11 = true;
                                while (flag11 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.TaxPercentage = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "TaxPercentage")
                                            {
                                                flag11 = false;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "TaxAmount":
                                flag12 = true;
                                while (flag12 && xmlReader.Read())
                                {
                                    switch (xmlReader.NodeType)
                                    {
                                        case XmlNodeType.Text:
                                            entity.TaxAmount = xmlReader.Value;
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (xmlReader.Name == "TaxAmount")
                                            {
                                                flag12 = false;
                                            }
                                            break;
                                    }
                                }
                                break;

                        }
                        break;
                    case XmlNodeType.EndElement:
                        if (xmlReader.Name == "TaxTableEntry")
                        {
                            entity.index = _taxTableEntry.Count + 1;
                            _taxTableEntry.Add(entity);
                            flag = false;
                        }
                        break;
                }
            }


            ResetVar();

        }

     }
}
