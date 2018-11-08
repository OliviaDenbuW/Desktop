/*
Skriv en funktion som tar in två nummer och returnerar det största. Observera att
båda argumenten som skickas till funktionen kan vara samma nummer. Testa att
anropa den och skriv ut resultatet via console.log
*/
let nr1 = 2;
let nr2 = 9;

let nr3 = Math.floor(Math.random() * 50);
let nr4 = Math.floor(Math.random() * 50);

function biggestNumber(nr1, nr2) {
    let max = Math.max(nr1, nr2);
    return max;
};

console.log('Max nr is: ' + biggestNumber(nr3, nr4));