using System.Collections.Generic;
using UnityEngine;

public class MementoController : MonoBehaviour
{
    public Inventory inventory;

    private Stack<Memento> mementos = new();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Save();
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            Cancle();
        }
    }

    private void Save()
    {
        var newMemento = inventory.CreateMemento();
        mementos.Push(newMemento);

        Debug.Log("저장 성공!");
    }

    private void Cancle()
    {
        if (mementos.Count <= 0)
        {
            Debug.Log("저장본이 없습니다.");
            return;
        }

        var memento = mementos.Pop();
        inventory.RestoreMemento(memento);

        Debug.Log("되돌리기 성공!");
    }
}
