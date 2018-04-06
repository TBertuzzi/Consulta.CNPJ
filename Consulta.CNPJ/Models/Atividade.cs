using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consulta.CNPJ.Models
{
    public class Atividade
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }
}
