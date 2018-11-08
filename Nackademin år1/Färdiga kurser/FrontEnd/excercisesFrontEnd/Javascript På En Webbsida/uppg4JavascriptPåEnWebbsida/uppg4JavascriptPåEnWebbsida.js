var button = document.getElementById("myButton");
button.addEventListener("click", AddToDoToList);

function AddToDoToList(){
    var newLine = document.createElement("dd");
    var text = document.getElementById("inputText").value + " ";
    var node = document.createTextNode(text);
    newLine.appendChild(node);

    //Skapar knapp "klar" till varje toDo-item som kommer upp på listan
    let newButton = document.createElement("button");
    let textNode = document.createTextNode("Klar");
    newButton.appendChild(textNode);
    newLine.appendChild(newButton);
    document.getElementById("myToDoList").appendChild(newLine);

    //SKapa event
    newButton.addEventListener("click", AddToDoneList)

    function AddToDoneList(){
        let clickedButton = event.target;
        let parent = clickedButton.parentNode;
        //tar bort knappen innan den flyttas
        parent.removeChild(clickedButton);
        //Flyttar till andra listan
        document.getElementById("doneList").appendChild(newLine);
    }
};