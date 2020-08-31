using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> _lista = new List<int>();
    public HighScores(List<int> list)
    {
        _lista = list;
    }

    public List<int> Scores()
    {

        return _lista;
    }

    public int Latest()
    {
        return _lista.Last();
    }

    public int PersonalBest()
    {
        return _lista.Max();
    }

    public List<int> PersonalTopThree()
    {
        List<int> listaOrdenada = _lista.OrderByDescending(c => c).Take(3).ToList();
        return listaOrdenada;
    }
}