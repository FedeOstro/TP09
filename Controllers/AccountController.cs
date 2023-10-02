using Microsoft.AspNetCore.Mvc;

namespace TP09.Controllers;

public class AccountController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult VerificarUsuario(string nombre, string contra){
        Usuario uss = BD.verificarUsuario(nombre, contra);
        if(nombre == null || contra == null){
//Mostrar ViewBag Error
        return RedirectToAction("Login");
        }
        else{
            if(uss == null){
//Mostrar ViewBag Error
return RedirectToAction("Login");
            }else{
ViewBag.User = BD.verificarUsuario(nombre, contra);
return RedirectToAction("Bienvenida");
            }
            }
            }
    public IActionResult Registro()
    {
        return View();
    }

    public IActionResult CrearUsuario(Usuario uss){
        BD.añadirusuario(uss);
        ViewBag.msj = "El usuario se ha creado correctamente";
        /*Añadir if(ViewBag.msj != null){
        Mostrar mensaje en Login
        }*/
        return View("Login");
    }    

    public IActionResult Olvide(){
        
        return View();
    }

    public IActionResult Recuperar(){

return View();
    }

    public IActionResult Bienvenida()
    {

    return View();
    }
}