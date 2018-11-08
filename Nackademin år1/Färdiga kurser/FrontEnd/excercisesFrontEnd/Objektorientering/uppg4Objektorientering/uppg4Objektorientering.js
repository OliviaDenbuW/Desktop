/*
Skapas en klass som heter Bankkonto. Skapa sedan 2 olika kontotyper som ärver från
den klassen och sedan har egna metoder och egenskaper som är unika för den
kontotypen. De skall heta Sparkonto och Personkonto. Ett bankkonto har
kontonummer och ett saldo. Det skall finnas en metod som heter Uttag och en som
heter Insättning. Ett sparkonto har egenskapen antaluttag (eftersom det har ett
begränsat antal uttag) och ett Personkonto egenskapen kortnummer (eftersom det
är kopplat till ett betalkort). Skapa dessa klasser och skriv kod för att skapa en instans
av Sparkonto och en av Personkonto.
*/

class Bankkonto
{
    constructor(kontoNr, s)
    {
        this.kontonummer = kontoNr;
        this.saldo = s;
    }

    Uttag()
    {

    }

    Insättning()
    {

    }
}

class Sparkonto extends Bankkonto
{

    constructor(aUttag, kontoNr, s)
    {
        super(kontoNr, s);
        this.antalUttag = aUttag;
    }
}

class Personkonto extends Bankkonto
{
    constructor(kNummer, kortNr, s)
    {
        super(kortNr, s);
        this.kortnummer = kortNr;
    }
}

var sparkonto = new Sparkonto("12", "5522 6456 74774", "120 000 kr");
/*
sparkonto.kontonummer = "5522 6456 74774";
sparkonto.saldo = "120 000 kr";
sparkonto.antalUttag = 2;
*/

var personkonto = new Personkonto("2999 1223 83738", "34 000 kr", "6400 54483 2635377");
/*
personkonto.kontonummer = "2999 1223 83738";
personkonto.saldo = "34 000 kr";
personkonto.kortnummer = "6400 54483 2635377";
*/

console.log("Sparkonto: " + sparkonto.antalUttag + " st uttag, Kontonummer: " + sparkonto.kontonummer + " Summa: " + sparkonto.saldo);