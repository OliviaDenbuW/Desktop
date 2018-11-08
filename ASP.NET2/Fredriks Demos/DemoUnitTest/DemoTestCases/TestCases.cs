using DemoUnitTest;
using Xunit;

//1. För att detta skall fungera måste du skapat en reference till
//webbprojektet genom Dependencies- "Add reference"

//2. Ladda ned två nuget packages- 
//Xunit och 
//xUnit runner Visual Studio (för att kunna testet i VS)

//3. Kör testen genom att välja test i menyn och "Run all tests"

namespace DemoTestCases
{
    public class TestCases
    {
        //Första test caset. Gör ett anrop till metoden
        [Fact]
        public void CheckSimpleAddition()
        {
            int expectedValue = 6;

            Calculation calculation = new Calculation();

            //Det värde som metoden levererar
            int acutalValue = calculation.Addition(3, 3);

            //Jämför förväntat värde med vad som levereras
            Assert.Equal(expectedValue, acutalValue);
            

        }

        //Nytt test case. Här läggs det in flera anrop till metoden
        [Theory]
        [InlineData(8,4,4)]
        [InlineData(10, 5, 4)]
        [InlineData(4, 2, 2)]

        public void CheckMultipleAdditions(int expectedValue, int value1, int value2)
        {
            Calculation calculation = new Calculation();

            int acutalValue = calculation.Addition(value1, value2);

            Assert.Equal(expectedValue, acutalValue);

        }


    }
}
