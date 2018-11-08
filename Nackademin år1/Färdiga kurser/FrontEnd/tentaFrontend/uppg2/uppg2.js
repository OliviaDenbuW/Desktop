var btnFlytta = document.getElementById("move");
btnFlytta.addEventListener("click", function(){

        let nyttElement1 = document.createElement("dd");
        let text1 = document.getElementById("txtLastName").value;
        let text2 = document.getElementById("txtFirstName").value;

        let textNode1 = document.createTextNode(text1);
        let textNode2 = document.createTextNode(text2);

        let textNode12 = textNode1 + " " + textNode2;
        nyttElement1.appendChild(textNode12);

        document.getElementById("sammanfattning").appendChild(nyttElement12);

        let nyttElement3 = document.createElement("dd");
        let text3 = document.getElementById("txtAdress").value;
        let textNode3 = document.createTextNode(text3);
        nyttElement3.appendChild(textNode3);
    
        document.getElementById("sammanfattning").appendChild(nyttElement3);

        
        let nyttElement4 = document.createElement("dd");
        let text4 = document.getElementById("txtPostNr").value;
        let textNode4 = document.createTextNode(text4);
        nyttElement3.appendChild(textNode3);
        document.getElementById("sammanfattning").appendChild(nyttElement4);
})