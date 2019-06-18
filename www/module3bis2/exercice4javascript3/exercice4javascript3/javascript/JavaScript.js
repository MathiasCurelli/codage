function checkPassword() {
    if (document.getElementById("password").value == document.getElementById("confirmPassword").value) {
        document.getElementById("password").style.border = "solid green 2px";
        document.getElementById("confirmPassword").style.border = "solid green 2px";
    } else {       
       document.getElementById("password").style.border = "solid red 2px";
       document.getElementById("confirmPassword").style.border = "solid red 2px";
    }
}