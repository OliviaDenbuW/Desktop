var firstTag = document.getElementById("text1");
alert("Texten i första taggen är: " + firstTag.innerHTML);

var secondTag = document.getElementById("text2");
alert("Texten i andra taggen är: " + secondTag.innerHTML);

secondTag.innerHTML = "Denna text skapas via JS kod";
alert("Texten i andra taggen är nu: " + secondTag.innerHTML);

var thirdTag = document.createElement('p');
var text = document.createTextNode("Denna tag skapades helt med JS kod");
thirdTag.appendChild(text);
document.body.appendChild(thirdTag);

/*
//Skapa en variabel som är ett objekt som pekar på 
//elementet
var firstTag = document.getElementById("text1");

//Tar fram en property som finns på objektet
alert('Texten i första taggen är:' + firstTag.innerHTML );

//Peka på det andra elementet
var secondTag = document.getElementById('text2');

//Via kod ändra en property på elementet
secondTag.innerHTML = "Denna text skapas via JS kod";

//Från grunden skapa ett nytt element med text
var thirdTag = document.createElement('p');
var text = document.createTextNode("Denna tag skapades helt med JS kod");
thirdTag.appendChild(text);

//Lägg till elementet till sidan i bodyn
document.body.appendChild(thirdTag);
*/
