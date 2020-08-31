using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int diferencas = 0;
        if (firstStrand.Length == secondStrand.Length)
        {
            int i = 0;
            foreach (var letra in firstStrand)
            {
                if (letra != secondStrand[i])
                {
                    diferencas++;
                }
                i++;
            }
        }
        else
        {
            throw new ArgumentException();
        }

        return diferencas;
    }
}