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
    public void Esercizio2RedTest() 
    {
        var test = new EducazioneCivica(); 
        string result = test.Esercizio2("msky", 10);

        Assert.Equal(result, "abcd");
    }

    [Fact]
    public void Esercizio3GreenTest() 
    {
        var test = new EducazioneCivica(); 
        int result = test.Esercizio3("ciao", 10);

        Assert.Equal(result, 280);
    }

    [Fact]
    public void Esercizio3RedTest() 
    {
        var test = new EducazioneCivica(); 
        int result = test.Esercizio3("ciao", 10);

        Assert.Equal(result, 200);
    }


}
