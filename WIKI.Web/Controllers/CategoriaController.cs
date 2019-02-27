using Microsoft.AspNetCore.Mvc;

namespace WIKI.Web.Controllers
{
    public class CategoriaController: Controller
    {
        public IActionResult Index(){
            return View();
        }
        
    }

}