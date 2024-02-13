using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SaftValidation.Conversor;
using SaftValidation.Model;
using System.IO;
using System.Xml;

namespace SaftAOAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaftUpload : ControllerBase
    {


        [HttpPost("Upload")]
        public async Task<ActionResult> Saftupload(IFormFile Saft, IFormFile Pulickey)
        {

            List<Messageresult> result = new List<Messageresult>();
            Messageresult Message;
            string jon = string.Empty;
            try
            {


                if (Saft == null)
                {
                    Message = new Messageresult();
                    Message.index = 0;
                    Message.Message = "Deve fazer o upload do ficheiro Saft a ser verificado";
                    result.Add(Message);
                }
                if (Pulickey == null)
                {
                    Message = new Messageresult();
                    Message.index =1;
                    Message.Message = "Deve fazer o upload dá Chave Publica a ser verificado";
                    result.Add(Message);
                }
                if (result.Count > 0)
                {
                     jon = JsonConvert.SerializeObject(result);
                    return Ok(jon);
                

                }
                result= SaftConvert.Validetion(Saft.OpenReadStream(), Pulickey.OpenReadStream());
                // Convertendo a lista de pessoas para JSON
                jon = JsonConvert.SerializeObject(result);
                return Ok(result);

            }
            catch (Exception)
            {

               
            }
            return Ok();
        }


    }
}
