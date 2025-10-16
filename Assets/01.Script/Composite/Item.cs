using UnityEngine;

public abstract class Item
{
    public enum Type
    {
        Use,
        Equip,
        Own,
        Main
    }

    public string name;
    public Type type;

    public abstract void Operate();

    public Item(string name, Type type)
    {
        this.name = name;
        this.type = type;
    }
}
