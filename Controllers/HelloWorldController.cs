using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace BSIStore.Controllers
{
    public class HelloWorldController : Controller
    {
        //  /HelloWorld

        public string index()
        {
             return "Essa é uma ação principal...";
        }
    // /HelloWorld/Welcome
    /*public string Welcome()
    {
        return "Ação do método Welcome";
    }*/
    public string Welcome(string nome, int ID=1)
    {
        return HtmlEncoder.Default.Encode($"Nome: {nome}, ID: {ID}");

    }
}

}