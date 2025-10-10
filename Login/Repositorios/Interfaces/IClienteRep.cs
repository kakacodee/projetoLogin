using Login.Models;
namespace Login.Repositorios.Interfaces
{
    public interface IClienteRep
    {
        ClienteRep Login(string Email,  string Senha);

        void Cadastrar(Cliente cliente);
        void Atualizar(Cliente cliente);
        void Ativar(int Id);
        void Desativar(int Id);
        void Excluir(int Id);

        Cliente ObterCliente(int Id);
        Cliente BuscaCPFCliente(string CPF);
        Cliente BuscaEmailCliente(string Email);

        IEnumerable<Cliente> ObterTodosClientes();

    }
}
