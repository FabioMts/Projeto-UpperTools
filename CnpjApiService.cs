using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UpperToolsProject;

namespace UpperToolsProject
{
    public class CnpjApiService
    {

        CnpjRepository repository = new CnpjRepository();

        
        public async Task<string> GetApiResponse(string cnpj)
        {
            var api = RestService.For<IRefitCompany>("https://www.receitaws.com.br");
            var cnpjResponse = await api.GetCompany(cnpj);

            if(cnpjResponse.Cnpj == null)
            {
                return "Não foi possivel encontrar dados da empresa."; 
            }
            cnpjResponse.Cnpj = IsCnpj(cnpjResponse.Cnpj);
            return repository.InsertCompany(cnpjResponse);
            
        }

        public CnpjEntity GetCompany(string cnpj)
        {
            
            return repository.GetCompany(cnpj);

        }

        public string DeleteCompany(string cnpj)
        {
            return repository.DeleteCompany(cnpj);
        }

        public string IsCnpj(string cnpj)
        {

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
           
                return cnpj;
        }

	}

}
