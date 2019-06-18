function passageDeLaSouris(element) {
    if (document.getElementById(element).src.substr(-6, 2) == '_2') {
        document.getElementById(element).src = 'Content/Image/' + element + '.jpg';
    } else {
        document.getElementById(element).src = 'Content/Image/' + element + '_2.jpg';
    }
}  