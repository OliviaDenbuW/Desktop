var pListArray = document.getElementsByTagName('p');

var firstText = pListArray[0].innerHTML;
var secondText = pListArray[1].innerHTML;
var thirdText = pListArray[2].innerHTML;

var forthTag = document.getElementById("allText");

forthTag.innerHTML = "1. " + firstText + " 2. " + secondText + " 3. " + thirdText; //property innerHTML för att samla ihop all text

var newElement = document.createElement("h1");
var text = document.createTextNode("Detta element skapades via javascript kod");
newElement.appendChild(text);

document.body.appendChild(newElement);
