using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BenganExtra.Bowling;

namespace BowlingTests
{
    [TestClass]
    public class UnitTest1
    {
        //Är ett exempeltest
        //Lägg till referens till consoleApp prokelt för vi vill ha klasserna därifrån
        //Höklicka på ref och lägg till
        [TestMethod]
        public void CreateMemeberShudCreateTransaction()
        {
            Member memberStefan = new Member
            {
                Name = "Stefan",
                MemberNo = 1010
            };
            memberStefan.AddMembership(new DateTime(2018, 10, 30));
            Assert.AreEqual(1, memberStefan.Transactions.Count);
            Assert.AreEqual(FeeType.MemberFee, memberStefan.Transactins[0].FeeType);

            //TEST TVÅ SAKER:

            //TEST1
            //1. Kod som kommer göras
            //2. Assert statement (sånt vi vill testa/veriefiera..det blir verkligen så när vi kör våra namn)
                //N
                //när vi kör AddMemnbersip så ska det hamna en transaktion där (vi kollar att count = 1)

            //TEST2 att första transaktionern feeType ska vara MemberFee

        }

        //EGentligen borde det vara en testfil per klass som man testar

        
        [TestMethod]
        public void CreateCompetitionShudAddParticipant()
        {
            COmpetition compettion //från main kommer massa mer kod
            Assert.AreEqual(1, competition.Parcipitants.Count);
            Assert.AreEqual(FeeType.COmpetitionFee, memberOlivia.Transactins[0].FeeType);

         
        }

        [TestMethod]
        public void PlayGameShudSetCorrectWinner()
        {
            Game game;
            game
            //Verifierar att assert 
            Assert.AreEqual(memberOlivia, member);


        }
    }
}
