/*
Skapa en anonym funktion som tar emot två tal och multiplicerar dessa och
returnerar resultatet
*/

let nr1 = Math.floor(Math.random()*10);
let nr2 = Math.floor(Math.random()*10);

var functionReturnProduct = function(nr1, nr2){
    return nr1 * nr2;
};

var product = functionReturnProduct(nr1, nr2);

console.log('The product is: ' + product);
console.log(nr1);
console.log(nr2);