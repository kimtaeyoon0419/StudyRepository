using UnityEngine;

public class VicePrincipal : Handler
{
    public override void HandleRequest(int level)
    {
        if (level == 2) Debug.Log("교감이 처리");
        else nextHandler?.HandleRequest(level);
    }
}
