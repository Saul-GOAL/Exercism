using System;
using System.Linq;

public enum Schedule { First, Second, Third, Fourth, Last, Teenth };

public class Meetup
{
    private int month;
    private int year;
    
    public Meetup(int month, int year)
    {
        this.month = month;
        this.year = year;
    }
    
    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        var startOfMonth = new DateTime(year, month, 1);
        var day_offset = dayOfWeek - startOfMonth.DayOfWeek;
        
        if (day_offset < 0)
        {
            day_offset += 7;
        }

        switch (schedule)
        {
            case Schedule.First:
            case Schedule.Second:
            case Schedule.Third:
            case Schedule.Fourth:
                day_offset += (int)schedule * 7;
                break;
            case Schedule.Teenth:
                day_offset += 7;
                if (day_offset < 12)
                {
                    day_offset += 7;
                }
                break;
            case Schedule.Last:
                day_offset += 21;
                var daysInMonth = DateTime.DaysInMonth(year, month);
                if (daysInMonth - day_offset > 7)
                {
                    day_offset += 7;
                }
                break;
            default:
                break;
        }
        return startOfMonth.AddDays(day_offset);
    }
}
