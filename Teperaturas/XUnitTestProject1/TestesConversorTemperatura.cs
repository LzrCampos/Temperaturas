using Xunit;
using Tempersturas;

namespace Temperatura.Tests
{
    public class TestesConversorTemperatura
    {
        [Theory]
        [InlineData(32, 0)]
        [InlineData(86, 30)]
        [InlineData(90.5, 32.5)]
        [InlineData(212, 100)]
        public void TesteConversaoTemp01(double tempF, double tempC)
        {
            double resultado = ConversorTemperaturas.FtoC(tempF);
            Assert.Equal(tempC, resultado);
        }
        //[Fact]
        //public void TesteConversaoTemp02()
        //{
        //    double resultado = ConversorTemperaturas.FtoC(86);
        //    Assert.Equal(30, resultado);
        //}
        //[Fact]
        //public void TesteConversaoTemp03()
        //{
        //    double resultado = ConversorTemperaturas.FtoC(90.5);
        //    Assert.Equal(32.5, resultado);
        //}
        //[Fact]
        //public void TesteConversaoTemp04()
        //{
        //    double resultado = ConversorTemperaturas.FtoC(212);
        //    Assert.Equal(100, resultado);
        //}
    }
}
