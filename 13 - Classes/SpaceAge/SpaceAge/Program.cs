using System;

public class SpaceAge
{
    const double EarthYear = 31557600;
    const double MercuryRate = 0.2408467;
    const double VenusRate = 0.61519726;
    const double MarsRate = 1.8808158;
    const double JupiterRate = 11.862615;
    const double SaturnRate = 29.447498;
    const double UranusRate = 84.016846;
    const double NeptuneRate = 164.79132;


    private double seconds;

    public SpaceAge(int seconds) => 
        this.seconds = seconds;

    public double OnEarth() =>
        seconds / EarthYear;

    public double OnMercury() =>
        seconds / EarthYear / MercuryRate;

    public double OnVenus() =>
        (seconds / EarthYear) / VenusRate;

    public double OnMars() =>
        seconds / EarthYear / MarsRate;

    public double OnJupiter() => 
        seconds / EarthYear / JupiterRate;

    public double OnSaturn() =>
        seconds / EarthYear / SaturnRate;

    public double OnUranus() =>
        seconds / EarthYear / UranusRate;

    public double OnNeptune() =>
        seconds / EarthYear / NeptuneRate;
}