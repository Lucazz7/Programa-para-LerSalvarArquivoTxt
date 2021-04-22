using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LerSalvarArquivoTxt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Arquivo de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            saveFileDialog1.Title = "Salvar um Arquivo Texto";
            saveFileDialog1.ShowDialog();

            if(saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

                byte[] bytes = Encoding.ASCII.GetBytes(richTextBoxSalvar.Text);
                int Nbytes = Encoding.ASCII.GetCharCount(bytes);
                fs.Write(bytes, 0, Nbytes);
                //Escrever o endereco do arquivo
                textBoxEndereco.Text = saveFileDialog1.FileName;
                fs.Close();
            }
        }

        private void bt_ler_Click(object sender, EventArgs e)
        {
            byte[] arqbin = new byte[1024];
            string arqtxt;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
           

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var sr = new StreamReader(openFileDialog1.FileName);
                openFileDialog1.Filter = "Arquivo de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
                openFileDialog1.Title = "Abrir arquivo";
                arqtxt = sr.ReadToEnd();
                sr.Close();

                // Ler arquivos no text box
                richTextBoxLer.Text = arqtxt;
                // Ler o endereço do arquvio
                textBoxEnderecoler.Text = openFileDialog1.FileName;
            }
        }
    }
}
