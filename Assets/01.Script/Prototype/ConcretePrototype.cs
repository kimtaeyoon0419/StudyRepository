using UnityEngine;

public abstract class Prototype
{
    public abstract Prototype Clone();
}

public class ConcretePrototype : Prototype
{
    public int data;
    public override Prototype Clone()
    {
        return new ConcretePrototype { data = this.data };
    }
}
