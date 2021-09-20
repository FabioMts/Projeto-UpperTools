using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using UpperToolsProject;

namespace UpperToolsProject
{
    public class CnpjResponse
    {
        [JsonProperty("cnpj")]
        public string Cnpj  { get; set; }
        
        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("fantasia")]
        public string Fantasia { get; set; }

        [JsonProperty("tipo")]
        public string Tipo { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }


    }
}
