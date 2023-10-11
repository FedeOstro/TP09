function validarContraseña(event, contra, contra2){  
    const regex = /^(?=.*[A-Z])(?=.*[$@$!%*?&-_])[A-Za-z\d$@$!%*?&-_]{8,}$/;
    if(regex.test(contra) && contra === contra2){
        return true;
    }
    else 
    if(!regex.test(contra)){
        alert("La contraseña no cumple con los requisitos");
        return false;
    }else{
        alert("Las contraseñas no coinciden");
        return false;
    }

}
