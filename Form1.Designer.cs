
namespace UpperToolsProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionarDados = new System.Windows.Forms.Button();
            this.btnExibirDados = new System.Windows.Forms.Button();
            this.btnExcluirDados = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(268, 35);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(214, 23);
            this.txtCnpj.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe o CNPJ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAdicionarDados
            // 
            this.btnAdicionarDados.Location = new System.Drawing.Point(31, 85);
            this.btnAdicionarDados.Name = "btnAdicionarDados";
            this.btnAdicionarDados.Size = new System.Drawing.Size(139, 59);
            this.btnAdicionarDados.TabIndex = 3;
            this.btnAdicionarDados.Text = "Adicionar dados do CNPJ";
            this.btnAdicionarDados.UseVisualStyleBackColor = true;
            this.btnAdicionarDados.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExibirDados
            // 
            this.btnExibirDados.Location = new System.Drawing.Point(297, 85);
            this.btnExibirDados.Name = "btnExibirDados";
            this.btnExibirDados.Size = new System.Drawing.Size(156, 59);
            this.btnExibirDados.TabIndex = 4;
            this.btnExibirDados.Text = "Exibir dados do CNPJ";
            this.btnExibirDados.UseVisualStyleBackColor = true;
            this.btnExibirDados.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExcluirDados
            // 
            this.btnExcluirDados.Location = new System.Drawing.Point(546, 85);
            this.btnExcluirDados.Name = "btnExcluirDados";
            this.btnExcluirDados.Size = new System.Drawing.Size(156, 59);
            this.btnExcluirDados.TabIndex = 5;
            this.btnExcluirDados.Text = "Excluir dados do CNPJ";
            this.btnExcluirDados.UseVisualStyleBackColor = true;
            this.btnExcluirDados.Click += new System.EventHandler(this.btnExcluirDados_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 175);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(671, 273);
            this.dataGridView2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnExcluirDados);
            this.Controls.Add(this.btnExibirDados);
            this.Controls.Add(this.btnAdicionarDados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCnpj);
            this.Name = "Form1";
            this.Text = "UpperToolsProject";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAdicionarDados;
        private System.Windows.Forms.Button btnExibirDados;
        private System.Windows.Forms.Button btnExcluirDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

