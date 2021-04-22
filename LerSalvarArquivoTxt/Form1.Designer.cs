
namespace LerSalvarArquivoTxt
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_ler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxSalvar = new System.Windows.Forms.RichTextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.richTextBoxLer = new System.Windows.Forms.RichTextBox();
            this.textBoxEnderecoler = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(52, 292);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(152, 36);
            this.bt_salvar.TabIndex = 0;
            this.bt_salvar.Text = "Salvar arquivo";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_ler
            // 
            this.bt_ler.Location = new System.Drawing.Point(298, 334);
            this.bt_ler.Name = "bt_ler";
            this.bt_ler.Size = new System.Drawing.Size(141, 29);
            this.bt_ler.TabIndex = 1;
            this.bt_ler.Text = "Ler Arquivo";
            this.bt_ler.UseVisualStyleBackColor = true;
            this.bt_ler.Click += new System.EventHandler(this.bt_ler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite texto na area abaixo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ler e mostrar arquivo";
            // 
            // richTextBoxSalvar
            // 
            this.richTextBoxSalvar.Location = new System.Drawing.Point(41, 44);
            this.richTextBoxSalvar.Name = "richTextBoxSalvar";
            this.richTextBoxSalvar.Size = new System.Drawing.Size(179, 242);
            this.richTextBoxSalvar.TabIndex = 4;
            this.richTextBoxSalvar.Text = "";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(12, 343);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.ReadOnly = true;
            this.textBoxEndereco.Size = new System.Drawing.Size(219, 20);
            this.textBoxEndereco.TabIndex = 5;
            // 
            // richTextBoxLer
            // 
            this.richTextBoxLer.Location = new System.Drawing.Point(281, 70);
            this.richTextBoxLer.Name = "richTextBoxLer";
            this.richTextBoxLer.ReadOnly = true;
            this.richTextBoxLer.Size = new System.Drawing.Size(183, 258);
            this.richTextBoxLer.TabIndex = 6;
            this.richTextBoxLer.Text = "";
            // 
            // textBoxEnderecoler
            // 
            this.textBoxEnderecoler.Location = new System.Drawing.Point(257, 44);
            this.textBoxEnderecoler.Name = "textBoxEnderecoler";
            this.textBoxEnderecoler.ReadOnly = true;
            this.textBoxEnderecoler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxEnderecoler.Size = new System.Drawing.Size(223, 20);
            this.textBoxEnderecoler.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 385);
            this.Controls.Add(this.textBoxEnderecoler);
            this.Controls.Add(this.richTextBoxLer);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.richTextBoxSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_ler);
            this.Controls.Add(this.bt_salvar);
            this.Name = "Form1";
            this.Text = "Ler e Salvar Arquivo Texto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_ler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxSalvar;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.RichTextBox richTextBoxLer;
        private System.Windows.Forms.TextBox textBoxEnderecoler;
    }
}

