using System.Collections.Generic;
using UnityEngine;

public class ItemBag : Item
{
    private List<Item> itemList = new List<Item>();

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

    public void Add(Item item)
    {
        if(itemList.Contains(item))
        {
            Debug.Log("�̹� �ش� �������� ����Ʈ�� ������");
            return;
        }
        itemList.Add(item);
    }

    public void Remove(Item item)
    {
        if (!itemList.Contains(item))
        {
            Debug.Log("�������� ����Ʈ�� �������� ����");
            return;
        }
        itemList.Remove(item);
    }
}
