using UnityEngine;

public class PrototypeTest : MonoBehaviour
{
    private void Start()
    {
        ConcretePrototype original = new ConcretePrototype();
        original.data = 42;

        ConcretePrototype clone = (ConcretePrototype)original.Clone();

        Debug.Log("원본 값 : " + original.data);
        Debug.Log("복제 값 : " + clone.data);

        clone.data = 99;
        Debug.Log($"복제 값 수정 후 원본 값 : {original.data} / 복제 값 {clone.data}");
    }
}
