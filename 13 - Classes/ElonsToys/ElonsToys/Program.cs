using System;

class RemoteControlCar
{

    private int _batteryLevel = 100;
    private int _distanceDriven = 0;

    public static RemoteControlCar Buy() => new();

    public string DistanceDisplay() =>
        $"Driven {_distanceDriven} meters";

    public string BatteryDisplay() => 
        _batteryLevel > 0 ? $"Battery at {_batteryLevel}%" : "Battery empty";

    public void Drive()
    {
        if (_batteryLevel > 0)
        {
            _distanceDriven += 20;
            _batteryLevel--;
        }
    }
}
