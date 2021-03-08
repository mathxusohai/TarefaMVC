using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMatheus.Controllers
{
    public class ProdutoController : Controller
    {
        public string Index()
        {
         return "Escola SENAI Suiço-Brasileira Paulo Ernesto Tolle";
        }
        public string Welcome(string nome , string sobrenome)
        {
         return HtmlEncoder.Default.Encode($"Ol {nome} {sobrenome} Seja Bem vindo ao nosso Site!!!");
        }
        public string Contato()
        {
            return "Contato: Celular - 11 98227-3609 / Telefone - 11 - 5615-6094 / Email: matheus45784@gmail.com";
        }

    }
}