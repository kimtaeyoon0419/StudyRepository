using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<ItemSO> inventoryItems = new List<ItemSO>();

    public Memento CreateMemento()
    {
        var newMemento = new Memento();
        newMemento.SetStates(inventoryItems);
        return newMemento;
    }

    public void RestoreMemento(Memento memento)
    {
        inventoryItems = memento.GetState();
    }
}

public class Memento
{
    public List<ItemSO> items;

    public List<ItemSO> GetState()
    {
        return items;
    }

    public void SetStates(List<ItemSO> items)
    {
        this.items = new(items);
    }
}