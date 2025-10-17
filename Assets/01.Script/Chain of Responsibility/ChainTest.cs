using UnityEngine;

public class ChainTest : MonoBehaviour
{
    private void Start()
    {
        Handler teacher = new Teacher();
        Handler vice = new VicePrincipal();
        Handler principal = new Principal();    

        teacher.SetNext(vice);
        vice.SetNext(principal);

        Debug.Log("선생님 결석계 처리해주세요!");
        teacher.HandleRequest(2); 
    }
}
