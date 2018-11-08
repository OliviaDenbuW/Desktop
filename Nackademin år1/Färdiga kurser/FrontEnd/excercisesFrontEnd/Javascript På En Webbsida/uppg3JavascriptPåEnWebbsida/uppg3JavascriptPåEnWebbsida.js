var btn = document.getElementById("myButton");
btn.addEventListener("click", function(){
    var newLine = document.createElement("li");
    var node = document.createTextNode("Nu skapar jag en ny rad");
    newLine.appendChild(node);
    document.getElementById("myList").appendChild(newLine);
})
