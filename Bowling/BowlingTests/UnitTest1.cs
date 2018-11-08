using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1.Bowling;

namespace BowlingTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateMemberShouldCreateTransaction()
        {
            Member member = new Member()
            {
                Name = "Stefan",
                MemberNo = 1010
            };
            member.AddMembership(new DateTime(2018, 10, 30));
            Assert.AreEqual(1, member.Transactions.Count);
            Assert.AreEqual(FeeType.MemberFee, member.Transactions[0].FeeType);
        }

        [TestMethod]
        public void CreateCompetitionShouldAddParticipants()
        {
            Member memberStefan = new Member()
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

            Assert.AreEqual(3, competition.Participants.Count);
            Assert.AreEqual(FeeType.CompetitionFee, memberOlivia.Transactions[1].FeeType);
        }

        [TestMethod]
        public void PlayGameShouldSetCorrectWinner()
        {
            Member memberStefan = new Member()
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
            game = competition.CreateGame(memberStefan, memberOlivia);
            game.RegisterSerie(1, 100, 120);
            game.RegisterSerie(2, 110, 130);
            game.RegisterSerie(3, 98, 115);
            Member member = game.GetWinner();
            Assert.AreEqual(memberOlivia, member);
        }


    }
}
