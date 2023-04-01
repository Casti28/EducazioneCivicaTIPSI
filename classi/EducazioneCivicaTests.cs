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

    [Fact]
    public void Esercizio4GreenTest() 
    {
        var test = new EducazioneCivica(); 
        double result = test.Esercizio4("ciao", 10);

        Assert.Equal(result, 41);
    }

    [Fact]
    public void Esercizio4RedTest() 
    {
        var test = new EducazioneCivica(); 
        double result = test.Esercizio4("ciao", 10);

        Assert.Equal(result, 100);
    }

    [Fact]
    public void Esercizio5GreenTest() 
    {
        var test = new EducazioneCivica(); 
        double result = test.Esercizio5("ciao", 10);

        Assert.Equal(result, 280);
    }

    [Fact]
    public void Esercizio5RedTest() 
    {
        var test = new EducazioneCivica(); 
        double result = test.Esercizio5("ciao", 9);

        Assert.Equal(result, 2000);
    }
}
