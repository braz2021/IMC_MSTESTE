namespace imc.mstest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Teste_Calculo_IMC()
    {
        double imc_previsto = 31.25;
        IMC imc = new IMC();

        imc.altura = 1.60;
        imc.peso = 80;

        imc.calcular_IMC();

        Assert.AreEqual(imc_previsto,imc.imc);
    }
    [TestMethod]
    [DataRow("Abaixo do peso")]
    [DataRow("Peso normal")]
    [DataRow("Sobrepeso")]
    [DataRow("obsidade GR 1")] 
    [DataRow("obsidade GR 3")]
    public void Teste_Classificar_IMC(string cat)
    {
        IMC imc = new  IMC();
        imc.imc = 31.25;
        imc.classificar_IMC();

        Assert.AreEqual(cat, imc.categoria);
    }
}