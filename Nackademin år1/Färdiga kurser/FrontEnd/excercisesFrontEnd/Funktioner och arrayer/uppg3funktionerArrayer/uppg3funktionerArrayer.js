/*
Skapa en array som du fyller med 25 slumpmässigt valda tal. Ta sedan via ett filter
fram alla tal som är större än 5
*/

var randomNumbers = [];

for(let i = 0; i < 25; i++){
    let randomNr = Math.floor(Math.random() * 25);
    randomNumbers.push(randomNr);
    let x = i++;
    console.log('Nr' + x + ': ' + randomNr);
}

let numberBiggerThanFive = randomNumbers.filter(function(number){
    return number > 5;
});

console.log(numberBiggerThanFive);
