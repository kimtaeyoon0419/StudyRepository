using System.Collections.Generic;
using UnityEngine;

public class ItemBag : MementoItem
{
    private List<MementoItem> itemList = new List<MementoItem>();

    public ItemBag(string name, Type type = Type.Use) : base(name, type)
    {

    }

    public override void Operate()
    {
        OpenSlotWindow();
    }

    private void OpenSlotWindow()
    {

    }

    public void Add(MementoItem item)
    {
        if(itemList.Contains(item))
        {
            Debug.Log("이미 해당 아이템이 리스트에 존재함");
            return;
        }
        itemList.Add(item);
    }

    public void Remove(MementoItem item)
    {
        if (!itemList.Contains(item))
        {
            Debug.Log("아이템이 리스트에 존재하지 않음");
            return;
        }
        itemList.Remove(item);
    }
}
