using UnityEngine;

public class PrototypeTest : MonoBehaviour
{
    private void Start()
    {
        ConcretePrototype original = new ConcretePrototype();
        original.data = 42;

        ConcretePrototype clone = (ConcretePrototype)original.Clone();

        Debug.Log("���� �� : " + original.data);
        Debug.Log("���� �� : " + clone.data);

        clone.data = 99;
        Debug.Log($"���� �� ���� �� ���� �� : {original.data} / ���� �� {clone.data}");
    }
}
