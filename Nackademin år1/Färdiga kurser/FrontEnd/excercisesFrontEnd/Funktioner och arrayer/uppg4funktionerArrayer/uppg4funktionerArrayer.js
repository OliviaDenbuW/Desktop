/*
Skapa en funktion som tar emot ett valfritt antal tal och returnerar dessa som en
array sorterad i nummerordning. Filtrera bort tal som är 0 eller mindre
*/
let numbers = [];
let numbersSorted = [];

let nr1 = 0;
let nr2 = 1;

function CollectingRandomNumbers(...inArray)
{
    
    return inArray.filter(x => x > 0).sort(function(a, b) {return a-b});
}

console.log(CollectingRandomNumbers(10,-2,6,0,9,5,7,50,33,118,12,24));