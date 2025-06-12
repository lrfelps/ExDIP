enum State { On, off }
class Lamp(State State)
{
    public void Operate()
    {
        State = State == State.On ? State.off : State.On;
        Console.WriteLine($"The lamp is now {State}.");

    }
}

class Switch
{
    private Lamp lamp;
    public Switch(Lamp lamp)
    {
        this.lamp = lamp;
    }
    public void Press()
    {
        this.lamp.Operate();
    }
}