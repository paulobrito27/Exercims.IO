using System;
using System.IO.Pipes;

public class SpaceAge
{
    private int _spaceSeconds;


    public SpaceAge(int seconds)
    {
        _spaceSeconds = seconds;
    }

    public double OnEarth()
    {
        double anosTerrestres = _spaceSeconds / 31557600.00;
        return anosTerrestres;
    }

    public double OnMercury()
    {
        return OnEarth()/ 0.2408467;
    }

    public double OnVenus()
    {
        return OnEarth() / 0.61519726;
    }

    public double OnMars()
    {
        return OnEarth() / 1.8808158;
    }

    public double OnJupiter()
    {
        return OnEarth() / 11.862615;
    }

    public double OnSaturn()
    {
        return OnEarth() / 29.447498;
    }

    public double OnUranus()
    {
        return OnEarth() / 84.016846;
    }

    public double OnNeptune()
    {
        return OnEarth() / 164.79132;
    }
}