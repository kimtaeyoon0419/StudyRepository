using UnityEngine;

public class Teacher : Handler
{
    public override void HandleRequest(int level)
    {
        if (level <= 1) Debug.Log("������ ó��");
        else nextHandler?.HandleRequest(level);
    }
}
