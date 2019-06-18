var shoeSize = parseFloat(prompt("Veuiller indiquer votre pointure svp"));
var yearBirth = parseFloat(prompt("Renseigner votre année de naissance"));
var result;

function calcul() {
    result = shoeSize * 2;
    console.log(result);
    result += 5;
    console.log(result);
    result *= 50;
    console.log(result);
    result -= 1993;
    console.log(result);
    result += 1769;
    console.log(result);
    return result;
}
alert(calcul());


