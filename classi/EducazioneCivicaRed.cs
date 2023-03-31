using Xunit;
using System;
using EducazioneCivica;

public class EducazioneCivicaTests
{
    [Fact]
    public void Esercizio2Test() 
    { 
        var test = new EducazioneCivica(); 
        string result = test.Esercizio2("msky", 10);

        Assert.Equal(result, "abcd");
    }
}
