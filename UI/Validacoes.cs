using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace UI
{
    public static class Validacoes
    {
        public static bool validarEmail(string email)
        {
            Regex regExpEmail = new Regex("^[A-Za-z0-9](([_.-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([.-]?[a-zA-Z0-9]+)*)([.][A-Za-z]{2,4})$");
            Match match = regExpEmail.Match(email);

            if (match.Success)
            {
                return true;
            }

            else
            {
                MessageBox.Show("O E-mail informado não é válido, favor verificar!", "E-mail");
                return false;
            }
        }

        public static bool validarUndMedida(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("O campo unidade de medida não pode ficar em branco, favor verificar!", "Unidade de Medida");
                return false;
            }
            else return true;
        }

        public static bool verificarUsoUnidadeMedida(unidade_medida unidade_Medida)
        {
            var produto = DataContextFactory.atendimentosDataContext.produto.Where(x => x.unidade_medida == unidade_Medida.codigo);

            if (produto.Count() > 0)
                return true;

            else return false;
        }

        public static bool existeUnidadeMedida(string nome)
        {
            var existe = DataContextFactory.atendimentosDataContext.unidade_medida.Where(x => x.nome == nome);

            if (existe.Count() > 0)
            {
                MessageBox.Show("A unidade de medida: " + nome + " já está cadastrada, favor verificar!", "Unidade de Medida");

                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool validarGrupoProduto(string nome)
        {
            if (nome.Length < 3)
            {
                MessageBox.Show("O campo grupo produto não pode ficar em branco, favor verificar!", "Grupo de Produtos");
                return false;
            }
            else return true;
        }

        public static bool verificarUsoGrupoProduto(grupo_produto grupo_Produto)
        {
            var produto = DataContextFactory.atendimentosDataContext.produto.Where(x => x.grupo_produto == grupo_Produto.codigo);

            if (produto.Count() > 0)
                return true;

            else return false;
        }

        public static bool existeGrupoProduto(string nome)
        {
            var existe = DataContextFactory.atendimentosDataContext.grupo_produto.Where(x => x.nome == nome);

            if (existe.Count() > 0)
            {
                MessageBox.Show("O grupo de produto: " + nome + " já está cadastrado, favor verificar!", "Grupo de Produtos");

                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool validarGrupoProcedimento(string nome)
        {
            if (nome.Length < 3)
            {
                MessageBox.Show("O campo grupo procedimento não pode ficar em branco, favor verificar!", "Grupo de Procedimentos");
                return false;
            }
            else return true;
        }

        public static bool verificarUsoGrupoProcedimento(grupo_procedimento grupo_Procedimento)
        {
            var procedimento = DataContextFactory.atendimentosDataContext.produto.Where(x => x.grupo_produto == grupo_Procedimento.codigo);

            if (procedimento.Count() > 0)
                return true;

            else return false;
        }

        public static bool existeGrupoProcedimento(string nome)
        {
            var existe = DataContextFactory.atendimentosDataContext.grupo_procedimento.Where(x => x.nome == nome);

            if (existe.Count() > 0)
            {
                MessageBox.Show("O grupo de procedimentos: " + nome + " já está cadastrado, favor verificar!", "Grupo de Procedimentos");

                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool validarGrupoCurso(string nome)
        {
            if (nome.Length < 3)
            {
                MessageBox.Show("O campo grupo cursos não pode ficar em branco, favor verificar!", "Grupo de Cursos");
                return false;
            }
            else return true;
        }

        public static bool verificarUsoGrupoCurso(grupo_curso grupo_Curso)
        {
            var curso = DataContextFactory.atendimentosDataContext.curso.Where(x => x.grupo_curso == grupo_Curso.codigo);

            if (curso.Count() > 0)
                return true;

            else return false;
        }

        public static bool existeGrupoCurso(string nome)
        {
            var existe = DataContextFactory.atendimentosDataContext.grupo_curso.Where(x => x.nome == nome);

            if (existe.Count() > 0)
            {
                MessageBox.Show("O grupo de cursos: " + nome + " já está cadastrado, favor verificar!", "Grupo de Cursos");

                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool validarCliente(string nome)
        {
            if (nome.Length < 3)
            {
                MessageBox.Show("O campo nome está em branco ou contém menos de 3 caracteres, favor verificar!", "Clientes");
                return false;
            }
            else return true;
        }

        public static bool existeCliente(string nome, string cpfCnpj)
        {
            var existe = DataContextFactory.atendimentosDataContext.cliente.Where(x => x.nome == nome && x.cpf_cnpj == cpfCnpj);

            if (existe.Count() > 0)
            {
                MessageBox.Show("O cliente: " + nome + ", CPF/CNPJ: " + cpfCnpj +" já está cadastrado, favor verificar!", "Clientes");

                return true;
            }
            else
            {
                return false;
            }
        }

        /*public static bool verificarUsoCliente(int id)
        {
            var usado = DataContextFactory.atendimentosDataContext.produto.Where(x => x.fornecedor == id);
            if (usado.Count() > 0)
                return true;

            else
                return false;
        }*/

        public static bool validarFornecedor(string nome)
        {
            if (nome.Length < 3)
            {
                MessageBox.Show("O campo nome está em branco ou contém menos de 3 caracteres, favor verificar!", "Fornecedores");
                return false;
            }
            else return true;
        }

        public static bool existeFornecedor(string nome, string cnpjCpf)
        {
            var existe = DataContextFactory.atendimentosDataContext.fornecedor.Where(x => x.razao_social == nome && x.cnpj_cpf == cnpjCpf);

            if (existe.Count() > 0)
            {
                MessageBox.Show("O fornecedor: " + nome + ", CPF/CNPJ: " + cnpjCpf + " já está cadastrado, favor verificar!", "Fornecedores");

                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool verificarUsoFornecedor(int id)
        {
            var usado = DataContextFactory.atendimentosDataContext.produto.Where(x => x.fornecedor == id);
            if (usado.Count() > 0)
                return true;

            else
                return false;
        }

        public static bool validarProduto(string nome, string valor, string margem)
        {
            if (nome.Length < 3)
            {
                MessageBox.Show("O campo nome está em branco ou contém menos de 3 caracteres, favor verificar!", "Produtos");
                return false;
            }
          
            if (string.IsNullOrEmpty(valor))
            {
                MessageBox.Show("O campo valor de compra está em branco, favor verificar!", "Produtos");
                return false;
            }

            if (string.IsNullOrEmpty(margem))
            {
                MessageBox.Show("O campo margem de lucro está em branco, favor verificar!", "Produtos");
                return false;
            }

            return true;
        }

        public static bool validarCurso(string nome)
        {
            if (nome.Length < 3)
            {
                MessageBox.Show("O campo nome está em branco ou contém menos de 3 caracteres, favor verificar!", "Cursos");
                return false;
            }

            return true;
        }

        public static bool existeCurso(string nome)
        {
            var existe = DataContextFactory.atendimentosDataContext.curso.Where(x => x.nome == nome);

            if (existe.Count() > 0)
            {
                MessageBox.Show("O curso: " + nome + " já está cadastrado, favor verificar!", "Cursos");

                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool validarProcedimento(string nome)
        {
            if (nome.Length < 3)
            {
                MessageBox.Show("O campo nome está em branco ou contém menos de 3 caracteres, favor verificar!", "Procedimento");
                return false;
            }

            return true;
        }
    }
}
