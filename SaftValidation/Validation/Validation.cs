using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.OpenSsl;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;
using SaftValidation.Model.SalesInvoice.Invoices;
using System.Drawing;
using SaftValidation.Model.SalesInvoice.Invoices.LineModels;

namespace SaftValidation.Validation
{
    internal partial class Validation:VarGlobal
    {



        internal  Validation(Stream Publickey)
        {
            using (StreamReader reader = new StreamReader(Publickey, Encoding.UTF8))
            {
                string conteudo = reader.ReadToEnd();
                    _publicKey2 = conteudo;
                    _publicKey = GetPublicKeyFromPemFile(conteudo);
            }

        }



        public void ValidationHash()
        {


            foreach (var item in _invoice)
            {
                try
                {
                    if(!VerificarAssinatura(item.Hash))
                    {
                        _message = new Model.Messageresult();
                        _message.index = _messageresults.Count + 1;
                        _message.Message = $"Erro no ficheiro,AuditFile.SourceDocuments.SalesInvoices.{item.index}Invoice ({item.InvoiceNo}) . Hash está errado.";
                        _messageresults.Add(_message);
                    }
          
                }
                catch 
                {
                    _message = new Model.Messageresult();
                    _message.index = _messageresults.Count+1;
                    _message.Message = $"Erro no ficheiro,AuditFile.SourceDocuments.SalesInvoices.{item.index}Invoice ({item.InvoiceNo}) . Hash está errado.";
                    _messageresults.Add(_message);
                }
            

            }
           


        }





        private readonly RSACryptoServiceProvider _privateKey;
        private readonly RsaKeyParameters _publicKey;
        private readonly string _publicKey2;

 
        private bool VerificarAssinatura( string Assinatura)
        {
            bool result=false;
          
                byte[] signature = Convert.FromBase64String(Assinatura);
                ISigner verifier = SignerUtilities.GetSigner("SHA1WithRSA");
                verifier.Init(false, _publicKey);
                verifier.BlockUpdate(signature, 0, signature.Length);
                result = verifier.VerifySignature(signature);
      
            return result;
        }



        public void Validationserie()
        {

            var valoresUnicos = _invoice.Select(x => x.InvoiceNo).Distinct();

            // Verificar se algum valor se repete na lista
            foreach (var valor in valoresUnicos)
            {
                if (_invoice.Count(x => x.InvoiceNo == valor) > 1)
                {
                    _message = new Model.Messageresult();
                    _message.index = _messageresults.Count + 1;
                    _message.Message = $"Erro no ficheiro,InvoiceNo ({valor}). está repetido";
                    _messageresults.Add(_message);
                }
            }

            // Exibir resultados
     
        }


        public void ValidationTotalCreditanddebit()
        {

            try
            {

       

            decimal somaTotalCredit = _invoice.Select(lista => lista.Lines.Select(valor => decimal.Parse(string.IsNullOrWhiteSpace(valor.CreditAmount)?"0":valor.CreditAmount)).Sum()).Sum();

            decimal somaTotalDebit = _invoice.Select(lista => lista.Lines.Select(valor => decimal.Parse(string.IsNullOrWhiteSpace(valor.DebitAmount) ? "0" : valor.DebitAmount)).Sum()).Sum();

                if (decimal.Parse(_salesInvoices.TotalCredit)!= somaTotalCredit)
            {
         
                    _message = new Model.Messageresult();
                    _message.index = _messageresults.Count + 1;
                    _message.Message = $"Erro no ficheiro, AuditFile.SourceDocuments.SalesInvoices.TotalCredit está mal calculado.";
                    _messageresults.Add(_message);
                

            }
            if (decimal.Parse(_salesInvoices.TotalDebit) != somaTotalDebit)
            {

                _message = new Model.Messageresult();
                _message.index = _messageresults.Count + 1;
                _message.Message = $"Erro no ficheiro, AuditFile.SourceDocuments.SalesInvoices.TotalDebit está mal calculado.";
                _messageresults.Add(_message);


            }

            }
            catch (Exception ex)
            {

           
            }

        }


     

        private RsaKeyParameters GetPublicKeyFromPemFile(string puclickey)
        {
            try
            {
                using (TextReader publicKeyTextReader = new StringReader(puclickey))
                {
                    RsaKeyParameters publicKeyParam = (RsaKeyParameters)new PemReader(publicKeyTextReader).ReadObject();

                        if(publicKeyParam == null)
                    {
                        return GetPublicKeyFromPemFile1();
                    }
                    else
                    {
                        return publicKeyParam;
                    }
             
                }
            }
            catch 
            {
                RsaKeyParameters parameters = (RsaKeyParameters)PublicKeyFactory.CreateKey(Convert.FromBase64String(puclickey));

                return parameters;
            }
  
        }


        private RsaKeyParameters GetPublicKeyFromPemFile1() 
    
        {

            RsaKeyParameters parameters = (RsaKeyParameters)PublicKeyFactory.CreateKey(Convert.FromBase64String(_publicKey2));

            return parameters;

        }


    }
}
