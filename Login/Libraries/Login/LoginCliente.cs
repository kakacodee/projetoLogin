using Login.Libraries.Sessao;
using Login.Models;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
namespace Login.Libraries.Login
{
    public class LoginCliente
    {
        private string Key = "Login.Cliente";
        private Sessao.Sessao _sessao;
        public LoginCliente(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }
        public void Login(Cliente cliente)
        {
            string clienteJSONstring = JsonConvert.SerializeObject(cliente);
            _sessao.Cadastrar(Key, clienteJSONstring);
        }
    }
}
