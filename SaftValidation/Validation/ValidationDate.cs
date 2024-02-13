using SaftValidation.Model.SalesInvoice.Invoices.LineModels;
using SaftValidation.Model.SalesInvoice.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaftValidation.Validation
{
    internal partial class Validation : VarGlobal
    {

        public void ValidationFormatDate()
        {
            ValidationFormatDateInvoiceStatusDate();
            ValidationFormatDateInvoiceDate();
            ValidationFormatDateTaxPointDate();
        }


        private void ValidationFormatDateTaxPointDate()
        {

            List<Invoice> errodata = _invoice.Where(invoice => invoice.Lines.Any(taxPointDate => !VerificarFormatoData(taxPointDate.TaxPointDate))).ToList();

            foreach (var item in errodata)
            {
                List<Line> _line = item.Lines.Where(p => !VerificarFormatoData(p.TaxPointDate)).ToList();
                foreach (var line in _line)
                {
                    _message = new Model.Messageresult();
                    _message.index = _messageresults.Count + 1;
                    _message.Message = $"Formato ou tipo errado do campo AuditFile.SourceDocuments.SalesInvoices.{item.index}Invoice.{line.index}Line.TaxPointDate ({item.InvoiceNo})";
                    _messageresults.Add(_message);
                }
            }

        }


        private void ValidationFormatDateInvoiceDate()
        {

            List<Invoice> invoices = _invoice.Where(p => !VerificarFormatoData(p.InvoiceDate)).ToList();

            foreach (var item in invoices)
            {
        
                    _message = new Model.Messageresult();
                    _message.index = _messageresults.Count + 1;
                    _message.Message = $"Formato ou tipo errado do campo AuditFile.SourceDocuments.SalesInvoices.{item.index}Invoice.InvoiceDate ({item.InvoiceNo})";
                    _messageresults.Add(_message);
            }

        }



        private void ValidationFormatDateInvoiceStatusDate()
        {

            List<Invoice> invoices = _invoice.Where(p => !VerificarFormatoDataHora(p.DocumentStatus.InvoiceStatusDate)).ToList();

            foreach (var item in invoices)
            {

                _message = new Model.Messageresult();
                _message.index = _messageresults.Count + 1;
                _message.Message = $"Erro no ficheiro, AuditFile.SourceDocuments.SalesInvoices.{item.index}Invoice.DocumentStatus.InvoiceStatusDate ({item.InvoiceNo}) deve estar compreendida entre SystemEntryDate e DateCreated.";
                _messageresults.Add(_message);
            }



            var valoresLista2 = _products.Select(item => item.ProductCode);

        }



        private bool VerificarFormatoData(string dataString)
        {
            string formatoEsperado = "yyyy-MM-dd";
            return DateTime.TryParseExact(dataString, formatoEsperado, null, System.Globalization.DateTimeStyles.None, out _);
        }

        static bool VerificarFormatoDataHora(string dataHoraString)
        {
            string formatoEsperado = "yyyy-MM-ddTHH:mm:ss";
            return DateTime.TryParseExact(dataHoraString, formatoEsperado, null, System.Globalization.DateTimeStyles.None, out _);
        }
    }
}
