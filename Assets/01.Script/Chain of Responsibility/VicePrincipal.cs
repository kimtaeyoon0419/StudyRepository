using UnityEngine;

public class VicePrincipal : Handler
{
    public override void HandleRequest(int level)
    {
        if (level == 2) Debug.Log("������ ó��");
        else nextHandler?.HandleRequest(level);
    }
}
