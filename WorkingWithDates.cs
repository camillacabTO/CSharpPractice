using System;
using System.Globalization;
using System.Runtime.InteropServices;

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    public static DateTime ShowLocalTime(DateTime dtUtc)
    {
        return TimeZoneInfo.ConvertTime(dtUtc, TimeZoneInfo.Local);
    }

    private static string GetTimezoneId(Location location)
    {
        var isLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ||
                      RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
        string timeZone = location switch
        {
            Location.NewYork => isLinux ? "America/New_York" : "Eastern Standard Time",
            Location.London => isLinux ? "Europe/London" : "GMT Standard Time",
            Location.Paris => isLinux ? "Europe/Paris" : "Romance Standard Time",
            _ => throw new ArgumentException("Invalid location")
        };
        return timeZone;
    }

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        TimeZoneInfo passedZone = TimeZoneInfo.Utc;
        string timeZone = GetTimezoneId(location);
        passedZone = TimeZoneInfo.FindSystemTimeZoneById(timeZone);
        return TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse(appointmentDateDescription), passedZone);
    }

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
    {
        DateTime alertTime = alertLevel switch
        {
            AlertLevel.Early => appointment.AddDays(-1),
            AlertLevel.Standard => appointment.AddHours(-1).AddMinutes(-45),
            AlertLevel.Late => appointment.AddMinutes(-30),
            _ => throw new ArgumentException("Invalid alert level")
        };
        return alertTime;
    }

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        string timeZone = GetTimezoneId(location);
        var pastDate = TimeZoneInfo.FindSystemTimeZoneById(timeZone).IsDaylightSavingTime(dt.AddDays(-8));
        var currentDate = TimeZoneInfo.FindSystemTimeZoneById(timeZone).IsDaylightSavingTime(dt);
        return pastDate != currentDate;
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        string format = location switch
        {
            Location.London => "dd/MM/yyyy HH:mm:ss",
            Location.NewYork => "MM/dd/yyyy HH:mm:ss",
            Location.Paris => "dd/MM/yyyy HH:mm:ss",
            _ => throw new ArgumentException("Unsupported location")
        };

        if (DateTime.TryParseExact(dtStr, 
                format, 
                System.Globalization.CultureInfo.InvariantCulture,
                DateTimeStyles.None, 
                out DateTime result))
        {
            return result;
        }
        return new DateTime(1, 1, 1);
    }

}