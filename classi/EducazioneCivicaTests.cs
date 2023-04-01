using Xunit;
using System;
using EducazioneCivica;

public class EducazioneCivicaTests
{
    [Fact]
    public void Esercizio1GreenTest() 
    { 
        var test = new EducazioneCivica(); 
        string result = test.Esercizio1("ciao", 10);

        Assert.Equal(result, "msky");
    }

    [Fact]
    public void Esercizio1RedTest() 
    { 
        var test = new EducazioneCivica(); 
        string result = test.Esercizio1("ciao", 10);

        Assert.Equal(result, "abcd");
    }

    [Fact]
    public void Esercizio2GreenTest() 
    { 
        var test = new EducazioneCivica(); 
        string result = test.Esercizio2("msky", 10);

        Assert.Equal(result, "ciao");
    }

    [Fact]
    public void Esercizio1RedTest() 
    {
        var test = new EducazioneCivica(); 
        string result = test.Esercizio2("msky", 10);

        Assert.Equal(result, "abcd");
    }
}
