using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace UI
{
    public class BuscarCep
    {
        private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";

        public static string logradouro;
        public static string bairro;
        public static string cidade;
        public static string uf;

        public static Endereco BuscarEnderecoViaCep(string cep)
        {
            string NovoEnderecoURL = string.Format(EnderecoURL, cep);

            WebClient wc = new WebClient
            {
                Encoding = Encoding.UTF8
            };
            string Conteudo = wc.DownloadString(NovoEnderecoURL);
            
            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo);

            if (end.cep == null) return null;

            return end;
        }
        public static bool BuscarEndereco(string cep)
        {   
            if (IsValidCEP(cep))
            {
                try
                {
                    Endereco end = BuscarEnderecoViaCep(cep);

                    if (end != null)
                    {
                        logradouro = end.logradouro;
                        bairro = end.bairro;
                        cidade = end.localidade;
                        uf = end.uf;
                        return true;
                    }
                    else
                    { 
                        MessageBox.Show("Endereço não encontrado!", "Buscar CEP");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Procurar CEP");
                    return false;
                }
            }
            return false;
        }

        private static bool IsValidCEP(string cep)
        {
            bool valido = true;

            if (cep.Length != 8)
            {
                MessageBox.Show("O CEP deve conter 8 caracteres", "Procurar CEP");
                valido = false;
            }
            if (!int.TryParse(cep, out int NovoCep))
            {
                MessageBox.Show("O CEP deve conter apenas números", "Procurar CEP");
                valido = false;
            }

            return valido;
        }
        
    }   
}
