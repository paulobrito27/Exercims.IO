using System;

public static class ResistorColor
{
    public static int ColorCode(string color) => (int)Enum.Parse(typeof(CoresEnum), color);


    public static string[] Colors()
    {
        return new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    }

    enum CoresEnum
    {
        black,
        brown,
        red,
        orange,
        yellow,
        green,
        blue,
        violet,
        gray,
        white
    }
}