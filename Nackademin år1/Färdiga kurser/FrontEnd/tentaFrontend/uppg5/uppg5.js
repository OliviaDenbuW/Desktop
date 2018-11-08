var tal = [8, 3, 4, 7, 2, 3, 1, 6, 9, 11, 10, 13];
var filtreradeTal = [];

function CollectingNumbers(tal)
{
    
    return tal.filter(x => x > 3 && x < 11 && x%2 !== 0);
}

console.log(CollectingNumbers(tal));