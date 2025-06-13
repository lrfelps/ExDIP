using Exec02;


IDevice lamp = new Lamp();
var lampSwitch = new Switch(lamp);

lampSwitch.Operate();
lampSwitch.Operate();
