using System;
using System.Collections.Generic;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private static int score;
    List<Allergen> all = new List<Allergen>() { Allergen.Eggs, Allergen.Peanuts, Allergen.Shellfish, Allergen.Strawberries,Allergen.Tomatoes, Allergen.Chocolate, Allergen.Pollen, Allergen.Cats };


    public Allergies(int mask)
    {
        score = mask;
    }

    public bool IsAllergicTo(Allergen a)
    {
        return (score & a.GetHashCode()) != 0;
    }

    public Allergen[] List()
    {
        Allergen[] lista = new Allergen[8];
        int i = 0;
        foreach (var item in all)
        {
            if (IsAllergicTo(item))
            {
                lista[i] = item;
                i++;
            }
        }

        int cont = 0;

        foreach (var item in lista)
        {
            if (item != 0)
            {
                cont++;
            }
        }

        Allergen[] listaCorreta = new Allergen[cont];
        i = 0;
        foreach (var item in all)
        {
            if (IsAllergicTo(item))
            {
                listaCorreta[i] = item;
                i++;
            }
        }

        return listaCorreta;
    }
}
