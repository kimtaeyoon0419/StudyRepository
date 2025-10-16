using UnityEngine;

public class BridgeTest : MonoBehaviour
{
    private Weapon sword;
    private Weapon bow;
    private Weapon axe;

    private void Awake()
    {
        sword = new Sword();
        bow = new Bow();
        axe = new Axe();
    }

    private void Start()
    {
        Debug.Log("�� ����");
        sword.Equipment();
        Debug.Log("�� ����");
        sword.Attack();

        Debug.Log("Ȱ ����");
        bow.Equipment();
        Debug.Log("Ȱ ����");
        bow.Attack();
    }
}
