//Sätt två events på knappen
var clickButton = document.getElementById("clickBtn");
clickButton.addEventListener("mouseenter", ChangeStyle);
clickButton.addEventListener("mouseleave", ChangeStyle);

var myLabel = document.getElementById("buttonFont");

function ChangeStyle()
{
   if(clickButton.className =="markGrey")
    {
        //Ändrar cssklassen för knappen
        clickButton.className="markBlue"

        //För att kodmässigt ta fram en style property
        var style = window.getComputedStyle(clickButton);
        var pixlar = style.getPropertyValue('font-size');
       
        myLabel.innerHTML= "Fonten har: " + pixlar ;
    }
    else
    {
         //Ändrar tillbaka cssklassen för knappen
        clickButton.className="markGrey"
        myLabel.innerHTML="";
    }

}

