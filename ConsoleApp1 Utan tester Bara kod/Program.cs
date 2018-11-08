using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Bowling;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Member memberStefan = new Member()
            {
                Name = "Stefan",
                MemberNo = 1010
            };
            memberStefan.AddMembership(new DateTime(2018,10,30));

            Member memberMaria = new Member
            {
                Name = "Maria",
                MemberNo = 1011
            };
            memberMaria.AddMembership(new DateTime(2018, 10, 28));

            Member memberOlivia = new Member
            {
                Name = "Olivia",
                MemberNo = 1012
            };
            memberOlivia.AddMembership(new DateTime(2018, 10, 27));

            Competition competition = new Competition();
            competition.Name = "Bengan Cup";
            competition.StartDate = new DateTime(2018, 1, 1);
            competition.EndDate = new DateTime(2018, 12, 31);
            competition.RegisterParticipant(memberStefan);
            competition.RegisterParticipant(memberOlivia);
            competition.RegisterParticipant(memberMaria);

            Game game;
            try
            {
                game = competition.CreateGame(memberStefan, memberOlivia);
                game.RegisterSerie(1, 100,120);
                game.RegisterSerie(2, 110, 130);
                game.RegisterSerie(3, 98, 115);
                Member member = game.GetWinner();
                if(member == null)
                {
                    Console.WriteLine("It's a tie, contiunue with more registerSeries...");
                }
                Console.WriteLine(member.Name + " won");
            }
            catch (Exception ex)
            {
                //Already played..
            }



            try
            {
                game = competition.CreateGame(memberMaria, memberOlivia);
                game.RegisterSerie(1, 100, 120);
                game.RegisterSerie(2, 110, 130);
                game.RegisterSerie(3, 98, 115);
                Member member = game.GetWinner();
                if (member == null)
                {
                    Console.WriteLine("It's a tie, contiunue with more registerSeries...");
                }
                Console.WriteLine(member.Name + " won");
            }
            catch (Exception ex)
            {
                //Already played..
            }



            try
            {
                game = competition.CreateGame(memberMaria, memberStefan);
                game.RegisterSerie(1, 100, 120);
                game.RegisterSerie(2, 110, 130);
                game.RegisterSerie(3, 98, 115);
                Member member = game.GetWinner();
                if (member == null)
                {
                    Console.WriteLine("It's a tie, contiunue with more registerSeries...");
                }
                Console.WriteLine(member.Name + " won");
            }
            catch (Exception ex)
            {
                //Already played..
            }

           Member winner = competition.GetWinner();
            if (winner == null)
            {
                Console.WriteLine("No winner yet...");
            }
            Console.WriteLine(winner.Name + " won");



        }
    }
}
