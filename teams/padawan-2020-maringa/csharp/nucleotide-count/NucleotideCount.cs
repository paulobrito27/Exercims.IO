using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var dicionario = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        foreach (var letra in sequence)
        {
            if (dicionario.ContainsKey(letra))
            {
                dicionario[letra]++;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        return dicionario;
    }
}