using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Dapper;

namespace UpperToolsProject 
{
    public partial class Form1 : Form
    {

        CnpjApiService service = new CnpjApiService();



        public Form1()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            DeleteRow();
            var cnpj = service.IsCnpj(txtCnpj.Text);
            if (string.IsNullOrWhiteSpace(txtCnpj.Text) || cnpj.Length <14 )
            {

                MessageBox.Show("Insira um CNPJ válido");
            }
            else
            {
                MessageBox.Show(await service.GetApiResponse(cnpj));
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteRow();
            var cnpj = service.IsCnpj(txtCnpj.Text);
            if (string.IsNullOrWhiteSpace(txtCnpj.Text) || cnpj.Length < 14)
            {

                MessageBox.Show("Insira um CNPJ válido");
            }else
            {
                var company = service.GetCompany(cnpj);
                List<CnpjEntity> companyList = new List<CnpjEntity>();
                companyList.Add(company);
                
                dataGridView2.DataSource = companyList;
                dataGridView2.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;

            }
        }

        private void btnExcluirDados_Click(object sender, EventArgs e)
        {
            DeleteRow();
            var cnpj = service.IsCnpj(txtCnpj.Text);
            if (string.IsNullOrWhiteSpace(txtCnpj.Text) || cnpj.Length < 14)
            {

                MessageBox.Show("Insira um CNPJ válido");
            }
            else
            {
                MessageBox.Show(service.DeleteCompany(cnpj));
            }
        }

        public void DeleteRow()
        {

            if(dataGridView2.Rows.Count > 0)
            {
                dataGridView2.DataSource = null;

            }

        }


    }
}
