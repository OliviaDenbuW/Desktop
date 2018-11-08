using System;
using Xunit;
using OliviaDemoUnitTest;

namespace DemoTestCases
{
    public class TestCases
    {
        //metod som kollar o checkar aFactv
        [Fact]
        public void CheckSimpleAddition()
        {
            //Vad ska resultatet bli?
            int expectedValue = 6;

            //SKapa upp klassen + using namespace där calculation finns
            Calculation calculation = new Calculation();

            //Anropa klassen med 2 värden o kolla om svaret är det den ska generera
            int actualValue = calculation.Addition(3, 3);

            //Göra kontroll
            Assert.Equal(expectedValue, actualValue);

            //Om den leverear tru så är det rätt annars fail + [Fact]
        }

        //TEstar utan hårdkodade värden, utan med inparamtrar till metoden
        [Theory]
        [InlineData(8,4,4)] //Förväntat, v1, v2
        [InlineData(10, 5, 5)]
        [InlineData(4, 2, 2)]
        public void CheckMultipleAddition(int expectedValue, int value1, int value2)
        {
            Calculation calculation = new Calculation();

            //Samma som ovan men inparam + []
            int actualValue = calculation.Addition(value1, value2);

            Assert.Equal(expectedValue, actualValue);
        }

        public void ThisIsNotATestCase()
        {
            //Utan attribut vet man att det inte är en testmetod
        }
    }
}
