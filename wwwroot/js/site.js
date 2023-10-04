// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function validarContraseña(){
const regex = /^(?=.*[A-Z])(?=.*[$@$!%*?&-_])([A-Z\d$@$!%*?&-_]){8,16}$/;
let p1;
let p2;
if (p1 != p2) {
    alert("Las contraseñas deben de coincidir");
    return false;
  } else {
    return true; 
  }
}