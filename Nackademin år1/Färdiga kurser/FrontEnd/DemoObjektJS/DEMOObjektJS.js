//---- Första sättet att skapa upp ett objekt med properties 
//---- utan att ha en klass, kallas för object literal
var person1 = {name: "kalle" , email: "kalle@nackademin.se"};

//---- Andra sättet via JSON data skapa upp objekt. Ett format 
//---- som tagits fram för att enkelt kunna omvandlas till JS-objekt
//---- JSON står för javascript object notation 
var myJSON = {"name" : "kalle" , "email": "kalle@nackademin.se"};
var person2 = myJSON;

//---- Tredje sättet är att använda en klass som bygger på en funktion
//---- Det traditionella sättet att jobba med JS-klasser
function person(inName, inMail)
{
    //Properties som sätts via konstruktorn
    this.name= inName;
    this.email= inMail;

    //Här skapas en metod genom en funktion inne i huvudfunktionen
    //Kallas för en closure i JS
    this.ViewInfo = function(){
        console.log("Uppgifterna är:" + this.name + " " + this.email);
    }
}

var person3 = new person("kalle", "kalle@nackademin.se");
person3.ViewInfo();

//---- Fjärde sättet är via den nya syntaxen som kom i EC6. Syntaxen är mer lik andra språk som Java och C#
//---- När denna kod körs omvandlas den ändå till en funktion så detta är mer "syntaktisk kosmetika" .
class PersonEC6{

    constructor(inName, inMail)
    {
        this.name = inName;
        this.email = inMail; 
    }

    ViewInfo()
    {
        console.log("Uppgifterna är:" + this.name + " " + this.email);
        
    }
}
var person4 = new PersonEC6("kalle", "kalle@nackademin.se");