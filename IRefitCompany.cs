using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UpperToolsProject
{
    interface IRefitCompany
    {

        [Get("/v1/cnpj/{cnpj}")]
        public Task<CnpjResponse> GetCompany(string cnpj);

    }
}
