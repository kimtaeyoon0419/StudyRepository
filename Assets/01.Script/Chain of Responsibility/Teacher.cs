using UnityEngine;

public class Teacher : Handler
{
    public override void HandleRequest(int level)
    {
        if (level <= 1) Debug.Log("담임이 처리");
        else nextHandler?.HandleRequest(level);
    }
}
