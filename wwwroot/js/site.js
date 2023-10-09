function validarContraseña(contra, contra2){
const regex = /^(?=.*[A-Z])(?=.*[$@$!%*?&-_])[A-Za-z\d$@$!%*?&-_]{8,}$/;
if(regex.test(contra) && contra === contra2){

}else if(!regex.test(contra)){
    alert("La contraseña no cumple con los requisitos")
}else{
    alert("Las contraseñas no coinciden")
}

}
