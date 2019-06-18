//Affecte la nouvelle image lorsque la souris survole l'élément
function passageDeLaSouris(element) {
    element.setAttribute('src', 'https://gitlab.ecole-e2n.fr/La-Manu/dot-net/raw/9390cf413f10268b0943a8daddc6308204691de5/partie-2-html-css/javascript/js-2/Exercice_1/images/image1_2.jpg');
};
//Affecte l'image de départ lorsque la souris ne survole plus l'élément
function departDeLaSouris(element) {
    element.setAttribute('src', 'https://gitlab.ecole-e2n.fr/La-Manu/dot-net/raw/9390cf413f10268b0943a8daddc6308204691de5/partie-2-html-css/javascript/js-2/Exercice_1/images/image1.jpg');
};

