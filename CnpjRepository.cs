using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UpperToolsProject
{
    public class CnpjRepository
    {

        private const string dbConnect = "Data Source=FABIO-MATOS\\SQLEXPRESS;Initial Catalog=UpperToolsProject;Trusted_Connection=true;";

        private SqlConnection Conexao()
        {
            SqlConnection conn = new SqlConnection(dbConnect);
            conn.Open();

            return conn;
        }

        public CnpjEntity GetCompany(string cnpj)
        { 

            var conexaoBanco = Conexao();

            string sql = $"SELECT * FROM CnpjResponse WHERE Cnpj = '{cnpj}'";
            conexaoBanco.Close();
            return conexaoBanco.Query<CnpjEntity>(sql).FirstOrDefault();

        }

        public string DeleteCompany(string cnpj)
        {

            var company = GetCompany(cnpj);
            if (company == null)
            {
                return "Os dados do CNPJ não estão inseridos no banco de dados.";
            }

            var conexaoBanco = Conexao();

            string sql = $"DELETE FROM CnpjResponse WHERE Cnpj = '{cnpj}'";

            try
            {
                conexaoBanco.Query<CnpjEntity>(sql);
            }
            catch (Exception ex)
            {
                conexaoBanco.Close();
                return ex.Message;
            }

            conexaoBanco.Close();
            return "Deletado com sucesso";

        }

        public string InsertCompany(CnpjResponse cnpj)
        {
            var company = GetCompany(cnpj.Cnpj);
            if(company != null)
            {
                return "Os dados da empresa já foram inseridos no banco.";
            }
            var conexaoBanco = Conexao();


            string sql = $"INSERT INTO[CnpjResponse]([Cnpj],[Nome],[NomeFantasia],[Tipo],[Uf])VALUES(@Cnpj, @Nome, @Fantasia, @Tipo, @Uf)";

            try
            {
                conexaoBanco.Execute(sql, cnpj);
            }
            catch (Exception ex)
            {
                conexaoBanco.Close();
                return ex.Message;
            }

            conexaoBanco.Close();
            return "Dados do CNPJ salvos com sucesso.";


        }



    }
}
