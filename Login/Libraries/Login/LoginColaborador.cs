using Login.Libraries.Sessao;
using Login.Models;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
namespace Login.Libraries.Login
{
    public class LoginColaborador
    {
        private string Key = "Login.Colaborador";
        private Sessao.Sessao _sessao;
        public LoginColaborador(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }
        public void Login(Colaborador colaborador)
        {
            string clienteJSONstring = JsonConvert.SerializeObject(colaborador);
            _sessao.Cadastrar(Key, clienteJSONstring);
        }
        public Cliente GetColaborador()
        {
            if (_sessao.Existe(Key))
            {
                string colaboradorJSONstring = _sessao.Consultar(Key);
                return JsonConvert.DeserializeObject<Cliente>(colaboradorJSONstring);
            }
            else
            {
                return null;
            }
        }
    }
}
