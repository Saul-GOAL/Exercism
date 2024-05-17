using System;

class RemoteControlCar
{
    public int Speed { get; }
    public int BatteryDrain { get; }
    private int battery;
    private int distance;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        battery = 100;
        distance = 0;
        Speed = speed;
        BatteryDrain = batteryDrain;
    }
    public bool BatteryDrained() =>
        (battery - BatteryDrain) < 0;

    public int DistanceDriven() =>
        distance;
    
    public void Drive()
    {
        if (!BatteryDrained())
        {
            distance += Speed;
            battery -= BatteryDrain;
        }
    }

    public static RemoteControlCar Nitro() =>
        new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private readonly int distance;

    public RaceTrack(int distance) => 
        this.distance = distance;
    
    public bool TryFinishTrack(RemoteControlCar car)
    {
        var drives = 100 / car.BatteryDrain;
        var possibleDistance = drives * car.Speed;
        
        return possibleDistance >= distance;
    }
}