using System;
public class Date
{
    private int day;
    private int month;
    private int year;

    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public override string ToString()
    {
        return $"{day:D2}/{month:D2}/{year}";
    }
}
