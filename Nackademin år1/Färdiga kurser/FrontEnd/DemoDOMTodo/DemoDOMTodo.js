//Lägger till ett click event för att lägga till nytt todoItem
var addBtn = document.getElementById("addButton");
addBtn.addEventListener("click", AddToDo);


//En metod som lägger till ett nytt element på sidan. 
//Anropas från knappen 
function AddToDo()
{      
    //Skapar listrad element och sätter texten från textboxen
    let newElement = document.createElement("dd");
    let text = document.getElementById("newItem").value + " ";
    let textNode = document.createTextNode(text);
    newElement.appendChild(textNode);

    //Skapar en knapp och lägger till text på knappen
    let newButton = document.createElement("button");
    textNode = document.createTextNode("Klar");
    newButton.appendChild(textNode);

    //Skapar ett klick event på knappen som körs när raden skall
    //markeras som klar
    newButton.addEventListener("click", function() {
        
        let clickedButton = event.target;        
        let parent = clickedButton.parentNode;
        //Tar bort innan den flyttas över
        parent.removeChild(clickedButton)
        //Flyttar till done listan
        document.getElementById("doneList").appendChild(parent);
    })

    //Kopplar knappen till listraden
    newElement.appendChild(newButton);
    
    //Kopplar listraden till listan
    document.getElementById("toDoList").appendChild(newElement);
}
