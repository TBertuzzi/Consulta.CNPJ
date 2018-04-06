using System;
using System.Net.Http;
using System.Threading.Tasks;
using Consulta.CNPJ.Helpers;
using Consulta.CNPJ.Models;
using Newtonsoft.Json;

namespace Consulta.CNPJ.Services
{
    public class CNPJService : ICNPJService
    {
        private readonly HttpClient _httpClient;

        public CNPJService()
        {
            _httpClient = new HttpClient();
        }

        public CNPJResult ConsultarCPNJ(string cnpj)
        {
           return ConsultarCPNJAsync(cnpj).Result;
        }

        public async Task<CNPJResult> ConsultarCPNJAsync(string cnpj)
        {
            if (string.IsNullOrEmpty(cnpj) || !Validacao.ValidaCNPJ(cnpj))
                throw new ArgumentException("CNPJ Invalido.");

            try
            {
                using (HttpResponseMessage response = await _httpClient.GetAsync(string.Format(Constantes.CNPJAPI, cnpj)))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();

                        return JsonConvert.DeserializeObject<CNPJResult>(result);
                    }

                    return null;
                }
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
            }

            return null;



           
        }
    }
}
