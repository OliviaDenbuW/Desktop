var namnTag = document.createElement('p');
var namnTxt = document.createTextNode('Namn');
namnTag.appendChild(namnTxt);
document.body.appendChild(namnTag);

var namnInput = document.createElement('input');
document.body.appendChild(namnInput);

var lösenTag = document.createElement('p');
var namnTxt = document.createTextNode('Lösenord');
lösenTag.appendChild(namnTxt);
document.body.appendChild(lösenTag);

var lösenInput = document.createElement('input');
document.body.appendChild(lösenInput);

var loggaInBtn = document.createElement('input');
loggaInBtn.type = "button";
loggaInBtn.value = "Logga in";
document.body.appendChild(loggaInBtn);

