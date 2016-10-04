using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.NetMvc5ConceitosBasicos.Controllers
{
    //[RoutePrefix("novasrotas")]
    [RoutePrefix("geral")]
    public class NovasRotasController : Controller
    {
        // GET: NovasRotas
        //[Route("novasrotas/index/{nascimento:datetime}")]
        // linha acima comentada por causa do RoutePrefix
        [Route("index/{nascimento:datetime}")]
        public string Index(DateTime nascimento)
        {
            return string.Format("Data de nascimento: {0:dd/MM/yyyy}", nascimento);
        }

        //[Route("novasrotas/getdados/{nome}/{idade}")]
        // renomear o método:
        [Route("info/{nome}/{idade}")]
        public string GetDados(string nome, int idade = 20)
        {
            return HttpUtility.HtmlEncode(
                string.Format("Bem vindo {0}, com idade {1}", nome, idade));
        }

        //[Route("novasrotas/getpreco/{preco}")]
        // renomear o método e atribuir um valor mínimo:
        [Route("cotacao/{preco:int:min(20)}")]
        public string GetPreco(int preco)
        {
            return "O preço do produto é " + preco;
        }

        //[Route("novasrotas/getcliente/{id}")]
        // renomear o método e atribuir um valor mínimo e máximo:
        [Route("cliente/{id:int:min(5):max(99)}")]
        public string GetCliente(int id)
        {
            return "Código do cliente: " + id;
        }
    }
}