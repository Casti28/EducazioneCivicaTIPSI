using System;
using System.Reflection;

public class EducazioneCivica
{
    private static string alfabeto = "abcdefghijklmnopqrstuvwxyz";
    public static string Esercizio1(string s, int n)
    {
        s = s.ToLower();
        string result = "";
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < alfabeto.Length; j++)
            {
                if (s[i] == alfabeto[j])
                {
                    int index = j + n;
                    if (index > 25)
                    {
                        index -= 26;
                    }
                    result += alfabeto[index];
                }
            }
        }
        return result;
    }

    public static string Esercizio2(string s, int n)
    {
        s = s.ToLower();
        string result = "";
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < alfabeto.Length; j++)
            {
                if (s[i] == alfabeto[j])
                {
                    int index = j - n;
                    if (index < 0)
                    {
                        index += 26;
                    }
                    result += alfabeto[index];
                }
            }
        }
        return result;
    }

    public static int Esercizio3(string s, int n)
    {
        s = s.ToLower();
        int result = 0;
        int somma = 0;
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < alfabeto.Length; j++)
            {
                if (s[i] == alfabeto[j])
                {
                    somma += j + 1;
                }
            }
        }
        result = somma * n;
        return result;
    }

    public static double Esercizio4(string s, int n)
    {
        s = s.ToLower();
        double result = 0;
        double prodotto = 1;
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < alfabeto.Length; j++)
            {
                if (s[i] == alfabeto[j])
                {
                    prodotto *= j + 1;
                }
            }
        }
        result = prodotto / n;
        return Math.Ceiling(result);
    }
}