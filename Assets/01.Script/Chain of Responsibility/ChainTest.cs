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

        Debug.Log("������ �Ἦ�� ó�����ּ���!");
        teacher.HandleRequest(2); 
    }
}
