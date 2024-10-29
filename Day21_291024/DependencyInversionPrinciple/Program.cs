// High-level module must not depend on the low-level module, but they should depend on abstractions.

using System;

public class GreenLightBulb
{
    public void TurnOn() => Console.WriteLine("Light is on");
    public void TurnOff() => Console.WriteLine("Light is off");
}

public class LightSwitch
{
    private readonly GreenLightBulb _bulb;

    public LightSwitch(GreenLightBulb bulb)
    {
        _bulb = bulb;
    }
    
    public void SwitchOn() => _bulb.TurnOn();
    public void SwitchOff() => _bulb.TurnOff();
}