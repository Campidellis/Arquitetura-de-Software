using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace BSIStore.Controllers
{
    public class HelloWorldController : Controller
    {
        //  /HelloWorld

       /* public string index()
        {
             return "Essa é uma ação principal...";
        }*/
         public IActionResult index()
        {
             return View();
        }
    // /HelloWorld/Welcome
    /*public string Welcome()
    {
        return "Ação do método Welcome";
    }*/
    public IActionResult Welcome(string nome, int ID=1)
    {
       ViewData["Mensagem"] = "Ola "+nome;
       ViewData["ID"] = ID;

       return View();
    }
}

}