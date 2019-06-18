
function determinTypeOfYear() {
    var yearOfBirthday = document.getElementById("yearOfBirth").value;
    if (yearOfBirthday % 4 == 0 && yearOfBirthday % 100 != 0 || yearOfBirthday % 400 == 0) {
        alert("C'est bissextile")
    }
        // tu dis que c'est bissextile
   
    else if (isNaN(yearOfBirthday)) {
            alert("Erreur de saisie");
        }
     else {
        alert("C'est non bissextile")
        // c'est pas bissextile
    }

}