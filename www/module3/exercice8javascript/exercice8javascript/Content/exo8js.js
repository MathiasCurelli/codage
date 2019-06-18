function ageUser() {

    var age = document.getElementById("age").value;
    

    if (age >= 18 && age <= 100) {
        alert("Vous êtes majeur.");
    }
    else if (age < 18) {
        alert("Vous êtes mineur.");
    }
    else {
        alert("Erreur, veuillez saisir un nombre entre 1 et 100");
    }
}