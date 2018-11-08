/*Skapa en ny klass. Döp den till Student. Den skall ha egenskaperna förnamn,
efternamn,  email och telefonnummer. Skapa properties för alla dessa egenskaper.
Skapa sedan kod där alla värden sätts på klassen. Hämta sedan alla värden från
klassen och skriv ut. Pröva sedan att göra samma lösning fast sätt alla värden via
konstruktorn istället.*/

class Student
{  
    constructor()
    {
        this.firstName;
        this.lastName;
        this.phone;
        this.email; 
    } 
}

class Elev
{
    constructor(fN, lN, p, e)
    {
        this.firstName = fN;
        this.lastName = lN;
        this.phone = p;
        this.email = e;
    }
}

var student = new Student();
student.firstName = "Olivia";
student.lastName = "Denbu";
student.email = "olivia.denbu@gmail.com";
student.phone = "0768607389";

var elev = new Elev("alexandra", "Persson", "075887262655", "a.p@gmail.com");
console.log(elev.firstName);
student.email = "lina.gr@gmail.com";
console.log(student.email);

console.log(student.firstName + " " + student.lastName + " " + student.email + " " + student.phone);