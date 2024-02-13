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
    internal class CProduct:VarGlobal
    {
        internal static void Conversor(List<Product> _products, XmlReader xmlReader)
        {


            
                flag27 = true;
                Product itemBE = new Product();
                while (flag27 && xmlReader.Read())
                {
                    switch (xmlReader.NodeType)
                    {
                        case XmlNodeType.Element:
                            switch (xmlReader.Name)
                            {
                                case "ProductType":
                                    flag28 = true;
                                    while (flag28 && xmlReader.Read())
                                    {
                                        switch (xmlReader.NodeType)
                                        {
                                            case XmlNodeType.Text:
                                                switch (xmlReader.Value)
                                                {

                                                    case "S":
                                                        itemBE.ProductType = "S";
                                                        break;
                                                    default:
                                                        itemBE.ProductType = "P";
                                                        break;
                                                }
                                                break;
                                            case XmlNodeType.EndElement:
                                                if (xmlReader.Name == "ProductType")
                                                {
                                                    flag28 = false;
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case "ProductCode":
                                    flag29 = true;
                                    while (flag29 && xmlReader.Read())
                                    {
                                        switch (xmlReader.NodeType)
                                        {
                                            case XmlNodeType.Text:
                                                itemBE.ProductCode = xmlReader.Value;
                                                break;
                                            case XmlNodeType.EndElement:
                                                if (xmlReader.Name == "ProductCode")
                                                {
                                                    flag29 = false;
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case "ProductDescription":
                                    flag30 = true;
                                    while (flag30 && xmlReader.Read())
                                    {
                                        switch (xmlReader.NodeType)
                                        {
                                            case XmlNodeType.Text:
                                                itemBE.ProductDescription = xmlReader.Value;
                                                break;
                                            case XmlNodeType.EndElement:
                                                if (xmlReader.Name == "ProductDescription")
                                                {
                                                    flag30 = false;
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case "ProductNumberCode":
                                    flag31 = true;
                                    while (flag31 && xmlReader.Read())
                                    {
                                        switch (xmlReader.NodeType)
                                        {
                                            case XmlNodeType.Text:
                                                {
                                                    string text = xmlReader.Value;
                                                    if (string.IsNullOrEmpty(text))
                                                    {
                                                        break;
                                                    }
                                                    if (text.Length < 13)
                                                    {
                                                        text = text.PadLeft(13, '0');
                                                    }
                                                    try
                                                    {
                                                        //if (BarcodeGenerator.Verify(BarCodeFormat.EAN_13, text))
                                                        //{
                                                        itemBE.ProductNumberCode = text;
                                                        //}
                                                    }
                                                    catch
                                                    {
                                                    }
                                                    break;
                                                }
                                            case XmlNodeType.EndElement:
                                                if (xmlReader.Name == "ProductNumberCode")
                                                {
                                                    flag31 = false;
                                                }
                                                break;
                                        }
                                    }
                                    break;
                            }
                            break;
                        case XmlNodeType.EndElement:
                            if (xmlReader.Name == "Product")
                            {
                                itemBE.index = _products.Count + 1; 
                                _products.Add(itemBE);
                                flag27 = false;
                            }
                            break;
                    }
                }
            ResetVar();

        }

    }
}
