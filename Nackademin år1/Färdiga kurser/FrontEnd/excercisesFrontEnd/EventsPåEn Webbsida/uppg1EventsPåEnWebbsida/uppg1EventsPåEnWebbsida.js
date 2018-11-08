var button = document.getElementById("showButton");
button.addEventListener("click", function(){
    let lineForFullName = document.createElement("p");
    let text =  "Your name is " + document.getElementById("firstName").value + " " + document.getElementById("lastName").value;
    let textNode = document.createTextNode(text);
    lineForFullName.appendChild(textNode);
    document.getElementById("myDiv").appendChild(lineForFullName);
});

