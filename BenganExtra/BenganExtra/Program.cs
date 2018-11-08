using BenganExtra.Bowling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BenganExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            Member member = new Member();
            

            Member memberStefan = new Member
            {
                Name = "Stefan",
                MemberNo = 1010
            };
            memberStefan.AddMembership(new DateTime(2018, 10, 30));

            Member memberMaria = new Member
            {
                Name = "Maria",
                MemberNo = 1011
            };

            Member memberOlivia = new Member
            {
                Name = "Olivia",
                MemberNo = 1010
            };

            Competition competition = new Competition();
            competition.Name = "Bengan Cup";
            competition.StartDate = new DateTime(2018, 1, 1);
            competition.EndDate = new DateTime(2018, 12, 31);
            //competition.RegisterParticipant(memberStefan);


            Game game;
            //får inte spela mot varandera flera gånger

            //SAMMANFATTNING:
            //Skpaar upp game och vi hårdkodar in vad de fick
            //läggs sen till i ..
            //Winnaren summers
            try
            {
                //lägger till match i tävlingen
                //när vi kommer in i create Game så loopar cvi igenom alla matcher som redan är bokade/körda o kollar om det är 
                //samma deltagare (måste göra åt båda hållen)
                //Om vi redan spelat gör vi exception annars så skapar vi game, lägger till i listan och returnerar game
                game = competition.CreateGame(memberStefan, memberOlivia);
                //Kör tre gånge rochg skickar in resultatern somm är på Game objektet
                game.RegisterSerie(1, 100, 120);
                game.RegisterSerie(2,110, 120);
                game.RegisterSerie(3, 98, 120);

                //När vi kört den här har vi lagt int re gameSergie objekt i listan som ligger i Game och så har vi tre st
                //i game i den listan
                //Sen kan vi köra GEtWInner
                Member member = game.GetWinner();
                if (member == null)
                {
                    Console.WriteLine("tie");
                }
                Console.WriteLine(member.Name + " won");
            }
            catch (Exception)
            {

                throw;
            }

            try
            {
                //lägger till match i tävlingen
                //när vi kommer in i create Game så loopar cvi igenom alla matcher som redan är bokade/körda o kollar om det är 
                //samma deltagare (måste göra åt båda hållen)
                //Om vi redan spelat gör vi exception annars så skapar vi game, lägger till i listan och returnerar game
                game = competition.CreateGame(memberMaria, memberOlivia);
                //Kör tre gånge rochg skickar in resultatern somm är på Game objektet
                game.RegisterSerie(1, 100, 120);
                game.RegisterSerie(2, 110, 120);
                game.RegisterSerie(3, 98, 120);

                //När vi kört den här har vi lagt int re gameSergie objekt i listan som ligger i Game och så har vi tre st
                //i game i den listan
                //Sen kan vi köra GEtWInner
                Member member = game.GetWinner();
                if (member == null)
                {
                    Console.WriteLine("tie");
                }
                Console.WriteLine(member.Name + " won");
            }
            catch (Exception)
            {

                throw;
            }

            try
            {
                //lägger till match i tävlingen
                //när vi kommer in i create Game så loopar cvi igenom alla matcher som redan är bokade/körda o kollar om det är 
                //samma deltagare (måste göra åt båda hållen)
                //Om vi redan spelat gör vi exception annars så skapar vi game, lägger till i listan och returnerar game
                game = competition.CreateGame(memberStefan, memberMaria);
                //Kör tre gånge rochg skickar in resultatern somm är på Game objektet
                game.RegisterSerie(1, 100, 120);
                game.RegisterSerie(2, 110, 120);
                game.RegisterSerie(3, 98, 120);

                //När vi kört den här har vi lagt int re gameSergie objekt i listan som ligger i Game och så har vi tre st
                //i game i den listan
                //Sen kan vi köra GEtWInner
                Member member = game.GetWinner();
                if (member == null)
                {
                    Console.WriteLine("tie");
                }
                Console.WriteLine(member.Name + " won");
            }
            catch (Exception)
            {

                throw;
            }

            //Gör som en variabel sen för 10 matcher etc...

            //VEM HAR CUNNIT COMPETITION
            Member winner = competition.GetWinner();
            if (winner == null)
            {
                Console.WriteLine("No winner yet");
            }
            Console.WriteLine(winner.);
        }

        //Går igenim alla participants
        //Sen alla som han spelat
        //Han hade snitt 0,5 men bästa snitt är 0,5 så mitt snitt blir 1 när jag spelat mina matcher
    }
}
