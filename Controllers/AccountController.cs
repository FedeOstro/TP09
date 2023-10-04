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
        Console.WriteLine(nombre, contra);
        Usuario uss = BD.verificarUsuario(nombre, contra);
        if(uss == null){
            ViewBag.Error = "El usuario o la contraseña son incorrectos";
            return View("Login");}
        else
        {
            ViewBag.Usuario = uss;
            return View("Bienvenida");
        }
    }
    public IActionResult Registro()
    {
        return View();
    }

    [HttpPost] public IActionResult CrearUsuario(Usuario uss){
        BD.añadirusuario(uss);
        ViewBag.msj = "El usuario se ha creado correctamente";
        return View("Login");
    }    

    public IActionResult Olvide(){
        
        return View();
    }

    public IActionResult Recuperar(){
 //Poner usuario y actualizar contraseña

        return View();
    }

    public IActionResult Bienvenida()
    {
        return View();
    }
}