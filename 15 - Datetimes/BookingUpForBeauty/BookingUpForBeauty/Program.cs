using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        DateTime date = DateTime.Parse(appointmentDateDescription);
        return date;
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        DateTime today = DateTime.Now;

        return Schedule(appointmentDate.ToString()) < today;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate) =>
        Schedule(appointmentDate.ToString()).Hour >= 12 && Schedule(appointmentDate.ToString()).Hour < 18;

    public static string Description(DateTime appointmentDate) =>
        "You have an appointment on " + Schedule(appointmentDate.ToString()) + ".";

    public static DateTime AnniversaryDate() =>
        new DateTime(2023, 9, 15, 0, 0, 0);
}
