//Skapar själva eventet och kopplingen direkt i JS
//Det rekommenderade sättet eftersom man separarerar HTML och JS mer
var myButton = document.getElementById("emptyGlass");
myButton.addEventListener("click",ShowEmpty );

//Tar in image elementet i ett objekt 
var myImage = document.getElementById("myGlass");

//Ändrar propertyn src på image objektet
function ShowEmpty()
{
    myImage.src ="Empty.jpg";
}

function ShowFull()
{
    myImage.src ="Full.jpg";
}

