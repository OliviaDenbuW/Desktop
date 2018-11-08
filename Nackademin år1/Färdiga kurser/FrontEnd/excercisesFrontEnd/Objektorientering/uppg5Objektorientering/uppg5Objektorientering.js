/*
Bygg ut din lösning från uppgift 1. Skapa en inkapslad metod (skall inte gå att anropa
utanför klassen) som heter SkapaTransaktion. Den skall anropas vid både uttag och
insättning och ta emot ett tal. Enda skillnaden är att detta tal är negativt vid ett
uttag. Skapa kod för att skapa ett konto och göra uttag och insättningar på någon
kontotyp.
*/

class Bankkonto
{
    constructor(kontoNr, s)
    {
        this.kontonummer = kontoNr;
        this.saldo = s;
    }

    Uttag(beloppUttag)
    {
        this.Transaktion(beloppUttag);
    }

    Insättning(beloppInsättning)
    {
        this.Transaktion(beloppInsättning);
    }

    Transaktion(belopp)
    {
        return this.saldo + belopp;
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

var personkonto = new Personkonto("2999 1223 83738", "34 000 kr", "6400 54483 2635377");

sparkonto.saldo = "1000";
console.log(sparkonto.saldo);

sparkonto.Transaktion(100);
console.log(sparkonto.saldo);
//console.log("Sparkonto: " + sparkonto.antalUttag + " st uttag, Kontonummer: " + sparkonto.kontonummer + " Summa: " + sparkonto.saldo);