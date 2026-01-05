namespace SchoolworkForYear12.Work.Inheritance.Homework_5_11_25;

public class Date
{
    private int _day;
    private int _month;
    private int _year;

    public Date(int day, int month, int year)
    {
        _day = day;
        _month = month;
        _year = year;
    }

    public Date(Date expirationDate)
    {
        _day = expirationDate._day;
        _month = expirationDate._month;
        _year = expirationDate._year;
    }

    public int GetDay()
    {
        return _day;
    }

    public int GetMonth()
    {
        return _month;
    }

    public int GetYear()
    {
        return _year;
    }


    public void SetDay(int num)
    {
        _day = num;
    }

    public void SetMonth(int num)
    {
        _month = num;
    }

    public void SetYear(int num)
    {
        _year = num;
    }

    public int CompareTo(Date other)
    {
        int diffBetweenDates = 0;

        diffBetweenDates += _day - other._day;
        diffBetweenDates += (_month - other._month)*31;
        diffBetweenDates += (_year - other._year) * 31 * 12;

        return diffBetweenDates;
    }

    public override string ToString()
    {
        return $"{_day}.{_month}.{_year}";
    }


    public static Date GetCurDate()
    {
        return new Date(
            5,
            1,
            2026
        );
    }
}