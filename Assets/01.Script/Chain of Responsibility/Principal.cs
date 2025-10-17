using UnityEngine;

public class Principal : Handler
{
    public override void HandleRequest(int level)
    {
        if (level >= 3) Debug.Log("교장이 처리");
    }
}
